USE [KDSP]
GO
/****** Object:  Table [dbo].[WaitingList]    Script Date: 9/19/2021 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WaitingList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[DateCreated] [datetime] NULL,
	[Status] [varchar](50) NULL,
	[Remarks] [varchar](500) NULL,
 CONSTRAINT [PK_WaitingList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[WaitingList] ADD  CONSTRAINT [DF_WaitingList_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
