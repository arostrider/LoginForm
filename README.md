# LoginForm
Login window form made with C# .NET and SQL Server in Visual Studio 2019, used as an example for Quality Assurance (QA) course.

When application is started login form appears. User can enter username and password. If entered credentials match some of the credentials found in the table 'Users' in Login.mdf database, then application enters main form. Otherwise the warning dialog should appear and text fields are cleared. In this commit warning dialog will NOT appear. This bug is made on purpose by commenting line 42 in LoginForm.cs in order to simulate Defect for Test Case Scenario for my QA course.
