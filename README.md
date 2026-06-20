# 🛒 MiniShop.Api

A learning project built with ASP.NET Core Web API, Entity Framework Core, SQL Server, and Swagger.

This project was created to learn backend architecture patterns commonly used in enterprise .NET applications.

---

## 🚀 Features

✅ ASP.NET Core Web API

✅ Swagger / OpenAPI

✅ Dependency Injection

✅ Controller → Service → Repository Architecture

✅ Entity Framework Core

✅ SQL Server Integration

✅ Database Migrations

✅ Product Availability Endpoint

---

## 🏗 Architecture

```txt
Swagger
   ↓
Controller
   ↓
Service
   ↓
Repository
   ↓
DbContext
   ↓
SQL Server
```

---

## 📂 Project Structure

```txt
MiniShop.Api
│
├── Controllers
│   └── ProductsController.cs
│
├── Services
│   ├── IProductService.cs
│   └── ProductService.cs
│
├── Repositories
│   ├── IProductRepository.cs
│   └── ProductRepository.cs
│
├── Models
│   └── Product.cs
│
├── Data
│   └── AppDbContext.cs
│
├── Program.cs
├── appsettings.json
└── README.md
```

---

## 🧠 Concepts Learned

- Dependency Injection
- Interfaces & Implementations
- Separation of Concerns
- Repository Pattern
- Entity Framework Core
- SQL Server
- Migrations
- Swagger Testing
- Controller-Service-Repository Flow

---

## 🔄 Request Flow

```txt
GET /api/products/available

Swagger
   ↓
ProductsController
   ↓
IProductService
   ↓
ProductService
   ↓
IProductRepository
   ↓
ProductRepository
   ↓
AppDbContext
   ↓
SQL Server
```

---

## 🛠 Technologies

| Technology               | Purpose            |
| ------------------------ | ------------------ |
| ⚡ ASP.NET Core          | Web API            |
| 📦 Entity Framework Core | ORM                |
| 🗄 SQL Server            | Database           |
| 📖 Swagger               | API Testing        |
| 💉 Dependency Injection  | Service Resolution |
| 🔍 LINQ                  | Data Querying      |

---

## ▶ Running the Project

```bash
dotnet restore
dotnet run
```

Open Swagger:

```txt
https://localhost:<port>/swagger
```

---
