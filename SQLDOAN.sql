Create DATABASE Coffee_Management
CREATE TABLE Menu
(
	id_category int primary key,
	name_category  nvarchar(100) NOT NULL DEFAULT ('(Chưa đặt tên)')
);

CREATE TABLE Item
(
	id_item nvarchar(4) primary key,
	id_category int FOREIGN KEY REFERENCES Menu(id_category),
	name nvarchar(100) NOT NULL,
	price int NOT NULL,
	photo image
);
CREATE TABLE Ban
(
	id_table int primary key
);
CREATE TABLE Account
(
	username nvarchar(100) primary key,
	pass nvarchar (100) not null,
	_admin int,
);
CREATE TABLE Staff
(
	id_staff int identity primary key,
	name_staff nvarchar (100) NOT NULL DEFAULT ('(Chưa đặt tên)'),
	position nvarchar (100) NOT NULL, 
	username nvarchar(100) NOT NULL 
	CONSTRAINT FK_username FOREIGN KEY (username) REFERENCES Account (username)
);
CREATE TABLE Bill
(
	id_bill int, 
	id_staff int FOREIGN KEY (id_staff) REFERENCES Staff(id_staff),
	id_table int FOREIGN KEY (id_table) REFERENCES Ban(id_table),
	id_item nvarchar(4) FOREIGN KEY (id_item) REFERENCES Item(id_item),
	count int NOT NULL DEFAULT 0,
	price int NOT NULL DEFAULT 0,
	time DATETIME DEFAULT GETDATE(),


	CONSTRAINT PK PRIMARY KEY (id_bill,id_table,id_item)
);


Insert into Account values('admin','admin',1)
Insert into Account values('nhanvien','nhanvien',0)
Insert into Staff values ('Phan Minh Phú','admin','admin')
Insert into Staff values ('Nhân Viên','nhân viên','nhanvien')
Insert into Menu values (0,'Coffee')
Insert into Menu values (1,'Tea')
Insert into Menu values (2,'Ice Blend')
Insert into Menu values (3,'Juice')
Insert into Menu values (4,'Cake & Snack')



Insert into Item values ('A001',0,N'AMERICANO',39000,(SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\AMERICANO.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A002',0,N'BẠC SỈU',29000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\BẠC SỈU.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A003',0,N'CÀ PHÊ ĐEN',29000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\CÀ PHÊ ĐEN.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A004',0,N'CÀ PHÊ SỮA',29000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\CÀ PHÊ SỮA.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A005',0,N'CAPPUCINNO',45000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\CAPPUCINNO.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A006',0,N'CARAMEL MACCHIATO',55000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\CARAMEL MACCHIATO.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A007',0,N'COLD BREW CAM SẢ',45000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\COLD BREW CAM SẢ.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A008',0,N'COLD BREW PHÚC BỒN TỬ',50000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\COLD BREW PHÚC BỒN TỬ.png',SINGLE_BLOB ) as T1))
Insert into Item values ('A009',0,N'COLD BREW SỮA TƯƠI MACCHIATO',50000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\COLD BREW SỮA TƯƠI MACCHIATO.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A010',0,N'COLD BREW SỮA TƯƠI',50000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\COLD BREW SỮA TƯƠI.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A011',0,N'COLD BREW TRUYỀN THỐNG',45000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\COLD BREW TRUYỀN THỐNG.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A012',0,N'ESPRESSO',35000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\ESPRESSO.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A013',0,N'LATTE',45000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\LATTE.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A014',0,N'MOCHA',49000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\MOCHA.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('A015',0,N'SÔ-CÔ-LA ĐÁ',55000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\Coffee\SÔ-CÔ-LA ĐÁ.jpg',SINGLE_BLOB ) as T1))



Insert into Item values ('B001',1,N'TRÀ BƯỞI MẬT ONG',50000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ BƯỞI MẬT ONG.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('B002',1,N'TRÀ CAM VÀNG',55000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ CAM VÀNG.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('B003',1,N'TRÀ CHERRY MACCHIATO',55000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ CHERRY MACCHIATO.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('B004',1,N'TRÀ ĐÀO CAM SẢ',45000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ ĐÀO CAM SẢ.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('B005',1,N'TRÀ ĐEN MACCHIATO',42000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ ĐEN MACCHIATO.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('B006',1,N'TRÀ LÀI MACCHIATO',42000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ LÀI MACCHIATO.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('B007',1,N'TRÀ MATCHA LATTE',59000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ MATCHA LATTE.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('B008',1,N'TRÀ MATCHA MACCHIATO',45000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ MATCHA MACCHIATO.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('B009',1,N'TRÀ ÔLONG SEN AN NHIÊN',45000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ ÔLONG SEN AN NHIÊN.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('B010',1,N'TRÀ ÔLONG VẢI NHƯ Ý',45000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ ÔLONG VẢI NHƯ Ý.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('B011',1,N'TRÀ PHÚC BỒN TỬ',49000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ PHÚC BỒN TỬ.png',SINGLE_BLOB ) as T1))
Insert into Item values ('B012',1,N'TRÀ SỮA MẮC CA TRÂN CHÂU TRẮNG',45000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ SỮA MẮC CA TRÂN CHÂU TRẮNG.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('B013',1,N'TRÀ XOÀI MACCHIATO',55000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\TRÀ & MACCHIARATO\TRÀ XOÀI MACCHIATO.jpg',SINGLE_BLOB ) as T1))



Insert into Item values ('C001',2,N'CÀ PHÊ ĐÁ XAY',59000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\THỨC UỐNG ĐÁ XAY\CÀ PHÊ ĐÁ XAY.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('C002',2,N'CAM VÀNG CHANH ĐÁ XAY',62000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\THỨC UỐNG ĐÁ XAY\CAM VÀNG CHANH ĐÁ XAY.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('C003',2,N'CHANH SẢ ĐÁ XAY',42000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\THỨC UỐNG ĐÁ XAY\CHANH SẢ ĐÁ XAY.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('C004',2,N'CHOCOLATE ĐÁ XAY',59000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\THỨC UỐNG ĐÁ XAY\CHOCOLATE ĐÁ XAY.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('C005',2,N'COOKIES ĐÁ XAY',59000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\THỨC UỐNG ĐÁ XAY\COOKIES ĐÁ XAY.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('C006',2,N'ĐÀO VIỆT QUẤT ĐÁ XAY',59000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\THỨC UỐNG ĐÁ XAY\ĐÀO VIỆT QUẤT ĐÁ XAY.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('C007',2,N'MATCHA ĐÁ XAY',59000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\THỨC UỐNG ĐÁ XAY\MATCHA ĐÁ XAY.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('C008',2,N'ỔI HỒNG VIỆT QUẤT ĐÁ XAY',59000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\THỨC UỐNG ĐÁ XAY\ỔI HỒNG VIỆT QUẤT ĐÁ XAY.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('C009',2,N'PHÚC BỒN TỬ CAM ĐÁ XAY',59000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\THỨC UỐNG ĐÁ XAY\PHÚC BỒN TỬ CAM ĐÁ XAY.png',SINGLE_BLOB ) as T1))
Insert into Item values ('C010',2,N'TRÀ CÀ PHÊ ĐÁ XAY',59000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\THỨC UỐNG ĐÁ XAY\TRÀ CÀ PHÊ ĐÁ XAY.jpg',SINGLE_BLOB ) as T1))




Insert into Item values ('D001',3,N'SINH TỐ CAM XOÀI',59000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\THỨC UỐNG TRÁI CÂY\SINH TỐ CAM XOÀI.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('D002',3,N'SINH TỐ VIỆT QUẤT',59000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\THỨC UỐNG TRÁI CÂY\SINH TỐ VIỆT QUẤT.jpg',SINGLE_BLOB ) as T1))



Insert into Item values ('F001',4,N'BÁNH BÔNG LAN TRỨNG MUỐI',29000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\BÁNH & SNACK\BÁNH BÔNG LAN TRỨNG MUỐI.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('F002',4,N'BÁNH CHOCOLATE',29000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\BÁNH & SNACK\BÁNH CHOCOLATE.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('F003',4,N'BÁNH CROISSANT BƠ TỎI',29000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\BÁNH & SNACK\BÁNH CROISSANT BƠ TỎI.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('F004',4,N'BÁNH GẤU CHOCOLATE',39000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\BÁNH & SNACK\BÁNH GẤU CHOCOLATE.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('F005',4,N'BÁNH MATCHA',29000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\BÁNH & SNACK\BÁNH MATCHA.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('F006',4,N'BÁNH MÌ CHÀ BÔNG PHÔ MAI',32000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\BÁNH & SNACK\BÁNH MÌ CHÀ BÔNG PHÔ MAI.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('F007',4,N'BÁNH PASSION CHEESE',29000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\BÁNH & SNACK\BÁNH PASSION CHEESE.jpg',SINGLE_BLOB ) as T1))
Insert into Item values ('F008',4,N'BÁNH TIRAMISU',29000, (SELECT * FROM OPENROWSET(BULK N'C:\Users\ABC\Desktop\DOAN\image\BÁNH & SNACK\BÁNH TIRAMISU.jpg',SINGLE_BLOB ) as T1))

Insert into Ban values(1)
Insert into Ban values(2)
Insert into Ban values(3)
Insert into Ban values(4)
Insert into Ban values(5)
Insert into Ban values(6)
Insert into Ban values(7)
Insert into Ban values(8)
Insert into Ban values(9)
Insert into Ban values(10)

insert into Bill values('1','1','1','A001','4','0',GETDATE())
insert into Bill values('1','1','1','A002','4','0',GETDATE())        
insert into Bill values('1','1','1','A003','4','0',GETDATE())
insert into Bill values('1','1','1','B004','4','0',GETDATE())
insert into Bill values('2','1','1','A001','4','0',GETDATE())
insert into Bill values('2','1','1','A002','4','0',GETDATE())
insert into Bill values('3','1','1','A003','4','0',GETDATE())
insert into Bill values('4','1','1','B004','4','0',GETDATE())
-- insert into Bill values('3','1','1','C002','3','0','Nov 16 2020 10:17PM')


SELECT name_staff FROM Staff WHERE id_staff = ( SELECT DISTINCT id_staff FROM Bill WHERE id_bill = 1 )
SELECT id_bill , id_staff , SUM(price) AS "ToTal", convert(char(20),time,100) AS "Time" From Bill GROUP BY id_bill,id_staff, convert(char(20),time,100)
SELECT id_bill , id_staff , SUM(price) AS "ToTal", convert(char(30),time,100) AS "Time" From Bill  WHERE  YEAR(time) = '2020' AND MONTH(time) = '11' GROUP BY id_bill,id_staff, convert(char(30),time,100)
SELECT ROW_NUMBER() OVER (ORDER BY name)  AS [STT], name,count, Bill.price FROM Item INNER JOIN Bill ON Item.id_item = Bill.id_item WHERE id_bill = 1
SELECT id_bill , SUM(price) AS "ToTal" from Bill GROUP BY id_bill

DELETE FROM Bill WHERE id_bill = 1
UPDATE Bill SET id_item = 'B001', count = 10 WHERE id_bill = 5 AND id_table = 6 AND id_item = 'A009'





-- triger caculate price for insert and update statement
create trigger trg_price
on dbo.Bill
for insert
as
begin
	declare @id_bill int
	declare @id_table int
	declare @id_item nvarchar(4)
	declare @price int
	declare @soluong int
	declare @total int
	select @id_bill=id_bill , @soluong = count, @id_item = id_item, @id_table = id_table from inserted
	select @price=price from Item where id_item=@id_item
	SET @total = @price * @soluong
	update Bill set price = @total where id_bill=@id_bill AND @id_table =id_table AND @id_item = id_item
end



create trigger trg_price_update
on dbo.Bill
after update
as
begin
	declare @id_bill int
	declare @id_table int
	declare @id_item nvarchar(4)
	declare @price int
	declare @soluong int
	declare @total int
	select @id_bill=id_bill , @soluong = count, @id_item = id_item, @id_table = id_table from inserted
	select @price=price from Item where id_item=@id_item
	SET @total = @price * @soluong
	update Bill set price = @total where id_bill=@id_bill AND @id_table =id_table AND @id_item = id_item
end



-- Procedure
CREATE PROCEDURE  Tao_Bill(@id_bill int, @name_staff nchar(100) , @id_table int, @name_item nchar(100), @soluong int)
AS 
BEGIN
	declare @id_staff int;
	declare @id_item nvarchar(4);
	select @id_staff = id_staff from Staff where name_staff =  @name_staff;
	select @id_item = id_item from Item where name =  @name_item;
	insert into Bill values(@id_bill,@id_staff,@id_table,@id_item,@soluong,'0',GETDATE())
END
drop procedure Tao_Bill
EXEC Tao_Bill @id_bill = 5, @name_staff = N'Phan Minh Phú', @id_table = 1, @name_item = N'COLD BREW PHÚC BỒN TỬ', @soluong = 3




CREATE PROCEDURE  Bill_Insert(@id_bill int, @name_staff nchar(100) , @id_table int, @id_item char(4), @soluong int, @time char(30))
AS 
BEGIN
	declare @id_staff int;
	select @id_staff = id_staff from Staff where name_staff =  @name_staff;
	insert into Bill values(@id_bill,@id_staff,@id_table,@id_item,@soluong,'0',@time)
END
drop procedure Bill_Insert
EXEC Bill_Insert @id_bill = 3 , @name_staff = N'Phan Minh Phú' , @id_table = 1, @id_item = 'C002', @soluong = 3, @time = 'Nov 16 2020 10:17PM'



CREATE PROCEDURE  Bill_Delete( @ten nchar(100), @id_bill int, @id_table int)
AS	
BEGIN
	declare @id_item nvarchar(4);
	select @id_item = id_item from Item where name = @ten;
	DELETE FROM Bill WHERE id_bill = @id_bill AND id_item = @id_item AND id_table = @id_table
END
drop PROCEDURE  Bill_Delete
EXEC Bill_Delete @ten = N'CÀ PHÊ ĐEN', @id_bill = 1, @id_table = 1
DELETE FROM Bill WHERE id_bill = 1 AND id_item = @id_item AND id_table = 1


