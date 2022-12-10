FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["pv179-badminton/Sprint/Sprint.MVC/Sprint.MVC.csproj", "Sprint.MVC/"]
COPY ["pv179-badminton/Sprint/Sprint.BL/Sprint.BL.csproj", "Sprint.BL/"]
COPY ["pv179-badminton/Sprint/Sprint.DAL/Sprint.DAL.EFCore.csproj", "Sprint.DAL/"]
COPY ["pv179-badminton/Sprint/Sprint.Common/Sprint.Common.csproj", "Sprint.Common/"]
COPY ["pv179-badminton/Sprint/Sprint.Infrastructure.EFCore/Sprint.Infrastructure.EFCore.csproj", "Sprint.Infrastructure.EFCore/"]
COPY ["pv179-badminton/Sprint/Sprint.Infrastructure/Sprint.Infrastructure.csproj", "Sprint.Infrastructure/"]
RUN dotnet restore "Sprint.MVC/Sprint.MVC.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "pv179-badminton/Sprint/Sprint.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "pv179-badminton/Sprint/Sprint.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

EXPOSE 8000
ENV ASPNETCORE_URLS=http://+:8000
ENTRYPOINT ["dotnet", "Sprint.MVC.dll"]
