create table Customer
( Customer_ID varchar (20) not null primary key,
  Name varchar (100) not null,
  Country varchar (100) not null,
  Address varchar (150) not null,
  NIC_or_Passport_No varchar (100) not null,
  Gender varchar (10),
  Age int not null,
  Contact int not null,
  Register_date date DEFAULT GETDATE(),
);

create table Vehical
(
  Vehical_ID varchar (20) not null primary key,
  Brand varchar (100) not null,
  Type varchar (100) not null,
  Engine_No varchar (100) not null,
  Vehical_No varchar (100) not null,
  Vehical_date date DEFAULT GETDATE(),
);

create table Booking
(
   Customer_ID varchar (20) not null,
   Vehical_ID varchar (20) not null,
   primary key (Customer_ID,Vehical_ID),
   FOREIGN KEY (Customer_ID) REFERENCES Customer(Customer_ID),
   FOREIGN KEY (Vehical_ID) REFERENCES Vehical(Vehical_ID),
   Price int not null,
   Destination varchar (1000) not null,
   No_of_KM int not null,

);

INSERT INTO Customer(Customer_ID, Name,Country, Address,NIC_or_Passport_No,Gender, Age,Contact,Register_date)
VALUES ('C001','Deshan Nethmina','Sri Lanka','44/B,pitgala Road,Habarakad,West,Thawalama,galle','200198373633','Male',23,0710283933,'2024.06.16');
  
  
insert into Vehical(Vehical_ID, Brand,Type,Engine_No, Vehical_No,Vehical_date)
Values ('V001','Honda','Civic','0VIDHDB4738H','BBC-2423','2024.06.16'),
	   ('V002','Nissan','GT86','EJNB3H389MHK','ASB-2390','2024.06.16');


insert into Booking(Customer_ID,Vehical_ID,Price,Destination,No_of_KM)
values ('C001','V002',30000.00,'Kandy',120);