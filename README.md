# WebApplicationmvc
step 1 : create a model in our project our model is blogpost and tag
2. define property inside a model
3. set a relation between two different model
4.now we have have created a domain model now we want entity framework to create a actual SQL table
5.to create entity framework download two packages
   5.1. Microsoft.EntityFrameworkCore.SqlServer
   5.2. Microsoft.EntityFrameworkCore.SqlServer
   (go to dependencies right click goto nuget packages and search in brower section and download)
6. Create dbContext class(it is a bridge between domain class and database or it is responsible for interacting with database such as CURD operation)
7. to create dbContext class click on project and create a new folder Data folder inside it create a new class
8. create constructor in bloggydbcontext file and add property to create table with respect to domain
9. connect string to database
	9.1. open appsetting.json
	9.2. add connection string
10. After connecting string to database inject dbContext into our App
	10.1. go to program.cs
	10.2. And add db service in it

we have done all the preparation for database preparation

11. Now finally create database table using entity framework
	11.1. open nuget console(tools -> nuget package manager -> nuget console)
		11.1.1. In console write : EntityFrameorkCore\Add-Migration "Name of Migration"
		11.1.2. After that new migration folder will be created means it will generate a required script which is required for a our project
		11.1.3. After that run: EntityFrameworkCore\Update-Database
		11.1.4. It will create a table in server

12. now we will create controllers and all to perform CURD operation
