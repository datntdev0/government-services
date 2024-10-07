# Government Services Project

This is a government services ASP.NET project.

## Table of Contents

1. [Requirements](#requirements)
2. [Configuration](#configuration)
3. [Installation](#installation)

## Requirements

- .NET SDK (version 8)
- MSSQL Server 2022

## Configuration

### 1. Configure Your Database

- Open the `docker-compose.yml` file.
- Set your database password by editing the following line:
  ```yaml
  MSSQL_SA_PASSWORD=your-password (at least 8 characters)
  ```
- Pull the latest SQL Server image, create a container, and start it by running the following command:
  ```bash
  docker-compose up -d
  ```
- Once the MSSQL Server is running, create a new database with your desired name.

### 2. Configure `ConnectionStrings`

You need to update the database connection strings in both the web host and migrator configurations.

- Navigate to the project folders `Government.Services.Web.Host` and `Government.Services.Migrator`.
- Edit the `appsettings.json` file in both projects to include your database connection string:
  ```json
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=your-db-server; Database=your-db-name; TrustServerCertificate=True; User=your-user-name; Password=your-password"
    }
  }
  ```

## Installation

### 1. Build the Project

Ensure that the correct .NET SDK is installed. To build the project, use the following command:

```bash
dotnet build
```

### 2. Run the Migrator

To apply database migrations, navigate to the `Government.Services.Migrator` folder and run the migrator:

```bash
cd Government.Services.Migrator
dotnet run
```

### 3. Run the Web Host

After building and migrating, you can run the web host. Navigate to the `Government.Services.Host` folder and start the project:

```bash
cd Government.Services.Web.Host
dotnet run
```
