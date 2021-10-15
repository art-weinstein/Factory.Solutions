# Sillystringz's Factory

### By Art Weinstein

### A basic webpage created to test student knowledge on building websites wtih many-to-many relationships.

## Technologies Used

* HTML
* CSS
* C#
* ASP.NET Core MVC
* NuGet
* MySql WorkBench
* Entity Framework Core

## Description

This program allows a user to create machines and hire engineers. Each catagory (machines and engineers) has pages that allow the user to view object details, create more objects, edit objects, and view a list of each object type in an index page. The user can delete objects from each respective category; such as deleting one or more engineers from a single machine or deleting one more machines from a single engineer. The splash page (home page) allows the user to select which category they would like to modify, being machines or engineers. 

## Setup/Installation Requirements

1. [Clone](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository-from-github/cloning-a-repository) this repository.
2. Within VS code or similar software, create an "appsettings.json file with the "Factory" directory.
3. Within the appsettings.json file copy the following code and replace "EXAMPLE_PASSWORD" with your SQL workbench password.
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=art_weinstein;uid=root;pwd=EXAMPLE_PASSWORD;"
  }
}
```

4. Install the necessary dependencies:
- Open a powershell terminal and navigate to the HairSalon directory.
- type ```dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0```
- type ```dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2```
- type ```dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0 ```
6. enter ```dotnet build``` in your powershell terminal to build the program and verify the code is running correctly.
7. enter ```dotnet ef migrations add Initial``` in your powershell terminal to build your database (note MySQLWorkbench 8.0 CE must be installed).
8. enter ```dotnet ef database update``` to populate your database with the necessary tables.
9. enter ```dotnet watch run``` to create a localhost in your browser and view the program. 

## Known Bugs

* No bugs known at the moment.

## License

* [MIT License](https://opensource.org/licenses/MIT)

Copyright (c) 2021 Art Weinstein

## Contact Information

[Email](artur.weintsein@gmail.com)