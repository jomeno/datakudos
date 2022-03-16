FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /

# copy csproj and restore as distinct layers
COPY *.sln .
COPY ./Api/*.csproj ./Api/
COPY ./Core/*.csproj ./Core/
RUN dotnet restore

# copy everything else and build app
COPY ./Api/. ./Api/
COPY ./Core/. ./Core/
WORKDIR /Api
RUN dotnet publish -c release -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "Api.dll"]