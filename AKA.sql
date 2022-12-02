CREATE TABLE Sales(
autoIncrement INT Primary key identity,
Invoice_Id char(9),
Item_Id char(9),
Customer_Id char(9),
itemsBought int,
dateTime Datetime,
Warehouse varchar(50),
)
CREATE TABLE Item(
Id char(9) PRIMARY KEY,
ItemName varchar(50),
Warehouse varchar(50),
Price decimal(10,2),
Stock int,
)
CREATE TABLE Customer(
CustomerId char(9) Primary key,
CustomerName varchar(max),
)
