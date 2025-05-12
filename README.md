# TaskCreatorCleanArhiticture

## About the Project

**TaskCreatorCleanArhiticture** is a complete learning/demo project designed for recruiters and technical specialists to quickly assess my practical skills in modern .NET development.  
This repository contains a fully functional backend project with CRUD operations, architectural patterns, and automated tests.

---

## Project Overview

- **Architecture:** Clean Architecture
- **Language:** C#
- **Platform:** .NET 8.0
- **Stack:** ASP.NET Core, Entity Framework Core, xUnit, InMemory Database, Entity Framework Core, Rider
- **Purpose:** To demonstrate my approach to design, code quality, test organization, and documentation for recruiters.

---

## What’s Inside

- **Domain** — Business models and logic (e.g., Task/Note entities)
- **Application** — Interfaces, services, business rules
- **Infrastructure** — Data access implementations (DbContext, repositories)
- **API** — Web interface (ASP.NET Core controllers)
- **Tests** — Automated unit and integration tests (xUnit), test data factories

---

## Core Features

- CRUD operations for tasks (Task) or notes (Note)
- Layered structure based on Clean Architecture principles
- Automated tests with xUnit and in-memory database
- Quick setup and launch on any machine
- Examples of clean code and best practices

---

## How to Run the Project and Tests

1. **Install .NET SDK 8.0 or newer**
2. **Clone the repository**
    ```sh
    git clone https://github.com/Allexand3r/TaskCreatorCleanArchitecture.git
    cd TaskCreatorCleanArhiticture
    ```
3. **Run the API**
    ```sh
    dotnet run --project WebApi/WebApi.csproj
    ```
   or open the project in JetBrains Rider/Visual Studio and start it from the IDE.
4. **Open Swagger UI**  
   Usually at: http://localhost:5000/swagger/index.html or http://localhost:5001/swagger/index.html

5. **Run tests**
    ```sh
    dotnet test
    ```

---

## Who This Project is For

- Recruiters to quickly evaluate .NET, architecture, and test skills
- Technical specialists to review structure, approaches, and code quality
- Fellow developers as a template or example for similar projects

---

## Why This Project is Great for Assessment

- Demonstrates not only testing skills but also architectural design
- Shows separation of concerns and best practices
- Easy to navigate, quick to launch and check CRUD operations and tests

---

## Repository Structure

- `/Domain` — Business entities
- `/Application` — Business logic and services
- `/Infrastructure` — Data access implementations
- `/WebApi` — ASP.NET Core Web API
- `/Tests`  — Automated tests
- `README.md` — This documentation

---

**If you have any questions, feel free to contact me!**
