CREATE TABLE [Production].[ProductReview]
(
	[Id] INT IDENTITY PRIMARY KEY,
	[ProductId] INT NOT NULL,
	[ReviewerName] NVARCHAR(50) NOT NULL,
	[ReviewDate] DATETIME NOT NULL,
	[EmailAddress] NVARCHAR(50) NOT NULL,
	[Rating] INT NOT NULL,
	[Comments] NVARCHAR(500),
	[ModifiedDate] DATETIME)
