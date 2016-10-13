# ASP.NET Core development environment using Docker

This is an ASP.NET Core environment set up for developmnet with Docker building and running the app. It includes:  
- The .NET Core CLI tools / SDK 
- A minimal app structure set up with one sample API endpoint 
- dotnet-watch for automatically rebuilding in the container on code changes 
- Dockerfile exposes container's port 5000 so default ASP.NET Core port is browsable 

When the ASP.NET container spins up, it will map your current directory to a folder /app in the container. Then you can change code in your directory, and it will be updated in the container. You can use your regular IDE while the container builds and runs the app. dotnet-watch will be running so the app rebuilds automatically in the container when code changes are saved. 

## Overview of the Developer Workflow with ASP.NET Core and Docker 

1. You should start with a command line, in an empty folder or the root of an existing ASP.NET Core app. Run this command to spin up an ASP.NET container. It will mount your current directory to a folder called `/app` in the container. 

    ```
    docker run -i -p 5000:5000 -v $(pwd):/app -t wyntuition/aspnetcore-development-env
    ```


1. You will now be in the bash of the container and can run `dotnet restore` then `dotnet run watch` to run the app on port 5000 with dotnet-watch. 

1. Then, you can change code in your app, and it will be updated in the container. So you use your IDE in your host as normal, while the container builds and runs the app. dotnet-watch will be running in the container, so the app rebuilds automatically in the container when code changes are saved. So after you save code changes, simply refresh your browser to see the changes.

For more details on setting up an ASP.NET Core development environment using Docker, and building your own development environment container, see this [workshop section on Docker and ASP.NET](https://github.com/excellalabs/aspnetcore-workshop-kit/tree/master/MISC-Containers).