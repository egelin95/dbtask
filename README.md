# DatabaseTask

This task is about using migrations in dotnet 6 framework with Entity Framework. Before using this project we will need to install:

## Requirements

1. [Dotnet 6 framework](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

2. [Dotnet EF tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)

Using the following command in command prompt we can install dotnet-ef tools. We are using the version `6.0.11` because that's the version used in this project.
```dotnet tool install --global dotnet-ef --version 6.0.11```

3. [MS SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
Use the developer edition

4. [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
We need this to view Database quickly, and create or modify any existing databases.

## Task 1
After installing everything, and assuming we have MS SQL Server running. 

### Creating an empty database `Asd1234`
1. Open SQL Management Studio and connect to the sql server running on your machine (if you installed it successfully, then it's already running and you will be able to select it)

2. Right click Databases, and create a database by the name `Asd1234` (because the project is configured to use this in `appsettings.json`)

### Run your code first migration to create the tables in the database
This step will help us create database tables automatically. The project already has a definition for a table called Employee, and a migration has already been created in the Migrations folder that will allow the entity framework to create the tables. Because we modified the database connection string in the `appsettings.json` and changed the server with a `.`, that will allow us to automatically connect to our sql server running on our machine. Now we can create the code first migration with following steps:

1. open command line (`window+run -> type cmd -> enter`)
2. navigate to `DatabaseTask\DatabaseTask` folder which is the root folder of our dot net web-app
3. type `dotnet clean` (this will help you check if all project requirements are properly installed on your machine, if everything work perfect, you will see some Green text)
4. run the database update command to create the tables with command line `dotnet ef database update`

5. check in sql management studio if the tables are visible
Go to MS Sql Server Management Studio, and right click on your database `Asd1234` and click refresh (this will load any new changes on your table).
