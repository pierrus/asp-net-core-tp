rm -r build
dotnet restore ../src/todo
dotnet publish ../src/todo -o ../../docker/build