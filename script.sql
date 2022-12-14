USE [master]
GO
/****** Object:  Database [students]    Script Date: 15/12/2022 21:16:50 ******/
CREATE DATABASE [students]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'students', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\students.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'students_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\students_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [students] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [students].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [students] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [students] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [students] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [students] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [students] SET ARITHABORT OFF 
GO
ALTER DATABASE [students] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [students] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [students] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [students] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [students] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [students] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [students] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [students] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [students] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [students] SET  DISABLE_BROKER 
GO
ALTER DATABASE [students] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [students] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [students] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [students] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [students] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [students] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [students] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [students] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [students] SET  MULTI_USER 
GO
ALTER DATABASE [students] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [students] SET DB_CHAINING OFF 
GO
ALTER DATABASE [students] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [students] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [students] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [students] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [students] SET QUERY_STORE = ON
GO
ALTER DATABASE [students] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [students]
GO
/****** Object:  Table [dbo].[attendancy]    Script Date: 15/12/2022 21:16:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[attendancy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EnterTime] [time](7) NOT NULL,
	[ExitTime] [time](7) NULL,
	[Date] [date] NOT NULL,
	[UserId] [int] NOT NULL,
	[LessonId] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_attendancy] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[course]    Script Date: 15/12/2022 21:16:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[course](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[TeacherId] [int] NOT NULL,
 CONSTRAINT [PK_course] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lesson]    Script Date: 15/12/2022 21:16:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lesson](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_lesson] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_to_course]    Script Date: 15/12/2022 21:16:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_to_course](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_student_to_course] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 15/12/2022 21:16:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](12) NULL,
	[Email] [nvarchar](50) NULL,
	[Type] [int] NOT NULL,
	[Active] [bit] NULL,
	[Password] [nvarchar](20) NOT NULL,
	[UserName] [nvarchar](20) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([Id], [Name], [Phone], [Email], [Type], [Active], [Password], [UserName]) VALUES (1, N'sara', N'0556783732', N'sara5780272@gmail.com', 1, 1, N'123456', N'sarit')
INSERT [dbo].[user] ([Id], [Name], [Phone], [Email], [Type], [Active], [Password], [UserName]) VALUES (2, N'aaaa', N'0556789321', N'sara@gmail.com', 0, NULL, N'1qaz', NULL)
INSERT [dbo].[user] ([Id], [Name], [Phone], [Email], [Type], [Active], [Password], [UserName]) VALUES (3, N'aaaa', N'025', N'sara@gm', 0, NULL, N'789', NULL)
SET IDENTITY_INSERT [dbo].[user] OFF
GO
ALTER TABLE [dbo].[attendancy]  WITH CHECK ADD  CONSTRAINT [FK_attendancy_lesson] FOREIGN KEY([LessonId])
REFERENCES [dbo].[lesson] ([Id])
GO
ALTER TABLE [dbo].[attendancy] CHECK CONSTRAINT [FK_attendancy_lesson]
GO
ALTER TABLE [dbo].[attendancy]  WITH CHECK ADD  CONSTRAINT [FK_attendancy_user] FOREIGN KEY([UserId])
REFERENCES [dbo].[user] ([Id])
GO
ALTER TABLE [dbo].[attendancy] CHECK CONSTRAINT [FK_attendancy_user]
GO
ALTER TABLE [dbo].[course]  WITH CHECK ADD  CONSTRAINT [FK_course_user] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[user] ([Id])
GO
ALTER TABLE [dbo].[course] CHECK CONSTRAINT [FK_course_user]
GO
ALTER TABLE [dbo].[lesson]  WITH CHECK ADD  CONSTRAINT [FK_lesson_course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[course] ([Id])
GO
ALTER TABLE [dbo].[lesson] CHECK CONSTRAINT [FK_lesson_course]
GO
ALTER TABLE [dbo].[student_to_course]  WITH CHECK ADD  CONSTRAINT [FK_student_to_course_course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[course] ([Id])
GO
ALTER TABLE [dbo].[student_to_course] CHECK CONSTRAINT [FK_student_to_course_course]
GO
ALTER TABLE [dbo].[student_to_course]  WITH CHECK ADD  CONSTRAINT [FK_student_to_course_user] FOREIGN KEY([UserId])
REFERENCES [dbo].[user] ([Id])
GO
ALTER TABLE [dbo].[student_to_course] CHECK CONSTRAINT [FK_student_to_course_user]
GO
USE [master]
GO
ALTER DATABASE [students] SET  READ_WRITE 
GO
