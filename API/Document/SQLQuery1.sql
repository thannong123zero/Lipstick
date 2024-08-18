create database LipstickDataBase;

create table MenuGroup 
(
	ID int	not null IDENTITY(1,1) PRIMARY KEY,
	NameEN nvarchar(100) not null,
	NameVN nvarchar(100) not null,
	DiscriptionEN nvarchar(255),
	DiscriptionVN nvarchar(255),
	CreatedOn date,
	ModifiedOn date,
	IsDeleted bit,
	IsActive bit
);
create table MenuItem 
(
	ID int	not null IDENTITY(1,1) PRIMARY KEY,
	MenuGroupID int not null FOREIGN KEY REFERENCES MenuGroup(ID),
	NameEN nvarchar(100) not null,
	NameVN nvarchar(100) not null,
	DiscriptionEN nvarchar(255),
	DiscriptionVN nvarchar(255),
	CreatedOn date,
	ModifiedOn date,
	IsDeleted bit,
	IsActive bit
);

Create table Product
(
	ID int	not null IDENTITY(1,1) PRIMARY KEY,
	MenuItemID int not null FOREIGN KEY REFERENCES MenuItem(ID),
	NameEN nvarchar(100) not null,
	NameVN nvarchar(100) not null,
	DiscriptionEN nvarchar(255),
	DiscriptionVN nvarchar(255),
	ContentEN nvarchar(max),
	contentVN nvarchar(max),
	Images varchar(255),
	CreatedOn date,
	ModifiedOn date,
	Price money not null,
	SellOff int,
	IsHome bit,
	IsDeleted bit,
	IsActive bit,
	Quantity int not null
);