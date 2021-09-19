USE [KDSP]
GO
/****** Object:  Table [dbo].[MasterSheet]    Script Date: 9/19/2021 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterSheet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[TherapistId] [int] NULL,
	[PatientAppointmentId] [int] NULL,
	[PatientPaymentHistoryId] [int] NULL,
	[TherapyStatus] [varchar](50) NULL,
	[FirstCancellationOfMonth] [char](1) NULL,
	[Inform24HrPrior] [char](1) NULL,
 CONSTRAINT [PK_MasterSheet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
