create database inventoryDBmvc

create table users
(
	u_id int primary key identity not null,
	u_name varchar(40) not null,
	u_username varchar(40) not null,
	u_password varchar(20) not null,
	u_phone varchar(15) not null,
	u_email varchar(25) not null,
	u_status tinyint not null
)

create table roles
(
	r_id tinyint not null identity primary key,
	r_name varchar(30) not null,
	r_status tinyint not null
)

create table categories
(
	cat_id tinyint not null identity primary key,
	cat_name varchar(30) not null,
	cat_status tinyint not null
)

alter table users
add u_roleID tinyint not null foreign key references roles(r_id) on update cascade on delete cascade



