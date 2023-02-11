## Dockerfile
## Generates the docker image using our code

# Creates the base aspnet image, with the correct exposed ports, which we are going to use
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Creates the build image, where it copies in our code and builds it in a seperate container
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Paint-Calculator/Paint-Calculator.csproj", "Paint-Calculator/"]
RUN dotnet restore "Paint-Calculator/Paint-Calculator.csproj"
COPY . .
WORKDIR "/src/Paint-Calculator"
RUN dotnet build "Paint-Calculator.csproj" -c Release -o /app/build

# Creates the publish image with the build image. This publishes our code after it was builded
FROM build AS publish
RUN dotnet publish "Paint-Calculator.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Creates the final image, where it uses our base image and copies in the code. Then sets the entrypoint as our .dll file.
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Paint-Calculator.dll"]