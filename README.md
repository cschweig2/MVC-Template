# Bakery

#### Independent Code Review, Last Updated 01.07.2021

#### **By Chelsea Becker**

## Description

_Bakery is a program that allows the user to view the cost of pastries and bread sold at the bakery, place an order, and then view their total cost for the order. There are deals available for the customer, such as "buy 2 for $8" for bread, and "buy 2 for $3" for pastries._

## Specifications

<table>
<tr>
  <th>User Story #</th>
  <th>User Story</th>
  <th>Actualized</th>
</tr>
<tr>
  <td>1</td>
  <td>As a ___, I want to be able to ____ so that I can ____."</td>
  <td>True</td>
</tr>
</table>
<br>

## Setup/Installation Requirements

### Installing .NET Core Framework for Windows(10+) Users

1. _Download the 64-bit .NET Core SDK (Software Development Kit) by following this link: https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer._<br>
1a. _Follow prompts to begin your download. The download will be a .exe file. Click to install when it is finished downloading._
2. _After clicking the downloaded .exe file, follow the prompts in the installer and use suggested default settings._
3. _You can confirm a successful installation by opening a command line terminal and running the command $ dotnet --version, which should return a version number._


### Installing .NET Core Framework for Mac Users

1. _Download the .NET Core SDK by following this link: https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer._<br>
1a. _Follow prompts to begin your download. The download will be a .pkg file. Click to install when it is finished downloading._
2. _After clicking the downloaded .pkg file, follow the prompts in the installer and use suggested default settings._
3. _You can confirm a successful installation by opening a command line terminal and running the command $ dotnet --version, which should return a version number._


### View locally/Project Setup

#### Clone
1. _Follow above steps to install .NET Core._
2. _Open web browser and go to https://github.com/cschweig2/Bakery.Solution._
3. _After clicking the green "code" button, you can copy the URL for the repository._
4. _Open a terminal window, such as Command Prompt or Git Bash._<br>
  4a. _Type in this command: "git clone", followed by the URL you just copied. The full command should look like this: "git clone https://github.com/cschweig2/Bakery.Solution"._
5. _View the code on your favorite text editor, such as Visual Studio Code._

#### Import Database in MySQL Workbench
1. _Open MySQL Workbench and enter your password to open a server._
2. _From the top navigation bar, follow:_ ```Server > Data Import```.
4. _Select the option_ `Import from Self-Contained File`.
5. _Set_ `Default Target Schema` _or create new schema._
6. _Select the schema objects you would like to import_
7. _To finalize, click_ `Start Import`.

#### Import Database with SQL Schema

_Open MySQL Workbench and paste the following Schema Create Statement to replicate the database and its tables._

//TODO need to place schema here

#### Final Steps
1. _Navigate to the Bakery and Bakery.Tests folders and enter "dotnet restore" in the command line to install packages._
2._After packages are installed in each of these folders, you may use "dotnet run" to both run and build the program._

## Known Bugs

No known bugs at this time.

## Test Specs

<table>
  <tr>
    <th>Test #</th>
    <th>Expected Behavior</th>
    <th>Input</th>
    <th>Output</th>
  </tr>
  <tr>
    <td>1</td>
    <td>Create a Bread class</td>
    <td>Bread bread = new Bread();</td>
    <td>bread</td>
  </tr>
</table>
<br>


## Support and contact details

_If you run into any issues, you can contact the creator at chelraebecker@gmail.com, or make contributions to the code on GitHub via forking and creating a new branch._

## Contributors

<table>
  <tr>
    <th>Author</th>
    <th>GitHub Profile</th>
    <th>Contact Email</th>
  </tr>
  <tr>
    <td>Chelsea Becker</td>
    <td>https://github.com/cschweig2</td>
    <td>chelraebecker@gmail.com</td>
  </tr>
</table>

## Technologies Used

_VS Code_ <br>
_C# 7.3.0_<br>
_.NET Core 2.2.0_<br>
_ASP.NET Core MVC_<br>
_Entity Framework Core 2.2.6_<br>
_MySQL Workbench 8.0 for Windows_

## Legal

*This software is licensed under the MIT license.*

Copyright (c) 2020 **Chelsea Becker**