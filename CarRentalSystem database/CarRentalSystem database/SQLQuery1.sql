-- Create CarRentalDB
CREATE DATABASE CarRentalDB;
GO

-- Use the database
USE CarRentalDB;
GO

-- Create Cars table
CREATE TABLE Cars (
    CarID INT IDENTITY(1,1) PRIMARY KEY,
    Make VARCHAR(50),
    Model VARCHAR(50),
    Year INT,
    PricePerDay DECIMAL(10, 2),
    Status VARCHAR(20) -- Available, Rented
);
GO

-- Create Customers table
CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Phone VARCHAR(20),
    Email VARCHAR(100)
);
GO

-- Create Rentals table
CREATE TABLE Rentals (
    RentalID INT IDENTITY(1,1) PRIMARY KEY,
    CarID INT FOREIGN KEY REFERENCES Cars(CarID),
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    StartDate DATE,
    EndDate DATE,
    TotalPrice DECIMAL(10, 2)
);
GO
