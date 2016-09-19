# ASP.NET Core development environment using Docker

This is an ASP.NET Core environment set up for developmnet with Docker building and running the app. It includes:  
- The .NET Core CLI tools / SDK 
- A minimal app structure set up with one sample API endpoint 
- dotnet-watch for automatically rebuilding in the container on code changes 
- Docker Compose to start the ASP.NET container along with a container with postgreSQL 

When the ASP.NET container spins up, it will map your current directory to a folder /app in the container. Then you can change code in your directory, and it will be updated in the container. You can use your regular IDE while the container builds and runs the app. dotnet-watch will be running so the app rebuilds automatically in the container when code changes are saved. 

## Spin up the environment

### To build the images and run them: 

```docker-compose up```

You can add a -d at the end to run them in the background. 

### To stop the containers: 

```docker-compose stop```

With them running, you should be able to navigate to your web app (or the Web API sample endpoint in this app - http://localhost:8080/api/articles).  

You should be able to develop as usual on your computer, but when you save, your code is rebuilt in the ASP.NET container, and then run from there. 
