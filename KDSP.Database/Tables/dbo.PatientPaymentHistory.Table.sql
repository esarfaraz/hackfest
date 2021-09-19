USE [KDSP]
GO
/****** Object:  Table [dbo].[PatientPaymentHistory]    Script Date: 9/19/2021 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientPaymentHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[PatientAppointmentId] [int] NULL,
	[ReceiptNo] [varchar](50) NULL,
	[DateCreated] [datetime] NULL,
	[PaymentAmount] [int] NULL,
	[Status] [varchar](50) NULL,
	[ECIRepFullName] [varchar](100) NULL,
 CONSTRAINT [PK_PatientPaymentHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PatientPaymentHistory] ADD  CONSTRAINT [DF_PatientPaymentHistory_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
