# TODO list TP

## La version finale du TP

* Pattern repository
* SQLLite
* Tests unitaires
* Docker

## Instructions
* Exécution simple:  dotnet run dans src/todo
* Docker (dans docker/):
    * ./build.sh (pour compiler et mettre les binaires dans docker/build)
    * docker build . -t todo-sqllite
    * docker run --name todo-sqllite -p 5000:80 -d todo-sqllite
    * docker stop todo-sqllite
    * docker start todo-sqllite