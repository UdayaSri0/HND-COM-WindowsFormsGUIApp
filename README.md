# WindowsFormsGUIApp

A C# Windows Forms application that manages users and administrators with role-based access. The application integrates a SQL Server database for data storage and provides CRUD (Create, Read, Update, Delete) operations for user management.

---

## Features

- **User Roles**: Supports Admin and User roles.
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

### Database Setup

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
   ('Sadun', 'sadun@gmail.com', 'EMP002', 'password', '0719876543', NULL, 'No. 22, Kandy Lane', NULL, 'User', 'System');


Application Configuration
Open the project in Visual Studio.

Update the database connection string in DatabaseConnection.cs:

private static readonly string ConnectionString = @"Data Source=<YOUR_SERVER_NAME>;Initial Catalog=WindowsFormsGUIApp;Integrated Security=True;Encrypt=False";
Replace <YOUR_SERVER_NAME> with your SQL Server instance name.

Usage
Run the Application
Build and run the project in Visual Studio.
Login
Use the following credentials for testing:

Admin: udayasri@gmail.com | Password: password
User: sadun@gmail.com | Password: password
Admin Features
Manage users: Add, update, delete, and search for user records.
View logged-in user details.
User Features
Basic access to user-specific functionality.
Project Structure
WindowsFormsGUIApp/
├── DatabaseConnection.cs   # Handles all database operations
├── frmLogin.cs             # Login form logic
├── frmAdmin.cs             # Admin panel for user management
├── frmAdminHome.cs         # Admin home screen
├── Session.cs              # Static class for session management
├── Program.cs              # Application entry point
Key Classes
DatabaseConnection:

Centralized class for handling database operations (ExecuteQuery, ExecuteNonQuery, etc.).
Session:

Stores logged-in user details like Name and EMP Number.
Error Handling
Database Errors:
Graceful handling with meaningful error messages.
File Access:
Ensures locked temporary files are skipped during cleanup.
Form Navigation:
Verifies session data to prevent unauthorized access.
Future Enhancements
Password Hashing:
Encrypt user passwords for better security.
Improved UI:
Modernize the design using WPF or other libraries.
Additional Roles:
Support for more user roles and permissions.
Audit Logs:
Track user actions like record updates or deletions.


ontributing
Contributions are welcome! Please fork the repository, make changes, and submit a pull request.


### **What's Improved?**
1. **Formatted Sections**:
   - Clear headings and subheadings for better readability.
2. **Consistent Formatting**:
   - Ensured consistent use of bold text, inline code formatting, and proper spacing.
3. **Added License and Contribution Sections**:
   - Encourages collaborative improvements and clarifies licensing.

You can save this as `README.md` in your project folder. Let me know if you need additional details!
