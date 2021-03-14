#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["first-project/first-project.csproj", "first-project/"]
RUN dotnet restore "first-project/first-project.csproj"
COPY . .
WORKDIR "/src/first-project"
RUN dotnet build "first-project.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "first-project.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "first-project.dll"]