USE [KDSP]
GO
/****** Object:  StoredProcedure [dbo].[usp_GenerateTherapistSchedule]    Script Date: 9/19/2021 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[usp_GenerateTherapistSchedule](@TherapistId int)
AS
Begin

DECLARE @StartDateTime DATETIME
DECLARE @EndDateTime DATETIME
Declare @TimeSlot int
DECLARE @ShiftStartTime DATETIME
DECLARE @ShiftEndTime DATETIME
--SET @StartDateTime = '2015-01-01'
--SET @EndDateTime = '2015-01-12';
--SET @ShiftStartTime = '09:00:00'
--SET @ShiftEndTime = '18:00:00';
--Declare @TherapistId int;
--set @TherapistId =1
Select @StartDateTime= ClinicStartDate, @EndDateTime=IsNull(ClinicEndDate, getdate()+90), 
@TimeSlot= DATEDIFF(MINUTE, ShiftStartTime, ShiftEndTime) / 60, @ShiftStartTime = ShiftStartTime, @ShiftEndTime=ShiftEndTime
from Therapists where Id = @TherapistId;
--select * from TherapistSchedule where TherapistId=@TherapistId;
--select @StartDateTime, @EndDateTime;

with dates_CTE (date) as (
    select @StartDateTime 
    Union ALL
    select DATEADD(day, 1, date)
    from dates_CTE
    where date < @EndDateTime
),
Times_CTE (time1 , time2 ) as (
    select @ShiftStartTime,  DATEADD(mi, 60, @ShiftStartTime)
    Union ALL
    select DATEADD(mi, 60, time1), DATEADD(mi, 120, time1)
    from Times_CTE
    where time1 < @ShiftEndTime
)

Insert into TherapistSchedule
(TherapistId,ScheduleDate,StartTime,EndTime,Status)
select @TherapistId, d.date, t.time1, t.time2, 'Available'
from dates_CTE d, Times_CTE t
where not exists(Select id from TherapistSchedule ts 
where ts.ScheduleDate = d.date and ts.TherapistId = @TherapistId
and ts.StartTime=Cast(t.time1 as time)
and ts.EndTime = Cast(t.time2 as time))
order by d.date
End
GO
