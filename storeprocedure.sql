USE [master]
GO
/****** Object:  Database [UnicatCore]    Script Date: 02-09-2024 02:33:18 ******/
CREATE DATABASE [UnicatCore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UnicatCore', FILENAME = N'C:\Users\USER\UnicatCore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UnicatCore_log', FILENAME = N'C:\Users\USER\UnicatCore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [UnicatCore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UnicatCore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UnicatCore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UnicatCore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UnicatCore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UnicatCore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UnicatCore] SET ARITHABORT OFF 
GO
ALTER DATABASE [UnicatCore] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [UnicatCore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UnicatCore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UnicatCore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UnicatCore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UnicatCore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UnicatCore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UnicatCore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UnicatCore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UnicatCore] SET  ENABLE_BROKER 
GO
ALTER DATABASE [UnicatCore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UnicatCore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UnicatCore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UnicatCore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UnicatCore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UnicatCore] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [UnicatCore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UnicatCore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UnicatCore] SET  MULTI_USER 
GO
ALTER DATABASE [UnicatCore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UnicatCore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UnicatCore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UnicatCore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UnicatCore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UnicatCore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [UnicatCore] SET QUERY_STORE = OFF
GO
USE [UnicatCore]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[CourseImage] [nvarchar](max) NOT NULL,
	[CourseName] [nvarchar](max) NOT NULL,
	[CourseDescription] [nvarchar](max) NOT NULL,
	[CourseTeacherName] [nvarchar](max) NOT NULL,
	[CoursePrice] [float] NOT NULL,
	[StudentCount] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[SubCategoryId] [int] NOT NULL,
	[ReviewId] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[Amount] [float] NOT NULL,
	[CourseId] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[ExpiryDate] [date] NOT NULL,
	[PaymentOrderId] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubCategories]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategories](
	[SubCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[SubCategoryName] [nvarchar](max) NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_SubCategories] PRIMARY KEY CLUSTERED 
(
	[SubCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Urole] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Videos]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Videos](
	[VideoId] [int] IDENTITY(1,1) NOT NULL,
	[CourseId] [int] NOT NULL,
	[VideoTitle] [nvarchar](max) NOT NULL,
	[VideoLink] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Videos] PRIMARY KEY CLUSTERED 
(
	[VideoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Courses] ADD  DEFAULT ((0)) FOR [ReviewId]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (N'') FOR [PaymentOrderId]
GO
/****** Object:  StoredProcedure [dbo].[AddOrder]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddOrder]
@Username varchar(100),
@amount decimal(10,2),
@courseid int,
@orderdate date,
@expirydate date,
@paymentorderid varchar(100)
as
begin
	 insert into orders values (@Username,@amount,@courseid,@orderdate,@expirydate,@paymentorderid)
END
GO
/****** Object:  StoredProcedure [dbo].[AddSubCategory]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[AddSubCategory]
  @SubcategoryName varchar(100),
  @CategoryId int
  as
  begin
	Insert SubCategories values(@SubcategoryName,@CategoryId);
end
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddUser] 
@Username varchar(100),
@Email varchar(100),
@Password varchar(100),
@Urole varchar(100)
as
begin
	insert users (Username,Email,Password,Urole) values (@Username,@Email,@Password,@Urole);
end
GO
/****** Object:  StoredProcedure [dbo].[AddVideo]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddVideo]
@courseid int,
@videotitle varchar(100),
@videolink varchar(100)
as
begin
	Insert into Videos values (@courseid,@videotitle,@videolink);
end
GO
/****** Object:  StoredProcedure [dbo].[AuthUser]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AuthUser]
@Username varchar(100),
@Password varchar(100)
as
begin
	select * from Users where Username = @Username and Password = @Password;
end
GO
/****** Object:  StoredProcedure [dbo].[DisplaySingleCourse]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[DisplaySingleCourse]
@Id int
as
begin
	select * from Courses where CourseId = @Id;
	
end
GO
/****** Object:  StoredProcedure [dbo].[DisplaySubCategory]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DisplaySubCategory]
@id int
as
begin
	select * from SubCategories where CategoryId = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[fetchCourse]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[fetchCourse]
@subcategoryid int
as
begin
	select * from Courses where SubCategoryId=@subcategoryid;
end
GO
/****** Object:  StoredProcedure [dbo].[FetchCourses]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[FetchCourses]
as
begin
	select * from Courses;
end
GO
/****** Object:  StoredProcedure [dbo].[FetchMyCourses]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FetchMyCourses]
@username varchar(100)
as
begin
	select c.CourseId,c.CourseImage,c.CourseName,c.CourseDescription,c.CourseTeacherName,c.CoursePrice,c.StudentCount,c.CategoryId,c.SubCategoryId,c.ReviewId from Courses c
	Inner Join Orders o on c.CourseId = o.CourseId
	where o.Username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[GetCategory]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetCategory]
as
begin
	select * from Categories;
end
GO
/****** Object:  StoredProcedure [dbo].[GetVideoByCourseId]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetVideoByCourseId]
@courseid int
as
begin
 select * from Videos where CourseId = @courseid;
end
GO
/****** Object:  StoredProcedure [dbo].[InsertCategory]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertCategory]
@categoryName varchar(100)
as
begin
	Insert Categories values(@categoryName)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertCourse]    Script Date: 02-09-2024 02:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertCourse]
@CourseImage varchar(100),
@courseName varchar(100),
@couseDesc varchar(100),
@teachername varchar(100),
@price decimal(10,2),
@studentcount int,
@categoryid int,
@subcategoryid int
as
begin
	Insert into Courses values(@CourseImage,@courseName,@couseDesc,@teachername,@price,@studentcount,@categoryid,@subcategoryid);
end
GO
USE [master]
GO
ALTER DATABASE [UnicatCore] SET  READ_WRITE 
GO
