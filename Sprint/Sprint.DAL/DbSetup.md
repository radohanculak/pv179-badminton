# Sprint database setup:

- Install EF Core - SQLite version

```console
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
```

- Apply migration

```console
dotnet ef database update
```
