
-- TALENT MARKETPLACE - COMPLETE CLEAN SETUP (SQL SERVER | EF CORE ALIGNED)

USE master
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'TalentMarketPlace_dev')
BEGIN
    ALTER DATABASE TalentMarketPlace_dev SET SINGLE_USER WITH ROLLBACK IMMEDIATE
    DROP DATABASE TalentMarketPlace_dev
END
GO

WAITFOR DELAY '00:00:02'
GO

CREATE DATABASE TalentMarketPlace_dev
GO

USE TalentMarketPlace_dev
GO

CREATE TABLE SkillCategories (
    CategoryId INT IDENTITY PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500),
    DisplayOrder INT NOT NULL
);

CREATE TABLE Users (
    UserId INT IDENTITY PRIMARY KEY,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(500) NOT NULL,
    Role NVARCHAR(20) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);

CREATE TABLE Teams (
    TeamId INT IDENTITY PRIMARY KEY,
    TeamName NVARCHAR(100) NOT NULL,
    Department NVARCHAR(100) NOT NULL,
    Location NVARCHAR(100) NOT NULL,
    ManagerId INT,
    IsActive BIT DEFAULT 1
);

CREATE TABLE Employees (
    EmployeeId INT IDENTITY PRIMARY KEY,
    UserId INT NOT NULL UNIQUE,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    PhoneNumber NVARCHAR(20) NOT NULL,
    Location NVARCHAR(100) NOT NULL,
    TeamId INT,
    Designation NVARCHAR(100) NOT NULL,
    AvailabilityStatus NVARCHAR(20) NOT NULL,
    YearsOfExperience DECIMAL(4,2) NOT NULL,
    JoiningDate DATETIME,
    CreatedDate DATETIME DEFAULT GETDATE(),
    UpdatedDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserId) REFERENCES Users(UserId),
    FOREIGN KEY (TeamId) REFERENCES Teams(TeamId)
);

CREATE TABLE EmailHistory (
    Id INT IDENTITY PRIMARY KEY,
    SentDate DATETIME DEFAULT GETDATE(),
    RecipientCount INT NOT NULL,
    Subject NVARCHAR(500) NOT NULL,
    SentBy NVARCHAR(100),
    RecipientType NVARCHAR(50),
    RecipientList NVARCHAR(MAX),
    CcAddress NVARCHAR(500),
    SuccessCount INT DEFAULT 0,
    FailedCount INT DEFAULT 0
);

CREATE TABLE ScheduledEmails (
    Id INT IDENTITY PRIMARY KEY,
    Recipients NVARCHAR(MAX) NOT NULL,
    Subject NVARCHAR(500) NOT NULL,
    Body NVARCHAR(MAX) NOT NULL,
    ScheduledTime DATETIME NOT NULL,
    Status NVARCHAR(50) DEFAULT 'Pending',
    CreatedDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE __EFMigrationsHistory (
    MigrationId NVARCHAR(150) PRIMARY KEY,
    ProductVersion NVARCHAR(32) NOT NULL
);
