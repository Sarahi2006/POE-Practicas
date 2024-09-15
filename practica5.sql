USE LibraryDB

-- Tabla Book
INSERT INTO Books 
VALUES ('El principito','Pablo Neruda', 1998),
('Romeo y Julieta','William sheaspeare',1998),
('El Hobbit','J.R.R Tolkien',1937),
('Don Quijote de la mancha','Miguel de Cervantes',1605),
('Cien años de soledad','Gabriel garcia',1967)

SELECT BookID, Title, Author, PublishedYear FROM Books

SELECT Title FROM Books

SELECT * FROM Books WHERE PublishedYear = 1992

UPDATE Books SET Title = 'El arte de la guerra', Author = 'Sun Tzu' WHERE BookID = 4

-- Tabla members

INSERT INTO Members 
VALUES ('Itamar Medrano','2024-09-11','itamar@mail.com'),
('Sarahi Martinez','2024-09-13','sarahi@mail.com'),
('Steisy Benitez','2024-09-28','steisy@mail.com'),
('Gustavo Rivas','2024-09-21','gustavo@mail.com'),
('Erick Martinez','2023-09-11','erick@mail.com')

SELECT * FROM Members

UPDATE Members SET FullName = 'Orlin Manzanares' WHERE MemberID = 4

DELETE FROM Members WHERE MemberID = 2

-- Tabla Loans

INSERT INTO Loans
VALUES ('2024-09-11', 3, 1)

SELECT * FROM Loans


UPDATE Loans SET BookID = 3 WHERE LoanID = 1

DELETE FROM Loans WHERE LoanID = 1
