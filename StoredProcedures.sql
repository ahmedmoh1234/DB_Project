USE RAILWAY;
GO
CREATE PROCEDURE VIEW_EMPLOYEES
AS
BEGIN
SELECT * FROM Employee
END
GO

CREATE PROCEDURE VIEW_TRIPS
AS
BEGIN
SELECT * FROM TRIP
END
GO

CREATE PROCEDURE VIEW_TRAINS
AS
BEGIN
SELECT * FROM TRAIN
END
GO

CREATE PROCEDURE VIEW_STATIONS
AS
BEGIN
SELECT * FROM STATION
END
GO

CREATE PROCEDURE VIEW_SUPPLIERS
AS
BEGIN
SELECT * FROM SUPPLIER
END
GO

CREATE PROCEDURE VIEW_SPARE_PARTS
AS
BEGIN
SELECT * FROM SPARE_PART
END
GO

CREATE PROCEDURE CHANGE_TRAIN_MAINTENANCE_DATE @New_Date DATE,@Train_Number INT
AS
BEGIN
UPDATE TRAIN SET Maintenance_Day = @New_Date
WHERE Train_Number = @Train_Number
END
GO

CREATE PROCEDURE ADD_TRIP @Trip_Num INT , @Deprt_Time DATETIME, @Arr_Time DATETIME
, @Eco_Ticket_Price INT, @Buss_Ticket_Price INT, @Buss_No INT, @Eco_No INT
, @Train_No INT
AS
BEGIN
INSERT INTO TRIP (Trip_Number, Departure_Time, Arrival_Time, Economic_Ticket_Price
, Business_Ticket_Price, Business, Economic, Train_Number)
VALUES
(@Trip_Num,@Deprt_Time,@Arr_Time,@Eco_Ticket_Price, @Buss_Ticket_Price, @Buss_No,@Eco_No
,@Train_No)
END
GO

CREATE PROCEDURE REMOVE_TRIP @Trip_Num INT 
AS
BEGIN
DELETE FROM TRIP 
WHERE Trip_Number = @Trip_Num
END
GO



CREATE PROCEDURE CHECK_LOGIN_PASSENGER @Username VARCHAR(20), @Password VARCHAR(20)
AS
BEGIN
SELECT COUNT(*) FROM LOGIN_PASSENGER WHERE Username = @Username AND Password=@Password
END
GO

CREATE PROCEDURE SIGNUP_PASSENGER @Fname varchar(20), @Minit char , @Lname varchar(20), @Phone_Number bigint,
@SSN bigint ,@gender char,@DOB Date,@Username VARCHAR(50), @Password Varchar(20)
AS
BEGIN
INSERT INTO PASSENGER 
VALUES
(@Fname,@Minit,@Lname,@gender,@SSN,@Phone_Number,@DOB)
INSERT INTO LOGIN_PASSENGER
VALUES
(@SSN,@Username,@Password)
END
GO

CREATE PROCEDURE CHECK_SSN_SIGN_UP_PASSENGER  @SSN bigint
AS
BEGIN
SELECT COUNT(*) FROM PASSENGER WHERE P_SSN=@SSN 
END
GO

CREATE PROCEDURE CHECK_USERNAME_SIGN_UP_PASSENGER @Username VARCHAR(50)
AS
BEGIN
SELECT COUNT(*) FROM LOGIN_PASSENGER WHERE Username=@Username 
END
GO



CREATE PROCEDURE CHECK_LOGIN_EMPLOYEE @Username VARCHAR(20), @Password VARCHAR(20)
AS
BEGIN
SELECT COUNT(*) FROM LOGIN_EMPLOYEE WHERE Username = @Username AND Password=@Password
END
GO

CREATE PROCEDURE CHECK_LOGIN_PASSENGER @Username VARCHAR(20), @Password VARCHAR(20)
AS
BEGIN
SELECT COUNT(*) FROM LOGIN_PASSENGER WHERE Username = @Username AND Password=@Password
END
GO

CREATE PROCEDURE GET_EMPLOYEE_DATA @Username VARCHAR(50)
AS
BEGIN
SELECT E.E_SSN,E.Manager_SSN,E.Station_Number FROM EMPLOYEE AS E,LOGIN_EMPLOYEE AS L WHERE L.Username=@Username AND L.E_SSN=E.E_SSN
END
GO

CREATE PROCEDURE GET_PASSENGER_SSN @Username VARCHAR(50)
AS
BEGIN
SELECT P_SSN FROM LOGIN_PASSENGER WHERE Username=@Username
END
GO