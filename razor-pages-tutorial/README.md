## Razor Page tutorial

https://docs.microsoft.com/en-us/as pnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-3.1&tabs=visual-studio-code

### Examine the project files
Here's an overview of the main project folders and files that you'll work with in later tutorials.

### Pages folder
Contains Razor pages and supporting files. Each Razor page is a pair of files:

- .cshtml file that contains HTML markup with C# code using Razor syntax.
- .cshtml.cs file that contains C# code that handles page events.

Supporting files have names that begin with an underscore. For example, the _Layout.cshtml file configures UI elements 
common to all pages. This file sets up the navigation menu at the top of the page and the copyright notice at the
 bottom of the page. For more information, see Layout in ASP.NET Core.

### wwwroot folder
Contains static files, such as HTML files, JavaScript files, and CSS files. For more information, see Static files in ASP.NET Core.

### appSettings.json
Contains configuration data, such as connection strings. For more information, see Configuration in ASP.NET Core.

### Program.cs
Contains the entry point for the program. For more information, see .NET Generic Host.

### Startup.cs
Contains code that configures app behavior. For more information, see App startup in ASP.NET Core.

### Part 2, add a model to a Razor Pages app

#### Scaffold the movie model

```shell
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet aspnet-codegenerator razorpage -m Movie -dc RazorPagesMovieContext -udl -outDir Pages/Movies --referenceScriptLibraries
```

#### Initial migration

```shell
dotnet tool install --global dotnet-ef

dotnet ef migrations add InitialCreate
dotnet ef database update
```

### Part 3, scaffolded Razor Pages in ASP.NET Core

#### The Create, Delete, Details, and Edit pages


##### Listing

- Razor Pages derive from `PageModel`
- The class name by convection is named `<PageName>Model`
- Dependency injection used to add the `RazorPagesMovieContext`
- `OnGetAsync` or `OnGet` does not need a return unless the return type involves an `Action`

#### Razor reserved keywords

- page
- namespace
- functions
- inherits
- model
- section

Transition to Razor-specific markup or C# happens with `@`

##### `@page` directive

This directive makes the file an MVC action which means it can handle requests.  It must be the first Razor directive on a page.

##### Notes

Look into...

- `Html.DisplayNameFor`
- `Html.DisplayFor`

##### `@model directive

Specifies the type of the model passed to the Razor Page.

```cs
@model razor_pages_tutorial.Pages.Movies.IndexModel
```