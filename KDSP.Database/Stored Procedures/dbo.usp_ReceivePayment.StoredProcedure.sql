USE [KDSP]
GO
/****** Object:  StoredProcedure [dbo].[usp_ReceivePayment]    Script Date: 9/19/2021 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ReceivePayment](@AppId int, @Paymentstatus varchar(100), @Amount int, @ReceiptNo varchar(50))
as
Begin

Update PatientAppointments set PaymentStatus =@Paymentstatus where Id =@AppId

Insert into PatientPaymentHistory
(PatientId,PatientAppointmentId,ReceiptNo,PaymentAmount,Status)
select PatientId, Id, @ReceiptNo, @Amount, 'Received' from PatientAppointments where Id =@AppId

Update MasterSheet 
Set PatientPaymentHistoryId=(select Id from PatientPaymentHistory where PatientAppointmentId =@AppId) 
where PatientAppointmentId =@AppId

End
GO
