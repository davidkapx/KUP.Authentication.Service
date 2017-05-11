#!groovy

properties([
    disableConcurrentBuilds(),
    pipelineTriggers([[$class: 'GitHubPushTrigger'], pollSCM('')])
])

node('LinuxBuild') {

    def branch = env.BRANCH_NAME
    def dockerHost = "nexushub.kaplan.edu:18079"
    def dockerRepository = "studenthome"
    def imageName = "${dockerHost}/${dockerRepository}:${branch}"

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
        sh 'docker run -t --rm -v $(pwd):/app:rw -w /app/KUP.Authentication.Service microsoft/aspnetcore-build:1.1 bash -c \'dotnet restore && dotnet publish -c Release -o /app/out\''
    }
    
    stage('Build Image'){
        sh "docker build -t ${imageName} -f KUP.Authentication.Service/KUP.Authentication.Api/Dockerfile --build-arg source=out ."
    }
    
    stage('Publish Image'){
        sh "docker login ${dockerHost} -u=dcruz -p=K@plan!Hub"
        sh "docker push ${imageName}"
    }
}