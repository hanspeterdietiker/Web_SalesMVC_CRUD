USE [Web_SalesMVC_CRUD]
GO

SELECT [Id]
      ,[Date]
      ,[Amount]
      ,[StatusModel]
      ,[SellerId]
  FROM [dbo].[SalesRecord]

GO

USE [Web_SalesMVC_CRUD]
GO

INSERT INTO [dbo].[SalesRecord]
           ([Date]
           ,[Amount]
           ,[StatusModel]
           ,[SellerId])
     VALUES
           (<Date, datetime2(7),>
           ,<Amount, float,>
           ,<StatusModel, int,>
           ,<SellerId, int,>)
GO

USE [Web_SalesMVC_CRUD]
GO

UPDATE [dbo].[SalesRecord]
   SET [Date] = <Date, datetime2(7),>
      ,[Amount] = <Amount, float,>
      ,[StatusModel] = <StatusModel, int,>
      ,[SellerId] = <SellerId, int,>
 WHERE <Critérios de Pesquisa,,>
GO

USE [Web_SalesMVC_CRUD]
GO

DELETE FROM [dbo].[SalesRecord]
      WHERE <Critérios de Pesquisa,,>
GO




