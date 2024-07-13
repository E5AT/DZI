CREATE TABLE Authors(
ID INT NOT NULL IDENTITY PRIMARY KEY,
Name VARCHAR(20) NOT NULL
);

CREATE TABLE Books(
ID INT NOT NULL IDENTITY PRIMARY KEY,
Title VARCHAR(100) NOT NULL,
ISBN VARCHAR(20),
Published INT NOT NULL
);

CREATE TABLE Library(
AuthorID INT,
BookID INT,
Rented DATE,
  FOREIGN KEY(AuthorID) REFERENCES Authors(ID) ON DELETE SET NULL,
  FOREIGN KEY(BookID) REFERENCES Books(ID) ON DELETE SET NULL
);

INSERT INTO Authors
VALUES
('Bjarne Stroustrup'),
('Stanley Lippman'),
('Paul Deitel'),
('Harvey Deitel'),
('Herb Sutter'),
('Mike Hendrickson'),
('Andrew Koenig'),
('Barbara Moo');

INSERT INTO Books(Title,ISBN,Published)
VALUES
('The C++ Programming Language, 4th Edition','9780275967307',2013),
('Tour of C++, A 3rd Edition','0136816487', 2022),
('C++ Primer 5th Edition','9780321714114',2012),
('Essential C++ 1st Edition','9780201485189',1999),
('C++ Gems: Programming Pearls from The C++ Report 320th Edition','9780135705810',1997),
('A Tour of C++ (C++ In-Depth Series) 1st Edition','9780321958310',2013),
('C++ How to Program 10th Edition','9780134448237',2016),
('Exceptional C++: 47 Engineering Puzzles, Programming Problems, and Solutions','9780201615623',1999),
('More Exceptional C++: 40 New Engineering Puzzles, Programming Problems, and Solutions 1st Edition','9780201704341',2001),
('Accelerated C++: Practical Programming by Example 1st Edition','9780201703535',2000);

INSERT INTO Library
VALUES
(1, 1, '1/1/2023'),
(1, 2, '1/1/2023'),
(2, 3, '1/1/2023'),
(2, 4, '1/1/2023'),
(2, 5, '1/1/2023'),
(1, 6, '1/2/2023'),
(3, 7, '1/2/2023'),
(4, 7, '1/2/2023'),
(5, 8, '1/2/2023'),
(5, 9, '1/2/2023'),
(6, 10, '1/3/2023'),
(7, 10, '1/3/2023'),
(8, 10, '1/3/2023')
;

select Title
FROM Books;

select Name
from Authors;

SELECT Name, COUNT(BookID)
FROM Authors
JOIN Library ON Authors.ID = Library.AuthorID
GROUP BY Name
HAVING COUNT(BookID) > 1;

SELECT Title, COUNT(AuthorID)
FROM Books
JOIN Library ON Books.ID = Library.BookID
GROUP BY Title
HAVING COUNT(AuthorID) > 1;

SELECT Title
FROM Books
Join Library
ON Books.ID = Library.BookID
GROUP BY Title
HAVING COUNT(BookID)=1;

DELETE Books
where Title = 'Accelerated C++: Practical Programming by Example 1st Edition';
