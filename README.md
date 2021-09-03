# CommandAPI
This is a .Net core Web API project and uses Entity Framework. Uses PostgreSQL as DB. 

To build and run,
1. Go to ./src/CommandAPI
2. Run "dotnet run"


## Implemented API endpoints:

GET /api/commmands

GET /api/commands/{Id}

POST /api/commmands

PUT /api/commands/{Id}

PATCH /api/commands/{Id}

DELETE /api/commands/{Id}

To secure the APIs,
1. uses Bearer Authentication
2. uses Azure Active Directory
3. Need to configure Active Directory in Azure and use a sample client to generate bearer token to be used to secure API
