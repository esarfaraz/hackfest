USE [KDSP]
GO
/****** Object:  Table [dbo].[Therapists]    Script Date: 9/19/2021 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Therapists](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TherapistRegNo] [varchar](50) NULL,
	[TherapistFullName] [varchar](100) NULL,
	[DOB] [date] NULL,
	[Sex] [char](1) NULL,
	[Address] [varchar](500) NULL,
	[ContactNo] [varchar](50) NULL,
	[DateCreated] [datetime] NULL,
	[OTTherapist] [char](1) NULL,
	[PTTherapist] [char](1) NULL,
	[StTherapist] [char](1) NULL,
	[ShiftStartTime] [time](7) NULL,
	[ShiftEndTime] [time](7) NULL,
	[Status] [varchar](50) NULL,
	[ClinicStartDate] [date] NULL,
	[ClinicEndDate] [date] NULL,
	[IsSatWorking] [char](1) NULL,
	[IsSunWorking] [char](1) NULL,
	[IsMonWorking] [char](1) NULL,
	[IsTueWorking] [char](1) NULL,
	[IsWedWorking] [char](1) NULL,
	[IsThuWorking] [char](1) NULL,
	[IsFriWorking] [char](1) NULL,
	[BreakStartTime] [time](7) NULL,
	[BreakEndTime] [time](7) NULL,
 CONSTRAINT [PK_Therapists] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Therapists] ADD  CONSTRAINT [DF_Therapists_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[Therapists] ADD  CONSTRAINT [DF_Therapists_OTTherapist]  DEFAULT ('N') FOR [OTTherapist]
GO
ALTER TABLE [dbo].[Therapists] ADD  CONSTRAINT [DF_Therapists_PTTherapist]  DEFAULT ('N') FOR [PTTherapist]
GO
ALTER TABLE [dbo].[Therapists] ADD  CONSTRAINT [DF_Therapists_StTherapist]  DEFAULT ('N') FOR [StTherapist]
GO
ALTER TABLE [dbo].[Therapists] ADD  CONSTRAINT [DF_Therapists_IsSatWorking]  DEFAULT ('Y') FOR [IsSatWorking]
GO
ALTER TABLE [dbo].[Therapists] ADD  CONSTRAINT [DF_Therapists_IsSunWorking]  DEFAULT ('Y') FOR [IsSunWorking]
GO
ALTER TABLE [dbo].[Therapists] ADD  CONSTRAINT [DF_Therapists_IsMonWorking]  DEFAULT ('Y') FOR [IsMonWorking]
GO
ALTER TABLE [dbo].[Therapists] ADD  CONSTRAINT [DF_Therapists_IsTueW'Y'orking]  DEFAULT ('Y') FOR [IsTueWorking]
GO
ALTER TABLE [dbo].[Therapists] ADD  CONSTRAINT [DF_Therapists_IsWedWorking]  DEFAULT ('Y') FOR [IsWedWorking]
GO
ALTER TABLE [dbo].[Therapists] ADD  CONSTRAINT [DF_Therapists_IsThuWorking]  DEFAULT ('Y') FOR [IsThuWorking]
GO
ALTER TABLE [dbo].[Therapists] ADD  CONSTRAINT [DF_Therapists_IsFriWorking]  DEFAULT ('Y') FOR [IsFriWorking]
GO
