USE [Library]
GO
/****** Object:  Table [dbo].[Session]    Script Date: 07/01/2016 08:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Session](
	[SessionId] [int] IDENTITY(1,1) NOT NULL,
	[SessionName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Session] PRIMARY KEY CLUSTERED 
(
	[SessionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Login]    Script Date: 07/01/2016 08:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[LastLoginTime] [datetime] NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Department]    Script Date: 07/01/2016 08:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentShortName] [varchar](50) NULL,
	[DepartmentFullName] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Book]    Script Date: 07/01/2016 08:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[Subject] [varchar](50) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Author] [varchar](50) NOT NULL,
	[Publisher] [varchar](50) NOT NULL,
	[Edition] [int] NOT NULL,
	[Pages] [int] NOT NULL,
	[Isbn] [varchar](50) NOT NULL,
	[NumberOfBooks] [int] NOT NULL,
	[Library] [varchar](50) NOT NULL,
	[ShelfNo] [int] NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 07/01/2016 08:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [varchar](70) NOT NULL,
	[Name] [varchar](59) NOT NULL,
	[LibrayCardNo] [varchar](59) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[SessionId] [int] NOT NULL,
	[Image] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Borrow]    Script Date: 07/01/2016 08:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrow](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[DayOfBorrowed] [date] NOT NULL,
	[DayOfReturn] [date] NOT NULL,
	[BookId] [int] NOT NULL,
	[DepartmentId] [int] NULL,
 CONSTRAINT [PK_Borrow] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_BorrowInformation]    Script Date: 07/01/2016 08:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc
[dbo].[sp_BorrowInformation]
as

Select Id,StudentId,DepartmentFullName,Isbn,DayOfBorrowed,DayOfReturn from Borrow join Department on Borrow.DepartmentId=Department.DepartmentId join Book on Borrow.BookId=Book.BookId   order by Id
GO
/****** Object:  View [dbo].[BookIssueDetailsView]    Script Date: 07/01/2016 08:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[BookIssueDetailsView]
AS
select s.StudentId,Name,DepartmentFullName,SessionName,LibrayCardNo,Title,Isbn,DayOfBorrowed,DayOfReturn from dbo.Borrow br
join dbo.Student s on br.StudentId=s.Id 
join dbo.Department d on s.DepartmentId=d.DepartmentId
join dbo.Session ss on s.SessionId=ss.SessionId
join dbo.Book b on br.BookId=b.BookId
GO
/****** Object:  View [dbo].[BookDetails_View]    Script Date: 07/01/2016 08:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[BookDetails_View]
AS
select b.BookId,Title,Author,Publisher,Edition,Isbn,Pages,ShelfNo,NumberOfBooks as Total,NumberOfBooks-COUNT(br.BookId) as Available from Borrow br join Book b on br.BookId=b.BookId

 group by br.BookId,Isbn,Title,NumberOfBooks,Author,Edition,Pages,ShelfNo,b.BookId,Publisher
GO
/****** Object:  ForeignKey [FK_Book_Book]    Script Date: 07/01/2016 08:55:25 ******/
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Book] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Book]
GO
/****** Object:  ForeignKey [FK_Borrow_Book]    Script Date: 07/01/2016 08:55:25 ******/
ALTER TABLE [dbo].[Borrow]  WITH CHECK ADD  CONSTRAINT [FK_Borrow_Book] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
GO
ALTER TABLE [dbo].[Borrow] CHECK CONSTRAINT [FK_Borrow_Book]
GO
/****** Object:  ForeignKey [FK_Borrow_Department]    Script Date: 07/01/2016 08:55:25 ******/
ALTER TABLE [dbo].[Borrow]  WITH CHECK ADD  CONSTRAINT [FK_Borrow_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([DepartmentId])
GO
ALTER TABLE [dbo].[Borrow] CHECK CONSTRAINT [FK_Borrow_Department]
GO
/****** Object:  ForeignKey [FK_Borrow_Student]    Script Date: 07/01/2016 08:55:25 ******/
ALTER TABLE [dbo].[Borrow]  WITH CHECK ADD  CONSTRAINT [FK_Borrow_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[Borrow] CHECK CONSTRAINT [FK_Borrow_Student]
GO
/****** Object:  ForeignKey [FK_Student_Department]    Script Date: 07/01/2016 08:55:25 ******/
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([DepartmentId])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Department]
GO
/****** Object:  ForeignKey [FK_Student_Session]    Script Date: 07/01/2016 08:55:25 ******/
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Session] FOREIGN KEY([SessionId])
REFERENCES [dbo].[Session] ([SessionId])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Session]
GO
