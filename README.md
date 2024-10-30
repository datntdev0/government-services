# goverment-services

## Introduction

Components and architecture

1. Backend with **ASP.NET Core Web API** _(version 8)_
2. Frontend with **Angular JS Framework** _(version 18)_
3. Database with **MSSQL Server** _(version 2022)_

## Setup environment

Please refer to the following documents to have the instruction of:

- [Frontend Environment Setup](./angular/README.md)
- [Backend Environment Setup](./aspnet-core/README.md)

Alternative, you can use the docker compose to run up all components for this project.

```bash
cd .github/deploy
bash deploy.dev.sh
```

The above commands will start the application which you can try using the application from your localhost by accessing http://localhost:8081.

_Note: The frontend developers don't need to run the backend component(s) while you can use backend service url(s) from container(s) as well as the staging environment. Open the `appconfig.json` and change the `remoteServiceBaseUrl` to your backend url._
