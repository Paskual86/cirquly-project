# cirquly-project
Test for Cirquly Project

Homework assignment: minimal ASP.NET MVC article browser

Goal
Create a very small ASP.NET MVC application that displays a list of articles and allows clicking an article to view its details.
This assignment is intended to verify basic familiarity with:
* ASP.NET MVC structure
* Controllers, Models, Views
* Routing & model binding
* Razor syntax
* Simple navigation between pages



Functional Requirements
1. Article Model
Create an Article model with the following properties:
Id (int)
Title (string)
Price (decimal)
Description (string)
CreatedDate (DateTime)



2. Article List Page
* Displays all articles (UI format is free: basic list, cards, table, etc.)
* Each article shows at least:
* Title
* Price
* Each article is clickable
* Clicking navigates to the Article Detail page



3. Article Detail Page
* Displays:
* Title
* Price
* Description
* CreatedDate
* Includes a Back button or link to return to the list



4. Data Source
* Hardcoded in-memory list inside a repository or service
No need for CRUD or persistence. No need for a database, no need for a API. Just basic in memory is fine dummy/fake/mockup data.



5. Technical Requirements
* ASP.NET MVC (.NET Core)
* Razor Views
* One controller: ArticlesController
* Clean folder structure



Deliverables
* ZIP file is fine, OR GitHub repository

Evaluation Criteria
We will look for:
* Correct MVC flow
* Clean routing to detail page
* Razor usage
* Readable, simple code



We are not evaluating design or styling.