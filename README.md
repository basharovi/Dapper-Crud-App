# Dapper-Crud-App

.Net 5 has been released two days ago. So, for the purpose of practising that I have built a simple ASP.NET Core 5.0 WebAPI following a Clean Architecture , Repository Pattern and Unit of Work. At the Data Access Layer, I've used the Mini ORM, Dapper.

## What is Dapper?
Dapper is a simple Object Mapping Framework or a Micro-ORM that helps us to Map the Data from the Result of an SQL Query to a .NET Class effeciently. It would be as simple as executing a SQL Select Statement using the SQL Client object and returning the result as a Mapped Domain C# Class. It’s more like an Automapper for the SQL World. This powerful ORM was build by the folks at StackOverflow and is definitely faster at querying data when compared to the performance of Entity Framework. This is possible because Dapper works directly with the RAW SQL and hence the time-delay is quite less. This boosts the performance of Dapper.
