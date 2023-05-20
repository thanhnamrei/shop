CREATE TABLE [Production].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(200) NOT NULL,
	rowguid UNIQUEIDENTIFIER DEFAULT NEWID(), 
    [ProductNumber] VARCHAR(50) NULL, 
    [Size] VARCHAR(50) NULL, 
    [Weight] FLOAT NULL, 
    [Color] VARCHAR(50) NULL, 
    [StandardCost] DECIMAL NULL, 
    [ProductSubcategoryId] INT NULL, 
    [CreatedDate] DATETIME NULL DEFAULT GETDATE(), 
    [CreatedBy] INT NULL, 
    [ModifiedDate] DATETIME NULL, 
    [ModifiedBy] INT NULL
)
