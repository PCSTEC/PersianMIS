USE [PCSTEC]
GO

/****** Object:  UserDefinedFunction [dbo].[GetAllStationData]    Script Date: 6/23/2017 10:42:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[GetAllStationData]()
 
RETURNS TABLE 
AS
RETURN 
(
SELECT        TOP (100) PERCENT dbo.Tb_Client.DeviceStateID, dbo.Tb_Client.DeviceID, dbo.Tb_Client.DeviceLineId, dbo.Tb_Client.StartDate, dbo.Tb_Client.StartTime, dbo.Tb_Client.EndDate, dbo.Tb_Client.EndTime, 
                         dbo.Tb_Client.Duration, dbo.Tb_Client.StateId, dbo.Tb_Client.Count, dbo.Tb_Client.MiladiStartDateTime, dbo.Tb_Client.MiladiFinishDateTime, dbo.Tb_Devices.DeviceDesc, dbo.Tb_DevicesLine.LineDesc, 
                         dbo.Tb_DevicesLine.DeActiveStateDesc, dbo.Tb_DevicesLine.ActiveStateDesc, dbo.Tb_DevicesLine.DeActiveColor, dbo.Tb_DevicesLine.ActiveColor, dbo.Tb_ProductLines.ProductLineDesc, 
                         dbo.Tb_Station.StationDesc
FROM            dbo.Tb_Client INNER JOIN
                         dbo.Tb_Devices ON dbo.Tb_Client.DeviceID = dbo.Tb_Devices.DeviceId INNER JOIN
                         dbo.Tb_DevicesLine ON dbo.Tb_Devices.DeviceId = dbo.Tb_DevicesLine.DeviceId INNER JOIN
                         dbo.Tb_ProductLines ON dbo.Tb_DevicesLine.ProductLineId = dbo.Tb_ProductLines.ID INNER JOIN
                         dbo.Tb_Station ON dbo.Tb_Devices.DeviceId = dbo.Tb_Station.DeviceId
ORDER BY dbo.Tb_Client.DeviceStateID
)

GO


