# Personal Portfolio
### A simple personal portfolio to showcase achievements and projects.

This is a simple personal portfolio.  It will showcase achievements and projects.  It has been built using C# and .NET.


## Getting Started & Requirements
* Required software:
	* Browser
	* MAMP
	* Terminal interface
	* Familiarity with dotnet & git commands is helpful, but not required!

In your terminal, clone the repo from GitHub (Alternatively [Click Here](https://github.com/johnnymayer/PersonalPortfolio/archive/master.zip) to download a zip directly from the repo).

```
$git clone https://github.com/johnnymayer/personalportfolio
```

Navigate to the cloned directory:

```
$cd personalportfolio
```

Navigate to the PersonalPortfolio directory:

```
$cd PersonalPortfolio
```

Run a dotnet restore to restore files post download:

```
$dotnet restore
```

Start your MAMP servers, making sure the MySQL port is set to 8889.
Create Database via dotnet migrations:

```
$dotnet ef migrations add Initial
```

And then update the database:

```
$dotnet ef database update
```

Build the project:

```
$dotnet build
```

Launch the project to run:

```
$dotnet run
```

After executing the ```$dotnet run``` command, your browser should automatically open and navigate to http://localhost:5000.

## Specifications




## Built With
* Visual Studio 2017
* MSTest
* C#
* ASP.NET
* Dotnet Core 1.1
* Chrome

## Author
[Johnny Mayer](https://github.com/johnnymayer)

## License
This project is licensed under the MIT License - [click here](LICENSE.md) for details.

## Acknowledgements