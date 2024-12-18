CREATE DATABASE Cafe
USE Cafe;

CREATE TABLE [Roles] (
  [RoleID] VARCHAR(10) PRIMARY KEY NOT NULL,
  [RoleName] NVARCHAR(50) NOT NULL
);

CREATE TABLE [Users] (
  [UserName] VARCHAR(20) PRIMARY KEY NOT NULL,
  [Userpassword] VARCHAR(20) NOT NULL,
  [FullName] NVARCHAR(100) NOT NULL,
  [Phone] CHAR(10) NOT NULL,
  [IdentityCard] NVARCHAR(50) NOT NULL,
  [RoleID] VARCHAR(10) NOT NULL,
  FOREIGN KEY ([RoleID]) REFERENCES [Roles]([RoleID])
);

CREATE TABLE [Category] (
  [CategoryID] VARCHAR(10) PRIMARY KEY,
  [CategoryName] NVARCHAR(50) NOT NULL,
  [Description] NVARCHAR(500)
);

CREATE TABLE [Product] (
  [ProductID] VARCHAR(10) PRIMARY KEY,
  [ProductName] NVARCHAR(50) NOT NULL,
  [Price] DECIMAL(18,2) NOT NULL,
  [CategoryID] VARCHAR(10),
  [Description] NVARCHAR(500),
  [Images] IMAGE,
  FOREIGN KEY ([CategoryID]) REFERENCES [Category]([CategoryID])
);

CREATE TABLE [Sizes] (
  [SizeName] NVARCHAR(50) PRIMARY KEY NOT NULL,
  [SizePrice] DECIMAL(18,2)
);

CREATE TABLE [ProductSize] (
  [ProductSizeID] INT IDENTITY(1,1) PRIMARY KEY,
  [SizeName] NVARCHAR(50),
  [ProductID] VARCHAR(10),
  FOREIGN KEY ([SizeName]) REFERENCES [Sizes]([SizeName]),
  FOREIGN KEY ([ProductID]) REFERENCES [Product]([ProductID])
);

CREATE TABLE [Area] (
  [AreaID] VARCHAR(10) PRIMARY KEY,
  [AreaName] NVARCHAR(50) NOT NULL
);

CREATE TABLE [CF_Table] (
  [TableID] VARCHAR(10) PRIMARY KEY,
  [TableName] NVARCHAR(50) NOT NULL,
  [AreaID] VARCHAR(10),
  FOREIGN KEY ([AreaID]) REFERENCES [Area]([AreaID])
);

CREATE TABLE [Orders] (
  [OrderID] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  [DateCheckIn] DATE DEFAULT (GETDATE()),
  [DateCheckOut] DATE,
  [Status] NVARCHAR(50),
  [TableID] VARCHAR(10),
  FOREIGN KEY ([TableID]) REFERENCES [CF_Table]([TableID])
);

CREATE TABLE [OrderDetail] (
  [OrderDetailID] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  [ProductSizeID] INT NOT NULL,
  [OrderID] INT NOT NULL,
  [Quantity] INT,
  FOREIGN KEY ([ProductSizeID]) REFERENCES [ProductSize]([ProductSizeID]),
  FOREIGN KEY ([OrderID]) REFERENCES [Orders]([OrderID])
);

CREATE TABLE [Bill] (
  [BillID] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  [OrderDetailID] INT NOT NULL,
  [PaymentDate] DATETIME,
  [PaymentStatus] NVARCHAR(50),
  [Total] DECIMAL(18,2) NOT NULL DEFAULT 0,
  FOREIGN KEY ([OrderDetailID]) REFERENCES [OrderDetail]([OrderDetailID])
);
