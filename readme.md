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
Prendre en compte les modifs (**mais pas les ajouts de fichiers**) au moment du commit (donc faire un add et un commit en même temps) : `git commit -a -m "updated readme"`

## Création d'un projet librairie

Depuis le dossier Isen.DotNet :  
`mkdir Isen.DotNet.Library`  
`cd Isen.DotNet.Library`  
`dotnet new classlib`

## Ajout de la librairie en référence du projet console

Depuis le dossier du projet Console :  
`dotnet add reference ..\Isen.DotNet.Library\Isen.DotNet.Library.csproj`  
Coder la classe Hello.  
Dans le Program.cs, ajouter le using, et appeler la classe Hello.

## Création d'une solution et ajout des projets

Depuis le dossier racine :  
Créer le fichier solution : `dotnet new sln`  
Ajouter le projet librairie : `dotnet sln add .\Isen.DotNet.Library\Isen.DotNet.Library.csproj`
Ajouter le projet console : `dotnet sln add .\Isen.DotNet.ConsoleApp\Isen.DotNet.ConsoleApp.csproj`  
Commit git :  
`git add .`  
`git commit -m "Console, lib, solution"`
