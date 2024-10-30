FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/Government.Services.Core.Shared/Government.Services.Core.Shared.csproj", "Government.Services.Core.Shared/"]
COPY ["src/Government.Services.Core/Government.Services.Core.csproj", "Government.Services.Core/"]
COPY ["src/Government.Services.Application.Contracts/Government.Services.Application.Contracts.csproj", "Government.Services.Application.Contracts/"]
COPY ["src/Government.Services.Application/Government.Services.Application.csproj", "Government.Services.Application/"]
COPY ["src/Government.Services.EntityFrameworkCore/Government.Services.EntityFrameworkCore.csproj", "Government.Services.EntityFrameworkCore/"]
COPY ["src/Government.Services.Web.Core/Government.Services.Web.Core.csproj", "Government.Services.Web.Core/"]
COPY ["src/Government.Services.Web.Host/Government.Services.Web.Host.csproj", "Government.Services.Web.Host/"]
WORKDIR "/src/Government.Services.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Government.Services.Core.Shared", "Government.Services.Core.Shared"]
COPY ["src/Government.Services.Core", "Government.Services.Core"]
COPY ["src/Government.Services.Application.Contracts", "Government.Services.Application.Contracts"]
COPY ["src/Government.Services.Application", "Government.Services.Application"]
COPY ["src/Government.Services.EntityFrameworkCore", "Government.Services.EntityFrameworkCore"]
COPY ["src/Government.Services.Web.Core", "Government.Services.Web.Core"]
COPY ["src/Government.Services.Web.Host", "Government.Services.Web.Host"]
WORKDIR "/src/Government.Services.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Government.Services.Web.Host.dll"]
