FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/Government.Services.Web.Host/Government.Services.Web.Host.csproj", "src/Government.Services.Web.Host/"]
COPY ["src/Government.Services.Web.Core/Government.Services.Web.Core.csproj", "src/Government.Services.Web.Core/"]
COPY ["src/Government.Services.Application/Government.Services.Application.csproj", "src/Government.Services.Application/"]
COPY ["src/Government.Services.Core/Government.Services.Core.csproj", "src/Government.Services.Core/"]
COPY ["src/Government.Services.EntityFrameworkCore/Government.Services.EntityFrameworkCore.csproj", "src/Government.Services.EntityFrameworkCore/"]
WORKDIR "/src/src/Government.Services.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Government.Services.Web.Host", "src/Government.Services.Web.Host"]
COPY ["src/Government.Services.Web.Core", "src/Government.Services.Web.Core"]
COPY ["src/Government.Services.Application", "src/Government.Services.Application"]
COPY ["src/Government.Services.Core", "src/Government.Services.Core"]
COPY ["src/Government.Services.EntityFrameworkCore", "src/Government.Services.EntityFrameworkCore"]
WORKDIR "/src/src/Government.Services.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Government.Services.Web.Host.dll"]

