/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
insert into Production.Product(Id,Name,ProductNumber,Size,Weight,Color,StandardCost,ProductSubcategoryId)
values(1,N'Áo thun Uni','A1-B','L',0.2,'Black',0.0,1);



insert into Production.ProductReview values(1,N'Thanh Nam',GETDATE(),N'thanhnam.rei@gmail.com',5,N'Very goods',null)