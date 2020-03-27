# [TreatTracker](https://github.com/ayohana/TreatTracker.git/)

#### C# Advanced Databases and Authentication Exercise for [Epicodus](https://www.epicodus.com/), 03.27.2020

#### By [**Adela Darmansyah**](https://ayohana.github.io/portfolio/)

## Description

**This is a web application for Della's Bakery to keep track of their sweet and savory treats provided a user authentication.** Della will be able to create an account and log in to use the application. Once logged in, she will be able to enter her treats (e.g. chocolate croissants) and their flavors (e.g. sweet). Per Della's request, the application will list all treats and flavors. She will be able to see the details of an individual treat to see all the flavors that belong to it and vice versa.

## User Stories

* As the bakery owner, I need to be able to see a list of all my treats.
* As the bakery owner, I need to be able to add flavors belonging to a treat and vice versa.
* As the bakery owner, I need to be able to select a treat, see their details and see a list of flavors that belong to that treat.
* As the bakery owner, I also need to be able to select a flavor and see a list of treats that belong to that flavor.
* As the developer, I need to establish many-to-many relationship between `Treats` and `Flavors` so that I can fulfil my client's request.

## Parking Lot

* Add a 3rd class of Ingredients (many-to-many relationship between Treats & Ingredients) to sort list/provide allergy warning.

## Specs

<details>
  <summary>Click to expand!</summary>

| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **The application will ask for user authentication prior to using the application.** | Log in | Welcome message and Log In form |
| **The application displays a message when there are no treats/flavors saved in the database.** | Treats/Flavors page | "No treats/flavors added yet." |
| **The application displays a splash page that lists all treats and flavors.** | Treats/Flavors page | List of all treats and flavors |
| **The application will provide links to add a new treat/flavor** | Treats/Flavors page | Displays a form to fill out a new treat/flavor |
| **The user clicks on a flavor and the application will display details of that flavor** | `Click:` "Sweet" | "Chocolate croissants, cupcakes, lollipops" |

</details>

## Setup/Installation Requirements

* Download [.NET Core](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) (Mac/Windows OS) - _FREE!_
* Download [MySQL](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) (Mac/Windows OS) - _FREE!_
* Clone this [repository](https://github.com/ayohana/TreatTracker.git/)
* Run the application.
  * Navigate into the `TreatTracker` directory `$ cd Desktop/TreatTracker/TreatTracker.Solution/TreatTracker`
    * Enter the command `dotnet restore` to gather tools and dependencies for the application.
    * Enter the command `dotnet build` to build the project using its dependencies.
    * Enter the command `dotnet ef database update` to create a new, empty database. 
    * Enter `dotnet run` to run the application.

## Known Bugs

No known bugs at this time.

## Support and contact details

Feel free to provide feedback via email: adela.yohana@gmail.com.

## Technologies Used

* C#
* MVC Pattern
* [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/) (Windows OS)
* [MySQL](https://dev.mysql.com/downloads/file/?id=484919) (Windows OS)
* [EF Core](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql)

### License

This C# console application is licensed under the MIT license.

Copyright (c) 2020 **Adela Darmansyah**
