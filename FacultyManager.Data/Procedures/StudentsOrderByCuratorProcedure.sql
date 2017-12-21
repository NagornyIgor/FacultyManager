USE FacultyManagerDb;
GO
CREATE PROCEDURE StudentsOrderedByСurator
@id int
AS
SET NOCOUNT ON;
SELECT * FROM Students WHERE Students.TeacherId = @id