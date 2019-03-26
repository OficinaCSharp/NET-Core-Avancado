CREATE DATABASE Cadastro
GO 

USE Cadastro
GO

CREATE TABLE Pessoas (
id int primary key identity(1,1) not null,
nome varchar(100) not null, 
usuario varchar(75) unique not null
)
GO


INSERT INTO Pessoas(nome, usuario) 
VALUES ('Borja','Mito'),
('Goulart','Top'),
('Prass','Monstro'),
('Dudu','Guerreiro'),
('Arthur','Rei'),
('Jailson','Muro'),
('Lucas Limas','Deus Me livre'),
('Bruno Henrique','Mumia'),
('Mayke','Morto'),
('Marcos Rocha','Perdido'),
('Felipe Melo','Soco Soco Bate Bate')
GO

SELECT id, nome, usuario FROM Pessoas
GO

