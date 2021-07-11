# StudentManagement2

Bài tập C# WinForms Tạo ứng dụng Quản lý Sinh viên

## Hướng dẫn

1. Tạo CSDL

```
CREATE DATABASE [StudentManagement];
GO
```

2. Tạo Bảng

```
USE [StudentManagement]
GO

/****** Object:  Table [dbo].[Students]    Script Date: 7/11/2021 7:41:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Students](
	[StudentID] [varchar](45) NULL,
	[StudentName] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[AvgScore] [decimal](10, 2) NULL,
	[ClassID] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF_Students_CreateAt]  DEFAULT (sysdatetime()) FOR [CreatedAt]
GO
```

3. Sửa Cấu hình kết nối SQL Server

- Mở file **App.config** thay đổi Server name (_ANHNBT\SQLEXPRESS_), UID (_anhnbt_) và Password (_KhoaiTay@2019_)

4. Chạy Project
