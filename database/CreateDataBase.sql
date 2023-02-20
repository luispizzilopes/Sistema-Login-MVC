CREATE DATABASE [DbLogin]
GO
USE DbLogin

CREATE TABLE [dbo].[TabelaLogin](
	[usuario] [varchar](50) NOT NULL,
	[senha] [varchar](50) NOT NULL
) ON [PRIMARY]

INSERT INTO TabelaLogin values ('admin', 'admin')