pipeline {
    agent any
    triggers {
        pollSCM("* * * * *")
    }
    stages {
        stage("Build"){
            steps {
                echo "We are building"
            }
        }
        stage("Test"){
            steps {
                echo "We are testing"
            }
        }
        stage("Deploy"){
            steps {
                 echo "We are deploying"
            }
        }
    }
}
