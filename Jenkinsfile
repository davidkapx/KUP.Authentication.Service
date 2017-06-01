#!groovy

properties([
    disableConcurrentBuilds(),
    pipelineTriggers([[$class: 'GitHubPushTrigger'], pollSCM('')])
])

node('LinuxBuild') {

    notifyStarted()
    
    try {
        def branch = env.BRANCH_NAME
        if (branch == 'master'){
            branch = 'latest'
        }
        def dockerRepository = "nexushub.k8s.int.kaplan.edu:30904"
        def imageName = "kup.authentication.service"
        def imageTag = "${dockerRepository}/${imageName}:${branch}"

        stage('Checkout'){
            checkout scm
        }
        stage('Build Project'){
            sh """
                docker run -t --rm -v \$(pwd):/app:rw -w /app/KUP.Authentication.Api microsoft/aspnetcore-build:1.1 bash -c '\
                    curl -O http://gt.symcb.com/gt.crt
                    openssl x509 -inform DER -in gt.crt -out /usr/local/share/ca-certificates/gt.crt
                    update-ca-certificates
                    dotnet restore
                    dotnet publish -c Release -o /app/out'
            """
        }
        
        stage('Build Image'){
            sh "docker build -t ${imageTag} -f KUP.Authentication.Api/Dockerfile --build-arg source=out ."
        }
        
        stage('Publish Image'){
            withCredentials([
                [$class: 'UsernamePasswordMultiBinding', credentialsId: 'kup-builds-nexus', usernameVariable: 'USERNAME', passwordVariable: 'PASSWORD']]) {
                    sh 'docker login nexushub.k8s.int.kaplan.edu:30904 -u="$USERNAME" -p="$PASSWORD"'
                    sh "docker push ${imageTag}"
            }
        }
        notifySuccessful()
        
    } catch (e) {
        notifyFailed()
    }
}

def notifyStarted() {
    notifySlack('warning', "Build Started: Job '${env.JOB_NAME} [${env.BUILD_NUMBER}]' (${env.BUILD_URL})")
}

def notifySuccessful() {
    notifySlack('good', "Build Successful: Job '${env.JOB_NAME} [${env.BUILD_NUMBER}]' (${env.BUILD_URL})")
}

def notifyFailed() {
    notifySlack('danger', "Build Failed: Job '${env.JOB_NAME} [${env.BUILD_NUMBER}]' (${env.BUILD_URL})")
}

def notifySlack(color, message) {
    withCredentials([
        [$class: 'StringBinding', credentialsId: 'kup-builds-slack',
        variable: 'KUP_SLACK_TOKEN']]) {
            slackSend (
                color: color, 
                message: message,
                channel: "#sf-kup-builds", 
                teamDomain: "kaplanhighereducation",
                token: env.KUP_SLACK_TOKEN
            )
    }
}

node('windows') {
    def branch = env.BRANCH_NAME
    if (branch == 'master'){
        stage('SonarQube Analysis') {
            dir('KUP.Framework'){
                git branch: 'master', url: 'https://kss-github.kaplan.com/rblaise/KUP.Framework.git', credentialsId: '73d98908-f7d7-42f6-80e7-b02171167482'
            }
            
            dir('KUP.Authentication.Service'){
                git branch: 'master', url: 'https://kss-github.kaplan.com/rblaise/KUP.Authentication.Service.git', credentialsId: '73d98908-f7d7-42f6-80e7-b02171167482'
            }
            
            def sqScannerMsBuildHome = "\"%programfiles%\"\\sonar-scanner-msbuild"
            withSonarQubeEnv('kaplan') {
                dir('KUP.Authentication.Service'){
                    withEnv(['MSBuildSDKsPath=C:\\Program Files\\dotnet\\sdk\\1.0.4\\Sdks']) {
                        bat "${sqScannerMsBuildHome}\\SonarQube.Scanner.MSBuild.exe begin /k:kup.authentication.service /n:KUP.Authentication.Service /v:1.0 /d:sonar.host.url=%SONAR_HOST_URL% /d:sonar.login=%SONAR_AUTH_TOKEN%"
                        bat "dotnet restore KUP.Authentication.Api"
                        bat "del docker-compose.dcproj"
                        bat "\"%MSBUILD15%\\MSBuild.exe\" KUP.Authentication.Service.sln /t:Rebuild"
                        bat "${sqScannerMsBuildHome}\\SonarQube.Scanner.MSBuild.exe end"
                    }
                }
            }   
        }
    }    
}