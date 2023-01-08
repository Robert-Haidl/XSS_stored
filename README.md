# XSS_stored
vulnerable .NET app to allow a cross-site scripting (XSS) attack

1) build project
2) create DB and migrate
- execute command in project folder: dotnet ef migrations add InitialCreate
- execute command in project folder: dotnet ef database update
3) use Client/add-entry.html to add a new blog Entry and check if it runs correctly
