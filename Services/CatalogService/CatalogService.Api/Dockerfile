
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release

WORKDIR /src
COPY ["Services/CatalogService/CatalogService.Api/CatalogService.Api.csproj", "Services/CatalogService/CatalogService.Api/"]
COPY ["BuildingBlocks/Framework.Core/Framework.Core.csproj", "BuildingBlocks/Framework.Core/"]
COPY ["BuildingBlocks/Framework.WebApi.Core/Framework.WebApi.Core.csproj", "BuildingBlocks/Framework.WebApi.Core/"]
COPY ["Services/CatalogService/CatalogService.Application/CatalogService.Application.csproj", "Services/CatalogService/CatalogService.Application/"]
COPY ["Framework.Shared.IntegrationEvent/Framework.Shared.IntegrationEvent.csproj", "Framework.Shared.IntegrationEvent/"]
COPY ["BuildingBlocks/Framework.Message.Bus/Framework.Message.Bus.csproj", "BuildingBlocks/Framework.Message.Bus/"]
COPY ["Services/CatalogService/CatalogService.Domain/CatalogService.Domain.csproj", "Services/CatalogService/CatalogService.Domain/"]
COPY ["Services/CatalogService/CatalogService.Infra/CatalogService.Infra.csproj", "Services/CatalogService/CatalogService.Infra/"]
RUN dotnet restore "Services/CatalogService/CatalogService.Api/CatalogService.Api.csproj"
COPY . .
WORKDIR "/src/Services/CatalogService/CatalogService.Api"
RUN dotnet build "CatalogService.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
RUN dotnet publish "CatalogService.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CatalogService.Api.dll"]
