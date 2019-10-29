--Query the database for all the Exercises.
--SELECT * FROM Exercise

--Find all the exercises in the database where the language is JavaScript.
--SELECT * FROM Exercise
--WHERE Language = 'JavaScript';

--Insert a new exercise into the database.
--INSERT INTO Exercise (Name, Language) VALUES ('Heist', 'C#')
--SELECT * FROM Exercise

--Find all instructors in the database. Include each instructor's cohort.
--SELECT i.FirstName,
--		i.LastName,
--		c.Name
--FROM Instructor i 
--	LEFT JOIN Cohort c on i.CohortId = c.Id

--Insert a new instructor into the database. Assign the instructor to an existing cohort.
--INSERT INTO Instructor (FirstName, LastName, SlackHandle, Speciality, CohortId) VALUES ('Brenda', 'Long', 'cssMyFav', 'css', 2)
--SELECT * FROM Instructor

--Assign an existing exercise to an existing student.