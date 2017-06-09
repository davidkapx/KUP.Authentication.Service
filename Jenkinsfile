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
    projectKey: "kup.authentication.service"
    projectName: "KUP.Authentication.Service"
    // slack notifications channel
    slackChannel: "#sf-kup-builds"
]

// build & publish docker image
dockerBuild(config)

// code quality (sonar scanner) stages
sonarScan(config)