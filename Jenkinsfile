#!groovy

properties([
    disableConcurrentBuilds(),
    pipelineTriggers([[$class: 'GitHubPushTrigger'], pollSCM('')])
])

config = [
    // docker configuration
    dockerRepository: "nexushub.k8s.int.kaplan.edu:30904",
    imageName: "kup.authentication.service",
    // build configuration
    startupProject: "KUP.Authentication.Api",
    projectSln: "KUP.Authentication.Service.sln",
    // sonarqube configuration
    projectKey: "kup.authentication.service",
    projectName: "KUP.Authentication.Service",
    // slack notifications channel
    slackChannel: "#sf-kup-builds"
]

node ('LinuxBuild'){
    sh 'env'
}

if (env.BRANCH_NAME.startsWith('PR-')) {
    node('windows'){
        checkout scm

        def prNum = env.BRANCH_NAME.replace('PR-', '')

        slackSend (color: 'warning', message: slackMessage("SonarScanner Started"), channel: config.slackChannel)
        try {
            stage('Checking Code Quality') {
                withSonarQubeEnv('kaplan') {
                    withEnv(['MSBuildSDKsPath=C:\\Program Files\\dotnet\\sdk\\1.0.4\\Sdks']) {
                        bat """
                            \"%SONAR_SCANNER_MSBUILD%\"\\SonarQube.Scanner.MSBuild.exe begin ^
                            /k:${config.projectKey} /n:${config.projectName} /v:1.0 ^
                            /d:sonar.host.url=%SONAR_HOST_URL% ^
                            /d:sonar.login=%SONAR_AUTH_TOKEN% ^
                            /d:sonar.analysis.mode=preview  ^
                            /d:sonar.github.endpoint='https://kss-github.kaplan.com/api/v3' ^
                            /d:sonar.github.pullRequest=$prNum ^
                            /d:sonar.github.repository=Kaplan/KUP.Authentication.Service ^
                            /d:sonar.github.oauth=faaedfc158e41493194e7a28b5dfdf07a006ea79
                            """
                        bat "dotnet restore ${config.projectSln}"
                        bat "del docker-compose.dcproj"
                        bat "\"%MSBUILD15%\\MSBuild.exe\" ${config.projectSln} /t:Rebuild"
                        bat "\"%SONAR_SCANNER_MSBUILD%\"\\SonarQube.Scanner.MSBuild.exe end"
                    }
                }   
            }
        } catch (e) {
            slackSend (color: 'danger', message: slackMessage("SonarScanner Failed"), channel: config.slackChannel)    
        }
        slackSend (color: 'good', message: slackMessage("SonarScanner Finished"), channel: config.slackChannel)    
    }
} 

// build & publish docker image
// dockerBuild(config)

// code quality (sonar scanner) stages
// sonarScan(config)

// confirm it's working