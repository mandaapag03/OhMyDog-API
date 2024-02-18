FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
LABEL maintainer "Amanda Pagani <paganiamanda791@gmail.com>"
WORKDIR /App

COPY . ./

WORKDIR /App/OhMyDogAPI
RUN dotnet restore ../OhMyDogAPI.sln
RUN dotnet publish -c Release -o out ../OhMyDogAPI.sln

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App/OhMyDogAPI
COPY --from=build-env /App/OhMyDogAPI/out .
ENTRYPOINT [ "dotnet", "OhMyDogAPI.dll" ]
