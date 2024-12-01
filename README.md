# PersonalInfoApp
Configure the connection string to your server. 
Db may be generated automatically from the name in your connection string based on selected approach.

For the fresh database setup, you can use either script attached in data layer to create new database, 
or much better is to delete Migrations folder from DataLayer project and run the commands below:
	1) dotnet ef migrations add InitialCreate --project DataLayer --startup-project FrontEnd
    2) dotnet ef database update --project DataLayer --startup-project FrontEnd

If using sql script, select the appropriate server on which the DB should be created

The assumptions are you have all necessary tools(ie .NET CLI, SQL server etc) installed