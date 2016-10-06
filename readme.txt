-------------------
Virtual Directories
-------------------

It is recommended that you use the exact same directory structure and drive when testing the examples as I did when creating them. This is because the Visual Studio .NET solution files store the full path for all web projects. (You can change this information by editing the project and solution files by hand in a text editor, but it's far from convenient.)

In addition, you will need to create a separate virtual directory for every project. The only exceptions are the first few chapters (Chapter02, Chapter04, and Chapter05). These chapters include simpler test pages, and the book provides detailed setup instructions on how to copy these test pages to the correct location or create the appropriate virtual directory.

To perform the full setup for Chapters 6-25, follow these steps:

1. Begin by unzipping the code zip file to C:\.
* This will create the root directory C:\ASP.NET, which contains the chapter directories (like Chapter04, Chapter05, and so on). Most chapter directories contains one or more project directories. For example, C:\ASP.NET\Chapter07\GreetingCardMaker is a project directory that contains all the web pages for the GreetingCardMaker example from Chapter 

2. Use the IIS virtual directory wizard to map C:\ASP.NET to the virtual directory named ASP.NET. 

3. Expand the ASP.NET folder in the IIS tree so that you can see the chapter directories.

4. Now, expand the Chapter06 directory to expose the project directories (there are four). Right-click on the first project directory (CurrencyConverter1), choose Properties, and then click the Create button in the Directory tab. Now click OK.
* Now the directory is configured as a web application. You can open the solution or project files in this directory using Visual Studio .NET. The IIS_Create.jpg file (included with this download) shows where you need to click.

5. Repeat step 4 for every project directory in every chapter directory.

6. When you are finished creating the virtual directories, right-click on the root ASP.NET virtual directory, select Properties, and then click Remove to turn it back to an ordinary directory.
* The IIS_Config.jpg file (included with this download) shows how some of the IIS configuration should look when you are finished.



---------------------------------------
Running the Pages in Visual Studio .NET
---------------------------------------

Note that every web project is made up of several example pages, which do not always relate directly. To run a page from Visual Studio .NET, right click on it and set it to be the startup page. Then start the application. You can also start the application, and then type different .aspx file names into the browser.



-----------------------
Visual Studio .NET 2003
-----------------------
The code samples are provided as Visual Studio .NET projects, which means you can open them in Visual Studio .NET or Visual Studio .NET 2003. When opening a project in Visual Studio .NET 2003, you will asked to convert to the files to the newer format. This process will take place automatically when you accept, and after this point the project will only be accessible in Visual Studio .NET 2003. All the code in this book has been tested and works equally well in Visual Studio .NET and Visual Studio .NET 2003.



-----------------------------------
SQL Server and Data Access Examples
-----------------------------------

You may need to modify some of the database samples before they work with your database.

1. If you are using SQL Server on the local computer, make sure the service is started (or is set to start automatically). You can check to make sure it is running by loading Enterprise Manager and requesting a database.

2. You can install the AdBoard database (used in Chapter 22) using the include adboard.sql file. This is a script that contains all the SQL statements required to build the database and generate the tables. You can run it by opening it in a SQL Server tool like Query Analyzer.

3. You may need to tweak the database connection string for your settings. This is the most common setting for SQL Server 2000 (it uses Windows integrated security):

Dim Connect As String = "Data Source=localhost;Integrated Security=SSPI;" & _
    "Initial Catalog=Northwind;"

If you aren't using integrated security, you will have to replace this with a connection string like this for the sa account (although it can vary depending on your database and whether you have configured a special password):

Dim Connect As String = "Data Source=localhost;user id=sa;" & _
    "Initial Catalog=Northwind;"

The sample examples in Chapter 14 include a ConnectionTester.aspx page that lets you try both ways to connect.



--------------------
Web Service Projects
--------------------

The c:\ASP.NET\Chapter19\WebServices directory contains the sample Web Services. The c:\ASP.NET\Chapter20\WebClients contains client pages that use these Web Services. Additionally, you can use the c:\ASP.NET\Chapter21\WebClients\WebClients.sln solution file to load both the Web Services and the clients and the same time.



---------------
Custom Controls
---------------

If you want the custom controls developed in Chapter 23 to be shown on your Toolbox, you will need to add them as described in the book. Visual Studio .NET stores global preference information for the Toolbox--it is not stored in individual projects or solutions.



-----------------
Security Settings
-----------------

For the WindowsSecurity project in Chapter 25, you will need to modify the IIS settings for the virtual directory to force Windows authentication, as described in the book.

