create database imageDb;

create table Product
(
Id int primary key identity,
Name varchar(100) not null,
Price int not null,
Image_path varchar(500) not null,
);