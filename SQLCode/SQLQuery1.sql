-- Create Database
CREATE DATABASE WindowsFormsGUIApp;

-- Use the database
USE WindowsFormsGUIApp;

-- Create Users Table
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY, -- Unique ID for each user
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(255) NOT NULL UNIQUE, -- Ensures no duplicate emails
    EMPNumber AS CONCAT('EMP', RIGHT('000' + CAST(UserID AS VARCHAR(3)), 3)) PERSISTED, -- Deterministic EMPNumber
    Password NVARCHAR(255) NOT NULL, -- Store hashed passwords
    ContactNumber1 NVARCHAR(15) NOT NULL, -- Mandatory Contact Number
    ContactNumber2 NVARCHAR(15), -- Optional Contact Number
    Address1 NVARCHAR(255) NOT NULL, -- Mandatory Address
    Address2 NVARCHAR(255), -- Optional Address
    Role NVARCHAR(10) NOT NULL CHECK (Role IN ('Admin', 'User')), -- Role validation
    CreatedBy NVARCHAR(100) DEFAULT 'System' NOT NULL, -- Tracks who created the account
    CreatedAt DATETIME DEFAULT GETDATE() NOT NULL -- Timestamp for record creation
);

-- Insert Sample Data
INSERT INTO Users (Name, Email, Password, ContactNumber1, ContactNumber2, Address1, Address2, Role, CreatedBy)
VALUES 
('UdayaSri', 'udayasri@gmail.com', 'password', '0711234567', '0717654321', 'No. 15, Colombo Street', 'Apartment 5B', 'Admin', 'System'),
('Imasha', 'imasha@gmail.com', 'password2', '0719876543', NULL, 'No. 22, Kandy Lane', NULL, 'User', 'System');

-- View Data
SELECT * FROM Users;

SELECT UserID, Name, Email, EMPNumber, Role, CreatedBy, CreatedAt FROM Users;
