# 📚 Book Management API

An ASP.NET Core Web API project to manage a collection of books. Supports basic CRUD operations using Entity Framework Core with SQL Server.

---

## 🛠️ Tech Stack

- ASP.NET Core Web API (.NET 9)
- Entity Framework Core
- SQL Server (LocalDB)
- Visual Studio 2022+
- Swagger for API testing

---

## 🚀 How to Run the Project

### Prerequisites
- Visual Studio 2022 or later
- .NET SDK 9.0 installed
- SQL Server LocalDB

### Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/Preete07/BookManagementAPI.git
   cd BookManagementAPI

Apply EF Core Migration: 
   Run the following commands from the Package Manager Console in Visual Studio:
       1. Add a Migration
          Add-Migration InitialMigration
       2. Apply the Migration (Create DB)
          Update-Database
   This will create the BooksDb database and Books table

Sample API Requests & Responses:
🔍 Get All Books
Request:
GET /api/Books

Response:
[
  {
    "id": "c2313e7a-0ec2-41b1-8fd2-df504c6d78a9",
    "title": "The Alchemist",
    "author": "Paulo Coelho",
    "year": 1988
  },
  {
    "id": "4f01a91e-7d34-4a1f-b9ea-53cb4f1ad2de",
    "title": "Atomic Habits",
    "author": "James Clear",
    "year": 2018
  }
]

🔍 Get Book by ID
Request:
GET /api/Books/c2313e7a-0ec2-41b1-8fd2-df504c6d78a9

Response:
{
  "id": "c2313e7a-0ec2-41b1-8fd2-df504c6d78a9",
  "title": "The Alchemist",
  "author": "Paulo Coelho",
  "year": 1988
}

➕ Add a New Book
Request:
POST /api/Books
Content-Type: application/json

{
  "title": "Deep Work",
  "author": "Cal Newport",
  "year": 2016
}

Response:
{
  "id": "efcb1012-61a3-4703-bf1f-4f3bd1f0b0c5",
  "title": "Deep Work",
  "author": "Cal Newport",
  "year": 2016
}

🔄 Update a Book
Request:
PUT /api/Books/efcb1012-61a3-4703-bf1f-4f3bd1f0b0c5
Content-Type: application/json

{
  "title": "Deep Work: Rules for Focused Success",
  "author": "Cal Newport",
  "year": 2016
}

Response:
{
  "id": "efcb1012-61a3-4703-bf1f-4f3bd1f0b0c5",
  "title": "Deep Work: Rules for Focused Success",
  "author": "Cal Newport",
  "year": 2016
}

❌ Delete a Book
Request:
DELETE /api/Books/efcb1012-61a3-4703-bf1f-4f3bd1f0b0c5

Response:
204 No Content
