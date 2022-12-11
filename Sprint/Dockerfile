FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Sprint.MVC/Sprint.MVC.csproj", "Deployment/Sprint.MVC/"]
COPY ["Sprint.BL/Sprint.BL.csproj", "Deployment/Sprint.BL/"]
COPY ["Sprint.DAL/Sprint.DAL.EFCore.csproj", "Deployment/Sprint.DAL/"]
COPY ["Sprint.Common/Sprint.Common.csproj", "Deployment/Sprint.Common/"]
COPY ["Sprint.Infrastructure.EFCore/Sprint.Infrastructure.EFCore.csproj", "Deployment/Sprint.Infrastructure.EFCore/"]
COPY ["Sprint.Infrastructure/Sprint.Infrastructure.csproj", "Deployment/Sprint.Infrastructure/"]
RUN dotnet restore "Deployment/Sprint.MVC/Sprint.MVC.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "Sprint.MVC/Sprint.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sprint.MVC/Sprint.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

EXPOSE 8000
ENV ASPNETCORE_URLS=http://+:8000
ENTRYPOINT ["dotnet", "Sprint.MVC.dll"]
