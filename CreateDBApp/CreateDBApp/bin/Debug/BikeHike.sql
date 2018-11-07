
CREATE TABLE Customers (
	CID			INT IDENTITY (20001,1) PRIMARY KEY,
	FirstName	NVARCHAR(128) NOT NULL, 
	LastName	NVARCHAR(128) NOT NULL, 
	Email		NVARCHAR(128) NOT NULL, 
); 

CREATE INDEX index_name ON Customers (FirstName, LastName);


CREATE TABLE BikeTypes (
	BTID 	INT IDENTITY (1,1) PRIMARY KEY,
	Price 	MONEY NOT NULL,
	Info	NVARCHAR(128) NOT NULL,
);

CREATE TABLE Bikes (
	BID  		INT IDENTITY (1001,1) PRIMARY KEY,
	BTID		INT NOT NULL FOREIGN KEY REFERENCES BikeTypes(BTID),
	YearService	SMALLINT NOT NULL, 
	Available	BIT DEFAULT 1 NOT NULL,
);

CREATE INDEX index_BTID on Bikes (BTID, YearService, Available)

CREATE TABLE RentalInfo (
	RID				INT IDENTITY (1,1) PRIMARY KEY, 
	CID 			INT NOT NULL FOREIGN KEY REFERENCES Customers(CID), 
	--BID				INT NOT NULL FOREIGN KEY REFERENCES Bikes (BID), 
	StartTime		DATETIME NOT NULL,
	ExpDuration		FLOAT NOT NULL,
	NumBikes		SMALLINT NOT NULL,
	EndTime			DATETIME,  
	CostOfRental	Money,
	--TripCompleted	BIT NOT NULL,
); 

CREATE INDEX index_CID on RentalInfo(CID);

CREATE TABLE RentalDetail (
	RDID			INT IDENTITY (1,1) PRIMARY KEY,
	RID				INT NOT NULL FOREIGN KEY REFERENCES RentalInfo(RID),
	BID				INT NOT NULL FOREIGN KEY REFERENCES Bikes(BID),
);

CREATE INDEX index_detail on RentalDetail(RID, BID);

CREATE TABLE BikeCustomer (
	BCID	INT IDENTITY (1,1) PRIMARY KEY,
	BID		INT NOT NULL FOREIGN KEY REFERENCES Bikes (BID), 
	CID 	INT NOT NULL FOREIGN KEY REFERENCES Customers(CID),
);
	
CREATE INDEX index_CID on BikeCustomer (CID);



CREATE PROCEDURE ReturnProcedure(@CID INT)
AS
	BEGIN 
		SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
			BEGIN TRANSACTION

			SELECT CID, Bikes.BID, Price INTO #BIDtable FROM RentalInfo
			JOIN RentalDetail ON RentalDetail.RID = RentalInfo.RID
			JOIN Bikes ON Bikes.BID = RentalDetail.BID
			JOIN BikeTypes ON BikeTypes.BTID = Bikes.BTID
			WHERE CID = @CID AND EndTime IS NULL

						UPDATE Bikes 
			SET Bikes.Available = 1 
			FROM Bikes
			INNER JOIN #BIDtable ON Bikes.BID = #BIDtable.BID 

			DROP TABLE #BIDtable

			DECLARE @endTime AS DATETIME 
			SET @endTime = (SELECT CURRENT_TIMESTAMP)
	
			DECLARE @startTime AS DATETIME 
			SET @startTime = (SELECT StartTime FROM RentalInfo WITH (INDEX(index_CID)) 
								WHERE CID = @CID AND EndTime IS NULL 
								AND CostOfRental IS NULL)

			DECLARE @totalHours AS NVARCHAR(128)
			SET @totalHours = (SELECT CONVERT(DECIMAL(10,2), DATEDIFF(MINUTE, @startTime, @endTime)/ 60.0))

			DECLARE @price AS FLOAT
			SET @price = (SELECT CAST(SUM(Price) AS DECIMAL(10,2)) FROM RentalInfo 
							JOIN RentalDetail ON RentalDetail.RID = RentalInfo.RID
							JOIN Bikes ON Bikes.BID = RentalDetail.BID
							JOIN BikeTypes ON BikeTypes.BTID = Bikes.BTID
							WHERE CID = @CID AND EndTime IS NULL)

			DECLARE @totalCost AS FLOAT
			SET @totalCost = @price * @totalHours

			UPDATE RentalInfo SET EndTime = @endTime, CostOfRental = @totalCost
			WHERE CID = @CID AND EndTime IS NULL AND CostOfRental IS NULL
			
			SELECT @totalCost AS TotalCost

			
			COMMIT TRANSACTION
			

	END	;
	