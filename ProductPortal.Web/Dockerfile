FROM mcr.microsoft.com/dotnet/core/sdk:3.1
COPY dist /app
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_URLS=http://+:56551 
EXPOSE 56551/tcp
ENTRYPOINT ["dotnet", "ProductPortal.Web.dll"]