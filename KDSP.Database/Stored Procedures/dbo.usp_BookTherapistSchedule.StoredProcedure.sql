USE [KDSP]
GO
/****** Object:  StoredProcedure [dbo].[usp_BookTherapistSchedule]    Script Date: 9/19/2021 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_BookTherapistSchedule](@TherapistName varchar(100), 
@ScheduleDate date, @StartTime time, @EndTime time, @PatientId int, @SessionNumber int)
As
Begin
Declare @TherapistId int
set @TherapistId = (Select Id from Therapists where TherapistFullName =@TherapistName);

Insert into PatientAppointments
(PatientId, TherapistId, TherapistScheduleId, AppointmentDate, Status, PaymentStatus, SessionNumber)
Select @PatientId, @TherapistId, Id, ScheduleDate, 'Booked', 'Pending', @SessionNumber
from TherapistSchedule where TherapistId = @TherapistId
and ScheduleDate = @ScheduleDate and StartTime =@StartTime and EndTime=@EndTime
--Order by ScheduleDate, StartTime

Insert into MasterSheet
(PatientId,TherapistId,PatientAppointmentId,TherapyStatus)
select PatientId,TherapistId, Id, 'Pending'  from PatientAppointments 
where TherapistId = @TherapistId and PatientId = @PatientId and status='Booked'

update TherapistSchedule
Set Status='Booked' 
where TherapistId = @TherapistId
and ScheduleDate = @ScheduleDate and StartTime =@StartTime and EndTime=@EndTime 

End
GO
