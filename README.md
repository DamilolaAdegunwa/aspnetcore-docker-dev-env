# ASP.NET Core development environment using Docker

This is an ASP.NET Core environment set up for developmnet with Docker building and running the app. It includes:  
- The .NET Core CLI tools / SDK 
- A minimal app structure set up with one sample API endpoint 
- dotnet-watch for automatically rebuilding in the container on code changes 
- Docker Compose to start the ASP.NET container along with a container with postgreSQL 

When the ASP.NET container spins up, it will map your current directory to a folder /app in the container. Then you can change code in your directory, and it will be updated in the container. You can use your regular IDE while the container builds and runs the app. dotnet-watch will be running so the app rebuilds automatically in the container when code changes are saved. 

## Spin up the environment

This will use Docker Compose to spin up an ASP.NET Core container, and a postgreSQL container.

### To build the images and run them: 

```docker-compose up```

You can add a -d at the end to run them in the background. 

### To stop the containers: 

```docker-compose stop```

With them running, you should be able to navigate to your web app (or the Web API sample endpoint in this app - http://localhost:8080/api/articles). You should be able to develop as usual on your computer, but when you save, your code is rebuilt in the ASP.NET container, and then run from there. You can try changing the /Controllers/ArticlesController.cs code and see it update at that endpoint, which is being hosted from the ASP.NET container.

## Build and run single container

 If you want, you can build just the ASP.NET Core container from your root app folder which will use the existing Dockerfile, using this command: 
 ```docker build -t <yourTag:YourAspNetImageName> .```

You can run the container, specifying a port binding for listening, the current app folder to mount in the container, and the image name, using this command:
```docker run -d -p 8080:5000 -v $(pwd):/app -t <yourTag:YourAspNetImageName>```

You could manually spin up the postgreSQL container or others in a similar manner. 
