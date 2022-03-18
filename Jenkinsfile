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
                discordSend description: "Jenkins Pipeline Start", footer: "Begin", link: env.Build_URL, webhookURL: 'https://discord.com/api/webhooks/951842111462981632/VgXVmyphYbRqnRZ3Q2NAvvo0PIT7v07GHz6usJ8DIXUt0VY4OP937ZaWn_idF5R-abtw'
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
    post {
        always {
            sh "echo 'Pipeline finished!'"
            discordSend description: "Jenkins Pipeline Start", footer: "Begin", link: env.Build_URL, result: currentBuild.currentResult, title: JOB_NAME, webhookURL: ''
        }
    }
}
