-- Drops views first (since they depend on tables)
IF OBJECT_ID('Member_Overview', 'V') IS NOT NULL
    DROP VIEW Member_Overview;
GO
-- Drops views first (since they depend on tables)


IF OBJECT_ID('Class_Overview', 'V') IS NOT NULL
    DROP VIEW Class_Overview;
GO

-- Drop junction table
IF OBJECT_ID('ClassMembers', 'U') IS NOT NULL
    DROP TABLE ClassMembers;
GO

-- Drop base tables
IF OBJECT_ID('Classes', 'U') IS NOT NULL
    DROP TABLE Classes;
GO

IF OBJECT_ID('Instructors', 'U') IS NOT NULL
    DROP TABLE Instructors;
GO

IF OBJECT_ID('Members', 'U') IS NOT NULL
    DROP TABLE Members;
GO

IF OBJECT_ID('Instructor_Overview', 'V') IS NOT NULL
    DROP VIEW Instructor_Overview;
GO

-- Members table
CREATE TABLE Members (
    MemberID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(100),
    SurName NVARCHAR(100),
    Email NVARCHAR(100),
    Telephone NVARCHAR(100),
    Birthday DATE,
    MemberType NVARCHAR(100),
    Active NVARCHAR(100)
);

-- Instructors table
CREATE TABLE Instructors (
    InstructorID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(100),
    SurName NVARCHAR(100),
    Email NVARCHAR(100),
    Telephone NVARCHAR(100),
    Certifications NVARCHAR(100),
    Active NVARCHAR(100)
);

-- Classes table
CREATE TABLE Classes (
    ClassID INT PRIMARY KEY IDENTITY(1,1),
    InstructorID INT FOREIGN KEY REFERENCES Instructors(InstructorID),
    ClassDate DATETIME,
    ClassTime NVARCHAR(100),
    ClassLocation NVARCHAR(100),
    ClassType NVARCHAR(100),
    ClassCapacity NVARCHAR(100)
);

-- Junction table: ClassMembers
CREATE TABLE ClassMembers (
    ClassID INT,
    MemberID INT,
    EnrolledDate DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (ClassID, MemberID, EnrolledDate),
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID),
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);
GO

-- Member_Overview: shows each member’s classes (past + future)

CREATE OR ALTER VIEW Member_Overview AS
SELECT  
    c.ClassType,
    c.ClassDate,
    i.FirstName + ' ' + i.SurName AS InstructorName,
    c.ClassCapacity,
    m.Birthday,
    c.ClassID,
    i.InstructorID,
    m.FirstName + ' ' + m.SurName AS MemberName,
    m.MemberID
FROM Classes c
INNER JOIN ClassMembers cm ON c.ClassID = cm.ClassID
INNER JOIN Members m ON cm.MemberID = m.MemberID
INNER JOIN Instructors i ON c.InstructorID = i.InstructorID;
GO


-- Class_Overview: shows each class with enrolled members, no EnrolledDate
CREATE OR ALTER VIEW Class_Overview AS
SELECT  
    c.ClassID,
    c.ClassDate,
    c.ClassTime,
    c.ClassLocation,
    c.ClassType,
    c.ClassCapacity,
    i.InstructorID,
    i.FirstName + ' ' + i.SurName AS InstructorName,
    m.MemberID,
    m.FirstName + ' ' + m.SurName AS MemberName
FROM Classes c
INNER JOIN Instructors i ON c.InstructorID = i.InstructorID
INNER JOIN ClassMembers cm ON c.ClassID = cm.ClassID
INNER JOIN Members m ON cm.MemberID = m.MemberID;
GO


CREATE OR ALTER VIEW Instructor_Overview AS
SELECT  
    c.ClassID,
    c.ClassDate,
    c.ClassTime,
    c.ClassLocation,
    c.ClassType,
    c.ClassCapacity,
    i.InstructorID,
    i.FirstName + ' ' + i.SurName AS InstructorName
FROM Classes c
INNER JOIN Instructors i ON c.InstructorID = i.InstructorID

GO
CREATE OR ALTER VIEW PopClassInd_Overview AS
SELECT
    c.ClassType,
    c.ClassDate,
    COUNT(cm.MemberID) AS MemberCount
FROM Classes c
INNER JOIN ClassMembers cm ON c.ClassID = cm.ClassID
GROUP BY
    c.ClassType,
    c.ClassDate;
GO

CREATE OR ALTER VIEW PopClassSum_Overview AS
SELECT
    c.ClassType,
    c.ClassDate,
    COUNT(cm.MemberID) AS TotalMembers
FROM Classes c
INNER JOIN ClassMembers cm ON c.ClassID = cm.ClassID
GROUP BY c.ClassType, c.ClassDate;
GO

GO

IF OBJECT_ID('PopClassSum_Overview', 'V') IS NOT NULL
    DROP VIEW Class_Overview;
GO

SELECT * FROM PopClassInd_Overview;
SELECT * FROM PopClassSum_Overview;

SELECT ClassType, ClassDate, SUM(MemberCount) AS MemberCount
FROM PopClassInd_Overview
WHERE ClassDate BETWEEN @StartDate AND @EndDate
GROUP BY ClassType, ClassDate
ORDER BY MemberCount DESC;

SELECT ClassType, SUM(TotalMembers) AS TotalMembers
FROM PopClassSum_Overview
WHERE ClassDate BETWEEN @StartDate AND @EndDate
GROUP BY ClassType, ClassDate
ORDER BY TotalMembers DESC;





-- Insert 25 members
INSERT INTO Members (FirstName, SurName, Email, Telephone, Birthday, MemberType, Active) VALUES
('Anna','Jensen','anna@email.com','30000001','1990-05-12','Basic','Active'),
('Mikkel','Larsen','mikkel@email.com','30000002','1985-09-23','Basic','Active'),
('Sofie','Nielsen','sofie@email.com','30000003','1992-11-02','Basic','Active'),
('Jonas','Christensen','jonas@email.com','30000004','1988-03-15','Basic','Active'),
('Emma','Poulsen','emma@email.com','30000005','1995-07-30','Basic','Active'),
('Frederik','Hansen','frederik@email.com','30000006','1987-01-10','Basic','Active'),
('Laura','Mortensen','laura@email.com','30000007','1993-04-22','Basic','Active'),
('Oliver','Andersen','oliver@email.com','30000008','1991-06-18','Basic','Active'),
('Ida','Thomsen','ida@email.com','30000009','1994-09-05','Basic','Active'),
('Victor','Knudsen','victor@email.com','30000010','1989-12-25','Basic','Active'),
('Katrine','Holm','katrine@email.com','30000011','1996-08-14','Basic','Active'),
('Sebastian','Madsen','sebastian@email.com','30000012','1984-02-19','Basic','Active'),
('Julie','Petersen','julie@email.com','30000013','1991-10-03','Basic','Active'),
('Christian','Berg','christian@email.com','30000014','1986-07-12','Basic','Active'),
('Amalie','Krogh','amalie@email.com','30000015','1993-11-22','Basic','Active'),
('Nikolaj','Brandt','nikolaj@email.com','30000016','1988-04-09','Basic','Active'),
('Camilla','Friis','camilla@email.com','30000017','1992-06-15','Basic','Active'),
('Mathias','Lauridsen','mathias@email.com','30000018','1989-09-28','Basic','Active'),
('Louise','Winther','louise@email.com','30000019','1994-12-01','Basic','Active'),
('Anders','Dam','anders@email.com','30000020','1987-03-17','Basic','Active'),
('Maria','Kjær','maria@email.com','30000021','1990-08-21','Basic','Active'),
('Thomas','Lund','thomas@email.com','30000022','1985-02-11','Basic','Active'),
('Line','Østergaard','line@email.com','30000023','1993-09-19','Basic','Active'),
('Henrik','Vester','henrik@email.com','30000024','1988-12-07','Basic','Active'),
('Pernille','Christoffersen','pernille@email.com','30000025','1992-04-30','Basic','Active');

-- Insert 3 instructors (Yoga, Trail Running, Both)
INSERT INTO Instructors (FirstName, SurName, Email, Telephone, Certifications, Active) VALUES
('Peter','Andersen','peter@email.com','40000001','Yoga Certificate','Active'),
('Maria','Hansen','maria@email.com','40000002','Trail Running Certificate','Active'),
('Thomas','Olsen','thomas@email.com','40000003','Yoga Certificate, Trail Running Certificate','Active');

-- Insert several classes (3 past, 3 future, alternating types)
INSERT INTO Classes (InstructorID, ClassDate, ClassTime, ClassLocation, ClassType, ClassCapacity) VALUES
(1,'2025-11-10','10:00','Studio A','Yoga',20),
(2,'2025-11-17','14:00','Trail Center','Trail Running',15),
(3,'2025-11-24','18:00','Studio B','Yoga',25),
(1,'2025-12-08','10:00','Studio A','Yoga',20),
(2,'2025-12-15','14:00','Trail Center','Trail Running',15),
(3,'2025-12-22','18:00','Studio B','Yoga',25);

-- Enroll members (each in 2 past + 2 future classes)
INSERT INTO ClassMembers (ClassID, MemberID) VALUES
(1,1),(2,1),(4,1),(5,1),
(2,2),(3,2),(5,2),(6,2),
(1,3),(3,3),(4,3),(6,3),
(1,4),(2,4),(4,4),(5,4),
(2,5),(3,5),(5,5),(6,5),
(1,6),(3,6),(4,6),(6,6),
(1,7),(2,7),(4,7),(5,7),
(2,8),(3,8),(5,8),(6,8),
(1,9),(3,9),(4,9),(6,9),
(1,10),(2,10),(4,10),(5,10),
(2,11),(3,11),(5,11),(6,11),
(1,12),(3,12),(4,12),(6,12),
(1,13),(2,13),(4,13),(5,13),
(2,14),(3,14),(5,14),(6,14),
(1,15),(3,15),(4,15),(6,15),
(1,16),(2,16),(4,16),(5,16),
(2,17),(3,17),(5,17),(6,17),
(1,18),(3,18),(4,18),(6,18),
(1,19),(2,19),(4,19),(5,19),
(2,20),(3,20),(5,20),(6,20),
(1,21),(3,21),(4,21),(6,21),
(1,22),(2,22),(4,22),(5,22),
(2,23),(3,23),(5,23),(6,23),
(1,24),(3,24),(4,24),(6,24),
(1,25),(2,25),(4,25),(5,25);

