CREATE TABLE students(
Admission_no INT NOT NULL PRIMARY KEY,
First_name VARCHAR(25) NOT NULL,
Last_name VARCHAR(25) NOT NULL,
City VARCHAR(25) NOT NULL
);

CREATE TABLE fee(
Admission_no INT NOT NULL,
Course VARCHAR(25),
Amount_paid INT NOT NULL,
FOREIGN KEY(Admission_no)
REFERENCES students(Admission_no)
);

INSERT INTO students
VALUES(3354,'Georgi','Georgiev','Varna'),
(4321,'Milena','Krasimirova','Stara Zagora'),
(8345,'Mihail','Martinov','Plovdiv'),
(7555,'Antonio','Tachev','Stara Zagora'),
(2135,'Martin','Iwanov','Sofiq');

INSERT INTO fee
VALUES(3354,'Java',2000),
(7555,'C#',1800),
(4321,'SQL',1600),
(4321,'Java',2000),
(8345,'C++',1700);

SELECT City
FROM students
WHERE Admission_no=8345;

SELECT First_name,Last_name,AVG(Amount_paid)
FROM students
JOIN fee
ON students.Admission_no = fee.Admission_no
GROUP BY First_name,Last_name;

UPDATE fee
SET Course='Java'
WHERE Amount_paid=1800;

SELECT Course,COUNT(*)
FROM fee
GROUP BY Course;

SELECT First_name,Last_name,Course
FROM students
LEFT JOIN fee
ON students.Admission_no=fee.Admission_no;
