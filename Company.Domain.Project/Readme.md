## Project Structure

```
services/
├── project/
│   ├── host/
│   │   └── Company.Domain.Project.HttpApi.Host/
│   │       ├── Program.cs
│   │       ├── appsettings.json
│   │       ├── appsettings.Development.json
│   │       └── Properties/launchSettings.json
│   └── src/
│       ├── Company.Domain.Project.Application/
│       │   ├── DependencyInjection.cs
│       │   └── Services/
│       ├── Company.Domain.Project.Application.Contract/
│       │   └── Interfaces/
│       ├── Company.Domain.Project.Domain/
│       │   ├── DependencyInjection.cs
│       │   ├── Entities/
│       │   └── Interfaces/
│       ├── Company.Domain.Project.Domain.Shared/
│       │   └── Helpers/
│       ├── Company.Domain.Project.HttpApi/
│       │   └── Controllers/
│       └── Company.Domain.Project.Infrastructure/
│           ├── AppDbContext.cs
│           ├── DependencyInjection.cs
│           └── Repository/
```

### Layer Descriptions

- **Host**: ASP.NET Core application entry point with configuration and middleware setup.
- **HttpApi**: API controllers, routing, and HTTP-specific concerns.
- **Application**: Application services, business logic orchestration, and DTOs.
- **Application.Contract**: Interfaces defining contracts between layers.
- **Domain**: Core business entities, domain services, and business rules.
- **Domain.Shared**: Shared domain types and utilities.
- **Infrastructure**: Data access implementations, external service integrations, and infrastructure code.