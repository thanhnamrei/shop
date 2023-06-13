#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/presentation/WebAPI/WebAPI.csproj", "src/presentation/WebAPI/"]
COPY ["src/services/ProductAPI/ProductAPI.csproj", "src/services/ProductAPI/"]
COPY ["src/infrastructure/Data/Data.csproj", "src/infrastructure/Data/"]
COPY ["src/core/Domain/Domain.csproj", "src/core/Domain/"]
RUN dotnet restore "src/presentation/WebAPI/WebAPI.csproj"
COPY . .
WORKDIR "/src/src/presentation/WebAPI"
RUN dotnet build "WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAPI.dll"]