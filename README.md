#### By _**Megan McKissack**_

## Description

This is an mvc application for a business to track vendors and orders. It utilizes the mvc pattern of multiple models, controllers, and views and RESTful routing conventions.

## Technologies Used

- _C#_
- _.NET 5_
- _MSTest_
- _ASP.NET Core_
- _HTML_
- _CSS_

## Setup/Installation Requirements

- using your terminal, clone or download this repository to your computer
- install the [.NET 5 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/5.0) to have access to the C# language if you don't already have it installed
- you'll also need to install the dotnet script in your terminal using the command `dotnet tool install -g dotnet-script` and configure your bash enviroment variables using the command `echo 'export PATH=$PATH:~/.dotnet/tools' >> ~/.bash_profile` or `echo 'export PATH=$PATH:~/.dotnet/tools' >> ~/.zshrc` if your using zsh instead of bash
- Open files in your favorite text editor or IDE
- cd into the BakeryOrderTracker.Solution/BakeryOrderTracker folder and run the command `dotnet restore` to install the necessary packages to run the program
  - repeat this process for the BakeryOrderTracker.Solution/BakeryOrderTracker.Tests folder as well to install the necessary testing packages
- To view and use the application, navigate to the BakeryOrderTracker folder and use the command `dotnet run` to start your local server and navigate to [http://localhost:5000](http://localhost:5000) in your web browser and interact with the application
- To test run unit tests on the application, navigate to the BakeryOrderTracker.Tests folder and run the command `dotnet test`

## Known Bugs

_none_

## License

_MIT_

Copyright (c) _July 16, 2022_ _Megan McKissack_
