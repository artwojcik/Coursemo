--INSERT INTO Departments(Department)
--SELECT * FROM(SELECT Department) AS tmp
--WHERE NOT EXISTS(
--    SELECT Department FROM Departments WHERE Department = 'CS'
--) 
--LIMIT 1

INSERT INTO Departments
(
    Department
)
VALUES
(N'' -- Department - nvarchar(16)
    )


CREATE TABLE Departmentse (
	DID			INT IDENTITY(1,1) PRIMARY KEY , 
	Department  NVARCHAR(16)NOT NULL
	UNIQUE (Department)
); 


