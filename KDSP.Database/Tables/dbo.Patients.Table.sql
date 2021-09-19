USE [KDSP]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 9/19/2021 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientRegNo] [varchar](50) NULL,
	[PatientFullName] [varchar](100) NULL,
	[DOB] [date] NULL,
	[FatherFullName] [varchar](100) NULL,
	[Sex] [char](1) NULL,
	[Address] [varchar](500) NULL,
	[DateCreated] [datetime] NULL,
	[ContactNo] [varchar](50) NULL,
	[Remarks] [varchar](1000) NULL,
	[TherapyDept] [char](2) NULL,
	[Status] [varchar](50) NULL,
	[VisitFrequency] [varchar](10) NULL,
	[PaidCharges] [int] NULL,
	[PendingCharges] [int] NULL,
 CONSTRAINT [PK_PatientDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Patients] ADD  CONSTRAINT [DF_Patients_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
