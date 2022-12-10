FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Sprint/Sprint.MVC/Sprint.MVC.csproj", "Sprint.MVC/"]
COPY ["Sprint/Sprint.BL/Sprint.BL.csproj", "Sprint.BL/"]
COPY ["Sprint/Sprint.DAL/Sprint.DAL.EFCore.csproj", "Sprint.DAL/"]
COPY ["Sprint/Sprint.Common/Sprint.Common.csproj", "Sprint.Common/"]
COPY ["Sprint/Sprint.Infrastructure.EFCore/Sprint.Infrastructure.EFCore.csproj", "Sprint.Infrastructure.EFCore/"]
COPY ["Sprint/Sprint.Infrastructure/Sprint.Infrastructure.csproj", "Sprint.Infrastructure/"]
RUN dotnet restore "Sprint.MVC/Sprint.MVC.csproj"
COPY . .
WORKDIR "/src/Sprint.MVC"
RUN dotnet build "Sprint/Sprint.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sprint/Sprint.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

EXPOSE 8000
ENV ASPNETCORE_URLS=http://+:8000
ENTRYPOINT ["dotnet", "Sprint.MVC.dll"]
