IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'AdBoard')
	DROP DATABASE [AdBoard]
GO

CREATE DATABASE [AdBoard]  ON (NAME = N'AdBoard_Data', FILENAME = N'C:\Applications\Microsoft SQL Server\MSSQL\data\AdBoard_Data.MDF' , SIZE = 1, FILEGROWTH = 10%) LOG ON (NAME = N'AdBoard_Log', FILENAME = N'C:\Applications\Microsoft SQL Server\MSSQL\data\AdBoard_Log.LDF' , SIZE = 1, FILEGROWTH = 10%)
 COLLATE SQL_Latin1_General_CP1_CI_AS
GO

exec sp_dboption N'AdBoard', N'autoclose', N'true'
GO

exec sp_dboption N'AdBoard', N'bulkcopy', N'false'
GO

exec sp_dboption N'AdBoard', N'trunc. log', N'true'
GO

exec sp_dboption N'AdBoard', N'torn page detection', N'true'
GO

exec sp_dboption N'AdBoard', N'read only', N'false'
GO

exec sp_dboption N'AdBoard', N'dbo use', N'false'
GO

exec sp_dboption N'AdBoard', N'single', N'false'
GO

exec sp_dboption N'AdBoard', N'autoshrink', N'true'
GO

exec sp_dboption N'AdBoard', N'ANSI null default', N'false'
GO

exec sp_dboption N'AdBoard', N'recursive triggers', N'false'
GO

exec sp_dboption N'AdBoard', N'ANSI nulls', N'false'
GO

exec sp_dboption N'AdBoard', N'concat null yields null', N'false'
GO

exec sp_dboption N'AdBoard', N'cursor close on commit', N'false'
GO

exec sp_dboption N'AdBoard', N'default to local cursor', N'false'
GO

exec sp_dboption N'AdBoard', N'quoted identifier', N'false'
GO

exec sp_dboption N'AdBoard', N'ANSI warnings', N'false'
GO

exec sp_dboption N'AdBoard', N'auto create statistics', N'true'
GO

exec sp_dboption N'AdBoard', N'auto update statistics', N'true'
GO

use [AdBoard]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Items_Categories]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Items] DROP CONSTRAINT FK_Items_Categories
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Items]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Items]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Categories]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Categories]
GO

CREATE TABLE [dbo].[Categories] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Items] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Title] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Price] [smallmoney] NOT NULL ,
	[Description] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Category_ID] [int] NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Categories] WITH NOCHECK ADD 
	CONSTRAINT [PK_Categories] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Items] WITH NOCHECK ADD 
	CONSTRAINT [PK_Items] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Items] ADD 
	CONSTRAINT [FK_Items_Categories] FOREIGN KEY 
	(
		[Category_ID]
	) REFERENCES [dbo].[Categories] (
		[ID]
	)
GO

