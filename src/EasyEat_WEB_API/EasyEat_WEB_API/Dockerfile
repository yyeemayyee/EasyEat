FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["EasyEat_WEB_API/EasyEat_WEB_API.csproj", "EasyEat_WEB_API/"]
RUN dotnet restore "EasyEat_WEB_API/EasyEat_WEB_API.csproj"
COPY . .
WORKDIR "/src/EasyEat_WEB_API"
RUN dotnet build "EasyEat_WEB_API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "EasyEat_WEB_API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EasyEat_WEB_API.dll"]
