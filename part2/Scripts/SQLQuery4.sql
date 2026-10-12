USE StudentTeacherMigrationTest;
GO
--use old db and get the sample data in the new EF db
BEGIN TRANSACTION;

--Users
INSERT INTO Users (Email, PasswordHash, Role)
SELECT Email, PasswordHash, Role
FROM StudentTeacherDB.dbo.Users;

--Teacher profiles
INSERT INTO Teacher_Profiles
    (UserId, EmployeeNumber, FirstName, LastName)
SELECT UserId, EmployeeNumber, FirstName, LastName
FROM StudentTeacherDB.dbo.Teacher_Profiles;

--Student profiles
INSERT INTO Student_Profiles
    (UserId, StudentNumber, FirstName, LastName)
SELECT UserId, StudentNumber, FirstName, LastName
FROM StudentTeacherDB.dbo.Student_Profiles;

--Course categories
INSERT INTO Course_Categories (Name, Description)
SELECT Name, Description
FROM StudentTeacherDB.dbo.Course_Categories;

--Courses
INSERT INTO Courses
    (TeacherProfileId, CourseCategoryId, Code, Title, Description, CreatedAt)
SELECT TeacherProfileId, CourseCategoryId, Code, Title, Description, CreatedAt
FROM StudentTeacherDB.dbo.Courses;

--Enrolments
INSERT INTO Enrolments
    (StudentProfileId, CourseId, EnrolledAt, Status)
SELECT StudentProfileId, CourseId, EnrolledAt, Status
FROM StudentTeacherDB.dbo.Enrolments;

--Course results
INSERT INTO Course_Results
    (EnrolmentId, FinalMark, Outcome, RecordedAt)
SELECT EnrolmentId, FinalMark, Outcome, RecordedAt
FROM StudentTeacherDB.dbo.Course_Results;

COMMIT TRANSACTION;