USE [master]
GO
/****** Object:  Database [PCSTEC]    Script Date: 7/15/2017 12:02:24 AM ******/
CREATE DATABASE [PCSTEC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PCSTEC2', FILENAME = N'D:\Install Applications\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PCSTEC2.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PCSTEC2_log', FILENAME = N'D:\Install Applications\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PCSTEC2_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  User [NT AUTHORITY\SERVICE]    Script Date: 7/15/2017 12:02:24 AM ******/
CREATE USER [NT AUTHORITY\SERVICE] FOR LOGIN [NT AUTHORITY\SERVICE]
GO
/****** Object:  User [NT AUTHORITY\LOCAL SERVICE]    Script Date: 7/15/2017 12:02:24 AM ******/
CREATE USER [NT AUTHORITY\LOCAL SERVICE] FOR LOGIN [NT AUTHORITY\LOCAL SERVICE] WITH DEFAULT_SCHEMA=[dbo]
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
/****** Object:  UserDefinedFunction [dbo].[daydiff]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  Table [dbo].[GanttDependencies]    Script Date: 7/15/2017 12:02:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GanttDependencies](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PredecessorID] [int] NOT NULL,
	[SuccessorID] [int] NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_GanttDependencies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GanttTasks]    Script Date: 7/15/2017 12:02:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GanttTasks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ParentID] [int] NULL,
	[OrderID] [int] NOT NULL,
	[Title] [ntext] NULL,
	[Start] [datetime] NOT NULL,
	[End] [datetime] NOT NULL,
	[PercentComplete] [decimal](5, 2) NOT NULL,
	[Expanded] [bit] NULL,
	[Summary] [bit] NOT NULL,
 CONSTRAINT [PK_GanttTasks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_Client]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  Table [dbo].[Tb_Client2]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  Table [dbo].[Tb_Devices]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  Table [dbo].[Tb_DevicesLine]    Script Date: 7/15/2017 12:02:24 AM ******/
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
	[GapTime] [int] NULL CONSTRAINT [DF_Tb_DevicesLine_GapTime]  DEFAULT ((0)),
 CONSTRAINT [PK_Tb_DevicesLine] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_InputPortType]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  Table [dbo].[Tb_ProductLines]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  Table [dbo].[Tb_PulsType]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  Table [dbo].[Tb_Station]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  Table [dbo].[test]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  View [dbo].[Vw_Appointments]    Script Date: 7/15/2017 12:02:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_Appointments]
AS
SELECT        TOP (100) PERCENT dbo.Tb_Client.DeviceStateID AS ID, dbo.Tb_Client.StateId AS Summary, dbo.Tb_Client.MiladiStartDateTime AS start, dbo.Tb_Client.MiladiFinishDateTime AS [end], 
                         dbo.Tb_Devices.DeviceDesc AS RecurrenceRule, dbo.Tb_Client.DeviceLineId AS MasterEventId, dbo.Tb_DevicesLine.LineDesc AS Description, dbo.Tb_DevicesLine.ID AS DeviceLineId
FROM            dbo.Tb_Client INNER JOIN
                         dbo.Tb_Devices ON dbo.Tb_Client.DeviceID = dbo.Tb_Devices.DeviceId INNER JOIN
                         dbo.Tb_DevicesLine ON dbo.Tb_Devices.DeviceId = dbo.Tb_DevicesLine.DeviceId INNER JOIN
                         dbo.Tb_ProductLines ON dbo.Tb_DevicesLine.ProductLineId = dbo.Tb_ProductLines.ID INNER JOIN
                         dbo.Tb_Station ON dbo.Tb_Devices.DeviceId = dbo.Tb_Station.DeviceId
ORDER BY ID


GO
/****** Object:  View [dbo].[Vw_Resources]    Script Date: 7/15/2017 12:02:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_Resources]
AS
SELECT        TOP (100) PERCENT dbo.Tb_DevicesLine.ID, dbo.Tb_ProductLines.ProductLineDesc, dbo.Tb_Devices.DeviceDesc
FROM            dbo.Tb_Devices INNER JOIN
                         dbo.Tb_DevicesLine ON dbo.Tb_Devices.DeviceId = dbo.Tb_DevicesLine.DeviceId INNER JOIN
                         dbo.Tb_ProductLines ON dbo.Tb_DevicesLine.ProductLineId = dbo.Tb_ProductLines.ID INNER JOIN
                         dbo.Tb_Station ON dbo.Tb_Devices.DeviceId = dbo.Tb_Station.DeviceId
WHERE        (dbo.Tb_Devices.Active = 1)

GO
/****** Object:  View [dbo].[Vw_AppointmentsResources]    Script Date: 7/15/2017 12:02:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_AppointmentsResources]
AS
SELECT        dbo.Vw_Resources.ID AS ResourceId, dbo.Vw_Appointments.ID AS AppointmentId
FROM            dbo.Vw_Resources INNER JOIN
                         dbo.Vw_Appointments ON dbo.Vw_Resources.ID = dbo.Vw_Appointments.DeviceLineId


GO
/****** Object:  UserDefinedFunction [dbo].[GetAllCientWithOutDiuratiion]    Script Date: 7/15/2017 12:02:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[GetAllCientWithOutDiuratiion]()
RETURNS TABLE 
AS
RETURN 
(
	SELECT        DeviceStateID, DeviceID, DeviceLineId, StartDate, StartTime, EndDate, EndTime, Duration, StateId, Count, MiladiStartDateTime, MiladiFinishDateTime
FROM            dbo.Tb_Client
WHERE        (Duration IS NULL)
)

GO
/****** Object:  UserDefinedFunction [dbo].[GetAllStationData]    Script Date: 7/15/2017 12:02:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[GetAllStationData](@StartDate datetime , @EndDate datetime )
 
RETURNS TABLE 
AS
RETURN 
(
SELECT        TOP (100) PERCENT dbo.Tb_Client.DeviceStateID, dbo.Tb_Client.DeviceID, dbo.Tb_Client.DeviceLineId, dbo.Tb_Client.StartDate, dbo.Tb_Client.StartTime, dbo.Tb_Client.EndDate, dbo.Tb_Client.EndTime, 
                         dbo.Tb_Client.Duration, dbo.Tb_Client.StateId, dbo.Tb_Client.Count, dbo.Tb_Client.MiladiStartDateTime, dbo.Tb_Client.MiladiFinishDateTime, dbo.Tb_Devices.DeviceDesc, dbo.Tb_DevicesLine.LineDesc, 
                         dbo.Tb_DevicesLine.DeActiveStateDesc, dbo.Tb_DevicesLine.ActiveStateDesc, dbo.Tb_DevicesLine.DeActiveColor, dbo.Tb_DevicesLine.ActiveColor, dbo.Tb_ProductLines.ProductLineDesc, 
                         dbo.Tb_Station.StationDesc, dbo.Tb_DevicesLine.ID,
                             (SELECT        CASE dbo.Tb_Client.StateId WHEN 1 THEN dbo.Tb_DevicesLine.ActiveColor ELSE dbo.Tb_DevicesLine.DeActiveColor END AS Expr1) AS Color, dbo.Tb_DevicesLine.GapTime
FROM            dbo.Tb_Client INNER JOIN
                         dbo.Tb_Devices ON dbo.Tb_Client.DeviceID = dbo.Tb_Devices.DeviceId INNER JOIN
                         dbo.Tb_DevicesLine ON dbo.Tb_Devices.DeviceId = dbo.Tb_DevicesLine.DeviceId AND dbo.Tb_Client.DeviceLineId = dbo.Tb_DevicesLine.LineId AND 
                         dbo.Tb_Client.Duration > dbo.Tb_DevicesLine.GapTime INNER JOIN
                         dbo.Tb_ProductLines ON dbo.Tb_DevicesLine.ProductLineId = dbo.Tb_ProductLines.ID INNER JOIN
                         dbo.Tb_Station ON dbo.Tb_Devices.DeviceId = dbo.Tb_Station.DeviceId
WHERE        (dbo.Tb_Client.MiladiStartDateTime > @StartDate) AND (dbo.Tb_Client.MiladiFinishDateTime < @EndDate)
ORDER BY dbo.Tb_Client.DeviceStateID
)



GO
/****** Object:  UserDefinedFunction [dbo].[GetDeviceInfo]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetLastStateFromSpecialLineStateByDate]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetListOfDeviceByProductLine]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetListOfInputPortTypes]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetListOfProductLines]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetListOfStations]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetPulsTypes]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetSpecialLineStateByDate]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetSpecialLineStateByDateForCount]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  View [dbo].[Vw_LineInfo]    Script Date: 7/15/2017 12:02:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_LineInfo]
AS
SELECT        dbo.Tb_Devices.DeviceId, dbo.Tb_DevicesLine.ID, dbo.Tb_DevicesLine.LineId, dbo.Tb_DevicesLine.LineDesc, dbo.Tb_DevicesLine.PulsID, dbo.Tb_DevicesLine.InputPortTypeId, 
                         dbo.Tb_DevicesLine.ProductLineId, dbo.Tb_DevicesLine.ActiveColor, dbo.Tb_DevicesLine.DeActiveColor, dbo.Tb_DevicesLine.LineActive, dbo.Tb_Devices.DeviceDesc, dbo.Tb_Devices.ComputerName, 
                         dbo.Tb_Devices.PortName, dbo.Tb_Devices.Active, dbo.Tb_DevicesLine.ActiveStateDesc, dbo.Tb_DevicesLine.DeActiveStateDesc, dbo.Tb_DevicesLine.GapTime
FROM            dbo.Tb_Devices INNER JOIN
                         dbo.Tb_DevicesLine ON dbo.Tb_Devices.DeviceId = dbo.Tb_DevicesLine.DeviceId

GO
SET IDENTITY_INSERT [dbo].[Tb_Client] ON 

GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5255, 1048, 9, N'1396/3/27', N'07:47:20:72', N'1396/3/27', N'09:44:45:54', 7045, 0, 34201, CAST(N'2017-06-17 07:47:20.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5256, 1048, 10, N'1396/3/27', N'07:47:31:03', N'1396/3/27', N'09:44:45:55', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5257, 1048, 11, N'1396/3/27', N'07:47:31:03', N'1396/3/27', N'09:44:45:59', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5258, 1048, 12, N'1396/3/27', N'07:47:31:03', N'1396/3/27', N'09:44:45:60', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5259, 1048, 13, N'1396/3/27', N'07:47:31:04', N'1396/3/27', N'09:44:45:63', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5260, 1048, 14, N'1396/3/27', N'07:47:31:04', N'1396/3/27', N'09:44:45:65', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5261, 1048, 15, N'1396/3/27', N'07:47:31:06', N'1396/3/27', N'09:44:45:68', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5262, 1048, 16, N'1396/3/27', N'07:47:31:06', N'1396/3/27', N'09:44:45:69', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5263, 1048, 1, N'1396/3/27', N'07:47:31:06', N'1396/3/27', N'09:44:45:73', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5264, 1048, 2, N'1396/3/27', N'07:47:31:06', N'1396/3/27', N'09:44:45:74', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5265, 1048, 3, N'1396/3/27', N'07:47:31:07', N'1396/3/27', N'09:44:45:77', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5266, 1048, 4, N'1396/3/27', N'07:47:31:07', N'1396/3/27', N'09:44:45:80', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5267, 1048, 5, N'1396/3/27', N'07:47:31:07', N'1396/3/27', N'09:44:45:82', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5268, 1048, 6, N'1396/3/27', N'07:47:31:07', N'1396/3/27', N'09:44:45:85', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5269, 1048, 7, N'1396/3/27', N'07:47:31:07', N'1396/3/27', N'09:44:45:88', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5270, 1048, 8, N'1396/3/27', N'07:47:31:09', N'1396/3/27', N'09:44:45:91', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5271, 1048, 17, N'1396/3/27', N'07:47:31:09', N'1396/3/27', N'09:44:45:94', 7034, 0, 34201, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5272, 1048, 18, N'1396/3/27', N'07:47:31:10', N'1396/3/27', N'09:44:45:45', 7034, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5273, 1048, 19, N'1396/3/27', N'07:47:31:10', N'1396/3/27', N'09:44:45:46', 7034, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5274, 1048, 20, N'1396/3/27', N'07:47:31:12', N'1396/3/27', N'09:44:45:46', 7034, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5275, 1048, 21, N'1396/3/27', N'07:47:31:12', N'1396/3/27', N'09:44:45:48', 7034, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5276, 1048, 22, N'1396/3/27', N'07:47:31:12', N'1396/3/27', N'09:44:45:49', 7034, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5277, 1048, 23, N'1396/3/27', N'07:47:31:12', N'1396/3/27', N'09:44:45:49', 7034, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5278, 1048, 24, N'1396/3/27', N'07:47:31:14', N'1396/3/27', N'09:44:45:51', 7034, 0, 34200, CAST(N'2017-06-17 07:47:31.000' AS DateTime), CAST(N'2017-06-17 09:44:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5279, 1048, 9, N'1396/3/27', N'14:19:09:09', N'1396/3/27', N'14:21:15:06', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5280, 1048, 10, N'1396/3/27', N'14:19:09:86', N'1396/3/27', N'14:21:15:06', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5281, 1048, 11, N'1396/3/27', N'14:19:09:86', N'1396/3/27', N'14:21:15:08', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5282, 1048, 12, N'1396/3/27', N'14:19:09:86', N'1396/3/27', N'14:21:15:08', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5283, 1048, 13, N'1396/3/27', N'14:19:09:87', N'1396/3/27', N'14:21:15:10', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5284, 1048, 14, N'1396/3/27', N'14:19:09:87', N'1396/3/27', N'14:21:15:10', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5285, 1048, 15, N'1396/3/27', N'14:19:09:87', N'1396/3/27', N'14:21:15:11', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5286, 1048, 16, N'1396/3/27', N'14:19:09:87', N'1396/3/27', N'14:21:15:11', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5287, 1048, 1, N'1396/3/27', N'14:19:09:87', N'1396/3/27', N'14:19:17:23', 7, 1, 32, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:19:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5288, 1048, 2, N'1396/3/27', N'14:19:09:89', N'1396/3/27', N'14:21:15:13', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5289, 1048, 3, N'1396/3/27', N'14:19:09:89', N'1396/3/27', N'14:21:15:13', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5290, 1048, 4, N'1396/3/27', N'14:19:09:89', N'1396/3/27', N'14:21:15:14', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5291, 1048, 5, N'1396/3/27', N'14:19:09:89', N'1396/3/27', N'14:21:15:14', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5292, 1048, 6, N'1396/3/27', N'14:19:09:89', N'1396/3/27', N'14:21:15:16', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5293, 1048, 7, N'1396/3/27', N'14:19:09:90', N'1396/3/27', N'14:21:15:16', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5294, 1048, 8, N'1396/3/27', N'14:19:09:90', N'1396/3/27', N'14:21:15:17', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5295, 1048, 17, N'1396/3/27', N'14:19:09:90', N'1396/3/27', N'14:21:15:17', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5296, 1048, 18, N'1396/3/27', N'14:19:09:90', N'1396/3/27', N'14:21:15:19', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5297, 1048, 19, N'1396/3/27', N'14:19:09:92', N'1396/3/27', N'14:21:15:19', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5298, 1048, 20, N'1396/3/27', N'14:19:09:92', N'1396/3/27', N'14:21:15:19', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5299, 1048, 21, N'1396/3/27', N'14:19:09:92', N'1396/3/27', N'14:21:15:20', 126, 0, 602, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5300, 1048, 22, N'1396/3/27', N'14:19:09:92', N'1396/3/27', N'14:21:15:03', 126, 0, 601, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5301, 1048, 23, N'1396/3/27', N'14:19:09:93', N'1396/3/27', N'14:21:15:05', 126, 0, 601, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5302, 1048, 24, N'1396/3/27', N'14:19:09:93', N'1396/3/27', N'14:21:15:05', 126, 0, 601, CAST(N'2017-06-17 14:19:09.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5303, 1048, 1, N'1396/3/27', N'14:19:17:44', N'1396/3/27', N'14:20:14:28', 57, 0, 248, CAST(N'2017-06-17 14:19:17.000' AS DateTime), CAST(N'2017-06-17 14:20:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5304, 1048, 1, N'1396/3/27', N'14:20:14:46', N'1396/3/27', N'14:21:15:11', 60, 1, 322, CAST(N'2017-06-17 14:20:14.000' AS DateTime), CAST(N'2017-06-17 14:21:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5305, 1048, 1, N'1396/3/27', N'14:21:19:06', N'1396/3/27', N'14:33:45:62', 746, 1, 3806, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-17 14:33:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5306, 1048, 2, N'1396/3/27', N'14:21:19:11', N'1396/3/30', N'12:18:07:13', 251808, 0, 1368723, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5307, 1048, 3, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:07:15', 251808, 0, 1368723, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5308, 1048, 4, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:07:16', 251808, 0, 1368723, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5309, 1048, 5, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:07:16', 251808, 0, 1368723, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5310, 1048, 6, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:07:18', 251808, 0, 1368723, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5311, 1048, 7, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:06:99', 251807, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5312, 1048, 8, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:06:99', 251807, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5313, 1048, 17, N'1396/3/27', N'14:21:19:12', N'1396/3/30', N'12:18:07:01', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5314, 1048, 18, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:01', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5315, 1048, 19, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:02', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5316, 1048, 20, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:02', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5317, 1048, 21, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:04', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5318, 1048, 22, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:04', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5319, 1048, 23, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:05', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5320, 1048, 24, N'1396/3/27', N'14:21:19:14', N'1396/3/30', N'12:18:07:05', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5321, 1048, 9, N'1396/3/27', N'14:21:19:15', N'1396/3/30', N'12:18:07:07', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5322, 1048, 10, N'1396/3/27', N'14:21:19:17', N'1396/3/30', N'12:18:07:08', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5323, 1048, 11, N'1396/3/27', N'14:21:19:17', N'1396/3/30', N'12:18:07:08', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5324, 1048, 12, N'1396/3/27', N'14:21:19:17', N'1396/3/30', N'12:18:07:10', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5325, 1048, 13, N'1396/3/27', N'14:21:19:17', N'1396/3/30', N'12:18:07:10', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5326, 1048, 14, N'1396/3/27', N'14:21:19:17', N'1396/3/30', N'12:18:07:10', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5327, 1048, 15, N'1396/3/27', N'14:21:19:17', N'1396/3/30', N'12:18:07:12', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5328, 1048, 16, N'1396/3/27', N'14:21:19:19', N'1396/3/30', N'12:18:07:12', 251808, 0, 1368722, CAST(N'2017-06-17 14:21:19.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5329, 1048, 1, N'1396/3/27', N'14:33:45:85', N'1396/3/27', N'14:33:50:05', 4, 0, 18, CAST(N'2017-06-17 14:33:45.000' AS DateTime), CAST(N'2017-06-17 14:33:50.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5330, 1048, 1, N'1396/3/27', N'14:33:50:22', N'1396/3/27', N'14:33:55:82', 5, 1, 28, CAST(N'2017-06-17 14:33:50.000' AS DateTime), CAST(N'2017-06-17 14:33:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5331, 1048, 1, N'1396/3/27', N'14:33:56:03', N'1396/3/27', N'14:34:55:00', 58, 0, 303, CAST(N'2017-06-17 14:33:56.000' AS DateTime), CAST(N'2017-06-17 14:34:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5332, 1048, 1, N'1396/3/27', N'14:34:55:19', N'1396/3/27', N'14:36:55:37', 120, 1, 625, CAST(N'2017-06-17 14:34:55.000' AS DateTime), CAST(N'2017-06-17 14:36:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5333, 1048, 1, N'1396/3/27', N'14:36:55:56', N'1396/3/27', N'14:49:28:12', 752, 0, 3917, CAST(N'2017-06-17 14:36:55.000' AS DateTime), CAST(N'2017-06-17 14:49:28.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5334, 1048, 1, N'1396/3/27', N'14:49:28:29', N'1396/3/27', N'14:57:49:23', 501, 1, 2532, CAST(N'2017-06-17 14:49:28.000' AS DateTime), CAST(N'2017-06-17 14:57:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5335, 1048, 1, N'1396/3/27', N'14:57:49:45', N'1396/3/27', N'16:33:56:65', 5767, 0, 31585, CAST(N'2017-06-17 14:57:49.000' AS DateTime), CAST(N'2017-06-17 16:33:56.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5336, 1048, 1, N'1396/3/27', N'16:33:56:84', N'1396/3/27', N'16:34:36:69', 40, 1, 233, CAST(N'2017-06-17 16:33:56.000' AS DateTime), CAST(N'2017-06-17 16:34:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5337, 1048, 1, N'1396/3/27', N'16:34:36:88', N'1396/3/27', N'16:34:37:44', 1, 0, 4, CAST(N'2017-06-17 16:34:36.000' AS DateTime), CAST(N'2017-06-17 16:34:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5338, 1048, 1, N'1396/3/27', N'16:34:37:64', N'1396/3/27', N'16:44:23:98', 586, 1, 3142, CAST(N'2017-06-17 16:34:37.000' AS DateTime), CAST(N'2017-06-17 16:44:23.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5339, 1048, 1, N'1396/3/27', N'16:44:24:22', N'1396/3/27', N'16:51:38:73', 434, 0, 2150, CAST(N'2017-06-17 16:44:24.000' AS DateTime), CAST(N'2017-06-17 16:51:38.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5340, 1048, 1, N'1396/3/27', N'16:51:38:92', N'1396/3/27', N'16:52:19:99', 41, 1, 186, CAST(N'2017-06-17 16:51:38.000' AS DateTime), CAST(N'2017-06-17 16:52:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5341, 1048, 1, N'1396/3/27', N'16:52:20:18', N'1396/3/27', N'16:57:06:46', 286, 0, 1618, CAST(N'2017-06-17 16:52:20.000' AS DateTime), CAST(N'2017-06-17 16:57:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5342, 1048, 1, N'1396/3/27', N'16:57:06:63', N'1396/3/27', N'17:15:30:03', 1103, 1, 6134, CAST(N'2017-06-17 16:57:06.000' AS DateTime), CAST(N'2017-06-17 17:15:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5343, 1048, 1, N'1396/3/27', N'17:15:30:22', N'1396/3/27', N'17:15:39:24', 9, 0, 51, CAST(N'2017-06-17 17:15:30.000' AS DateTime), CAST(N'2017-06-17 17:15:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5344, 1048, 1, N'1396/3/27', N'17:15:39:42', N'1396/3/27', N'17:21:39:56', 360, 1, 2005, CAST(N'2017-06-17 17:15:39.000' AS DateTime), CAST(N'2017-06-17 17:21:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5345, 1048, 1, N'1396/3/27', N'17:21:39:75', N'1396/3/27', N'17:40:11:60', 1112, 0, 6243, CAST(N'2017-06-17 17:21:39.000' AS DateTime), CAST(N'2017-06-17 17:40:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5346, 1048, 1, N'1396/3/27', N'17:40:11:76', N'1396/3/27', N'17:54:26:32', 855, 1, 4944, CAST(N'2017-06-17 17:40:11.000' AS DateTime), CAST(N'2017-06-17 17:54:26.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5347, 1048, 1, N'1396/3/27', N'17:54:26:44', N'1396/3/27', N'17:54:31:86', 5, 0, 33, CAST(N'2017-06-17 17:54:26.000' AS DateTime), CAST(N'2017-06-17 17:54:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5348, 1048, 1, N'1396/3/27', N'17:54:32:04', N'1396/3/27', N'17:54:36:66', 4, 1, 28, CAST(N'2017-06-17 17:54:32.000' AS DateTime), CAST(N'2017-06-17 17:54:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5349, 1048, 1, N'1396/3/27', N'17:54:36:82', N'1396/3/27', N'17:54:45:91', 9, 0, 52, CAST(N'2017-06-17 17:54:36.000' AS DateTime), CAST(N'2017-06-17 17:54:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5350, 1048, 1, N'1396/3/27', N'17:54:46:10', N'1396/3/27', N'18:06:59:79', 733, 1, 4262, CAST(N'2017-06-17 17:54:46.000' AS DateTime), CAST(N'2017-06-17 18:06:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5351, 1048, 1, N'1396/3/27', N'18:06:59:99', N'1396/3/27', N'18:31:00:80', 1441, 0, 8403, CAST(N'2017-06-17 18:06:59.000' AS DateTime), CAST(N'2017-06-17 18:31:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5352, 1048, 1, N'1396/3/27', N'18:31:00:97', N'1396/3/27', N'18:32:09:68', 69, 1, 412, CAST(N'2017-06-17 18:31:00.000' AS DateTime), CAST(N'2017-06-17 18:32:09.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5353, 1048, 1, N'1396/3/27', N'18:32:09:80', N'1396/3/27', N'18:32:30:24', 21, 0, 124, CAST(N'2017-06-17 18:32:09.000' AS DateTime), CAST(N'2017-06-17 18:32:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5354, 1048, 1, N'1396/3/27', N'18:32:30:41', N'1396/3/27', N'18:33:37:55', 67, 1, 390, CAST(N'2017-06-17 18:32:30.000' AS DateTime), CAST(N'2017-06-17 18:33:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5355, 1048, 1, N'1396/3/27', N'18:33:37:74', N'1396/3/27', N'18:34:22:29', 45, 0, 273, CAST(N'2017-06-17 18:33:37.000' AS DateTime), CAST(N'2017-06-17 18:34:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5356, 1048, 1, N'1396/3/27', N'18:34:22:46', N'1396/3/27', N'19:28:35:49', 3253, 1, 19429, CAST(N'2017-06-17 18:34:22.000' AS DateTime), CAST(N'2017-06-17 19:28:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5357, 1048, 1, N'1396/3/27', N'19:28:35:67', N'1396/3/27', N'19:35:15:85', 400, 0, 2413, CAST(N'2017-06-17 19:28:35.000' AS DateTime), CAST(N'2017-06-17 19:35:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5358, 1048, 1, N'1396/3/27', N'19:35:16:03', N'1396/3/27', N'19:40:10:43', 294, 1, 1748, CAST(N'2017-06-17 19:35:16.000' AS DateTime), CAST(N'2017-06-17 19:40:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5359, 1048, 1, N'1396/3/27', N'19:40:10:63', N'1396/3/27', N'19:42:40:03', 149, 0, 896, CAST(N'2017-06-17 19:40:10.000' AS DateTime), CAST(N'2017-06-17 19:42:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5360, 1048, 1, N'1396/3/27', N'19:42:40:20', N'1396/3/27', N'19:46:53:62', 253, 1, 1529, CAST(N'2017-06-17 19:42:40.000' AS DateTime), CAST(N'2017-06-17 19:46:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5361, 1048, 1, N'1396/3/27', N'19:46:53:79', N'1396/3/27', N'19:53:01:97', 368, 0, 2195, CAST(N'2017-06-17 19:46:53.000' AS DateTime), CAST(N'2017-06-17 19:53:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5362, 1048, 1, N'1396/3/27', N'19:53:02:14', N'1396/3/27', N'19:59:03:71', 361, 1, 2190, CAST(N'2017-06-17 19:53:02.000' AS DateTime), CAST(N'2017-06-17 19:59:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5363, 1048, 1, N'1396/3/27', N'19:59:03:87', N'1396/3/27', N'20:24:41:20', 1537, 0, 9295, CAST(N'2017-06-17 19:59:03.000' AS DateTime), CAST(N'2017-06-17 20:24:41.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5364, 1048, 1, N'1396/3/27', N'20:24:41:36', N'1396/3/27', N'20:27:16:19', 155, 1, 936, CAST(N'2017-06-17 20:24:41.000' AS DateTime), CAST(N'2017-06-17 20:27:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5365, 1048, 1, N'1396/3/27', N'20:27:16:37', N'1396/3/27', N'20:27:23:25', 7, 0, 29, CAST(N'2017-06-17 20:27:16.000' AS DateTime), CAST(N'2017-06-17 20:27:23.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5366, 1048, 1, N'1396/3/27', N'20:27:23:35', N'1396/3/27', N'20:27:33:71', 10, 1, 65, CAST(N'2017-06-17 20:27:23.000' AS DateTime), CAST(N'2017-06-17 20:27:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5367, 1048, 1, N'1396/3/27', N'20:27:33:83', N'1396/3/27', N'20:27:36:45', 3, 0, 18, CAST(N'2017-06-17 20:27:33.000' AS DateTime), CAST(N'2017-06-17 20:27:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5368, 1048, 1, N'1396/3/27', N'20:27:37:00', N'1396/3/27', N'20:42:27:88', 890, 1, 5397, CAST(N'2017-06-17 20:27:37.000' AS DateTime), CAST(N'2017-06-17 20:42:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5369, 1048, 1, N'1396/3/27', N'20:42:27:99', N'1396/3/28', N'09:41:59:03', 46771, 0, 280027, CAST(N'2017-06-17 20:42:27.000' AS DateTime), CAST(N'2017-06-18 09:41:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5370, 1048, 1, N'1396/3/28', N'09:41:59:43', N'1396/3/28', N'09:43:15:79', 76, 1, 278, CAST(N'2017-06-18 09:41:59.000' AS DateTime), CAST(N'2017-06-18 09:43:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5371, 1048, 1, N'1396/3/28', N'09:43:16:14', N'1396/3/28', N'09:43:21:49', 4, 0, 16, CAST(N'2017-06-18 09:43:16.000' AS DateTime), CAST(N'2017-06-18 09:43:21.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5372, 1048, 1, N'1396/3/28', N'09:43:21:96', N'1396/3/28', N'09:50:36:25', 435, 1, 1616, CAST(N'2017-06-18 09:43:21.000' AS DateTime), CAST(N'2017-06-18 09:50:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5373, 1048, 1, N'1396/3/28', N'09:50:36:44', N'1396/3/28', N'10:01:38:19', 661, 0, 2733, CAST(N'2017-06-18 09:50:36.000' AS DateTime), CAST(N'2017-06-18 10:01:38.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5374, 1048, 1, N'1396/3/28', N'10:01:38:46', N'1396/3/28', N'10:39:42:96', 2284, 1, 10591, CAST(N'2017-06-18 10:01:38.000' AS DateTime), CAST(N'2017-06-18 10:39:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5375, 1048, 1, N'1396/3/28', N'10:39:43:11', N'1396/3/28', N'10:40:51:89', 68, 0, 348, CAST(N'2017-06-18 10:39:43.000' AS DateTime), CAST(N'2017-06-18 10:40:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5376, 1048, 1, N'1396/3/28', N'10:40:52:09', N'1396/3/28', N'11:03:17:00', 1344, 1, 6401, CAST(N'2017-06-18 10:40:52.000' AS DateTime), CAST(N'2017-06-18 11:03:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5377, 1048, 1, N'1396/3/28', N'11:03:17:19', N'1396/3/28', N'11:04:14:67', 57, 0, 294, CAST(N'2017-06-18 11:03:17.000' AS DateTime), CAST(N'2017-06-18 11:04:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5378, 1048, 1, N'1396/3/28', N'11:04:14:87', N'1396/3/28', N'11:05:37:73', 83, 1, 414, CAST(N'2017-06-18 11:04:14.000' AS DateTime), CAST(N'2017-06-18 11:05:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5379, 1048, 1, N'1396/3/28', N'11:05:37:92', N'1396/3/28', N'11:36:58:35', 1881, 0, 9616, CAST(N'2017-06-18 11:05:37.000' AS DateTime), CAST(N'2017-06-18 11:36:58.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5380, 1048, 1, N'1396/3/28', N'11:36:58:55', N'1396/3/28', N'11:38:02:06', 63, 1, 349, CAST(N'2017-06-18 11:36:58.000' AS DateTime), CAST(N'2017-06-18 11:38:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5381, 1048, 1, N'1396/3/28', N'11:38:02:23', N'1396/3/28', N'11:38:36:69', 34, 0, 188, CAST(N'2017-06-18 11:38:02.000' AS DateTime), CAST(N'2017-06-18 11:38:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5382, 1048, 1, N'1396/3/28', N'11:38:36:89', N'1396/3/28', N'11:40:10:12', 93, 1, 480, CAST(N'2017-06-18 11:38:36.000' AS DateTime), CAST(N'2017-06-18 11:40:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5383, 1048, 1, N'1396/3/28', N'11:40:10:34', N'1396/3/28', N'11:40:15:52', 5, 0, 28, CAST(N'2017-06-18 11:40:10.000' AS DateTime), CAST(N'2017-06-18 11:40:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5384, 1048, 1, N'1396/3/28', N'11:40:15:75', N'1396/3/28', N'12:11:32:94', 1877, 1, 9751, CAST(N'2017-06-18 11:40:15.000' AS DateTime), CAST(N'2017-06-18 12:11:32.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5385, 1048, 1, N'1396/3/28', N'12:11:33:12', N'1396/3/28', N'12:22:04:60', 631, 0, 3348, CAST(N'2017-06-18 12:11:33.000' AS DateTime), CAST(N'2017-06-18 12:22:04.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5386, 1048, 1, N'1396/3/28', N'12:22:04:81', N'1396/3/28', N'12:45:42:66', 1418, 1, 6791, CAST(N'2017-06-18 12:22:04.000' AS DateTime), CAST(N'2017-06-18 12:45:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5387, 1048, 1, N'1396/3/28', N'12:45:42:84', N'1396/3/28', N'12:57:55:56', 733, 0, 3954, CAST(N'2017-06-18 12:45:42.000' AS DateTime), CAST(N'2017-06-18 12:57:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5388, 1048, 1, N'1396/3/28', N'12:57:55:75', N'1396/3/28', N'12:58:18:57', 23, 1, 123, CAST(N'2017-06-18 12:57:55.000' AS DateTime), CAST(N'2017-06-18 12:58:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5389, 1048, 1, N'1396/3/28', N'12:58:18:76', N'1396/3/28', N'13:08:09:89', 591, 0, 3240, CAST(N'2017-06-18 12:58:18.000' AS DateTime), CAST(N'2017-06-18 13:08:09.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5390, 1048, 1, N'1396/3/28', N'13:08:10:06', N'1396/3/28', N'13:09:14:55', 64, 1, 351, CAST(N'2017-06-18 13:08:10.000' AS DateTime), CAST(N'2017-06-18 13:09:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5391, 1048, 1, N'1396/3/28', N'13:09:14:72', N'1396/3/28', N'13:19:33:90', 619, 0, 3419, CAST(N'2017-06-18 13:09:14.000' AS DateTime), CAST(N'2017-06-18 13:19:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5392, 1048, 1, N'1396/3/28', N'13:19:34:00', N'1396/3/28', N'13:20:15:28', 41, 1, 238, CAST(N'2017-06-18 13:19:34.000' AS DateTime), CAST(N'2017-06-18 13:20:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5393, 1048, 1, N'1396/3/28', N'13:20:15:44', N'1396/3/28', N'13:32:44:25', 749, 0, 4135, CAST(N'2017-06-18 13:20:15.000' AS DateTime), CAST(N'2017-06-18 13:32:44.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5394, 1048, 1, N'1396/3/28', N'13:32:44:43', N'1396/3/28', N'13:35:18:01', 153, 1, 855, CAST(N'2017-06-18 13:32:44.000' AS DateTime), CAST(N'2017-06-18 13:35:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5395, 1048, 1, N'1396/3/28', N'13:35:18:16', N'1396/3/28', N'13:41:10:64', 352, 0, 1945, CAST(N'2017-06-18 13:35:18.000' AS DateTime), CAST(N'2017-06-18 13:41:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5396, 1048, 1, N'1396/3/28', N'13:41:10:90', N'1396/3/28', N'13:43:11:44', 121, 1, 653, CAST(N'2017-06-18 13:41:10.000' AS DateTime), CAST(N'2017-06-18 13:43:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5397, 1048, 1, N'1396/3/28', N'13:43:11:62', N'1396/3/28', N'13:47:36:54', 265, 0, 1369, CAST(N'2017-06-18 13:43:11.000' AS DateTime), CAST(N'2017-06-18 13:47:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5398, 1048, 1, N'1396/3/28', N'13:47:36:71', N'1396/3/28', N'13:49:00:99', 84, 1, 447, CAST(N'2017-06-18 13:47:36.000' AS DateTime), CAST(N'2017-06-18 13:49:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5399, 1048, 1, N'1396/3/28', N'13:49:01:17', N'1396/3/28', N'14:40:11:35', 3070, 0, 15981, CAST(N'2017-06-18 13:49:01.000' AS DateTime), CAST(N'2017-06-18 14:40:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5400, 1048, 1, N'1396/3/28', N'14:40:11:54', N'1396/3/28', N'14:59:13:75', 1142, 1, 6019, CAST(N'2017-06-18 14:40:11.000' AS DateTime), CAST(N'2017-06-18 14:59:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5401, 1048, 1, N'1396/3/28', N'14:59:13:93', N'1396/3/28', N'15:04:06:51', 293, 0, 1555, CAST(N'2017-06-18 14:59:13.000' AS DateTime), CAST(N'2017-06-18 15:04:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5402, 1048, 1, N'1396/3/28', N'15:04:06:68', N'1396/3/28', N'15:04:36:86', 30, 1, 168, CAST(N'2017-06-18 15:04:06.000' AS DateTime), CAST(N'2017-06-18 15:04:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5403, 1048, 1, N'1396/3/28', N'15:04:37:04', N'1396/3/28', N'15:06:59:51', 142, 0, 719, CAST(N'2017-06-18 15:04:37.000' AS DateTime), CAST(N'2017-06-18 15:06:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5404, 1048, 1, N'1396/3/28', N'15:06:59:62', N'1396/3/28', N'15:08:01:54', 62, 1, 329, CAST(N'2017-06-18 15:06:59.000' AS DateTime), CAST(N'2017-06-18 15:08:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5405, 1048, 1, N'1396/3/28', N'15:08:01:71', N'1396/3/28', N'15:08:08:45', 7, 0, 38, CAST(N'2017-06-18 15:08:01.000' AS DateTime), CAST(N'2017-06-18 15:08:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5406, 1048, 1, N'1396/3/28', N'15:08:08:64', N'1396/3/28', N'15:08:15:96', 7, 1, 36, CAST(N'2017-06-18 15:08:08.000' AS DateTime), CAST(N'2017-06-18 15:08:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5407, 1048, 1, N'1396/3/28', N'15:08:16:15', N'1396/3/28', N'15:10:14:85', 118, 0, 622, CAST(N'2017-06-18 15:08:16.000' AS DateTime), CAST(N'2017-06-18 15:10:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5408, 1048, 1, N'1396/3/28', N'15:10:15:02', N'1396/3/28', N'15:14:57:66', 282, 1, 1462, CAST(N'2017-06-18 15:10:15.000' AS DateTime), CAST(N'2017-06-18 15:14:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5409, 1048, 1, N'1396/3/28', N'15:14:57:87', N'1396/3/28', N'15:15:05:49', 8, 0, 41, CAST(N'2017-06-18 15:14:57.000' AS DateTime), CAST(N'2017-06-18 15:15:05.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5410, 1048, 1, N'1396/3/28', N'15:15:05:67', N'1396/3/28', N'15:15:47:22', 41, 1, 223, CAST(N'2017-06-18 15:15:05.000' AS DateTime), CAST(N'2017-06-18 15:15:47.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5411, 1048, 1, N'1396/3/28', N'15:15:47:40', N'1396/3/28', N'15:16:01:96', 14, 0, 84, CAST(N'2017-06-18 15:15:47.000' AS DateTime), CAST(N'2017-06-18 15:16:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5412, 1048, 1, N'1396/3/28', N'15:16:02:16', N'1396/3/28', N'15:19:43:73', 221, 1, 1170, CAST(N'2017-06-18 15:16:02.000' AS DateTime), CAST(N'2017-06-18 15:19:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5413, 1048, 1, N'1396/3/28', N'15:19:43:96', N'1396/3/28', N'15:19:51:55', 8, 0, 40, CAST(N'2017-06-18 15:19:43.000' AS DateTime), CAST(N'2017-06-18 15:19:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5414, 1048, 1, N'1396/3/28', N'15:19:51:77', N'1396/3/28', N'15:24:18:71', 267, 1, 1372, CAST(N'2017-06-18 15:19:51.000' AS DateTime), CAST(N'2017-06-18 15:24:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5415, 1048, 1, N'1396/3/28', N'15:24:18:90', N'1396/3/28', N'15:24:26:28', 8, 0, 38, CAST(N'2017-06-18 15:24:18.000' AS DateTime), CAST(N'2017-06-18 15:24:26.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5416, 1048, 1, N'1396/3/28', N'15:24:26:45', N'1396/3/28', N'15:29:00:51', 274, 1, 1350, CAST(N'2017-06-18 15:24:26.000' AS DateTime), CAST(N'2017-06-18 15:29:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5417, 1048, 1, N'1396/3/28', N'15:29:00:77', N'1396/3/28', N'15:29:11:75', 11, 0, 42, CAST(N'2017-06-18 15:29:00.000' AS DateTime), CAST(N'2017-06-18 15:29:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5418, 1048, 1, N'1396/3/28', N'15:29:11:96', N'1396/3/28', N'15:29:14:90', 3, 1, 13, CAST(N'2017-06-18 15:29:11.000' AS DateTime), CAST(N'2017-06-18 15:29:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5419, 1048, 1, N'1396/3/28', N'15:29:15:08', N'1396/3/28', N'15:35:25:88', 370, 0, 1998, CAST(N'2017-06-18 15:29:15.000' AS DateTime), CAST(N'2017-06-18 15:35:25.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5420, 1048, 1, N'1396/3/28', N'15:35:26:09', N'1396/3/28', N'15:36:13:21', 47, 1, 257, CAST(N'2017-06-18 15:35:26.000' AS DateTime), CAST(N'2017-06-18 15:36:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5421, 1048, 1, N'1396/3/28', N'15:36:13:39', N'1396/3/28', N'15:36:20:75', 7, 0, 39, CAST(N'2017-06-18 15:36:13.000' AS DateTime), CAST(N'2017-06-18 15:36:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5422, 1048, 1, N'1396/3/28', N'15:36:20:94', N'1396/3/28', N'15:37:03:64', 43, 1, 222, CAST(N'2017-06-18 15:36:20.000' AS DateTime), CAST(N'2017-06-18 15:37:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5423, 1048, 1, N'1396/3/28', N'15:37:03:83', N'1396/3/28', N'15:37:10:47', 7, 0, 40, CAST(N'2017-06-18 15:37:03.000' AS DateTime), CAST(N'2017-06-18 15:37:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5424, 1048, 1, N'1396/3/28', N'15:37:10:57', N'1396/3/28', N'15:37:20:48', 10, 1, 55, CAST(N'2017-06-18 15:37:10.000' AS DateTime), CAST(N'2017-06-18 15:37:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5425, 1048, 1, N'1396/3/28', N'15:37:20:67', N'1396/3/28', N'15:41:45:44', 265, 0, 1397, CAST(N'2017-06-18 15:37:20.000' AS DateTime), CAST(N'2017-06-18 15:41:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5426, 1048, 1, N'1396/3/28', N'15:41:45:61', N'1396/3/28', N'15:42:21:01', 35, 1, 196, CAST(N'2017-06-18 15:41:45.000' AS DateTime), CAST(N'2017-06-18 15:42:21.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5427, 1048, 1, N'1396/3/28', N'15:42:21:21', N'1396/3/28', N'15:42:27:76', 6, 0, 35, CAST(N'2017-06-18 15:42:21.000' AS DateTime), CAST(N'2017-06-18 15:42:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5428, 1048, 1, N'1396/3/28', N'15:42:27:95', N'1396/3/28', N'15:42:33:45', 6, 1, 31, CAST(N'2017-06-18 15:42:27.000' AS DateTime), CAST(N'2017-06-18 15:42:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5429, 1048, 1, N'1396/3/28', N'15:42:33:68', N'1396/3/28', N'15:44:39:09', 125, 0, 676, CAST(N'2017-06-18 15:42:33.000' AS DateTime), CAST(N'2017-06-18 15:44:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5430, 1048, 1, N'1396/3/28', N'15:44:39:26', N'1396/3/28', N'15:45:43:54', 64, 1, 192, CAST(N'2017-06-18 15:44:39.000' AS DateTime), CAST(N'2017-06-18 15:45:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5431, 1048, 1, N'1396/3/28', N'15:45:43:76', N'1396/3/28', N'15:45:55:81', 12, 0, 35, CAST(N'2017-06-18 15:45:43.000' AS DateTime), CAST(N'2017-06-18 15:45:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5432, 1048, 1, N'1396/3/28', N'15:45:56:40', N'1396/3/28', N'15:46:00:64', 4, 1, 9, CAST(N'2017-06-18 15:45:56.000' AS DateTime), CAST(N'2017-06-18 15:46:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5433, 1048, 1, N'1396/3/28', N'15:46:00:90', N'1396/3/28', N'15:46:22:34', 22, 0, 92, CAST(N'2017-06-18 15:46:00.000' AS DateTime), CAST(N'2017-06-18 15:46:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5434, 1048, 1, N'1396/3/28', N'15:46:22:57', N'1396/3/28', N'15:50:34:24', 252, 1, 1213, CAST(N'2017-06-18 15:46:22.000' AS DateTime), CAST(N'2017-06-18 15:50:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5435, 1048, 1, N'1396/3/28', N'15:50:34:39', N'1396/3/28', N'15:50:40:08', 5, 0, 39, CAST(N'2017-06-18 15:50:34.000' AS DateTime), CAST(N'2017-06-18 15:50:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5436, 1048, 1, N'1396/3/28', N'15:50:40:22', N'1396/3/28', N'15:50:56:98', 16, 1, 97, CAST(N'2017-06-18 15:50:40.000' AS DateTime), CAST(N'2017-06-18 15:50:56.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5437, 1048, 1, N'1396/3/28', N'15:50:57:16', N'1396/3/28', N'15:52:04:66', 67, 0, 384, CAST(N'2017-06-18 15:50:57.000' AS DateTime), CAST(N'2017-06-18 15:52:04.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5438, 1048, 1, N'1396/3/28', N'15:52:04:86', N'1396/3/28', N'15:54:55:10', 170, 1, 931, CAST(N'2017-06-18 15:52:04.000' AS DateTime), CAST(N'2017-06-18 15:54:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5439, 1048, 1, N'1396/3/28', N'15:54:55:28', N'1396/3/28', N'15:55:02:16', 6, 0, 39, CAST(N'2017-06-18 15:54:55.000' AS DateTime), CAST(N'2017-06-18 15:55:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5440, 1048, 1, N'1396/3/28', N'15:55:02:30', N'1396/3/28', N'15:58:09:19', 187, 1, 1023, CAST(N'2017-06-18 15:55:02.000' AS DateTime), CAST(N'2017-06-18 15:58:09.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5441, 1048, 1, N'1396/3/28', N'15:58:09:68', N'1396/3/28', N'15:58:18:10', 8, 0, 42, CAST(N'2017-06-18 15:58:09.000' AS DateTime), CAST(N'2017-06-18 15:58:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5442, 1048, 1, N'1396/3/28', N'15:58:18:26', N'1396/3/28', N'16:01:18:18', 180, 1, 1002, CAST(N'2017-06-18 15:58:18.000' AS DateTime), CAST(N'2017-06-18 16:01:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5443, 1048, 1, N'1396/3/28', N'16:01:18:34', N'1396/3/28', N'16:01:25:61', 7, 0, 39, CAST(N'2017-06-18 16:01:18.000' AS DateTime), CAST(N'2017-06-18 16:01:25.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5444, 1048, 1, N'1396/3/28', N'16:01:25:78', N'1396/3/28', N'16:01:28:40', 3, 1, 13, CAST(N'2017-06-18 16:01:25.000' AS DateTime), CAST(N'2017-06-18 16:01:28.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5445, 1048, 1, N'1396/3/28', N'16:01:28:57', N'1396/3/28', N'16:14:44:18', 796, 0, 4402, CAST(N'2017-06-18 16:01:28.000' AS DateTime), CAST(N'2017-06-18 16:14:44.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5446, 1048, 1, N'1396/3/28', N'16:14:44:37', N'1396/3/28', N'17:02:54:60', 2890, 1, 16084, CAST(N'2017-06-18 16:14:44.000' AS DateTime), CAST(N'2017-06-18 17:02:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5447, 1048, 1, N'1396/3/28', N'17:02:54:76', N'1396/3/28', N'17:08:51:33', 357, 0, 1887, CAST(N'2017-06-18 17:02:54.000' AS DateTime), CAST(N'2017-06-18 17:08:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5448, 1048, 1, N'1396/3/28', N'17:08:51:51', N'1396/3/28', N'17:09:34:96', 43, 1, 237, CAST(N'2017-06-18 17:08:51.000' AS DateTime), CAST(N'2017-06-18 17:09:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5449, 1048, 1, N'1396/3/28', N'17:09:35:13', N'1396/3/28', N'17:17:46:79', 491, 0, 2567, CAST(N'2017-06-18 17:09:35.000' AS DateTime), CAST(N'2017-06-18 17:17:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5450, 1048, 1, N'1396/3/28', N'17:17:47:04', N'1396/3/28', N'17:33:06:39', 919, 1, 4756, CAST(N'2017-06-18 17:17:47.000' AS DateTime), CAST(N'2017-06-18 17:33:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5451, 1048, 1, N'1396/3/28', N'17:33:06:59', N'1396/3/28', N'17:49:49:33', 1003, 0, 5526, CAST(N'2017-06-18 17:33:06.000' AS DateTime), CAST(N'2017-06-18 17:49:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5452, 1048, 1, N'1396/3/28', N'17:49:49:54', N'1396/3/28', N'17:50:27:60', 38, 1, 209, CAST(N'2017-06-18 17:49:49.000' AS DateTime), CAST(N'2017-06-18 17:50:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5453, 1048, 1, N'1396/3/28', N'17:50:27:79', N'1396/3/28', N'17:50:28:90', 1, 0, 7, CAST(N'2017-06-18 17:50:27.000' AS DateTime), CAST(N'2017-06-18 17:50:28.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5454, 1048, 1, N'1396/3/28', N'17:50:29:09', N'1396/3/28', N'18:16:31:89', 1562, 1, 8607, CAST(N'2017-06-18 17:50:29.000' AS DateTime), CAST(N'2017-06-18 18:16:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5455, 1048, 1, N'1396/3/28', N'18:16:32:07', N'1396/3/28', N'18:21:48:48', 316, 0, 1721, CAST(N'2017-06-18 18:16:32.000' AS DateTime), CAST(N'2017-06-18 18:21:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5456, 1048, 1, N'1396/3/28', N'18:21:48:65', N'1396/3/28', N'18:22:01:86', 13, 1, 73, CAST(N'2017-06-18 18:21:48.000' AS DateTime), CAST(N'2017-06-18 18:22:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5457, 1048, 1, N'1396/3/28', N'18:22:02:05', N'1396/3/28', N'18:22:03:04', 0, 0, 7, CAST(N'2017-06-18 18:22:02.000' AS DateTime), CAST(N'2017-06-18 18:22:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5458, 1048, 1, N'1396/3/28', N'18:22:03:23', N'1396/3/28', N'18:27:48:23', 345, 1, 1920, CAST(N'2017-06-18 18:22:03.000' AS DateTime), CAST(N'2017-06-18 18:27:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5459, 1048, 1, N'1396/3/28', N'18:27:48:41', N'1396/3/28', N'18:27:51:72', 3, 0, 19, CAST(N'2017-06-18 18:27:48.000' AS DateTime), CAST(N'2017-06-18 18:27:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5460, 1048, 1, N'1396/3/28', N'18:27:51:92', N'1396/3/28', N'18:44:35:11', 1003, 1, 5631, CAST(N'2017-06-18 18:27:51.000' AS DateTime), CAST(N'2017-06-18 18:44:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5461, 1048, 1, N'1396/3/28', N'18:44:35:31', N'1396/3/28', N'18:45:39:93', 64, 0, 367, CAST(N'2017-06-18 18:44:35.000' AS DateTime), CAST(N'2017-06-18 18:45:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5462, 1048, 1, N'1396/3/28', N'18:45:40:09', N'1396/3/28', N'18:48:29:32', 169, 1, 936, CAST(N'2017-06-18 18:45:40.000' AS DateTime), CAST(N'2017-06-18 18:48:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5463, 1048, 1, N'1396/3/28', N'18:48:29:51', N'1396/3/28', N'20:57:57:24', 7768, 0, 44408, CAST(N'2017-06-18 18:48:29.000' AS DateTime), CAST(N'2017-06-18 20:57:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5464, 1048, 1, N'1396/3/28', N'20:57:57:40', N'1396/3/28', N'20:58:06:98', 9, 1, 57, CAST(N'2017-06-18 20:57:57.000' AS DateTime), CAST(N'2017-06-18 20:58:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5465, 1048, 1, N'1396/3/28', N'20:58:07:16', N'1396/3/28', N'20:58:33:46', 26, 0, 155, CAST(N'2017-06-18 20:58:07.000' AS DateTime), CAST(N'2017-06-18 20:58:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5466, 1048, 1, N'1396/3/28', N'20:58:33:63', N'1396/3/28', N'21:00:10:33', 97, 1, 566, CAST(N'2017-06-18 20:58:33.000' AS DateTime), CAST(N'2017-06-18 21:00:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5467, 1048, 1, N'1396/3/28', N'21:00:10:49', N'1396/3/28', N'21:00:14:77', 4, 0, 27, CAST(N'2017-06-18 21:00:10.000' AS DateTime), CAST(N'2017-06-18 21:00:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5468, 1048, 1, N'1396/3/28', N'21:00:14:93', N'1396/3/28', N'21:07:33:82', 439, 1, 2483, CAST(N'2017-06-18 21:00:14.000' AS DateTime), CAST(N'2017-06-18 21:07:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5469, 1048, 1, N'1396/3/28', N'21:07:34:04', N'1396/3/28', N'21:10:18:95', 164, 0, 951, CAST(N'2017-06-18 21:07:34.000' AS DateTime), CAST(N'2017-06-18 21:10:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5470, 1048, 1, N'1396/3/28', N'21:10:19:23', N'1396/3/28', N'21:13:15:69', 176, 1, 1022, CAST(N'2017-06-18 21:10:19.000' AS DateTime), CAST(N'2017-06-18 21:13:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5471, 1048, 1, N'1396/3/28', N'21:13:15:90', N'1396/3/28', N'23:06:22:78', 6787, 0, 39315, CAST(N'2017-06-18 21:13:15.000' AS DateTime), CAST(N'2017-06-18 23:06:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5472, 1048, 1, N'1396/3/28', N'23:06:22:95', N'1396/3/28', N'23:07:33:79', 71, 1, 380, CAST(N'2017-06-18 23:06:22.000' AS DateTime), CAST(N'2017-06-18 23:07:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5473, 1048, 1, N'1396/3/28', N'23:07:33:99', N'1396/3/28', N'23:08:08:98', 35, 0, 179, CAST(N'2017-06-18 23:07:33.000' AS DateTime), CAST(N'2017-06-18 23:08:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5474, 1048, 1, N'1396/3/28', N'23:08:09:17', N'1396/3/28', N'23:47:58:65', 2389, 1, 11895, CAST(N'2017-06-18 23:08:09.000' AS DateTime), CAST(N'2017-06-18 23:47:58.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5475, 1048, 1, N'1396/3/28', N'23:47:58:85', N'1396/3/28', N'23:48:43:96', 45, 0, 223, CAST(N'2017-06-18 23:47:58.000' AS DateTime), CAST(N'2017-06-18 23:48:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5476, 1048, 1, N'1396/3/28', N'23:48:44:16', N'1396/3/29', N'01:28:49:21', 6005, 1, 32691, CAST(N'2017-06-18 23:48:44.000' AS DateTime), CAST(N'2017-06-19 01:28:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5477, 1048, 1, N'1396/3/29', N'01:28:49:38', N'1396/3/29', N'09:59:21:48', 30632, 0, 172541, CAST(N'2017-06-19 01:28:49.000' AS DateTime), CAST(N'2017-06-19 09:59:21.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5478, 1048, 1, N'1396/3/29', N'09:59:21:65', N'1396/3/29', N'11:39:52:99', 6031, 1, 29088, CAST(N'2017-06-19 09:59:21.000' AS DateTime), CAST(N'2017-06-19 11:39:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5479, 1048, 1, N'1396/3/29', N'11:39:53:21', N'1396/3/29', N'11:51:08:57', 675, 0, 3305, CAST(N'2017-06-19 11:39:53.000' AS DateTime), CAST(N'2017-06-19 11:51:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5480, 1048, 1, N'1396/3/29', N'11:51:08:94', N'1396/3/29', N'15:16:22:60', 12314, 1, 62451, CAST(N'2017-06-19 11:51:08.000' AS DateTime), CAST(N'2017-06-19 15:16:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5481, 1048, 1, N'1396/3/29', N'15:16:22:73', N'1396/3/29', N'15:20:37:64', 255, 0, 1335, CAST(N'2017-06-19 15:16:22.000' AS DateTime), CAST(N'2017-06-19 15:20:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5482, 1048, 1, N'1396/3/29', N'15:20:37:94', N'1396/3/29', N'15:28:13:29', 456, 1, 2378, CAST(N'2017-06-19 15:20:37.000' AS DateTime), CAST(N'2017-06-19 15:28:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5483, 1048, 1, N'1396/3/29', N'15:28:13:47', N'1396/3/29', N'15:28:30:34', 17, 0, 87, CAST(N'2017-06-19 15:28:13.000' AS DateTime), CAST(N'2017-06-19 15:28:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5484, 1048, 1, N'1396/3/29', N'15:28:30:52', N'1396/3/29', N'16:06:27:08', 2276, 1, 11947, CAST(N'2017-06-19 15:28:30.000' AS DateTime), CAST(N'2017-06-19 16:06:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5485, 1048, 1, N'1396/3/29', N'16:06:27:25', N'1396/3/29', N'17:01:50:69', 3323, 0, 17887, CAST(N'2017-06-19 16:06:27.000' AS DateTime), CAST(N'2017-06-19 17:01:50.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5486, 1048, 1, N'1396/3/29', N'17:01:50:87', N'1396/3/29', N'17:08:02:02', 371, 1, 2016, CAST(N'2017-06-19 17:01:50.000' AS DateTime), CAST(N'2017-06-19 17:08:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5487, 1048, 1, N'1396/3/29', N'17:08:02:24', N'1396/3/29', N'17:08:27:51', 25, 0, 149, CAST(N'2017-06-19 17:08:02.000' AS DateTime), CAST(N'2017-06-19 17:08:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5488, 1048, 1, N'1396/3/29', N'17:08:27:68', N'1396/3/29', N'17:09:48:10', 80, 1, 450, CAST(N'2017-06-19 17:08:27.000' AS DateTime), CAST(N'2017-06-19 17:09:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5489, 1048, 1, N'1396/3/29', N'17:09:48:26', N'1396/3/29', N'17:09:52:89', 4, 0, 25, CAST(N'2017-06-19 17:09:48.000' AS DateTime), CAST(N'2017-06-19 17:09:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5490, 1048, 1, N'1396/3/29', N'17:09:53:16', N'1396/3/29', N'17:22:41:02', 767, 1, 4178, CAST(N'2017-06-19 17:09:53.000' AS DateTime), CAST(N'2017-06-19 17:22:41.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5491, 1048, 1, N'1396/3/29', N'17:22:41:21', N'1396/3/29', N'17:48:46:77', 1565, 0, 8390, CAST(N'2017-06-19 17:22:41.000' AS DateTime), CAST(N'2017-06-19 17:48:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5492, 1048, 1, N'1396/3/29', N'17:48:47:07', N'1396/3/29', N'18:18:57:54', 1810, 1, 8765, CAST(N'2017-06-19 17:48:47.000' AS DateTime), CAST(N'2017-06-19 18:18:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5493, 1048, 1, N'1396/3/29', N'18:18:57:83', N'1396/3/29', N'18:19:03:34', 6, 0, 25, CAST(N'2017-06-19 18:18:57.000' AS DateTime), CAST(N'2017-06-19 18:19:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5494, 1048, 1, N'1396/3/29', N'18:19:03:50', N'1396/3/29', N'18:52:00:22', 1977, 1, 9332, CAST(N'2017-06-19 18:19:03.000' AS DateTime), CAST(N'2017-06-19 18:52:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5495, 1048, 1, N'1396/3/29', N'18:52:00:41', N'1396/3/29', N'19:18:03:34', 1563, 0, 7444, CAST(N'2017-06-19 18:52:00.000' AS DateTime), CAST(N'2017-06-19 19:18:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5496, 1048, 1, N'1396/3/29', N'19:18:03:53', N'1396/3/29', N'19:38:59:74', 1256, 1, 6296, CAST(N'2017-06-19 19:18:03.000' AS DateTime), CAST(N'2017-06-19 19:38:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5497, 1048, 1, N'1396/3/29', N'19:38:59:97', N'1396/3/29', N'19:59:02:07', 1202, 0, 5925, CAST(N'2017-06-19 19:38:59.000' AS DateTime), CAST(N'2017-06-19 19:59:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5498, 1048, 1, N'1396/3/29', N'19:59:02:24', N'1396/3/29', N'20:04:34:02', 331, 1, 1678, CAST(N'2017-06-19 19:59:02.000' AS DateTime), CAST(N'2017-06-19 20:04:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5499, 1048, 1, N'1396/3/29', N'20:04:34:29', N'1396/3/29', N'20:04:39:80', 5, 0, 27, CAST(N'2017-06-19 20:04:34.000' AS DateTime), CAST(N'2017-06-19 20:04:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5500, 1048, 1, N'1396/3/29', N'20:04:39:97', N'1396/3/29', N'21:19:46:78', 4507, 1, 22387, CAST(N'2017-06-19 20:04:39.000' AS DateTime), CAST(N'2017-06-19 21:19:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5501, 1048, 1, N'1396/3/29', N'21:19:46:95', N'1396/3/29', N'21:45:52:61', 1566, 0, 7599, CAST(N'2017-06-19 21:19:46.000' AS DateTime), CAST(N'2017-06-19 21:45:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5502, 1048, 1, N'1396/3/29', N'21:45:52:78', N'1396/3/29', N'21:49:00:82', 188, 1, 941, CAST(N'2017-06-19 21:45:52.000' AS DateTime), CAST(N'2017-06-19 21:49:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5503, 1048, 1, N'1396/3/29', N'21:49:01:05', N'1396/3/29', N'21:49:30:27', 29, 0, 141, CAST(N'2017-06-19 21:49:01.000' AS DateTime), CAST(N'2017-06-19 21:49:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5504, 1048, 1, N'1396/3/29', N'21:49:30:50', N'1396/3/29', N'22:00:42:65', 672, 1, 3272, CAST(N'2017-06-19 21:49:30.000' AS DateTime), CAST(N'2017-06-19 22:00:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5505, 1048, 1, N'1396/3/29', N'22:00:42:82', N'1396/3/29', N'22:02:53:68', 131, 0, 697, CAST(N'2017-06-19 22:00:42.000' AS DateTime), CAST(N'2017-06-19 22:02:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5506, 1048, 1, N'1396/3/29', N'22:02:53:85', N'1396/3/29', N'22:07:19:03', 265, 1, 1396, CAST(N'2017-06-19 22:02:53.000' AS DateTime), CAST(N'2017-06-19 22:07:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5507, 1048, 1, N'1396/3/29', N'22:07:19:21', N'1396/3/30', N'00:07:53:36', 7234, 0, 32537, CAST(N'2017-06-19 22:07:19.000' AS DateTime), CAST(N'2017-06-20 00:07:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5508, 1048, 1, N'1396/3/30', N'00:07:53:57', N'1396/3/30', N'01:28:42:33', 4849, 1, 21414, CAST(N'2017-06-20 00:07:53.000' AS DateTime), CAST(N'2017-06-20 01:28:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5509, 1048, 1, N'1396/3/30', N'01:28:42:52', N'1396/3/30', N'02:26:37:77', 3475, 0, 20343, CAST(N'2017-06-20 01:28:42.000' AS DateTime), CAST(N'2017-06-20 02:26:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5510, 1048, 1, N'1396/3/30', N'02:26:37:94', N'1396/3/30', N'02:49:18:74', 1361, 1, 7980, CAST(N'2017-06-20 02:26:37.000' AS DateTime), CAST(N'2017-06-20 02:49:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5511, 1048, 1, N'1396/3/30', N'02:49:18:91', N'1396/3/30', N'02:49:51:36', 33, 0, 182, CAST(N'2017-06-20 02:49:18.000' AS DateTime), CAST(N'2017-06-20 02:49:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5512, 1048, 1, N'1396/3/30', N'02:49:51:53', N'1396/3/30', N'02:52:40:85', 169, 1, 1013, CAST(N'2017-06-20 02:49:51.000' AS DateTime), CAST(N'2017-06-20 02:52:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5513, 1048, 1, N'1396/3/30', N'02:52:41:01', N'1396/3/30', N'03:08:29:38', 948, 0, 5668, CAST(N'2017-06-20 02:52:41.000' AS DateTime), CAST(N'2017-06-20 03:08:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5514, 1048, 1, N'1396/3/30', N'03:08:29:58', N'1396/3/30', N'03:12:02:58', 213, 1, 1293, CAST(N'2017-06-20 03:08:29.000' AS DateTime), CAST(N'2017-06-20 03:12:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5515, 1048, 1, N'1396/3/30', N'03:12:02:74', N'1396/3/30', N'03:32:36:38', 1234, 0, 7417, CAST(N'2017-06-20 03:12:02.000' AS DateTime), CAST(N'2017-06-20 03:32:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5516, 1048, 1, N'1396/3/30', N'03:32:36:54', N'1396/3/30', N'03:36:18:77', 222, 1, 1344, CAST(N'2017-06-20 03:32:36.000' AS DateTime), CAST(N'2017-06-20 03:36:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5517, 1048, 1, N'1396/3/30', N'03:36:18:93', N'1396/3/30', N'03:39:03:68', 165, 0, 1000, CAST(N'2017-06-20 03:36:18.000' AS DateTime), CAST(N'2017-06-20 03:39:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5518, 1048, 1, N'1396/3/30', N'03:39:03:83', N'1396/3/30', N'04:29:10:80', 3007, 1, 17999, CAST(N'2017-06-20 03:39:03.000' AS DateTime), CAST(N'2017-06-20 04:29:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5519, 1048, 1, N'1396/3/30', N'04:29:10:97', N'1396/3/30', N'12:18:07:13', 28137, 0, 144036, CAST(N'2017-06-20 04:29:10.000' AS DateTime), CAST(N'2017-06-20 12:18:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5520, 1048, 1, N'1396/3/30', N'17:55:15:55', N'1396/3/30', N'20:03:52:91', 7717, 0, 43525, CAST(N'2017-06-20 17:55:15.000' AS DateTime), CAST(N'2017-06-20 20:03:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5521, 1048, 2, N'1396/3/30', N'17:55:16:14', N'1396/4/3', N'07:31:03:31', 308147, 0, 1731660, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5522, 1048, 3, N'1396/3/30', N'17:55:16:14', N'1396/4/3', N'07:31:03:31', 308147, 0, 1731660, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5523, 1048, 4, N'1396/3/30', N'17:55:16:15', N'1396/4/3', N'07:31:03:32', 308147, 0, 1731660, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5524, 1048, 5, N'1396/3/30', N'17:55:16:15', N'1396/4/3', N'07:31:03:32', 308147, 0, 1731660, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5525, 1048, 6, N'1396/3/30', N'17:55:16:15', N'1396/4/3', N'07:31:03:34', 308147, 0, 1731660, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5526, 1048, 7, N'1396/3/30', N'17:55:16:15', N'1396/4/3', N'07:31:03:34', 308147, 0, 1731660, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5527, 1048, 8, N'1396/3/30', N'17:55:16:16', N'1396/4/3', N'07:31:03:36', 308147, 0, 1731660, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5528, 1048, 17, N'1396/3/30', N'17:55:16:17', N'1396/4/3', N'07:31:03:37', 308147, 0, 1731952, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5529, 1048, 18, N'1396/3/30', N'17:55:16:17', N'1396/4/3', N'07:31:03:37', 308147, 0, 1731952, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5530, 1048, 19, N'1396/3/30', N'17:55:16:18', N'1396/4/3', N'07:31:03:39', 308147, 0, 1731952, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5531, 1048, 20, N'1396/3/30', N'17:55:16:18', N'1396/4/3', N'07:31:03:39', 308147, 0, 1731952, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5532, 1048, 21, N'1396/3/30', N'17:55:16:19', N'1396/4/3', N'07:31:03:40', 308147, 0, 1731952, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5533, 1048, 22, N'1396/3/30', N'17:55:16:19', N'1396/4/3', N'07:31:03:40', 308147, 0, 1731952, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5534, 1048, 23, N'1396/3/30', N'17:55:16:19', N'1396/4/3', N'07:31:03:18', 308147, 0, 1731951, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5535, 1048, 24, N'1396/3/30', N'17:55:16:19', N'1396/4/3', N'07:31:03:20', 308147, 0, 1731951, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5536, 1048, 9, N'1396/3/30', N'17:55:16:20', N'1396/4/3', N'07:31:03:23', 308147, 0, 1731641, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5537, 1048, 10, N'1396/3/30', N'17:55:16:20', N'1396/4/3', N'07:31:03:23', 308147, 0, 1731641, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5538, 1048, 11, N'1396/3/30', N'17:55:16:20', N'1396/4/3', N'07:31:03:25', 308147, 0, 1731641, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5539, 1048, 12, N'1396/3/30', N'17:55:16:21', N'1396/4/3', N'07:31:03:25', 308147, 0, 1731641, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5540, 1048, 13, N'1396/3/30', N'17:55:16:21', N'1396/4/3', N'07:31:03:26', 308147, 0, 1731641, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5541, 1048, 14, N'1396/3/30', N'17:55:16:21', N'1396/4/3', N'07:31:03:28', 308147, 0, 1731641, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5542, 1048, 15, N'1396/3/30', N'17:55:16:21', N'1396/4/3', N'07:31:03:28', 308147, 0, 1731641, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5543, 1048, 16, N'1396/3/30', N'17:55:16:21', N'1396/4/3', N'07:31:03:29', 308147, 0, 1731641, CAST(N'2017-06-20 17:55:16.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5544, 1048, 1, N'1396/3/30', N'20:03:53:10', N'1396/3/30', N'20:12:43:06', 529, 1, 3061, CAST(N'2017-06-20 20:03:53.000' AS DateTime), CAST(N'2017-06-20 20:12:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5545, 1048, 1, N'1396/3/30', N'20:12:43:23', N'1396/3/30', N'20:12:44:93', 1, 0, 10, CAST(N'2017-06-20 20:12:43.000' AS DateTime), CAST(N'2017-06-20 20:12:44.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5546, 1048, 1, N'1396/3/30', N'20:12:45:17', N'1396/3/30', N'20:22:42:83', 597, 1, 3480, CAST(N'2017-06-20 20:12:45.000' AS DateTime), CAST(N'2017-06-20 20:22:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5547, 1048, 1, N'1396/3/30', N'20:22:42:99', N'1396/3/30', N'20:25:31:43', 169, 0, 983, CAST(N'2017-06-20 20:22:42.000' AS DateTime), CAST(N'2017-06-20 20:25:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5548, 1048, 1, N'1396/3/30', N'20:25:31:59', N'1396/3/30', N'20:34:22:59', 531, 1, 3061, CAST(N'2017-06-20 20:25:31.000' AS DateTime), CAST(N'2017-06-20 20:34:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5549, 1048, 1, N'1396/3/30', N'20:34:22:77', N'1396/3/30', N'20:34:32:20', 10, 0, 55, CAST(N'2017-06-20 20:34:22.000' AS DateTime), CAST(N'2017-06-20 20:34:32.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5550, 1048, 1, N'1396/3/30', N'20:34:32:39', N'1396/3/30', N'20:40:41:36', 369, 1, 2119, CAST(N'2017-06-20 20:34:32.000' AS DateTime), CAST(N'2017-06-20 20:40:41.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5551, 1048, 1, N'1396/3/30', N'20:40:41:56', N'1396/3/30', N'21:37:24:96', 3403, 0, 19724, CAST(N'2017-06-20 20:40:41.000' AS DateTime), CAST(N'2017-06-20 21:37:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5552, 1048, 1, N'1396/3/30', N'21:37:25:14', N'1396/3/30', N'22:41:38:75', 3853, 1, 22400, CAST(N'2017-06-20 21:37:25.000' AS DateTime), CAST(N'2017-06-20 22:41:38.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5553, 1048, 1, N'1396/3/30', N'22:41:38:93', N'1396/3/30', N'22:41:58:33', 20, 0, 117, CAST(N'2017-06-20 22:41:38.000' AS DateTime), CAST(N'2017-06-20 22:41:58.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5554, 1048, 1, N'1396/3/30', N'22:41:58:49', N'1396/3/30', N'22:49:52:37', 474, 1, 2792, CAST(N'2017-06-20 22:41:58.000' AS DateTime), CAST(N'2017-06-20 22:49:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5555, 1048, 1, N'1396/3/30', N'22:49:52:54', N'1396/3/30', N'22:50:13:83', 21, 0, 127, CAST(N'2017-06-20 22:49:52.000' AS DateTime), CAST(N'2017-06-20 22:50:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5556, 1048, 1, N'1396/3/30', N'22:50:13:99', N'1396/3/30', N'22:51:40:95', 87, 1, 502, CAST(N'2017-06-20 22:50:13.000' AS DateTime), CAST(N'2017-06-20 22:51:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5557, 1048, 1, N'1396/3/30', N'22:51:41:12', N'1396/3/30', N'23:26:05:96', 2064, 0, 10560, CAST(N'2017-06-20 22:51:41.000' AS DateTime), CAST(N'2017-06-20 23:26:05.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5558, 1048, 1, N'1396/3/30', N'23:26:06:16', N'1396/3/30', N'23:49:19:80', 1393, 1, 6611, CAST(N'2017-06-20 23:26:06.000' AS DateTime), CAST(N'2017-06-20 23:49:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5559, 1048, 1, N'1396/3/30', N'23:49:20:01', N'1396/3/31', N'08:17:53:70', 30513, 0, 174771, CAST(N'2017-06-20 23:49:20.000' AS DateTime), CAST(N'2017-06-21 08:17:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5560, 1048, 1, N'1396/3/31', N'08:17:53:92', N'1396/3/31', N'08:49:19:36', 1886, 1, 9120, CAST(N'2017-06-21 08:17:53.000' AS DateTime), CAST(N'2017-06-21 08:49:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5561, 1048, 1, N'1396/3/31', N'08:49:19:59', N'1396/3/31', N'08:52:49:38', 210, 0, 998, CAST(N'2017-06-21 08:49:19.000' AS DateTime), CAST(N'2017-06-21 08:52:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5562, 1048, 1, N'1396/3/31', N'08:52:49:84', N'1396/3/31', N'10:11:39:80', 4730, 1, 23835, CAST(N'2017-06-21 08:52:49.000' AS DateTime), CAST(N'2017-06-21 10:11:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5563, 1048, 1, N'1396/3/31', N'10:11:40:40', N'1396/3/31', N'10:20:05:95', 505, 0, 2652, CAST(N'2017-06-21 10:11:40.000' AS DateTime), CAST(N'2017-06-21 10:20:05.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5564, 1048, 1, N'1396/3/31', N'10:20:06:13', N'1396/3/31', N'10:56:01:57', 2155, 1, 10580, CAST(N'2017-06-21 10:20:06.000' AS DateTime), CAST(N'2017-06-21 10:56:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5565, 1048, 1, N'1396/3/31', N'10:56:01:77', N'1396/3/31', N'11:27:04:04', 1862, 0, 9062, CAST(N'2017-06-21 10:56:01.000' AS DateTime), CAST(N'2017-06-21 11:27:04.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5566, 1048, 1, N'1396/3/31', N'11:27:04:24', N'1396/3/31', N'12:18:50:32', 3106, 1, 15337, CAST(N'2017-06-21 11:27:04.000' AS DateTime), CAST(N'2017-06-21 12:18:50.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5567, 1048, 1, N'1396/3/31', N'12:18:50:59', N'1396/3/31', N'12:29:42:92', 652, 0, 3151, CAST(N'2017-06-21 12:18:50.000' AS DateTime), CAST(N'2017-06-21 12:29:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5568, 1048, 1, N'1396/3/31', N'12:29:43:18', N'1396/3/31', N'12:31:35:49', 112, 1, 560, CAST(N'2017-06-21 12:29:43.000' AS DateTime), CAST(N'2017-06-21 12:31:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5569, 1048, 1, N'1396/3/31', N'12:31:35:87', N'1396/3/31', N'13:28:39:10', 3423, 0, 17634, CAST(N'2017-06-21 12:31:35.000' AS DateTime), CAST(N'2017-06-21 13:28:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5570, 1048, 1, N'1396/3/31', N'13:28:39:29', N'1396/3/31', N'13:40:10:97', 691, 1, 3624, CAST(N'2017-06-21 13:28:39.000' AS DateTime), CAST(N'2017-06-21 13:40:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5571, 1048, 1, N'1396/3/31', N'13:40:11:16', N'1396/3/31', N'13:40:45:74', 34, 0, 179, CAST(N'2017-06-21 13:40:11.000' AS DateTime), CAST(N'2017-06-21 13:40:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5572, 1048, 1, N'1396/3/31', N'13:40:45:94', N'1396/3/31', N'13:48:04:61', 439, 1, 2215, CAST(N'2017-06-21 13:40:45.000' AS DateTime), CAST(N'2017-06-21 13:48:04.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5573, 1048, 1, N'1396/3/31', N'13:48:04:77', N'1396/3/31', N'13:52:42:35', 278, 0, 1414, CAST(N'2017-06-21 13:48:04.000' AS DateTime), CAST(N'2017-06-21 13:52:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5574, 1048, 1, N'1396/3/31', N'13:52:42:54', N'1396/3/31', N'14:12:26:61', 1184, 1, 5823, CAST(N'2017-06-21 13:52:42.000' AS DateTime), CAST(N'2017-06-21 14:12:26.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5575, 1048, 1, N'1396/3/31', N'14:12:26:82', N'1396/3/31', N'14:12:47:60', 21, 0, 110, CAST(N'2017-06-21 14:12:26.000' AS DateTime), CAST(N'2017-06-21 14:12:47.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5576, 1048, 1, N'1396/3/31', N'14:12:47:82', N'1396/3/31', N'14:34:49:20', 1322, 1, 6501, CAST(N'2017-06-21 14:12:47.000' AS DateTime), CAST(N'2017-06-21 14:34:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5577, 1048, 1, N'1396/3/31', N'14:34:49:38', N'1396/3/31', N'14:35:12:58', 23, 0, 125, CAST(N'2017-06-21 14:34:49.000' AS DateTime), CAST(N'2017-06-21 14:35:12.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5578, 1048, 1, N'1396/3/31', N'14:35:12:81', N'1396/3/31', N'14:36:56:19', 103, 1, 502, CAST(N'2017-06-21 14:35:12.000' AS DateTime), CAST(N'2017-06-21 14:36:56.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5579, 1048, 1, N'1396/3/31', N'14:36:56:39', N'1396/3/31', N'15:32:47:07', 3350, 0, 16245, CAST(N'2017-06-21 14:36:56.000' AS DateTime), CAST(N'2017-06-21 15:32:47.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5580, 1048, 1, N'1396/3/31', N'15:32:47:27', N'1396/3/31', N'15:57:01:75', 1454, 1, 7534, CAST(N'2017-06-21 15:32:47.000' AS DateTime), CAST(N'2017-06-21 15:57:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5581, 1048, 1, N'1396/3/31', N'15:57:01:94', N'1396/3/31', N'16:03:19:11', 377, 0, 2001, CAST(N'2017-06-21 15:57:01.000' AS DateTime), CAST(N'2017-06-21 16:03:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5582, 1048, 1, N'1396/3/31', N'16:03:19:31', N'1396/3/31', N'16:25:50:26', 1351, 1, 7022, CAST(N'2017-06-21 16:03:19.000' AS DateTime), CAST(N'2017-06-21 16:25:50.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5583, 1048, 1, N'1396/3/31', N'16:25:50:47', N'1396/3/31', N'16:29:53:95', 243, 0, 1275, CAST(N'2017-06-21 16:25:50.000' AS DateTime), CAST(N'2017-06-21 16:29:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5584, 1048, 1, N'1396/3/31', N'16:29:54:12', N'1396/3/31', N'16:55:37:61', 1543, 1, 7745, CAST(N'2017-06-21 16:29:54.000' AS DateTime), CAST(N'2017-06-21 16:55:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5585, 1048, 1, N'1396/3/31', N'16:55:37:80', N'1396/3/31', N'17:48:16:67', 3159, 0, 16493, CAST(N'2017-06-21 16:55:37.000' AS DateTime), CAST(N'2017-06-21 17:48:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5586, 1048, 1, N'1396/3/31', N'17:48:16:84', N'1396/3/31', N'17:57:02:02', 525, 1, 2923, CAST(N'2017-06-21 17:48:16.000' AS DateTime), CAST(N'2017-06-21 17:57:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5587, 1048, 1, N'1396/3/31', N'17:57:02:18', N'1396/3/31', N'18:16:02:40', 1140, 0, 6349, CAST(N'2017-06-21 17:57:02.000' AS DateTime), CAST(N'2017-06-21 18:16:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5588, 1048, 1, N'1396/3/31', N'18:16:02:56', N'1396/3/31', N'18:24:54:72', 532, 1, 2975, CAST(N'2017-06-21 18:16:02.000' AS DateTime), CAST(N'2017-06-21 18:24:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5589, 1048, 1, N'1396/3/31', N'18:24:55:18', N'1396/3/31', N'18:34:37:70', 582, 0, 3182, CAST(N'2017-06-21 18:24:55.000' AS DateTime), CAST(N'2017-06-21 18:34:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5590, 1048, 1, N'1396/3/31', N'18:34:37:89', N'1396/3/31', N'18:36:46:10', 128, 1, 745, CAST(N'2017-06-21 18:34:37.000' AS DateTime), CAST(N'2017-06-21 18:36:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5591, 1048, 1, N'1396/3/31', N'18:36:46:27', N'1396/3/31', N'18:41:10:35', 264, 0, 1486, CAST(N'2017-06-21 18:36:46.000' AS DateTime), CAST(N'2017-06-21 18:41:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5592, 1048, 1, N'1396/3/31', N'18:41:10:51', N'1396/3/31', N'18:41:21:09', 10, 1, 58, CAST(N'2017-06-21 18:41:10.000' AS DateTime), CAST(N'2017-06-21 18:41:21.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5593, 1048, 1, N'1396/3/31', N'18:41:21:34', N'1396/3/31', N'18:49:02:49', 461, 0, 2617, CAST(N'2017-06-21 18:41:21.000' AS DateTime), CAST(N'2017-06-21 18:49:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5594, 1048, 1, N'1396/3/31', N'18:49:02:65', N'1396/3/31', N'19:05:48:57', 1006, 1, 5725, CAST(N'2017-06-21 18:49:02.000' AS DateTime), CAST(N'2017-06-21 19:05:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5595, 1048, 1, N'1396/3/31', N'19:05:48:74', N'1396/3/31', N'19:27:36:92', 1308, 0, 7735, CAST(N'2017-06-21 19:05:48.000' AS DateTime), CAST(N'2017-06-21 19:27:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5596, 1048, 1, N'1396/3/31', N'19:27:37:08', N'1396/3/31', N'19:43:06:82', 929, 1, 5357, CAST(N'2017-06-21 19:27:37.000' AS DateTime), CAST(N'2017-06-21 19:43:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5597, 1048, 1, N'1396/3/31', N'19:43:07:05', N'1396/3/31', N'19:54:28:80', 681, 0, 3757, CAST(N'2017-06-21 19:43:07.000' AS DateTime), CAST(N'2017-06-21 19:54:28.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5598, 1048, 1, N'1396/3/31', N'19:54:28:98', N'1396/3/31', N'20:00:17:56', 349, 1, 2098, CAST(N'2017-06-21 19:54:28.000' AS DateTime), CAST(N'2017-06-21 20:00:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5599, 1048, 1, N'1396/3/31', N'20:00:17:72', N'1396/3/31', N'20:06:33:90', 376, 0, 2247, CAST(N'2017-06-21 20:00:17.000' AS DateTime), CAST(N'2017-06-21 20:06:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5600, 1048, 1, N'1396/3/31', N'20:06:34:04', N'1396/3/31', N'20:20:54:84', 860, 1, 5116, CAST(N'2017-06-21 20:06:34.000' AS DateTime), CAST(N'2017-06-21 20:20:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5601, 1048, 1, N'1396/3/31', N'20:20:55:02', N'1396/3/31', N'20:28:24:31', 449, 0, 2643, CAST(N'2017-06-21 20:20:55.000' AS DateTime), CAST(N'2017-06-21 20:28:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5602, 1048, 1, N'1396/3/31', N'20:28:24:47', N'1396/3/31', N'20:32:33:24', 249, 1, 1461, CAST(N'2017-06-21 20:28:24.000' AS DateTime), CAST(N'2017-06-21 20:32:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5603, 1048, 1, N'1396/3/31', N'20:32:33:41', N'1396/3/31', N'20:32:35:67', 2, 0, 15, CAST(N'2017-06-21 20:32:33.000' AS DateTime), CAST(N'2017-06-21 20:32:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5604, 1048, 1, N'1396/3/31', N'20:32:35:85', N'1396/3/31', N'20:41:27:73', 532, 1, 3171, CAST(N'2017-06-21 20:32:35.000' AS DateTime), CAST(N'2017-06-21 20:41:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5605, 1048, 1, N'1396/3/31', N'20:41:27:92', N'1396/3/31', N'20:56:53:95', 926, 0, 5485, CAST(N'2017-06-21 20:41:27.000' AS DateTime), CAST(N'2017-06-21 20:56:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5606, 1048, 1, N'1396/3/31', N'20:56:54:10', N'1396/3/31', N'21:06:02:44', 548, 1, 3235, CAST(N'2017-06-21 20:56:54.000' AS DateTime), CAST(N'2017-06-21 21:06:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5607, 1048, 1, N'1396/3/31', N'21:06:02:60', N'1396/3/31', N'21:30:57:36', 1495, 0, 8711, CAST(N'2017-06-21 21:06:02.000' AS DateTime), CAST(N'2017-06-21 21:30:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5608, 1048, 1, N'1396/3/31', N'21:30:57:53', N'1396/3/31', N'21:31:39:62', 42, 1, 251, CAST(N'2017-06-21 21:30:57.000' AS DateTime), CAST(N'2017-06-21 21:31:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5609, 1048, 1, N'1396/3/31', N'21:31:39:78', N'1396/3/31', N'21:50:32:13', 1132, 0, 6683, CAST(N'2017-06-21 21:31:39.000' AS DateTime), CAST(N'2017-06-21 21:50:32.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5610, 1048, 1, N'1396/3/31', N'21:50:32:29', N'1396/3/31', N'21:54:20:74', 228, 1, 1334, CAST(N'2017-06-21 21:50:32.000' AS DateTime), CAST(N'2017-06-21 21:54:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5611, 1048, 1, N'1396/3/31', N'21:54:20:92', N'1396/3/31', N'21:55:07:68', 47, 0, 286, CAST(N'2017-06-21 21:54:20.000' AS DateTime), CAST(N'2017-06-21 21:55:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5612, 1048, 1, N'1396/3/31', N'21:55:07:83', N'1396/3/31', N'22:13:54:31', 1127, 1, 6657, CAST(N'2017-06-21 21:55:07.000' AS DateTime), CAST(N'2017-06-21 22:13:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5613, 1048, 1, N'1396/3/31', N'22:13:54:51', N'1396/3/31', N'22:25:28:88', 694, 0, 4104, CAST(N'2017-06-21 22:13:54.000' AS DateTime), CAST(N'2017-06-21 22:25:28.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5614, 1048, 1, N'1396/3/31', N'22:25:29:04', N'1396/3/31', N'22:45:09:13', 1179, 1, 7002, CAST(N'2017-06-21 22:25:29.000' AS DateTime), CAST(N'2017-06-21 22:45:09.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5615, 1048, 1, N'1396/3/31', N'22:45:09:32', N'1396/3/31', N'23:56:33:95', 4284, 0, 21514, CAST(N'2017-06-21 22:45:09.000' AS DateTime), CAST(N'2017-06-21 23:56:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5616, 1048, 1, N'1396/3/31', N'23:56:34:14', N'1396/4/1', N'00:12:48:47', 974, 1, 4706, CAST(N'2017-06-21 23:56:34.000' AS DateTime), CAST(N'2017-06-22 00:12:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5617, 1048, 1, N'1396/4/1', N'00:12:48:67', N'1396/4/1', N'00:12:58:65', 10, 0, 49, CAST(N'2017-06-22 00:12:48.000' AS DateTime), CAST(N'2017-06-22 00:12:58.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5618, 1048, 1, N'1396/4/1', N'00:12:58:89', N'1396/4/1', N'00:30:02:49', 1024, 1, 4963, CAST(N'2017-06-22 00:12:58.000' AS DateTime), CAST(N'2017-06-22 00:30:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5619, 1048, 1, N'1396/4/1', N'00:30:02:70', N'1396/4/1', N'00:37:49:95', 467, 0, 2296, CAST(N'2017-06-22 00:30:02.000' AS DateTime), CAST(N'2017-06-22 00:37:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5620, 1048, 1, N'1396/4/1', N'00:37:50:13', N'1396/4/1', N'00:38:20:79', 30, 1, 151, CAST(N'2017-06-22 00:37:50.000' AS DateTime), CAST(N'2017-06-22 00:38:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5621, 1048, 1, N'1396/4/1', N'00:38:21:04', N'1396/4/1', N'00:38:58:03', 36, 0, 185, CAST(N'2017-06-22 00:38:21.000' AS DateTime), CAST(N'2017-06-22 00:38:58.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5622, 1048, 1, N'1396/4/1', N'00:38:58:24', N'1396/4/1', N'00:39:14:20', 16, 1, 76, CAST(N'2017-06-22 00:38:58.000' AS DateTime), CAST(N'2017-06-22 00:39:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5623, 1048, 1, N'1396/4/1', N'00:39:14:41', N'1396/4/1', N'00:39:58:96', 44, 0, 210, CAST(N'2017-06-22 00:39:14.000' AS DateTime), CAST(N'2017-06-22 00:39:58.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5624, 1048, 1, N'1396/4/1', N'00:39:59:16', N'1396/4/1', N'00:40:35:34', 36, 1, 179, CAST(N'2017-06-22 00:39:59.000' AS DateTime), CAST(N'2017-06-22 00:40:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5625, 1048, 1, N'1396/4/1', N'00:40:35:54', N'1396/4/1', N'00:42:49:64', 134, 0, 642, CAST(N'2017-06-22 00:40:35.000' AS DateTime), CAST(N'2017-06-22 00:42:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5626, 1048, 1, N'1396/4/1', N'00:42:49:84', N'1396/4/1', N'00:47:52:12', 302, 1, 1780, CAST(N'2017-06-22 00:42:49.000' AS DateTime), CAST(N'2017-06-22 00:47:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5627, 1048, 1, N'1396/4/1', N'00:47:52:29', N'1396/4/1', N'00:47:59:86', 7, 0, 42, CAST(N'2017-06-22 00:47:52.000' AS DateTime), CAST(N'2017-06-22 00:47:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5628, 1048, 1, N'1396/4/1', N'00:48:00:03', N'1396/4/1', N'00:48:06:91', 6, 1, 34, CAST(N'2017-06-22 00:48:00.000' AS DateTime), CAST(N'2017-06-22 00:48:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5629, 1048, 1, N'1396/4/1', N'00:48:07:07', N'1396/4/1', N'00:48:46:96', 39, 0, 225, CAST(N'2017-06-22 00:48:07.000' AS DateTime), CAST(N'2017-06-22 00:48:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5630, 1048, 1, N'1396/4/1', N'00:48:47:11', N'1396/4/1', N'00:53:51:16', 304, 1, 1726, CAST(N'2017-06-22 00:48:47.000' AS DateTime), CAST(N'2017-06-22 00:53:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5631, 1048, 1, N'1396/4/1', N'00:53:51:33', N'1396/4/1', N'00:53:57:68', 6, 0, 39, CAST(N'2017-06-22 00:53:51.000' AS DateTime), CAST(N'2017-06-22 00:53:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5632, 1048, 1, N'1396/4/1', N'00:53:57:83', N'1396/4/1', N'00:58:44:72', 287, 1, 1736, CAST(N'2017-06-22 00:53:57.000' AS DateTime), CAST(N'2017-06-22 00:58:44.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5633, 1048, 1, N'1396/4/1', N'00:58:44:90', N'1396/4/1', N'00:58:51:46', 7, 0, 41, CAST(N'2017-06-22 00:58:44.000' AS DateTime), CAST(N'2017-06-22 00:58:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5634, 1048, 1, N'1396/4/1', N'00:58:51:61', N'1396/4/1', N'01:05:05:56', 374, 1, 1720, CAST(N'2017-06-22 00:58:51.000' AS DateTime), CAST(N'2017-06-22 01:05:05.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5635, 1048, 1, N'1396/4/1', N'01:05:05:72', N'1396/4/1', N'01:05:11:71', 6, 0, 36, CAST(N'2017-06-22 01:05:05.000' AS DateTime), CAST(N'2017-06-22 01:05:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5636, 1048, 1, N'1396/4/1', N'01:05:11:91', N'1396/4/1', N'01:05:14:95', 3, 1, 19, CAST(N'2017-06-22 01:05:11.000' AS DateTime), CAST(N'2017-06-22 01:05:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5637, 1048, 1, N'1396/4/1', N'01:05:15:11', N'1396/4/1', N'01:06:32:90', 77, 0, 465, CAST(N'2017-06-22 01:05:15.000' AS DateTime), CAST(N'2017-06-22 01:06:32.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5638, 1048, 1, N'1396/4/1', N'01:06:33:17', N'1396/4/1', N'01:11:09:56', 276, 1, 1636, CAST(N'2017-06-22 01:06:33.000' AS DateTime), CAST(N'2017-06-22 01:11:09.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5639, 1048, 1, N'1396/4/1', N'01:11:09:74', N'1396/4/1', N'01:11:15:39', 6, 0, 35, CAST(N'2017-06-22 01:11:09.000' AS DateTime), CAST(N'2017-06-22 01:11:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5640, 1048, 1, N'1396/4/1', N'01:11:15:55', N'1396/4/1', N'01:15:28:00', 252, 1, 1522, CAST(N'2017-06-22 01:11:15.000' AS DateTime), CAST(N'2017-06-22 01:15:28.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5641, 1048, 1, N'1396/4/1', N'01:15:28:17', N'1396/4/1', N'01:15:34:79', 6, 0, 40, CAST(N'2017-06-22 01:15:28.000' AS DateTime), CAST(N'2017-06-22 01:15:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5642, 1048, 1, N'1396/4/1', N'01:15:34:96', N'1396/4/1', N'01:19:55:91', 261, 1, 1538, CAST(N'2017-06-22 01:15:34.000' AS DateTime), CAST(N'2017-06-22 01:19:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5643, 1048, 1, N'1396/4/1', N'01:19:56:12', N'1396/4/1', N'01:20:02:11', 5, 0, 36, CAST(N'2017-06-22 01:19:56.000' AS DateTime), CAST(N'2017-06-22 01:20:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5644, 1048, 1, N'1396/4/1', N'01:20:02:30', N'1396/4/1', N'01:24:20:23', 258, 1, 1522, CAST(N'2017-06-22 01:20:02.000' AS DateTime), CAST(N'2017-06-22 01:24:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5645, 1048, 1, N'1396/4/1', N'01:24:20:38', N'1396/4/1', N'01:24:27:20', 7, 0, 40, CAST(N'2017-06-22 01:24:20.000' AS DateTime), CAST(N'2017-06-22 01:24:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5646, 1048, 1, N'1396/4/1', N'01:24:27:35', N'1396/4/1', N'01:24:29:68', 2, 1, 15, CAST(N'2017-06-22 01:24:27.000' AS DateTime), CAST(N'2017-06-22 01:24:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5647, 1048, 1, N'1396/4/1', N'01:24:29:84', N'1396/4/1', N'01:26:16:06', 106, 0, 631, CAST(N'2017-06-22 01:24:29.000' AS DateTime), CAST(N'2017-06-22 01:26:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5648, 1048, 1, N'1396/4/1', N'01:26:16:24', N'1396/4/1', N'01:26:52:89', 36, 1, 220, CAST(N'2017-06-22 01:26:16.000' AS DateTime), CAST(N'2017-06-22 01:26:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5649, 1048, 1, N'1396/4/1', N'01:26:53:04', N'1396/4/1', N'01:26:58:69', 5, 0, 35, CAST(N'2017-06-22 01:26:53.000' AS DateTime), CAST(N'2017-06-22 01:26:58.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5650, 1048, 1, N'1396/4/1', N'01:26:58:91', N'1396/4/1', N'01:27:02:68', 4, 1, 23, CAST(N'2017-06-22 01:26:58.000' AS DateTime), CAST(N'2017-06-22 01:27:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5651, 1048, 1, N'1396/4/1', N'01:27:02:87', N'1396/4/1', N'01:28:16:24', 74, 0, 431, CAST(N'2017-06-22 01:27:02.000' AS DateTime), CAST(N'2017-06-22 01:28:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5652, 1048, 1, N'1396/4/1', N'01:28:16:41', N'1396/4/1', N'01:32:30:97', 254, 1, 1512, CAST(N'2017-06-22 01:28:16.000' AS DateTime), CAST(N'2017-06-22 01:32:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5653, 1048, 1, N'1396/4/1', N'01:32:31:13', N'1396/4/1', N'01:32:37:32', 6, 0, 37, CAST(N'2017-06-22 01:32:31.000' AS DateTime), CAST(N'2017-06-22 01:32:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5654, 1048, 1, N'1396/4/1', N'01:32:37:51', N'1396/4/1', N'01:32:41:06', 3, 1, 22, CAST(N'2017-06-22 01:32:37.000' AS DateTime), CAST(N'2017-06-22 01:32:41.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5655, 1048, 1, N'1396/4/1', N'01:32:41:20', N'1396/4/1', N'01:33:01:56', 20, 0, 116, CAST(N'2017-06-22 01:32:41.000' AS DateTime), CAST(N'2017-06-22 01:33:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5656, 1048, 1, N'1396/4/1', N'01:33:01:72', N'1396/4/1', N'01:37:00:62', 239, 1, 1431, CAST(N'2017-06-22 01:33:01.000' AS DateTime), CAST(N'2017-06-22 01:37:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5657, 1048, 1, N'1396/4/1', N'01:37:00:79', N'1396/4/1', N'01:37:07:40', 7, 0, 40, CAST(N'2017-06-22 01:37:00.000' AS DateTime), CAST(N'2017-06-22 01:37:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5658, 1048, 1, N'1396/4/1', N'01:37:07:57', N'1396/4/1', N'01:41:12:88', 245, 1, 1451, CAST(N'2017-06-22 01:37:07.000' AS DateTime), CAST(N'2017-06-22 01:41:12.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5659, 1048, 1, N'1396/4/1', N'01:41:13:07', N'1396/4/1', N'01:41:18:66', 5, 0, 34, CAST(N'2017-06-22 01:41:13.000' AS DateTime), CAST(N'2017-06-22 01:41:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5660, 1048, 1, N'1396/4/1', N'01:41:18:80', N'1396/4/1', N'01:45:22:28', 244, 1, 1434, CAST(N'2017-06-22 01:41:18.000' AS DateTime), CAST(N'2017-06-22 01:45:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5661, 1048, 1, N'1396/4/1', N'01:45:22:45', N'1396/4/1', N'01:45:28:80', 6, 0, 38, CAST(N'2017-06-22 01:45:22.000' AS DateTime), CAST(N'2017-06-22 01:45:28.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5662, 1048, 1, N'1396/4/1', N'01:45:28:96', N'1396/4/1', N'01:45:31:39', 3, 1, 15, CAST(N'2017-06-22 01:45:28.000' AS DateTime), CAST(N'2017-06-22 01:45:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5663, 1048, 1, N'1396/4/1', N'01:45:31:58', N'1396/4/1', N'10:32:07:21', 31596, 0, 178542, CAST(N'2017-06-22 01:45:31.000' AS DateTime), CAST(N'2017-06-22 10:32:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5664, 1048, 1, N'1396/4/1', N'10:32:07:38', N'1396/4/1', N'10:36:43:08', 275, 1, 1457, CAST(N'2017-06-22 10:32:07.000' AS DateTime), CAST(N'2017-06-22 10:36:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5665, 1048, 1, N'1396/4/1', N'10:36:43:25', N'1396/4/1', N'11:01:25:95', 1482, 0, 7467, CAST(N'2017-06-22 10:36:43.000' AS DateTime), CAST(N'2017-06-22 11:01:25.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5666, 1048, 1, N'1396/4/1', N'11:01:26:21', N'1396/4/1', N'11:01:31:60', 5, 1, 26, CAST(N'2017-06-22 11:01:26.000' AS DateTime), CAST(N'2017-06-22 11:01:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5667, 1048, 1, N'1396/4/1', N'11:01:31:80', N'1396/4/1', N'11:01:35:20', 4, 0, 18, CAST(N'2017-06-22 11:01:31.000' AS DateTime), CAST(N'2017-06-22 11:01:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5668, 1048, 1, N'1396/4/1', N'11:01:35:39', N'1396/4/1', N'11:01:40:27', 5, 1, 24, CAST(N'2017-06-22 11:01:35.000' AS DateTime), CAST(N'2017-06-22 11:01:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5669, 1048, 1, N'1396/4/1', N'11:01:40:47', N'1396/4/1', N'11:02:26:49', 46, 0, 223, CAST(N'2017-06-22 11:01:40.000' AS DateTime), CAST(N'2017-06-22 11:02:26.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5670, 1048, 1, N'1396/4/1', N'11:02:26:70', N'1396/4/1', N'11:02:31:38', 5, 1, 26, CAST(N'2017-06-22 11:02:26.000' AS DateTime), CAST(N'2017-06-22 11:02:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5671, 1048, 1, N'1396/4/1', N'11:02:31:58', N'1396/4/1', N'11:02:34:79', 3, 0, 18, CAST(N'2017-06-22 11:02:31.000' AS DateTime), CAST(N'2017-06-22 11:02:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5672, 1048, 1, N'1396/4/1', N'11:02:34:95', N'1396/4/1', N'11:02:49:85', 15, 1, 78, CAST(N'2017-06-22 11:02:34.000' AS DateTime), CAST(N'2017-06-22 11:02:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5673, 1048, 1, N'1396/4/1', N'11:02:50:08', N'1396/4/1', N'11:05:20:68', 150, 0, 741, CAST(N'2017-06-22 11:02:50.000' AS DateTime), CAST(N'2017-06-22 11:05:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5674, 1048, 1, N'1396/4/1', N'11:05:20:87', N'1396/4/1', N'11:05:24:88', 4, 1, 19, CAST(N'2017-06-22 11:05:20.000' AS DateTime), CAST(N'2017-06-22 11:05:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5675, 1048, 1, N'1396/4/1', N'11:05:25:10', N'1396/4/1', N'11:05:48:89', 23, 0, 119, CAST(N'2017-06-22 11:05:25.000' AS DateTime), CAST(N'2017-06-22 11:05:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5676, 1048, 1, N'1396/4/1', N'11:05:49:11', N'1396/4/1', N'11:05:53:68', 4, 1, 22, CAST(N'2017-06-22 11:05:49.000' AS DateTime), CAST(N'2017-06-22 11:05:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5677, 1048, 1, N'1396/4/1', N'11:05:53:88', N'1396/4/1', N'11:05:57:53', 4, 0, 18, CAST(N'2017-06-22 11:05:53.000' AS DateTime), CAST(N'2017-06-22 11:05:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5678, 1048, 1, N'1396/4/1', N'11:05:57:72', N'1396/4/1', N'11:06:02:37', 4, 1, 17, CAST(N'2017-06-22 11:05:57.000' AS DateTime), CAST(N'2017-06-22 11:06:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5679, 1048, 1, N'1396/4/1', N'11:06:02:99', N'1396/4/1', N'11:15:17:83', 555, 0, 2651, CAST(N'2017-06-22 11:06:02.000' AS DateTime), CAST(N'2017-06-22 11:15:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5680, 1048, 1, N'1396/4/1', N'11:15:18:01', N'1396/4/1', N'11:42:27:07', 1628, 1, 8193, CAST(N'2017-06-22 11:15:18.000' AS DateTime), CAST(N'2017-06-22 11:42:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5681, 1048, 1, N'1396/4/1', N'11:42:27:22', N'1396/4/1', N'11:42:51:58', 24, 0, 135, CAST(N'2017-06-22 11:42:27.000' AS DateTime), CAST(N'2017-06-22 11:42:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5682, 1048, 1, N'1396/4/1', N'11:42:51:76', N'1396/4/1', N'11:58:54:81', 963, 1, 4781, CAST(N'2017-06-22 11:42:51.000' AS DateTime), CAST(N'2017-06-22 11:58:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5683, 1048, 1, N'1396/4/1', N'11:58:55:12', N'1396/4/1', N'12:12:42:50', 827, 0, 4045, CAST(N'2017-06-22 11:58:55.000' AS DateTime), CAST(N'2017-06-22 12:12:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5684, 1048, 1, N'1396/4/1', N'12:12:42:66', N'1396/4/1', N'13:12:45:01', 3602, 1, 18361, CAST(N'2017-06-22 12:12:42.000' AS DateTime), CAST(N'2017-06-22 13:12:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5685, 1048, 1, N'1396/4/1', N'13:12:45:24', N'1396/4/1', N'13:22:24:13', 578, 0, 3032, CAST(N'2017-06-22 13:12:45.000' AS DateTime), CAST(N'2017-06-22 13:22:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5686, 1048, 1, N'1396/4/1', N'13:22:24:32', N'1396/4/1', N'13:22:25:39', 1, 1, 6, CAST(N'2017-06-22 13:22:24.000' AS DateTime), CAST(N'2017-06-22 13:22:25.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5687, 1048, 1, N'1396/4/1', N'13:22:25:59', N'1396/4/1', N'13:23:39:13', 73, 0, 398, CAST(N'2017-06-22 13:22:25.000' AS DateTime), CAST(N'2017-06-22 13:23:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5688, 1048, 1, N'1396/4/1', N'13:23:39:31', N'1396/4/1', N'13:23:40:44', 1, 1, 7, CAST(N'2017-06-22 13:23:39.000' AS DateTime), CAST(N'2017-06-22 13:23:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5689, 1048, 1, N'1396/4/1', N'13:23:40:63', N'1396/4/1', N'14:06:47:45', 2587, 0, 13383, CAST(N'2017-06-22 13:23:40.000' AS DateTime), CAST(N'2017-06-22 14:06:47.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5690, 1048, 1, N'1396/4/1', N'14:06:47:70', N'1396/4/1', N'15:06:15:98', 3568, 1, 17976, CAST(N'2017-06-22 14:06:47.000' AS DateTime), CAST(N'2017-06-22 15:06:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5691, 1048, 1, N'1396/4/1', N'15:06:16:16', N'1396/4/1', N'15:08:36:16', 139, 0, 689, CAST(N'2017-06-22 15:06:16.000' AS DateTime), CAST(N'2017-06-22 15:08:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5692, 1048, 1, N'1396/4/1', N'15:08:36:33', N'1396/4/1', N'15:08:40:29', 4, 1, 25, CAST(N'2017-06-22 15:08:36.000' AS DateTime), CAST(N'2017-06-22 15:08:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5693, 1048, 1, N'1396/4/1', N'15:08:40:53', N'1396/4/1', N'15:08:43:89', 3, 0, 18, CAST(N'2017-06-22 15:08:40.000' AS DateTime), CAST(N'2017-06-22 15:08:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5694, 1048, 1, N'1396/4/1', N'15:08:44:07', N'1396/4/1', N'15:08:56:85', 12, 1, 69, CAST(N'2017-06-22 15:08:44.000' AS DateTime), CAST(N'2017-06-22 15:08:56.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5695, 1048, 1, N'1396/4/1', N'15:08:57:04', N'1396/4/1', N'15:27:07:27', 1090, 0, 5747, CAST(N'2017-06-22 15:08:57.000' AS DateTime), CAST(N'2017-06-22 15:27:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5696, 1048, 1, N'1396/4/1', N'15:27:07:56', N'1396/4/1', N'15:28:17:93', 70, 1, 380, CAST(N'2017-06-22 15:27:07.000' AS DateTime), CAST(N'2017-06-22 15:28:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5697, 1048, 1, N'1396/4/1', N'15:28:18:08', N'1396/4/1', N'15:28:36:93', 18, 0, 107, CAST(N'2017-06-22 15:28:18.000' AS DateTime), CAST(N'2017-06-22 15:28:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5698, 1048, 1, N'1396/4/1', N'15:28:37:13', N'1396/4/1', N'15:29:45:71', 68, 1, 389, CAST(N'2017-06-22 15:28:37.000' AS DateTime), CAST(N'2017-06-22 15:29:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5699, 1048, 1, N'1396/4/1', N'15:29:45:89', N'1396/4/1', N'15:30:18:31', 33, 0, 173, CAST(N'2017-06-22 15:29:45.000' AS DateTime), CAST(N'2017-06-22 15:30:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5700, 1048, 1, N'1396/4/1', N'15:30:18:49', N'1396/4/1', N'15:36:30:69', 372, 1, 1977, CAST(N'2017-06-22 15:30:18.000' AS DateTime), CAST(N'2017-06-22 15:36:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5701, 1048, 1, N'1396/4/1', N'15:36:30:88', N'1396/4/1', N'15:37:41:12', 70, 0, 370, CAST(N'2017-06-22 15:36:30.000' AS DateTime), CAST(N'2017-06-22 15:37:41.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5702, 1048, 1, N'1396/4/1', N'15:37:41:30', N'1396/4/1', N'15:45:36:11', 474, 1, 2554, CAST(N'2017-06-22 15:37:41.000' AS DateTime), CAST(N'2017-06-22 15:45:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5703, 1048, 1, N'1396/4/1', N'15:45:36:35', N'1396/4/1', N'15:59:08:42', 812, 0, 4491, CAST(N'2017-06-22 15:45:36.000' AS DateTime), CAST(N'2017-06-22 15:59:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5704, 1048, 1, N'1396/4/1', N'15:59:08:61', N'1396/4/1', N'16:12:11:09', 782, 1, 4398, CAST(N'2017-06-22 15:59:08.000' AS DateTime), CAST(N'2017-06-22 16:12:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5705, 1048, 1, N'1396/4/1', N'16:12:11:28', N'1396/4/1', N'16:20:11:42', 480, 0, 2713, CAST(N'2017-06-22 16:12:11.000' AS DateTime), CAST(N'2017-06-22 16:20:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5706, 1048, 1, N'1396/4/1', N'16:20:11:73', N'1396/4/1', N'16:34:33:94', 862, 1, 4971, CAST(N'2017-06-22 16:20:11.000' AS DateTime), CAST(N'2017-06-22 16:34:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5707, 1048, 1, N'1396/4/1', N'16:34:34:05', N'1396/4/1', N'17:03:40:83', 1746, 0, 9850, CAST(N'2017-06-22 16:34:34.000' AS DateTime), CAST(N'2017-06-22 17:03:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5708, 1048, 1, N'1396/4/1', N'17:03:40:94', N'1396/4/1', N'17:10:58:81', 438, 1, 2591, CAST(N'2017-06-22 17:03:40.000' AS DateTime), CAST(N'2017-06-22 17:10:58.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5709, 1048, 1, N'1396/4/1', N'17:10:58:94', N'1396/4/1', N'17:14:31:99', 213, 0, 1257, CAST(N'2017-06-22 17:10:58.000' AS DateTime), CAST(N'2017-06-22 17:14:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5710, 1048, 1, N'1396/4/1', N'17:14:32:16', N'1396/4/1', N'17:34:31:56', 1199, 1, 6977, CAST(N'2017-06-22 17:14:32.000' AS DateTime), CAST(N'2017-06-22 17:34:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5711, 1048, 1, N'1396/4/1', N'17:34:31:74', N'1396/4/1', N'17:36:24:40', 113, 0, 672, CAST(N'2017-06-22 17:34:31.000' AS DateTime), CAST(N'2017-06-22 17:36:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5712, 1048, 1, N'1396/4/1', N'17:36:24:54', N'1396/4/1', N'17:56:20:95', 1196, 1, 7119, CAST(N'2017-06-22 17:36:24.000' AS DateTime), CAST(N'2017-06-22 17:56:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5713, 1048, 1, N'1396/4/1', N'17:56:21:12', N'1396/4/1', N'18:13:01:22', 1000, 0, 6260, CAST(N'2017-06-22 17:56:21.000' AS DateTime), CAST(N'2017-06-22 18:13:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5714, 1048, 1, N'1396/4/1', N'18:13:01:33', N'1396/4/1', N'18:13:02:69', 1, 1, 12, CAST(N'2017-06-22 18:13:01.000' AS DateTime), CAST(N'2017-06-22 18:13:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5715, 1048, 1, N'1396/4/1', N'18:13:02:86', N'1396/4/1', N'18:13:05:33', 3, 0, 18, CAST(N'2017-06-22 18:13:02.000' AS DateTime), CAST(N'2017-06-22 18:13:05.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5716, 1048, 1, N'1396/4/1', N'18:13:05:48', N'1396/4/1', N'18:13:08:80', 3, 1, 23, CAST(N'2017-06-22 18:13:05.000' AS DateTime), CAST(N'2017-06-22 18:13:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5717, 1048, 1, N'1396/4/1', N'18:13:08:91', N'1396/4/1', N'18:14:36:52', 88, 0, 628, CAST(N'2017-06-22 18:13:08.000' AS DateTime), CAST(N'2017-06-22 18:14:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5718, 1048, 1, N'1396/4/1', N'18:14:36:66', N'1396/4/1', N'18:14:39:78', 3, 1, 23, CAST(N'2017-06-22 18:14:36.000' AS DateTime), CAST(N'2017-06-22 18:14:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5719, 1048, 1, N'1396/4/1', N'18:14:39:91', N'1396/4/1', N'18:14:41:89', 2, 0, 18, CAST(N'2017-06-22 18:14:39.000' AS DateTime), CAST(N'2017-06-22 18:14:41.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5720, 1048, 1, N'1396/4/1', N'18:14:42:01', N'1396/4/1', N'18:14:43:84', 1, 1, 16, CAST(N'2017-06-22 18:14:42.000' AS DateTime), CAST(N'2017-06-22 18:14:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5721, 1048, 1, N'1396/4/1', N'18:14:43:98', N'1396/4/1', N'18:19:22:91', 279, 0, 1707, CAST(N'2017-06-22 18:14:43.000' AS DateTime), CAST(N'2017-06-22 18:19:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5722, 1048, 1, N'1396/4/1', N'18:19:23:08', N'1396/4/1', N'18:37:47:37', 1104, 1, 6548, CAST(N'2017-06-22 18:19:23.000' AS DateTime), CAST(N'2017-06-22 18:37:47.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5723, 1048, 1, N'1396/4/1', N'18:37:47:53', N'1396/4/1', N'19:22:51:00', 2703, 0, 15869, CAST(N'2017-06-22 18:37:47.000' AS DateTime), CAST(N'2017-06-22 19:22:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5724, 1048, 1, N'1396/4/1', N'19:22:51:30', N'1396/4/1', N'19:23:44:02', 52, 1, 321, CAST(N'2017-06-22 19:22:51.000' AS DateTime), CAST(N'2017-06-22 19:23:44.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5725, 1048, 1, N'1396/4/1', N'19:23:44:26', N'1396/4/3', N'07:31:03:29', 130039, 0, 755166, CAST(N'2017-06-22 19:23:44.000' AS DateTime), CAST(N'2017-06-24 07:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5726, 1048, 1, N'1396/4/3', N'17:49:16:77', N'1396/4/3', N'17:54:02:53', 286, 1, 1525, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-24 17:54:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5727, 1048, 2, N'1396/4/3', N'17:49:16:84', N'1396/4/4', N'18:15:52:85', 87996, 0, 499314, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5728, 1048, 3, N'1396/4/3', N'17:49:16:84', N'1396/4/4', N'18:15:52:85', 87996, 0, 499314, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5729, 1048, 4, N'1396/4/3', N'17:49:16:85', N'1396/4/4', N'18:15:52:87', 87996, 0, 499314, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5730, 1048, 5, N'1396/4/3', N'17:49:16:85', N'1396/4/4', N'18:15:52:87', 87996, 0, 499314, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5731, 1048, 6, N'1396/4/3', N'17:49:16:85', N'1396/4/4', N'18:15:52:88', 87996, 0, 499314, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5732, 1048, 7, N'1396/4/3', N'17:49:16:85', N'1396/4/4', N'18:15:52:88', 87996, 0, 499314, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5733, 1048, 8, N'1396/4/3', N'17:49:16:86', N'1396/4/4', N'18:15:52:90', 87996, 0, 499314, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5734, 1048, 17, N'1396/4/3', N'17:49:16:87', N'1396/4/4', N'18:15:52:90', 87996, 0, 499310, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5735, 1048, 18, N'1396/4/3', N'17:49:16:88', N'1396/4/4', N'18:15:52:92', 87996, 0, 499310, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5736, 1048, 19, N'1396/4/3', N'17:49:16:88', N'1396/4/4', N'18:15:52:92', 87996, 0, 499310, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5737, 1048, 20, N'1396/4/3', N'17:49:16:88', N'1396/4/4', N'18:15:52:93', 87996, 0, 499310, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5738, 1048, 21, N'1396/4/3', N'17:49:16:88', N'1396/4/4', N'18:15:52:93', 87996, 0, 499310, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5739, 1048, 22, N'1396/4/3', N'17:49:16:89', N'1396/4/4', N'18:15:52:95', 87996, 0, 499310, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5740, 1048, 23, N'1396/4/3', N'17:49:16:89', N'1396/4/4', N'18:15:52:95', 87996, 0, 499310, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5741, 1048, 24, N'1396/4/3', N'17:49:16:89', N'1396/4/4', N'18:15:52:96', 87996, 0, 499310, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5742, 1048, 9, N'1396/4/3', N'17:49:16:89', N'1396/4/4', N'18:15:52:98', 87996, 0, 499306, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5743, 1048, 10, N'1396/4/3', N'17:49:16:89', N'1396/4/4', N'18:15:52:98', 87996, 0, 499306, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5744, 1048, 11, N'1396/4/3', N'17:49:16:90', N'1396/4/4', N'18:15:52:81', 87996, 0, 499305, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5745, 1048, 12, N'1396/4/3', N'17:49:16:90', N'1396/4/4', N'18:15:52:81', 87996, 0, 499305, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5746, 1048, 13, N'1396/4/3', N'17:49:16:90', N'1396/4/4', N'18:15:52:81', 87996, 0, 499305, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5747, 1048, 14, N'1396/4/3', N'17:49:16:90', N'1396/4/4', N'18:15:52:82', 87996, 0, 499305, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5748, 1048, 15, N'1396/4/3', N'17:49:16:91', N'1396/4/4', N'18:15:52:84', 87996, 0, 499305, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5749, 1048, 16, N'1396/4/3', N'17:49:16:91', N'1396/4/4', N'18:15:52:84', 87996, 0, 499305, CAST(N'2017-06-24 17:49:16.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5750, 1048, 1, N'1396/4/3', N'17:54:02:76', N'1396/4/3', N'17:57:42:54', 220, 0, 1237, CAST(N'2017-06-24 17:54:02.000' AS DateTime), CAST(N'2017-06-24 17:57:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5751, 1048, 1, N'1396/4/3', N'17:57:42:73', N'1396/4/3', N'18:00:55:08', 192, 1, 1086, CAST(N'2017-06-24 17:57:42.000' AS DateTime), CAST(N'2017-06-24 18:00:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5752, 1048, 1, N'1396/4/3', N'18:00:55:27', N'1396/4/3', N'18:02:33:52', 98, 0, 567, CAST(N'2017-06-24 18:00:55.000' AS DateTime), CAST(N'2017-06-24 18:02:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5753, 1048, 1, N'1396/4/3', N'18:02:33:70', N'1396/4/3', N'18:21:00:37', 1107, 1, 6271, CAST(N'2017-06-24 18:02:33.000' AS DateTime), CAST(N'2017-06-24 18:21:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5754, 1048, 1, N'1396/4/3', N'18:21:00:56', N'1396/4/3', N'18:22:07:57', 67, 0, 398, CAST(N'2017-06-24 18:21:00.000' AS DateTime), CAST(N'2017-06-24 18:22:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5755, 1048, 1, N'1396/4/3', N'18:22:07:74', N'1396/4/3', N'18:34:34:23', 747, 1, 4367, CAST(N'2017-06-24 18:22:07.000' AS DateTime), CAST(N'2017-06-24 18:34:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5756, 1048, 1, N'1396/4/3', N'18:34:34:40', N'1396/4/3', N'18:34:51:37', 17, 0, 95, CAST(N'2017-06-24 18:34:34.000' AS DateTime), CAST(N'2017-06-24 18:34:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5757, 1048, 1, N'1396/4/3', N'18:34:51:52', N'1396/4/3', N'18:47:32:59', 761, 1, 4367, CAST(N'2017-06-24 18:34:51.000' AS DateTime), CAST(N'2017-06-24 18:47:32.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5758, 1048, 1, N'1396/4/3', N'18:47:32:80', N'1396/4/3', N'18:51:04:07', 211, 0, 1240, CAST(N'2017-06-24 18:47:32.000' AS DateTime), CAST(N'2017-06-24 18:51:04.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5759, 1048, 1, N'1396/4/3', N'18:51:04:25', N'1396/4/3', N'18:52:45:91', 101, 1, 605, CAST(N'2017-06-24 18:51:04.000' AS DateTime), CAST(N'2017-06-24 18:52:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5760, 1048, 1, N'1396/4/3', N'18:52:46:12', N'1396/4/3', N'18:54:04:94', 78, 0, 474, CAST(N'2017-06-24 18:52:46.000' AS DateTime), CAST(N'2017-06-24 18:54:04.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5761, 1048, 1, N'1396/4/3', N'18:54:05:12', N'1396/4/3', N'18:54:18:13', 12, 1, 85, CAST(N'2017-06-24 18:54:05.000' AS DateTime), CAST(N'2017-06-24 18:54:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5762, 1048, 1, N'1396/4/3', N'18:54:18:30', N'1396/4/3', N'18:59:45:69', 327, 0, 1959, CAST(N'2017-06-24 18:54:18.000' AS DateTime), CAST(N'2017-06-24 18:59:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5763, 1048, 1, N'1396/4/3', N'18:59:45:85', N'1396/4/3', N'19:10:22:76', 637, 1, 3784, CAST(N'2017-06-24 18:59:45.000' AS DateTime), CAST(N'2017-06-24 19:10:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5764, 1048, 1, N'1396/4/3', N'19:10:22:91', N'1396/4/3', N'19:10:45:30', 23, 0, 134, CAST(N'2017-06-24 19:10:22.000' AS DateTime), CAST(N'2017-06-24 19:10:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5765, 1048, 1, N'1396/4/3', N'19:10:45:45', N'1396/4/3', N'19:23:40:55', 775, 1, 4616, CAST(N'2017-06-24 19:10:45.000' AS DateTime), CAST(N'2017-06-24 19:23:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5766, 1048, 1, N'1396/4/3', N'19:23:40:74', N'1396/4/3', N'19:23:55:74', 15, 0, 90, CAST(N'2017-06-24 19:23:40.000' AS DateTime), CAST(N'2017-06-24 19:23:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5767, 1048, 1, N'1396/4/3', N'19:23:55:92', N'1396/4/3', N'19:24:34:21', 39, 1, 230, CAST(N'2017-06-24 19:23:55.000' AS DateTime), CAST(N'2017-06-24 19:24:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5768, 1048, 1, N'1396/4/3', N'19:24:34:38', N'1396/4/3', N'19:27:01:96', 147, 0, 875, CAST(N'2017-06-24 19:24:34.000' AS DateTime), CAST(N'2017-06-24 19:27:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5769, 1048, 1, N'1396/4/3', N'19:27:02:15', N'1396/4/3', N'19:28:02:86', 60, 1, 360, CAST(N'2017-06-24 19:27:02.000' AS DateTime), CAST(N'2017-06-24 19:28:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5770, 1048, 1, N'1396/4/3', N'19:28:03:04', N'1396/4/3', N'19:28:09:73', 6, 0, 40, CAST(N'2017-06-24 19:28:03.000' AS DateTime), CAST(N'2017-06-24 19:28:09.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5771, 1048, 1, N'1396/4/3', N'19:28:09:90', N'1396/4/3', N'19:39:19:40', 670, 1, 3996, CAST(N'2017-06-24 19:28:09.000' AS DateTime), CAST(N'2017-06-24 19:39:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5772, 1048, 1, N'1396/4/3', N'19:39:19:52', N'1396/4/3', N'19:41:13:15', 113, 0, 681, CAST(N'2017-06-24 19:39:19.000' AS DateTime), CAST(N'2017-06-24 19:41:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5773, 1048, 1, N'1396/4/3', N'19:41:13:33', N'1396/4/3', N'19:55:11:85', 838, 1, 4932, CAST(N'2017-06-24 19:41:13.000' AS DateTime), CAST(N'2017-06-24 19:55:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5774, 1048, 1, N'1396/4/3', N'19:55:12:01', N'1396/4/3', N'19:55:20:81', 8, 0, 58, CAST(N'2017-06-24 19:55:12.000' AS DateTime), CAST(N'2017-06-24 19:55:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5775, 1048, 1, N'1396/4/3', N'19:55:20:95', N'1396/4/3', N'19:55:58:29', 38, 1, 222, CAST(N'2017-06-24 19:55:20.000' AS DateTime), CAST(N'2017-06-24 19:55:58.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5776, 1048, 1, N'1396/4/3', N'19:55:58:48', N'1396/4/3', N'19:58:03:23', 125, 0, 749, CAST(N'2017-06-24 19:55:58.000' AS DateTime), CAST(N'2017-06-24 19:58:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5777, 1048, 1, N'1396/4/3', N'19:58:03:39', N'1396/4/3', N'19:58:59:24', 56, 1, 331, CAST(N'2017-06-24 19:58:03.000' AS DateTime), CAST(N'2017-06-24 19:58:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5778, 1048, 1, N'1396/4/3', N'19:58:59:41', N'1396/4/3', N'20:02:46:41', 227, 0, 1361, CAST(N'2017-06-24 19:58:59.000' AS DateTime), CAST(N'2017-06-24 20:02:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5779, 1048, 1, N'1396/4/3', N'20:02:46:60', N'1396/4/3', N'20:03:56:11', 69, 1, 418, CAST(N'2017-06-24 20:02:46.000' AS DateTime), CAST(N'2017-06-24 20:03:56.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5780, 1048, 1, N'1396/4/3', N'20:03:56:28', N'1396/4/3', N'20:05:14:95', 78, 0, 464, CAST(N'2017-06-24 20:03:56.000' AS DateTime), CAST(N'2017-06-24 20:05:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5781, 1048, 1, N'1396/4/3', N'20:05:15:14', N'1396/4/3', N'20:05:16:57', 1, 1, 11, CAST(N'2017-06-24 20:05:15.000' AS DateTime), CAST(N'2017-06-24 20:05:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5782, 1048, 1, N'1396/4/3', N'20:05:16:73', N'1396/4/3', N'20:05:34:64', 18, 0, 109, CAST(N'2017-06-24 20:05:16.000' AS DateTime), CAST(N'2017-06-24 20:05:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5783, 1048, 1, N'1396/4/3', N'20:05:34:81', N'1396/4/3', N'20:05:36:84', 2, 1, 13, CAST(N'2017-06-24 20:05:34.000' AS DateTime), CAST(N'2017-06-24 20:05:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5784, 1048, 1, N'1396/4/3', N'20:05:37:02', N'1396/4/3', N'20:05:40:52', 3, 0, 18, CAST(N'2017-06-24 20:05:37.000' AS DateTime), CAST(N'2017-06-24 20:05:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5785, 1048, 1, N'1396/4/3', N'20:05:40:72', N'1396/4/3', N'20:05:48:63', 8, 1, 46, CAST(N'2017-06-24 20:05:40.000' AS DateTime), CAST(N'2017-06-24 20:05:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5786, 1048, 1, N'1396/4/3', N'20:05:48:81', N'1396/4/3', N'20:09:37:07', 228, 0, 1391, CAST(N'2017-06-24 20:05:48.000' AS DateTime), CAST(N'2017-06-24 20:09:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5787, 1048, 1, N'1396/4/3', N'20:09:37:23', N'1396/4/3', N'20:11:00:70', 83, 1, 490, CAST(N'2017-06-24 20:09:37.000' AS DateTime), CAST(N'2017-06-24 20:11:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5788, 1048, 1, N'1396/4/3', N'20:11:00:89', N'1396/4/3', N'20:11:06:90', 6, 0, 35, CAST(N'2017-06-24 20:11:00.000' AS DateTime), CAST(N'2017-06-24 20:11:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5789, 1048, 1, N'1396/4/3', N'20:11:07:12', N'1396/4/3', N'20:21:18:34', 611, 1, 3672, CAST(N'2017-06-24 20:11:07.000' AS DateTime), CAST(N'2017-06-24 20:21:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5790, 1048, 1, N'1396/4/3', N'20:21:18:44', N'1396/4/3', N'20:21:20:71', 2, 0, 18, CAST(N'2017-06-24 20:21:18.000' AS DateTime), CAST(N'2017-06-24 20:21:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5791, 1048, 1, N'1396/4/3', N'20:21:20:92', N'1396/4/3', N'20:21:49:72', 29, 1, 182, CAST(N'2017-06-24 20:21:20.000' AS DateTime), CAST(N'2017-06-24 20:21:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5792, 1048, 1, N'1396/4/3', N'20:21:49:87', N'1396/4/3', N'20:21:54:30', 5, 0, 27, CAST(N'2017-06-24 20:21:49.000' AS DateTime), CAST(N'2017-06-24 20:21:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5793, 1048, 1, N'1396/4/3', N'20:21:54:47', N'1396/4/3', N'20:23:18:95', 84, 1, 516, CAST(N'2017-06-24 20:21:54.000' AS DateTime), CAST(N'2017-06-24 20:23:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5794, 1048, 1, N'1396/4/3', N'20:23:19:05', N'1396/4/3', N'20:23:21:51', 2, 0, 17, CAST(N'2017-06-24 20:23:19.000' AS DateTime), CAST(N'2017-06-24 20:23:21.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5795, 1048, 1, N'1396/4/3', N'20:23:21:70', N'1396/4/3', N'20:26:14:16', 172, 1, 1040, CAST(N'2017-06-24 20:23:21.000' AS DateTime), CAST(N'2017-06-24 20:26:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5796, 1048, 1, N'1396/4/3', N'20:26:14:32', N'1396/4/4', N'11:12:24:39', 53170, 0, 304226, CAST(N'2017-06-24 20:26:14.000' AS DateTime), CAST(N'2017-06-25 11:12:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5797, 1048, 1, N'1396/4/4', N'11:12:24:57', N'1396/4/4', N'11:12:29:67', 5, 1, 27, CAST(N'2017-06-25 11:12:24.000' AS DateTime), CAST(N'2017-06-25 11:12:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5798, 1048, 1, N'1396/4/4', N'11:12:29:87', N'1396/4/4', N'11:13:06:47', 37, 0, 186, CAST(N'2017-06-25 11:12:29.000' AS DateTime), CAST(N'2017-06-25 11:13:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5799, 1048, 1, N'1396/4/4', N'11:13:06:64', N'1396/4/4', N'11:13:09:06', 2, 1, 13, CAST(N'2017-06-25 11:13:06.000' AS DateTime), CAST(N'2017-06-25 11:13:09.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5800, 1048, 1, N'1396/4/4', N'11:13:09:26', N'1396/4/4', N'11:13:13:13', 3, 0, 18, CAST(N'2017-06-25 11:13:09.000' AS DateTime), CAST(N'2017-06-25 11:13:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5801, 1048, 1, N'1396/4/4', N'11:13:13:30', N'1396/4/4', N'11:13:22:21', 9, 1, 47, CAST(N'2017-06-25 11:13:13.000' AS DateTime), CAST(N'2017-06-25 11:13:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5802, 1048, 1, N'1396/4/4', N'11:13:22:35', N'1396/4/4', N'12:15:39:36', 3737, 0, 19640, CAST(N'2017-06-25 11:13:22.000' AS DateTime), CAST(N'2017-06-25 12:15:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5803, 1048, 1, N'1396/4/4', N'12:15:39:60', N'1396/4/4', N'12:47:40:55', 1921, 1, 9891, CAST(N'2017-06-25 12:15:39.000' AS DateTime), CAST(N'2017-06-25 12:47:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5804, 1048, 1, N'1396/4/4', N'12:47:40:71', N'1396/4/4', N'12:58:35:55', 655, 0, 3383, CAST(N'2017-06-25 12:47:40.000' AS DateTime), CAST(N'2017-06-25 12:58:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5805, 1048, 1, N'1396/4/4', N'12:58:35:66', N'1396/4/4', N'13:01:15:43', 160, 1, 857, CAST(N'2017-06-25 12:58:35.000' AS DateTime), CAST(N'2017-06-25 13:01:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5806, 1048, 1, N'1396/4/4', N'13:01:15:62', N'1396/4/4', N'13:04:22:35', 187, 0, 1039, CAST(N'2017-06-25 13:01:15.000' AS DateTime), CAST(N'2017-06-25 13:04:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5807, 1048, 1, N'1396/4/4', N'13:04:22:52', N'1396/4/4', N'13:05:19:92', 57, 1, 317, CAST(N'2017-06-25 13:04:22.000' AS DateTime), CAST(N'2017-06-25 13:05:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5808, 1048, 1, N'1396/4/4', N'13:05:20:09', N'1396/4/4', N'13:06:24:95', 64, 0, 371, CAST(N'2017-06-25 13:05:20.000' AS DateTime), CAST(N'2017-06-25 13:06:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5809, 1048, 1, N'1396/4/4', N'13:06:25:15', N'1396/4/4', N'13:26:19:51', 1194, 1, 6570, CAST(N'2017-06-25 13:06:25.000' AS DateTime), CAST(N'2017-06-25 13:26:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5810, 1048, 1, N'1396/4/4', N'13:26:19:74', N'1396/4/4', N'13:30:26:25', 247, 0, 1338, CAST(N'2017-06-25 13:26:19.000' AS DateTime), CAST(N'2017-06-25 13:30:26.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5811, 1048, 1, N'1396/4/4', N'13:30:26:44', N'1396/4/4', N'13:32:00:52', 94, 1, 516, CAST(N'2017-06-25 13:30:26.000' AS DateTime), CAST(N'2017-06-25 13:32:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5812, 1048, 1, N'1396/4/4', N'13:32:00:71', N'1396/4/4', N'13:32:42:83', 42, 0, 235, CAST(N'2017-06-25 13:32:00.000' AS DateTime), CAST(N'2017-06-25 13:32:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5813, 1048, 1, N'1396/4/4', N'13:32:43:00', N'1396/4/4', N'13:47:16:34', 873, 1, 4800, CAST(N'2017-06-25 13:32:43.000' AS DateTime), CAST(N'2017-06-25 13:47:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5814, 1048, 1, N'1396/4/4', N'13:47:16:53', N'1396/4/4', N'15:06:33:46', 4757, 0, 25461, CAST(N'2017-06-25 13:47:16.000' AS DateTime), CAST(N'2017-06-25 15:06:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5815, 1048, 1, N'1396/4/4', N'15:06:34:00', N'1396/4/4', N'15:10:36:54', 242, 1, 1326, CAST(N'2017-06-25 15:06:34.000' AS DateTime), CAST(N'2017-06-25 15:10:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5816, 1048, 1, N'1396/4/4', N'15:10:36:74', N'1396/4/4', N'15:11:29:49', 53, 0, 279, CAST(N'2017-06-25 15:10:36.000' AS DateTime), CAST(N'2017-06-25 15:11:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5817, 1048, 1, N'1396/4/4', N'15:11:29:67', N'1396/4/4', N'15:11:33:59', 4, 1, 24, CAST(N'2017-06-25 15:11:29.000' AS DateTime), CAST(N'2017-06-25 15:11:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5818, 1048, 1, N'1396/4/4', N'15:11:33:77', N'1396/4/4', N'15:12:11:05', 37, 0, 207, CAST(N'2017-06-25 15:11:33.000' AS DateTime), CAST(N'2017-06-25 15:12:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5819, 1048, 1, N'1396/4/4', N'15:12:11:23', N'1396/4/4', N'15:12:15:46', 4, 1, 24, CAST(N'2017-06-25 15:12:11.000' AS DateTime), CAST(N'2017-06-25 15:12:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5820, 1048, 1, N'1396/4/4', N'15:12:15:63', N'1396/4/4', N'15:14:00:73', 105, 0, 574, CAST(N'2017-06-25 15:12:15.000' AS DateTime), CAST(N'2017-06-25 15:14:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5821, 1048, 1, N'1396/4/4', N'15:14:00:96', N'1396/4/4', N'15:14:03:17', 3, 1, 14, CAST(N'2017-06-25 15:14:00.000' AS DateTime), CAST(N'2017-06-25 15:14:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5822, 1048, 1, N'1396/4/4', N'15:14:03:34', N'1396/4/4', N'15:14:48:97', 45, 0, 244, CAST(N'2017-06-25 15:14:03.000' AS DateTime), CAST(N'2017-06-25 15:14:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5823, 1048, 1, N'1396/4/4', N'15:14:49:21', N'1396/4/4', N'15:14:53:60', 4, 1, 23, CAST(N'2017-06-25 15:14:49.000' AS DateTime), CAST(N'2017-06-25 15:14:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5824, 1048, 1, N'1396/4/4', N'15:14:53:78', N'1396/4/4', N'15:18:51:22', 238, 0, 1290, CAST(N'2017-06-25 15:14:53.000' AS DateTime), CAST(N'2017-06-25 15:18:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5825, 1048, 1, N'1396/4/4', N'15:18:51:41', N'1396/4/4', N'15:18:53:62', 2, 1, 13, CAST(N'2017-06-25 15:18:51.000' AS DateTime), CAST(N'2017-06-25 15:18:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5826, 1048, 1, N'1396/4/4', N'15:18:53:80', N'1396/4/4', N'15:19:50:14', 56, 0, 316, CAST(N'2017-06-25 15:18:53.000' AS DateTime), CAST(N'2017-06-25 15:19:50.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5827, 1048, 1, N'1396/4/4', N'15:19:50:31', N'1396/4/4', N'15:19:54:38', 4, 1, 24, CAST(N'2017-06-25 15:19:50.000' AS DateTime), CAST(N'2017-06-25 15:19:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5828, 1048, 1, N'1396/4/4', N'15:19:54:56', N'1396/4/4', N'15:19:57:64', 3, 0, 18, CAST(N'2017-06-25 15:19:54.000' AS DateTime), CAST(N'2017-06-25 15:19:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5829, 1048, 1, N'1396/4/4', N'15:19:57:90', N'1396/4/4', N'15:20:06:04', 8, 1, 46, CAST(N'2017-06-25 15:19:57.000' AS DateTime), CAST(N'2017-06-25 15:20:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5830, 1048, 1, N'1396/4/4', N'15:20:06:20', N'1396/4/4', N'15:25:01:31', 295, 0, 1606, CAST(N'2017-06-25 15:20:06.000' AS DateTime), CAST(N'2017-06-25 15:25:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5831, 1048, 1, N'1396/4/4', N'15:25:01:50', N'1396/4/4', N'15:25:06:20', 4, 1, 26, CAST(N'2017-06-25 15:25:01.000' AS DateTime), CAST(N'2017-06-25 15:25:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5832, 1048, 1, N'1396/4/4', N'15:25:06:35', N'1396/4/4', N'15:25:44:99', 38, 0, 221, CAST(N'2017-06-25 15:25:06.000' AS DateTime), CAST(N'2017-06-25 15:25:44.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5833, 1048, 1, N'1396/4/4', N'15:25:45:22', N'1396/4/4', N'15:56:51:35', 1866, 1, 10302, CAST(N'2017-06-25 15:25:45.000' AS DateTime), CAST(N'2017-06-25 15:56:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5834, 1048, 1, N'1396/4/4', N'15:56:51:55', N'1396/4/4', N'16:58:22:05', 3690, 0, 21496, CAST(N'2017-06-25 15:56:51.000' AS DateTime), CAST(N'2017-06-25 16:58:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5835, 1048, 1, N'1396/4/4', N'16:58:22:24', N'1396/4/4', N'17:17:16:92', 1134, 1, 6560, CAST(N'2017-06-25 16:58:22.000' AS DateTime), CAST(N'2017-06-25 17:17:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5836, 1048, 1, N'1396/4/4', N'17:17:17:09', N'1396/4/4', N'17:20:38:78', 201, 0, 1143, CAST(N'2017-06-25 17:17:17.000' AS DateTime), CAST(N'2017-06-25 17:20:38.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5837, 1048, 1, N'1396/4/4', N'17:20:38:93', N'1396/4/4', N'17:29:30:53', 532, 1, 3000, CAST(N'2017-06-25 17:20:38.000' AS DateTime), CAST(N'2017-06-25 17:29:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5838, 1048, 1, N'1396/4/4', N'17:29:30:67', N'1396/4/4', N'17:38:21:99', 531, 0, 3274, CAST(N'2017-06-25 17:29:30.000' AS DateTime), CAST(N'2017-06-25 17:38:21.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5839, 1048, 1, N'1396/4/4', N'17:38:22:09', N'1396/4/4', N'17:40:41:14', 138, 1, 810, CAST(N'2017-06-25 17:38:22.000' AS DateTime), CAST(N'2017-06-25 17:40:41.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5840, 1048, 1, N'1396/4/4', N'17:40:41:33', N'1396/4/4', N'17:45:18:01', 276, 0, 1660, CAST(N'2017-06-25 17:40:41.000' AS DateTime), CAST(N'2017-06-25 17:45:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5841, 1048, 1, N'1396/4/4', N'17:45:18:17', N'1396/4/4', N'17:51:33:20', 375, 1, 2220, CAST(N'2017-06-25 17:45:18.000' AS DateTime), CAST(N'2017-06-25 17:51:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5842, 1048, 1, N'1396/4/4', N'17:51:33:37', N'1396/4/4', N'18:15:52:85', 1459, 0, 8437, CAST(N'2017-06-25 17:51:33.000' AS DateTime), CAST(N'2017-06-25 18:15:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5843, 1048, 17, N'1396/4/7', N'08:06:20:82', N'1396/4/10', N'21:42:08:58', 308148, 0, 1760975, CAST(N'2017-06-28 08:06:20.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5844, 1048, 18, N'1396/4/7', N'08:06:26:19', N'1396/4/10', N'21:42:08:60', 308142, 0, 1760975, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5845, 1048, 19, N'1396/4/7', N'08:06:26:19', N'1396/4/10', N'21:42:08:61', 308142, 0, 1760975, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5846, 1048, 20, N'1396/4/7', N'08:06:26:19', N'1396/4/10', N'21:42:08:61', 308142, 0, 1760975, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5847, 1048, 21, N'1396/4/7', N'08:06:26:19', N'1396/4/10', N'21:42:08:63', 308142, 0, 1760975, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5848, 1048, 22, N'1396/4/7', N'08:06:26:19', N'1396/4/10', N'21:42:08:63', 308142, 0, 1760975, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5849, 1048, 23, N'1396/4/7', N'08:06:26:21', N'1396/4/10', N'21:42:08:63', 308142, 0, 1760975, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5850, 1048, 24, N'1396/4/7', N'08:06:26:21', N'1396/4/10', N'21:42:08:64', 308142, 0, 1760975, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5851, 1048, 9, N'1396/4/7', N'08:06:26:21', N'1396/4/10', N'21:42:08:44', 308142, 0, 1760961, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5852, 1048, 10, N'1396/4/7', N'08:06:26:21', N'1396/4/10', N'21:42:08:46', 308142, 0, 1760961, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5853, 1048, 11, N'1396/4/7', N'08:06:26:21', N'1396/4/10', N'21:42:08:46', 308142, 0, 1760961, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5854, 1048, 12, N'1396/4/7', N'08:06:26:21', N'1396/4/10', N'21:42:08:46', 308142, 0, 1760961, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5855, 1048, 13, N'1396/4/7', N'08:06:26:21', N'1396/4/10', N'21:42:08:47', 308142, 0, 1760961, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5856, 1048, 14, N'1396/4/7', N'08:06:26:22', N'1396/4/10', N'21:42:08:47', 308142, 0, 1760961, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5857, 1048, 15, N'1396/4/7', N'08:06:26:22', N'1396/4/10', N'21:42:08:49', 308142, 0, 1760961, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5858, 1048, 16, N'1396/4/7', N'08:06:26:22', N'1396/4/10', N'21:42:08:49', 308142, 0, 1760961, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5859, 1048, 1, N'1396/4/7', N'08:06:26:22', N'1396/4/7', N'10:05:34:33', 7148, 0, 37331, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-06-28 10:05:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5860, 1048, 2, N'1396/4/7', N'08:06:26:22', N'1396/4/10', N'21:42:08:50', 308142, 0, 1760978, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5861, 1048, 3, N'1396/4/7', N'08:06:26:22', N'1396/4/10', N'21:42:08:52', 308142, 0, 1760978, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5862, 1048, 4, N'1396/4/7', N'08:06:26:24', N'1396/4/10', N'21:42:08:53', 308142, 0, 1760978, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5863, 1048, 5, N'1396/4/7', N'08:06:26:24', N'1396/4/10', N'21:42:08:53', 308142, 0, 1760978, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5864, 1048, 6, N'1396/4/7', N'08:06:26:24', N'1396/4/10', N'21:42:08:55', 308142, 0, 1760978, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5865, 1048, 7, N'1396/4/7', N'08:06:26:24', N'1396/4/10', N'21:42:08:55', 308142, 0, 1760978, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5866, 1048, 8, N'1396/4/7', N'08:06:26:24', N'1396/4/10', N'21:42:08:55', 308142, 0, 1760978, CAST(N'2017-06-28 08:06:26.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5867, 1048, 1, N'1396/4/7', N'10:05:34:51', N'1396/4/7', N'10:07:16:68', 102, 1, 508, CAST(N'2017-06-28 10:05:34.000' AS DateTime), CAST(N'2017-06-28 10:07:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5868, 1048, 1, N'1396/4/7', N'10:07:16:85', N'1396/4/7', N'10:37:18:81', 1802, 0, 9353, CAST(N'2017-06-28 10:07:16.000' AS DateTime), CAST(N'2017-06-28 10:37:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5869, 1048, 1, N'1396/4/7', N'10:37:19:03', N'1396/4/7', N'10:37:56:38', 37, 1, 160, CAST(N'2017-06-28 10:37:19.000' AS DateTime), CAST(N'2017-06-28 10:37:56.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5870, 1048, 1, N'1396/4/7', N'10:37:56:55', N'1396/4/7', N'10:37:56:93', 0, 0, 3, CAST(N'2017-06-28 10:37:56.000' AS DateTime), CAST(N'2017-06-28 10:37:56.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5871, 1048, 1, N'1396/4/7', N'10:37:57:12', N'1396/4/7', N'10:47:01:25', 544, 1, 2738, CAST(N'2017-06-28 10:37:57.000' AS DateTime), CAST(N'2017-06-28 10:47:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5872, 1048, 1, N'1396/4/7', N'10:47:01:47', N'1396/4/7', N'11:04:02:00', 1020, 0, 5005, CAST(N'2017-06-28 10:47:01.000' AS DateTime), CAST(N'2017-06-28 11:04:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5873, 1048, 1, N'1396/4/7', N'11:04:02:22', N'1396/4/7', N'11:08:27:18', 265, 1, 1298, CAST(N'2017-06-28 11:04:02.000' AS DateTime), CAST(N'2017-06-28 11:08:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5874, 1048, 1, N'1396/4/7', N'11:08:27:38', N'1396/4/7', N'11:10:43:83', 136, 0, 688, CAST(N'2017-06-28 11:08:27.000' AS DateTime), CAST(N'2017-06-28 11:10:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5875, 1048, 1, N'1396/4/7', N'11:10:44:15', N'1396/4/7', N'11:13:29:59', 165, 1, 816, CAST(N'2017-06-28 11:10:44.000' AS DateTime), CAST(N'2017-06-28 11:13:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5876, 1048, 1, N'1396/4/7', N'11:13:29:79', N'1396/4/7', N'11:13:31:32', 2, 0, 8, CAST(N'2017-06-28 11:13:29.000' AS DateTime), CAST(N'2017-06-28 11:13:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5877, 1048, 1, N'1396/4/7', N'11:13:31:52', N'1396/4/7', N'11:13:39:39', 8, 1, 39, CAST(N'2017-06-28 11:13:31.000' AS DateTime), CAST(N'2017-06-28 11:13:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5878, 1048, 1, N'1396/4/7', N'11:13:39:54', N'1396/4/7', N'11:18:36:31', 297, 0, 1430, CAST(N'2017-06-28 11:13:39.000' AS DateTime), CAST(N'2017-06-28 11:18:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5879, 1048, 1, N'1396/4/7', N'11:18:36:53', N'1396/4/7', N'11:20:34:32', 118, 1, 572, CAST(N'2017-06-28 11:18:36.000' AS DateTime), CAST(N'2017-06-28 11:20:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5880, 1048, 1, N'1396/4/7', N'11:20:34:54', N'1396/4/7', N'11:23:15:00', 160, 0, 743, CAST(N'2017-06-28 11:20:34.000' AS DateTime), CAST(N'2017-06-28 11:23:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5881, 1048, 1, N'1396/4/7', N'11:23:15:20', N'1396/4/7', N'11:36:30:06', 794, 1, 3736, CAST(N'2017-06-28 11:23:15.000' AS DateTime), CAST(N'2017-06-28 11:36:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5882, 1048, 1, N'1396/4/7', N'11:36:30:26', N'1396/4/7', N'11:36:44:63', 14, 0, 75, CAST(N'2017-06-28 11:36:30.000' AS DateTime), CAST(N'2017-06-28 11:36:44.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5883, 1048, 1, N'1396/4/7', N'11:36:44:83', N'1396/4/7', N'12:43:14:70', 3990, 1, 20798, CAST(N'2017-06-28 11:36:44.000' AS DateTime), CAST(N'2017-06-28 12:43:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5884, 1048, 1, N'1396/4/7', N'12:43:14:89', N'1396/4/7', N'12:44:13:55', 59, 0, 302, CAST(N'2017-06-28 12:43:14.000' AS DateTime), CAST(N'2017-06-28 12:44:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5885, 1048, 1, N'1396/4/7', N'12:44:13:72', N'1396/4/7', N'13:14:43:45', 1830, 1, 10135, CAST(N'2017-06-28 12:44:13.000' AS DateTime), CAST(N'2017-06-28 13:14:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5886, 1048, 1, N'1396/4/7', N'13:14:43:62', N'1396/4/7', N'13:14:50:74', 7, 0, 40, CAST(N'2017-06-28 13:14:43.000' AS DateTime), CAST(N'2017-06-28 13:14:50.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5887, 1048, 1, N'1396/4/7', N'13:14:50:91', N'1396/4/7', N'13:49:14:89', 2064, 1, 11523, CAST(N'2017-06-28 13:14:50.000' AS DateTime), CAST(N'2017-06-28 13:49:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5888, 1048, 1, N'1396/4/7', N'13:49:15:05', N'1396/4/7', N'14:35:07:65', 2752, 0, 14413, CAST(N'2017-06-28 13:49:15.000' AS DateTime), CAST(N'2017-06-28 14:35:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5889, 1048, 1, N'1396/4/7', N'14:35:07:88', N'1396/4/7', N'16:32:04:02', 7016, 1, 39163, CAST(N'2017-06-28 14:35:07.000' AS DateTime), CAST(N'2017-06-28 16:32:04.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5890, 1048, 1, N'1396/4/7', N'16:32:04:16', N'1396/4/7', N'16:36:08:56', 244, 0, 1449, CAST(N'2017-06-28 16:32:04.000' AS DateTime), CAST(N'2017-06-28 16:36:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5891, 1048, 1, N'1396/4/7', N'16:36:08:72', N'1396/4/7', N'17:20:51:92', 2683, 1, 15749, CAST(N'2017-06-28 16:36:08.000' AS DateTime), CAST(N'2017-06-28 17:20:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5892, 1048, 1, N'1396/4/7', N'17:20:52:10', N'1396/4/7', N'17:25:27:77', 275, 0, 1614, CAST(N'2017-06-28 17:20:52.000' AS DateTime), CAST(N'2017-06-28 17:25:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5893, 1048, 1, N'1396/4/7', N'17:25:27:94', N'1396/4/7', N'18:00:55:65', 2128, 1, 12542, CAST(N'2017-06-28 17:25:27.000' AS DateTime), CAST(N'2017-06-28 18:00:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5894, 1048, 1, N'1396/4/7', N'18:00:55:79', N'1396/4/7', N'18:07:19:63', 384, 0, 2324, CAST(N'2017-06-28 18:00:55.000' AS DateTime), CAST(N'2017-06-28 18:07:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5895, 1048, 1, N'1396/4/7', N'18:07:19:80', N'1396/4/7', N'18:57:29:11', 3009, 1, 17895, CAST(N'2017-06-28 18:07:19.000' AS DateTime), CAST(N'2017-06-28 18:57:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5896, 1048, 1, N'1396/4/7', N'18:57:29:30', N'1396/4/7', N'19:04:51:61', 442, 0, 2660, CAST(N'2017-06-28 18:57:29.000' AS DateTime), CAST(N'2017-06-28 19:04:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5897, 1048, 1, N'1396/4/7', N'19:04:51:78', N'1396/4/7', N'20:00:40:32', 3349, 1, 20233, CAST(N'2017-06-28 19:04:51.000' AS DateTime), CAST(N'2017-06-28 20:00:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5898, 1048, 1, N'1396/4/7', N'20:00:40:47', N'1396/4/7', N'20:43:05:90', 2545, 0, 15172, CAST(N'2017-06-28 20:00:40.000' AS DateTime), CAST(N'2017-06-28 20:43:05.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5899, 1048, 1, N'1396/4/7', N'20:43:06:13', N'1396/4/7', N'20:45:02:03', 115, 1, 734, CAST(N'2017-06-28 20:43:06.000' AS DateTime), CAST(N'2017-06-28 20:45:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5900, 1048, 1, N'1396/4/7', N'20:45:02:15', N'1396/4/7', N'20:55:18:29', 616, 0, 3726, CAST(N'2017-06-28 20:45:02.000' AS DateTime), CAST(N'2017-06-28 20:55:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5901, 1048, 1, N'1396/4/7', N'20:55:18:46', N'1396/4/7', N'20:59:13:19', 235, 1, 1419, CAST(N'2017-06-28 20:55:18.000' AS DateTime), CAST(N'2017-06-28 20:59:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5902, 1048, 1, N'1396/4/7', N'20:59:13:37', N'1396/4/7', N'22:36:35:82', 5842, 0, 35140, CAST(N'2017-06-28 20:59:13.000' AS DateTime), CAST(N'2017-06-28 22:36:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5903, 1048, 1, N'1396/4/7', N'22:36:36:02', N'1396/4/7', N'23:03:37:89', 1621, 1, 8264, CAST(N'2017-06-28 22:36:36.000' AS DateTime), CAST(N'2017-06-28 23:03:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5904, 1048, 1, N'1396/4/7', N'23:03:38:09', N'1396/4/7', N'23:03:42:02', 3, 0, 21, CAST(N'2017-06-28 23:03:38.000' AS DateTime), CAST(N'2017-06-28 23:03:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5905, 1048, 1, N'1396/4/7', N'23:03:42:23', N'1396/4/7', N'23:03:54:21', 12, 1, 62, CAST(N'2017-06-28 23:03:42.000' AS DateTime), CAST(N'2017-06-28 23:03:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5906, 1048, 1, N'1396/4/7', N'23:03:54:41', N'1396/4/7', N'23:04:45:98', 51, 0, 246, CAST(N'2017-06-28 23:03:54.000' AS DateTime), CAST(N'2017-06-28 23:04:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5907, 1048, 1, N'1396/4/7', N'23:04:46:25', N'1396/4/7', N'23:04:50:66', 4, 1, 18, CAST(N'2017-06-28 23:04:46.000' AS DateTime), CAST(N'2017-06-28 23:04:50.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5908, 1048, 1, N'1396/4/7', N'23:04:50:87', N'1396/4/7', N'23:14:45:69', 595, 0, 2905, CAST(N'2017-06-28 23:04:50.000' AS DateTime), CAST(N'2017-06-28 23:14:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5909, 1048, 1, N'1396/4/7', N'23:14:45:90', N'1396/4/8', N'08:26:37:72', 33112, 1, 197616, CAST(N'2017-06-28 23:14:45.000' AS DateTime), CAST(N'2017-06-29 08:26:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5910, 1048, 1, N'1396/4/8', N'08:26:37:90', N'1396/4/8', N'08:36:28:05', 590, 0, 3303, CAST(N'2017-06-29 08:26:37.000' AS DateTime), CAST(N'2017-06-29 08:36:28.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5911, 1048, 1, N'1396/4/8', N'08:36:28:18', N'1396/4/8', N'09:13:49:09', 2240, 1, 12299, CAST(N'2017-06-29 08:36:28.000' AS DateTime), CAST(N'2017-06-29 09:13:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5912, 1048, 1, N'1396/4/8', N'09:13:49:24', N'1396/4/8', N'09:32:52:72', 1143, 0, 6227, CAST(N'2017-06-29 09:13:49.000' AS DateTime), CAST(N'2017-06-29 09:32:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5913, 1048, 1, N'1396/4/8', N'09:32:52:85', N'1396/4/8', N'12:17:30:89', 9878, 1, 54831, CAST(N'2017-06-29 09:32:52.000' AS DateTime), CAST(N'2017-06-29 12:17:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5914, 1048, 1, N'1396/4/8', N'12:17:31:06', N'1396/4/8', N'12:19:03:91', 92, 0, 489, CAST(N'2017-06-29 12:17:31.000' AS DateTime), CAST(N'2017-06-29 12:19:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5915, 1048, 1, N'1396/4/8', N'12:19:04:09', N'1396/4/8', N'12:50:33:07', 1888, 1, 10291, CAST(N'2017-06-29 12:19:04.000' AS DateTime), CAST(N'2017-06-29 12:50:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5916, 1048, 1, N'1396/4/8', N'12:50:33:23', N'1396/4/8', N'13:01:48:10', 674, 0, 3823, CAST(N'2017-06-29 12:50:33.000' AS DateTime), CAST(N'2017-06-29 13:01:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5917, 1048, 1, N'1396/4/8', N'13:01:48:27', N'1396/4/8', N'13:03:18:27', 90, 1, 506, CAST(N'2017-06-29 13:01:48.000' AS DateTime), CAST(N'2017-06-29 13:03:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5918, 1048, 1, N'1396/4/8', N'13:03:18:46', N'1396/4/8', N'13:03:40:16', 21, 0, 128, CAST(N'2017-06-29 13:03:18.000' AS DateTime), CAST(N'2017-06-29 13:03:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5919, 1048, 1, N'1396/4/8', N'13:03:40:36', N'1396/4/8', N'19:01:22:48', 21462, 1, 125479, CAST(N'2017-06-29 13:03:40.000' AS DateTime), CAST(N'2017-06-29 19:01:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5920, 1048, 1, N'1396/4/8', N'19:01:22:64', N'1396/4/8', N'19:01:37:79', 15, 0, 94, CAST(N'2017-06-29 19:01:22.000' AS DateTime), CAST(N'2017-06-29 19:01:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5921, 1048, 1, N'1396/4/8', N'19:01:37:96', N'1396/4/8', N'23:52:16:35', 17439, 1, 105839, CAST(N'2017-06-29 19:01:37.000' AS DateTime), CAST(N'2017-06-29 23:52:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5922, 1048, 1, N'1396/4/8', N'23:52:16:50', N'1396/4/9', N'08:40:07:03', 31670, 0, 194648, CAST(N'2017-06-29 23:52:16.000' AS DateTime), CAST(N'2017-06-30 08:40:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5923, 1048, 1, N'1396/4/9', N'08:40:07:14', N'1396/4/9', N'08:41:06:82', 59, 1, 367, CAST(N'2017-06-30 08:40:07.000' AS DateTime), CAST(N'2017-06-30 08:41:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5924, 1048, 1, N'1396/4/9', N'08:41:06:98', N'1396/4/9', N'08:41:27:23', 21, 0, 124, CAST(N'2017-06-30 08:41:06.000' AS DateTime), CAST(N'2017-06-30 08:41:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5925, 1048, 1, N'1396/4/9', N'08:41:27:38', N'1396/4/9', N'08:42:29:67', 62, 1, 368, CAST(N'2017-06-30 08:41:27.000' AS DateTime), CAST(N'2017-06-30 08:42:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5926, 1048, 1, N'1396/4/9', N'08:42:29:83', N'1396/4/9', N'08:51:55:23', 566, 0, 3425, CAST(N'2017-06-30 08:42:29.000' AS DateTime), CAST(N'2017-06-30 08:51:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5927, 1048, 1, N'1396/4/9', N'08:51:55:42', N'1396/4/9', N'11:46:06:35', 10451, 1, 62659, CAST(N'2017-06-30 08:51:55.000' AS DateTime), CAST(N'2017-06-30 11:46:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5928, 1048, 1, N'1396/4/9', N'11:46:06:53', N'1396/4/9', N'11:49:24:26', 198, 0, 1209, CAST(N'2017-06-30 11:46:06.000' AS DateTime), CAST(N'2017-06-30 11:49:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5929, 1048, 1, N'1396/4/9', N'11:49:24:40', N'1396/4/9', N'12:07:16:84', 1072, 1, 6453, CAST(N'2017-06-30 11:49:24.000' AS DateTime), CAST(N'2017-06-30 12:07:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5930, 1048, 1, N'1396/4/9', N'12:07:17:00', N'1396/4/9', N'12:07:57:46', 40, 0, 252, CAST(N'2017-06-30 12:07:17.000' AS DateTime), CAST(N'2017-06-30 12:07:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5931, 1048, 1, N'1396/4/9', N'12:07:57:67', N'1396/4/9', N'12:15:17:24', 440, 1, 2623, CAST(N'2017-06-30 12:07:57.000' AS DateTime), CAST(N'2017-06-30 12:15:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5932, 1048, 1, N'1396/4/9', N'12:15:17:40', N'1396/4/9', N'12:23:53:42', 516, 0, 2971, CAST(N'2017-06-30 12:15:17.000' AS DateTime), CAST(N'2017-06-30 12:23:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5933, 1048, 1, N'1396/4/9', N'12:23:53:59', N'1396/4/9', N'12:24:11:40', 18, 1, 109, CAST(N'2017-06-30 12:23:53.000' AS DateTime), CAST(N'2017-06-30 12:24:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5934, 1048, 1, N'1396/4/9', N'12:24:11:56', N'1396/4/9', N'12:33:23:52', 552, 0, 3343, CAST(N'2017-06-30 12:24:11.000' AS DateTime), CAST(N'2017-06-30 12:33:23.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5935, 1048, 1, N'1396/4/9', N'12:33:23:67', N'1396/4/9', N'12:34:03:98', 40, 1, 245, CAST(N'2017-06-30 12:33:23.000' AS DateTime), CAST(N'2017-06-30 12:34:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5936, 1048, 1, N'1396/4/9', N'12:34:04:17', N'1396/4/9', N'12:43:11:64', 547, 0, 3268, CAST(N'2017-06-30 12:34:04.000' AS DateTime), CAST(N'2017-06-30 12:43:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5937, 1048, 1, N'1396/4/9', N'12:43:11:79', N'1396/4/9', N'12:43:47:44', 36, 1, 215, CAST(N'2017-06-30 12:43:11.000' AS DateTime), CAST(N'2017-06-30 12:43:47.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5938, 1048, 1, N'1396/4/9', N'12:43:47:58', N'1396/4/9', N'13:09:07:23', 1519, 0, 9165, CAST(N'2017-06-30 12:43:47.000' AS DateTime), CAST(N'2017-06-30 13:09:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5939, 1048, 1, N'1396/4/9', N'13:09:07:42', N'1396/4/9', N'13:09:13:89', 6, 1, 40, CAST(N'2017-06-30 13:09:07.000' AS DateTime), CAST(N'2017-06-30 13:09:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5940, 1048, 1, N'1396/4/9', N'13:09:14:05', N'1396/4/9', N'13:09:22:70', 8, 0, 53, CAST(N'2017-06-30 13:09:14.000' AS DateTime), CAST(N'2017-06-30 13:09:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5941, 1048, 1, N'1396/4/9', N'13:09:22:88', N'1396/4/9', N'13:21:53:31', 751, 1, 4520, CAST(N'2017-06-30 13:09:22.000' AS DateTime), CAST(N'2017-06-30 13:21:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5942, 1048, 1, N'1396/4/9', N'13:21:53:53', N'1396/4/9', N'13:22:02:50', 9, 0, 52, CAST(N'2017-06-30 13:21:53.000' AS DateTime), CAST(N'2017-06-30 13:22:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5943, 1048, 1, N'1396/4/9', N'13:22:02:66', N'1396/4/9', N'13:22:49:69', 47, 1, 286, CAST(N'2017-06-30 13:22:02.000' AS DateTime), CAST(N'2017-06-30 13:22:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5944, 1048, 1, N'1396/4/9', N'13:22:49:86', N'1396/4/9', N'13:28:47:41', 358, 0, 2129, CAST(N'2017-06-30 13:22:49.000' AS DateTime), CAST(N'2017-06-30 13:28:47.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5945, 1048, 1, N'1396/4/9', N'13:28:47:57', N'1396/4/9', N'13:32:21:63', 214, 1, 1294, CAST(N'2017-06-30 13:28:47.000' AS DateTime), CAST(N'2017-06-30 13:32:21.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5946, 1048, 1, N'1396/4/9', N'13:32:21:82', N'1396/4/9', N'14:20:24:90', 2883, 0, 17389, CAST(N'2017-06-30 13:32:21.000' AS DateTime), CAST(N'2017-06-30 14:20:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5947, 1048, 1, N'1396/4/9', N'14:20:25:11', N'1396/4/9', N'14:22:24:70', 119, 1, 723, CAST(N'2017-06-30 14:20:25.000' AS DateTime), CAST(N'2017-06-30 14:22:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5948, 1048, 1, N'1396/4/9', N'14:22:24:88', N'1396/4/9', N'14:22:57:46', 33, 0, 193, CAST(N'2017-06-30 14:22:24.000' AS DateTime), CAST(N'2017-06-30 14:22:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5949, 1048, 1, N'1396/4/9', N'14:22:57:61', N'1396/4/9', N'14:28:01:70', 304, 1, 1848, CAST(N'2017-06-30 14:22:57.000' AS DateTime), CAST(N'2017-06-30 14:28:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5950, 1048, 1, N'1396/4/9', N'14:28:01:80', N'1396/4/9', N'14:28:16:29', 15, 0, 105, CAST(N'2017-06-30 14:28:01.000' AS DateTime), CAST(N'2017-06-30 14:28:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5951, 1048, 1, N'1396/4/9', N'14:28:16:48', N'1396/4/9', N'14:31:54:41', 218, 1, 1601, CAST(N'2017-06-30 14:28:16.000' AS DateTime), CAST(N'2017-06-30 14:31:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5952, 1048, 1, N'1396/4/9', N'14:31:54:60', N'1396/4/9', N'14:32:11:19', 17, 0, 116, CAST(N'2017-06-30 14:31:54.000' AS DateTime), CAST(N'2017-06-30 14:32:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5953, 1048, 1, N'1396/4/9', N'14:32:11:38', N'1396/4/9', N'14:36:45:46', 274, 1, 1663, CAST(N'2017-06-30 14:32:11.000' AS DateTime), CAST(N'2017-06-30 14:36:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5954, 1048, 1, N'1396/4/9', N'14:36:45:63', N'1396/4/9', N'14:39:36:53', 171, 0, 1016, CAST(N'2017-06-30 14:36:45.000' AS DateTime), CAST(N'2017-06-30 14:39:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5955, 1048, 1, N'1396/4/9', N'14:39:36:70', N'1396/4/9', N'14:47:10:33', 454, 1, 2649, CAST(N'2017-06-30 14:39:36.000' AS DateTime), CAST(N'2017-06-30 14:47:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5956, 1048, 1, N'1396/4/9', N'14:47:10:50', N'1396/4/9', N'14:47:16:70', 6, 0, 39, CAST(N'2017-06-30 14:47:10.000' AS DateTime), CAST(N'2017-06-30 14:47:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5957, 1048, 1, N'1396/4/9', N'14:47:16:88', N'1396/4/9', N'14:47:20:00', 3, 1, 19, CAST(N'2017-06-30 14:47:16.000' AS DateTime), CAST(N'2017-06-30 14:47:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5958, 1048, 1, N'1396/4/9', N'14:47:20:17', N'1396/4/9', N'15:05:37:74', 1097, 0, 6415, CAST(N'2017-06-30 14:47:20.000' AS DateTime), CAST(N'2017-06-30 15:05:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5959, 1048, 1, N'1396/4/9', N'15:05:37:90', N'1396/4/9', N'15:09:59:50', 262, 1, 1541, CAST(N'2017-06-30 15:05:37.000' AS DateTime), CAST(N'2017-06-30 15:09:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5960, 1048, 1, N'1396/4/9', N'15:09:59:70', N'1396/4/9', N'15:37:57:00', 1677, 0, 10181, CAST(N'2017-06-30 15:09:59.000' AS DateTime), CAST(N'2017-06-30 15:37:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5961, 1048, 1, N'1396/4/9', N'15:37:57:15', N'1396/4/9', N'15:42:26:56', 269, 1, 1632, CAST(N'2017-06-30 15:37:57.000' AS DateTime), CAST(N'2017-06-30 15:42:26.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5962, 1048, 1, N'1396/4/9', N'15:42:26:74', N'1396/4/9', N'15:48:32:96', 366, 0, 2174, CAST(N'2017-06-30 15:42:26.000' AS DateTime), CAST(N'2017-06-30 15:48:32.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5963, 1048, 1, N'1396/4/9', N'15:48:33:12', N'1396/4/9', N'15:50:50:18', 136, 1, 847, CAST(N'2017-06-30 15:48:33.000' AS DateTime), CAST(N'2017-06-30 15:50:50.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5964, 1048, 1, N'1396/4/9', N'15:50:50:33', N'1396/4/9', N'15:56:03:40', 313, 0, 1919, CAST(N'2017-06-30 15:50:50.000' AS DateTime), CAST(N'2017-06-30 15:56:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5965, 1048, 1, N'1396/4/9', N'15:56:03:57', N'1396/4/9', N'15:59:35:99', 212, 1, 1297, CAST(N'2017-06-30 15:56:03.000' AS DateTime), CAST(N'2017-06-30 15:59:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5966, 1048, 1, N'1396/4/9', N'15:59:36:18', N'1396/4/9', N'16:03:16:58', 220, 0, 1356, CAST(N'2017-06-30 15:59:36.000' AS DateTime), CAST(N'2017-06-30 16:03:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5967, 1048, 1, N'1396/4/9', N'16:03:16:72', N'1396/4/9', N'16:07:12:12', 235, 1, 1449, CAST(N'2017-06-30 16:03:16.000' AS DateTime), CAST(N'2017-06-30 16:07:12.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5968, 1048, 1, N'1396/4/9', N'16:07:12:28', N'1396/4/10', N'10:02:26:64', 64514, 0, 362004, CAST(N'2017-06-30 16:07:12.000' AS DateTime), CAST(N'2017-07-01 10:02:26.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5969, 1048, 1, N'1396/4/10', N'10:02:26:82', N'1396/4/10', N'10:06:35:13', 249, 1, 1282, CAST(N'2017-07-01 10:02:26.000' AS DateTime), CAST(N'2017-07-01 10:06:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5970, 1048, 1, N'1396/4/10', N'10:06:35:29', N'1396/4/10', N'10:06:40:12', 4, 0, 26, CAST(N'2017-07-01 10:06:35.000' AS DateTime), CAST(N'2017-07-01 10:06:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5971, 1048, 1, N'1396/4/10', N'10:06:40:25', N'1396/4/10', N'10:10:35:21', 235, 1, 1270, CAST(N'2017-07-01 10:06:40.000' AS DateTime), CAST(N'2017-07-01 10:10:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5972, 1048, 1, N'1396/4/10', N'10:10:35:45', N'1396/4/10', N'10:11:17:29', 42, 0, 215, CAST(N'2017-07-01 10:10:35.000' AS DateTime), CAST(N'2017-07-01 10:11:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5973, 1048, 1, N'1396/4/10', N'10:11:17:47', N'1396/4/10', N'10:17:49:71', 392, 1, 2008, CAST(N'2017-07-01 10:11:17.000' AS DateTime), CAST(N'2017-07-01 10:17:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5974, 1048, 1, N'1396/4/10', N'10:17:49:91', N'1396/4/10', N'10:18:27:10', 37, 0, 192, CAST(N'2017-07-01 10:17:49.000' AS DateTime), CAST(N'2017-07-01 10:18:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5975, 1048, 1, N'1396/4/10', N'10:18:27:32', N'1396/4/10', N'10:34:04:35', 936, 1, 4922, CAST(N'2017-07-01 10:18:27.000' AS DateTime), CAST(N'2017-07-01 10:34:04.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5976, 1048, 1, N'1396/4/10', N'10:34:04:55', N'1396/4/10', N'10:34:17:22', 12, 0, 71, CAST(N'2017-07-01 10:34:04.000' AS DateTime), CAST(N'2017-07-01 10:34:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5977, 1048, 1, N'1396/4/10', N'10:34:17:81', N'1396/4/10', N'10:39:24:40', 307, 1, 1641, CAST(N'2017-07-01 10:34:17.000' AS DateTime), CAST(N'2017-07-01 10:39:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5978, 1048, 1, N'1396/4/10', N'10:39:24:54', N'1396/4/10', N'10:39:34:77', 10, 0, 56, CAST(N'2017-07-01 10:39:24.000' AS DateTime), CAST(N'2017-07-01 10:39:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5979, 1048, 1, N'1396/4/10', N'10:39:34:89', N'1396/4/10', N'10:40:00:79', 26, 1, 118, CAST(N'2017-07-01 10:39:34.000' AS DateTime), CAST(N'2017-07-01 10:40:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5980, 1048, 1, N'1396/4/10', N'10:40:00:95', N'1396/4/10', N'10:40:13:15', 12, 0, 56, CAST(N'2017-07-01 10:40:00.000' AS DateTime), CAST(N'2017-07-01 10:40:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5981, 1048, 1, N'1396/4/10', N'10:40:13:36', N'1396/4/10', N'10:46:56:86', 403, 1, 1283, CAST(N'2017-07-01 10:40:13.000' AS DateTime), CAST(N'2017-07-01 10:46:56.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5982, 1048, 1, N'1396/4/10', N'10:46:57:12', N'1396/4/10', N'10:49:45:57', 168, 0, 923, CAST(N'2017-07-01 10:46:57.000' AS DateTime), CAST(N'2017-07-01 10:49:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5983, 1048, 1, N'1396/4/10', N'10:49:45:76', N'1396/4/10', N'10:51:45:69', 120, 1, 613, CAST(N'2017-07-01 10:49:45.000' AS DateTime), CAST(N'2017-07-01 10:51:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5984, 1048, 1, N'1396/4/10', N'10:51:45:85', N'1396/4/10', N'10:52:31:65', 46, 0, 242, CAST(N'2017-07-01 10:51:45.000' AS DateTime), CAST(N'2017-07-01 10:52:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5985, 1048, 1, N'1396/4/10', N'10:52:31:98', N'1396/4/10', N'10:53:24:96', 53, 1, 291, CAST(N'2017-07-01 10:52:31.000' AS DateTime), CAST(N'2017-07-01 10:53:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5986, 1048, 1, N'1396/4/10', N'10:53:25:11', N'1396/4/10', N'11:08:30:83', 905, 0, 4805, CAST(N'2017-07-01 10:53:25.000' AS DateTime), CAST(N'2017-07-01 11:08:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5987, 1048, 1, N'1396/4/10', N'11:08:31:03', N'1396/4/10', N'11:30:25:51', 1314, 1, 6844, CAST(N'2017-07-01 11:08:31.000' AS DateTime), CAST(N'2017-07-01 11:30:25.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5988, 1048, 1, N'1396/4/10', N'11:30:25:69', N'1396/4/10', N'11:33:54:16', 208, 0, 1080, CAST(N'2017-07-01 11:30:25.000' AS DateTime), CAST(N'2017-07-01 11:33:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5989, 1048, 1, N'1396/4/10', N'11:33:54:33', N'1396/4/10', N'11:34:06:82', 12, 1, 64, CAST(N'2017-07-01 11:33:54.000' AS DateTime), CAST(N'2017-07-01 11:34:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5990, 1048, 1, N'1396/4/10', N'11:34:06:99', N'1396/4/10', N'11:41:34:53', 448, 0, 2345, CAST(N'2017-07-01 11:34:06.000' AS DateTime), CAST(N'2017-07-01 11:41:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5991, 1048, 1, N'1396/4/10', N'11:41:34:71', N'1396/4/10', N'11:49:43:95', 489, 1, 2582, CAST(N'2017-07-01 11:41:34.000' AS DateTime), CAST(N'2017-07-01 11:49:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5992, 1048, 1, N'1396/4/10', N'11:49:44:16', N'1396/4/10', N'11:59:06:33', 562, 0, 2976, CAST(N'2017-07-01 11:49:44.000' AS DateTime), CAST(N'2017-07-01 11:59:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5993, 1048, 1, N'1396/4/10', N'11:59:06:59', N'1396/4/10', N'11:59:08:96', 2, 1, 14, CAST(N'2017-07-01 11:59:06.000' AS DateTime), CAST(N'2017-07-01 11:59:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5994, 1048, 1, N'1396/4/10', N'11:59:09:13', N'1396/4/10', N'11:59:12:21', 3, 0, 18, CAST(N'2017-07-01 11:59:09.000' AS DateTime), CAST(N'2017-07-01 11:59:12.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5995, 1048, 1, N'1396/4/10', N'11:59:12:38', N'1396/4/10', N'11:59:19:74', 7, 1, 47, CAST(N'2017-07-01 11:59:12.000' AS DateTime), CAST(N'2017-07-01 11:59:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5996, 1048, 1, N'1396/4/10', N'11:59:19:93', N'1396/4/10', N'12:02:28:33', 189, 0, 1002, CAST(N'2017-07-01 11:59:19.000' AS DateTime), CAST(N'2017-07-01 12:02:28.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5997, 1048, 1, N'1396/4/10', N'12:02:28:52', N'1396/4/10', N'12:06:41:33', 253, 1, 1364, CAST(N'2017-07-01 12:02:28.000' AS DateTime), CAST(N'2017-07-01 12:06:41.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5998, 1048, 1, N'1396/4/10', N'12:06:41:52', N'1396/4/10', N'12:08:30:13', 108, 0, 590, CAST(N'2017-07-01 12:06:41.000' AS DateTime), CAST(N'2017-07-01 12:08:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (5999, 1048, 1, N'1396/4/10', N'12:08:30:31', N'1396/4/10', N'12:09:20:34', 50, 1, 264, CAST(N'2017-07-01 12:08:30.000' AS DateTime), CAST(N'2017-07-01 12:09:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6000, 1048, 1, N'1396/4/10', N'12:09:20:47', N'1396/4/10', N'13:11:11:41', 3711, 0, 19769, CAST(N'2017-07-01 12:09:20.000' AS DateTime), CAST(N'2017-07-01 13:11:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6001, 1048, 1, N'1396/4/10', N'13:11:11:58', N'1396/4/10', N'13:11:16:31', 5, 1, 27, CAST(N'2017-07-01 13:11:11.000' AS DateTime), CAST(N'2017-07-01 13:11:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6002, 1048, 1, N'1396/4/10', N'13:11:16:50', N'1396/4/10', N'13:11:19:34', 3, 0, 17, CAST(N'2017-07-01 13:11:16.000' AS DateTime), CAST(N'2017-07-01 13:11:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6003, 1048, 1, N'1396/4/10', N'13:11:19:49', N'1396/4/10', N'13:11:27:51', 8, 1, 47, CAST(N'2017-07-01 13:11:19.000' AS DateTime), CAST(N'2017-07-01 13:11:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6004, 1048, 1, N'1396/4/10', N'13:11:27:78', N'1396/4/10', N'14:42:34:76', 5467, 0, 28427, CAST(N'2017-07-01 13:11:27.000' AS DateTime), CAST(N'2017-07-01 14:42:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6005, 1048, 1, N'1396/4/10', N'14:42:34:95', N'1396/4/10', N'14:49:31:80', 417, 1, 2234, CAST(N'2017-07-01 14:42:34.000' AS DateTime), CAST(N'2017-07-01 14:49:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6006, 1048, 1, N'1396/4/10', N'14:49:31:95', N'1396/4/10', N'14:49:40:19', 9, 0, 46, CAST(N'2017-07-01 14:49:31.000' AS DateTime), CAST(N'2017-07-01 14:49:40.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6007, 1048, 1, N'1396/4/10', N'14:49:40:35', N'1396/4/10', N'15:00:35:95', 655, 1, 3427, CAST(N'2017-07-01 14:49:40.000' AS DateTime), CAST(N'2017-07-01 15:00:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6008, 1048, 1, N'1396/4/10', N'15:00:36:16', N'1396/4/10', N'15:01:06:00', 29, 0, 153, CAST(N'2017-07-01 15:00:36.000' AS DateTime), CAST(N'2017-07-01 15:01:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6009, 1048, 1, N'1396/4/10', N'15:01:06:20', N'1396/4/10', N'15:03:43:45', 157, 1, 787, CAST(N'2017-07-01 15:01:06.000' AS DateTime), CAST(N'2017-07-01 15:03:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6010, 1048, 1, N'1396/4/10', N'15:03:43:62', N'1396/4/10', N'15:07:12:30', 209, 0, 1166, CAST(N'2017-07-01 15:03:43.000' AS DateTime), CAST(N'2017-07-01 15:07:12.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6011, 1048, 1, N'1396/4/10', N'15:07:12:47', N'1396/4/10', N'16:18:02:29', 4249, 1, 22942, CAST(N'2017-07-01 15:07:12.000' AS DateTime), CAST(N'2017-07-01 16:18:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6012, 1048, 1, N'1396/4/10', N'16:18:02:52', N'1396/4/10', N'16:24:48:58', 406, 0, 2135, CAST(N'2017-07-01 16:18:02.000' AS DateTime), CAST(N'2017-07-01 16:24:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6013, 1048, 1, N'1396/4/10', N'16:24:48:78', N'1396/4/10', N'17:27:05:17', 3736, 1, 20799, CAST(N'2017-07-01 16:24:48.000' AS DateTime), CAST(N'2017-07-01 17:27:05.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6014, 1048, 1, N'1396/4/10', N'17:27:05:34', N'1396/4/10', N'17:27:29:38', 24, 0, 117, CAST(N'2017-07-01 17:27:05.000' AS DateTime), CAST(N'2017-07-01 17:27:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6015, 1048, 1, N'1396/4/10', N'17:27:29:58', N'1396/4/10', N'19:12:35:46', 6305, 1, 35714, CAST(N'2017-07-01 17:27:29.000' AS DateTime), CAST(N'2017-07-01 19:12:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6016, 1048, 1, N'1396/4/10', N'19:12:35:63', N'1396/4/10', N'19:18:44:78', 369, 0, 2068, CAST(N'2017-07-01 19:12:35.000' AS DateTime), CAST(N'2017-07-01 19:18:44.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6017, 1048, 1, N'1396/4/10', N'19:18:44:96', N'1396/4/10', N'20:52:33:74', 5628, 1, 28583, CAST(N'2017-07-01 19:18:44.000' AS DateTime), CAST(N'2017-07-01 20:52:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6018, 1048, 1, N'1396/4/10', N'20:52:33:99', N'1396/4/10', N'21:02:08:29', 573, 0, 3187, CAST(N'2017-07-01 20:52:33.000' AS DateTime), CAST(N'2017-07-01 21:02:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6019, 1048, 1, N'1396/4/10', N'21:02:08:49', N'1396/4/10', N'21:05:17:87', 189, 1, 1030, CAST(N'2017-07-01 21:02:08.000' AS DateTime), CAST(N'2017-07-01 21:05:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6020, 1048, 1, N'1396/4/10', N'21:05:18:09', N'1396/4/10', N'21:42:08:50', 2210, 0, 7130, CAST(N'2017-07-01 21:05:18.000' AS DateTime), CAST(N'2017-07-01 21:42:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6021, 1048, 9, N'1396/4/10', N'22:07:15:65', N'1396/4/11', N'07:13:17:26', 32762, 0, 194471, CAST(N'2017-07-01 22:07:15.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6022, 1048, 10, N'1396/4/10', N'22:07:16:41', N'1396/4/11', N'07:13:17:28', 32761, 0, 194471, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6023, 1048, 11, N'1396/4/10', N'22:07:16:41', N'1396/4/11', N'07:13:17:28', 32761, 0, 194471, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6024, 1048, 12, N'1396/4/10', N'22:07:16:41', N'1396/4/11', N'07:13:17:28', 32761, 0, 194471, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6025, 1048, 13, N'1396/4/10', N'22:07:16:41', N'1396/4/11', N'07:13:17:29', 32761, 0, 194471, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6026, 1048, 14, N'1396/4/10', N'22:07:16:41', N'1396/4/11', N'07:13:17:29', 32761, 0, 194471, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6027, 1048, 15, N'1396/4/10', N'22:07:16:41', N'1396/4/11', N'07:13:17:13', 32761, 0, 194470, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6028, 1048, 16, N'1396/4/10', N'22:07:16:43', N'1396/4/11', N'07:13:17:13', 32761, 0, 194470, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6029, 1048, 1, N'1396/4/10', N'22:07:16:43', N'1396/4/11', N'00:54:54:33', 10058, 1, 59701, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 00:54:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6030, 1048, 2, N'1396/4/10', N'22:07:16:43', N'1396/4/11', N'07:13:17:15', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6031, 1048, 3, N'1396/4/10', N'22:07:16:43', N'1396/4/11', N'07:13:17:17', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6032, 1048, 4, N'1396/4/10', N'22:07:16:43', N'1396/4/11', N'07:13:17:17', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6033, 1048, 5, N'1396/4/10', N'22:07:16:45', N'1396/4/11', N'07:13:17:18', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6034, 1048, 6, N'1396/4/10', N'22:07:16:45', N'1396/4/11', N'07:13:17:20', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6035, 1048, 7, N'1396/4/10', N'22:07:16:45', N'1396/4/11', N'07:13:17:20', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6036, 1048, 8, N'1396/4/10', N'22:07:16:45', N'1396/4/11', N'07:13:17:20', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6037, 1048, 17, N'1396/4/10', N'22:07:16:45', N'1396/4/11', N'07:13:17:21', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6038, 1048, 18, N'1396/4/10', N'22:07:16:45', N'1396/4/11', N'07:13:17:21', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6039, 1048, 19, N'1396/4/10', N'22:07:16:45', N'1396/4/11', N'07:13:17:23', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6040, 1048, 20, N'1396/4/10', N'22:07:16:46', N'1396/4/11', N'07:13:17:23', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6041, 1048, 21, N'1396/4/10', N'22:07:16:46', N'1396/4/11', N'07:13:17:24', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6042, 1048, 22, N'1396/4/10', N'22:07:16:46', N'1396/4/11', N'07:13:17:24', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6043, 1048, 23, N'1396/4/10', N'22:07:16:46', N'1396/4/11', N'07:13:17:24', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6044, 1048, 24, N'1396/4/10', N'22:07:16:46', N'1396/4/11', N'07:13:17:26', 32761, 0, 194474, CAST(N'2017-07-01 22:07:16.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6045, 1048, 1, N'1396/4/11', N'00:54:54:50', N'1396/4/11', N'01:10:38:61', 944, 0, 5239, CAST(N'2017-07-02 00:54:54.000' AS DateTime), CAST(N'2017-07-02 01:10:38.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6046, 1048, 1, N'1396/4/11', N'01:10:38:78', N'1396/4/11', N'01:12:12:66', 94, 1, 572, CAST(N'2017-07-02 01:10:38.000' AS DateTime), CAST(N'2017-07-02 01:12:12.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6047, 1048, 1, N'1396/4/11', N'01:12:12:82', N'1396/4/11', N'01:12:33:21', 21, 0, 130, CAST(N'2017-07-02 01:12:12.000' AS DateTime), CAST(N'2017-07-02 01:12:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6048, 1048, 1, N'1396/4/11', N'01:12:33:36', N'1396/4/11', N'04:42:35:78', 12602, 1, 75199, CAST(N'2017-07-02 01:12:33.000' AS DateTime), CAST(N'2017-07-02 04:42:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6049, 1048, 1, N'1396/4/11', N'04:42:35:92', N'1396/4/11', N'07:13:17:15', 9042, 0, 53633, CAST(N'2017-07-02 04:42:35.000' AS DateTime), CAST(N'2017-07-02 07:13:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6050, 1048, 1, N'1396/4/11', N'07:14:19:89', N'1396/4/11', N'08:03:10:57', 2931, 0, 15572, CAST(N'2017-07-02 07:14:19.000' AS DateTime), CAST(N'2017-07-02 08:03:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6051, 1048, 2, N'1396/4/11', N'07:14:20:73', N'1396/4/15', N'13:06:04:21', 366704, 0, 2000961, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 13:06:04.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6052, 1048, 3, N'1396/4/11', N'07:14:20:75', N'1396/4/15', N'14:09:57:38', 370537, 0, 2021153, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6053, 1048, 4, N'1396/4/11', N'07:14:20:75', N'1396/4/15', N'14:09:57:38', 370537, 0, 2021153, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6054, 1048, 5, N'1396/4/11', N'07:14:20:75', N'1396/4/15', N'14:09:57:39', 370537, 0, 2021153, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6055, 1048, 6, N'1396/4/11', N'07:14:20:75', N'1396/4/15', N'14:09:57:23', 370537, 0, 2021152, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6056, 1048, 7, N'1396/4/11', N'07:14:20:77', N'1396/4/15', N'14:09:57:24', 370537, 0, 2021152, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6057, 1048, 8, N'1396/4/11', N'07:14:20:77', N'1396/4/15', N'14:09:57:24', 370537, 0, 2021152, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6058, 1048, 17, N'1396/4/11', N'07:14:20:78', N'1396/4/15', N'14:09:57:25', 370537, 0, 2021397, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6059, 1048, 18, N'1396/4/11', N'07:14:20:78', N'1396/4/15', N'14:09:57:26', 370537, 0, 2021397, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6060, 1048, 19, N'1396/4/11', N'07:14:20:78', N'1396/4/15', N'14:09:57:26', 370537, 0, 2021397, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6061, 1048, 20, N'1396/4/11', N'07:14:20:78', N'1396/4/15', N'14:09:57:27', 370537, 0, 2021397, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6062, 1048, 21, N'1396/4/11', N'07:14:20:78', N'1396/4/15', N'14:09:57:27', 370537, 0, 2021397, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6063, 1048, 22, N'1396/4/11', N'07:14:20:78', N'1396/4/15', N'14:09:57:28', 370537, 0, 2021397, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6064, 1048, 23, N'1396/4/11', N'07:14:20:78', N'1396/4/15', N'14:09:57:29', 370537, 0, 2021397, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6065, 1048, 24, N'1396/4/11', N'07:14:20:80', N'1396/4/15', N'14:09:57:30', 370537, 0, 2021397, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6066, 1048, 9, N'1396/4/11', N'07:14:20:80', N'1396/4/15', N'14:09:57:31', 370537, 0, 2020779, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6067, 1048, 10, N'1396/4/11', N'07:14:20:80', N'1396/4/15', N'14:09:57:31', 370537, 0, 2020779, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6068, 1048, 11, N'1396/4/11', N'07:14:20:80', N'1396/4/15', N'14:09:57:32', 370537, 0, 2020779, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6069, 1048, 12, N'1396/4/11', N'07:14:20:80', N'1396/4/15', N'14:09:57:33', 370537, 0, 2020779, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6070, 1048, 13, N'1396/4/11', N'07:14:20:80', N'1396/4/15', N'14:09:57:34', 370537, 0, 2020779, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6071, 1048, 14, N'1396/4/11', N'07:14:20:81', N'1396/4/15', N'14:09:57:34', 370537, 0, 2020779, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6072, 1048, 15, N'1396/4/11', N'07:14:20:81', N'1396/4/15', N'14:09:57:35', 370537, 0, 2020779, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6073, 1048, 16, N'1396/4/11', N'07:14:20:81', N'1396/4/15', N'14:09:57:36', 370537, 0, 2020779, CAST(N'2017-07-02 07:14:20.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6074, 1048, 1, N'1396/4/11', N'08:03:10:79', N'1396/4/11', N'08:07:46:02', 275, 1, 1425, CAST(N'2017-07-02 08:03:10.000' AS DateTime), CAST(N'2017-07-02 08:07:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6075, 1048, 1, N'1396/4/11', N'08:07:46:18', N'1396/4/11', N'08:07:53:08', 6, 0, 34, CAST(N'2017-07-02 08:07:46.000' AS DateTime), CAST(N'2017-07-02 08:07:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6076, 1048, 1, N'1396/4/11', N'08:07:53:24', N'1396/4/11', N'14:37:20:35', 23367, 1, 115116, CAST(N'2017-07-02 08:07:53.000' AS DateTime), CAST(N'2017-07-02 14:37:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6077, 1048, 1, N'1396/4/11', N'14:37:20:54', N'1396/4/11', N'14:38:58:14', 97, 0, 510, CAST(N'2017-07-02 14:37:20.000' AS DateTime), CAST(N'2017-07-02 14:38:58.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6078, 1048, 1, N'1396/4/11', N'14:38:58:31', N'1396/4/11', N'14:40:08:41', 70, 1, 357, CAST(N'2017-07-02 14:38:58.000' AS DateTime), CAST(N'2017-07-02 14:40:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6079, 1048, 1, N'1396/4/11', N'14:40:08:58', N'1396/4/11', N'14:40:38:80', 30, 0, 157, CAST(N'2017-07-02 14:40:08.000' AS DateTime), CAST(N'2017-07-02 14:40:38.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6080, 1048, 1, N'1396/4/11', N'14:40:38:98', N'1396/4/11', N'18:20:32:86', 13194, 1, 70005, CAST(N'2017-07-02 14:40:38.000' AS DateTime), CAST(N'2017-07-02 18:20:32.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6081, 1048, 1, N'1396/4/11', N'18:20:33:03', N'1396/4/11', N'18:28:09:43', 456, 0, 2597, CAST(N'2017-07-02 18:20:33.000' AS DateTime), CAST(N'2017-07-02 18:28:09.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6082, 1048, 1, N'1396/4/11', N'18:28:09:60', N'1396/4/11', N'18:28:33:17', 24, 1, 142, CAST(N'2017-07-02 18:28:09.000' AS DateTime), CAST(N'2017-07-02 18:28:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6083, 1048, 1, N'1396/4/11', N'18:28:33:32', N'1396/4/11', N'18:29:26:55', 53, 0, 299, CAST(N'2017-07-02 18:28:33.000' AS DateTime), CAST(N'2017-07-02 18:29:26.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6084, 1048, 1, N'1396/4/11', N'18:29:26:74', N'1396/4/11', N'18:30:39:97', 73, 1, 416, CAST(N'2017-07-02 18:29:26.000' AS DateTime), CAST(N'2017-07-02 18:30:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6085, 1048, 1, N'1396/4/11', N'18:30:40:14', N'1396/4/11', N'18:31:03:61', 23, 0, 135, CAST(N'2017-07-02 18:30:40.000' AS DateTime), CAST(N'2017-07-02 18:31:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6086, 1048, 1, N'1396/4/11', N'18:31:03:81', N'1396/4/11', N'21:18:54:74', 10071, 1, 59075, CAST(N'2017-07-02 18:31:03.000' AS DateTime), CAST(N'2017-07-02 21:18:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6087, 1048, 1, N'1396/4/11', N'21:18:54:89', N'1396/4/11', N'21:23:12:74', 258, 0, 1572, CAST(N'2017-07-02 21:18:54.000' AS DateTime), CAST(N'2017-07-02 21:23:12.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6088, 1048, 1, N'1396/4/11', N'21:23:12:89', N'1396/4/11', N'21:25:17:76', 125, 1, 764, CAST(N'2017-07-02 21:23:12.000' AS DateTime), CAST(N'2017-07-02 21:25:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6089, 1048, 1, N'1396/4/11', N'21:25:17:87', N'1396/4/11', N'21:26:41:24', 84, 0, 508, CAST(N'2017-07-02 21:25:17.000' AS DateTime), CAST(N'2017-07-02 21:26:41.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6090, 1048, 1, N'1396/4/11', N'21:26:41:40', N'1396/4/11', N'21:28:49:24', 128, 1, 777, CAST(N'2017-07-02 21:26:41.000' AS DateTime), CAST(N'2017-07-02 21:28:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6091, 1048, 1, N'1396/4/11', N'21:28:49:42', N'1396/4/11', N'21:39:26:99', 637, 0, 3895, CAST(N'2017-07-02 21:28:49.000' AS DateTime), CAST(N'2017-07-02 21:39:26.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6092, 1048, 1, N'1396/4/11', N'21:39:27:14', N'1396/4/11', N'22:08:12:45', 1725, 1, 10362, CAST(N'2017-07-02 21:39:27.000' AS DateTime), CAST(N'2017-07-02 22:08:12.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6093, 1048, 1, N'1396/4/11', N'22:08:12:62', N'1396/4/11', N'23:46:04:51', 5872, 0, 33687, CAST(N'2017-07-02 22:08:12.000' AS DateTime), CAST(N'2017-07-02 23:46:04.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6094, 1048, 1, N'1396/4/11', N'23:46:04:69', N'1396/4/11', N'23:46:41:68', 37, 1, 194, CAST(N'2017-07-02 23:46:04.000' AS DateTime), CAST(N'2017-07-02 23:46:41.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6095, 1048, 1, N'1396/4/11', N'23:46:41:87', N'1396/4/12', N'00:02:52:13', 970, 0, 5184, CAST(N'2017-07-02 23:46:41.000' AS DateTime), CAST(N'2017-07-03 00:02:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6096, 1048, 1, N'1396/4/12', N'00:02:52:31', N'1396/4/12', N'00:03:59:05', 66, 1, 361, CAST(N'2017-07-03 00:02:52.000' AS DateTime), CAST(N'2017-07-03 00:03:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6097, 1048, 1, N'1396/4/12', N'00:03:59:22', N'1396/4/12', N'00:04:13:81', 14, 0, 79, CAST(N'2017-07-03 00:03:59.000' AS DateTime), CAST(N'2017-07-03 00:04:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6098, 1048, 1, N'1396/4/12', N'00:04:14:00', N'1396/4/12', N'00:04:48:03', 33, 1, 181, CAST(N'2017-07-03 00:04:14.000' AS DateTime), CAST(N'2017-07-03 00:04:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6099, 1048, 1, N'1396/4/12', N'00:04:48:22', N'1396/4/12', N'00:06:24:29', 96, 0, 516, CAST(N'2017-07-03 00:04:48.000' AS DateTime), CAST(N'2017-07-03 00:06:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6100, 1048, 1, N'1396/4/12', N'00:06:24:46', N'1396/4/12', N'00:07:56:55', 92, 1, 495, CAST(N'2017-07-03 00:06:24.000' AS DateTime), CAST(N'2017-07-03 00:07:56.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6101, 1048, 1, N'1396/4/12', N'00:07:56:73', N'1396/4/12', N'00:18:29:79', 633, 0, 3413, CAST(N'2017-07-03 00:07:56.000' AS DateTime), CAST(N'2017-07-03 00:18:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6102, 1048, 1, N'1396/4/12', N'00:18:29:97', N'1396/4/12', N'00:19:15:92', 46, 1, 251, CAST(N'2017-07-03 00:18:29.000' AS DateTime), CAST(N'2017-07-03 00:19:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6103, 1048, 1, N'1396/4/12', N'00:19:16:12', N'1396/4/12', N'00:28:22:89', 546, 0, 2936, CAST(N'2017-07-03 00:19:16.000' AS DateTime), CAST(N'2017-07-03 00:28:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6104, 1048, 1, N'1396/4/12', N'00:28:23:07', N'1396/4/12', N'00:34:11:71', 348, 1, 1798, CAST(N'2017-07-03 00:28:23.000' AS DateTime), CAST(N'2017-07-03 00:34:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6105, 1048, 1, N'1396/4/12', N'00:34:11:91', N'1396/4/12', N'00:34:13:33', 2, 0, 9, CAST(N'2017-07-03 00:34:11.000' AS DateTime), CAST(N'2017-07-03 00:34:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6106, 1048, 1, N'1396/4/12', N'00:34:13:52', N'1396/4/12', N'00:38:17:14', 243, 1, 1277, CAST(N'2017-07-03 00:34:13.000' AS DateTime), CAST(N'2017-07-03 00:38:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6107, 1048, 1, N'1396/4/12', N'00:38:17:33', N'1396/4/12', N'00:52:22:23', 845, 0, 5211, CAST(N'2017-07-03 00:38:17.000' AS DateTime), CAST(N'2017-07-03 00:52:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6108, 1048, 1, N'1396/4/12', N'00:52:22:39', N'1396/4/12', N'00:52:23:50', 1, 1, 8, CAST(N'2017-07-03 00:52:22.000' AS DateTime), CAST(N'2017-07-03 00:52:23.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6109, 1048, 1, N'1396/4/12', N'00:52:23:67', N'1396/4/12', N'00:53:10:21', 47, 0, 289, CAST(N'2017-07-03 00:52:23.000' AS DateTime), CAST(N'2017-07-03 00:53:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6110, 1048, 1, N'1396/4/12', N'00:53:10:39', N'1396/4/12', N'01:01:13:59', 483, 1, 2917, CAST(N'2017-07-03 00:53:10.000' AS DateTime), CAST(N'2017-07-03 01:01:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6111, 1048, 1, N'1396/4/12', N'01:01:13:77', N'1396/4/12', N'01:12:47:63', 694, 0, 3867, CAST(N'2017-07-03 01:01:13.000' AS DateTime), CAST(N'2017-07-03 01:12:47.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6112, 1048, 1, N'1396/4/12', N'01:12:47:81', N'1396/4/12', N'01:17:19:41', 272, 1, 1671, CAST(N'2017-07-03 01:12:47.000' AS DateTime), CAST(N'2017-07-03 01:17:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6113, 1048, 1, N'1396/4/12', N'01:17:19:56', N'1396/4/12', N'01:28:17:13', 657, 0, 4031, CAST(N'2017-07-03 01:17:19.000' AS DateTime), CAST(N'2017-07-03 01:28:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6114, 1048, 1, N'1396/4/12', N'01:28:17:29', N'1396/4/12', N'01:30:16:02', 118, 1, 736, CAST(N'2017-07-03 01:28:17.000' AS DateTime), CAST(N'2017-07-03 01:30:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6115, 1048, 1, N'1396/4/12', N'01:30:16:20', N'1396/4/12', N'01:30:26:18', 10, 0, 64, CAST(N'2017-07-03 01:30:16.000' AS DateTime), CAST(N'2017-07-03 01:30:26.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6116, 1048, 1, N'1396/4/12', N'01:30:26:33', N'1396/4/12', N'04:55:57:01', 12330, 1, 76757, CAST(N'2017-07-03 01:30:26.000' AS DateTime), CAST(N'2017-07-03 04:55:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6117, 1048, 1, N'1396/4/12', N'04:55:57:17', N'1396/4/12', N'09:54:34:96', 17917, 0, 98814, CAST(N'2017-07-03 04:55:57.000' AS DateTime), CAST(N'2017-07-03 09:54:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6118, 1048, 1, N'1396/4/12', N'09:54:35:18', N'1396/4/12', N'10:02:23:92', 468, 1, 2096, CAST(N'2017-07-03 09:54:35.000' AS DateTime), CAST(N'2017-07-03 10:02:23.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6119, 1048, 1, N'1396/4/12', N'10:02:24:30', N'1396/4/12', N'13:25:07:62', 12163, 0, 59522, CAST(N'2017-07-03 10:02:24.000' AS DateTime), CAST(N'2017-07-03 13:25:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6120, 1048, 1, N'1396/4/12', N'13:25:07:80', N'1396/4/12', N'13:30:01:29', 294, 1, 1596, CAST(N'2017-07-03 13:25:07.000' AS DateTime), CAST(N'2017-07-03 13:30:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6121, 1048, 1, N'1396/4/12', N'13:30:01:47', N'1396/4/12', N'15:08:53:14', 5931, 1, 31355, CAST(N'2017-07-03 13:30:01.000' AS DateTime), CAST(N'2017-07-03 15:08:53.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6122, 1048, 1, N'1396/4/12', N'15:08:53:34', N'1396/4/12', N'15:15:05:12', 371, 0, 2004, CAST(N'2017-07-03 15:08:53.000' AS DateTime), CAST(N'2017-07-03 15:15:05.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6123, 1048, 1, N'1396/4/12', N'15:15:05:33', N'1396/4/12', N'15:44:54:05', 1788, 1, 9682, CAST(N'2017-07-03 15:15:05.000' AS DateTime), CAST(N'2017-07-03 15:44:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6124, 1048, 1, N'1396/4/12', N'15:44:54:22', N'1396/4/12', N'16:17:27:84', 1953, 0, 11314, CAST(N'2017-07-03 15:44:54.000' AS DateTime), CAST(N'2017-07-03 16:17:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6125, 1048, 1, N'1396/4/12', N'16:17:28:03', N'1396/4/12', N'16:49:29:09', 1920, 1, 11232, CAST(N'2017-07-03 16:17:28.000' AS DateTime), CAST(N'2017-07-03 16:49:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6126, 1048, 1, N'1396/4/12', N'16:49:29:26', N'1396/4/12', N'16:53:31:28', 242, 0, 1369, CAST(N'2017-07-03 16:49:29.000' AS DateTime), CAST(N'2017-07-03 16:53:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6127, 1048, 1, N'1396/4/12', N'16:53:31:45', N'1396/4/12', N'20:29:22:43', 12951, 1, 75422, CAST(N'2017-07-03 16:53:31.000' AS DateTime), CAST(N'2017-07-03 20:29:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6128, 1048, 1, N'1396/4/12', N'20:29:22:59', N'1396/4/12', N'20:34:28:39', 306, 0, 1757, CAST(N'2017-07-03 20:29:22.000' AS DateTime), CAST(N'2017-07-03 20:34:28.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6129, 1048, 1, N'1396/4/12', N'20:34:28:60', N'1396/4/13', N'01:53:31:85', 19143, 1, 109961, CAST(N'2017-07-03 20:34:28.000' AS DateTime), CAST(N'2017-07-04 01:53:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6130, 1048, 1, N'1396/4/13', N'01:53:32:01', N'1396/4/13', N'01:56:09:16', 156, 0, 979, CAST(N'2017-07-04 01:53:32.000' AS DateTime), CAST(N'2017-07-04 01:56:09.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6131, 1048, 1, N'1396/4/13', N'01:56:09:33', N'1396/4/13', N'01:57:00:89', 51, 1, 322, CAST(N'2017-07-04 01:56:09.000' AS DateTime), CAST(N'2017-07-04 01:57:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6132, 1048, 1, N'1396/4/13', N'01:57:01:06', N'1396/4/13', N'02:16:00:44', 1139, 0, 7026, CAST(N'2017-07-04 01:57:01.000' AS DateTime), CAST(N'2017-07-04 02:16:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6133, 1048, 1, N'1396/4/13', N'02:16:00:59', N'1396/4/13', N'03:07:13:49', 3073, 1, 19152, CAST(N'2017-07-04 02:16:00.000' AS DateTime), CAST(N'2017-07-04 03:07:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6134, 1048, 1, N'1396/4/13', N'03:07:13:64', N'1396/4/13', N'03:08:55:92', 102, 0, 643, CAST(N'2017-07-04 03:07:13.000' AS DateTime), CAST(N'2017-07-04 03:08:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6135, 1048, 1, N'1396/4/13', N'03:08:56:07', N'1396/4/13', N'15:06:38:97', 43062, 1, 237103, CAST(N'2017-07-04 03:08:56.000' AS DateTime), CAST(N'2017-07-04 15:06:38.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6136, 1048, 1, N'1396/4/13', N'15:06:39:20', N'1396/4/13', N'15:07:30:29', 51, 0, 265, CAST(N'2017-07-04 15:06:39.000' AS DateTime), CAST(N'2017-07-04 15:07:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6137, 1048, 1, N'1396/4/13', N'15:07:30:47', N'1396/4/13', N'15:09:46:66', 136, 1, 745, CAST(N'2017-07-04 15:07:30.000' AS DateTime), CAST(N'2017-07-04 15:09:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6138, 1048, 1, N'1396/4/13', N'15:09:46:84', N'1396/4/13', N'15:09:49:32', 3, 0, 15, CAST(N'2017-07-04 15:09:46.000' AS DateTime), CAST(N'2017-07-04 15:09:49.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6139, 1048, 1, N'1396/4/13', N'15:09:49:49', N'1396/4/13', N'15:32:48:39', 1379, 1, 7132, CAST(N'2017-07-04 15:09:49.000' AS DateTime), CAST(N'2017-07-04 15:32:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6140, 1048, 1, N'1396/4/13', N'15:32:48:61', N'1396/4/13', N'15:34:51:04', 122, 0, 643, CAST(N'2017-07-04 15:32:48.000' AS DateTime), CAST(N'2017-07-04 15:34:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6141, 1048, 1, N'1396/4/13', N'15:34:51:23', N'1396/4/13', N'17:49:09:81', 8058, 1, 43828, CAST(N'2017-07-04 15:34:51.000' AS DateTime), CAST(N'2017-07-04 17:49:09.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6142, 1048, 1, N'1396/4/13', N'17:49:10:01', N'1396/4/13', N'17:49:41:74', 31, 0, 175, CAST(N'2017-07-04 17:49:10.000' AS DateTime), CAST(N'2017-07-04 17:49:41.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6143, 1048, 1, N'1396/4/13', N'17:49:41:98', N'1396/4/13', N'20:22:58:09', 9196, 1, 53392, CAST(N'2017-07-04 17:49:41.000' AS DateTime), CAST(N'2017-07-04 20:22:58.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6144, 1048, 1, N'1396/4/13', N'20:22:58:25', N'1396/4/13', N'20:29:25:77', 387, 0, 2255, CAST(N'2017-07-04 20:22:58.000' AS DateTime), CAST(N'2017-07-04 20:29:25.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6145, 1048, 1, N'1396/4/13', N'20:29:25:91', N'1396/4/13', N'20:42:07:71', 762, 1, 4594, CAST(N'2017-07-04 20:29:25.000' AS DateTime), CAST(N'2017-07-04 20:42:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6146, 1048, 1, N'1396/4/13', N'20:42:07:85', N'1396/4/13', N'20:47:23:85', 316, 0, 1915, CAST(N'2017-07-04 20:42:07.000' AS DateTime), CAST(N'2017-07-04 20:47:23.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6147, 1048, 1, N'1396/4/13', N'20:47:24:10', N'1396/4/13', N'20:49:11:07', 106, 1, 634, CAST(N'2017-07-04 20:47:24.000' AS DateTime), CAST(N'2017-07-04 20:49:11.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6148, 1048, 1, N'1396/4/13', N'20:49:11:22', N'1396/4/13', N'21:08:33:37', 1162, 0, 6943, CAST(N'2017-07-04 20:49:11.000' AS DateTime), CAST(N'2017-07-04 21:08:33.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6149, 1048, 1, N'1396/4/13', N'21:08:33:52', N'1396/4/13', N'21:10:18:86', 105, 1, 634, CAST(N'2017-07-04 21:08:33.000' AS DateTime), CAST(N'2017-07-04 21:10:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6150, 1048, 1, N'1396/4/13', N'21:10:19:03', N'1396/4/13', N'21:20:39:28', 620, 0, 3713, CAST(N'2017-07-04 21:10:19.000' AS DateTime), CAST(N'2017-07-04 21:20:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6151, 1048, 1, N'1396/4/13', N'21:20:39:45', N'1396/4/13', N'21:22:23:97', 104, 1, 629, CAST(N'2017-07-04 21:20:39.000' AS DateTime), CAST(N'2017-07-04 21:22:23.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6152, 1048, 1, N'1396/4/13', N'21:22:24:13', N'1396/4/13', N'21:25:50:81', 206, 0, 1216, CAST(N'2017-07-04 21:22:24.000' AS DateTime), CAST(N'2017-07-04 21:25:50.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6153, 1048, 1, N'1396/4/13', N'21:25:50:98', N'1396/4/13', N'21:27:36:80', 106, 1, 631, CAST(N'2017-07-04 21:25:50.000' AS DateTime), CAST(N'2017-07-04 21:27:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6154, 1048, 1, N'1396/4/13', N'21:27:36:99', N'1396/4/13', N'22:10:59:19', 2602, 0, 15469, CAST(N'2017-07-04 21:27:36.000' AS DateTime), CAST(N'2017-07-04 22:10:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6155, 1048, 1, N'1396/4/13', N'22:10:59:36', N'1396/4/13', N'22:12:45:39', 106, 1, 630, CAST(N'2017-07-04 22:10:59.000' AS DateTime), CAST(N'2017-07-04 22:12:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6156, 1048, 1, N'1396/4/13', N'22:12:45:58', N'1396/4/13', N'22:16:08:91', 203, 0, 1209, CAST(N'2017-07-04 22:12:45.000' AS DateTime), CAST(N'2017-07-04 22:16:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6157, 1048, 1, N'1396/4/13', N'22:16:09:06', N'1396/4/13', N'22:17:59:28', 110, 1, 632, CAST(N'2017-07-04 22:16:09.000' AS DateTime), CAST(N'2017-07-04 22:17:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6158, 1048, 1, N'1396/4/13', N'22:17:59:47', N'1396/4/13', N'22:18:19:20', 19, 0, 98, CAST(N'2017-07-04 22:17:59.000' AS DateTime), CAST(N'2017-07-04 22:18:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6159, 1048, 1, N'1396/4/13', N'22:18:19:45', N'1396/4/13', N'22:19:39:88', 80, 1, 454, CAST(N'2017-07-04 22:18:19.000' AS DateTime), CAST(N'2017-07-04 22:19:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6160, 1048, 1, N'1396/4/13', N'22:19:40:04', N'1396/4/13', N'22:21:42:26', 122, 0, 720, CAST(N'2017-07-04 22:19:40.000' AS DateTime), CAST(N'2017-07-04 22:21:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6161, 1048, 1, N'1396/4/13', N'22:21:42:44', N'1396/4/13', N'22:22:50:33', 68, 1, 390, CAST(N'2017-07-04 22:21:42.000' AS DateTime), CAST(N'2017-07-04 22:22:50.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6162, 1048, 1, N'1396/4/13', N'22:22:50:47', N'1396/4/13', N'22:32:29:32', 579, 0, 3433, CAST(N'2017-07-04 22:22:50.000' AS DateTime), CAST(N'2017-07-04 22:32:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6163, 1048, 1, N'1396/4/13', N'22:32:29:48', N'1396/4/13', N'22:34:13:89', 104, 1, 629, CAST(N'2017-07-04 22:32:29.000' AS DateTime), CAST(N'2017-07-04 22:34:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6164, 1048, 1, N'1396/4/13', N'22:34:14:03', N'1396/4/13', N'22:36:36:44', 142, 0, 858, CAST(N'2017-07-04 22:34:14.000' AS DateTime), CAST(N'2017-07-04 22:36:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6165, 1048, 1, N'1396/4/13', N'22:36:36:58', N'1396/4/13', N'22:36:45:69', 9, 1, 57, CAST(N'2017-07-04 22:36:36.000' AS DateTime), CAST(N'2017-07-04 22:36:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6166, 1048, 1, N'1396/4/13', N'22:36:45:86', N'1396/4/13', N'23:21:37:47', 2692, 0, 15845, CAST(N'2017-07-04 22:36:45.000' AS DateTime), CAST(N'2017-07-04 23:21:37.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6167, 1048, 1, N'1396/4/13', N'23:21:37:66', N'1396/4/13', N'23:23:42:88', 125, 1, 628, CAST(N'2017-07-04 23:21:37.000' AS DateTime), CAST(N'2017-07-04 23:23:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6168, 1048, 1, N'1396/4/13', N'23:23:43:05', N'1396/4/13', N'23:28:08:49', 265, 0, 1356, CAST(N'2017-07-04 23:23:43.000' AS DateTime), CAST(N'2017-07-04 23:28:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6169, 1048, 1, N'1396/4/13', N'23:28:08:67', N'1396/4/13', N'23:28:21:71', 13, 1, 69, CAST(N'2017-07-04 23:28:08.000' AS DateTime), CAST(N'2017-07-04 23:28:21.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6170, 1048, 1, N'1396/4/13', N'23:28:21:92', N'1396/4/13', N'23:28:28:44', 7, 0, 35, CAST(N'2017-07-04 23:28:21.000' AS DateTime), CAST(N'2017-07-04 23:28:28.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6171, 1048, 1, N'1396/4/13', N'23:28:28:63', N'1396/4/13', N'23:30:03:35', 95, 1, 524, CAST(N'2017-07-04 23:28:28.000' AS DateTime), CAST(N'2017-07-04 23:30:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6172, 1048, 1, N'1396/4/13', N'23:30:03:50', N'1396/4/13', N'23:33:30:24', 207, 0, 1082, CAST(N'2017-07-04 23:30:03.000' AS DateTime), CAST(N'2017-07-04 23:33:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6173, 1048, 1, N'1396/4/13', N'23:33:30:41', N'1396/4/13', N'23:35:32:54', 122, 1, 618, CAST(N'2017-07-04 23:33:30.000' AS DateTime), CAST(N'2017-07-04 23:35:32.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6174, 1048, 1, N'1396/4/13', N'23:35:32:77', N'1396/4/13', N'23:35:48:56', 16, 0, 83, CAST(N'2017-07-04 23:35:32.000' AS DateTime), CAST(N'2017-07-04 23:35:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6175, 1048, 1, N'1396/4/13', N'23:35:48:75', N'1396/4/13', N'23:37:20:91', 92, 1, 469, CAST(N'2017-07-04 23:35:48.000' AS DateTime), CAST(N'2017-07-04 23:37:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6176, 1048, 1, N'1396/4/13', N'23:37:21:10', N'1396/4/13', N'23:39:12:94', 111, 0, 596, CAST(N'2017-07-04 23:37:21.000' AS DateTime), CAST(N'2017-07-04 23:39:12.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6177, 1048, 1, N'1396/4/13', N'23:39:13:12', N'1396/4/14', N'04:23:15:25', 17041, 1, 99343, CAST(N'2017-07-04 23:39:13.000' AS DateTime), CAST(N'2017-07-05 04:23:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6178, 1048, 1, N'1396/4/14', N'04:23:15:50', N'1396/4/14', N'04:26:16:32', 181, 0, 1130, CAST(N'2017-07-05 04:23:15.000' AS DateTime), CAST(N'2017-07-05 04:26:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6179, 1048, 1, N'1396/4/14', N'04:26:16:62', N'1396/4/14', N'04:47:57:44', 1301, 1, 8171, CAST(N'2017-07-05 04:26:16.000' AS DateTime), CAST(N'2017-07-05 04:47:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6180, 1048, 1, N'1396/4/14', N'04:47:57:48', N'1396/4/14', N'08:10:01:89', 12124, 0, 24921, CAST(N'2017-07-05 04:47:57.000' AS DateTime), CAST(N'2017-07-05 08:10:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6181, 1048, 1, N'1396/4/14', N'08:10:02:09', N'1396/4/14', N'08:14:59:46', 297, 1, 1537, CAST(N'2017-07-05 08:10:02.000' AS DateTime), CAST(N'2017-07-05 08:14:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6182, 1048, 1, N'1396/4/14', N'08:14:59:62', N'1396/4/14', N'08:29:47:63', 888, 0, 4498, CAST(N'2017-07-05 08:14:59.000' AS DateTime), CAST(N'2017-07-05 08:29:47.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6183, 1048, 1, N'1396/4/14', N'08:29:47:82', N'1396/4/14', N'08:30:03:82', 16, 1, 88, CAST(N'2017-07-05 08:29:47.000' AS DateTime), CAST(N'2017-07-05 08:30:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6184, 1048, 1, N'1396/4/14', N'08:30:04:00', N'1396/4/14', N'08:36:34:18', 389, 0, 1910, CAST(N'2017-07-05 08:30:04.000' AS DateTime), CAST(N'2017-07-05 08:36:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6185, 1048, 1, N'1396/4/14', N'08:36:34:34', N'1396/4/14', N'08:37:02:59', 28, 1, 148, CAST(N'2017-07-05 08:36:34.000' AS DateTime), CAST(N'2017-07-05 08:37:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6186, 1048, 1, N'1396/4/14', N'08:37:03:15', N'1396/4/14', N'09:26:20:71', 2957, 0, 14261, CAST(N'2017-07-05 08:37:03.000' AS DateTime), CAST(N'2017-07-05 09:26:20.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6187, 1048, 1, N'1396/4/14', N'09:26:20:88', N'1396/4/14', N'09:51:27:76', 1507, 1, 7231, CAST(N'2017-07-05 09:26:20.000' AS DateTime), CAST(N'2017-07-05 09:51:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6188, 1048, 1, N'1396/4/14', N'09:51:27:95', N'1396/4/14', N'10:00:18:95', 531, 0, 2665, CAST(N'2017-07-05 09:51:27.000' AS DateTime), CAST(N'2017-07-05 10:00:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6189, 1048, 1, N'1396/4/14', N'10:00:19:15', N'1396/4/14', N'10:10:21:28', 602, 1, 2918, CAST(N'2017-07-05 10:00:19.000' AS DateTime), CAST(N'2017-07-05 10:10:21.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6190, 1048, 1, N'1396/4/14', N'10:10:21:48', N'1396/4/14', N'10:10:46:53', 25, 0, 119, CAST(N'2017-07-05 10:10:21.000' AS DateTime), CAST(N'2017-07-05 10:10:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6191, 1048, 1, N'1396/4/14', N'10:10:47:06', N'1396/4/14', N'10:16:55:35', 368, 1, 1747, CAST(N'2017-07-05 10:10:47.000' AS DateTime), CAST(N'2017-07-05 10:16:55.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6192, 1048, 1, N'1396/4/14', N'10:16:55:52', N'1396/4/14', N'10:23:36:32', 401, 0, 1903, CAST(N'2017-07-05 10:16:55.000' AS DateTime), CAST(N'2017-07-05 10:23:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6193, 1048, 1, N'1396/4/14', N'10:23:36:63', N'1396/4/14', N'10:51:12:62', 1656, 1, 7747, CAST(N'2017-07-05 10:23:36.000' AS DateTime), CAST(N'2017-07-05 10:51:12.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6194, 1048, 1, N'1396/4/14', N'10:51:12:82', N'1396/4/14', N'10:56:03:15', 290, 0, 1386, CAST(N'2017-07-05 10:51:12.000' AS DateTime), CAST(N'2017-07-05 10:56:03.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6195, 1048, 1, N'1396/4/14', N'10:56:03:33', N'1396/4/14', N'13:18:41:22', 8558, 1, 43314, CAST(N'2017-07-05 10:56:03.000' AS DateTime), CAST(N'2017-07-05 13:18:41.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6196, 1048, 1, N'1396/4/14', N'13:18:41:47', N'1396/4/14', N'14:45:05:22', 5183, 0, 26663, CAST(N'2017-07-05 13:18:41.000' AS DateTime), CAST(N'2017-07-05 14:45:05.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6197, 1048, 1, N'1396/4/14', N'14:45:05:40', N'1396/4/14', N'14:48:36:08', 210, 1, 1092, CAST(N'2017-07-05 14:45:05.000' AS DateTime), CAST(N'2017-07-05 14:48:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6198, 1048, 1, N'1396/4/14', N'14:48:36:29', N'1396/4/14', N'14:48:43:85', 7, 0, 41, CAST(N'2017-07-05 14:48:36.000' AS DateTime), CAST(N'2017-07-05 14:48:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6199, 1048, 1, N'1396/4/14', N'14:48:44:02', N'1396/4/14', N'14:52:27:67', 223, 1, 1152, CAST(N'2017-07-05 14:48:44.000' AS DateTime), CAST(N'2017-07-05 14:52:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6200, 1048, 1, N'1396/4/14', N'14:52:27:86', N'1396/4/14', N'14:52:39:47', 12, 0, 62, CAST(N'2017-07-05 14:52:27.000' AS DateTime), CAST(N'2017-07-05 14:52:39.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6201, 1048, 1, N'1396/4/14', N'14:52:39:63', N'1396/4/14', N'15:01:17:02', 517, 1, 2522, CAST(N'2017-07-05 14:52:39.000' AS DateTime), CAST(N'2017-07-05 15:01:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6202, 1048, 1, N'1396/4/14', N'15:01:17:25', N'1396/4/14', N'15:25:21:65', 1444, 0, 7237, CAST(N'2017-07-05 15:01:17.000' AS DateTime), CAST(N'2017-07-05 15:25:21.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6203, 1048, 1, N'1396/4/14', N'15:25:21:82', N'1396/4/14', N'15:53:22:49', 1681, 1, 9072, CAST(N'2017-07-05 15:25:21.000' AS DateTime), CAST(N'2017-07-05 15:53:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6204, 1048, 1, N'1396/4/14', N'15:53:22:65', N'1396/4/14', N'15:53:25:94', 3, 0, 18, CAST(N'2017-07-05 15:53:22.000' AS DateTime), CAST(N'2017-07-05 15:53:25.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6205, 1048, 1, N'1396/4/14', N'15:53:26:13', N'1396/4/14', N'16:00:38:37', 432, 1, 2288, CAST(N'2017-07-05 15:53:26.000' AS DateTime), CAST(N'2017-07-05 16:00:38.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6206, 1048, 1, N'1396/4/14', N'16:00:38:54', N'1396/4/14', N'16:01:32:72', 54, 0, 299, CAST(N'2017-07-05 16:00:38.000' AS DateTime), CAST(N'2017-07-05 16:01:32.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6207, 1048, 1, N'1396/4/14', N'16:01:32:91', N'1396/4/14', N'16:33:14:32', 1902, 1, 10544, CAST(N'2017-07-05 16:01:32.000' AS DateTime), CAST(N'2017-07-05 16:33:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6208, 1048, 1, N'1396/4/14', N'16:33:14:51', N'1396/4/14', N'17:03:34:98', 1820, 0, 10324, CAST(N'2017-07-05 16:33:14.000' AS DateTime), CAST(N'2017-07-05 17:03:34.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6209, 1048, 1, N'1396/4/14', N'17:03:35:16', N'1396/4/14', N'17:39:46:34', 2171, 1, 11965, CAST(N'2017-07-05 17:03:35.000' AS DateTime), CAST(N'2017-07-05 17:39:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6210, 1048, 1, N'1396/4/14', N'17:39:46:49', N'1396/4/14', N'17:47:30:51', 464, 0, 2518, CAST(N'2017-07-05 17:39:46.000' AS DateTime), CAST(N'2017-07-05 17:47:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6211, 1048, 1, N'1396/4/14', N'17:47:30:68', N'1396/4/14', N'18:03:36:43', 966, 1, 5758, CAST(N'2017-07-05 17:47:30.000' AS DateTime), CAST(N'2017-07-05 18:03:36.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6212, 1048, 1, N'1396/4/14', N'18:03:36:53', N'1396/4/14', N'18:12:21:08', 524, 0, 3235, CAST(N'2017-07-05 18:03:36.000' AS DateTime), CAST(N'2017-07-05 18:12:21.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6213, 1048, 1, N'1396/4/14', N'18:12:21:26', N'1396/4/14', N'18:20:26:69', 485, 1, 2956, CAST(N'2017-07-05 18:12:21.000' AS DateTime), CAST(N'2017-07-05 18:20:26.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6214, 1048, 1, N'1396/4/14', N'18:20:26:89', N'1396/4/14', N'18:29:14:35', 528, 0, 3321, CAST(N'2017-07-05 18:20:26.000' AS DateTime), CAST(N'2017-07-05 18:29:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6215, 1048, 1, N'1396/4/14', N'18:29:14:52', N'1396/4/14', N'18:46:22:05', 1027, 1, 6412, CAST(N'2017-07-05 18:29:14.000' AS DateTime), CAST(N'2017-07-05 18:46:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6216, 1048, 1, N'1396/4/14', N'18:46:22:20', N'1396/4/14', N'18:46:25:38', 3, 0, 20, CAST(N'2017-07-05 18:46:22.000' AS DateTime), CAST(N'2017-07-05 18:46:25.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6217, 1048, 1, N'1396/4/14', N'18:46:25:55', N'1396/4/14', N'19:10:59:29', 1474, 1, 9281, CAST(N'2017-07-05 18:46:25.000' AS DateTime), CAST(N'2017-07-05 19:10:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6218, 1048, 1, N'1396/4/14', N'19:10:59:48', N'1396/4/14', N'19:11:10:76', 11, 0, 63, CAST(N'2017-07-05 19:10:59.000' AS DateTime), CAST(N'2017-07-05 19:11:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6219, 1048, 1, N'1396/4/14', N'19:11:10:93', N'1396/4/14', N'19:16:47:46', 337, 1, 2129, CAST(N'2017-07-05 19:11:10.000' AS DateTime), CAST(N'2017-07-05 19:16:47.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6220, 1048, 1, N'1396/4/14', N'19:16:47:59', N'1396/4/14', N'19:24:06:73', 439, 0, 2833, CAST(N'2017-07-05 19:16:47.000' AS DateTime), CAST(N'2017-07-05 19:24:06.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6221, 1048, 1, N'1396/4/14', N'19:24:06:89', N'1396/4/14', N'19:56:31:83', 1945, 1, 12500, CAST(N'2017-07-05 19:24:06.000' AS DateTime), CAST(N'2017-07-05 19:56:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6222, 1048, 1, N'1396/4/14', N'19:56:32:01', N'1396/4/14', N'20:30:47:15', 2054, 0, 12752, CAST(N'2017-07-05 19:56:32.000' AS DateTime), CAST(N'2017-07-05 20:30:47.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6223, 1048, 1, N'1396/4/14', N'20:30:47:31', N'1396/4/14', N'20:31:00:67', 13, 1, 96, CAST(N'2017-07-05 20:30:47.000' AS DateTime), CAST(N'2017-07-05 20:31:00.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6224, 1048, 1, N'1396/4/14', N'20:31:00:83', N'1396/4/14', N'20:31:01:61', 1, 0, 6, CAST(N'2017-07-05 20:31:00.000' AS DateTime), CAST(N'2017-07-05 20:31:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6225, 1048, 1, N'1396/4/14', N'20:31:01:77', N'1396/4/14', N'20:34:52:67', 231, 1, 1498, CAST(N'2017-07-05 20:31:01.000' AS DateTime), CAST(N'2017-07-05 20:34:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6226, 1048, 1, N'1396/4/14', N'20:34:52:83', N'1396/4/14', N'20:40:23:60', 331, 0, 2080, CAST(N'2017-07-05 20:34:52.000' AS DateTime), CAST(N'2017-07-05 20:40:23.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6227, 1048, 1, N'1396/4/14', N'20:40:23:77', N'1396/4/14', N'21:08:35:96', 1692, 1, 10625, CAST(N'2017-07-05 20:40:23.000' AS DateTime), CAST(N'2017-07-05 21:08:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6228, 1048, 1, N'1396/4/14', N'21:08:36:08', N'1396/4/14', N'21:09:44:86', 68, 0, 457, CAST(N'2017-07-05 21:08:36.000' AS DateTime), CAST(N'2017-07-05 21:09:44.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6229, 1048, 1, N'1396/4/14', N'21:09:45:03', N'1396/4/14', N'21:31:46:82', 1321, 1, 8591, CAST(N'2017-07-05 21:09:45.000' AS DateTime), CAST(N'2017-07-05 21:31:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6230, 1048, 1, N'1396/4/14', N'21:31:46:94', N'1396/4/14', N'21:36:01:99', 255, 0, 1691, CAST(N'2017-07-05 21:31:46.000' AS DateTime), CAST(N'2017-07-05 21:36:01.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6231, 1048, 1, N'1396/4/14', N'21:36:02:16', N'1396/4/14', N'21:50:07:11', 844, 1, 5189, CAST(N'2017-07-05 21:36:02.000' AS DateTime), CAST(N'2017-07-05 21:50:07.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6232, 1048, 1, N'1396/4/14', N'21:50:07:27', N'1396/4/14', N'22:47:42:83', 3455, 0, 20820, CAST(N'2017-07-05 21:50:07.000' AS DateTime), CAST(N'2017-07-05 22:47:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6233, 1048, 1, N'1396/4/14', N'22:47:42:99', N'1396/4/14', N'22:47:45:14', 2, 1, 13, CAST(N'2017-07-05 22:47:42.000' AS DateTime), CAST(N'2017-07-05 22:47:45.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6234, 1048, 1, N'1396/4/14', N'22:47:45:31', N'1396/4/14', N'22:47:59:89', 14, 0, 87, CAST(N'2017-07-05 22:47:45.000' AS DateTime), CAST(N'2017-07-05 22:47:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6235, 1048, 1, N'1396/4/14', N'22:48:00:04', N'1396/4/14', N'23:02:25:66', 865, 1, 5139, CAST(N'2017-07-05 22:48:00.000' AS DateTime), CAST(N'2017-07-05 23:02:25.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6236, 1048, 1, N'1396/4/14', N'23:02:25:84', N'1396/4/14', N'23:18:14:52', 949, 0, 5518, CAST(N'2017-07-05 23:02:25.000' AS DateTime), CAST(N'2017-07-05 23:18:14.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6237, 1048, 1, N'1396/4/14', N'23:18:14:70', N'1396/4/14', N'23:23:04:84', 290, 1, 1509, CAST(N'2017-07-05 23:18:14.000' AS DateTime), CAST(N'2017-07-05 23:23:04.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6238, 1048, 1, N'1396/4/14', N'23:23:05:03', N'1396/4/14', N'23:24:18:27', 73, 0, 385, CAST(N'2017-07-05 23:23:05.000' AS DateTime), CAST(N'2017-07-05 23:24:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6239, 1048, 1, N'1396/4/14', N'23:24:18:45', N'1396/4/14', N'23:24:48:97', 30, 1, 164, CAST(N'2017-07-05 23:24:18.000' AS DateTime), CAST(N'2017-07-05 23:24:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6240, 1048, 1, N'1396/4/14', N'23:24:49:15', N'1396/4/14', N'23:30:22:73', 333, 0, 1788, CAST(N'2017-07-05 23:24:49.000' AS DateTime), CAST(N'2017-07-05 23:30:22.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6241, 1048, 1, N'1396/4/14', N'23:30:22:91', N'1396/4/15', N'00:01:05:86', 1843, 1, 9573, CAST(N'2017-07-05 23:30:22.000' AS DateTime), CAST(N'2017-07-06 00:01:05.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6242, 1048, 1, N'1396/4/15', N'00:01:06:06', N'1396/4/15', N'00:03:35:84', 149, 0, 722, CAST(N'2017-07-06 00:01:06.000' AS DateTime), CAST(N'2017-07-06 00:03:35.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6243, 1048, 1, N'1396/4/15', N'00:03:36:03', N'1396/4/15', N'00:08:38:68', 302, 1, 1487, CAST(N'2017-07-06 00:03:36.000' AS DateTime), CAST(N'2017-07-06 00:08:38.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6244, 1048, 1, N'1396/4/15', N'00:08:38:91', N'1396/4/15', N'00:12:30:93', 232, 0, 1135, CAST(N'2017-07-06 00:08:38.000' AS DateTime), CAST(N'2017-07-06 00:12:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6245, 1048, 1, N'1396/4/15', N'00:12:31:13', N'1396/4/15', N'00:42:30:94', 1799, 1, 8866, CAST(N'2017-07-06 00:12:31.000' AS DateTime), CAST(N'2017-07-06 00:42:30.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6246, 1048, 1, N'1396/4/15', N'00:42:31:29', N'1396/4/15', N'00:43:17:91', 46, 0, 223, CAST(N'2017-07-06 00:42:31.000' AS DateTime), CAST(N'2017-07-06 00:43:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6247, 1048, 1, N'1396/4/15', N'00:43:18:10', N'1396/4/15', N'01:46:24:42', 3786, 1, 21975, CAST(N'2017-07-06 00:43:18.000' AS DateTime), CAST(N'2017-07-06 01:46:24.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6248, 1048, 1, N'1396/4/15', N'01:46:24:58', N'1396/4/15', N'01:48:08:11', 103, 0, 648, CAST(N'2017-07-06 01:46:24.000' AS DateTime), CAST(N'2017-07-06 01:48:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6249, 1048, 1, N'1396/4/15', N'01:48:08:27', N'1396/4/15', N'02:15:29:29', 1641, 1, 10156, CAST(N'2017-07-06 01:48:08.000' AS DateTime), CAST(N'2017-07-06 02:15:29.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6250, 1048, 1, N'1396/4/15', N'02:15:29:45', N'1396/4/15', N'02:17:10:89', 101, 0, 634, CAST(N'2017-07-06 02:15:29.000' AS DateTime), CAST(N'2017-07-06 02:17:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6251, 1048, 1, N'1396/4/15', N'02:17:11:06', N'1396/4/15', N'02:38:59:91', 1308, 1, 8150, CAST(N'2017-07-06 02:17:11.000' AS DateTime), CAST(N'2017-07-06 02:38:59.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6252, 1048, 1, N'1396/4/15', N'02:39:00:18', N'1396/4/15', N'02:44:46:63', 346, 0, 2137, CAST(N'2017-07-06 02:39:00.000' AS DateTime), CAST(N'2017-07-06 02:44:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6253, 1048, 1, N'1396/4/15', N'02:44:46:80', N'1396/4/15', N'03:14:48:02', 1801, 1, 11281, CAST(N'2017-07-06 02:44:46.000' AS DateTime), CAST(N'2017-07-06 03:14:48.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6254, 1048, 1, N'1396/4/15', N'03:14:48:17', N'1396/4/15', N'03:17:42:90', 174, 0, 1100, CAST(N'2017-07-06 03:14:48.000' AS DateTime), CAST(N'2017-07-06 03:17:42.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6255, 1048, 1, N'1396/4/15', N'03:17:43:06', N'1396/4/15', N'03:44:57:43', 1634, 1, 10210, CAST(N'2017-07-06 03:17:43.000' AS DateTime), CAST(N'2017-07-06 03:44:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6256, 1048, 1, N'1396/4/15', N'03:44:57:61', N'1396/4/15', N'03:46:51:20', 114, 0, 705, CAST(N'2017-07-06 03:44:57.000' AS DateTime), CAST(N'2017-07-06 03:46:51.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6257, 1048, 1, N'1396/4/15', N'03:46:51:35', N'1396/4/15', N'04:27:13:35', 2422, 1, 14920, CAST(N'2017-07-06 03:46:51.000' AS DateTime), CAST(N'2017-07-06 04:27:13.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6258, 1048, 1, N'1396/4/15', N'04:27:13:51', N'1396/4/15', N'09:45:46:25', 19113, 0, 111801, CAST(N'2017-07-06 04:27:13.000' AS DateTime), CAST(N'2017-07-06 09:45:46.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6259, 1048, 1, N'1396/4/15', N'09:45:46:43', N'1396/4/15', N'09:49:04:08', 197, 1, 1048, CAST(N'2017-07-06 09:45:46.000' AS DateTime), CAST(N'2017-07-06 09:49:04.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6260, 1048, 1, N'1396/4/15', N'09:49:04:27', N'1396/4/15', N'09:49:08:26', 4, 0, 23, CAST(N'2017-07-06 09:49:04.000' AS DateTime), CAST(N'2017-07-06 09:49:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6261, 1048, 1, N'1396/4/15', N'09:49:08:43', N'1396/4/15', N'10:19:15:16', 1806, 1, 9358, CAST(N'2017-07-06 09:49:08.000' AS DateTime), CAST(N'2017-07-06 10:19:15.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6262, 1048, 1, N'1396/4/15', N'10:19:15:33', N'1396/4/15', N'10:21:27:68', 132, 0, 692, CAST(N'2017-07-06 10:19:15.000' AS DateTime), CAST(N'2017-07-06 10:21:27.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6263, 1048, 1, N'1396/4/15', N'10:21:27:85', N'1396/4/15', N'10:51:08:86', 1781, 1, 8951, CAST(N'2017-07-06 10:21:27.000' AS DateTime), CAST(N'2017-07-06 10:51:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6264, 1048, 1, N'1396/4/15', N'10:51:09:06', N'1396/4/15', N'10:56:10:88', 301, 0, 1616, CAST(N'2017-07-06 10:51:09.000' AS DateTime), CAST(N'2017-07-06 10:56:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6265, 1048, 1, N'1396/4/15', N'10:56:11:08', N'1396/4/15', N'11:40:52:96', 2681, 1, 12941, CAST(N'2017-07-06 10:56:11.000' AS DateTime), CAST(N'2017-07-06 11:40:52.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6266, 1048, 1, N'1396/4/15', N'11:40:53:13', N'1396/4/15', N'12:01:43:42', 1250, 0, 6448, CAST(N'2017-07-06 11:40:53.000' AS DateTime), CAST(N'2017-07-06 12:01:43.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6267, 1048, 1, N'1396/4/15', N'12:01:43:62', N'1396/4/15', N'12:05:31:49', 228, 1, 1198, CAST(N'2017-07-06 12:01:43.000' AS DateTime), CAST(N'2017-07-06 12:05:31.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6268, 1048, 1, N'1396/4/15', N'12:05:31:68', N'1396/4/15', N'12:08:05:22', 154, 0, 820, CAST(N'2017-07-06 12:05:31.000' AS DateTime), CAST(N'2017-07-06 12:08:05.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6269, 1048, 1, N'1396/4/15', N'12:08:05:38', N'1396/4/15', N'12:36:16:05', 1690, 1, 8682, CAST(N'2017-07-06 12:08:05.000' AS DateTime), CAST(N'2017-07-06 12:36:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6270, 1048, 1, N'1396/4/15', N'12:36:16:21', N'1396/4/15', N'12:41:10:95', 294, 0, 1575, CAST(N'2017-07-06 12:36:16.000' AS DateTime), CAST(N'2017-07-06 12:41:10.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6271, 1048, 1, N'1396/4/15', N'12:41:11:07', N'1396/4/15', N'13:06:02:90', 1491, 1, 7887, CAST(N'2017-07-06 12:41:11.000' AS DateTime), CAST(N'2017-07-06 13:06:02.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6272, 1048, 1, N'1396/4/15', N'13:06:03:09', N'1396/4/15', N'13:06:19:36', 16, 0, 92, CAST(N'2017-07-06 13:06:03.000' AS DateTime), CAST(N'2017-07-06 13:06:19.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6273, 1048, 2, N'1396/4/15', N'13:06:04:41', N'1396/4/15', N'13:06:18:27', 14, 1, 79, CAST(N'2017-07-06 13:06:04.000' AS DateTime), CAST(N'2017-07-06 13:06:18.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6274, 1048, 2, N'1396/4/15', N'13:06:18:46', N'1396/4/15', N'14:09:57:37', 3819, 0, 20113, CAST(N'2017-07-06 13:06:18.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6275, 1048, 1, N'1396/4/15', N'13:06:19:52', N'1396/4/15', N'13:28:16:24', 1317, 1, 7067, CAST(N'2017-07-06 13:06:19.000' AS DateTime), CAST(N'2017-07-06 13:28:16.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6276, 1048, 1, N'1396/4/15', N'13:28:16:41', N'1396/4/15', N'13:31:08:98', 172, 0, 943, CAST(N'2017-07-06 13:28:16.000' AS DateTime), CAST(N'2017-07-06 13:31:08.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6277, 1048, 1, N'1396/4/15', N'13:31:09:17', N'1396/4/15', N'14:05:17:42', 2048, 1, 10652, CAST(N'2017-07-06 13:31:09.000' AS DateTime), CAST(N'2017-07-06 14:05:17.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6278, 1048, 1, N'1396/4/15', N'14:05:17:59', N'1396/4/15', N'14:09:54:85', 277, 0, 1431, CAST(N'2017-07-06 14:05:17.000' AS DateTime), CAST(N'2017-07-06 14:09:54.000' AS DateTime))
GO
INSERT [dbo].[Tb_Client] ([DeviceStateID], [DeviceID], [DeviceLineId], [StartDate], [StartTime], [EndDate], [EndTime], [Duration], [StateId], [Count], [MiladiStartDateTime], [MiladiFinishDateTime]) VALUES (6279, 1048, 1, N'1396/4/15', N'14:09:55:04', N'1396/4/15', N'14:09:57:36', 2, 1, 14, CAST(N'2017-07-06 14:09:55.000' AS DateTime), CAST(N'2017-07-06 14:09:57.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Tb_Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Tb_Devices] ON 

GO
INSERT [dbo].[Tb_Devices] ([DeviceId], [DeviceDesc], [ComputerName], [PortName], [Active]) VALUES (1048, N'دستگاه کنترل خطوط ماشینکاری', N'S1143', N'COM3', 1)
GO
SET IDENTITY_INSERT [dbo].[Tb_Devices] OFF
GO
SET IDENTITY_INSERT [dbo].[Tb_DevicesLine] ON 

GO
INSERT [dbo].[Tb_DevicesLine] ([ID], [LineId], [LineDesc], [DeviceId], [PulsID], [InputPortTypeId], [ProductLineId], [ActiveColor], [DeActiveColor], [LineActive], [ActiveStateDesc], [DeActiveStateDesc], [GapTime]) VALUES (1039, 1, N'وضعیت خط H45-6', 1048, 2, 1, 1, N'-16732080', N'-1048576', 0, N'کارکرد', N'توقف', 120)
GO
INSERT [dbo].[Tb_DevicesLine] ([ID], [LineId], [LineDesc], [DeviceId], [PulsID], [InputPortTypeId], [ProductLineId], [ActiveColor], [DeActiveColor], [LineActive], [ActiveStateDesc], [DeActiveStateDesc], [GapTime]) VALUES (1041, 2, N'وضعیت خط H45-7', 1048, 2, 1, 1, N'-16732080', N'-1443032', 0, N'کارکرد', N'توقف', 120)
GO
SET IDENTITY_INSERT [dbo].[Tb_DevicesLine] OFF
GO
SET IDENTITY_INSERT [dbo].[Tb_InputPortType] ON 

GO
INSERT [dbo].[Tb_InputPortType] ([InputPortTypeId], [InputPortType]) VALUES (1, N'پایه فعال')
GO
INSERT [dbo].[Tb_InputPortType] ([InputPortTypeId], [InputPortType]) VALUES (2, N'پایه غیر فعال')
GO
SET IDENTITY_INSERT [dbo].[Tb_InputPortType] OFF
GO
SET IDENTITY_INSERT [dbo].[Tb_ProductLines] ON 

GO
INSERT [dbo].[Tb_ProductLines] ([ID], [ProductLineId], [ProductLineDesc], [Description], [MizaneTolid], [SalonDesc]) VALUES (1, N'G1206', N'ماشین H45-6', N'-', N'0', N'سالن ماشینکاری')
GO
INSERT [dbo].[Tb_ProductLines] ([ID], [ProductLineId], [ProductLineDesc], [Description], [MizaneTolid], [SalonDesc]) VALUES (2, N'G1207', N'ماشین H45-5', N'-', N'0', N'سالن ماشینکاری')
GO
SET IDENTITY_INSERT [dbo].[Tb_ProductLines] OFF
GO
SET IDENTITY_INSERT [dbo].[Tb_PulsType] ON 

GO
INSERT [dbo].[Tb_PulsType] ([PulsTypeId], [PulsTypeDesc]) VALUES (1, N'تعداد (شمارنده)')
GO
INSERT [dbo].[Tb_PulsType] ([PulsTypeId], [PulsTypeDesc]) VALUES (2, N'وضعیت')
GO
SET IDENTITY_INSERT [dbo].[Tb_PulsType] OFF
GO
SET IDENTITY_INSERT [dbo].[Tb_Station] ON 

GO
INSERT [dbo].[Tb_Station] ([StationId], [ProductLineId], [DeviceId], [DeviceLineId], [StationDesc], [Description]) VALUES (1, 1, 1048, 1039, N'وضعیت ماشین H45-6', N'-')
GO
SET IDENTITY_INSERT [dbo].[Tb_Station] OFF
GO
INSERT [dbo].[test] ([ID], [Name], [Designation]) VALUES (N'ID', N'Name', N'Designation')
GO
INSERT [dbo].[test] ([ID], [Name], [Designation]) VALUES (N'1', N'mohsen', N'sadasdasd')
GO
INSERT [dbo].[test] ([ID], [Name], [Designation]) VALUES (N'1', N'ali', N'xdfxcvxcv')
GO
INSERT [dbo].[test] ([ID], [Name], [Designation]) VALUES (N'2', N'mohsen', N'sadasdasd')
GO
ALTER TABLE [dbo].[GanttTasks] ADD  CONSTRAINT [DF_GanttTasks_Summary]  DEFAULT ((0)) FOR [Summary]
GO
ALTER TABLE [dbo].[Tb_Client2] ADD  DEFAULT ((0)) FOR [RestTime]
GO
ALTER TABLE [dbo].[Tb_Client2] ADD  DEFAULT ((0)) FOR [ViewManager]
GO
ALTER TABLE [dbo].[Tb_Client2] ADD  DEFAULT ((-1)) FOR [MachinCodeExtra]
GO
ALTER TABLE [dbo].[GanttTasks]  WITH CHECK ADD  CONSTRAINT [FK_GanttTasks_GanttTasks] FOREIGN KEY([ParentID])
REFERENCES [dbo].[GanttTasks] ([ID])
GO
ALTER TABLE [dbo].[GanttTasks] CHECK CONSTRAINT [FK_GanttTasks_GanttTasks]
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
/****** Object:  StoredProcedure [dbo].[insertClient]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ChangeDeviceState]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DeleteDevice]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_DeleteDeviceLine]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DeleteProductLines]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_DeletePulsType]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DeleteStation]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertClient]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertDevices]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_insertDevicesLine]    Script Date: 7/15/2017 12:02:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

-- =============================================
-- Author:		<Author,,mohsen AZADFALLAH>
-- Create date: <Create Date,1395/09/05,>
-- Description:	<Descriptio , insert data to [dbo].[DevicesLine] >
-- =============================================
CREATE PROCEDURE  [dbo].[SP_insertDevicesLine](@LineId int,@LineDesc nvarchar(50),@DeviceId int , @PulsID int,  @InputPortTypeId int,@ProductLineId int,@ActiveColor nvarchar(50) , @DeActiveColor nvarchar(50) , @LineActive bit , @ActiveStateDesc nvarchar(50) , @DeActiveStateDesc nvarchar(50) ,@GapTime int)
AS
BEGIN
	 

   insert into  [dbo].[Tb_DevicesLine] ([LineId] ,LineDesc,DeviceId ,PulsID ,InputPortTypeId ,ProductLineId,ActiveColor ,DeActiveColor,LineActive,  ActiveStateDesc   ,  DeActiveStateDesc ,gaptime  ) values (@LineId ,@LineDesc,@DeviceId ,@PulsID ,@InputPortTypeId ,@ProductLineId,@ActiveColor ,@DeActiveColor,@LineActive,@ActiveStateDesc  ,  @DeActiveStateDesc ,@gaptime )
END








GO
/****** Object:  StoredProcedure [dbo].[SP_InsertProductLine]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_InsertPulsType]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_InsertStation]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_UpdateDevice]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_UpdateDevicesLine]    Script Date: 7/15/2017 12:02:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

-- =============================================
-- Author:		<Author,,mohsen AZADFALLAH>
-- Create date: <Create Date,1395/09/05,>
-- Description:	<Descriptio , insert data to [dbo].[DevicesLine] >
-- =============================================
CREATE  PROCEDURE  [dbo].[SP_UpdateDevicesLine](@LineId int,@LineDesc nvarchar(50),@DeviceId int , @PulsID int,  @InputPortTypeId int,@ProductLineId int,@ActiveColor nvarchar(50) , @DeActiveColor nvarchar(50) , @LineActive bit, @ActiveStateDesc nvarchar(50) , @DeActiveStateDesc nvarchar(50) ,@GapTime int  )
AS
BEGIN
	 

   update  [dbo].[Tb_DevicesLine] set  LineDesc= @LineDesc  ,PulsID=@PulsID ,InputPortTypeId =@InputPortTypeId ,ProductLineId=@ProductLineId,ActiveColor=@ActiveColor ,DeActiveColor=@DeActiveColor,LineActive=@LineActive,ActiveStateDesc= @ActiveStateDesc   ,DeActiveStateDesc= @DeActiveStateDesc  ,Gaptime=@GapTime  where @LineId=LineId and DeviceId=@DeviceId

END








GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateProductLine]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SpUpdate_Station]    Script Date: 7/15/2017 12:02:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SpUpdateClientDuration]    Script Date: 7/15/2017 12:02:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpUpdateClientDuration](@DeviceStateID nvarchar(50) , @Duration nvarchar(50))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   update Tb_Client set Duration=@Duration where DeviceStateID=@DeviceStateID
END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[49] 2[3] 3) )"
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
         Begin Table = "Tb_Client"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tb_Devices"
            Begin Extent = 
               Top = 6
               Left = 280
               Bottom = 136
               Right = 455
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tb_DevicesLine"
            Begin Extent = 
               Top = 6
               Left = 493
               Bottom = 136
               Right = 680
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tb_ProductLines"
            Begin Extent = 
               Top = 6
               Left = 718
               Bottom = 136
               Right = 896
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tb_Station"
            Begin Extent = 
               Top = 6
               Left = 934
               Bottom = 136
               Right = 1104
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
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
         Column = 3075
         Ali' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_Appointments'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'as = 3795
         Table = 1170
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_Appointments'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_Appointments'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "Vw_Resources"
            Begin Extent = 
               Top = 79
               Left = 535
               Bottom = 211
               Right = 713
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Vw_Appointments"
            Begin Extent = 
               Top = 38
               Left = 110
               Bottom = 277
               Right = 281
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
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
         Column = 1440
         Alias = 900
         Table = 3480
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_AppointmentsResources'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_AppointmentsResources'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[70] 4[4] 2[4] 3) )"
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
            TopColumn = 2
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
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[56] 4[10] 2[3] 3) )"
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
         Configuration = "(H (4[49] 2[30] 3) )"
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
               Top = 19
               Left = 208
               Bottom = 263
               Right = 383
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tb_DevicesLine"
            Begin Extent = 
               Top = 87
               Left = 619
               Bottom = 372
               Right = 806
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tb_ProductLines"
            Begin Extent = 
               Top = 185
               Left = 1128
               Bottom = 399
               Right = 1306
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tb_Station"
            Begin Extent = 
               Top = 6
               Left = 934
               Bottom = 136
               Right = 1104
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 21
         Width = 284
         Width = 1500
         Width = 3915
         Width = 2430
         Width = 1830
         Width = 1500
         Width = 1500
         Width = 2595
         Width = 3150
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
         Width = 1770
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_Resources'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'= 2520
         Alias = 3840
         Table = 1170
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_Resources'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_Resources'
GO
USE [master]
GO
ALTER DATABASE [PCSTEC] SET  READ_WRITE 
GO
