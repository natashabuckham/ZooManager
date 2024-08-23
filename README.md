# ZooManager

## Introduction
The is the API for the ZooManager Application.
Most of the endpoints are CRUD like.

The application is written in C# with .NET Core, and uses ASP.NET Core, Entity Framework Core and a SQLite Database.

## Getting started
Install the dependencies:
- dotnet add package Microsoft.EntityFrameworkCore
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite 
- dotnet add package Microsoft.EntityFrameworkCore.Relational
- dotnet add package Swashbuckle.AspNetCore
- dotnet add package Microsoft.AspNetCore.OpenApi (this should install together with Swashbuckle)

Trust the HTTPS development certificate by running the following command: dotnet dev-certs https --trust 
Select "Yes" in the window that pops up after this command.

Use command dotnet run to run the application. 
 
Accept any vulnerabilities when opening the localhost:5041.

Entity Framework will automatically generate the database for you, and it is populated in code.
If you need to trigger the database to be recreated, the easiest way is just to delete the `zoomanager.db` file.