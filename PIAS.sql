USE [master]
GO
/****** Object:  Database [PIASDB]    Script Date: 1/3/2017 05:23:44 ب.ظ ******/
CREATE DATABASE [PIASDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PIASDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER2014\MSSQL\DATA\PIASDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PIASDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER2014\MSSQL\DATA\PIASDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PIASDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PIASDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PIASDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PIASDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PIASDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PIASDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PIASDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PIASDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PIASDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PIASDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PIASDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PIASDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PIASDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PIASDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PIASDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PIASDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PIASDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PIASDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PIASDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PIASDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PIASDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PIASDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PIASDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PIASDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PIASDB] SET RECOVERY FULL 
GO
ALTER DATABASE [PIASDB] SET  MULTI_USER 
GO
ALTER DATABASE [PIASDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PIASDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PIASDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PIASDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PIASDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PIASDB', N'ON'
GO
USE [PIASDB]
GO
/****** Object:  User [mohsen]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
CREATE USER [mohsen] FOR LOGIN [mohsen] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [3015]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
CREATE USER [3015] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  UserDefinedFunction [dbo].[daydiff]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[daydiff](@date1 NCHAR(10),@date2 NCHAR(10))

RETURNS INT
AS
BEGIN
		
	DECLARE @daydiff INT
	DECLARE @diff INT	
	SET @daydiff=0
	SET @diff=0

	DECLARE @ddate1 INT
	DECLARE @mdate1 INT
	DECLARE @ydate1 INT

	DECLARE @ddate2 INT
	DECLARE @mdate2 INT
	DECLARE @ydate2 INT

	DECLARE @i INT
	DECLARE @j INT
	DECLARE @s BIT


	--------------------------------
	SET @ddate1=SUBSTRING(@date1,9,2)
	SET @mdate1=SUBSTRING(@date1,6,2)
	SET @ydate1=SUBSTRING(@date1,1,4)

	SET @ddate2=SUBSTRING(@date2,9,2)
	SET @mdate2=SUBSTRING(@date2,6,2)
	SET @ydate2=SUBSTRING(@date2,1,4)
	--------------------------------


		
	IF(@ydate1=@ydate2)
		BEGIN
			
			SET @i=@mdate1
			WHILE(@i<@mdate2)
			BEGIN
				IF(@i<=6)
					SET @daydiff=@daydiff+31
				IF(@i>6 AND @i<12)
					SET @daydiff=@daydiff+30
				IF(@i=12)
					SET @daydiff=@daydiff+29
				SET @i=@i+1
			END	
			SET @daydiff=@daydiff+(@ddate2-@ddate1)	
		END		
		
	IF(@ydate1<>@ydate2)
		BEGIN
			
			SET @j=@ydate1
			WHILE(@j<@ydate2)
			BEGIN
				SET @daydiff=@daydiff+365		
				IF(@mdate2<@mdate1)
				BEGIN
					DECLARE @temp INT 
					SET @s=1	
					
					SET @temp=@ddate1
					SET @ddate1=@ddate2	
					SET @ddate2=@temp
					
					SET @temp=@mdate1
					SET @mdate1=@mdate2	
					SET @mdate2=@temp
						
				END
			SET @j=@j+1		
			END
			-- اضافه کردن سال کبیسه 
			SET @j=@ydate1
			WHILE(@j<=@ydate2)
			BEGIN
				IF(@j%33=1 OR @j%33=5 OR @j%33=9 OR @j%33=13 OR @j%33=17 OR @j%33=22 OR @j%33=26 OR @j%33=30)
					SET @daydiff=@daydiff+1	
				SET @j=@j+1			
			END
			
			SET @i=@mdate1
			WHILE(@i<@mdate2)
			BEGIN
				IF(@i<=6)				
					SET @diff=@diff+31				
				IF(@i>6 AND @i<12)				
					SET @diff=@diff+30				
				IF(@i=12)				
					SET @diff=@diff+29				
				SET @i=@i+1
			END	
			IF(@s=1)
				SET @daydiff= @daydiff - @diff-((@ddate2-@ddate1))
			ELSE
				SET @daydiff= @daydiff + @diff-((@ddate2-@ddate1))
			 		
		END
		RETURN @daydiff

END








GO
/****** Object:  Table [dbo].[Tb_Client]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Client](
	[DeviceStateID] [int] IDENTITY(1,1) NOT NULL,
	[DeviceID] [int] NOT NULL,
	[DeviceLineId] [int] NOT NULL,
	[StartDate] [nvarchar](10) NULL,
	[StartTime] [nvarchar](12) NULL,
	[EndDate] [nvarchar](10) NULL,
	[EndTime] [nvarchar](12) NULL,
	[Duration] [int] NULL,
	[StateId] [int] NOT NULL,
	[Count] [int] NULL,
	[MiladiStartDateTime] [datetime] NULL,
	[MiladiFinishDateTime] [datetime] NULL,
 CONSTRAINT [PK_Tb_Client] PRIMARY KEY CLUSTERED 
(
	[DeviceStateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_Devices]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Devices](
	[DeviceId] [int] IDENTITY(1,1) NOT NULL,
	[DeviceDesc] [nvarchar](50) NOT NULL,
	[ComputerName] [nvarchar](50) NOT NULL,
	[PortName] [nvarchar](50) NOT NULL,
	[Active] [bit] NOT NULL CONSTRAINT [DF_Tb_Devices_Active]  DEFAULT ((0)),
 CONSTRAINT [PK_Tb_Devices] PRIMARY KEY CLUSTERED 
(
	[DeviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_DevicesLine]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_DevicesLine](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LineId] [int] NOT NULL,
	[LineDesc] [nvarchar](50) NOT NULL,
	[DeviceId] [int] NOT NULL,
	[PulsID] [int] NOT NULL,
	[InputPortTypeId] [int] NOT NULL,
	[ProductLineId] [int] NOT NULL,
	[ActiveColor] [nvarchar](50) NOT NULL,
	[DeActiveColor] [nvarchar](50) NOT NULL,
	[LineActive] [bit] NOT NULL CONSTRAINT [DF_Tb_DevicesLine_LineActive]  DEFAULT ((0)),
	[ActiveStateDesc] [nvarchar](50) NULL,
	[DeActiveStateDesc] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tb_DevicesLine] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_InputPortType]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_InputPortType](
	[InputPortTypeId] [int] IDENTITY(1,1) NOT NULL,
	[InputPortType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tb_InputType] PRIMARY KEY CLUSTERED 
(
	[InputPortTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_ProductLines]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_ProductLines](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductLineId] [nvarchar](50) NOT NULL,
	[ProductLineDesc] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[MizaneTolid] [nvarchar](50) NULL,
	[SalonDesc] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tb_ProductLines] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_PulsType]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_PulsType](
	[PulsTypeId] [int] IDENTITY(1,1) NOT NULL,
	[PulsTypeDesc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tb_PulsType] PRIMARY KEY CLUSTERED 
(
	[PulsTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_Station]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Station](
	[StationId] [int] IDENTITY(1,1) NOT NULL,
	[ProductLineId] [int] NOT NULL,
	[DeviceId] [int] NOT NULL,
	[DeviceLineId] [int] NOT NULL,
	[StationDesc] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
 CONSTRAINT [PK_Tb_Station] PRIMARY KEY CLUSTERED 
(
	[StationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[GetDeviceInfo]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION  [dbo].[GetDeviceInfo]()
RETURNS TABLE 
AS
RETURN 
(
	SELECT        DeviceId, DeviceDesc, ComputerName, PortName,
                             (SELECT        CASE active WHEN 'FALSE' THEN N'غیر فعال' ELSE N'فعال' END AS Expr1) AS active
		FROM            dbo.Tb_Devices

)






GO
/****** Object:  UserDefinedFunction [dbo].[GetLastStateFromSpecialLineStateByDate]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION  [dbo].[GetLastStateFromSpecialLineStateByDate](@DeviceId nvarchar(50) , @LineId nvarchar(50) ,@StartDateTime nvarchar(50) ,@StartTime nvarchar(50))
RETURNS TABLE 
AS
RETURN 
(
	 SELECT        TOP (1) DeviceStateID, DeviceID, DeviceLineId, StartDate, StartTime, EndDate, EndTime, Duration, StateId, Count, MiladiStartDateTime, MiladiFinishDateTime
FROM            Tb_Client
WHERE        (MiladiStartDateTime >= CONVERT(DATETIME, @StartDateTime +' ' +  @StartTime , 102)) AND (DeviceID = @DeviceId) AND (DeviceLineId = @LineId)
ORDER BY DeviceStateID DESC
)


GO
/****** Object:  UserDefinedFunction [dbo].[GetListOfDeviceByProductLine]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE  FUNCTION  [dbo].[GetListOfDeviceByProductLine](@ProductLineId nvarchar(50))
RETURNS TABLE 
AS
RETURN 
(
			SELECT DISTINCT dbo.Tb_Devices.DeviceDesc, dbo.Tb_Devices.DeviceId, dbo.Tb_ProductLines.ID
			FROM            dbo.Tb_Devices INNER JOIN
									 dbo.Tb_DevicesLine ON dbo.Tb_Devices.DeviceId = dbo.Tb_DevicesLine.DeviceId INNER JOIN
									 dbo.Tb_ProductLines ON dbo.Tb_DevicesLine.ProductLineId = dbo.Tb_ProductLines.ID
			WHERE        (dbo.Tb_ProductLines.ID = @ProductLineId)
)





GO
/****** Object:  UserDefinedFunction [dbo].[GetListOfInputPortTypes]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,mohsen AZADFALLAH>
-- Create date: <Create Date,1395/09/05,>
-- Description:	<Descriptio , Return List Of InputsPortType>
-- =============================================
CREATE FUNCTION [dbo].[GetListOfInputPortTypes]()
RETURNS TABLE 
AS
RETURN 
(
	select * from  Tb_InputPortType  
)






GO
/****** Object:  UserDefinedFunction [dbo].[GetListOfProductLines]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,mohsen AZADFALLAH>
-- Create date: <Create Date,1395/09/06,>
-- Description:	<Descriptio , Return List Of Product Lines>
-- =============================================
CREATE FUNCTION [dbo].[GetListOfProductLines]()
RETURNS TABLE 
AS
RETURN 
(
	 select * from   [dbo].[Tb_ProductLines]
)






GO
/****** Object:  UserDefinedFunction [dbo].[GetListOfStations]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[GetListOfStations]()
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
SELECT        dbo.Tb_Station.StationDesc, dbo.Tb_Station.Description, dbo.Tb_ProductLines.ProductLineDesc, dbo.Tb_Devices.DeviceDesc, dbo.Tb_DevicesLine.LineDesc, dbo.Tb_Station.StationId, dbo.Tb_Station.DeviceId, 
                         dbo.Tb_DevicesLine.LineId, dbo.Tb_PulsType.PulsTypeId, dbo.Tb_DevicesLine.ActiveStateDesc, dbo.Tb_DevicesLine.DeActiveStateDesc, dbo.Tb_ProductLines.ID AS ProductLineID
FROM            dbo.Tb_DevicesLine INNER JOIN
                         dbo.Tb_ProductLines INNER JOIN
                         dbo.Tb_Station INNER JOIN
                         dbo.Tb_Devices ON dbo.Tb_Station.DeviceId = dbo.Tb_Devices.DeviceId ON dbo.Tb_ProductLines.ID = dbo.Tb_Station.ProductLineId ON dbo.Tb_DevicesLine.ID = dbo.Tb_Station.DeviceLineId INNER JOIN
                         dbo.Tb_PulsType ON dbo.Tb_DevicesLine.PulsID = dbo.Tb_PulsType.PulsTypeId
)





GO
/****** Object:  UserDefinedFunction [dbo].[GetPulsTypes]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,mohsen AZADFALLAH>
-- Create date: <Create Date,1395/09/05,>
-- Description:	<Descriptio , Return List Of Puls Types>
-- =============================================
CREATE FUNCTION  [dbo].[GetPulsTypes]()
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT * from Tb_PulsType 
)






GO
/****** Object:  UserDefinedFunction [dbo].[GetSpecialLineStateByDate]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[GetSpecialLineStateByDate](@DeviceId nvarchar(50) , @LineId nvarchar(50) ,@StartDateTime nvarchar(50) ,@StartTime nvarchar(50))

RETURNS TABLE 
AS
RETURN 
(
	SELECT        TOP (200) SUM(Duration) AS SumDuration, StateId
FROM            dbo.Tb_Client
WHERE        (MiladiStartDateTime >= CONVERT(DATETIME, @StartDateTime +' ' +  @StartTime , 102)) AND (DeviceLineId = @LineId) AND (DeviceID = @DeviceId)
GROUP BY StateId
ORDER BY StateId



)



GO
/****** Object:  UserDefinedFunction [dbo].[GetSpecialLineStateByDateForCount]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE  FUNCTION [dbo].[GetSpecialLineStateByDateForCount](@DeviceId nvarchar(50) , @LineId nvarchar(50) ,@StartDateTime nvarchar(50) ,@StartTime nvarchar(50))

RETURNS TABLE 
AS
RETURN 
(
SELECT        TOP (200) COUNT(dbo.Tb_Client.DeviceStateID) AS Count
FROM            dbo.Tb_Client INNER JOIN
                         dbo.Tb_DevicesLine ON dbo.Tb_Client.DeviceLineId = dbo.Tb_DevicesLine.LineId INNER JOIN
                         dbo.Tb_PulsType ON dbo.Tb_DevicesLine.PulsID = dbo.Tb_PulsType.PulsTypeId
WHERE        (dbo.Tb_Client.DeviceID = @DeviceId) AND (dbo.Tb_Client.DeviceLineId = @LineId) AND (dbo.Tb_Client.MiladiStartDateTime >= CONVERT(DATETIME, @StartDateTime +' ' +  @StartTime , 102)) AND (dbo.Tb_PulsType.PulsTypeId = 1)AND (dbo.Tb_Client.StateId = 1)
 
)



GO
/****** Object:  View [dbo].[Vw_LineInfo]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_LineInfo]
AS
SELECT        dbo.Tb_Devices.DeviceId, dbo.Tb_DevicesLine.ID, dbo.Tb_DevicesLine.LineId, dbo.Tb_DevicesLine.LineDesc, dbo.Tb_DevicesLine.PulsID, dbo.Tb_DevicesLine.InputPortTypeId, 
                         dbo.Tb_DevicesLine.ProductLineId, dbo.Tb_DevicesLine.ActiveColor, dbo.Tb_DevicesLine.DeActiveColor, dbo.Tb_DevicesLine.LineActive, dbo.Tb_Devices.DeviceDesc, dbo.Tb_Devices.ComputerName, 
                         dbo.Tb_Devices.PortName, dbo.Tb_Devices.Active, dbo.Tb_DevicesLine.ActiveStateDesc, dbo.Tb_DevicesLine.DeActiveStateDesc
FROM            dbo.Tb_Devices INNER JOIN
                         dbo.Tb_DevicesLine ON dbo.Tb_Devices.DeviceId = dbo.Tb_DevicesLine.DeviceId



GO
SET IDENTITY_INSERT [dbo].[Tb_Client] ON 

INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5130, 1048, 8, N'1395/10/10', N'23:50:58:729', N'1395/10/11', N'0:35:35:941', NULL, 0, 1274, CAST(N'2016-12-30 23:50:58.000' AS DateTime), CAST(N'2016-12-31 00:35:35.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5131, 1048, 2, N'1395/10/10', N'23:55:48:866', N'1395/10/10', N'23:55:50:677', 0, 1, 4, CAST(N'2016-12-30 23:55:48.000' AS DateTime), CAST(N'2016-12-30 23:55:50.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5132, 1048, 2, N'1395/10/10', N'23:55:51:281', N'1395/10/11', N'0:35:35:900', NULL, 1, 1000, CAST(N'2016-12-30 23:55:51.000' AS DateTime), CAST(N'2016-12-31 00:35:35.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5133, 1048, 9, N'1395/10/11', N'0:38:56:506', N'1395/10/11', N'0:45:31:98', NULL, 0, 93, CAST(N'2016-12-31 00:38:56.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5134, 1048, 10, N'1395/10/11', N'0:38:56:537', N'1395/10/11', N'0:45:31:104', NULL, 0, 93, CAST(N'2016-12-31 00:38:56.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5135, 1048, 11, N'1395/10/11', N'0:38:56:560', N'1395/10/11', N'0:45:31:111', NULL, 0, 93, CAST(N'2016-12-31 00:38:56.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5136, 1048, 12, N'1395/10/11', N'0:38:56:598', N'1395/10/11', N'0:45:31:118', NULL, 0, 93, CAST(N'2016-12-31 00:38:56.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5137, 1048, 13, N'1395/10/11', N'0:38:56:625', N'1395/10/11', N'0:45:31:124', NULL, 0, 93, CAST(N'2016-12-31 00:38:56.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5138, 1048, 14, N'1395/10/11', N'0:38:56:646', N'1395/10/11', N'0:45:31:131', NULL, 0, 93, CAST(N'2016-12-31 00:38:56.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5139, 1048, 15, N'1395/10/11', N'0:38:56:667', N'1395/10/11', N'0:45:31:137', NULL, 0, 93, CAST(N'2016-12-31 00:38:56.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5140, 1048, 16, N'1395/10/11', N'0:38:56:688', N'1395/10/11', N'0:45:31:143', NULL, 0, 93, CAST(N'2016-12-31 00:38:56.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5141, 1048, 1, N'1395/10/11', N'0:38:56:717', N'1395/10/11', N'0:45:31:151', 10, 0, 93, CAST(N'2016-12-31 00:38:56.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5142, 1048, 2, N'1395/10/11', N'0:39:3:911', N'1395/10/11', N'0:45:30:840', 6, 1, 91, CAST(N'2016-12-31 00:39:03.000' AS DateTime), CAST(N'2016-12-31 00:45:30.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5143, 1048, 3, N'1395/10/11', N'0:39:3:929', N'1395/10/11', N'0:45:31:4', NULL, 0, 92, CAST(N'2016-12-31 00:39:03.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5144, 1048, 4, N'1395/10/11', N'0:39:3:948', N'1395/10/11', N'0:45:46:166', NULL, 0, 93, CAST(N'2016-12-31 00:39:03.000' AS DateTime), CAST(N'2016-12-31 00:45:46.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5145, 1048, 5, N'1395/10/11', N'0:39:3:969', N'1395/10/11', N'0:45:46:176', NULL, 0, 93, CAST(N'2016-12-31 00:39:03.000' AS DateTime), CAST(N'2016-12-31 00:45:46.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5146, 1048, 6, N'1395/10/11', N'0:39:3:989', N'1395/10/11', N'0:45:46:187', NULL, 0, 93, CAST(N'2016-12-31 00:39:03.000' AS DateTime), CAST(N'2016-12-31 00:45:46.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5147, 1048, 7, N'1395/10/11', N'0:39:4:3', N'1395/10/11', N'0:45:46:196', NULL, 0, 93, CAST(N'2016-12-31 00:39:04.000' AS DateTime), CAST(N'2016-12-31 00:45:46.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5148, 1048, 8, N'1395/10/11', N'0:39:4:20', N'1395/10/11', N'0:45:46:203', NULL, 0, 93, CAST(N'2016-12-31 00:39:04.000' AS DateTime), CAST(N'2016-12-31 00:45:46.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5149, 1048, 17, N'1395/10/11', N'0:39:4:43', N'1395/10/11', N'0:45:31:44', NULL, 0, 92, CAST(N'2016-12-31 00:39:04.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5150, 1048, 18, N'1395/10/11', N'0:39:4:60', N'1395/10/11', N'0:45:31:51', NULL, 0, 92, CAST(N'2016-12-31 00:39:04.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5151, 1048, 19, N'1395/10/11', N'0:39:4:76', N'1395/10/11', N'0:45:31:58', NULL, 0, 92, CAST(N'2016-12-31 00:39:04.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5152, 1048, 20, N'1395/10/11', N'0:39:4:91', N'1395/10/11', N'0:45:31:65', NULL, 0, 92, CAST(N'2016-12-31 00:39:04.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5153, 1048, 21, N'1395/10/11', N'0:39:4:108', N'1395/10/11', N'0:45:31:72', NULL, 0, 92, CAST(N'2016-12-31 00:39:04.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5154, 1048, 22, N'1395/10/11', N'0:39:4:146', N'1395/10/11', N'0:45:31:78', NULL, 0, 92, CAST(N'2016-12-31 00:39:04.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5155, 1048, 23, N'1395/10/11', N'0:39:4:171', N'1395/10/11', N'0:45:31:84', NULL, 0, 92, CAST(N'2016-12-31 00:39:04.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5156, 1048, 24, N'1395/10/11', N'0:39:4:200', N'1395/10/11', N'0:45:31:90', NULL, 0, 92, CAST(N'2016-12-31 00:39:04.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5157, 1048, 2, N'1395/10/11', N'0:45:31:3', N'1395/10/11', N'0:45:31:158', NULL, 0, 2, CAST(N'2016-12-31 00:45:31.000' AS DateTime), CAST(N'2016-12-31 00:45:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5158, 1048, 9, N'1395/10/11', N'0:46:49:532', N'1395/10/11', N'6:37:39:697', NULL, 0, 373, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5159, 1048, 10, N'1395/10/11', N'0:46:49:540', N'1395/10/11', N'6:37:39:705', NULL, 0, 375, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5160, 1048, 11, N'1395/10/11', N'0:46:49:547', N'1395/10/11', N'6:37:39:713', NULL, 0, 375, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5161, 1048, 12, N'1395/10/11', N'0:46:49:553', N'1395/10/11', N'6:37:39:731', NULL, 0, 375, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5162, 1048, 13, N'1395/10/11', N'0:46:49:559', N'1395/10/11', N'6:37:39:742', NULL, 0, 374, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5163, 1048, 14, N'1395/10/11', N'0:46:49:566', N'1395/10/11', N'6:37:39:752', NULL, 0, 374, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5164, 1048, 15, N'1395/10/11', N'0:46:49:572', N'1395/10/11', N'6:37:39:762', NULL, 0, 372, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5165, 1048, 16, N'1395/10/11', N'0:46:49:578', N'1395/10/11', N'6:37:39:773', NULL, 0, 368, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5166, 1048, 1, N'1395/10/11', N'0:46:49:586', N'1395/10/11', N'6:37:39:783', 20, 0, 374, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5167, 1048, 2, N'1395/10/11', N'0:46:49:593', N'1395/10/11', N'0:52:39:982', 5, 0, 121, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 00:52:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5168, 1048, 3, N'1395/10/11', N'0:46:49:600', N'1395/10/11', N'6:37:39:587', NULL, 0, 371, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5169, 1048, 4, N'1395/10/11', N'0:46:49:606', N'1395/10/11', N'6:37:54:802', NULL, 0, 371, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:54.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5170, 1048, 5, N'1395/10/11', N'0:46:49:613', N'1395/10/11', N'6:37:54:809', NULL, 0, 377, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:54.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5171, 1048, 6, N'1395/10/11', N'0:46:49:619', N'1395/10/11', N'6:37:54:816', NULL, 0, 378, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:54.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5172, 1048, 7, N'1395/10/11', N'0:46:49:626', N'1395/10/11', N'6:37:54:825', NULL, 0, 378, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:54.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5173, 1048, 8, N'1395/10/11', N'0:46:49:633', N'1395/10/11', N'6:37:54:832', NULL, 0, 378, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:54.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5174, 1048, 17, N'1395/10/11', N'0:46:49:641', N'1395/10/11', N'6:37:39:629', NULL, 0, 373, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5175, 1048, 18, N'1395/10/11', N'0:46:49:648', N'1395/10/11', N'6:37:39:637', NULL, 0, 373, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5176, 1048, 19, N'1395/10/11', N'0:46:49:654', N'1395/10/11', N'6:37:39:644', NULL, 0, 373, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5177, 1048, 20, N'1395/10/11', N'0:46:49:661', N'1395/10/11', N'6:37:39:652', NULL, 0, 373, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5178, 1048, 21, N'1395/10/11', N'0:46:49:668', N'1395/10/11', N'6:37:39:659', NULL, 0, 373, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5179, 1048, 22, N'1395/10/11', N'0:46:49:676', N'1395/10/11', N'6:37:39:666', NULL, 0, 373, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5180, 1048, 23, N'1395/10/11', N'0:46:49:678', N'1395/10/11', N'6:37:39:677', NULL, 0, 373, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5181, 1048, 24, N'1395/10/11', N'0:46:49:680', N'1395/10/11', N'6:37:39:687', NULL, 0, 371, CAST(N'2016-12-31 00:46:49.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5182, 1048, 2, N'1395/10/11', N'0:52:40:139', N'1395/10/11', N'6:37:39:791', NULL, 1, 256, CAST(N'2016-12-31 00:52:40.000' AS DateTime), CAST(N'2016-12-31 06:37:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5183, 1048, 9, N'1395/10/11', N'9:52:25:103', N'1395/10/11', N'10:38:15:961', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5184, 1048, 10, N'1395/10/11', N'9:52:25:117', N'1395/10/11', N'10:38:31:157', NULL, 0, 895, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5185, 1048, 11, N'1395/10/11', N'9:52:25:132', N'1395/10/11', N'10:38:31:170', NULL, 0, 895, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5186, 1048, 12, N'1395/10/11', N'9:52:25:144', N'1395/10/11', N'10:38:31:181', NULL, 0, 895, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5187, 1048, 13, N'1395/10/11', N'9:52:25:150', N'1395/10/11', N'10:38:15:991', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5188, 1048, 14, N'1395/10/11', N'9:52:25:156', N'1395/10/11', N'10:38:15:999', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5189, 1048, 15, N'1395/10/11', N'9:52:25:162', N'1395/10/11', N'10:38:16:8', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5190, 1048, 16, N'1395/10/11', N'9:52:25:169', N'1395/10/11', N'10:38:16:16', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5191, 1048, 1, N'1395/10/11', N'9:52:25:176', N'1395/10/11', N'10:38:16:25', NULL, 1, 893, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5192, 1048, 2, N'1395/10/11', N'9:52:25:182', N'1395/10/11', N'10:38:16:34', NULL, 0, 893, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5193, 1048, 3, N'1395/10/11', N'9:52:25:188', N'1395/10/11', N'10:38:16:41', NULL, 1, 893, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5194, 1048, 4, N'1395/10/11', N'9:52:25:194', N'1395/10/11', N'10:38:16:48', NULL, 0, 893, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5195, 1048, 5, N'1395/10/11', N'9:52:25:199', N'1395/10/11', N'10:38:16:55', NULL, 0, 893, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5196, 1048, 6, N'1395/10/11', N'9:52:25:208', N'1395/10/11', N'10:38:16:62', NULL, 0, 893, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5197, 1048, 7, N'1395/10/11', N'9:52:25:214', N'1395/10/11', N'10:38:16:70', NULL, 0, 893, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5198, 1048, 8, N'1395/10/11', N'9:52:25:225', N'1395/10/11', N'10:38:16:80', NULL, 0, 893, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5199, 1048, 17, N'1395/10/11', N'9:52:25:232', N'1395/10/11', N'10:38:16:90', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5200, 1048, 18, N'1395/10/11', N'9:52:25:240', N'1395/10/11', N'10:38:16:97', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5201, 1048, 19, N'1395/10/11', N'9:52:25:246', N'1395/10/11', N'10:38:16:105', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5202, 1048, 20, N'1395/10/11', N'9:52:25:254', N'1395/10/11', N'10:38:16:112', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5203, 1048, 21, N'1395/10/11', N'9:52:25:264', N'1395/10/11', N'10:38:16:121', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5204, 1048, 22, N'1395/10/11', N'9:52:25:272', N'1395/10/11', N'10:38:16:130', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5205, 1048, 23, N'1395/10/11', N'9:52:25:273', N'1395/10/11', N'10:38:16:138', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5206, 1048, 24, N'1395/10/11', N'9:52:25:275', N'1395/10/11', N'10:38:16:146', NULL, 0, 894, CAST(N'2016-12-31 09:52:25.000' AS DateTime), CAST(N'2016-12-31 10:38:16.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Tb_Client] OFF
SET IDENTITY_INSERT [dbo].[Tb_Devices] ON 

INSERT [dbo].[Tb_Devices] ([DeviceId], [DeviceDesc], [ComputerName], [PortName], [Active]) VALUES (1048, N'دستگاه آزمایشی', N'pc', N'COM3', 1)
SET IDENTITY_INSERT [dbo].[Tb_Devices] OFF
SET IDENTITY_INSERT [dbo].[Tb_DevicesLine] ON 

INSERT [dbo].[Tb_DevicesLine] ([ID], [LineId], [LineDesc], [DeviceId], [PulsID], [InputPortTypeId], [ProductLineId], [ActiveColor], [DeActiveColor], [LineActive], [ActiveStateDesc], [DeActiveStateDesc]) VALUES (1037, 2, N'وضعیت پرس', 1048, 2, 1, 2, N'-16732080', N'-1048576', 0, N'فعال', N'غیر فعال')
INSERT [dbo].[Tb_DevicesLine] ([ID], [LineId], [LineDesc], [DeviceId], [PulsID], [InputPortTypeId], [ProductLineId], [ActiveColor], [DeActiveColor], [LineActive], [ActiveStateDesc], [DeActiveStateDesc]) VALUES (1038, 1, N'تعداد تولید', 1048, 1, 1, 2, N'-16732080', N'-1048576', 0, N'تولید', N'عدم تولید')
SET IDENTITY_INSERT [dbo].[Tb_DevicesLine] OFF
SET IDENTITY_INSERT [dbo].[Tb_InputPortType] ON 

INSERT [dbo].[Tb_InputPortType] ([InputPortTypeId], [InputPortType]) VALUES (1, N'پایه فعال')
INSERT [dbo].[Tb_InputPortType] ([InputPortTypeId], [InputPortType]) VALUES (2, N'پایه غیر فعال')
SET IDENTITY_INSERT [dbo].[Tb_InputPortType] OFF
SET IDENTITY_INSERT [dbo].[Tb_ProductLines] ON 

INSERT [dbo].[Tb_ProductLines] ([ID], [ProductLineId], [ProductLineDesc], [Description], [MizaneTolid], [SalonDesc]) VALUES (2, N'L4', N'خط تولیدی L4A', N'-', N'500', N'سالن پایین')
INSERT [dbo].[Tb_ProductLines] ([ID], [ProductLineId], [ProductLineDesc], [Description], [MizaneTolid], [SalonDesc]) VALUES (3, N'L3A', N'خط تولید L3A', N'ندارد', N'300000', N'سالن بالا')
SET IDENTITY_INSERT [dbo].[Tb_ProductLines] OFF
SET IDENTITY_INSERT [dbo].[Tb_PulsType] ON 

INSERT [dbo].[Tb_PulsType] ([PulsTypeId], [PulsTypeDesc]) VALUES (1, N'تعداد(شمارنده)')
INSERT [dbo].[Tb_PulsType] ([PulsTypeId], [PulsTypeDesc]) VALUES (2, N'وضعیت')
INSERT [dbo].[Tb_PulsType] ([PulsTypeId], [PulsTypeDesc]) VALUES (3, N'تست')
INSERT [dbo].[Tb_PulsType] ([PulsTypeId], [PulsTypeDesc]) VALUES (4, N'تست ۲')
INSERT [dbo].[Tb_PulsType] ([PulsTypeId], [PulsTypeDesc]) VALUES (5, N'وضعیت پرس')
SET IDENTITY_INSERT [dbo].[Tb_PulsType] OFF
SET IDENTITY_INSERT [dbo].[Tb_Station] ON 

INSERT [dbo].[Tb_Station] ([StationId], [ProductLineId], [DeviceId], [DeviceLineId], [StationDesc], [Description]) VALUES (1, 2, 1041, 1030, N'ایستگاه نمونه', N'توضیحات ندارد ')
INSERT [dbo].[Tb_Station] ([StationId], [ProductLineId], [DeviceId], [DeviceLineId], [StationDesc], [Description]) VALUES (2, 2, 1048, 1037, N'ایستگاه وضعیت پرس در دستگاه تست', N'ندارد3')
INSERT [dbo].[Tb_Station] ([StationId], [ProductLineId], [DeviceId], [DeviceLineId], [StationDesc], [Description]) VALUES (3, 2, 1048, 1038, N'تعداد تولید خط L4', N'ندارد . ')
SET IDENTITY_INSERT [dbo].[Tb_Station] OFF
ALTER TABLE [dbo].[Tb_DevicesLine]  WITH CHECK ADD  CONSTRAINT [FK_Tb_DevicesLine_Tb_Devices] FOREIGN KEY([DeviceId])
REFERENCES [dbo].[Tb_Devices] ([DeviceId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_DevicesLine] CHECK CONSTRAINT [FK_Tb_DevicesLine_Tb_Devices]
GO
ALTER TABLE [dbo].[Tb_DevicesLine]  WITH CHECK ADD  CONSTRAINT [FK_Tb_DevicesLine_Tb_InputPortType] FOREIGN KEY([InputPortTypeId])
REFERENCES [dbo].[Tb_InputPortType] ([InputPortTypeId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_DevicesLine] CHECK CONSTRAINT [FK_Tb_DevicesLine_Tb_InputPortType]
GO
ALTER TABLE [dbo].[Tb_DevicesLine]  WITH CHECK ADD  CONSTRAINT [FK_Tb_DevicesLine_Tb_ProductLines] FOREIGN KEY([ProductLineId])
REFERENCES [dbo].[Tb_ProductLines] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_DevicesLine] CHECK CONSTRAINT [FK_Tb_DevicesLine_Tb_ProductLines]
GO
ALTER TABLE [dbo].[Tb_DevicesLine]  WITH CHECK ADD  CONSTRAINT [FK_Tb_DevicesLine_Tb_PulsType] FOREIGN KEY([PulsID])
REFERENCES [dbo].[Tb_PulsType] ([PulsTypeId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_DevicesLine] CHECK CONSTRAINT [FK_Tb_DevicesLine_Tb_PulsType]
GO
/****** Object:  StoredProcedure [dbo].[insertClient]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[insertClient]( @DeviceId int,   @DeviceLineId int,   @StartDate nvarchar(50),   @EndDate nvarchar(50) ,  @Duration int,  @StateID int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into Tb_Client (DeviceID,DeviceLineId,StartDate,EndDate,Duration,StateId) values(@DeviceId ,@DeviceLineId ,@StartDate , @EndDate , @Duration , @StateID)
END






GO
/****** Object:  StoredProcedure [dbo].[SP_ChangeDeviceState]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[SP_ChangeDeviceState]( @DeviceID int,  @DeviceState bit)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update  [dbo].[Tb_Devices]  set [Active]=@DeviceState where [DeviceId]=@DeviceID

update [dbo].[Tb_DevicesLine] set [LineActive]=@DeviceState where [DeviceId]=@DeviceID

END






GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteDevice]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[SP_DeleteDevice] (@DeviceId int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  delete from [dbo].[Tb_Devices] where [DeviceId]=@DeviceId
  delete from [dbo].[Tb_DevicesLine] where [DeviceId]=@DeviceId

END






GO
/****** Object:  StoredProcedure [dbo].[Sp_DeleteDeviceLine]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[Sp_DeleteDeviceLine] (@deviceId int , @lineId int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  delete from [dbo].[Tb_DevicesLine] where LineId=@lineId and DeviceId=@deviceId
END






GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteProductLines]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE  PROCEDURE   [dbo].[SP_DeleteProductLines]   (@Id int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 declare @cnt int=(SELECT        COUNT(ProductLineId) AS Cnt
FROM            dbo.Tb_DevicesLine
WHERE        (LineActive = 1)
HAVING        (COUNT(ProductLineId) = 2))

if(@cnt<1)
begin
  delete from [dbo].Tb_ProductLines where id=@id 
 END  

END






GO
/****** Object:  StoredProcedure [dbo].[Sp_DeletePulsType]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,mohsen AZADFALLAH>
-- Create date: <Create Date,1395/09/05,>
-- Description:	<Descriptio , delete Special Record Of Tb_PulsType>
-- =============================================
CREATE PROCEDURE  [dbo].[Sp_DeletePulsType](@PulsTypeId nvarchar(50))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 delete from [dbo].[Tb_PulsType] where [PulsTypeId]=@PulsTypeId
END






GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteStation]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[SP_DeleteStation](@StationId int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM [dbo].[Tb_Station]
      WHERE Stationid=@StationId
END




GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDevices]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,mohsen AZADFALLAH>
-- Create date: <Create Date,1395/09/05,>
-- Description:	<Descriptio , insert data to   Tb_Devices >
-- =============================================
CREATE  PROCEDURE [dbo].[SP_InsertDevices] (@DeviceDesc nvarchar(50) , @computerName nvarchar(50),@PortName nvarchar(50) , @ID int OUTPUT )
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into Tb_Devices (DeviceDesc  , computerName ,PortName) values(@DeviceDesc  , @computerName ,@PortName )

  set     @id =( SELECT        TOP (1) PERCENT DeviceId  FROM            dbo.Tb_Devices ORDER BY DeviceId DESC)
  -- 

	 

END






GO
/****** Object:  StoredProcedure [dbo].[SP_insertDevicesLine]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

-- =============================================
-- Author:		<Author,,mohsen AZADFALLAH>
-- Create date: <Create Date,1395/09/05,>
-- Description:	<Descriptio , insert data to [dbo].[DevicesLine] >
-- =============================================
CREATE PROCEDURE  [dbo].[SP_insertDevicesLine](@LineId int,@LineDesc nvarchar(50),@DeviceId int , @PulsID int,  @InputPortTypeId int,@ProductLineId int,@ActiveColor nvarchar(50) , @DeActiveColor nvarchar(50) , @LineActive bit , @ActiveStateDesc nvarchar(50) , @DeActiveStateDesc nvarchar(50) )
AS
BEGIN
	 

   insert into  [dbo].[Tb_DevicesLine] ([LineId] ,LineDesc,DeviceId ,PulsID ,InputPortTypeId ,ProductLineId,ActiveColor ,DeActiveColor,LineActive,  ActiveStateDesc   ,  DeActiveStateDesc   ) values (@LineId ,@LineDesc,@DeviceId ,@PulsID ,@InputPortTypeId ,@ProductLineId,@ActiveColor ,@DeActiveColor,@LineActive,@ActiveStateDesc  ,  @DeActiveStateDesc )
END






GO
/****** Object:  StoredProcedure [dbo].[SP_InsertProductLine]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE PROCEDURE  [dbo].[SP_InsertProductLine](@ProductLineId nvarchar(50), @ProductLineDesc nvarchar(50) , @Description nvarchar(250), @MizaneTolid nvarchar(50) ,@SalonDesc nvarchar(50) ) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

     insert into [dbo].[Tb_ProductLines](ProductLineId , ProductLineDesc  , [Description] , MizaneTolid  ,SalonDesc )values(@ProductLineId , @ProductLineDesc  , @Description , @MizaneTolid  ,@SalonDesc )
END






GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertPulsType]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,mohsen AZADFALLAH>
-- Create date: <Create Date,1395/09/05,>
-- Description:	<Descriptio , Insert  Record to Tb_PulsType>
-- =============================================
CREATE  PROCEDURE  [dbo].[Sp_InsertPulsType] (@PulsTypeDesc nvarchar(50))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if(select COUNT([PulsTypeId]) as cnt  from [dbo].[Tb_PulsType] where [PulsTypeDesc]=@PulsTypeDesc)<1
	begin
 insert into [dbo].[Tb_PulsType]([PulsTypeDesc] ) values (@PulsTypeDesc)
	END 
    
END






GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertStation]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_InsertStation](   @ProductLineId  int ,@DeviceId int ,@DeviceLineId  int ,@StationDesc nvarchar(50),  @Description  nvarchar(100) )
AS
BEGIN
 


 
INSERT INTO [dbo].[Tb_Station]
           ( [ProductLineId]
           ,[DeviceId]
           ,[DeviceLineId]
           ,[StationDesc]
           ,[Description])
     VALUES
           (
            @ProductLineId    ,@DeviceId   ,@DeviceLineId    ,@StationDesc ,  @Description  
           
          )
           
          

END





GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateDevice]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[SP_UpdateDevice](@DeviceDesc nvarchar(50) , @computerName nvarchar(50),@PortName nvarchar(50) ,@DeviceId int)
AS
BEGIN
	 
	 update [dbo].[Tb_Devices] set DeviceDesc=@DeviceDesc , computerName=@computerName , PortName=@PortName where DeviceId=@DeviceId
END






GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateDevicesLine]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

-- =============================================
-- Author:		<Author,,mohsen AZADFALLAH>
-- Create date: <Create Date,1395/09/05,>
-- Description:	<Descriptio , insert data to [dbo].[DevicesLine] >
-- =============================================
CREATE  PROCEDURE  [dbo].[SP_UpdateDevicesLine](@LineId int,@LineDesc nvarchar(50),@DeviceId int , @PulsID int,  @InputPortTypeId int,@ProductLineId int,@ActiveColor nvarchar(50) , @DeActiveColor nvarchar(50) , @LineActive bit, @ActiveStateDesc nvarchar(50) , @DeActiveStateDesc nvarchar(50)  )
AS
BEGIN
	 

   update  [dbo].[Tb_DevicesLine] set  LineDesc= @LineDesc  ,PulsID=@PulsID ,InputPortTypeId =@InputPortTypeId ,ProductLineId=@ProductLineId,ActiveColor=@ActiveColor ,DeActiveColor=@DeActiveColor,LineActive=@LineActive,ActiveStateDesc= @ActiveStateDesc   ,DeActiveStateDesc= @DeActiveStateDesc  where @LineId=LineId and DeviceId=@DeviceId

END






GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateProductLine]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create  PROCEDURE   [dbo].[SP_UpdateProductLine] (@ProductLineId nvarchar(50), @ProductLineDesc nvarchar(50) , @Description nvarchar(250), @MizaneTolid nvarchar(50) ,@SalonDesc nvarchar(50),@id int) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

     update  [dbo].[Tb_ProductLines] set ProductLineId=@ProductLineId , ProductLineDesc =@ProductLineDesc , [Description] =@Description , MizaneTolid = @MizaneTolid  ,SalonDesc = @SalonDesc where id=@id
END






GO
/****** Object:  StoredProcedure [dbo].[SpUpdate_Station]    Script Date: 1/3/2017 05:23:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[SpUpdate_Station]( @ProductLineId  int ,@DeviceId int ,@DeviceLineId  int ,@StationDesc nvarchar(50),  @Description  nvarchar(100),@StationId int)
AS
BEGIN
	update [dbo].[Tb_Station] set  ProductLineId=@ProductLineId   ,DeviceId =@DeviceId ,DeviceLineId  =@DeviceLineId ,StationDesc =@StationDesc,  Description =@Description where StationId= @StationId
END




GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[53] 4[12] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tb_Devices"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 224
               Right = 213
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tb_DevicesLine"
            Begin Extent = 
               Top = 16
               Left = 285
               Bottom = 268
               Right = 454
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3210
         Alias = 900
         Table = 3015
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_LineInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_LineInfo'
GO
USE [master]
GO
ALTER DATABASE [PIASDB] SET  READ_WRITE 
GO
