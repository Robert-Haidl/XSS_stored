# XSS_stored
vulnerable .NET app to allow a cross-site scripting (XSS) attack

1) build project
2) create DB and migrate
3) execute command in project folder: dotnet ef migrations add InitialCreate
4) execute command in project folder: dotnet ef database update
5) use Client/add-entry.html to add a new blog Entry
