CREATE TABLE laptops(
ID INT NOT NULL IDENTITY PRIMARY KEY,
Марка VARCHAR(50),
Модел VARCHAR(50),
Наличност INT,
Цена INT
);

INSERT INTO laptops
VALUES('Laptop1','L29KAS',10,1100),
('Laptop2','15FDR7',14,1350),
('Laptop3','L29GTA',12,1500),
('Laptop4','L29DFT',8,1499),
('Laptop5','15FDM5',11,1600);

DELETE laptops
WHERE Модел='15FDR7';

SELECT Модел, (Наличност*Цена)*1.2
FROM laptops;

SELECT sum(Наличност)
FROM laptops
WHERE Марка='Laptop1';
