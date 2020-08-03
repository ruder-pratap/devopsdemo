FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 56562

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["ProductPortal.API/ProductPortal.API.csproj", "ProductPortal.API/"]
COPY ["ProductPortal.Model/ProductPortal.Model.csproj", "ProductPortal.Model/"]
COPY ["ProductPortal.Repository/ProductPortal.Repository.csproj", "ProductPortal.Repository/"]

COPY . .
WORKDIR "/src/ProductPortal.API"
RUN dotnet restore "ProductPortal.API.csproj"
RUN dotnet build "ProductPortal.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProductPortal.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProductPortal.API.dll"]