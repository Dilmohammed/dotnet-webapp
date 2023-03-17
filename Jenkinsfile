pipeline {
    agent any

    stages {
        stage('Github checkout') {
            steps {
                git branch: 'main', url: 'https://github.com/arjunans/dotnet-webapp.git'
            }
        }
        stage('Nuget Restore') {
            steps {
               dotnetRestore project: 'Dotnet-webapp', sdk: '.net 7'
        }
        stage('Build .Net') {
            steps {
                dotnetBuild configuration: 'Release', project: 'Dotnet-webapp.sln', target: 'Build'
            }
        }
        stage('Test') {
            steps {
                dotnetTest project: 'Dotnet-tests'
            }
        }
        stage('Publish .Net') {
            steps {
                dotnetPublish configuration: 'Release', project: 'Dotnet-webapp'
            }
        }
    }
}
