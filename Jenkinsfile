pipeline{
agent any
environment {
        dotnet ='/usr/bin/dotnet'
        }
stages {
        stage('Checkout') {
            steps {
                git url: 'https://github.com/ruder-pratap/devopsdemo.git', branch: 'master'
            }
        }
        stage('Restore Packages') {
            steps {
                  sh "dotnet restore"
            }
        }
        stage('Clean') {
            steps {
                  sh "dotnet clean"
            }
        }
        stage('Build') {
            steps {
                  sh "dotnet build --configuration Release"
            }
        }
        stage('Docker Images') {
            steps {
                  sh "docker build -t ezcoderz/portalapi:1.0.6 ."
            }
        }
        stage("Docker push") {
            steps{
                    sh "docker login -u ezcoderz -pPankaj@123"
                    sh "docker push ezcoderz/portalapi:1.0.6"
                
            }
        }
         stage("Deploy") {
            steps{
              sh 'ssh  -o StrictHostKeyChecking=no  ezcoderz@192.168.56.105 "docker run --name portalapi -p 56562:80 --rm -d ezcoderz/portalapi:1.0.6"'
            }
        }
    }
}
    

