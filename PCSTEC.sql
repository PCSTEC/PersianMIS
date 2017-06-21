USE [master]
GO
/****** Object:  Database [PCSTEC]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
CREATE DATABASE [PCSTEC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PCSTEC', FILENAME = N'E:\DATA_2014\DATA\PCSTEC.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PCSTEC_log', FILENAME = N'E:\DATA_2014\LOG\PCSTEC_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PCSTEC] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PCSTEC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PCSTEC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PCSTEC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PCSTEC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PCSTEC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PCSTEC] SET ARITHABORT OFF 
GO
ALTER DATABASE [PCSTEC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PCSTEC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PCSTEC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PCSTEC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PCSTEC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PCSTEC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PCSTEC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PCSTEC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PCSTEC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PCSTEC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PCSTEC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PCSTEC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PCSTEC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PCSTEC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PCSTEC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PCSTEC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PCSTEC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PCSTEC] SET RECOVERY FULL 
GO
ALTER DATABASE [PCSTEC] SET  MULTI_USER 
GO
ALTER DATABASE [PCSTEC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PCSTEC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PCSTEC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PCSTEC] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PCSTEC] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PCSTEC', N'ON'
GO
USE [PCSTEC]
GO
/****** Object:  User [NT AUTHORITY\SERVICE]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
CREATE USER [NT AUTHORITY\SERVICE] FOR LOGIN [NT AUTHORITY\SERVICE]
GO
/****** Object:  User [NT AUTHORITY\LOCAL SERVICE]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
CREATE USER [NT AUTHORITY\LOCAL SERVICE] FOR LOGIN [NT AUTHORITY\LOCAL SERVICE] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Barnamenevis]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
CREATE USER [Barnamenevis] FOR LOGIN [Barnamenevis] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [NT AUTHORITY\SERVICE]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [NT AUTHORITY\SERVICE]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [NT AUTHORITY\SERVICE]
GO
ALTER ROLE [db_owner] ADD MEMBER [NT AUTHORITY\LOCAL SERVICE]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [NT AUTHORITY\LOCAL SERVICE]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [NT AUTHORITY\LOCAL SERVICE]
GO
/****** Object:  UserDefinedFunction [dbo].[daydiff]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  Table [dbo].[Tb_Client]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  Table [dbo].[Tb_Client2]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Client2](
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
	[prhID] [int] NOT NULL,
	[PersonCode] [int] NULL,
	[StartHour] [char](5) NULL,
	[EndHour] [char](5) NULL,
	[WorkTime] [int] NULL,
	[ProsDetailID] [int] NULL,
	[StopID] [int] NULL,
	[RegTypeID] [smallint] NULL,
	[NafarTime] [int] NULL,
	[MachinCode] [varchar](50) NULL,
	[DieCode] [varchar](50) NULL,
	[PrjCode] [varchar](10) NULL,
	[MachinHour] [int] NULL,
	[MachinHourFlag] [bit] NULL,
	[NafarTimeFlag] [bit] NULL,
	[EzafeKarWorkTime] [int] NULL,
	[RestTime] [int] NULL,
	[ViewManager] [bit] NULL,
	[ViewStopPersonCode] [int] NULL,
	[MachinCodeExtra] [varchar](50) NULL,
	[CostCenterCodeNafar] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tb_Client2] PRIMARY KEY CLUSTERED 
(
	[DeviceStateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tb_Devices]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  Table [dbo].[Tb_DevicesLine]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  Table [dbo].[Tb_InputPortType]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  Table [dbo].[Tb_ProductLines]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  Table [dbo].[Tb_PulsType]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  Table [dbo].[Tb_Station]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  Table [dbo].[test]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[ID] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Designation] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[GetDeviceInfo]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetLastStateFromSpecialLineStateByDate]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetListOfDeviceByProductLine]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetListOfInputPortTypes]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetListOfProductLines]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetListOfStations]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetPulsTypes]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetSpecialLineStateByDate]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[GetSpecialLineStateByDate](@DeviceId nvarchar(50) , @LineId nvarchar(50) ,@StartDateTime nvarchar(50) ,@StartTime nvarchar(50),@EndDateTime nvarchar(50) ,@EndTime nvarchar(50))

RETURNS TABLE 
AS
RETURN 
(
	SELECT        TOP (200) SUM(Duration) AS SumDuration, StateId
FROM            dbo.Tb_Client
WHERE        (MiladiStartDateTime >= CONVERT(DATETIME, @StartDateTime +' ' +  @StartTime , 102)) AND (DeviceLineId = @LineId) AND (DeviceID = @DeviceId) and  (MiladiStartDateTime <= CONVERT(DATETIME, @EndDateTime +' ' +  @EndTime , 102)) 
GROUP BY StateId
ORDER BY StateId



)




GO
/****** Object:  UserDefinedFunction [dbo].[GetSpecialLineStateByDateForCount]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  View [dbo].[Vw_LineInfo]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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

INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5207, 1048, 17, N'1396/3/23', N'17:17:58:38', N'1396/3/23', N'17:57:26:81', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5208, 1048, 18, N'1396/3/23', N'17:17:58:48', N'1396/3/23', N'17:57:26:81', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5209, 1048, 19, N'1396/3/23', N'17:17:58:48', N'1396/3/23', N'17:57:26:81', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5210, 1048, 20, N'1396/3/23', N'17:17:58:48', N'1396/3/23', N'17:57:26:82', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5211, 1048, 21, N'1396/3/23', N'17:17:58:48', N'1396/3/23', N'17:57:26:82', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5212, 1048, 22, N'1396/3/23', N'17:17:58:49', N'1396/3/23', N'17:57:26:84', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5213, 1048, 23, N'1396/3/23', N'17:17:58:49', N'1396/3/23', N'17:57:26:84', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5214, 1048, 24, N'1396/3/23', N'17:17:58:49', N'1396/3/23', N'17:57:26:85', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5215, 1048, 9, N'1396/3/23', N'17:17:58:50', N'1396/3/23', N'17:57:26:85', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5216, 1048, 10, N'1396/3/23', N'17:17:58:50', N'1396/3/23', N'17:57:26:87', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5217, 1048, 11, N'1396/3/23', N'17:17:58:51', N'1396/3/23', N'17:57:26:87', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5218, 1048, 12, N'1396/3/23', N'17:17:58:51', N'1396/3/23', N'17:57:26:88', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5219, 1048, 13, N'1396/3/23', N'17:17:58:51', N'1396/3/23', N'17:57:26:88', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5220, 1048, 14, N'1396/3/23', N'17:17:58:52', N'1396/3/23', N'17:57:26:90', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5221, 1048, 15, N'1396/3/23', N'17:17:58:52', N'1396/3/23', N'17:57:26:90', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5222, 1048, 16, N'1396/3/23', N'17:17:58:52', N'1396/3/23', N'17:57:26:90', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5223, 1048, 1, N'1396/3/23', N'17:17:58:53', N'1396/3/23', N'17:57:26:91', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5224, 1048, 2, N'1396/3/23', N'17:17:58:53', N'1396/3/23', N'17:57:26:91', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5225, 1048, 3, N'1396/3/23', N'17:17:58:54', N'1396/3/23', N'17:57:26:93', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5226, 1048, 4, N'1396/3/23', N'17:17:58:54', N'1396/3/23', N'17:57:26:93', NULL, 0, 12760, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5227, 1048, 5, N'1396/3/23', N'17:17:58:54', N'1396/3/23', N'17:57:26:77', NULL, 0, 12759, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5228, 1048, 6, N'1396/3/23', N'17:17:58:55', N'1396/3/23', N'17:57:26:77', NULL, 0, 12759, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5229, 1048, 7, N'1396/3/23', N'17:17:58:55', N'1396/3/23', N'17:57:26:79', NULL, 0, 12759, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5230, 1048, 8, N'1396/3/23', N'17:17:58:55', N'1396/3/23', N'17:57:26:79', NULL, 0, 12759, CAST(N'2017-06-13 17:17:58.000' AS DateTime), CAST(N'2017-06-13 17:57:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5231, 1048, 9, N'1396/3/25', N'07:32:51:13', N'1396/3/25', N'17:43:27:36', NULL, 0, 198734, CAST(N'2017-06-15 07:32:51.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5232, 1048, 10, N'1396/3/25', N'07:32:53:09', N'1396/3/25', N'17:43:27:36', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5233, 1048, 11, N'1396/3/25', N'07:32:53:11', N'1396/3/25', N'17:43:27:38', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5234, 1048, 12, N'1396/3/25', N'07:32:53:11', N'1396/3/25', N'17:43:27:38', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5235, 1048, 13, N'1396/3/25', N'07:32:53:11', N'1396/3/25', N'17:43:27:38', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5236, 1048, 14, N'1396/3/25', N'07:32:53:11', N'1396/3/25', N'17:43:27:38', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5237, 1048, 15, N'1396/3/25', N'07:32:53:11', N'1396/3/25', N'17:43:27:40', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5238, 1048, 16, N'1396/3/25', N'07:32:53:11', N'1396/3/25', N'17:43:27:40', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5239, 1048, 1, N'1396/3/25', N'07:32:53:11', N'1396/3/25', N'17:43:27:40', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5240, 1048, 2, N'1396/3/25', N'07:32:53:13', N'1396/3/25', N'17:43:27:40', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5241, 1048, 3, N'1396/3/25', N'07:32:53:13', N'1396/3/25', N'17:43:27:41', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5242, 1048, 4, N'1396/3/25', N'07:32:53:13', N'1396/3/25', N'17:43:27:41', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5243, 1048, 5, N'1396/3/25', N'07:32:53:13', N'1396/3/25', N'17:43:27:41', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5244, 1048, 6, N'1396/3/25', N'07:32:53:13', N'1396/3/25', N'17:43:27:41', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5245, 1048, 7, N'1396/3/25', N'07:32:53:13', N'1396/3/25', N'17:43:27:43', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5246, 1048, 8, N'1396/3/25', N'07:32:53:13', N'1396/3/25', N'17:43:27:43', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5247, 1048, 17, N'1396/3/25', N'07:32:53:14', N'1396/3/25', N'17:43:27:43', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5248, 1048, 18, N'1396/3/25', N'07:32:53:14', N'1396/3/25', N'17:43:27:44', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5249, 1048, 19, N'1396/3/25', N'07:32:53:14', N'1396/3/25', N'17:43:27:44', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5250, 1048, 20, N'1396/3/25', N'07:32:53:14', N'1396/3/25', N'17:43:27:44', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5251, 1048, 21, N'1396/3/25', N'07:32:53:14', N'1396/3/25', N'17:43:27:44', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5252, 1048, 22, N'1396/3/25', N'07:32:53:14', N'1396/3/25', N'17:43:27:46', NULL, 0, 198734, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5253, 1048, 23, N'1396/3/25', N'07:32:53:14', N'1396/3/25', N'17:43:27:35', NULL, 0, 198733, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5254, 1048, 24, N'1396/3/25', N'07:32:53:16', N'1396/3/25', N'17:43:27:36', NULL, 0, 198733, CAST(N'2017-06-15 07:32:53.000' AS DateTime), CAST(N'2017-06-15 17:43:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5255, 1048, 9, N'1396/3/27', N'07:47:20:72', N'1396/3/27', N'09:44:45:54', NULL, 0, 34201, CAST(N'2017-06-17 07:47:20.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5256, 1048, 10, N'1396/3/27', N'07:47:31:03', N'1396/3/27', N'09:44:45:55', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5257, 1048, 11, N'1396/3/27', N'07:47:31:03', N'1396/3/27', N'09:44:45:59', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5258, 1048, 12, N'1396/3/27', N'07:47:31:03', N'1396/3/27', N'09:44:45:60', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5259, 1048, 13, N'1396/3/27', N'07:47:31:04', N'1396/3/27', N'09:44:45:63', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5260, 1048, 14, N'1396/3/27', N'07:47:31:04', N'1396/3/27', N'09:44:45:65', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5261, 1048, 15, N'1396/3/27', N'07:47:31:06', N'1396/3/27', N'09:44:45:68', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5262, 1048, 16, N'1396/3/27', N'07:47:31:06', N'1396/3/27', N'09:44:45:69', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5263, 1048, 1, N'1396/3/27', N'07:47:31:06', N'1396/3/27', N'09:44:45:73', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5264, 1048, 2, N'1396/3/27', N'07:47:31:06', N'1396/3/27', N'09:44:45:74', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5265, 1048, 3, N'1396/3/27', N'07:47:31:07', N'1396/3/27', N'09:44:45:77', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5266, 1048, 4, N'1396/3/27', N'07:47:31:07', N'1396/3/27', N'09:44:45:80', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5267, 1048, 5, N'1396/3/27', N'07:47:31:07', N'1396/3/27', N'09:44:45:82', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5268, 1048, 6, N'1396/3/27', N'07:47:31:07', N'1396/3/27', N'09:44:45:85', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5269, 1048, 7, N'1396/3/27', N'07:47:31:07', N'1396/3/27', N'09:44:45:88', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5270, 1048, 8, N'1396/3/27', N'07:47:31:09', N'1396/3/27', N'09:44:45:91', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5271, 1048, 17, N'1396/3/27', N'07:47:31:09', N'1396/3/27', N'09:44:45:94', NULL, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5272, 1048, 18, N'1396/3/27', N'07:47:31:10', N'1396/3/27', N'09:44:45:45', NULL, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5273, 1048, 19, N'1396/3/27', N'07:47:31:10', N'1396/3/27', N'09:44:45:46', NULL, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5274, 1048, 20, N'1396/3/27', N'07:47:31:12', N'1396/3/27', N'09:44:45:46', NULL, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5275, 1048, 21, N'1396/3/27', N'07:47:31:12', N'1396/3/27', N'09:44:45:48', NULL, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5276, 1048, 22, N'1396/3/27', N'07:47:31:12', N'1396/3/27', N'09:44:45:49', NULL, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5277, 1048, 23, N'1396/3/27', N'07:47:31:12', N'1396/3/27', N'09:44:45:49', NULL, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5278, 1048, 24, N'1396/3/27', N'07:47:31:14', N'1396/3/27', N'09:44:45:51', NULL, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5279, 1048, 9, N'1396/3/27', N'14:19:09:09', N'1396/3/27', N'14:21:15:06', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5280, 1048, 10, N'1396/3/27', N'14:19:09:86', N'1396/3/27', N'14:21:15:06', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5281, 1048, 11, N'1396/3/27', N'14:19:09:86', N'1396/3/27', N'14:21:15:08', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5282, 1048, 12, N'1396/3/27', N'14:19:09:86', N'1396/3/27', N'14:21:15:08', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5283, 1048, 13, N'1396/3/27', N'14:19:09:87', N'1396/3/27', N'14:21:15:10', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5284, 1048, 14, N'1396/3/27', N'14:19:09:87', N'1396/3/27', N'14:21:15:10', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5285, 1048, 15, N'1396/3/27', N'14:19:09:87', N'1396/3/27', N'14:21:15:11', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5286, 1048, 16, N'1396/3/27', N'14:19:09:87', N'1396/3/27', N'14:21:15:11', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5287, 1048, 1, N'1396/3/27', N'14:19:09:87', N'1396/3/27', N'14:19:17:23', 7, 1, 32, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:19:17.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5288, 1048, 2, N'1396/3/27', N'14:19:09:89', N'1396/3/27', N'14:21:15:13', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5289, 1048, 3, N'1396/3/27', N'14:19:09:89', N'1396/3/27', N'14:21:15:13', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5290, 1048, 4, N'1396/3/27', N'14:19:09:89', N'1396/3/27', N'14:21:15:14', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5291, 1048, 5, N'1396/3/27', N'14:19:09:89', N'1396/3/27', N'14:21:15:14', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5292, 1048, 6, N'1396/3/27', N'14:19:09:89', N'1396/3/27', N'14:21:15:16', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5293, 1048, 7, N'1396/3/27', N'14:19:09:90', N'1396/3/27', N'14:21:15:16', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5294, 1048, 8, N'1396/3/27', N'14:19:09:90', N'1396/3/27', N'14:21:15:17', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5295, 1048, 17, N'1396/3/27', N'14:19:09:90', N'1396/3/27', N'14:21:15:17', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5296, 1048, 18, N'1396/3/27', N'14:19:09:90', N'1396/3/27', N'14:21:15:19', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5297, 1048, 19, N'1396/3/27', N'14:19:09:92', N'1396/3/27', N'14:21:15:19', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5298, 1048, 20, N'1396/3/27', N'14:19:09:92', N'1396/3/27', N'14:21:15:19', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5299, 1048, 21, N'1396/3/27', N'14:19:09:92', N'1396/3/27', N'14:21:15:20', NULL, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5300, 1048, 22, N'1396/3/27', N'14:19:09:92', N'1396/3/27', N'14:21:15:03', NULL, 0, 601, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5301, 1048, 23, N'1396/3/27', N'14:19:09:93', N'1396/3/27', N'14:21:15:05', NULL, 0, 601, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5302, 1048, 24, N'1396/3/27', N'14:19:09:93', N'1396/3/27', N'14:21:15:05', NULL, 0, 601, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5303, 1048, 1, N'1396/3/27', N'14:19:17:44', N'1396/3/27', N'14:20:14:28', 57, 0, 248, CAST(N'2017-06-17 14:19:17.000' AS DateTime), CAST(N'2017-06-17 14:20:14.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5304, 1048, 1, N'1396/3/27', N'14:20:14:46', N'1396/3/27', N'14:21:15:11', 60, 1, 322, CAST(N'2017-06-17 14:20:14.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5305, 1048, 1, N'1396/3/27', N'14:21:19:06', N'1396/3/27', N'14:33:45:62', 746, 1, 3806, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-17 14:33:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5306, 1048, 2, N'1396/3/27', N'14:21:19:11', N'1396/3/30', N'12:18:07:13', NULL, 0, 1368723, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5307, 1048, 3, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:07:15', NULL, 0, 1368723, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5308, 1048, 4, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:07:16', NULL, 0, 1368723, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5309, 1048, 5, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:07:16', NULL, 0, 1368723, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5310, 1048, 6, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:07:18', NULL, 0, 1368723, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5311, 1048, 7, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:06:99', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:06.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5312, 1048, 8, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:06:99', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:06.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5313, 1048, 17, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:07:01', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5314, 1048, 18, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:01', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5315, 1048, 19, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:02', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5316, 1048, 20, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:02', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5317, 1048, 21, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:04', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5318, 1048, 22, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:04', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5319, 1048, 23, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:05', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5320, 1048, 24, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:05', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5321, 1048, 9, N'1396/3/27', N'14:21:19:15', N'1396/3/30', N'12:18:07:07', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5322, 1048, 10, N'1396/3/27', N'14:21:19:17', N'1396/3/30', N'12:18:07:08', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5323, 1048, 11, N'1396/3/27', N'14:21:19:17', N'1396/3/30', N'12:18:07:08', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5324, 1048, 12, N'1396/3/27', N'14:21:19:17', N'1396/3/30', N'12:18:07:10', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5325, 1048, 13, N'1396/3/27', N'14:21:19:17', N'1396/3/30', N'12:18:07:10', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5326, 1048, 14, N'1396/3/27', N'14:21:19:17', N'1396/3/30', N'12:18:07:10', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5327, 1048, 15, N'1396/3/27', N'14:21:19:17', N'1396/3/30', N'12:18:07:12', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5328, 1048, 16, N'1396/3/27', N'14:21:19:19', N'1396/3/30', N'12:18:07:12', NULL, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5329, 1048, 1, N'1396/3/27', N'14:33:45:85', N'1396/3/27', N'14:33:50:05', 4, 0, 18, CAST(N'2017-06-17 14:33:45.000' AS DateTime), CAST(N'2017-06-17 14:33:50.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5330, 1048, 1, N'1396/3/27', N'14:33:50:22', N'1396/3/27', N'14:33:55:82', 5, 1, 28, CAST(N'2017-06-17 14:33:50.000' AS DateTime), CAST(N'2017-06-17 14:33:55.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5331, 1048, 1, N'1396/3/27', N'14:33:56:03', N'1396/3/27', N'14:34:55:00', 58, 0, 303, CAST(N'2017-06-17 14:33:56.000' AS DateTime), CAST(N'2017-06-17 14:34:55.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5332, 1048, 1, N'1396/3/27', N'14:34:55:19', N'1396/3/27', N'14:36:55:37', 120, 1, 625, CAST(N'2017-06-17 14:34:55.000' AS DateTime), CAST(N'2017-06-17 14:36:55.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5333, 1048, 1, N'1396/3/27', N'14:36:55:56', N'1396/3/27', N'14:49:28:12', 752, 0, 3917, CAST(N'2017-06-17 14:36:55.000' AS DateTime), CAST(N'2017-06-17 14:49:28.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5334, 1048, 1, N'1396/3/27', N'14:49:28:29', N'1396/3/27', N'14:57:49:23', 501, 1, 2532, CAST(N'2017-06-17 14:49:28.000' AS DateTime), CAST(N'2017-06-17 14:57:49.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5335, 1048, 1, N'1396/3/27', N'14:57:49:45', N'1396/3/27', N'16:33:56:65', 5767, 0, 31585, CAST(N'2017-06-17 14:57:49.000' AS DateTime), CAST(N'2017-06-17 16:33:56.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5336, 1048, 1, N'1396/3/27', N'16:33:56:84', N'1396/3/27', N'16:34:36:69', 40, 1, 233, CAST(N'2017-06-17 16:33:56.000' AS DateTime), CAST(N'2017-06-17 16:34:36.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5337, 1048, 1, N'1396/3/27', N'16:34:36:88', N'1396/3/27', N'16:34:37:44', 1, 0, 4, CAST(N'2017-06-17 16:34:36.000' AS DateTime), CAST(N'2017-06-17 16:34:37.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5338, 1048, 1, N'1396/3/27', N'16:34:37:64', N'1396/3/27', N'16:44:23:98', 586, 1, 3142, CAST(N'2017-06-17 16:34:37.000' AS DateTime), CAST(N'2017-06-17 16:44:23.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5339, 1048, 1, N'1396/3/27', N'16:44:24:22', N'1396/3/27', N'16:51:38:73', 434, 0, 2150, CAST(N'2017-06-17 16:44:24.000' AS DateTime), CAST(N'2017-06-17 16:51:38.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5340, 1048, 1, N'1396/3/27', N'16:51:38:92', N'1396/3/27', N'16:52:19:99', 41, 1, 186, CAST(N'2017-06-17 16:51:38.000' AS DateTime), CAST(N'2017-06-17 16:52:19.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5341, 1048, 1, N'1396/3/27', N'16:52:20:18', N'1396/3/27', N'16:57:06:46', 286, 0, 1618, CAST(N'2017-06-17 16:52:20.000' AS DateTime), CAST(N'2017-06-17 16:57:06.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5342, 1048, 1, N'1396/3/27', N'16:57:06:63', N'1396/3/27', N'17:15:30:03', 1103, 1, 6134, CAST(N'2017-06-17 16:57:06.000' AS DateTime), CAST(N'2017-06-17 17:15:30.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5343, 1048, 1, N'1396/3/27', N'17:15:30:22', N'1396/3/27', N'17:15:39:24', 9, 0, 51, CAST(N'2017-06-17 17:15:30.000' AS DateTime), CAST(N'2017-06-17 17:15:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5344, 1048, 1, N'1396/3/27', N'17:15:39:42', N'1396/3/27', N'17:21:39:56', 360, 1, 2005, CAST(N'2017-06-17 17:15:39.000' AS DateTime), CAST(N'2017-06-17 17:21:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5345, 1048, 1, N'1396/3/27', N'17:21:39:75', N'1396/3/27', N'17:40:11:60', 1112, 0, 6243, CAST(N'2017-06-17 17:21:39.000' AS DateTime), CAST(N'2017-06-17 17:40:11.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5346, 1048, 1, N'1396/3/27', N'17:40:11:76', N'1396/3/27', N'17:54:26:32', 855, 1, 4944, CAST(N'2017-06-17 17:40:11.000' AS DateTime), CAST(N'2017-06-17 17:54:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5347, 1048, 1, N'1396/3/27', N'17:54:26:44', N'1396/3/27', N'17:54:31:86', 5, 0, 33, CAST(N'2017-06-17 17:54:26.000' AS DateTime), CAST(N'2017-06-17 17:54:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5348, 1048, 1, N'1396/3/27', N'17:54:32:04', N'1396/3/27', N'17:54:36:66', 4, 1, 28, CAST(N'2017-06-17 17:54:32.000' AS DateTime), CAST(N'2017-06-17 17:54:36.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5349, 1048, 1, N'1396/3/27', N'17:54:36:82', N'1396/3/27', N'17:54:45:91', 9, 0, 52, CAST(N'2017-06-17 17:54:36.000' AS DateTime), CAST(N'2017-06-17 17:54:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5350, 1048, 1, N'1396/3/27', N'17:54:46:10', N'1396/3/27', N'18:06:59:79', 733, 1, 4262, CAST(N'2017-06-17 17:54:46.000' AS DateTime), CAST(N'2017-06-17 18:06:59.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5351, 1048, 1, N'1396/3/27', N'18:06:59:99', N'1396/3/27', N'18:31:00:80', 1441, 0, 8403, CAST(N'2017-06-17 18:06:59.000' AS DateTime), CAST(N'2017-06-17 18:31:00.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5352, 1048, 1, N'1396/3/27', N'18:31:00:97', N'1396/3/27', N'18:32:09:68', 69, 1, 412, CAST(N'2017-06-17 18:31:00.000' AS DateTime), CAST(N'2017-06-17 18:32:09.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5353, 1048, 1, N'1396/3/27', N'18:32:09:80', N'1396/3/27', N'18:32:30:24', 21, 0, 124, CAST(N'2017-06-17 18:32:09.000' AS DateTime), CAST(N'2017-06-17 18:32:30.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5354, 1048, 1, N'1396/3/27', N'18:32:30:41', N'1396/3/27', N'18:33:37:55', 67, 1, 390, CAST(N'2017-06-17 18:32:30.000' AS DateTime), CAST(N'2017-06-17 18:33:37.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5355, 1048, 1, N'1396/3/27', N'18:33:37:74', N'1396/3/27', N'18:34:22:29', 45, 0, 273, CAST(N'2017-06-17 18:33:37.000' AS DateTime), CAST(N'2017-06-17 18:34:22.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5356, 1048, 1, N'1396/3/27', N'18:34:22:46', N'1396/3/27', N'19:28:35:49', 3253, 1, 19429, CAST(N'2017-06-17 18:34:22.000' AS DateTime), CAST(N'2017-06-17 19:28:35.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5357, 1048, 1, N'1396/3/27', N'19:28:35:67', N'1396/3/27', N'19:35:15:85', 400, 0, 2413, CAST(N'2017-06-17 19:28:35.000' AS DateTime), CAST(N'2017-06-17 19:35:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5358, 1048, 1, N'1396/3/27', N'19:35:16:03', N'1396/3/27', N'19:40:10:43', 294, 1, 1748, CAST(N'2017-06-17 19:35:16.000' AS DateTime), CAST(N'2017-06-17 19:40:10.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5359, 1048, 1, N'1396/3/27', N'19:40:10:63', N'1396/3/27', N'19:42:40:03', 149, 0, 896, CAST(N'2017-06-17 19:40:10.000' AS DateTime), CAST(N'2017-06-17 19:42:40.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5360, 1048, 1, N'1396/3/27', N'19:42:40:20', N'1396/3/27', N'19:46:53:62', 253, 1, 1529, CAST(N'2017-06-17 19:42:40.000' AS DateTime), CAST(N'2017-06-17 19:46:53.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5361, 1048, 1, N'1396/3/27', N'19:46:53:79', N'1396/3/27', N'19:53:01:97', 368, 0, 2195, CAST(N'2017-06-17 19:46:53.000' AS DateTime), CAST(N'2017-06-17 19:53:01.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5362, 1048, 1, N'1396/3/27', N'19:53:02:14', N'1396/3/27', N'19:59:03:71', 361, 1, 2190, CAST(N'2017-06-17 19:53:02.000' AS DateTime), CAST(N'2017-06-17 19:59:03.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5363, 1048, 1, N'1396/3/27', N'19:59:03:87', N'1396/3/27', N'20:24:41:20', 1537, 0, 9295, CAST(N'2017-06-17 19:59:03.000' AS DateTime), CAST(N'2017-06-17 20:24:41.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5364, 1048, 1, N'1396/3/27', N'20:24:41:36', N'1396/3/27', N'20:27:16:19', 155, 1, 936, CAST(N'2017-06-17 20:24:41.000' AS DateTime), CAST(N'2017-06-17 20:27:16.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5365, 1048, 1, N'1396/3/27', N'20:27:16:37', N'1396/3/27', N'20:27:23:25', 7, 0, 29, CAST(N'2017-06-17 20:27:16.000' AS DateTime), CAST(N'2017-06-17 20:27:23.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5366, 1048, 1, N'1396/3/27', N'20:27:23:35', N'1396/3/27', N'20:27:33:71', 10, 1, 65, CAST(N'2017-06-17 20:27:23.000' AS DateTime), CAST(N'2017-06-17 20:27:33.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5367, 1048, 1, N'1396/3/27', N'20:27:33:83', N'1396/3/27', N'20:27:36:45', 3, 0, 18, CAST(N'2017-06-17 20:27:33.000' AS DateTime), CAST(N'2017-06-17 20:27:36.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5368, 1048, 1, N'1396/3/27', N'20:27:37:00', N'1396/3/27', N'20:42:27:88', 890, 1, 5397, CAST(N'2017-06-17 20:27:37.000' AS DateTime), CAST(N'2017-06-17 20:42:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5369, 1048, 1, N'1396/3/27', N'20:42:27:99', N'1396/3/28', N'09:41:59:03', 46771, 0, 280027, CAST(N'2017-06-17 20:42:27.000' AS DateTime), CAST(N'2017-06-18 09:41:59.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5370, 1048, 1, N'1396/3/28', N'09:41:59:43', N'1396/3/28', N'09:43:15:79', 76, 1, 278, CAST(N'2017-06-18 09:41:59.000' AS DateTime), CAST(N'2017-06-18 09:43:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5371, 1048, 1, N'1396/3/28', N'09:43:16:14', N'1396/3/28', N'09:43:21:49', 4, 0, 16, CAST(N'2017-06-18 09:43:16.000' AS DateTime), CAST(N'2017-06-18 09:43:21.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5372, 1048, 1, N'1396/3/28', N'09:43:21:96', N'1396/3/28', N'09:50:36:25', 435, 1, 1616, CAST(N'2017-06-18 09:43:21.000' AS DateTime), CAST(N'2017-06-18 09:50:36.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5373, 1048, 1, N'1396/3/28', N'09:50:36:44', N'1396/3/28', N'10:01:38:19', 661, 0, 2733, CAST(N'2017-06-18 09:50:36.000' AS DateTime), CAST(N'2017-06-18 10:01:38.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5374, 1048, 1, N'1396/3/28', N'10:01:38:46', N'1396/3/28', N'10:39:42:96', 2284, 1, 10591, CAST(N'2017-06-18 10:01:38.000' AS DateTime), CAST(N'2017-06-18 10:39:42.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5375, 1048, 1, N'1396/3/28', N'10:39:43:11', N'1396/3/28', N'10:40:51:89', 68, 0, 348, CAST(N'2017-06-18 10:39:43.000' AS DateTime), CAST(N'2017-06-18 10:40:51.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5376, 1048, 1, N'1396/3/28', N'10:40:52:09', N'1396/3/28', N'11:03:17:00', 1344, 1, 6401, CAST(N'2017-06-18 10:40:52.000' AS DateTime), CAST(N'2017-06-18 11:03:17.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5377, 1048, 1, N'1396/3/28', N'11:03:17:19', N'1396/3/28', N'11:04:14:67', 57, 0, 294, CAST(N'2017-06-18 11:03:17.000' AS DateTime), CAST(N'2017-06-18 11:04:14.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5378, 1048, 1, N'1396/3/28', N'11:04:14:87', N'1396/3/28', N'11:05:37:73', 83, 1, 414, CAST(N'2017-06-18 11:04:14.000' AS DateTime), CAST(N'2017-06-18 11:05:37.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5379, 1048, 1, N'1396/3/28', N'11:05:37:92', N'1396/3/28', N'11:36:58:35', 1881, 0, 9616, CAST(N'2017-06-18 11:05:37.000' AS DateTime), CAST(N'2017-06-18 11:36:58.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5380, 1048, 1, N'1396/3/28', N'11:36:58:55', N'1396/3/28', N'11:38:02:06', 63, 1, 349, CAST(N'2017-06-18 11:36:58.000' AS DateTime), CAST(N'2017-06-18 11:38:02.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5381, 1048, 1, N'1396/3/28', N'11:38:02:23', N'1396/3/28', N'11:38:36:69', 34, 0, 188, CAST(N'2017-06-18 11:38:02.000' AS DateTime), CAST(N'2017-06-18 11:38:36.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5382, 1048, 1, N'1396/3/28', N'11:38:36:89', N'1396/3/28', N'11:40:10:12', 93, 1, 480, CAST(N'2017-06-18 11:38:36.000' AS DateTime), CAST(N'2017-06-18 11:40:10.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5383, 1048, 1, N'1396/3/28', N'11:40:10:34', N'1396/3/28', N'11:40:15:52', 5, 0, 28, CAST(N'2017-06-18 11:40:10.000' AS DateTime), CAST(N'2017-06-18 11:40:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5384, 1048, 1, N'1396/3/28', N'11:40:15:75', N'1396/3/28', N'12:11:32:94', 1877, 1, 9751, CAST(N'2017-06-18 11:40:15.000' AS DateTime), CAST(N'2017-06-18 12:11:32.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5385, 1048, 1, N'1396/3/28', N'12:11:33:12', N'1396/3/28', N'12:22:04:60', 631, 0, 3348, CAST(N'2017-06-18 12:11:33.000' AS DateTime), CAST(N'2017-06-18 12:22:04.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5386, 1048, 1, N'1396/3/28', N'12:22:04:81', N'1396/3/28', N'12:45:42:66', 1418, 1, 6791, CAST(N'2017-06-18 12:22:04.000' AS DateTime), CAST(N'2017-06-18 12:45:42.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5387, 1048, 1, N'1396/3/28', N'12:45:42:84', N'1396/3/28', N'12:57:55:56', 733, 0, 3954, CAST(N'2017-06-18 12:45:42.000' AS DateTime), CAST(N'2017-06-18 12:57:55.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5388, 1048, 1, N'1396/3/28', N'12:57:55:75', N'1396/3/28', N'12:58:18:57', 23, 1, 123, CAST(N'2017-06-18 12:57:55.000' AS DateTime), CAST(N'2017-06-18 12:58:18.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5389, 1048, 1, N'1396/3/28', N'12:58:18:76', N'1396/3/28', N'13:08:09:89', 591, 0, 3240, CAST(N'2017-06-18 12:58:18.000' AS DateTime), CAST(N'2017-06-18 13:08:09.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5390, 1048, 1, N'1396/3/28', N'13:08:10:06', N'1396/3/28', N'13:09:14:55', 64, 1, 351, CAST(N'2017-06-18 13:08:10.000' AS DateTime), CAST(N'2017-06-18 13:09:14.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5391, 1048, 1, N'1396/3/28', N'13:09:14:72', N'1396/3/28', N'13:19:33:90', 619, 0, 3419, CAST(N'2017-06-18 13:09:14.000' AS DateTime), CAST(N'2017-06-18 13:19:33.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5392, 1048, 1, N'1396/3/28', N'13:19:34:00', N'1396/3/28', N'13:20:15:28', 41, 1, 238, CAST(N'2017-06-18 13:19:34.000' AS DateTime), CAST(N'2017-06-18 13:20:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5393, 1048, 1, N'1396/3/28', N'13:20:15:44', N'1396/3/28', N'13:32:44:25', 749, 0, 4135, CAST(N'2017-06-18 13:20:15.000' AS DateTime), CAST(N'2017-06-18 13:32:44.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5394, 1048, 1, N'1396/3/28', N'13:32:44:43', N'1396/3/28', N'13:35:18:01', 153, 1, 855, CAST(N'2017-06-18 13:32:44.000' AS DateTime), CAST(N'2017-06-18 13:35:18.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5395, 1048, 1, N'1396/3/28', N'13:35:18:16', N'1396/3/28', N'13:41:10:64', 352, 0, 1945, CAST(N'2017-06-18 13:35:18.000' AS DateTime), CAST(N'2017-06-18 13:41:10.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5396, 1048, 1, N'1396/3/28', N'13:41:10:90', N'1396/3/28', N'13:43:11:44', 121, 1, 653, CAST(N'2017-06-18 13:41:10.000' AS DateTime), CAST(N'2017-06-18 13:43:11.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5397, 1048, 1, N'1396/3/28', N'13:43:11:62', N'1396/3/28', N'13:47:36:54', 265, 0, 1369, CAST(N'2017-06-18 13:43:11.000' AS DateTime), CAST(N'2017-06-18 13:47:36.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5398, 1048, 1, N'1396/3/28', N'13:47:36:71', N'1396/3/28', N'13:49:00:99', 84, 1, 447, CAST(N'2017-06-18 13:47:36.000' AS DateTime), CAST(N'2017-06-18 13:49:00.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5399, 1048, 1, N'1396/3/28', N'13:49:01:17', N'1396/3/28', N'14:40:11:35', 3070, 0, 15981, CAST(N'2017-06-18 13:49:01.000' AS DateTime), CAST(N'2017-06-18 14:40:11.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5400, 1048, 1, N'1396/3/28', N'14:40:11:54', N'1396/3/28', N'14:59:13:75', 1142, 1, 6019, CAST(N'2017-06-18 14:40:11.000' AS DateTime), CAST(N'2017-06-18 14:59:13.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5401, 1048, 1, N'1396/3/28', N'14:59:13:93', N'1396/3/28', N'15:04:06:51', 293, 0, 1555, CAST(N'2017-06-18 14:59:13.000' AS DateTime), CAST(N'2017-06-18 15:04:06.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5402, 1048, 1, N'1396/3/28', N'15:04:06:68', N'1396/3/28', N'15:04:36:86', 30, 1, 168, CAST(N'2017-06-18 15:04:06.000' AS DateTime), CAST(N'2017-06-18 15:04:36.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5403, 1048, 1, N'1396/3/28', N'15:04:37:04', N'1396/3/28', N'15:06:59:51', 142, 0, 719, CAST(N'2017-06-18 15:04:37.000' AS DateTime), CAST(N'2017-06-18 15:06:59.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5404, 1048, 1, N'1396/3/28', N'15:06:59:62', N'1396/3/28', N'15:08:01:54', 62, 1, 329, CAST(N'2017-06-18 15:06:59.000' AS DateTime), CAST(N'2017-06-18 15:08:01.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5405, 1048, 1, N'1396/3/28', N'15:08:01:71', N'1396/3/28', N'15:08:08:45', 7, 0, 38, CAST(N'2017-06-18 15:08:01.000' AS DateTime), CAST(N'2017-06-18 15:08:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5406, 1048, 1, N'1396/3/28', N'15:08:08:64', N'1396/3/28', N'15:08:15:96', 7, 1, 36, CAST(N'2017-06-18 15:08:08.000' AS DateTime), CAST(N'2017-06-18 15:08:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5407, 1048, 1, N'1396/3/28', N'15:08:16:15', N'1396/3/28', N'15:10:14:85', 118, 0, 622, CAST(N'2017-06-18 15:08:16.000' AS DateTime), CAST(N'2017-06-18 15:10:14.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5408, 1048, 1, N'1396/3/28', N'15:10:15:02', N'1396/3/28', N'15:14:57:66', 282, 1, 1462, CAST(N'2017-06-18 15:10:15.000' AS DateTime), CAST(N'2017-06-18 15:14:57.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5409, 1048, 1, N'1396/3/28', N'15:14:57:87', N'1396/3/28', N'15:15:05:49', 8, 0, 41, CAST(N'2017-06-18 15:14:57.000' AS DateTime), CAST(N'2017-06-18 15:15:05.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5410, 1048, 1, N'1396/3/28', N'15:15:05:67', N'1396/3/28', N'15:15:47:22', 41, 1, 223, CAST(N'2017-06-18 15:15:05.000' AS DateTime), CAST(N'2017-06-18 15:15:47.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5411, 1048, 1, N'1396/3/28', N'15:15:47:40', N'1396/3/28', N'15:16:01:96', 14, 0, 84, CAST(N'2017-06-18 15:15:47.000' AS DateTime), CAST(N'2017-06-18 15:16:01.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5412, 1048, 1, N'1396/3/28', N'15:16:02:16', N'1396/3/28', N'15:19:43:73', 221, 1, 1170, CAST(N'2017-06-18 15:16:02.000' AS DateTime), CAST(N'2017-06-18 15:19:43.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5413, 1048, 1, N'1396/3/28', N'15:19:43:96', N'1396/3/28', N'15:19:51:55', 8, 0, 40, CAST(N'2017-06-18 15:19:43.000' AS DateTime), CAST(N'2017-06-18 15:19:51.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5414, 1048, 1, N'1396/3/28', N'15:19:51:77', N'1396/3/28', N'15:24:18:71', 267, 1, 1372, CAST(N'2017-06-18 15:19:51.000' AS DateTime), CAST(N'2017-06-18 15:24:18.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5415, 1048, 1, N'1396/3/28', N'15:24:18:90', N'1396/3/28', N'15:24:26:28', 8, 0, 38, CAST(N'2017-06-18 15:24:18.000' AS DateTime), CAST(N'2017-06-18 15:24:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5416, 1048, 1, N'1396/3/28', N'15:24:26:45', N'1396/3/28', N'15:29:00:51', 274, 1, 1350, CAST(N'2017-06-18 15:24:26.000' AS DateTime), CAST(N'2017-06-18 15:29:00.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5417, 1048, 1, N'1396/3/28', N'15:29:00:77', N'1396/3/28', N'15:29:11:75', 11, 0, 42, CAST(N'2017-06-18 15:29:00.000' AS DateTime), CAST(N'2017-06-18 15:29:11.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5418, 1048, 1, N'1396/3/28', N'15:29:11:96', N'1396/3/28', N'15:29:14:90', 3, 1, 13, CAST(N'2017-06-18 15:29:11.000' AS DateTime), CAST(N'2017-06-18 15:29:14.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5419, 1048, 1, N'1396/3/28', N'15:29:15:08', N'1396/3/28', N'15:35:25:88', 370, 0, 1998, CAST(N'2017-06-18 15:29:15.000' AS DateTime), CAST(N'2017-06-18 15:35:25.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5420, 1048, 1, N'1396/3/28', N'15:35:26:09', N'1396/3/28', N'15:36:13:21', 47, 1, 257, CAST(N'2017-06-18 15:35:26.000' AS DateTime), CAST(N'2017-06-18 15:36:13.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5421, 1048, 1, N'1396/3/28', N'15:36:13:39', N'1396/3/28', N'15:36:20:75', 7, 0, 39, CAST(N'2017-06-18 15:36:13.000' AS DateTime), CAST(N'2017-06-18 15:36:20.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5422, 1048, 1, N'1396/3/28', N'15:36:20:94', N'1396/3/28', N'15:37:03:64', 43, 1, 222, CAST(N'2017-06-18 15:36:20.000' AS DateTime), CAST(N'2017-06-18 15:37:03.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5423, 1048, 1, N'1396/3/28', N'15:37:03:83', N'1396/3/28', N'15:37:10:47', 7, 0, 40, CAST(N'2017-06-18 15:37:03.000' AS DateTime), CAST(N'2017-06-18 15:37:10.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5424, 1048, 1, N'1396/3/28', N'15:37:10:57', N'1396/3/28', N'15:37:20:48', 10, 1, 55, CAST(N'2017-06-18 15:37:10.000' AS DateTime), CAST(N'2017-06-18 15:37:20.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5425, 1048, 1, N'1396/3/28', N'15:37:20:67', N'1396/3/28', N'15:41:45:44', 265, 0, 1397, CAST(N'2017-06-18 15:37:20.000' AS DateTime), CAST(N'2017-06-18 15:41:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5426, 1048, 1, N'1396/3/28', N'15:41:45:61', N'1396/3/28', N'15:42:21:01', 35, 1, 196, CAST(N'2017-06-18 15:41:45.000' AS DateTime), CAST(N'2017-06-18 15:42:21.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5427, 1048, 1, N'1396/3/28', N'15:42:21:21', N'1396/3/28', N'15:42:27:76', 6, 0, 35, CAST(N'2017-06-18 15:42:21.000' AS DateTime), CAST(N'2017-06-18 15:42:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5428, 1048, 1, N'1396/3/28', N'15:42:27:95', N'1396/3/28', N'15:42:33:45', 6, 1, 31, CAST(N'2017-06-18 15:42:27.000' AS DateTime), CAST(N'2017-06-18 15:42:33.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5429, 1048, 1, N'1396/3/28', N'15:42:33:68', N'1396/3/28', N'15:44:39:09', 125, 0, 676, CAST(N'2017-06-18 15:42:33.000' AS DateTime), CAST(N'2017-06-18 15:44:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5430, 1048, 1, N'1396/3/28', N'15:44:39:26', N'1396/3/28', N'15:45:43:54', 64, 1, 192, CAST(N'2017-06-18 15:44:39.000' AS DateTime), CAST(N'2017-06-18 15:45:43.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5431, 1048, 1, N'1396/3/28', N'15:45:43:76', N'1396/3/28', N'15:45:55:81', 12, 0, 35, CAST(N'2017-06-18 15:45:43.000' AS DateTime), CAST(N'2017-06-18 15:45:55.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5432, 1048, 1, N'1396/3/28', N'15:45:56:40', N'1396/3/28', N'15:46:00:64', 4, 1, 9, CAST(N'2017-06-18 15:45:56.000' AS DateTime), CAST(N'2017-06-18 15:46:00.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5433, 1048, 1, N'1396/3/28', N'15:46:00:90', N'1396/3/28', N'15:46:22:34', 22, 0, 92, CAST(N'2017-06-18 15:46:00.000' AS DateTime), CAST(N'2017-06-18 15:46:22.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5434, 1048, 1, N'1396/3/28', N'15:46:22:57', N'1396/3/28', N'15:50:34:24', 252, 1, 1213, CAST(N'2017-06-18 15:46:22.000' AS DateTime), CAST(N'2017-06-18 15:50:34.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5435, 1048, 1, N'1396/3/28', N'15:50:34:39', N'1396/3/28', N'15:50:40:08', 5, 0, 39, CAST(N'2017-06-18 15:50:34.000' AS DateTime), CAST(N'2017-06-18 15:50:40.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5436, 1048, 1, N'1396/3/28', N'15:50:40:22', N'1396/3/28', N'15:50:56:98', 16, 1, 97, CAST(N'2017-06-18 15:50:40.000' AS DateTime), CAST(N'2017-06-18 15:50:56.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5437, 1048, 1, N'1396/3/28', N'15:50:57:16', N'1396/3/28', N'15:52:04:66', 67, 0, 384, CAST(N'2017-06-18 15:50:57.000' AS DateTime), CAST(N'2017-06-18 15:52:04.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5438, 1048, 1, N'1396/3/28', N'15:52:04:86', N'1396/3/28', N'15:54:55:10', 170, 1, 931, CAST(N'2017-06-18 15:52:04.000' AS DateTime), CAST(N'2017-06-18 15:54:55.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5439, 1048, 1, N'1396/3/28', N'15:54:55:28', N'1396/3/28', N'15:55:02:16', 6, 0, 39, CAST(N'2017-06-18 15:54:55.000' AS DateTime), CAST(N'2017-06-18 15:55:02.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5440, 1048, 1, N'1396/3/28', N'15:55:02:30', N'1396/3/28', N'15:58:09:19', 187, 1, 1023, CAST(N'2017-06-18 15:55:02.000' AS DateTime), CAST(N'2017-06-18 15:58:09.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5441, 1048, 1, N'1396/3/28', N'15:58:09:68', N'1396/3/28', N'15:58:18:10', 8, 0, 42, CAST(N'2017-06-18 15:58:09.000' AS DateTime), CAST(N'2017-06-18 15:58:18.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5442, 1048, 1, N'1396/3/28', N'15:58:18:26', N'1396/3/28', N'16:01:18:18', 180, 1, 1002, CAST(N'2017-06-18 15:58:18.000' AS DateTime), CAST(N'2017-06-18 16:01:18.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5443, 1048, 1, N'1396/3/28', N'16:01:18:34', N'1396/3/28', N'16:01:25:61', 7, 0, 39, CAST(N'2017-06-18 16:01:18.000' AS DateTime), CAST(N'2017-06-18 16:01:25.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5444, 1048, 1, N'1396/3/28', N'16:01:25:78', N'1396/3/28', N'16:01:28:40', 3, 1, 13, CAST(N'2017-06-18 16:01:25.000' AS DateTime), CAST(N'2017-06-18 16:01:28.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5445, 1048, 1, N'1396/3/28', N'16:01:28:57', N'1396/3/28', N'16:14:44:18', 796, 0, 4402, CAST(N'2017-06-18 16:01:28.000' AS DateTime), CAST(N'2017-06-18 16:14:44.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5446, 1048, 1, N'1396/3/28', N'16:14:44:37', N'1396/3/28', N'17:02:54:60', 2890, 1, 16084, CAST(N'2017-06-18 16:14:44.000' AS DateTime), CAST(N'2017-06-18 17:02:54.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5447, 1048, 1, N'1396/3/28', N'17:02:54:76', N'1396/3/28', N'17:08:51:33', 357, 0, 1887, CAST(N'2017-06-18 17:02:54.000' AS DateTime), CAST(N'2017-06-18 17:08:51.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5448, 1048, 1, N'1396/3/28', N'17:08:51:51', N'1396/3/28', N'17:09:34:96', 43, 1, 237, CAST(N'2017-06-18 17:08:51.000' AS DateTime), CAST(N'2017-06-18 17:09:34.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5449, 1048, 1, N'1396/3/28', N'17:09:35:13', N'1396/3/28', N'17:17:46:79', 491, 0, 2567, CAST(N'2017-06-18 17:09:35.000' AS DateTime), CAST(N'2017-06-18 17:17:46.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5450, 1048, 1, N'1396/3/28', N'17:17:47:04', N'1396/3/28', N'17:33:06:39', 919, 1, 4756, CAST(N'2017-06-18 17:17:47.000' AS DateTime), CAST(N'2017-06-18 17:33:06.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5451, 1048, 1, N'1396/3/28', N'17:33:06:59', N'1396/3/28', N'17:49:49:33', 1003, 0, 5526, CAST(N'2017-06-18 17:33:06.000' AS DateTime), CAST(N'2017-06-18 17:49:49.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5452, 1048, 1, N'1396/3/28', N'17:49:49:54', N'1396/3/28', N'17:50:27:60', 38, 1, 209, CAST(N'2017-06-18 17:49:49.000' AS DateTime), CAST(N'2017-06-18 17:50:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5453, 1048, 1, N'1396/3/28', N'17:50:27:79', N'1396/3/28', N'17:50:28:90', 1, 0, 7, CAST(N'2017-06-18 17:50:27.000' AS DateTime), CAST(N'2017-06-18 17:50:28.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5454, 1048, 1, N'1396/3/28', N'17:50:29:09', N'1396/3/28', N'18:16:31:89', 1562, 1, 8607, CAST(N'2017-06-18 17:50:29.000' AS DateTime), CAST(N'2017-06-18 18:16:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5455, 1048, 1, N'1396/3/28', N'18:16:32:07', N'1396/3/28', N'18:21:48:48', 316, 0, 1721, CAST(N'2017-06-18 18:16:32.000' AS DateTime), CAST(N'2017-06-18 18:21:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5456, 1048, 1, N'1396/3/28', N'18:21:48:65', N'1396/3/28', N'18:22:01:86', 13, 1, 73, CAST(N'2017-06-18 18:21:48.000' AS DateTime), CAST(N'2017-06-18 18:22:01.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5457, 1048, 1, N'1396/3/28', N'18:22:02:05', N'1396/3/28', N'18:22:03:04', 0, 0, 7, CAST(N'2017-06-18 18:22:02.000' AS DateTime), CAST(N'2017-06-18 18:22:03.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5458, 1048, 1, N'1396/3/28', N'18:22:03:23', N'1396/3/28', N'18:27:48:23', 345, 1, 1920, CAST(N'2017-06-18 18:22:03.000' AS DateTime), CAST(N'2017-06-18 18:27:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5459, 1048, 1, N'1396/3/28', N'18:27:48:41', N'1396/3/28', N'18:27:51:72', 3, 0, 19, CAST(N'2017-06-18 18:27:48.000' AS DateTime), CAST(N'2017-06-18 18:27:51.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5460, 1048, 1, N'1396/3/28', N'18:27:51:92', N'1396/3/28', N'18:44:35:11', 1003, 1, 5631, CAST(N'2017-06-18 18:27:51.000' AS DateTime), CAST(N'2017-06-18 18:44:35.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5461, 1048, 1, N'1396/3/28', N'18:44:35:31', N'1396/3/28', N'18:45:39:93', 64, 0, 367, CAST(N'2017-06-18 18:44:35.000' AS DateTime), CAST(N'2017-06-18 18:45:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5462, 1048, 1, N'1396/3/28', N'18:45:40:09', N'1396/3/28', N'18:48:29:32', 169, 1, 936, CAST(N'2017-06-18 18:45:40.000' AS DateTime), CAST(N'2017-06-18 18:48:29.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5463, 1048, 1, N'1396/3/28', N'18:48:29:51', N'1396/3/28', N'20:57:57:24', 7768, 0, 44408, CAST(N'2017-06-18 18:48:29.000' AS DateTime), CAST(N'2017-06-18 20:57:57.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5464, 1048, 1, N'1396/3/28', N'20:57:57:40', N'1396/3/28', N'20:58:06:98', 9, 1, 57, CAST(N'2017-06-18 20:57:57.000' AS DateTime), CAST(N'2017-06-18 20:58:06.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5465, 1048, 1, N'1396/3/28', N'20:58:07:16', N'1396/3/28', N'20:58:33:46', 26, 0, 155, CAST(N'2017-06-18 20:58:07.000' AS DateTime), CAST(N'2017-06-18 20:58:33.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5466, 1048, 1, N'1396/3/28', N'20:58:33:63', N'1396/3/28', N'21:00:10:33', 97, 1, 566, CAST(N'2017-06-18 20:58:33.000' AS DateTime), CAST(N'2017-06-18 21:00:10.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5467, 1048, 1, N'1396/3/28', N'21:00:10:49', N'1396/3/28', N'21:00:14:77', 4, 0, 27, CAST(N'2017-06-18 21:00:10.000' AS DateTime), CAST(N'2017-06-18 21:00:14.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5468, 1048, 1, N'1396/3/28', N'21:00:14:93', N'1396/3/28', N'21:07:33:82', 439, 1, 2483, CAST(N'2017-06-18 21:00:14.000' AS DateTime), CAST(N'2017-06-18 21:07:33.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5469, 1048, 1, N'1396/3/28', N'21:07:34:04', N'1396/3/28', N'21:10:18:95', 164, 0, 951, CAST(N'2017-06-18 21:07:34.000' AS DateTime), CAST(N'2017-06-18 21:10:18.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5470, 1048, 1, N'1396/3/28', N'21:10:19:23', N'1396/3/28', N'21:13:15:69', 176, 1, 1022, CAST(N'2017-06-18 21:10:19.000' AS DateTime), CAST(N'2017-06-18 21:13:15.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5471, 1048, 1, N'1396/3/28', N'21:13:15:90', N'1396/3/28', N'23:06:22:78', 6787, 0, 39315, CAST(N'2017-06-18 21:13:15.000' AS DateTime), CAST(N'2017-06-18 23:06:22.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5472, 1048, 1, N'1396/3/28', N'23:06:22:95', N'1396/3/28', N'23:07:33:79', 71, 1, 380, CAST(N'2017-06-18 23:06:22.000' AS DateTime), CAST(N'2017-06-18 23:07:33.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5473, 1048, 1, N'1396/3/28', N'23:07:33:99', N'1396/3/28', N'23:08:08:98', 35, 0, 179, CAST(N'2017-06-18 23:07:33.000' AS DateTime), CAST(N'2017-06-18 23:08:08.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5474, 1048, 1, N'1396/3/28', N'23:08:09:17', N'1396/3/28', N'23:47:58:65', 2389, 1, 11895, CAST(N'2017-06-18 23:08:09.000' AS DateTime), CAST(N'2017-06-18 23:47:58.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5475, 1048, 1, N'1396/3/28', N'23:47:58:85', N'1396/3/28', N'23:48:43:96', 45, 0, 223, CAST(N'2017-06-18 23:47:58.000' AS DateTime), CAST(N'2017-06-18 23:48:43.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5476, 1048, 1, N'1396/3/28', N'23:48:44:16', N'1396/3/29', N'01:28:49:21', 6005, 1, 32691, CAST(N'2017-06-18 23:48:44.000' AS DateTime), CAST(N'2017-06-19 01:28:49.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5477, 1048, 1, N'1396/3/29', N'01:28:49:38', N'1396/3/29', N'09:59:21:48', 30632, 0, 172541, CAST(N'2017-06-19 01:28:49.000' AS DateTime), CAST(N'2017-06-19 09:59:21.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5478, 1048, 1, N'1396/3/29', N'09:59:21:65', N'1396/3/29', N'11:39:52:99', 6031, 1, 29088, CAST(N'2017-06-19 09:59:21.000' AS DateTime), CAST(N'2017-06-19 11:39:52.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5479, 1048, 1, N'1396/3/29', N'11:39:53:21', N'1396/3/29', N'11:51:08:57', 675, 0, 3305, CAST(N'2017-06-19 11:39:53.000' AS DateTime), CAST(N'2017-06-19 11:51:08.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5480, 1048, 1, N'1396/3/29', N'11:51:08:94', N'1396/3/29', N'15:16:22:60', 12314, 1, 62451, CAST(N'2017-06-19 11:51:08.000' AS DateTime), CAST(N'2017-06-19 15:16:22.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5481, 1048, 1, N'1396/3/29', N'15:16:22:73', N'1396/3/29', N'15:20:37:64', 255, 0, 1335, CAST(N'2017-06-19 15:16:22.000' AS DateTime), CAST(N'2017-06-19 15:20:37.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5482, 1048, 1, N'1396/3/29', N'15:20:37:94', N'1396/3/29', N'15:28:13:29', 456, 1, 2378, CAST(N'2017-06-19 15:20:37.000' AS DateTime), CAST(N'2017-06-19 15:28:13.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5483, 1048, 1, N'1396/3/29', N'15:28:13:47', N'1396/3/29', N'15:28:30:34', 17, 0, 87, CAST(N'2017-06-19 15:28:13.000' AS DateTime), CAST(N'2017-06-19 15:28:30.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5484, 1048, 1, N'1396/3/29', N'15:28:30:52', N'1396/3/29', N'16:06:27:08', 2276, 1, 11947, CAST(N'2017-06-19 15:28:30.000' AS DateTime), CAST(N'2017-06-19 16:06:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5485, 1048, 1, N'1396/3/29', N'16:06:27:25', N'1396/3/29', N'17:01:50:69', 3323, 0, 17887, CAST(N'2017-06-19 16:06:27.000' AS DateTime), CAST(N'2017-06-19 17:01:50.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5486, 1048, 1, N'1396/3/29', N'17:01:50:87', N'1396/3/29', N'17:08:02:02', 371, 1, 2016, CAST(N'2017-06-19 17:01:50.000' AS DateTime), CAST(N'2017-06-19 17:08:02.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5487, 1048, 1, N'1396/3/29', N'17:08:02:24', N'1396/3/29', N'17:08:27:51', 25, 0, 149, CAST(N'2017-06-19 17:08:02.000' AS DateTime), CAST(N'2017-06-19 17:08:27.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5488, 1048, 1, N'1396/3/29', N'17:08:27:68', N'1396/3/29', N'17:09:48:10', 80, 1, 450, CAST(N'2017-06-19 17:08:27.000' AS DateTime), CAST(N'2017-06-19 17:09:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5489, 1048, 1, N'1396/3/29', N'17:09:48:26', N'1396/3/29', N'17:09:52:89', 4, 0, 25, CAST(N'2017-06-19 17:09:48.000' AS DateTime), CAST(N'2017-06-19 17:09:52.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5490, 1048, 1, N'1396/3/29', N'17:09:53:16', N'1396/3/29', N'17:22:41:02', 767, 1, 4178, CAST(N'2017-06-19 17:09:53.000' AS DateTime), CAST(N'2017-06-19 17:22:41.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5491, 1048, 1, N'1396/3/29', N'17:22:41:21', N'1396/3/29', N'17:48:46:77', 1565, 0, 8390, CAST(N'2017-06-19 17:22:41.000' AS DateTime), CAST(N'2017-06-19 17:48:46.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5492, 1048, 1, N'1396/3/29', N'17:48:47:07', N'1396/3/29', N'18:18:57:54', 1810, 1, 8765, CAST(N'2017-06-19 17:48:47.000' AS DateTime), CAST(N'2017-06-19 18:18:57.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5493, 1048, 1, N'1396/3/29', N'18:18:57:83', N'1396/3/29', N'18:19:03:34', 6, 0, 25, CAST(N'2017-06-19 18:18:57.000' AS DateTime), CAST(N'2017-06-19 18:19:03.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5494, 1048, 1, N'1396/3/29', N'18:19:03:50', N'1396/3/29', N'18:52:00:22', 1977, 1, 9332, CAST(N'2017-06-19 18:19:03.000' AS DateTime), CAST(N'2017-06-19 18:52:00.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5495, 1048, 1, N'1396/3/29', N'18:52:00:41', N'1396/3/29', N'19:18:03:34', 1563, 0, 7444, CAST(N'2017-06-19 18:52:00.000' AS DateTime), CAST(N'2017-06-19 19:18:03.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5496, 1048, 1, N'1396/3/29', N'19:18:03:53', N'1396/3/29', N'19:38:59:74', 1256, 1, 6296, CAST(N'2017-06-19 19:18:03.000' AS DateTime), CAST(N'2017-06-19 19:38:59.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5497, 1048, 1, N'1396/3/29', N'19:38:59:97', N'1396/3/29', N'19:59:02:07', 1202, 0, 5925, CAST(N'2017-06-19 19:38:59.000' AS DateTime), CAST(N'2017-06-19 19:59:02.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5498, 1048, 1, N'1396/3/29', N'19:59:02:24', N'1396/3/29', N'20:04:34:02', 331, 1, 1678, CAST(N'2017-06-19 19:59:02.000' AS DateTime), CAST(N'2017-06-19 20:04:34.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5499, 1048, 1, N'1396/3/29', N'20:04:34:29', N'1396/3/29', N'20:04:39:80', 5, 0, 27, CAST(N'2017-06-19 20:04:34.000' AS DateTime), CAST(N'2017-06-19 20:04:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5500, 1048, 1, N'1396/3/29', N'20:04:39:97', N'1396/3/29', N'21:19:46:78', 4507, 1, 22387, CAST(N'2017-06-19 20:04:39.000' AS DateTime), CAST(N'2017-06-19 21:19:46.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5501, 1048, 1, N'1396/3/29', N'21:19:46:95', N'1396/3/29', N'21:45:52:61', 1566, 0, 7599, CAST(N'2017-06-19 21:19:46.000' AS DateTime), CAST(N'2017-06-19 21:45:52.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5502, 1048, 1, N'1396/3/29', N'21:45:52:78', N'1396/3/29', N'21:49:00:82', 188, 1, 941, CAST(N'2017-06-19 21:45:52.000' AS DateTime), CAST(N'2017-06-19 21:49:00.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5503, 1048, 1, N'1396/3/29', N'21:49:01:05', N'1396/3/29', N'21:49:30:27', 29, 0, 141, CAST(N'2017-06-19 21:49:01.000' AS DateTime), CAST(N'2017-06-19 21:49:30.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5504, 1048, 1, N'1396/3/29', N'21:49:30:50', N'1396/3/29', N'22:00:42:65', 672, 1, 3272, CAST(N'2017-06-19 21:49:30.000' AS DateTime), CAST(N'2017-06-19 22:00:42.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5505, 1048, 1, N'1396/3/29', N'22:00:42:82', N'1396/3/29', N'22:02:53:68', 131, 0, 697, CAST(N'2017-06-19 22:00:42.000' AS DateTime), CAST(N'2017-06-19 22:02:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5506, 1048, 1, N'1396/3/29', N'22:02:53:85', N'1396/3/29', N'22:07:19:03', 265, 1, 1396, CAST(N'2017-06-19 22:02:53.000' AS DateTime), CAST(N'2017-06-19 22:07:19.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5507, 1048, 1, N'1396/3/29', N'22:07:19:21', N'1396/3/30', N'00:07:53:36', 7234, 0, 32537, CAST(N'2017-06-19 22:07:19.000' AS DateTime), CAST(N'2017-06-20 00:07:53.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5508, 1048, 1, N'1396/3/30', N'00:07:53:57', N'1396/3/30', N'01:28:42:33', 4849, 1, 21414, CAST(N'2017-06-20 00:07:53.000' AS DateTime), CAST(N'2017-06-20 01:28:42.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5509, 1048, 1, N'1396/3/30', N'01:28:42:52', N'1396/3/30', N'02:26:37:77', 3475, 0, 20343, CAST(N'2017-06-20 01:28:42.000' AS DateTime), CAST(N'2017-06-20 02:26:37.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5510, 1048, 1, N'1396/3/30', N'02:26:37:94', N'1396/3/30', N'02:49:18:74', 1361, 1, 7980, CAST(N'2017-06-20 02:26:37.000' AS DateTime), CAST(N'2017-06-20 02:49:18.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5511, 1048, 1, N'1396/3/30', N'02:49:18:91', N'1396/3/30', N'02:49:51:36', 33, 0, 182, CAST(N'2017-06-20 02:49:18.000' AS DateTime), CAST(N'2017-06-20 02:49:51.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5512, 1048, 1, N'1396/3/30', N'02:49:51:53', N'1396/3/30', N'02:52:40:85', 169, 1, 1013, CAST(N'2017-06-20 02:49:51.000' AS DateTime), CAST(N'2017-06-20 02:52:40.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5513, 1048, 1, N'1396/3/30', N'02:52:41:01', N'1396/3/30', N'03:08:29:38', 948, 0, 5668, CAST(N'2017-06-20 02:52:41.000' AS DateTime), CAST(N'2017-06-20 03:08:29.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5514, 1048, 1, N'1396/3/30', N'03:08:29:58', N'1396/3/30', N'03:12:02:58', 213, 1, 1293, CAST(N'2017-06-20 03:08:29.000' AS DateTime), CAST(N'2017-06-20 03:12:02.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5515, 1048, 1, N'1396/3/30', N'03:12:02:74', N'1396/3/30', N'03:32:36:38', 1234, 0, 7417, CAST(N'2017-06-20 03:12:02.000' AS DateTime), CAST(N'2017-06-20 03:32:36.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5516, 1048, 1, N'1396/3/30', N'03:32:36:54', N'1396/3/30', N'03:36:18:77', 222, 1, 1344, CAST(N'2017-06-20 03:32:36.000' AS DateTime), CAST(N'2017-06-20 03:36:18.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5517, 1048, 1, N'1396/3/30', N'03:36:18:93', N'1396/3/30', N'03:39:03:68', 165, 0, 1000, CAST(N'2017-06-20 03:36:18.000' AS DateTime), CAST(N'2017-06-20 03:39:03.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5518, 1048, 1, N'1396/3/30', N'03:39:03:83', N'1396/3/30', N'04:29:10:80', 3007, 1, 17999, CAST(N'2017-06-20 03:39:03.000' AS DateTime), CAST(N'2017-06-20 04:29:10.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5519, 1048, 1, N'1396/3/30', N'04:29:10:97', N'1396/3/30', N'12:18:07:13', NULL, 0, 144036, CAST(N'2017-06-20 04:29:10.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5520, 1048, 1, N'1396/3/30', N'17:55:15:55', N'1396/3/30', N'20:03:52:91', 7717, 0, 43525, CAST(N'2017-06-20 17:55:15.000' AS DateTime), CAST(N'2017-06-20 20:03:52.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5521, 1048, 2, N'1396/3/30', N'17:55:16:14', N'1396/3/31', N'17:37:48:74', NULL, 0, 462221, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5522, 1048, 3, N'1396/3/30', N'17:55:16:14', N'1396/3/31', N'17:37:48:75', NULL, 0, 462221, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5523, 1048, 4, N'1396/3/30', N'17:55:16:15', N'1396/3/31', N'17:37:48:76', NULL, 0, 462221, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5524, 1048, 5, N'1396/3/30', N'17:55:16:15', N'1396/3/31', N'17:37:48:76', NULL, 0, 462221, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5525, 1048, 6, N'1396/3/30', N'17:55:16:15', N'1396/3/31', N'17:37:48:77', NULL, 0, 462221, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5526, 1048, 7, N'1396/3/30', N'17:55:16:15', N'1396/3/31', N'17:37:48:78', NULL, 0, 462221, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5527, 1048, 8, N'1396/3/30', N'17:55:16:16', N'1396/3/31', N'17:37:48:78', NULL, 0, 462221, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5528, 1048, 17, N'1396/3/30', N'17:55:16:17', N'1396/3/31', N'17:37:48:79', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5529, 1048, 18, N'1396/3/30', N'17:55:16:17', N'1396/3/31', N'17:37:48:80', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5530, 1048, 19, N'1396/3/30', N'17:55:16:18', N'1396/3/31', N'17:37:48:82', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5531, 1048, 20, N'1396/3/30', N'17:55:16:18', N'1396/3/31', N'17:37:48:84', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5532, 1048, 21, N'1396/3/30', N'17:55:16:19', N'1396/3/31', N'17:37:48:86', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5533, 1048, 22, N'1396/3/30', N'17:55:16:19', N'1396/3/31', N'17:37:48:88', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5534, 1048, 23, N'1396/3/30', N'17:55:16:19', N'1396/3/31', N'17:37:48:90', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5535, 1048, 24, N'1396/3/30', N'17:55:16:19', N'1396/3/31', N'17:37:48:92', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5536, 1048, 9, N'1396/3/30', N'17:55:16:20', N'1396/3/31', N'17:37:48:93', NULL, 0, 462220, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5537, 1048, 10, N'1396/3/30', N'17:55:16:20', N'1396/3/31', N'17:37:48:67', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5538, 1048, 11, N'1396/3/30', N'17:55:16:20', N'1396/3/31', N'17:37:48:67', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5539, 1048, 12, N'1396/3/30', N'17:55:16:21', N'1396/3/31', N'17:37:48:69', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5540, 1048, 13, N'1396/3/30', N'17:55:16:21', N'1396/3/31', N'17:37:48:70', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5541, 1048, 14, N'1396/3/30', N'17:55:16:21', N'1396/3/31', N'17:37:48:71', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5542, 1048, 15, N'1396/3/30', N'17:55:16:21', N'1396/3/31', N'17:37:48:71', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5543, 1048, 16, N'1396/3/30', N'17:55:16:21', N'1396/3/31', N'17:37:48:72', NULL, 0, 462219, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5544, 1048, 1, N'1396/3/30', N'20:03:53:10', N'1396/3/30', N'20:12:43:06', 529, 1, 3061, CAST(N'2017-06-20 20:03:53.000' AS DateTime), CAST(N'2017-06-20 20:12:43.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5545, 1048, 1, N'1396/3/30', N'20:12:43:23', N'1396/3/30', N'20:12:44:93', 1, 0, 10, CAST(N'2017-06-20 20:12:43.000' AS DateTime), CAST(N'2017-06-20 20:12:44.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5546, 1048, 1, N'1396/3/30', N'20:12:45:17', N'1396/3/30', N'20:22:42:83', 597, 1, 3480, CAST(N'2017-06-20 20:12:45.000' AS DateTime), CAST(N'2017-06-20 20:22:42.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5547, 1048, 1, N'1396/3/30', N'20:22:42:99', N'1396/3/30', N'20:25:31:43', 169, 0, 983, CAST(N'2017-06-20 20:22:42.000' AS DateTime), CAST(N'2017-06-20 20:25:31.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5548, 1048, 1, N'1396/3/30', N'20:25:31:59', N'1396/3/30', N'20:34:22:59', 531, 1, 3061, CAST(N'2017-06-20 20:25:31.000' AS DateTime), CAST(N'2017-06-20 20:34:22.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5549, 1048, 1, N'1396/3/30', N'20:34:22:77', N'1396/3/30', N'20:34:32:20', 10, 0, 55, CAST(N'2017-06-20 20:34:22.000' AS DateTime), CAST(N'2017-06-20 20:34:32.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5550, 1048, 1, N'1396/3/30', N'20:34:32:39', N'1396/3/30', N'20:40:41:36', 369, 1, 2119, CAST(N'2017-06-20 20:34:32.000' AS DateTime), CAST(N'2017-06-20 20:40:41.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5551, 1048, 1, N'1396/3/30', N'20:40:41:56', N'1396/3/30', N'21:37:24:96', 3403, 0, 19724, CAST(N'2017-06-20 20:40:41.000' AS DateTime), CAST(N'2017-06-20 21:37:24.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5552, 1048, 1, N'1396/3/30', N'21:37:25:14', N'1396/3/30', N'22:41:38:75', 3853, 1, 22400, CAST(N'2017-06-20 21:37:25.000' AS DateTime), CAST(N'2017-06-20 22:41:38.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5553, 1048, 1, N'1396/3/30', N'22:41:38:93', N'1396/3/30', N'22:41:58:33', 20, 0, 117, CAST(N'2017-06-20 22:41:38.000' AS DateTime), CAST(N'2017-06-20 22:41:58.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5554, 1048, 1, N'1396/3/30', N'22:41:58:49', N'1396/3/30', N'22:49:52:37', 474, 1, 2792, CAST(N'2017-06-20 22:41:58.000' AS DateTime), CAST(N'2017-06-20 22:49:52.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5555, 1048, 1, N'1396/3/30', N'22:49:52:54', N'1396/3/30', N'22:50:13:83', 21, 0, 127, CAST(N'2017-06-20 22:49:52.000' AS DateTime), CAST(N'2017-06-20 22:50:13.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5556, 1048, 1, N'1396/3/30', N'22:50:13:99', N'1396/3/30', N'22:51:40:95', 87, 1, 502, CAST(N'2017-06-20 22:50:13.000' AS DateTime), CAST(N'2017-06-20 22:51:40.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5557, 1048, 1, N'1396/3/30', N'22:51:41:12', N'1396/3/30', N'23:26:05:96', 2064, 0, 10560, CAST(N'2017-06-20 22:51:41.000' AS DateTime), CAST(N'2017-06-20 23:26:05.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5558, 1048, 1, N'1396/3/30', N'23:26:06:16', N'1396/3/30', N'23:49:19:80', 1393, 1, 6611, CAST(N'2017-06-20 23:26:06.000' AS DateTime), CAST(N'2017-06-20 23:49:19.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5559, 1048, 1, N'1396/3/30', N'23:49:20:01', N'1396/3/31', N'08:17:53:70', 30513, 0, 174771, CAST(N'2017-06-20 23:49:20.000' AS DateTime), CAST(N'2017-06-21 08:17:53.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5560, 1048, 1, N'1396/3/31', N'08:17:53:92', N'1396/3/31', N'08:49:19:36', 1886, 1, 9120, CAST(N'2017-06-21 08:17:53.000' AS DateTime), CAST(N'2017-06-21 08:49:19.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5561, 1048, 1, N'1396/3/31', N'08:49:19:59', N'1396/3/31', N'08:52:49:38', 210, 0, 998, CAST(N'2017-06-21 08:49:19.000' AS DateTime), CAST(N'2017-06-21 08:52:49.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5562, 1048, 1, N'1396/3/31', N'08:52:49:84', N'1396/3/31', N'10:11:39:80', 4730, 1, 23835, CAST(N'2017-06-21 08:52:49.000' AS DateTime), CAST(N'2017-06-21 10:11:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5563, 1048, 1, N'1396/3/31', N'10:11:40:40', N'1396/3/31', N'10:20:05:95', 505, 0, 2652, CAST(N'2017-06-21 10:11:40.000' AS DateTime), CAST(N'2017-06-21 10:20:05.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5564, 1048, 1, N'1396/3/31', N'10:20:06:13', N'1396/3/31', N'10:56:01:57', 2155, 1, 10580, CAST(N'2017-06-21 10:20:06.000' AS DateTime), CAST(N'2017-06-21 10:56:01.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5565, 1048, 1, N'1396/3/31', N'10:56:01:77', N'1396/3/31', N'11:27:04:04', 1862, 0, 9062, CAST(N'2017-06-21 10:56:01.000' AS DateTime), CAST(N'2017-06-21 11:27:04.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5566, 1048, 1, N'1396/3/31', N'11:27:04:24', N'1396/3/31', N'12:18:50:32', 3106, 1, 15337, CAST(N'2017-06-21 11:27:04.000' AS DateTime), CAST(N'2017-06-21 12:18:50.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5567, 1048, 1, N'1396/3/31', N'12:18:50:59', N'1396/3/31', N'12:29:42:92', 652, 0, 3151, CAST(N'2017-06-21 12:18:50.000' AS DateTime), CAST(N'2017-06-21 12:29:42.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5568, 1048, 1, N'1396/3/31', N'12:29:43:18', N'1396/3/31', N'12:31:35:49', 112, 1, 560, CAST(N'2017-06-21 12:29:43.000' AS DateTime), CAST(N'2017-06-21 12:31:35.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5569, 1048, 1, N'1396/3/31', N'12:31:35:87', N'1396/3/31', N'13:28:39:10', 3423, 0, 17634, CAST(N'2017-06-21 12:31:35.000' AS DateTime), CAST(N'2017-06-21 13:28:39.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5570, 1048, 1, N'1396/3/31', N'13:28:39:29', N'1396/3/31', N'13:40:10:97', 691, 1, 3624, CAST(N'2017-06-21 13:28:39.000' AS DateTime), CAST(N'2017-06-21 13:40:10.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5571, 1048, 1, N'1396/3/31', N'13:40:11:16', N'1396/3/31', N'13:40:45:74', 34, 0, 179, CAST(N'2017-06-21 13:40:11.000' AS DateTime), CAST(N'2017-06-21 13:40:45.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5572, 1048, 1, N'1396/3/31', N'13:40:45:94', N'1396/3/31', N'13:48:04:61', 439, 1, 2215, CAST(N'2017-06-21 13:40:45.000' AS DateTime), CAST(N'2017-06-21 13:48:04.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5573, 1048, 1, N'1396/3/31', N'13:48:04:77', N'1396/3/31', N'13:52:42:35', 278, 0, 1414, CAST(N'2017-06-21 13:48:04.000' AS DateTime), CAST(N'2017-06-21 13:52:42.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5574, 1048, 1, N'1396/3/31', N'13:52:42:54', N'1396/3/31', N'14:12:26:61', 1184, 1, 5823, CAST(N'2017-06-21 13:52:42.000' AS DateTime), CAST(N'2017-06-21 14:12:26.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5575, 1048, 1, N'1396/3/31', N'14:12:26:82', N'1396/3/31', N'14:12:47:60', 21, 0, 110, CAST(N'2017-06-21 14:12:26.000' AS DateTime), CAST(N'2017-06-21 14:12:47.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5576, 1048, 1, N'1396/3/31', N'14:12:47:82', N'1396/3/31', N'14:34:49:20', 1322, 1, 6501, CAST(N'2017-06-21 14:12:47.000' AS DateTime), CAST(N'2017-06-21 14:34:49.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5577, 1048, 1, N'1396/3/31', N'14:34:49:38', N'1396/3/31', N'14:35:12:58', 23, 0, 125, CAST(N'2017-06-21 14:34:49.000' AS DateTime), CAST(N'2017-06-21 14:35:12.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5578, 1048, 1, N'1396/3/31', N'14:35:12:81', N'1396/3/31', N'14:36:56:19', 103, 1, 502, CAST(N'2017-06-21 14:35:12.000' AS DateTime), CAST(N'2017-06-21 14:36:56.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5579, 1048, 1, N'1396/3/31', N'14:36:56:39', N'1396/3/31', N'15:32:47:07', 3350, 0, 16245, CAST(N'2017-06-21 14:36:56.000' AS DateTime), CAST(N'2017-06-21 15:32:47.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5580, 1048, 1, N'1396/3/31', N'15:32:47:27', N'1396/3/31', N'15:57:01:75', 1454, 1, 7534, CAST(N'2017-06-21 15:32:47.000' AS DateTime), CAST(N'2017-06-21 15:57:01.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5581, 1048, 1, N'1396/3/31', N'15:57:01:94', N'1396/3/31', N'16:03:19:11', 377, 0, 2001, CAST(N'2017-06-21 15:57:01.000' AS DateTime), CAST(N'2017-06-21 16:03:19.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5582, 1048, 1, N'1396/3/31', N'16:03:19:31', N'1396/3/31', N'16:25:50:26', 1351, 1, 7022, CAST(N'2017-06-21 16:03:19.000' AS DateTime), CAST(N'2017-06-21 16:25:50.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5583, 1048, 1, N'1396/3/31', N'16:25:50:47', N'1396/3/31', N'16:29:53:95', 243, 0, 1275, CAST(N'2017-06-21 16:25:50.000' AS DateTime), CAST(N'2017-06-21 16:29:53.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5584, 1048, 1, N'1396/3/31', N'16:29:54:12', N'1396/3/31', N'16:55:37:61', 1543, 1, 7745, CAST(N'2017-06-21 16:29:54.000' AS DateTime), CAST(N'2017-06-21 16:55:37.000' AS DateTime))
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5585, 1048, 1, N'1396/3/31', N'16:55:37:80', N'1396/3/31', N'17:37:48:73', NULL, 0, 13079, CAST(N'2017-06-21 16:55:37.000' AS DateTime), CAST(N'2017-06-21 17:37:48.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Tb_Client] OFF
SET IDENTITY_INSERT [dbo].[Tb_Devices] ON 

INSERT [dbo].[Tb_Devices] ([DeviceId], [DeviceDesc], [ComputerName], [PortName], [Active]) VALUES (1048, N'دستگاه کنترل خطوط ماشینکاری', N'S1143', N'COM3', 1)
SET IDENTITY_INSERT [dbo].[Tb_Devices] OFF
SET IDENTITY_INSERT [dbo].[Tb_DevicesLine] ON 

INSERT [dbo].[Tb_DevicesLine] ([ID], [LineId], [LineDesc], [DeviceId], [PulsID], [InputPortTypeId], [ProductLineId], [ActiveColor], [DeActiveColor], [LineActive], [ActiveStateDesc], [DeActiveStateDesc]) VALUES (1039, 1, N'وضعیت خط H45-6', 1048, 2, 1, 1, N'-16732080', N'-1048576', 0, N'کارکرد', N'توقف')
SET IDENTITY_INSERT [dbo].[Tb_DevicesLine] OFF
SET IDENTITY_INSERT [dbo].[Tb_InputPortType] ON 

INSERT [dbo].[Tb_InputPortType] ([InputPortTypeId], [InputPortType]) VALUES (1, N'پایه فعال')
INSERT [dbo].[Tb_InputPortType] ([InputPortTypeId], [InputPortType]) VALUES (2, N'پایه غیر فعال')
SET IDENTITY_INSERT [dbo].[Tb_InputPortType] OFF
SET IDENTITY_INSERT [dbo].[Tb_ProductLines] ON 

INSERT [dbo].[Tb_ProductLines] ([ID], [ProductLineId], [ProductLineDesc], [Description], [MizaneTolid], [SalonDesc]) VALUES (1, N'G1206', N'ماشین H45-6', N'-', N'0', N'سالن ماشینکاری')
SET IDENTITY_INSERT [dbo].[Tb_ProductLines] OFF
SET IDENTITY_INSERT [dbo].[Tb_PulsType] ON 

INSERT [dbo].[Tb_PulsType] ([PulsTypeId], [PulsTypeDesc]) VALUES (1, N'تعداد (شمارنده)')
INSERT [dbo].[Tb_PulsType] ([PulsTypeId], [PulsTypeDesc]) VALUES (2, N'وضعیت')
SET IDENTITY_INSERT [dbo].[Tb_PulsType] OFF
SET IDENTITY_INSERT [dbo].[Tb_Station] ON 

INSERT [dbo].[Tb_Station] ([StationId], [ProductLineId], [DeviceId], [DeviceLineId], [StationDesc], [Description]) VALUES (1, 1, 1048, 1039, N'وضعیت ماشین H45-6', N'-')
SET IDENTITY_INSERT [dbo].[Tb_Station] OFF
INSERT [dbo].[test] ([ID], [Name], [Designation]) VALUES (N'ID', N'Name', N'Designation')
INSERT [dbo].[test] ([ID], [Name], [Designation]) VALUES (N'1', N'mohsen', N'sadasdasd')
INSERT [dbo].[test] ([ID], [Name], [Designation]) VALUES (N'1', N'ali', N'xdfxcvxcv')
INSERT [dbo].[test] ([ID], [Name], [Designation]) VALUES (N'2', N'mohsen', N'sadasdasd')
ALTER TABLE [dbo].[Tb_Client2] ADD  DEFAULT ((0)) FOR [RestTime]
GO
ALTER TABLE [dbo].[Tb_Client2] ADD  DEFAULT ((0)) FOR [ViewManager]
GO
ALTER TABLE [dbo].[Tb_Client2] ADD  DEFAULT ((-1)) FOR [MachinCodeExtra]
GO
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
/****** Object:  StoredProcedure [dbo].[insertClient]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ChangeDeviceState]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DeleteDevice]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_DeleteDeviceLine]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DeleteProductLines]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_DeletePulsType]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DeleteStation]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertClient]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Mohsen Azadfallah>
-- Create date: <1396/03/17>
-- Description:	<Insert Recived Puls From Senders>
-- =============================================
CREATE PROCEDURE  [dbo].[SP_InsertClient]     
         (@DeviceID  int 
           ,@DeviceLineId int 
           ,@StartDate  nvarchar(10) 
           ,@StartTime  nvarchar(12) 
           ,@EndDate  nvarchar(10) 
           ,@EndTime nvarchar(12) 
           ,@Duration  int 
           ,@StateId  int 
           ,@Count  int 
           ,@MiladiStartDateTime  datetime  
           ,@MiladiFinishDateTime  datetime )
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO [dbo].[Tb_Client]
           ([DeviceID]
           ,[DeviceLineId]
           ,[StartDate]
           ,[StartTime]
           ,[EndDate]
           ,[EndTime]
           ,[Duration]
           ,[StateId]
           ,[Count]
           ,[MiladiStartDateTime]
           ,[MiladiFinishDateTime])
     VALUES
           (@DeviceID    
           ,@DeviceLineId    
           ,@StartDate  
           ,@StartTime    
           ,@EndDate    
           ,@EndTime   
           ,@Duration     
           ,@StateId    
           ,@Count    
           ,@MiladiStartDateTime     
           ,@MiladiFinishDateTime    )

END


GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDevices]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[SP_insertDevicesLine]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertProductLine]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_InsertPulsType]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_InsertStation]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[SP_UpdateDevice]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[SP_UpdateDevicesLine]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[SP_UpdateProductLine]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
/****** Object:  StoredProcedure [dbo].[SpUpdate_Station]    Script Date: 21/06/2017 05:37:48 ب.ظ ******/
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
ALTER DATABASE [PCSTEC] SET  READ_WRITE 
GO
