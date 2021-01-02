<div align="center">

# Eau Claire's Salon

</div>

<div align="center">
<img src="https://github.com/agatakolohe.png" width="200px" height="auto" >
</div>
<h3 align="center">Database Basics with C#, MySQL & Entity, 12-28-2020</h3>
<h4 align="center"> By Agata Kolodziej</h4>

## Description

This is an MVC web application to help Claire(user) manage their employees (stylists) and the stylists' clients. The user should be able to add a list of stylists working at the salon, and for each stylist add clients who see that stylists. The stylists have specific specialities, so each client can only belong to a single stylist.

Production Database Name: agata_kolodziej
Exposted Database file: agata_kolodziej.sql
Main Project Folder: HairSalon

## User Stories

<details>
    <summary>Expand User Stories</summary>

- As the salon owner, I need to be able to see a list of all stylists.
- As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
- As the salon owner, I need to add new stylists to our system when they are hired.
- As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.

</details>

## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code
3. .NET or follow along with the Installing .NET instructions to install .NET

##### Open Locally

- Click on the link to my repository: [My Repository](https://github.com/agatakolohe/EauClaireSalon.Solution.git)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone REPO URL HERE` into the directory you would like to clone the repository
- Open in text editor to view code and make changes

##### Installing .NET

In order to run the application, please install .NET for your computer to recognize the `dotnet` command.

1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer). Clicking this link will prompt a file download for your particular OS from Microsoft.
2. Open the file. Follow the installation steps.
3. Confirm the installation is successful by opening your terminal and running the command `dotnet --version`. The response should be something similar to this:`2.2.105`. This means it was successfully installed.

##### Compiling

- Navigate to the HairSalon folder in the command line
- Use the command `dotnet build` to compile

##### Installing Packages

- Navigate to the HairSalon folder in the command line
- Use the command `dotnet restore`

##### View In Browser

- To view in browser, navigate to HairSalon folder in the command line.
- Use the command `dotnet run` to execute the compiled code and start a localhost.
- In browser navigate to http://localhost:5000

## Known Bugs

No known bugs present

## Support and Contact Details

If any errors or bugs occur with installation, delete both bin and obj folders and follow the Compiling and Installing Packages instructions again. Get help or report a bug you have found in the .NET platform at [.NET Support](https://dotnet.microsoft.com/platform/support). Or please email me, <agatakolohe@gmail.com>.

## Technologies Used

TODO

- .NET Core 2.2
- ASP.NET Core MVC
- Bootstrap
- C# 7.3
- CRUD
- CSS
- Entity
- GitHub
- HTML
- HTTP
- MySQLWorkbench
- Razor
- REPL
- RESTful Conventions
- VS Code

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2020 Agata Kolodziej
