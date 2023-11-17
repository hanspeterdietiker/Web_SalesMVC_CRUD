USE [Web_SalesMVC_CRUD]
GO

SELECT [Id]
      ,[Name]
      ,[Email]
      ,[BirthDate]
      ,[BaseSalary]
      ,[DepartmentId]
  FROM [dbo].[Seller]

GO


USE [Web_SalesMVC_CRUD]
GO

INSERT INTO [dbo].[Seller]
           ([Name]
           ,[Email]
           ,[BirthDate]
           ,[BaseSalary]
           ,[DepartmentId])
     VALUES
           (<Name, nvarchar(max),>
           ,<Email, nvarchar(max),>
           ,<BirthDate, datetime2(7),>
           ,<BaseSalary, float,>
           ,<DepartmentId, int,>)
GO


USE [Web_SalesMVC_CRUD]
GO

UPDATE [dbo].[Seller]
   SET [Name] = <Name, nvarchar(max),>
      ,[Email] = <Email, nvarchar(max),>
      ,[BirthDate] = <BirthDate, datetime2(7),>
      ,[BaseSalary] = <BaseSalary, float,>
      ,[DepartmentId] = <DepartmentId, int,>
 WHERE <Critérios de Pesquisa,,>
GO

USE [Web_SalesMVC_CRUD]
GO

DELETE FROM [dbo].[Seller]
      WHERE <Critérios de Pesquisa,,>
GO



