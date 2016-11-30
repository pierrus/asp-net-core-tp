# TODO list TP

Un TP simple pour découvrir les APIs REST avec .NET Core

## Etapes principales
* Créer la classe Models.TODO
* Créer l'interface ITodoRepository
* Créer la classe TodoRepository qui implémente ITodoRepository
* Compléter le contrôleur MVC API Controllers.TodoController

## Etapes bonus
* Ajouter une seconde propriété date de création au modèle Todo, renseigner cette propriété à l'ajout d'un nouvel élément dans le contrôleur, puis l'afficher côté client
* Créer un projet de test unitaire, tester le repository, exécuter le test avec "dotnet test"
* Installer SQLite ou  MySQL, utilise Entity Framework pour déployer le modèle en base, et persister vos données

# Point d'attention

* Startup.cs : regarder comment le service TodoRepository est déclaré pour l'injection de dépendance
* Regarder évidemment son cycle de vie (options: Transient, Singleton, Scoped). Quelle différence entre ces cycles de vie ?