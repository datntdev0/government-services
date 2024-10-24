FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/Government.Services.Core.Shared/Government.Services.Core.Shared.csproj", "Government.Services.Core.Shared/"]
COPY ["src/Government.Services.Core/Government.Services.Core.csproj", "Government.Services.Core/"]
COPY ["src/Government.Services.EntityFrameworkCore/Government.Services.EntityFrameworkCore.csproj", "Government.Services.EntityFrameworkCore/"]
COPY ["src/Government.Services.Migrator/Government.Services.Migrator.csproj", "Government.Services.Migrator/"]
WORKDIR "/src/Government.Services.Migrator"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Government.Services.Core.Shared", "Government.Services.Core.Shared"]
COPY ["src/Government.Services.Core", "Government.Services.Core"]
COPY ["src/Government.Services.EntityFrameworkCore", "Government.Services.EntityFrameworkCore"]
COPY ["src/Government.Services.Migrator", "Government.Services.Migrator"]
WORKDIR "/src/Government.Services.Migrator"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Government.Services.Migrator.dll", "-q"]
