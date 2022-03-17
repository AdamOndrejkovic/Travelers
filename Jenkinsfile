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
            steps {
                buildDescription env.COMMITMSG
            }
        }
        stage("Build"){
            steps {
                echo "We are building"
                sh "dotnet build WebApi/WebApi.csproj"
            }
        }
        stage("Test"){
            steps {
                    dir("Core.Test") {
                        sh "dotnet add package coverlet.collector"
                        sh "dotnet test --collect:'XPlat Code Coverage'"
                    }
                }
                post {
                    success {
                        publishCoverage adapters: [coberturaAdapter('Core.Test/TestResults/*/coverage.cobertura.xml')], sourceFileResolver: sourceFiles('NEVER_STORE')
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
