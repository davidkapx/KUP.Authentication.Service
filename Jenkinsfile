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
slackSend (color: 'warning', message: slackMsg("Build Started"), channel: "#sf-kup-builds")
try {
    dockerBuild(config)
} catch (e) {
    slackSend (color: 'danger', message: slackMsg("Build Failed"), channel: "#sf-kup-builds")
}
slackSend (color: 'good', message: slackMsg("Build Successful"), channel: "#sf-kup-builds")

// code quality (sonar scanner) stages
slackSend (color: 'warning', message: slackMsg("SonarScanner Started"), channel: "#sf-kup-builds")
try {
    sonarScan(config)
} catch (e) {
    slackSend (color: 'danger', message: slackMsg("SonarScanner Failed"), channel: "#sf-kup-builds")    
}
slackSend (color: 'good', message: slackMsg("SonarScanner Finished"), channel: "#sf-kup-builds")    
