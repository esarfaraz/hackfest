USE [KDSP]
GO
/****** Object:  Table [dbo].[TherapistSchedule]    Script Date: 9/19/2021 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TherapistSchedule](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TherapistId] [int] NULL,
	[ScheduleDate] [date] NULL,
	[EndTime] [time](7) NULL,
	[StartTime] [time](7) NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_TherapistSchedule] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
