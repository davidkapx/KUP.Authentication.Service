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
        def dockerRepository = "nexushub.kaplan.edu:30904"
        def imageName = "kup.authentication.service"
        def imageTag = "${dockerRepository}/${imageName}:${branch}"

        stage('Checkout'){
            step([$class: 'GitHubSetCommitStatusBuilder'])
            
            dir('KUP.Framework'){
                git branch: 'master', url: 'https://kss-github.kaplan.com/rblaise/KUP.Framework.git', credentialsId: '73d98908-f7d7-42f6-80e7-b02171167482'
            }
            
            dir('KUP.Authentication.Service'){
                checkout scm
            }  
        }
        stage('Build Project'){
            sh 'docker run -t --rm -v $(pwd):/app:rw -w /app/KUP.Authentication.Service/KUP.Authentication.Api microsoft/aspnetcore-build:1.1 bash -c \'dotnet restore && dotnet publish -c Release -o /app/out\''
        }
        
        stage('Build Image'){
            sh "docker build -t ${imageTag} -f KUP.Authentication.Service/KUP.Authentication.Api/Dockerfile --build-arg source=out ."
        }
        
        stage('Publish Image'){
            withCredentials([
                [$class: 'UsernamePasswordMultiBinding', credentialsId: 'kup-builds-nexus', usernameVariable: 'USERNAME', passwordVariable: 'PASSWORD']]) {
                    sh 'docker login nexushub.kaplan.edu:30904 -u="$USERNAME" -p="$PASSWORD"'
                    sh "docker push ${imageTag}"
            }
        }
        notifySuccessful()
        
    } catch (e) {
        notifyFailed()
    }
}

def notifyStarted() {
    notifySlack('#FFFF00', "Build Started: Job '${env.JOB_NAME} [${env.BUILD_NUMBER}]' (${env.BUILD_URL})")
}

def notifySuccessful() {
    notifySlack('#00FF00', "Build Successful: Job '${env.JOB_NAME} [${env.BUILD_NUMBER}]' (${env.BUILD_URL})")
}

def notifyFailed() {
    notifySlack('#FF0000', "Build Failed: Job '${env.JOB_NAME} [${env.BUILD_NUMBER}]' (${env.BUILD_URL})")
}

def notifySlack(color, message) {
    withCredentials([
        [$class: 'StringBinding', credentialsId: 'kup-builds-slack',
        variable: 'KUP_SLACK_TOKEN']
    ],
    body)
    slackSend (
        color: color, 
        message: message,
        channel: "#sf-kup-builds", 
        teamDomain: "kaplanhighereducation",
        token: env.KUP_SLACK_TOKEN
    )
}
