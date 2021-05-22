# Eau Claire's Salon

#### _C# Week 3 Project, 5/21/2021_

#### By _**Marney Mallory**_

## Description

For week 3 of C#, we were required to create a MVC web application that enables a hair salon owner to keep track of her stylists and their clients. 

## Project Objectives 

- Follow proper .NET naming conventions.
- Clear instructions for recreating database.
- Correct setup of one-to-many relationship  within database.
- Entity is used for communication with database.
- Demonstrates use of CREATE functionality for one class and CREATE and VIEW functionality for the other class. 

## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to run and interact with the console app.
- [MySQL Community Server][https://dev.mysql.com/downloads/file/?id=484914]

### Installation

1. Clone the repository: `$ git clone https://github.com/marneymallory/HairSalon.Solution.git`
2. Navigate to the `HairSalon.Solution` directory on your computer
3. Open with your preferred text editor to view the code base
4. To setup a SQL database using MySQL:
   - Create an `appsettings.json` file in the `HairSalon.Solution` directory
   - Copy the text box below and paste into the `appsettings.json` file, replacing `<password>` with your MySQL password:
   ```
     {
        "ConnectionStrings": {
           "DefaultConnection": "Server=localhost;Port=3306;database=tiffany_greathead;uid=root;pwd=<password>;"
         }
     }
   ```
   - Open your terminal and run the command: `mysql -uroot -p<password>` (replace `<password>` with your MySQL password) and select the enter key to launch MySQL servers
   - Type the following commands to setup the database:
     - `CREATE DATABASE marney_mallory;` to make a new database
     - `USE marney_mallory;` to connect to the new database
     - `CREATE TABLE Stylists(StylistId INT, Name VARCHAR (255), Description VARCHAR (255), Specialty VARCHAR (255))};` to create a `Stylists` table
     - `CREATE TABLE Clients (ClientId INT, StylistId INT, Name VARCHAR (255), Number VARCHAR (255), Preferences VARCHAR (255)};` to create another new `Clients` table
5. To run the console app:
   - Navigate to `HairSalon.Solution/HairSalon}` in your command line
   - Run the command `dotnet restore` to restore the dependencies that are listed in `HairSalon.csproj`
   - Run the command `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
   - Run the command `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
   - Run the command `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`
   - Run the command `dotnet build` to build the project and its dependencies into a set of binaries
   - Finally, run the command `dotnet run` to run the project!
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
6. Visit the application via web browser at: `localhost:5000/`

## Known Bugs

_No known bugs_

## Support and contact details

_Please reach out through my GitHub account._

## Technologies Used

- C#
- .NET 5 SDK
- ASP.NET
- Entity Framework Core
- Bootstrap

### License

MIT License.

Copyright (c) 2021 **_Marney Mallory_**
