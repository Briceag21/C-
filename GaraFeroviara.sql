SET DATEFORMAT dmy
USE master
GO
IF EXISTS(SELECT'True' FROM SYS.DATABASES WHERE NAME='Garaferoviara')
BEGIN
DROP DATABASE  Garaferoviara
END
GO
CREATE DATABASE  Garaferoviara
GO
USE Garaferoviara
Go
CREATE TABLE Login
(
	idLogara INT IDENTITY(1,1) PRIMARY KEY,
	userLogin VARCHAR(15) NOT NULL,
	userPassword VARCHAR(35) NOT NULL

)
					Insert into Login values 
											('admin','admin'),
											('a','a')
GO

--crearea tabelelor
CREATE TABLE Gara(
					IDGara int primary key,
					Denumire varchar(30),
					Localitate varchar(30)
					)
CREATE TABLE Gara1(
					IDGara int primary key,
					Denumire varchar(30),
					Localitate varchar(30)
					)
Create table Angajat(
					IdAngajat int primary key,
					Functie varchar(20),
					Nume varchar(20),
					Datanasterii date,
					IDNP NVARCHAR(13) UNIQUE,
					IDGara int foreign key references Gara(IDGara)
					)
Create Table Client(
					IDClient int primary key,
					Nume varchar(30),
					DataNasterii date,
					IDNP NVARCHAR(13) unique
					)


			create table Orar (
				IdOrar int primary key, 
				TimpPornire  Time ,
				TimpSosire    time 
			--	IdTraseu  int foreign key references Traseu(IdTraseu)
	
				
				)
				create table Tren 
				(IdTren int primary key,
				NrLocuri int )
Create Table Cursa(
				IDCursa int primary key,
				IDGARA1 INT FOREIGN KEY REFERENCES GARA(IDGARA),
				IDGARA2 INT FOREIGN KEY REFERENCES GARA1(IDGARA),
				PRET MONEY,
				IdOrar int foreign key references Orar(IdOrar),
				Comfort int ,
				IdTren int foreign key references Tren(IdTren) , 
				Stare nvarchar(30)
				)					
				--  (1,5,10,100,38,1,'Anulata'),
Create Table Bilet(
					IDBilet int primary key,
					IDClient int foreign key references Client(IdClient),
					--IDTraseu int foreign key references Traseu(IdTraseu),
					IDCursa int foreign key references Cursa(IdCursa),
					Data varchar(30)
					)


--inserea datelor
INSERT INTO Gara Values
(1,'Chisinau-1', 'Chisinau'),
(2,'Chisinau-1', 'Chisinau'),
(3,'Balti-Oras', 'Balti'),
(4,'Bender',	 'Bender'),
(5,'Straseni',   'Straseni'),
(6,'Ungheni',	 'Ungheni'),
(7,'Moscova',	 'Moscova'),
(8,'Kiev',		 'Kiev'),
(9,'Odesa',		 'Odesa'),
(10,'Bucuresti','Bucuresti'),
(11,'Iasi',		'Iasi'),
(12,'Iasi-Socola','Iasi'),
(13,'Sankt-Petersburg', 'Sankt-Petersburg'),
(14,'Caluga-2', 'Caluga'),
(15,'Minsk', 'Minsk'),
(16,'Bacau',  'Bacau'),
(17,'Focsani','Focsani'),
(18,'Falesti', 'Falesti'),
(19,'Dondusani','Dondusani'),
(20,'Briansc','Briansc')
GO
--COPIEREA TABELULUI GARA IN TAVELUL GARA1
INSERT INTO GARA1
SELECT * FROM GARA
GO

insert into Angajat values
(1, 'Sudor', 'Andrei Popescu', '11.11.1971', 21417429219, 1),
(2, 'Mecanic','Alexandru Ionescu','10.10.1972', 32891739127, 1),
(3, 'Consilier','Soltan Corneliu', '09.09.1973', 321361236121,1),
(4, 'Director', 'Oleg Tofilat', '08.08.1974', 3213198739127, 1),
(5, 'Taxatoare', 'Olga Tofilat', '07.07.1975', 412479187492, 1),
(6, 'Regulator', 'Ion Ceban', '06.06.1976', 3213123112, 1),
(7, 'Masinist', 'Stefan Stoica', '05.05.1977', 1274981274, 1),
(8, 'Masinist', 'Stefan Ursu', '05.05.1977', 1274211274, 2),
(9, 'Taxator', 'Sorin Sirbu', '04.04.1978', 42174928179, 3),
(10,'Masinist', 'Gheorghe Balan', '03.03.1980', 27419472917, 4),
(11,'Masinist', 'Ion Cebotari', '02.02.1981', 32173217132, 5),
(12,'Masinist', 'Mihai Grosu', '01.01.1982', 472618746121, 6),
(13,'Masinist', 'Sergiu Chiric','30.12.1983', 1987429187142, 7),
(14,'Regulator', 'Chirill Unureanu', '29.10.1984', 4124814214, 8),
(15,'Regulator,', 'Cristian Miron', '28.11.1985', 421749217712, 9)

Insert into Client Values
(1, 'Ion Malai', '01.01.1999', 41242141242),
(2, 'Andrei Codreanu','02.02.1998', 412412412),
(3, 'Sergiu Istrati', '03.03.1997', 4189274981),
(4, 'Pavel Stratan', '04.04.1996', 49187249281),
(5, 'Cristian Vicol', '05.05.1995', 412142148142),
(6, 'Radu Toma', '06.06.1994', 1246218764214),
(7, 'Victor Vroitoru', '07.07.1993', 4198241981),
(8, 'Veaceslav Stratulat', '08.08.1992', 123141241),
(9, 'Liviu Topal', '09.09.1991', 42164877416),
(10,'Maxim Tataru', '10.10.1990', 4129847129),
(11, 'Alexandru Pascal', '11.11.2000',498217498127),
(12, 'Mihaela Birca', '12.12.2001', 782418712142),
(13, 'Cristina Bors', '03.01.2000', 481274981212),
(14, 'Diana Mardari', '06.02.1989', 4124281790412),
(15, 'Alnia Postolachi', '10.03.1999', 19827409112),
(16,'Winifred Summers','13.08.12',59626381527),
  (17,'Nicole Simpson','02.11.87',41620375200),
  (18,'Oren Palmer','01.11.93',35028767536),
  (19,'Rajah Ingram','22.11.02',24960421455),
  (20,'Autumn Downs','24.06.09',44421833618),
  (21,'Quamar Hester','23.06.82',46116494330),
  (22,'Elliott Haley','24.06.05',67938157622),
  (23,'Brianna Bolton','20.04.13',36942491662),
  (24,'Slade Cantrell','12.01.03',68334145349),
  (25,'Jonas Kirby','05.07.97',30265651624),
  (26,'Rebekah Kirkland','09.11.10',26944294257),
  (27,'Wyatt Pate','04.02.92',52815183750),
  (28,'Lacota Branch','13.10.95',80678590735),
  (29,'Blossom Perry','14.02.83',50966541665),
  (30,'Shaeleigh Reynolds','15.04.03',43520592807),
  (31,'Timothy Woods','23.08.04',37634514725),
  (32,'Fritz Ayers','25.09.10',57370585241),
  (33,'Vanna Mathews','27.07.86',35569221924),
  (34,'Channing Hall','24.11.90',44235558685),
  (35,'Mufutau O''brien','12.01.92',54933669501),
  (36,'Baker Campos','11.02.05',80649178169),
  (37,'Eliana Tucker','23.07.94',41109832938),
  (38,'Amos Maldonado','27.11.13',42945821449),
  (39,'Tana Stone','25.06.12',13394430454),
  (40,'Quail Carpenter','03.02.01',18955086659),
  (41,'Holly Sweet','19.01.05',79983255485),
  (42,'Kyra Byers','07.05.08',52384386341),
  (43,'Larissa Vang','21.10.93',67280295236),
  (44,'Oliver Jarvis','05.02.98',80971613171),
  (45,'Kaye Terrell','12.09.89',87443082257),
  (46,'Angelica Meyer','28.03.04',64596895083),
  (47,'Cameron Lowery','07.10.89',18510742030),
  (48,'Stewart Carney','28.02.84',50761487974),
  (49,'Galena Zimmerman','09.06.99',82508230296),
  (50,'Edan Brock','17.05.00',67947885435),
  (51,'Rowan Roman','26.02.94',68990569043),
  (52,'Bertha Patrick','12.12.11',78913692607),
  (53,'Hayfa Rosa','12.12.01',74667766132),
  (54,'Timothy Fernandez','07.02.94',16114647959),
  (55,'Serina Montgomery','28.08.83',62295289670),
  (56,'Hector Byrd','16.10.83',48673003712),
  (57,'Wallace Daniels','13.04.92',54078275084),
  (58,'Althea Richmond','11.08.93',58532473672),
  (59,'Quentin Beck','06.05.00',47868974851),
  (60,'Ginger Martinez','06.02.08',26692583688),
  (61,'Gavin Curry','06.02.97',26357375681),
  (62,'David Guerrero','25.07.00',27087697022),
  (63,'Yetta Irwin','02.12.14',41558175212),
  (64,'Thomas Sanford','01.10.81',31547076892),
  (65,'Cassady Sims','02.06.02',20159291699),
  (66,'Demetrius Stark','03.01.94',80234566223),
  (67,'Judith Noble','30.05.10',11220221979),
  (68,'Jaquelyn Anderson','07.05.00',24181436820),
  (69,'Roth Wilder','10.09.11',38573461236),
  (70,'Chelsea Benton','31.10.04',38112045845),
  (71,'Diana Shelton','11.05.13',71826895605),
  (72,'Maggy Kane','21.09.83',60028445318),
  (73,'Germaine Rodgers','02.03.04',83634100660),
  (74,'Nolan Gibson','26.08.06',72832534875),
  (75,'Alec Ortega','16.12.90',28471665627),
  (76,'Meghan Rivers','06.03.09',14345525105),
  (77,'Dawn Bolton','01.07.92',61880450862),
  (78,'Brian Goodwin','30.08.86',55444914300),
  (79,'Aretha Sweet','23.05.07',51829413359),
  (80,'Nissim Moss','06.03.83',73472070118)




  
INSERT INTO Orar
VALUES
  (1,'7:30','10:59'),
  (2,'7:09','10:21'),
  (3,'6:22','10:34'),
  (4,'6:06','10:12'),
  (5,'7:07','10:56'),
  (6,'6:39','11:39'),
  (7,'6:11','11:33'),
  (8,'6:02','11:07'),
  (9,'7:01','11:37'),
  (10,'7:24','10:02'),
  (11,'6:48','10:10'),
  (12,'7:24','11:21'),
  (13,'6:55','11:49'),
  (14,'6:09','10:16'),
  (15,'6:18','11:28'),
  (16,'6:52','10:02'),
  (17,'7:02','11:15'),
  (18,'7:13','11:03'),
  (19,'6:45','10:34'),
  (20,'7:27','10:04'),
    (21,'12:18','16:12'),
  (22,'13:38','16:01'),
  (23,'12:09','16:46'),
  (24,'13:52','15:03'),
  (25,'13:35','16:21'),
  (26,'12:12','16:08'),
  (27,'13:41','16:54'),
  (28,'12:00','16:53'),
  (29,'13:33','15:57'),
  (30,'12:26','15:05'),
  (31,'13:30','16:01'),
  (32,'12:46','16:25'),
  (33,'13:28','15:31'),
  (34,'13:45','16:16'),
  (35,'13:06','16:52'),
  (36,'12:24','16:53'),
  (37,'12:41','15:51'),
  (38,'13:08','15:08'),
  (39,'13:00','16:04'),
  (40,'12:46','16:06')

  Insert into Tren values 
    (1,100),
  (2,100),
  (3,150),
  (4,150),
  (5,200),
  (6,200),
  (7,250),
  (8,250),
  (9,300),
  (10,300)
  INSERT INTO Cursa VALUES

 			--IDCursa int primary key,
				--IDGARA1 INT FOREIGN KEY REFERENCES GARA(IDGARA),
				--IDGARA2 INT FOREIGN KEY REFERENCES GARA1(IDGARA),
				--PRET MONEY,
				--IdOrar int foreign key references Orar(IdOrar),
				--Comfort int ,
				--Stare varchar(30)
   (1,18,5,100,3,4,1,'Anulata'),
  (2,9,17,100,26,1,7,'Neanulata'),
  (3,14,10,150,24,2,6,'Neanulata'),
  (4,17,11,150,5,7,8,'Neanulata'),
  (5,18,7,200,7,5,8,'Anulata'),
  (6,18,5,200,28,4,2,'Neanulata'),
  (7,10,3,250,17,3,9,'Neanulata'),
  (8,4,9,250,26,10,5,'Anulata'),
  (9,18,12,300,27,7,5,'Anulata'),
  (10,9,12,300,33,9,8,'Anulata'),
  (11,9,15,100,3,8,7,'Anulata'),
  (12,1,12,100,40,9,5,'Anulata'),
  (13,12,7,150,19,1,7,'Neanulata'),
  (14,2,19,150,35,4,4,'Neanulata'),
  (15,10,14,200,18,8,9,'Anulata'),
  (16,5,5,200,39,3,9,'Neanulata'),
  (17,14,4,250,4,3,7,'Anulata'),
  (18,13,13,250,17,6,5,'Neanulata'),
  (19,5,2,300,38,1,3,'Neanulata'),
  (20,11,10,300,37,3,2,'Anulata'),
  (21,5,7,100,30,2,5,'Anulata'),
  (22,8,15,100,12,5,6,'Neanulata'),
  (23,17,3,150,9,4,2,'Anulata'),
  (24,17,10,150,36,8,6,'Neanulata'),
  (25,11,15,200,37,4,8,'Anulata'),
  (26,10,18,200,24,7,8,'Neanulata'),
  (27,6,19,250,14,2,2,'Anulata'),
  (28,20,5,250,32,3,10,'Anulata'),
  (29,10,11,300,26,3,4,'Neanulata'),
  (30,11,2,300,9,8,2,'Neanulata'),
  (31,3,2,100,18,7,3,'Anulata'),
  (32,16,17,100,19,6,3,'Anulata'),
  (33,11,10,150,34,4,5,'Anulata'),
  (34,8,4,150,20,5,8,'Neanulata'),
  (35,4,11,200,13,5,5,'Anulata'),
  (36,13,15,200,23,5,8,'Anulata'),
  (37,10,10,250,26,4,1,'Neanulata'),
  (38,11,16,250,34,6,9,'Neanulata'),
  (39,2,3,300,5,2,7,'Anulata'),
  (40,6,15,300,29,2,7,'Anulata'),
  (41,19,7,100,33,7,3,'Anulata'),
  (42,6,3,100,26,5,2,'Neanulata'),
  (43,7,3,150,12,8,3,'Neanulata'),
  (44,13,19,150,13,5,9,'Anulata'),
  (45,12,6,200,20,3,9,'Anulata'),
  (46,8,17,200,20,4,4,'Anulata'),
  (47,15,9,250,6,9,6,'Neanulata'),
  (48,1,3,250,37,2,10,'Neanulata'),
  (49,12,16,300,16,3,2,'Neanulata'),
  (50,5,5,300,39,1,3,'Anulata'),
   (51,12,9,100,26,7,7,'Anulata'),
  (52,1,8,100,27,3,2,'Anulata'),
  (53,1,9,150,18,10,10,'Anulata'),
  (54,3,8,150,35,5,5,'Neanulata'),
  (55,13,6,200,8,10,10,'Anulata'),
  (56,15,3,200,14,7,7,'Neanulata'),
  (57,6,15,250,9,3,4,'Neanulata'),
  (58,5,14,250,23,5,7,'Anulata'),
  (59,18,7,300,8,9,5,'Anulata'),
  (60,7,15,300,27,4,7,'Anulata'),
  (61,4,9,100,32,6,4,'Anulata'),
  (62,14,20,100,10,5,1,'Neanulata'),
  (63,13,2,150,33,1,4,'Anulata'),
  (64,12,2,150,29,4,7,'Anulata'),
  (65,18,16,200,31,3,3,'Neanulata'),
  (66,12,19,200,26,2,9,'Neanulata'),
  (67,6,17,250,26,8,5,'Neanulata'),
  (68,15,12,250,16,6,9,'Neanulata'),
  (69,15,20,300,5,5,8,'Anulata'),
  (70,9,16,300,24,3,4,'Neanulata'),
  (71,6,3,100,27,7,2,'Anulata'),
  (72,7,4,100,21,5,4,'Anulata'),
  (73,5,14,150,20,1,10,'Neanulata'),
  (74,2,8,150,16,9,3,'Neanulata'),
  (75,19,18,200,29,5,8,'Neanulata'),
  (76,11,15,200,21,4,6,'Anulata'),
  (77,14,17,250,17,6,8,'Neanulata'),
  (78,7,12,250,20,4,4,'Neanulata'),
  (79,6,6,300,6,4,2,'Anulata'),
  (80,12,14,300,31,8,3,'Neanulata')

INSERT INTO BILET VALUES
(1,1,1,'05.27.22'),
  (2,2,2,'05.11.22'),
  (3,3,3,'05.15.22'),
  (4,4,4,'05.13.22'),
  (5,5,5,'05.15.22'),
  (6,6,6,'05.02.22'),
  (7,7,7,'05.18.22'),
  (8,8,8,'05.05.22'),
  (9,9,9,'05.22.22'),
  (10,10,10,'05.18.22'),
  (11,11,11,'05.16.22'),
  (12,12,12,'05.21.22'),
  (13,13,13,'05.04.22'),
  (14,14,14,'05.31.22'),
  (15,15,15,'05.02.22'),
  (16,16,16,'05.11.22'),
  (17,17,17,'05.14.22'),
  (18,18,18,'05.08.22'),
  (19,19,19,'05.06.22'),
  (20,20,20,'05.26.22'),
  (21,21,21,'05.05.22'),
  (22,22,22,'05.01.22'),
  (23,23,23,'05.20.22'),
  (24,24,24,'05.21.22'),
  (25,25,25,'05.08.22'),
  (26,26,26,'05.10.22'),
  (27,27,27,'05.11.22'),
  (28,28,28,'05.14.22'),
  (29,29,29,'05.15.22'),
  (30,30,30,'05.23.22'),
  (31,31,31,'05.20.22'),
  (32,32,32,'05.16.22'),
  (33,33,33,'05.31.22'),
  (34,34,34,'05.22.22'),
  (35,35,35,'05.06.22'),
  (36,36,36,'05.17.22'),
  (37,37,37,'05.18.22'),
  (38,38,38,'05.29.22'),
  (39,39,39,'05.21.22'),
  (40,40,40,'05.24.22'),
  (41,41,41,'05.26.22'),
  (42,42,42,'05.27.22'),
  (43,43,43,'05.13.22'),
  (44,44,44,'05.24.22'),
  (45,45,45,'05.05.22'),
  (46,46,46,'05.10.22'),
  (47,47,47,'05.15.22'),
  (48,48,48,'05.25.22'),
  (49,49,49,'05.12.22'),
  (50,50,50,'05.26.22'),
  (51,51,51,'05.13.22'),
  (52,52,52,'05.16.22'),
  (53,53,53,'05.09.22'),
  (54,54,54,'05.26.22'),
  (55,55,55,'05.30.22'),
  (56,56,56,'05.05.22'),
  (57,57,57,'05.29.22'),
  (58,58,58,'05.14.22'),
  (59,59,59,'05.04.22'),
  (60,60,60,'05.07.22'),
  (61,61,61,'05.12.22'),
  (62,62,62,'05.01.22'),
  (63,63,63,'05.18.22'),
  (64,64,64,'05.03.22'),
  (65,65,65,'05.08.22'),
  (66,66,66,'05.20.22'),
  (67,67,67,'05.22.22'),
  (68,68,68,'05.14.22'),
  (69,69,69,'05.24.22'),
  (70,70,70,'05.21.22'),
  (71,71,71,'05.04.22'),
  (72,72,72,'05.08.22'),
  (73,73,73,'05.27.22'),
  (74,74,74,'05.05.22'),
  (75,75,75,'05.06.22'),
  (76,76,76,'05.04.22'),
  (77,77,77,'05.15.22'),
  (78,78,78,'05.06.22'),
  (79,79,79,'05.27.22'),
  (80,80,80,'05.29.22')


GO
--afisarea persoanei ce a cumparat bilet, tarseul pe care merge, data si pretul biletului
--CREATE VIEW [INFORMATIE_BILET] AS
--SELECT NUME, G.Denumire AS Pornire, G1.Denumire as STATIONARE, DATA, PRET
--FROM Gara G, Gara1 G1, Bilet B, TRASEU T, Client C
--WHERE T.IDGARA1=G.IDGara AND T.IDGARA2=G1.IDGara
--AND B.IDTraseu =T.IDTraseu AND C.IDClient = B.IDClient
--GO
--  --afisarea numarului de calatorii a fiecarui pasager
--  CREATE VIEW [NumarDeCalatorii] as
--	Select c.nume,  count(b.idClient) as [numar de calatorii]
--	from Bilet b, Client c
--	where b.IDClient=c.IDClient
--	group by  nume
  GO


GO
select * from Angajat

--select * from orar
--select*from Angajat
--select *from Gara
--select  * from Gara1
--select * from Bilet
--Select * from Traseu
--select * from TransportClienti
--Select* from Client
select*from Cursa