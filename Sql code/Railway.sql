---------------CREATE DATABASE----------
CREATE DATABASE RAILWAY
GO
USE RAILWAY

-------------CREATE TABLES--------------

CREATE TABLE PASSENGER
(
  Fname VARCHAR(50) NOT NULL,
  Minit CHAR(1) NOT NULL,
  Lname VARCHAR(50) NOT NULL,
  Sex CHAR(1) NOT NULL,
  P_SSN INT NOT NULL,
  Phone_Number INT NOT NULL,
  DOB DATE NOT NULL,
  PRIMARY KEY (P_SSN),
  UNIQUE (Phone_Number)
);

CREATE TABLE EMPLOYEE
(
  Fname VARCHAR(50) NOT NULL,
  Minit CHAR(1) NOT NULL,
  Lname VARCHAR(50) NOT NULL,
  E_SSN INT NOT NULL,
  Sex CHAR(1) NOT NULL,
  Phone_Number INT NOT NULL,
  Salary INT NOT NULL,
  DOB DATE NOT NULL,
  Manager_SSN INT,
  FOREIGN KEY (Manager_SSN) REFERENCES EMPLOYEE (E_SSN),
  PRIMARY KEY (E_SSN),
  UNIQUE (Phone_Number)
);

CREATE TABLE TRAIN
(
  Business_Class INT NOT NULL,
  Economic_Class INT NOT NULL,
  Train_Number INT NOT NULL,
  Maintenance_Day DATE NOT NULL,
  PRIMARY KEY (Train_Number)
);

CREATE TABLE STATION
(
  Station_Name VARCHAR(50) NOT NULL,
  Station_Number INT NOT NULL,
  Location VARCHAR(50) NOT NULL,
  Manager_SSN INT NOT NULL,
  Manager_Start_Date DATE NOT NULL,
  FOREIGN KEY (Manager_SSN) REFERENCES EMPLOYEE (E_SSN),
  PRIMARY KEY (Station_Number),
  UNIQUE (Station_Number)
);

ALTER TABLE EMPLOYEE ADD Station_Number INT,
FOREIGN KEY (Station_Number) REFERENCES STATION (Station_Number);

CREATE TABLE TRIP
(
  Trip_Number INT NOT NULL,
  Departure_Time DATETIME NOT NULL,
  Arrival_Time DATETIME NOT NULL,
  Economic_Ticket_Price INT NOT NULL,
  Business_Ticket_Price INT NOT NULL,
  Business INT NOT NULL,
  Economic INT NOT NULL,
  Train_Number INT NOT NULL,
  PRIMARY KEY (Trip_Number),
  FOREIGN KEY (Train_Number) REFERENCES TRAIN (Train_Number)
);

CREATE TABLE SUPPLIER
(
  Supplier_ID INT NOT NULL,
  Supplier_Address VARCHAR(50) NOT NULL,
  Supplier_Name VARCHAR(50) NOT NULL,
  Phone_Number BIGINT NOT NULL,
  PRIMARY KEY (Supplier_ID),
  UNIQUE (Phone_Number)
);

CREATE TABLE SPARE_PART
(
  Part_Number INT NOT NULL,
  Price INT NOT NULL,
  Supplier_ID INT NOT NULL,
  FOREIGN KEY (Supplier_ID) REFERENCES SUPPLIER (Supplier_ID),
  PRIMARY KEY (Part_Number)
);


CREATE TABLE BOOKINGS
(
  P_SSN INT NOT NULL,
  Trip_Number INT NOT NULL,
  Trip_Date DATE NOT NULL,
  Type VARCHAR(8) NOT NULL,
  Status VARCHAR(10) NOT NULL,
  Feedback_Rating INT,
  Feedback_Comment VARCHAR(100),
  FOREIGN KEY (P_SSN) REFERENCES PASSENGER (P_SSN),
  FOREIGN KEY (Trip_Number) REFERENCES TRIP (Trip_Number),
  PRIMARY KEY (P_SSN,Trip_Number,Trip_Date)
);

CREATE TABLE FROM_TO
(
  Trip_Number INT NOT NULL,
  Station_Number1 INT NOT NULL,
  Station_Number2 INT NOT NULL
  FOREIGN KEY (Trip_Number) REFERENCES TRIP (Trip_Number),
  FOREIGN KEY (Station_Number1) REFERENCES STATION( Station_Number),
  FOREIGN KEY (Station_Number2) REFERENCES STATION( Station_Number),
  PRIMARY KEY (Trip_Number,Station_Number1,Station_Number2)
);

CREATE TABLE INVENTORY 
(
  Station_Number INT NOT NULL,
  Part_Number INT NOT NULL,
  Quantity INT,
  FOREIGN KEY (Station_Number) REFERENCES STATION( Station_Number),
  FOREIGN KEY (Part_Number) REFERENCES SPARE_PART (Part_Number),
  PRIMARY KEY (Station_Number,Part_Number)
);

CREATE TABLE REQUEST 
(
  E_SSN INT NOT NULL,
  Part_Number INT NOT NULL,
  Request_ID INT NOT NULL,
  Quantity INT,
  Status VARCHAR(10) NOT NULL,
  FOREIGN KEY (E_SSN) REFERENCES EMPLOYEE (E_SSN),
  FOREIGN KEY (Part_Number) REFERENCES SPARE_PART (Part_Number),
  PRIMARY KEY (Request_ID)
);

CREATE TABLE LOGIN_PASSENGER
(
  P_SSN INT NOT NULL,
  Username VARCHAR(50) NOT NULL,
  Password VARCHAR(50) NOT NULL,
  UNIQUE (P_SSN),
  FOREIGN KEY (P_SSN) REFERENCES PASSENGER (P_SSN),
  PRIMARY KEY (Username)
);

CREATE TABLE LOGIN_EMPLOYEE
(
  E_SSN INT NOT NULL,
  Username VARCHAR(50) NOT NULL,
  Password VARCHAR(50) NOT NULL,
  UNIQUE (E_SSN),
  FOREIGN KEY (E_SSN) REFERENCES EMPLOYEE (E_SSN),
  PRIMARY KEY (Username)
);

---------------------ADDING ROWS INTO THE DB-------------

INSERT INTO EMPLOYEE(Fname,Minit,Lname,E_SSN,Sex,Phone_Number,Salary,DOB,Manager_SSN)
VALUES
('Ahmed','M','Ismail',12345678,'M',01123456789,30000,'2000-02-22',NULL),
('Moaz','M','ElSherbiny',619619619,'M',0114789542,30000,'2000-10-03',12345678),
('Mostafa','A','Ahmed',88888888,'M',01158795123,30000,'1998-12-12',12345678),
('Nader','Y','Adib',420420420,'M',01285003523,30000,'2000-05-15',NULL);

INSERT INTO STATION (Station_Number,Station_Name,Manager_SSN,Manager_Start_Date,Location)
VALUES
(1,'Burg Al Arab',420420420,'2015-07-04','Alexandria'),
(2,'Port-Said',420420420,'2014-03-05','Port-Said'),
(3,'Aswan',420420420,'2014-03-01','Aswan'),
(4,'Luxor',619619619,'2013-06-11','Luxor'),
(5,'New Capital',420420420,'2014-02-01','New Capital'),
(6,'Mansoura',88888888,'2017-06-03','Dakahleya'),
(7,'Menya',88888888,'2018-09-14','Menya'),
(8,'Misr Station',420420420,'2015-07-04','Ramsis'),
(9,'Marsa Matrouh',88888888,'2016-05-01','Marsa Matrouh'),
(10,'Saloum',88888888,'2017-12-15','Saloum'),
(11,'Alyoub',88888888,'2018-09-14','Aluoubeya'),
(12,'Assiout',88888888,'2015-01-02','Assiout'),
(13,'Zagazig',88888888,'2014-07-08','Sharkeya'),
(14,'Fayoum',88888888,'2013-02-05','Fayoum'),
(15,'El Mahala Al Kobra',88888888,'2011-04-25','Gharbeya'),
(16,'Ismailia',88888888,'2012-04-05','Ismailia'),
(17,'Kafr El Sheikh',88888888,'2014-05-11','Kafr El Sheikh'),
(18,'Tanta',88888888,'2017-08-05','Gharbeya'),
(19,'Sohag',88888888,'2019-08-04','Sohag'),
(20,'Qena',88888888,'2012-05-04','Qena'),
(21,'Banha',88888888,'2017-09-08','Alyoubeya'),
(22,'Beni Suef',88888888,'2016-06-06','Beni Suef'),
(23,'Suez',88888888,'2015-01-04','Suez');



INSERT INTO SUPPLIER(Supplier_ID, Supplier_Address, Supplier_Name, Phone_Number)
VALUES
(1,'Beijing, China','CRRC',8611111111111),
(2,'Saint Petersburg, Russia','Kirov Plant', 70000000),
(3,'Munich, Germany','Siemens Mobility',4930901820),
(4,'Berlin, Germany','Bombardier Transportation',4980967820),
(5,'Brossard, Quebec, Canada','Railpower Technologies',16045555555),
(6,'Aarhus, Denmark','Frichs',4553232341),
(7,'Tampere, Finland','Lokomo',358501234567),
(8,'Levallois-Perret, France','Alstom',33109758351),
(9,'Crespin, France','ANF Industrie',33108410251),
(10,'Paris, France','Corpet-Louvet',33187902551),
(11,'Westphalia, Germany','Windhoff',4930875430),
(12,'Werdohl, Germany','Vossloh',4932315830),
(13,'Uttar Pradesh, India','Banaras Locomotive Works',912212345678),
(14,'Tamil Nadu, India','Golden Rock Railway Workshop',912875685678),
(15,'Mumbai, India','Tata Motors',912813290678),
(16,'Pistoia, Italy','Hitachi Rail Italy',393789438645),
(17,'Napoli, Italy','Trasporti',390823379111),
(18,'Tokyo, Japan','Mitsubishi Heavy Industries',810876986789),
(19,'Tokyo, Japan','Toshiba',810123456789),
(20,'Pennsylvania, United States','GE Transportation',15555551234);



INSERT INTO SPARE_PART(Part_Number,Price,Supplier_ID)
VALUES
(10,1000000,1),		--Engine
(20,1000,1),		--Wheel
(21,2000,2),		--Brakes
(22,20000,2),		--Brake system
(23,5000,3),		--Bearings
(30,20000,3);		--Gears


INSERT INTO TRAIN (Train_Number,Economic_Class,Business_Class,Maintenance_Day)
VALUES
(1,50,20,'2021-05-05'),
(2,70,20,'2022-07-05'),
(3,60,10,'2023-08-15'),
(4,50,20,'2022-05-05'),
(5,50,10,'2024-01-04'),
(6,60,10,'2023-06-09'),
(7,50,10,'2021-01-04'),
(8,60,30,'2025-04-05'),
(9,50,30,'2025-05-05'),
(10,70,30,'2024-05-05'),
(11,60,20,'2023-07-05'),
(12,60,20,'2021-08-05'),
(13,50,10,'2022-05-04'),
(14,70,20,'2023-05-09'),
(15,50,10,'2024-05-14'),
(16,60,10,'2026-12-05'),
(17,50,10,'2025-05-05'),
(18,70,20,'2021-05-05'),
(19,50,20,'2023-07-08'),
(20,70,10,'2024-04-05');
