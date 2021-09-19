USE [KDSP]
GO
/****** Object:  View [dbo].[v_PatientWaitingList]    Script Date: 9/19/2021 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[v_PatientWaitingList]
as
select p.Id PId, p.PatientRegNo, P.PatientFullName, P.TherapyDept,  p.VisitFrequency, Wl.Id WLId--, P.Status PStatus, wl.Status WLStatus, WL.DateCreated
from Patients P, WaitingList WL
where P.Id = WL.PatientId
and wl.Status='Waiting'
GO
