
# _Pierre's Bakery_

#### _Test-Driven Development With C# Project, July 17, 2020_

#### By _**Joseph Pearce**_

## Description

_A project to introduce the C# language and the .NET Core framework. Create a Bakery application with the following functionality._

### Specs

There should be two classes: one for Bread and one for Pastry.

When the user runs the application, they should receive a prompt with a welcome message along with the cost for both Bread and Pastry.

A user should be able to specify how many loaves of Bread and how many Pastrys they'd like.

The application will return the total cost of the order.

Pierre offers the following deals:

- Bread: Buy 2, get 1 free. A single loaf costs $5.
- Pastry: Buy 1 for $2 or 3 for $5.


| Behavior | Input | Output |
| -------- | ----- | ------ |
|    Welcome message   |  nada  |  nada | 
|    Specials message  |  nada  |  nada | 
|    How many loafs of Bread?   |  1  |  $5 | 
|    How many loafs of Bread?   |  2  |  $5 | 
|    How many loafs of Bread?   |  3  |  $10 | 
|    How many loafs of Bread?   |  4  |  $10 | 
|    How many Pastries?   |  1  |  $2 | 
|    How many Pastries?   |  2  |  $4 | 
|    How many Pastries?   |  3  |  $5 | 
|    How many Pastries?   |  4  |  $7 | 
|    Wait, that not all!   |   |   | 
|    Order 2 loaves of bread & 1 pastry   | 2,1  | $12 | 
|   Don't leave, Stay awhile.  Breath into the nostrils of the code, it's soothing.    |   |   | 
|   Just kidding,  Get out of here!   |   |   | 


## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the command dotnet build.

## Known Bugs

There are no known bugs at the time of this update.
 
## Technologies Used

* C#
* .NET Core
* Git and GitHub


### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Joseph Pearce_**