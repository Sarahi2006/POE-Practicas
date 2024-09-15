CREATE DATABASE libraryDB
GO

USE libraryDB
GO

-- Crear tabla Libros
CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1),  
    Title NVARCHAR(255) NOT NULL,          
    Author NVARCHAR(255) NOT NULL,         
    PublishedYear INT                      
)
GO

-- Crear tabla Miembros
CREATE TABLE Members (
    MemberID INT PRIMARY KEY IDENTITY(1,1), 
    FullName NVARCHAR(255) NOT NULL,        
    JoinDate DATE NOT NULL,                 
    Email NVARCHAR(255)                     
)
GO

-- Crear tabla Prestamo
CREATE TABLE Loans (
    LoanID INT PRIMARY KEY IDENTITY(1,1),   
    LoanDate DATE NOT NULL,                 
    BookID INT NOT NULL,                    
    MemberID INT NOT NULL,                  
    FOREIGN KEY (BookID) REFERENCES Books(BookID), 
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID) 
)
GO

