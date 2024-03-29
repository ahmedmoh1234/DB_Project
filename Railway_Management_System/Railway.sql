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
  P_SSN BIGINT NOT NULL,
  Phone_Number BIGINT NOT NULL,
  DOB DATE NOT NULL,
  PRIMARY KEY (P_SSN),
  UNIQUE (Phone_Number)
);

CREATE TABLE EMPLOYEE
(
  Fname VARCHAR(50) NOT NULL,
  Minit CHAR(1) NOT NULL,
  Lname VARCHAR(50) NOT NULL,
  E_SSN BIGINT NOT NULL,
  Sex CHAR(1) NOT NULL,
  Phone_Number BIGINT NOT NULL,
  Salary INT NOT NULL,
  DOB DATE NOT NULL,
  Manager_SSN BIGINT,
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
  Manager_SSN BIGINT NOT NULL,
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
  P_SSN BIGINT NOT NULL,
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
  E_SSN BIGINT NOT NULL,
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
  P_SSN BIGINT NOT NULL,
  Username VARCHAR(50) NOT NULL,
  Password VARCHAR(50) NOT NULL,
  UNIQUE (P_SSN),
  FOREIGN KEY (P_SSN) REFERENCES PASSENGER (P_SSN),
  PRIMARY KEY (Username)
);

CREATE TABLE LOGIN_EMPLOYEE
(
  E_SSN BIGINT NOT NULL,
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

INSERT INTO STATION(Station_Number,Station_Name,Manager_SSN,Manager_Start_Date,Location)
VALUES
(205,'Misr Station',420420420,'2015-07-04','Ramsis'),
(301,'Menya',88888888,'2018-09-14','Menya'),
(488,'Mansoura',619619619,'2017-06-03','Dakahleya');


INSERT INTO SUPPLIER(Supplier_ID, Supplier_Address, Supplier_Name, Phone_Number)
VALUES
(1,'Beijing, China','CRRC',8611111111111),
(2,'Saint Petersburg, Russia','Kirov Plant', 70000000),
(3,'Munich, Germany','Siemens Mobility',4930901820);

INSERT INTO SPARE_PART(Part_Number,Price,Supplier_ID)
VALUES
(10,1000000,1),		--Engine
(20,1000,1),		--Wheel
(21,2000,2),		--Brakes
(22,20000,2),		--Brake system
(23,5000,3),		--Bearings
(30,20000,3);		--Gears

--------------------------------------------------------------------------------------------------------
INSERT INTO PASSENGER
VALUES
('Mostafa','A','Ismail','M',12345678925400,32369115126,'1980-10-20'),
('Mohamed','A','Abdelfattah','M',12345678925401,25010083156,'1981-11-21'),
('Ahmed','A','Gali','M',12345678925402,69201892085,'1982-05-12'),
('Abdallah','A','Radwan','M',12345678925403,97871229887,'1983-07-11'),
('Khaled','A','Rashwan','M',12345678925404,31901272454,'1998-06-15'),
('Hussein','A','Kamel','M',12345678925405,44276980139,'1998-05-02'),
('Mariam','A','Moaz','F',12345678925406,33585806716,'1984-09-05'),
('Nada','A','Nader','F',12345678925407,18759302464,'1985-02-07'),
('Habiba','A','Chadi','F',12345678925408,23728221227,'1990-01-12'),
('Mennah','A','Shamy','F',12345678925409,55621063128,'1991-06-17'),
('Aya','A','Omar','F',12345678925410,05466721878,'1992-07-10'),
('Sarah','A','Ibrahim','F',12345678925411,99090712225,'1993-04-02'),
('Salma','A','Moataz','F',12345678925412,59654834347,'1994-03-08'),
('Farida','A','Amr','F',12345678925413,83818727225,'1995-07-03'),
('Iman','A','Salah','F',12345678925414,68592725297,'1996-06-25'),
('Somaia','A','Essam','F',12345678925415,37905594828,'1998-06-13'),
('Wafaa','A','Emam','F',12345678925416,58055980572,'1998-08-19'),
('Karim','A','Salama','M',12345678925417,58107957800,'1985-12-06'),
('Abdelrahman','A','Shamy','M',12345678925418,84319998918,'1970-12-07'),
('Kamal','A','Sabahi','M',12345678925419,80223512967,'1989-10-18')
-----------------------------------------------------------------------------------------
INSERT INTO LOGIN_PASSENGER
VALUES
(12345678925400,'Mostafa153','sda1234'),
(12345678925401,'Mohamed363','vsf1234'),
(12345678925402,'Ahmed12','ghj1234'),
(12345678925403,'Abdallah23','sdf1234'),
(12345678925404,'Khaled7','sge1234'),
(12345678925405,'Hussein3','hgj1234'),
(12345678925406,'Mariam2','fgh1234'),
(12345678925407,'Nada19','dsg1234'),
(12345678925408,'Habiba7','dfh1234'),
(12345678925409,'Mennah12','sgt1234'),
(12345678925410,'Aya123','sfg1234'),
(12345678925411,'Sarah653','fdh1234'),
(12345678925412,'Salma1','ghf1234'),
(12345678925413,'Farida23','sdg1234'),
(12345678925414,'Iman13','sdg1234'),
(12345678925415,'Somaia123','fgh1234'),
(12345678925416,'Wafaa165','sdg1234'),
(12345678925417,'Karim124','sdf1234'),
(12345678925418,'Abdelrahman_23','sdgh1234'),
(12345678925419,'Kamal64','qwe1234');


-----------------------------------------------------------------------------------------
INSERT INTO LOGIN_EMPLOYEE
VALUES
(88888888,'ismail123','12345678');
(12345678,'Ahmed123','12345678');



