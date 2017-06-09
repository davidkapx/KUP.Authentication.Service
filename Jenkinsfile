#!groovy

properties([
    disableConcurrentBuilds(),
    pipelineTriggers([[$class: 'GitHubPushTrigger'], pollSCM('')])
])

config = [:]
// docker configuration
config.dockerRepository = "nexushub.k8s.int.kaplan.edu:30904"
config.imageName = "kup.authentication.service"
// build configuration
config.startupProject = "KUP.Authentication.Api"
config.projectSln = "KUP.Authentication.Service.sln"
// sonarqube configuration
config.projectKey = "kup.authentication.service"
config.projectName = "KUP.Authentication.Service"

// build stages
// slackSend (color: 'warning', message: slackMessage("Build Started"), channel: "#sf-kup-builds")
// dockerBuild(config)
// slackSend (color: 'good', message: slackMessage("Build Successful"), channel: "#sf-kup-builds")

// code quality (sonar scanner) stages
slackSend (color: 'warning', message: slackMessage("SonarScanner Started"), channel: "#sf-kup-builds")
sonarScan(config)
slackSend (color: 'good', message: slackMessage("SonarScanner Finished"), channel: "#sf-kup-builds")    
