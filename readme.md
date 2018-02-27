# Prérequis

* Installer Visual Studio Code
* Installer Dotnet core SDK & Runtime :
  https://www.microsoft.com/net/download/

# Préparatifs

`mkdir Isen.DotNet`  
`cd Isen.DotNet`  
`git init`  
`touch .gitignore`  
`touch readme.md`  
`code .`

# Création de l'espace de travail

## Création d'un projet console

Depuis le dossier Isen.DotNet :  
`mkdir Isen.DotNet.ConsoleApp`  
`cd Isen.DotNet.ConsoleApp`  
`dotnet new console`  
`dotnet run`

## Commit Git

Depuis la racine du projet :  
Etat des fichiers (non trackés) : `git status`  
Tracker les fichiers : `git add .`  
Ils sont maintenant suivis : `git status`  
Commit : `git commit -m "Initial commit"`  
Prendre en compte les modifs (mais pas les ajouts de fichiers) au moment du commit (donc faire un add et un commit en même temps) : `git commit -a -m "updated readme"`
