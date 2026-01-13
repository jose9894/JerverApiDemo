# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# copy csproj and restore as distinct layers
COPY MenuApi.csproj ./
RUN dotnet restore 

# copy everything else and build app
COPY . ./
RUN dotnet publish MenuApi.csproj -c Release -o /app/publish --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app

COPY --from=build /app/publish ./
ENTRYPOINT ["dotnet", "MenuApi.dll"]