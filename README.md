# Student Management System API

A professional, secure, and scalable **.NET 8 Web API** for managing student records. This project demonstrates a clean implementation of **Layered Architecture**, **JWT-based Security**, and **Persistence** using SQLite.

---

### 🚀 Key Features
* **Layered Architecture**: Organized into Controllers, Services, and Repositories for clear separation of concerns.
* **JWT Authentication**: Secure endpoints protected by JSON Web Tokens with a custom Auth flow.
* **SQLite Persistence**: Lightweight, file-based database integration using Entity Framework Core.
* **Global Exception Handling**: Custom middleware ensures consistent, graceful error responses across the API.
* **Swagger/OpenAPI**: Fully documented interface with built-in JWT "Authorize" support for seamless testing.

---

### 🛠️ Tech Stack
* **Framework**: .NET 8.0
* **Database Provider**: Entity Framework Core 8.0 (SQLite)
* **Security**: System.IdentityModel.Tokens.Jwt
* **Documentation**: Swagger (OpenAPI 3.0)

---

### 📂 Project Structure
```text
├── Controllers     # API Endpoints (Student CRUD & Auth)
├── Services        # Business Logic Layer (Interfaces & Implementation)
├── Repositories    # Data Access Layer (Persistence Logic)
├── Models          # Data Entities and DTOs
├── Data            # ApplicationDbContext & Migrations
├── Middleware      # Exception Handling Middleware
└── StudentMgmt.db  # Local SQLite Database File
---

### Getting Started

#### 1. Prerequisites
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* VS Code or Visual Studio 2022

#### 2. Installation
```bash
# Clone the repository
git clone [https://github.com/AbhikKhodiyar/StudentManagementSystem.git](https://github.com/AbhikKhodiyar/StudentManagementSystem.git)

# Navigate to the project directory
cd StudentManagementSystem

# Restore NuGet packages
dotnet restore

#Running the API
dotnet run
The API will be available at http://localhost:5138

#Testing with Swagger
Navigate to http://localhost:5138/swagger to access the interactive UI.
Use the POST /api/Auth/login endpoint to generate a token.
Click the Authorize button at the top and paste your token to unlock protected endpoints.
