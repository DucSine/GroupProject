﻿-- Author: Sine
-- Create date: 03/11/2020.
-- Purpose: restore Database when something goes wrong.
-- Note: do not modify the structure of the tables.
 

CREATE TABLE [dbo].[Account] (
    [Acc_Username] NVARCHAR (15) NOT NULL,
    [Acc_Password] NVARCHAR (15) NOT NULL,
    PRIMARY KEY CLUSTERED ([Acc_Username] ASC)
);
CREATE TABLE [dbo].[Staff] (
    [st_ID]     NVARCHAR (50)  NOT NULL,
    [st_Name]   NVARCHAR (50)  NOT NULL,
    [st_Image]  NVARCHAR (50)  NOT NULL,
    [st_Sex]    BIT            NOT NULL,
    [st_Bday]   DATETIME       NULL,
    [st_Phone]  NVARCHAR (15)  NOT NULL,
    [st_Adress] NVARCHAR (100) NOT NULL,
    [st_Local]  NVARCHAR (30)  NOT NULL,
    [st_Salary] FLOAT (53)     NOT NULL,
    PRIMARY KEY CLUSTERED ([st_ID] ASC)
);
CREATE TABLE [dbo].[KindOfGoods] (
    [kog_ID]   NVARCHAR (50) NOT NULL,
    [kog_Name] NVARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([kog_ID] ASC)
);
CREATE TABLE [dbo].[Goods] (
    [g_ID]         NVARCHAR (50) NOT NULL,
    [kog_ID]       NVARCHAR (50) NOT NULL,
    [g_Name]       NVARCHAR (30) NOT NULL,
    [g_Image]      NVARCHAR (50) NULL,
    [g_Caption]    NVARCHAR (20) NULL,
    [g_DateImport] DATETIME      NULL,
    [g_Amount]     INT           NOT NULL,
    [g_Unit]       NVARCHAR (20) NOT NULL,
    [g_Cost]       FLOAT (53)    NOT NULL,
    [g_Price]      FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([g_ID] ASC),
    FOREIGN KEY ([kog_ID]) REFERENCES [dbo].[KindOfGoods] ([kog_ID])
);
CREATE TABLE [dbo].[Bill] (
    [b_ID]        NVARCHAR (50) NOT NULL,
    [b_TimeOrder] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([b_ID] ASC)
);
CREATE TABLE [dbo].[BillDetail] (
    [b_ID]        NVARCHAR (50) NOT NULL,
    [g_ID]        NVARCHAR (50) NOT NULL,
    [bd_Amount]   INT           NOT NULL,
    [bd_Discount] FLOAT (53)    NOT NULL,
    CONSTRAINT [pk1] PRIMARY KEY CLUSTERED ([b_ID] ASC, [g_ID] ASC),
    FOREIGN KEY ([b_ID]) REFERENCES [dbo].[Bill] ([b_ID]),
    FOREIGN KEY ([g_ID]) REFERENCES [dbo].[Goods] ([g_ID])
);

-------------------------------------------------------------------------------------------------------
GO
create proc spCheckLogin
@Acc_Username nvarchar(15),
@Acc_Password nvarchar(15)
as
begin 
	select * from Account where Acc_Username = @Acc_Username and Acc_Password = @Acc_Password
end

GO
create proc spGetStaff
as
begin
	select * from Staff
end
GO

create proc spAddStaff
@st_ID NVARCHAR(50),
@st_Name   NVARCHAR (50),
@st_Image  NVARCHAR (50),
@st_Sex    BIT,
@st_Bday  DATETIME,
@st_Phone  NVARCHAR (15),
@st_Adress NVARCHAR (100),
@st_Local  NVARCHAR (30),
@st_Salary FLOAT
as
begin
	insert into Staff
	values(@st_ID, @st_Name , @st_Image, @st_Sex ,@st_Bday, @st_Phone, @st_Adress, @st_Local, @st_Salary)
end

GO
create proc spUpdateStaff
@st_ID NVARCHAR(50),
@st_Name   NVARCHAR (50),
@st_Image  NVARCHAR (50),
@st_Sex    BIT,
@st_Bday  DATETIME,
@st_Phone  NVARCHAR (15),
@st_Adress NVARCHAR (100),
@st_Local  NVARCHAR (30),
@st_Salary FLOAT
as
begin
	Update Staff
	set st_Name = @st_Name,
		st_Image = @st_Image,
		st_Sex = @st_Sex,
		st_Bday = @st_Bday, 
		st_Phone = @st_Phone,
		st_Adress = @st_Adress,
		st_Local = @st_Local,
		st_Salary = @st_Salary
	where st_ID = @st_ID

end

GO
create proc spDeleteStaff
@st_ID NVARCHAR(50)
as 
begin
	DELETE FROM Staff
	WHERE st_ID = @st_ID
end

GO
create proc spGetKindOfGoods
@type       NVARCHAR (50)
as
begin
	if(@type = 'material')
	begin
		select * from KindOfGoods
		except
		select * from KindOfGoods where kog_ID like '%B%'
	end
	else
		select * from KindOfGoods where kog_ID like '%B%'
end

GO
create proc spAddKindOfGoods
@kog_ID   NVARCHAR (50),
@kog_Name NVARCHAR (30)
as
begin
    insert into KindOfGoods
	values(@kog_ID, @kog_Name)
end

GO
create proc spUpdateKindOfGoods
@kog_ID   NVARCHAR (50),
@kog_Name NVARCHAR (30)
as
begin 
    Update KindOfGoods
	set kog_Name = @kog_Name
    where kog_ID = @kog_ID 
end

GO
create proc spDeleteKindOfGoods
@kog_ID   NVARCHAR (50)
as
begin 
    Delete from Goods
    where kog_ID = @kog_ID
    ----------------------
    Delete from KindOfGoods
    where kog_ID = @kog_ID
end

GO
create proc spGetGoods 
@kog_ID       NVARCHAR (50)
as
begin
	select * from Goods where kog_ID = @kog_ID
end
GO
GO
create proc spAddGoods
@g_ID         NVARCHAR (50),
@kog_ID       NVARCHAR (50),
@g_Name       NVARCHAR (30),
@g_Image      NVARCHAR (50),
@g_Caption    NVARCHAR (20),
@g_DateImport DATETIME,
@g_Amount     INT,
@g_Unit       NVARCHAR (20),
@g_Cost       FLOAT,
@g_Price      FLOAT
as
begin 
    Insert into Goods 
    values (@g_ID, @kog_ID, @g_Name, @g_Image, @g_Caption, @g_DateImport, @g_Amount, @g_Unit, @g_Cost, @g_Price )
end

GO
create proc spUpdateGoods
@g_ID         NVARCHAR (50),
@kog_ID       NVARCHAR (50),
@g_Name       NVARCHAR (30),
@g_Image      NVARCHAR (50),
@g_Caption    NVARCHAR (20),
@g_DateImport DATETIME,
@g_Amount     INT,
@g_Unit       NVARCHAR (20),
@g_Cost       FLOAT,
@g_Price      FLOAT
as
begin 
    Update Goods
    set kog_ID = @kog_ID,
        g_Name = @g_Name,
        g_Image = @g_Image,
        g_Caption = @g_Caption,
        g_DateImport = @g_DateImport,
        g_Amount = @g_Amount,
        g_Unit = @g_Unit,
        g_Cost = @g_Cost,
        g_Price = @g_Price
    where g_ID = @g_ID
end

GO
create proc spDeleteGoods
@g_ID         NVARCHAR (50)
as
begin 
    delete from Goods
    where g_ID = @g_ID
end

GO
create proc spFindStaff
@st_Name nvarchar(50)
as
begin
select * from Staff
where st_Name like @st_Name  
end

GO
create proc spFindKindOfGoods
@kog_Name nvarchar(50)
as
begin
select * from KindOfGoods
where kog_Name = @kog_Name  
end

GO
create proc spFindGoods
@g_Name nvarchar(50)
as
begin
select * from Goods
where g_Name like @g_Name  
end

GO
create proc spGetBillOut
as
begin
	select b.b_ID, b.b_TimeOrder, sum(bd_Amount * g_Price) as tt_Price
	from Bill b, BillDetail bd, Goods g
	where b.b_ID = bd.b_ID and bd.g_ID = g.g_ID and g_Cost = 0
	group by b.b_ID, b.b_TimeOrder
end

Go
create proc spGetBillIn
as
begin
	select b.b_ID, b.b_TimeOrder, sum(bd_Amount * g_Cost) as tt_Price
	from Bill b, BillDetail bd, Goods g
	where b.b_ID = bd.b_ID and bd.g_ID = g.g_ID and g_Price =0
	group by b.b_ID, b.b_TimeOrder
end

GO
create proc spGetBillDetail
@b_ID nvarchar(50)
as
begin
	select b.b_ID, b_TimeOrder, g_Name, bd_Amount, g_Unit ,(case when g_Cost <>0  then (bd_Amount * g_Cost)
																 when g_Price <> 0  then (bd_Amount * g_Price)
																 End ) as tt_Pay
	from Bill b, BillDetail bd, Goods g
	where b.b_ID = bd.b_ID and bd.g_ID = g.g_ID and b.b_ID = @b_ID
end
GO
--

INSERT INTO [dbo].[Account] ([Acc_Username], [Acc_Password]) VALUES (N'Admin', N'duc123')
INSERT INTO [dbo].[Staff] ([st_ID], [st_Name], [st_Image], [st_Sex], [st_Bday], [st_Phone], [st_Adress], [st_Local], [st_Salary]) VALUES (N'sv001', N'Đức', N'avatar.png', 1, N'1997-10-23 00:00:00', N'0311451512', N'Quảng Trị', N'Nhân viên bán hàng', 500)
INSERT INTO [dbo].[Staff] ([st_ID], [st_Name], [st_Image], [st_Sex], [st_Bday], [st_Phone], [st_Adress], [st_Local], [st_Salary]) VALUES (N'sv002', N'Nam', N'avatar.png', 1, N'1999-10-10 00:00:00', N'0326546589', N'Nghệ An', N'Đầu bếp', 800)
INSERT INTO [dbo].[Staff] ([st_ID], [st_Name], [st_Image], [st_Sex], [st_Bday], [st_Phone], [st_Adress], [st_Local], [st_Salary]) VALUES (N'sv003', N'Phong', N'avatar.png', 1, N'1999-10-10 00:00:00', N'0352498721', N'Quảng Ngãi', N'Nhân viên giao hàng', 500)
INSERT INTO [dbo].[KindOfGoods] ([kog_ID], [kog_Name]) VALUES (N'B001', N'Bánh mỳ')
INSERT INTO [dbo].[KindOfGoods] ([kog_ID], [kog_Name]) VALUES (N'B002', N'Bánh ngọt')
INSERT INTO [dbo].[KindOfGoods] ([kog_ID], [kog_Name]) VALUES (N'B003', N'Bánh gato')
INSERT INTO [dbo].[KindOfGoods] ([kog_ID], [kog_Name]) VALUES (N'NL001', N'Nguyên liệu thô')
INSERT INTO [dbo].[KindOfGoods] ([kog_ID], [kog_Name]) VALUES (N'NL002', N'Gia vị')
INSERT INTO [dbo].[KindOfGoods] ([kog_ID], [kog_Name]) VALUES (N'P001', N'Công cụ')
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g001', N'NL001', N'Bột mỳ', NULL, N'Bao 50kg', N'2020-10-10 00:00:00', 20, N'Bao', 400000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g002', N'NL001', N'Bơ', NULL, N'Hộp 200g', N'2020-10-10 00:00:00', 200, N'Hộp', 10000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g003', N'NL001', N'Cacao', NULL, N'Bao 1Kg', N'2020-10-10 00:00:00', 100, N'Bao', 120000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g004', N'NL001', N'Sữa tươi Vinamilk', NULL, N'Hộp 1 lít', N'2020-10-10 00:00:00', 100, N'Hộp', 50000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g005', N'NL001', N'Sữa đặc Vinamilk', NULL, N'Hộp 380ml', N'2020-10-10 00:00:00', 100, N'Hộp', 17000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g006', N'NL001', N'Trứng gà', NULL, N'Khay 50 quả', N'2020-10-10 00:00:00', 50, N'Khay', 60000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g007', N'NL001', N'Nho', NULL, N'Nho tím', N'2020-10-10 00:00:00', 20, N'kg', 100000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g008', N'NL001', N'Nho', NULL, N'Nho xanh', N'2020-10-10 00:00:00', 20, N'kg', 100000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g009', N'NL001', N'Dâu Tây', NULL, NULL, N'2020-10-10 00:00:00', 20, N'kg', 300000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g010', N'NL001', N'Dâu Tằm', NULL, NULL, N'2020-10-10 00:00:00', 10, N'kg', 100000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g011', N'NL001', N'Xoài', NULL, NULL, N'2020-10-10 00:00:00', 20, N'kg', 40000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g012', N'NL001', N'Chuối', NULL, NULL, N'2020-10-10 00:00:00', 20, N'kg', 50000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g013', N'NL001', N'Khoai Lang', NULL, NULL, N'2020-10-10 00:00:00', 50, N'kg', 12000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g014', N'NL001', N'Dưa Leo', NULL, NULL, N'2020-10-10 00:00:00', 20, N'kg', 10000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g015', N'NL001', N'Rau Xà Lách', NULL, N'Đặt theo ngày', N'2020-10-10 00:00:00', 3, N'kg', 30000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g016', N'NL001', N'Rau màu', NULL, N'(Mùi, húng quế,..)', N'2020-10-10 00:00:00', 3, N'kg', 30000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g017', N'NL002', N'Đường', NULL, N'Bao 50kg', N'2020-10-10 00:00:00', 20, N'Bao', 550000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g018', N'NL002', N'Muối', NULL, N'Bao 500g', N'2020-10-10 00:00:00', 100, N'Bao', 2000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g019', N'NL002', N'Mỳ chính', NULL, N'Thùng 20kg', N'2020-10-10 00:00:00', 10, N'Thùng', 700000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g020', N'NL002', N'Hạt Tiêu', NULL, N'Gói 1kg', N'2020-10-10 00:00:00', 10, N'Gói', 200000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g021', N'NL002', N'Sốt Mazone', NULL, N'Thùng 24 chai', N'2020-10-10 00:00:00', 20, N'Thùng', 400000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g022', N'NL002', N'Tương ớt', NULL, N'Can 5 lít', N'2020-10-10 00:00:00', 20, N'Can', 100000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g023', N'NL002', N'Tương cà', NULL, N'Can 5 lít', N'2020-10-10 00:00:00', 20, N'Can', 150000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g024', N'NL002', N'Nước mắm', NULL, N'Thùng 20 chai', N'2020-10-10 00:00:00', 10, N'Thùng', 500000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g025', N'P001', N'Nước rửa tay', NULL, N'Thùng 20 chai', N'2020-10-10 00:00:00', 1, N'Thùng', 400000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g026', N'P001', N'Nước lau kính', NULL, N'Thùng 24 chai', N'2020-10-10 00:00:00', 1, N'Thùng', 350000, 0)
INSERT INTO [dbo].[Goods] ([g_ID], [kog_ID], [g_Name], [g_Image], [g_Caption], [g_DateImport], [g_Amount], [g_Unit], [g_Cost], [g_Price]) VALUES (N'g027', N'B001', N'Bánh mỳ', NULL, NULL, NULL, 1000, N'Cái', 0, 10000)
