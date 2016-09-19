## ASP.NET Core development environment using Docker

This is an ASP.NET Core environment sey up for developmnet, with the CLI tools included, a minimal app structure set up with one sample API endpoint, and dotnet-watch is being used for automatically rebuilding in the container on code changes.

It also uses Docker Compose to start the ASP.NET container, along with a container with postgreSQL. 

### To build the images and run them: 

```docker-compose up```

You can add a -d at the end to run them in the background. 

### To stop the containers: 

```docker-compose stop```
