# Clean Architecture ASP.NET Core Project Template

A production-ready **ASP.NET Core Web API project template** built using **Clean Architecture** principles. This template provides a solid foundation for building scalable, maintainable, and testable web APIs with proper separation of concerns.

## What It Does

This project template implements a Clean Architecture pattern for ASP.NET Core Web APIs. It separates the application into distinct layers:

- **Domain Layer**: Contains business entities, domain logic, and interfaces.
- **Application Layer**: Handles application-specific logic, services, and contracts.
- **Infrastructure Layer**: Manages data access, external services, and infrastructure concerns.
- **Presentation Layer**: Includes API controllers and HTTP-related components.
- **Host Layer**: The entry point that configures and runs the application.

The template includes:
- Dependency injection setup across layers
- Entity Framework Core with PostgreSQL support
- Swagger/OpenAPI documentation
- Authorization middleware
- HTTPS redirection
- Controller-based API endpoints

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

## Requirements

- **.NET SDK 8.0** or later
- **PostgreSQL** database (for data persistence)

## Key Features

- **Clean Architecture**: Strict separation of concerns with dependency inversion.
- **Dependency Injection**: Configured across all layers.
- **Entity Framework Core**: ORM with PostgreSQL support.
- **Swagger Integration**: Automatic API documentation.
- **Authorization**: Built-in ASP.NET Core authorization middleware.
- **HTTPS**: Enforced in production.
- **Nullable Reference Types**: Enabled for better null safety.
- **Implicit Usings**: Modern C# features enabled.

### Installation

- Install this template from Nuget

```bash
dotnet new install Thushar.SimpleWebApi.CleanArchitecture
```

### Verify installation:
```
dotnet new list
```

### Create a New Lambda Project
```bash
dotnet new cln-simple-webapi -n CompanyName.DomainName.ProjectName
```

### Nuget Package
Check out the nuget template: https://www.nuget.org/packages/Thushxr.SimpleWebApi.CleanArchitecture

### Repository
Source code and documentation: https://github.com/thushxr/simple-web-api-clean-architecture-template

### Contact
If you face any issues with downloading or installation, or have feature requests or bug reports, feel free to reach out.

[Mail](mailto:thushar8p@gmail.com) | [LinkedIn](https://www.linkedin.com/in/thushxr) | [Instagram](https://www.instagram.com/thushxr) | [Github](https://twitter.com/thushxr)