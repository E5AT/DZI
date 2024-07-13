CREATE table Mountains(
ID INT NOT NULL IDENTITY primary key,
MountainName NVARCHAR(20) NOT NULL,
CountryCode char(3) NOT NULL,
Country NVARCHAR(20)
);

CREATE table Peaks(
ID INT NOT NULL IDENTITY primary key,
PeakName NVARCHAR(20) NOT NULL,
Elevation INT NOT NULL,
MountainID INT NOT NULL
references Mountains(ID),
CHECK(Elevation>0)
);

insert into Mountains
VALUES
('Рила','BUL','България'),
('Пирин','BUL','България'),
('Стара Планина','BUL','България'),
('Анди','ARG','Аржентина'),
('Анди','CHL','Чили'),
('Хималаи','NPL','Непал'),
('Алпи','SUI','Швейцария'),
('Алпи','ITA','Италия'),
('Алпи','AUT','Австрия'),
('Алпи','FRA','Франция'),
('Елбрус','RUS','Русия'),
('Елбрус','GЕО','Грузия');

insert into Peaks
VALUES
('Аконкагуа',6962,4),
('Ботев',2376,3),
('Мусала',2925,1),
('Еверест',8849,6),
('Вихрен',2914,2),
('Мальовица',2729,1),
('Монблан',4809,10),
('Матерхорн',4478,8),
('Дюфур',4634,7),
('Елбрус',5642,11),
('Ком',2015,3),
('Манаслу',2729,6),
('Дено',2790,1);

update Peaks
set Elevation=2016
WHERE Elevation=2015;

select avg(Elevation)
FROM Peaks
WHERE MountainID=1;

select COUNT(*)
FROM Peaks
WHERE Elevation>=5000 AND Elevation<=9000;

select PeakName,Elevation,MountainName,Country
from Peaks
join Mountains
ON MountainID=Mountains.ID
WHERE Elevation>2900
order by Country,Elevation desc;

select Country,COUNT(*)
FROM Mountains
group by Country
order by COUNT(*) desc, Country;
