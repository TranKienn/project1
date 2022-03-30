USE QLTTDL
GO

--Thủ tục get danh sách danh mục
CREATE PROC sp_SelectDanhMuc
AS
BEGIN
	SELECT MaDanhMuc, TenDanhMuc FROM DanhMuc
END

GO

--Thủ tục thêm mới danh sách danh mục
CREATE PROC  sp_InsertDanhMuc
(
	@MaDanhMuc VARCHAR(10),
	@TenDanhMuc NVARCHAR(50)
)
AS
BEGIN
	IF EXISTS (SELECT * FROM DanhMuc WHERE MaDanhMuc = @MaDanhMuc)
		BEGIN
			PRINT N'Mã danh mục đã tồn tại'
		END
	ELSE
		BEGIN
			INSERT INTO DanhMuc VALUES(@MaDanhMuc, @TenDanhMuc)
		END
END
GO

CREATE PROC sp_UpdateDanhMuc
(
	@MaDanhMuc VARCHAR(10),
	@TenDanhMuc NVARCHAR(50)
)
AS
BEGIN
	UPDATE DanhMuc
	SET TenDanhMuc = @TenDanhMuc
	WHERE MaDanhMuc = @MaDanhMuc
END
GO
--Thủ tục xóa danh sách danh mục
CREATE PROC sp_DeleteDanhMuc
(
	@MaDanhMuc VARCHAR(10)
)
AS
BEGIN
	DELETE FROM DanhMuc
	WHERE MaDanhMuc = @MaDanhMuc
END

GO

--Thủ tục get danh sách thông tin du lịch
CREATE PROC sp_SelectTTDuLich
AS
BEGIN
	SELECT MaTTDL, MaDiemDL, DiemXuatPhat, NgayKhoiHanh, PhuongTien, Gia FROM TTDuLich
END

GO

--Thủ tục thêm mới danh sách danh mục
CREATE PROC  sp_InsertTTDuLich
(
	@MaTTDL VARCHAR(10),
	@MaDiemDL VARCHAR(10),
	@DiemXuatPhat VARCHAR(10),
	@NgayKhoiHanh DATETIME,
	@PhuongTien NVARCHAR(100),
	@Gia NVARCHAR(50)
)
AS
BEGIN
	IF EXISTS (SELECT * FROM TTDuLich WHERE MaTTDL = @MaTTDL)
		BEGIN
			PRINT N'Mã thông tin du lịch đã tồn tại'
		END
	ELSE
		BEGIN
			INSERT INTO TTDuLich VALUES(@MaTTDL, @MaDiemDL, @DiemXuatPhat, @NgayKhoiHanh, @PhuongTien, @Gia)
		END
END
GO

CREATE PROC sp_UpdateTTDuLich
(
	@MaTTDL VARCHAR(10),
	@MaDiemDL VARCHAR(10),
	@DiemXuatPhat VARCHAR(10),
	@NgayKhoiHanh DATETIME,
	@PhuongTien NVARCHAR(100),
	@Gia NVARCHAR(50)
)
AS
BEGIN
	UPDATE TTDuLich
	SET	 MaDiemDL = @MaDiemDL,
		 DiemXuatPhat = @DiemXuatPhat,
		 NgayKhoiHanh = @NgayKhoiHanh,
		 PhuongTien = @PhuongTien,
		 Gia =@Gia
	WHERE MaTTDL = @MaTTDL
END
GO
--Thủ tục xóa danh sách danh mục
CREATE PROC sp_DeleteTTDuLich
(
	@MaTTDL VARCHAR(10),
	@MaDiemDL VARCHAR(10),
	@DiemXuatPhat VARCHAR(10),
	@NgayKhoiHanh DATETIME,
	@PhuongTien NVARCHAR(100),
	@Gia NVARCHAR(50)
)
AS
BEGIN
	DELETE FROM TTDuLich
	WHERE MaTTDL = @MaTTDL
END


--Thủ tục get danh sách điểm du lịch
GO
CREATE PROC sp_SelectDiemDuLich
AS
BEGIN
	SELECT MaDiemDL, TenDiemDL, MaDanhMuc  FROM DiemDuLich
END

GO
--Thủ tục thêm mới danh sách danh mục
CREATE PROC  sp_InsertDiemDuLich
(
	@MaDiemDL VARCHAR(10),
	@TenDiemDL NVARCHAR(100),
	@MaDanhMuc VARCHAR(10)
)
AS
BEGIN
	IF EXISTS (SELECT * FROM DiemDuLich WHERE MaDiemDL = @MaDiemDL)
		BEGIN
			PRINT N'Mã điểm du lịch đã tồn tại'
		END
	ELSE
		BEGIN
			INSERT INTO DiemDuLich VALUES(@MaDiemDL, @TenDiemDL, @MaDanhMuc)
		END
END
GO

CREATE PROC sp_UpdateDiemDuLich
(
	@MaDiemDL VARCHAR(10),
	@TenDiemDL NVARCHAR(100),
	@MaDanhMuc VARCHAR(10)
)
AS
BEGIN
	UPDATE DiemDuLich
	SET	 MaDiemDL = @MaDiemDL,
		 TenDiemDL = @TenDiemDL,
		 MaDanhMuc = @MaDanhMuc
	WHERE MaDiemDL = @MaDiemDL
END
GO
--Thủ tục xóa danh sách danh mục
CREATE PROC sp_DeleteDiemDuLich
(
	@MaDiemDL VARCHAR(10)
)
AS
BEGIN
	DELETE FROM DiemDuLich
	WHERE MaDiemDL = @MaDiemDL
END

GO
--Thủ tục get danh sách user
CREATE PROC sp_SelectUser
AS
BEGIN
	SELECT UserID, UserName, Password, FullName, Email, Phone, DateOfBirth FROM [User]
END

GO

--Thủ tục thêm mới danh sách danh mục
CREATE PROC  sp_InsertUser
(
	@UserID VARCHAR(10),
	@UserName VARCHAR(100),
	@Password VARCHAR(100),
	@FullName NVARCHAR(100),
	@Email VARCHAR (100),
	@Phone VARCHAR (10),
	@DateOfBirth DATE
)
AS
BEGIN
	IF EXISTS (SELECT * FROM [User] WHERE UserID = @UserID)
		BEGIN
			PRINT N'Mã UserID đã tồn tại'
		END
	ELSE
		BEGIN
			INSERT INTO [User] VALUES(@UserID, @UserName, @Password, @FullName, @Email, @Phone, @DateOfBirth)
		END
END
GO

CREATE PROC sp_UpdateUser
(
	@UserID VARCHAR(10),
	@UserName VARCHAR(100),
	@Password VARCHAR(100),
	@FullName NVARCHAR(100),
	@Email VARCHAR (100),
	@Phone VARCHAR (10),
	@DateOfBirth DATE
)
AS
BEGIN
	UPDATE [User]
	SET UserID = @UserID,
		UserName = @UserName,
		Password = @Password,
		FullName = @FullName,
		Email = @Email,
		Phone = @Phone,
		DateOfBirth = @DateOfBirth
	WHERE UserID = @UserID
END
GO
--Thủ tục xóa danh sách danh mục
CREATE PROC sp_DeleteUser
(
	@UserID VARCHAR(10),
	@UserName VARCHAR(100),
	@Password VARCHAR(100),
	@FullName NVARCHAR(100),
	@Email VARCHAR (100),
	@Phone VARCHAR (10),
	@DateOfBirth DATE
)
AS
BEGIN
	DELETE FROM [User]
	WHERE UserID = @UserID
END
--Thủ tục login
GO
CREATE PROC sp_DangNhap
(
	@UserName VARCHAR(100),
	@Password VARCHAR(100)
)
AS
BEGIN
	SELECT UserID, UserName, Password, FullName, Email, Phone, DateOfBirth FROM [User]
	WHERE UserName = @UserName
		AND Password = @Password
END