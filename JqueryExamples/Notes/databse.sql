--------------------------------------------------
Create PROCEDURE [dbo].[usp_getCustomProperty]
AS
BEGIN

SELECT TOP 1000 [PropertyId]
      ,[PropertyName]
      ,[PropertyValue]
      ,[FieldLength]
      ,[IsActive]
      ,[FieldType]
	  ,[OrderId]
  FROM [Employee].[dbo].[tbl_CustomProperty]

  order by OrderId asc
END

-----------------------------------------------

CREATE TABLE [dbo].[tbl_CustomProperty](
	[PropertyId] [int] IDENTITY(1,1) NOT NULL,
	[PropertyName] [nvarchar](50) NULL,
	[PropertyValue] [nvarchar](500) NULL,
	[FieldLength] [int] NULL,
	[IsActive] [bit] NULL,
	[FieldType] [nvarchar](50) NULL,
	[OrderId] [int] NULL,
 CONSTRAINT [PK_tbl_CustomProperty] PRIMARY KEY CLUSTERED 
(
	[PropertyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO