pipeline {
    agent any
    stages {
        stage('build') {
            steps {
                sh 'python --version'
            }
        }
        stage("Using env vars") {
            step {
            echo "BUILD_NUMBER = ${env.BUILD_NUMBER}"
            sh 'echo BUILD_NUMBER = $BUILD_NUMBER'
            }
        }
    }
}