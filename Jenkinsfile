pipeline {
    agent any
    triggers {
        pollSCM("* * * * *")
    }
    stages {
        stage("Build"){
            steps {
                echo "We are building"
                sh "dotnet build WebApi.csproj "
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
