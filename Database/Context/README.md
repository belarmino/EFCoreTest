## Create a console project
```
dotnet run
```
# To create a new project
## Create a console project
```
dotnet new console -o EFCoreTest
cd EFCoreTest
dotnet new gitignore
```

## EF tools
```
dotnet tool install --global dotnet-ef
```
## add EF library
```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
```

## Create and apply migration
```
dotnet ef migrations add Category
dotnet ef database update
```