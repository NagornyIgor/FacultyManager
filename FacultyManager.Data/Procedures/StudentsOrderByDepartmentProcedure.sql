USE FacultyManagerDb;
GO
CREATE PROCEDURE StudentsOrderedByDepartment
@id int
AS
SELECT * FROM Students WHERE Students.DepartmentId = @id