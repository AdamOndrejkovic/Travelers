pipeline {
    agent any
    triggers {
        pollSCM("* * * * *")
    }
    environment {
        COMMITMSG = sh(returnStdout: true, script: "git log -1 --oneline")
    }
    stages {
        stage("Start up"){
            buildDescription env.COMMITMSG
        }
        stage("Build"){
            steps {
                echo "We are building"
                sh "dotnet build WebApi/WebApi.csproj"
            }
        }
        stage("Test"){
            steps {
                echo "We are testing"
                sh "dotnet add package coverlet.collector"
                sh "dotnet test --collect:'XPlat Code Coverage'"
            }
            post {
                success {
                    archiveArtifacts "Domain.Test/TestResults/*/"
                    archiveArtifacts "Core.Test/TestResults/*/"
                }
            }
        }
        stage("Deploy"){
            steps {
                 echo "We are deploying"
            }
        }
    }
}
