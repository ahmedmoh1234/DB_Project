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



CREATE PROCEDURE VIEW_SPARE_PARTS_IN_STATION @Station_No INT
AS
BEGIN
SELECT Part_Number,Quantity
FROM INVENTORY
WHERE Station_Number = @Station_No
END
GO


CREATE PROCEDURE DEC_SPARE_PARTS @Station_No INT, @Part_No INT, @Amount INT
AS
BEGIN
UPDATE INVENTORY
SET Quantity = Quantity - @Amount
WHERE Station_Number = @Station_No AND Part_Number = @Part_No
END
GO


CREATE PROCEDURE ORDER_SPARE_PARTS @Part_No INT, @Amount INT, @SSN BIGINT ,@RequestID INT
AS
BEGIN
INSERT INTO REQUEST (Request_ID, E_SSN, Part_Number, Quantity, [Status] )
VALUES (@RequestID,@SSN,  @Part_No, @Amount, 'Pending')
END
GO


CREATE PROCEDURE INSERT_EMPLOYEE @Fname VARCHAR(50), @Minit CHAR(1), @Lname VARCHAR(50), @SSN BIGINT,
								@Sex CHAR(1),@DOB DATE, @Phone_Number BIGINT, 
								@Manager_SSN BIGINT, @Salary INT,@Station_Number INT
AS
BEGIN
INSERT INTO EMPLOYEE 
VALUES (@Fname,@Minit,@Lname,@SSN,@Sex,@Phone_Number,@Salary,@DOB,@Manager_SSN,@Station_Number)
END
GO

CREATE PROCEDURE CHECK_EMPLOYEE_BY_SSN @SSN BIGINT
AS
BEGIN
SELECT COUNT(*)
FROM EMPLOYEE
WHERE E_SSN=@SSN
END
GO

CREATE PROCEDURE REMOVE_EMPLOYEE @SSN BIGINT
AS
BEGIN
DELETE FROM EMPLOYEE
WHERE E_SSN = @SSN
END
GO

CREATE PROCEDURE VIEW_REQUEST
AS
BEGIN
SELECT * FROM REQUEST
END
GO

/*
CREATE PROCEDURE PASSENGER_MOST_TRIPS
AS
BEGIN
SELECT [P_SSN] 
FROM PASSENGER AS P, 
*/

CREATE PROCEDURE NO_TRAIN_TRIPS		@TrainNo INT
AS
BEGIN
SELECT COUNT(*) AS 'Count'
FROM TRIP
WHERE Train_Number = @TrainNo
END
GO


--------------moaz-----------

CREATE PROCEDURE INSERT_TRIP @PassengerId INT, @TripNo INT, @TripDate DATE, @TypeB_E VARCHAR(8), @status VARCHAR(10)
AS
BEGIN
INSERT INTO BOOKINGS(P_SSN,Trip_Number,Trip_Date,Type,Status)
VALUES
(@PassengerId,@TripNo,@TripDate,@TypeB_E,@status)
END
GO

CREATE PROCEDURE DELETE_TRIP @PassengerId INT, @TripNo INT, @TripDate DATE
AS 
BEGIN
DELETE FROM BOOKINGS 
WHERE P_SSN = @PassengerId AND Trip_Date = @TripDate AND Trip_Number = @TripNo AND Status = 'upcoming'
END
GO

CREATE PROCEDURE ViewPreviousTripinTable @PassengerId INT
AS
BEGIN
SELECT B.P_SSN,B.Trip_Number,B.Trip_Date,S1.Station_Name, S2.Station_Name,B.Feedback_Rating,B.Feedback_Comment
FROM BOOKINGS AS B, FROM_TO AS F , STATION AS S1, STATION AS S2
WHERE B.P_SSN = @PassengerId AND Station_Number1 = S1.Station_Number AND Station_Number2 = S2.Station_Number AND B.Trip_Number = F.Trip_Number AND B.Status = 'Completed'
END
GO


CREATE PROCEDURE DisplayinTextBoxPreviousTrip @PassengerId INT, @TripNo INT, @TripDate DATE
AS
BEGIN
SELECT * 
FROM BOOKINGS, TRIP, FROM_TO, STATION AS S1, STATION AS S2
WHERE P_SSN = @PassengerId AND BOOKINGS.Trip_Number = @TripNo AND BOOKINGS.Trip_Date = @TripDate AND Station_Number1 = S1.Station_Number AND Station_Number2 = S2.Station_Number AND BOOKINGS.Trip_Number = TRIP.Trip_Number AND TRIP.Trip_Number = FROM_TO.Trip_Number AND Status = 'Completed'
END
GO

CREATE PROCEDURE ViewAvailableTrip @PassengerId INT, @currenttime TIME
AS
BEGIN
SELECT TRIP.Trip_Number, S1.Station_Name, S2.Station_Name, Departure_Time,Arrival_Time, Business, Business_Ticket_Price, Economic, Economic_Ticket_Price
FROM BOOKINGS, TRIP, FROM_TO, STATION AS S1, STATION AS S2
WHERE BOOKINGS.Trip_Number = TRIP.Trip_Number AND TRIP.Trip_Number = FROM_TO.Trip_Number  AND Station_Number1 = S1.Station_Number AND Station_Number2 = S2.Station_Number AND Departure_Time > @currenttime
END
GO

CREATE PROCEDURE ViewUpcomingTrip @PassengerId INT
AS
BEGIN
SELECT *
FROM BOOKINGS, TRIP, FROM_TO, STATION AS S1, STATION AS S2
WHERE BOOKINGS.Trip_Number = TRIP.Trip_Number AND TRIP.Trip_Number = FROM_TO.Trip_Number AND Station_Number1 = S1.Station_Number AND Station_Number2 = S2.Station_Number AND P_SSN = @PassengerId AND Status = 'Upcoming'
END
GO

CREATE PROCEDURE ViewSpecificTrip @currenttime TIME, @stationName1 VARCHAR(50), @stationName2 VARCHAR(50) 
AS
BEGIN
SELECT TRIP.Trip_Number, S1.Station_Name, S2.Station_Name, Departure_Time,Arrival_Time, Business, Business_Ticket_Price, Economic, Economic_Ticket_Price
FROM BOOKINGS, TRIP, FROM_TO, STATION AS S1, STATION AS S2
WHERE BOOKINGS.Trip_Number = TRIP.Trip_Number AND TRIP.Trip_Number = FROM_TO.Trip_Number AND Station_Number1 = S1.Station_Number AND Station_Number2 = S2.Station_Number AND S1.Station_Name = @stationName1 AND S2.Station_Name = @stationName2 AND Departure_Time > @currenttime
END
GO

CREATE PROCEDURE INSERTFEEDBACK_W @Comment VARCHAR(100), @Rating INT, @PassengerId INT, @TripNo INT,@TRIPDate DATE
AS
BEGIN
UPDATE BOOKINGS 
SET Feedback_Rating = @Rating, Feedback_Comment = @Comment
WHERE P_SSN = @PassengerId AND Trip_Number = @TripNo AND Trip_Date = Trip_Date
END
GO

CREATE PROCEDURE INSERTFEEDBACK_WO @Rating INT, @PassengerId INT, @TripNo INT,@TRIPDate DATE
AS
BEGIN
UPDATE BOOKINGS 
SET Feedback_Rating = @Rating
WHERE P_SSN = @PassengerId AND Trip_Number = @TripNo AND Trip_Date = Trip_Date
END
GO

CREATE PROCEDURE ViewTrainInfo @TripNo INT
AS
BEGIN
SELECT * 
FROM TRIP
WHERE Trip_Number = @TripNo
END 
GO

CREATE PROCEDURE CHANGETRIPDATE @PassengerId INT, @TripNo INT,@TRIPDate DATE, @TRIPDateNew DATE 
AS
BEGIN
UPDATE BOOKINGS
SET Trip_Date = @TRIPDateNew
WHERE  P_SSN = @PassengerId AND Trip_Number = @TripNo AND Trip_Date = Trip_Date
END
GO

CREATE PROCEDURE CHANGETRIPCLASS @PassengerId INT,@TRIPClassNew VARCHAR(8)
AS
BEGIN
UPDATE BOOKINGS
SET Type = @TRIPClassNew
WHERE  P_SSN = @PassengerId AND Status = 'Upcoming'
END
GO

-------------moaz-------------
