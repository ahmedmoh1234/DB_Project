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