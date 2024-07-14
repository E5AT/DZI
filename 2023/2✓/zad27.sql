CREATE TABLE singers(
id INT NOT NULL IDENTITY PRIMARY KEY,
name VARCHAR(20),
songs INT,
rank INT,
networth INT
);

INSERT INTO singers
VALUES
('Ivan Ivanov', 50, 1, 1000000),
('Maria Ivanova', 55, 3, 900000),
('Georgi Georgiev', 20, 4, 800000),
('Gergana Petrova', 55, 2, 1000000),
('Boris Borisov', 20, 5, 900000);

SELECT rank, name
FROM singers
WHERE rank<=3
ORDER BY rank;

SELECT SUM(songs), AVG(networth) / 1.95583
FROM singers;

UPDATE singers
SET networth = networth+networth*0.1
WHERE id IN (2,3,4);
