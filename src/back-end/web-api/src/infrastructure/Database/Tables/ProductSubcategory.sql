CREATE TABLE [Production].[ProductSubcategory]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProductCategoryId] INT NOT NULL, 
    [Name] NVARCHAR(100) NOT NULL, 
    [rowguid] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID()
)
