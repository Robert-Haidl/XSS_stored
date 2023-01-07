# XSS_stored
vulnerable .NET app to allow a cross-site scripting (XSS) attack

1) build project
2) create DB and migrate
  2.1) dotnet ef migrations add InitialCreate
  2.2) dotnet ef database update
3) use Client/add-entry.html to add a new blog Entry
