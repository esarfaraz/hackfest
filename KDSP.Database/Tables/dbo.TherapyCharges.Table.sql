USE [KDSP]
GO
/****** Object:  Table [dbo].[TherapyCharges]    Script Date: 9/19/2021 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TherapyCharges](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Therapy] [char](2) NULL,
	[Charges] [int] NULL,
	[Status] [varchar](50) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[DateCreated] [datetime] NULL,
 CONSTRAINT [PK_TherapyCharges] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TherapyCharges] ADD  CONSTRAINT [DF_TherapyCharges_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
