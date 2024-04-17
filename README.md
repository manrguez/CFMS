To be able to run the application you should perform the followin steps:

1.- Clone the repository and restore all the dependencies
2.- Change the Connection String to use your connection info inside the appsetting.json file
3.- Build project CMFS
4.- Execute the Update-Database command from the Package Manager Console (PMC)
5.- Run the application
6.- Register as new user

The application was developed using MVC and Repository patterns. This implementation is to have a better code organization, to reuse repositories among the controllers, and to reduce the risk of duplicating code therefore easier maintenance.

For error handling, a global exception handler was implemented to generate detailed text files with error info pleced at ErrorLogs folder.

The application enables you to provide feedback and view a list of recent records from the past 30 days. In the feedback details, you will find a section for responses where you can add, edit, and view a list of responses.