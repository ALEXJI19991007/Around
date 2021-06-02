#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Around.API/Around.API.csproj", "Around.API/"]
RUN dotnet restore "Around.API/Around.API.csproj"
COPY . .
WORKDIR "/src/Around.API"
RUN dotnet build "Around.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Around.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Around.API.dll"]
