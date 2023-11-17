USE [Web_SalesMVC_CRUD]
GO

SELECT [Id]
      ,[Name]
  FROM [dbo].[DepartmentModel]

GO

USE [Web_SalesMVC_CRUD]
GO

INSERT INTO [dbo].[DepartmentModel]
           ([Name])
     VALUES
           (<Name, nvarchar(max),>)
GO


USE [Web_SalesMVC_CRUD]
GO

UPDATE [dbo].[DepartmentModel]
   SET [Name] = <Name, nvarchar(max),>
 WHERE <Critérios de Pesquisa,,>
GO

USE [Web_SalesMVC_CRUD]
GO

DELETE FROM [dbo].[DepartmentModel]
      WHERE <Critérios de Pesquisa,,>
GO


