# TODO list TP

Un TP simple pour découvrir les APIs REST avec .NET Core

## Etapes de démarrage
Les fichiers existent et sont à compléter:

* Créer la classe Models.TODO
* Créer l'interface Data.ITodoRepository
* Créer la classe Data.TodoRepository qui implémente Data.ITodoRepository
* Compléter le contrôleur MVC API Controllers.TodoController

## Etapes suivantes
* Ajouter une seconde propriété date de création au modèle Todo, renseigner cette propriété à l'ajout d'un nouvel élément dans le contrôleur, puis l'afficher côté client
* Créer un projet de test unitaire avec "dotnet new -t xunit", tester le repository, exécuter le test avec "dotnet test"
* Installer SQLite ou  MySQL, utiliser Entity Framework pour créer un dbContext et déployer le modèle en base (code first), et persister vos données. Les namespaces à référencer sont:
    * Microsoft.EntityFrameworkCore
    * Microsoft.EntityFrameworkCore.Sqlite
    * Microsoft.EntityFrameworkCore.Design
* Installer Docker (uniquement sur MacOSX et Linux)

# Points d'attention
* Startup.cs : regarder comment le service TodoRepository est déclaré pour l'injection de dépendance
* Regarder évidemment son cycle de vie (options: Transient, Singleton, Scoped). Quelle différence entre ces cycles de vie ?

# Contactez-nous

http://www.c17e.com/index.php/blog/

https://twitter.com/PMurasso
