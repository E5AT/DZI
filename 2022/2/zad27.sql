CREATE TABLE students(
ID INT NOT NULL IDENTITY PRIMARY KEY,
Name VARCHAR(20) NOT NULL,
BEL INT,
English INT,
Math INT,
Informatics INT,
IT INT
);

INSERT INTO students
VALUES('Antoniq Koleva',4,5,6,5,4),
('Asen Angelov',5,5,6,4,5),
('Borislav Ganew',4,4,5,5,6),
('Boqna Todorova',5,6,6,6,6),
('Waleri Iliew',6,6,6,6,6);

SELECT ID,BEL,English,Math,Informatics,IT
FROM students
WHERE ID=4;

SELECT COUNT(*)
FROM students
WHERE Math=6 AND Informatics=6 AND IT=6;

SELECT AVG(BEL) AS BEL_Average, AVG(Math) AS Math_Average
FROM students;

SELECT Name, (BEL+English+Math+Informatics+IT)/5 AS Average
FROM students
ORDER BY Average DESC, Name;
