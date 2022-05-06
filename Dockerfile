# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ../src/CountYourself.Service/CountYourself.Service.Host/*.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY ../src/CountYourself.Service/CountYourself.Service.Host/ ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "CountYourself.Service.Host.dll"]