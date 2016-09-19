# ASP.NET Core development environment using Docker

This is an ASP.NET Core environment sey up for developmnet, with the CLI tools included, a minimal app structure set up with one sample API endpoint, and dotnet-watch is being used for automatically rebuilding in the container on code changes.

It also uses Docker Compose to start the ASP.NET container, along with a container with postgreSQL. 

## Spin up the environment

### To build the images and run them: 

```docker-compose up```

You can add a -d at the end to run them in the background. 

### To stop the containers: 

```docker-compose stop```

## The development process with Docker and ASP.NET Core

When the ASP.NET container spins up, it will map your current directory to a folder /app in the container. You can change code in your directory, and it will be updated in the container. You can use your regular IDE while the container builds and runs the app. dotnet-watch will be running so the app rebuilds in the container when code changes are saved. 
