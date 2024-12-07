# WindowsFormsGUIApp

A C# Windows Forms application that manages users and administrators with role-based access. The application integrates a SQL Server database for data storage and provides CRUD (Create, Read, Update, Delete) operations for user management.

---

## Features

- **User Roles**: Support for Admin and User roles.
- **User Management**:
  - Add, update, delete, and search for users.
- **Authentication**:
  - Login system with role-based navigation.
- **DataGridView**:
  - Displays user records with selectable rows.
- **Session Management**:
  - Tracks the logged-in user details (`Name` and `EMP Number`).
- **Graceful Exit and Logout**:
  - Exit and logout functionality with confirmation prompts.
- **Dynamic Search**:
  - Allows searching users by multiple fields such as `Name`, `Email`, or `EMP Number`.
- **Database Integration**:
  - Uses SQL Server for data storage with parameterized queries for security.

---

## Prerequisites

1. **Software**:
   - Visual Studio 2019 or later
   - SQL Server 2019 or later
2. **Dependencies**:
   - .NET Framework 4.7.2 or later

---

## Setup

### 1. Database Setup
1. Open SQL Server Management Studio (SSMS).
2. Execute the following script to create the database and `Users` table:

   ```sql
   -- Create Database
   CREATE DATABASE WindowsFormsGUIApp;

   -- Use the database
   USE WindowsFormsGUIApp;

   -- Create Users Table
   CREATE TABLE Users (
       UserID INT IDENTITY(1,1) PRIMARY KEY,
       Name NVARCHAR(100) NOT NULL,
       Email NVARCHAR(255) NOT NULL UNIQUE,
       EMPNumber NVARCHAR(50) NOT NULL UNIQUE,
       Password NVARCHAR(255) NOT NULL,
       ContactNumber1 NVARCHAR(15) NOT NULL,
       ContactNumber2 NVARCHAR(15),
       Address1 NVARCHAR(255) NOT NULL,
       Address2 NVARCHAR(255),
       Role NVARCHAR(10) NOT NULL CHECK (Role IN ('Admin', 'User')),
       CreatedBy NVARCHAR(100) NOT NULL,
       CreatedAt DATETIME DEFAULT GETDATE() NOT NULL
   );

   -- Insert Sample Data
   INSERT INTO Users (Name, Email, EMPNumber, Password, ContactNumber1, ContactNumber2, Address1, Address2, Role, CreatedBy)
   VALUES 
   ('UdayaSri', 'udayasri@gmail.com', 'EMP001', 'password', '0711234567', '0717654321', 'No. 15, Colombo Street', 'Apartment 5B', 'Admin', 'System'),
   ('Imasha', 'imasha@gmail.com', 'EMP002', 'password', '0719876543', NULL, 'No. 22, Kandy Lane', NULL, 'User', 'System');


WindowsFormsGUIApp/
├── DatabaseConnection.cs   # Handles all database operations
├── frmLogin.cs             # Login form logic
├── frmAdmin.cs             # Admin panel for user management
├── frmAdminHome.cs         # Admin home screen
├── Session.cs              # Static class for session management
├── Program.cs              # Application entry point
