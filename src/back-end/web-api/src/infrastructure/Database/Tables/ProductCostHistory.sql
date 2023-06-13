CREATE TABLE [Production].[ProductCostHistory]
(
	[ProductId] INT NOT NULL,
	[StartDate] DATETIME NOT NULL DEFAULT GETDATE(),
	[EndDate] DATETIME NULL,
	[StandardCost] MONEY NOT NULL,
	[ModifiedDate] DATETIME NOT NULL
)
