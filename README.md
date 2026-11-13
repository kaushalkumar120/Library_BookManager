# Library_BookManager
A C# Windows Forms Library Book Manager connected to SQL Server for adding, updating, deleting, searching, and displaying book records.

# 📚 Library Book Manager

A simple **C# Windows Forms Application** connected to a **SQL Server database** for managing library book records.

## 📌 Project Overview

**Library Book Manager** is a CRUD-based desktop application developed using **C# Windows Forms** and **SQL Server**.

The application allows users to add, update, delete, search, and view book records through a simple graphical interface.

Book records are displayed in a `DataGridView`.

## ✨ Features

- ➕ Add new books
- ✏️ Update book details
- 🗑️ Delete books
- 🔍 Search books
- 📋 Display all books
- 📊 View records using DataGridView
- 📖 Manage book availability
- 🗄️ Store data in SQL Server database
- 🧹 Clear input fields

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET
- **Application Type:** Windows Forms Application
- **Database:** SQL Server
- **IDE:** Visual Studio
- **Data Access:** ADO.NET
- **Database Library:** `System.Data.SqlClient`

## 🗃️ Database

The project uses a database named:

```text
LibraryDB
```

### Books Table

The `Books` table contains the following fields:

| Column | Data Type | Description |
|---|---|---|
| BookID | INT | Unique ID of the book |
| Title | VARCHAR | Book title |
| Author | VARCHAR | Author name |
| Category | VARCHAR | Book category |
| Available | BIT | Book availability |

### Table Structure

```text
Books
│
├── BookID
├── Title
├── Author
├── Category
└── Available
```

## 🔄 CRUD Operations

The application supports the four basic CRUD operations:

### Create
Add a new book record to the database.

### Read
Display existing book records in the `DataGridView`.

### Update
Modify the details of an existing book.

### Delete
Remove a selected book record from the database.

### Search
Search for books using the search field.

## 🖥️ Sample Interface

```text
+------------------------------------------------------+
|              LIBRARY BOOK MANAGER                    |
+------------------------------------------------------+
| Book ID:    [____________]                           |
| Title:      [____________]                           |
| Author:     [____________]                           |
| Category:   [____________]                           |
| Available:  ☐                                            |
|                                                      |
| [ Add ] [ Update ] [ Delete ] [ Search ] [ Clear ]  |
+------------------------------------------------------+
| BookID | Title | Author | Category | Available      |
|------------------------------------------------------|
| 1      | Java  | James  | Programming | Yes         |
| 2      | C#    | John   | Programming | Yes         |
+------------------------------------------------------+
```

## 📂 Project Structure

```text
LibraryBookManager/
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
└── README.md
```

## ▶️ How to Run

1. Open **Visual Studio**.
2. Open the `LibraryBookManager` project.
3. Create the `LibraryDB` database in SQL Server.
4. Create the `Books` table.
5. Check the database connection string in the C# code.
6. Build the project.
7. Run the application.
8. Use the buttons to add, update, delete, and search books.

## 🔌 Database Connection

The application uses a SQL Server connection similar to:

```text
Data Source=(localdb)\MSSQLLocalDB;
Initial Catalog=LibraryDB;
Integrated Security=True
```

Make sure SQL Server/LocalDB is available on the system before running the application.

## 📚 Concepts Used

This project demonstrates:

- C# Windows Forms
- SQL Server
- ADO.NET
- Database Connectivity
- CRUD Operations
- SQL Queries
- DataGridView
- Event Handling
- Input Validation
- Exception Handling
- Search Functionality

## 🎯 Learning Objective

The main objective of this project is to understand how to build a **database-connected desktop application using C# Windows Forms** and perform CRUD operations using SQL Server.

## 🚀 Future Improvements

The project can be improved by adding:

- Student/member management
- Issue and return book functionality
- Due-date management
- Fine calculation
- Login system
- Book category filtering
- Advanced search
- Database backup and restore

## 👨‍💻 Author

**Kaushal Kumar Rathour**

---

⭐ If you find this project useful, feel free to star the repository.
