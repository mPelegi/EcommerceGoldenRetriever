/* E01 - EcommerceGoldenRetriever: */

--DROP TABLE Vacinacao;
--DROP TABLE Medicacao;
--DROP TABLE Alimentacao;
--DROP TABLE Consulta;
--DROP TABLE Veterinario;
--DROP TABLE Vacina;
--DROP TABLE Medicamento;
--DROP TABLE Alimento;
--DROP TABLE Exame;
--DROP TABLE CarteiraVacinacao;
--DROP TABLE CarteiraMedicacao;
--DROP TABLE CarteiraAlimentacao;
--DROP TABLE CarteiraExame;
--DROP TABLE Venda;
--DROP TABLE Cachorro;
--DROP TABLE Comprador;
--DROP TABLE Criador;

CREATE TABLE Cachorro (
    IdCachorro INTEGER IDENTITY(0,1) PRIMARY KEY,
    Nome NVARCHAR(50),
    Porte NVARCHAR(50),
    DataNascimento DATE,
    Raca NVARCHAR(50),
    Sexo NVARCHAR(50),
    Pedigree INTEGER,
    IdMatriz INTEGER,
    IdPadreador INTEGER,
	Reservado BIT,
    IdCriador INTEGER,
    IdComprador INTEGER
);

CREATE TABLE Vacina (
    IdVacina INTEGER IDENTITY(1,1) PRIMARY KEY,
    Tipo NVARCHAR(50),
    Nome NVARCHAR(50),
    Fabricante NVARCHAR(50)
);

CREATE TABLE CarteiraVacinacao (
    IdCarteiraVacinacao INTEGER IDENTITY(1,1) PRIMARY KEY,
    IdCachorro INTEGER,
    DataEmissao DATE
);

CREATE TABLE Vacinacao (
	IdVacinacao INTEGER IDENTITY(1,1) PRIMARY KEY,
    IdCarteiraVacinacao INTEGER,
    IdVacina INTEGER,
    DataAplicacao DATE,
    IdVeterinario INTEGER,
    Dose DECIMAL(10,4),
    Observacao NVARCHAR(50)
);

CREATE TABLE CarteiraMedicacao (
    IdCarteiraMedicacao INTEGER IDENTITY(1,1) PRIMARY KEY,
    IdCachorro INTEGER,
    DataEmissao DATE
);

CREATE TABLE Medicamento (
    IdMedicamento INTEGER IDENTITY(1,1) PRIMARY KEY,
    Tipo NVARCHAR(50),
    Nome NVARCHAR(50),
    Fabricante NVARCHAR(50),
    Composicao NVARCHAR(50)
);

CREATE TABLE Veterinario (
    IdVeterinario INTEGER IDENTITY(0,1) PRIMARY KEY,
    CRMV NVARCHAR(50) UNIQUE,
    Nome NVARCHAR(50),
    Especialidade NVARCHAR(50)
);

CREATE TABLE Medicacao (
	IdMedicacao INTEGER IDENTITY(1,1) PRIMARY KEY,
    IdCarteiraMedicacao INTEGER,
    IdMedicamento INTEGER,
    DataInicio DATE,
    DataTermino DATE,
    IdVeterinario INTEGER,
    Posologia DECIMAL(10,4),
    Justificativa NVARCHAR(50)
);

CREATE TABLE CarteiraAlimentacao (
    IdCarteiraAlimentacao INTEGER IDENTITY(1,1) PRIMARY KEY,
    IdCachorro INTEGER,
    DataEmissao DATE
);

CREATE TABLE Alimentacao (
	IdAlimentacao INTEGER IDENTITY(1,1) PRIMARY KEY,
    IdCarteiraAlimentacao INTEGER,
    IdAlimento INTEGER,
    DataInicio DATE,
    DataTermino DATE,
    IdVeterinario INTEGER,
    Frequencia INTEGER,
    Quantidade DECIMAL(10,4)
);

CREATE TABLE Alimento (
    IdAlimento INTEGER IDENTITY(1,1) PRIMARY KEY,
    Tipo NVARCHAR(50),
    Nome NVARCHAR(50),
    Fabricante NVARCHAR(50),
    Composicao NVARCHAR(50)
);

CREATE TABLE Exame (
    IdExame INTEGER IDENTITY(1,1) PRIMARY KEY,
    Tipo NVARCHAR(50),
    Nome NVARCHAR(50)
);

CREATE TABLE Consulta (
	IdConsulta INTEGER IDENTITY(1,1) PRIMARY KEY,
    IdCarteiraExame INTEGER,
    IdExame INTEGER,
    DataExame DATE,
    IdVeterinario INTEGER,
    Resultado NVARCHAR(50),
    Observacao NVARCHAR(50)
);

CREATE TABLE CarteiraExame (
    IdCarteiraExame INTEGER IDENTITY(1,1) PRIMARY KEY,
    IdCachorro INTEGER,
    DataEmissao DATE
);

CREATE TABLE Criador (
    IdCriador INTEGER IDENTITY(0,1) PRIMARY KEY,
    Nome NVARCHAR(50),
    Documento NVARCHAR(50),
    Telefone NVARCHAR(50),
    DataNascimento DATE,
    Endereco NVARCHAR(50)
);

CREATE TABLE Comprador (
    IdComprador INTEGER IDENTITY(0,1) PRIMARY KEY,
    Nome NVARCHAR(50),
    Documento NVARCHAR(50),
    Telefone NVARCHAR(50),
    DataNascimento DATE,
    Endereco NVARCHAR(50)
);

CREATE TABLE Venda (
    IdVenda INTEGER IDENTITY(1,1) PRIMARY KEY,
    IdCachorro INTEGER,
    IdComprador INTEGER,
    DataCompra DATE,
    DataReserva DATE,
    Status NVARCHAR(50),
    Valor DECIMAL(10,4),
    NotaFiscal NVARCHAR(50)
);

ALTER TABLE Cachorro ADD CONSTRAINT FK_cachorro_criador
    FOREIGN KEY (IdCriador)
    REFERENCES Criador (IdCriador);
 
ALTER TABLE Cachorro ADD CONSTRAINT FK_cachorro_comprador
    FOREIGN KEY (IdComprador)
    REFERENCES Comprador (IdComprador);
 
ALTER TABLE CarteiraVacinacao ADD CONSTRAINT FK_carteiravacinacao_cachorro
    FOREIGN KEY (IdCachorro)
    REFERENCES Cachorro (IdCachorro);
 
ALTER TABLE Vacinacao ADD CONSTRAINT FK_vacinacao_carteira
    FOREIGN KEY (IdCarteiraVacinacao)
    REFERENCES CarteiraVacinacao (IdCarteiraVacinacao);
 
ALTER TABLE Vacinacao ADD CONSTRAINT FK_vacinacao_vacina
    FOREIGN KEY (IdVacina)
    REFERENCES Vacina (IdVacina);
 
ALTER TABLE Vacinacao ADD CONSTRAINT FK_vacinacao_veterinario
    FOREIGN KEY (IdVeterinario)
    REFERENCES Veterinario (IdVeterinario);
 
ALTER TABLE CarteiraMedicacao ADD CONSTRAINT FK_carteiramedicacao_cachorro
    FOREIGN KEY (IdCachorro)
    REFERENCES Cachorro (IdCachorro);
 
ALTER TABLE Medicacao ADD CONSTRAINT FK_medicacao_carteira
    FOREIGN KEY (IdCarteiraMedicacao)
    REFERENCES CarteiraMedicacao (IdCarteiraMedicacao);
 
ALTER TABLE Medicacao ADD CONSTRAINT FK_medicacao_medicamento
    FOREIGN KEY (IdMedicamento)
    REFERENCES Medicamento (IdMedicamento);
 
ALTER TABLE Medicacao ADD CONSTRAINT FK_medicacao_veterinario
    FOREIGN KEY (IdVeterinario)
    REFERENCES Veterinario (IdVeterinario);
 
ALTER TABLE CarteiraAlimentacao ADD CONSTRAINT FK_carteiraalimentacao_cachorro
    FOREIGN KEY (IdCachorro)
    REFERENCES Cachorro (IdCachorro);
 
ALTER TABLE Alimentacao ADD CONSTRAINT FK_alimentacao_carteira
    FOREIGN KEY (IdCarteiraAlimentacao)
    REFERENCES CarteiraAlimentacao (IdCarteiraAlimentacao);
 
ALTER TABLE Alimentacao ADD CONSTRAINT FK_alimentacao_alimento
    FOREIGN KEY (IdAlimento)
    REFERENCES Alimento (IdAlimento);
 
ALTER TABLE Alimentacao ADD CONSTRAINT FK_alimentacao_veterinario
    FOREIGN KEY (IdVeterinario)
    REFERENCES Veterinario (IdVeterinario);
 
ALTER TABLE Consulta ADD CONSTRAINT FK_consulta_carteira
    FOREIGN KEY (IdCarteiraExame)
    REFERENCES CarteiraExame (IdCarteiraExame);
 
ALTER TABLE Consulta ADD CONSTRAINT FK_consulta_exame
    FOREIGN KEY (IdExame)
    REFERENCES Exame (IdExame);
 
ALTER TABLE Consulta ADD CONSTRAINT FK_consulta_veterinario
    FOREIGN KEY (IdVeterinario)
    REFERENCES Veterinario (IdVeterinario);
 
ALTER TABLE CarteiraExame ADD CONSTRAINT Fk_carteiraexame_cachorro
    FOREIGN KEY (IdCachorro)
    REFERENCES Cachorro (IdCachorro);
 
ALTER TABLE Venda ADD CONSTRAINT FK_venda_cachorro
    FOREIGN KEY (IdCachorro)
    REFERENCES Cachorro (IdCachorro);
 
ALTER TABLE Venda ADD CONSTRAINT FK_venda_comprador
    FOREIGN KEY (IdComprador)
    REFERENCES Comprador (IdComprador);
	
INSERT INTO Criador 
VALUES
	('Sem Criador', '', '', NULL, ''),
	('Winonah Vase', '0000000000001', '8308431014', '1981-06-13', '20337 Cottonwood Place'),
    ('Miranda Tooher', '0000000000002', '5936814581', '1968-05-24', '02917 Golf Terrace'),
    ('Ruperta Niaves', '0000000000003', '4547158381', '1961-09-11', '20810 Bultman Hill'),
    ('Rosalyn Scotfurth', '0000000000004', '9342836182', '1995-09-22', '176 Cardinal Way'),
    ('Buddy Wibrow', '0000000000005', '9986530277', '1973-05-04', '81 Superior Park'),
    ('Wadsworth Pash', '0000000000006', '9728879076', '2003-06-17', '834 Upham Drive'),
    ('Agnella Spavins', '0000000000007', '3597217887', '1981-06-03', '42 Bultman Parkway'),
    ('Miguela Bool', '0000000000008', '9653687463', '1976-05-12', '096 Kropf Circle'),
    ('Jocelyne Sacchetti', '0000000000009', '2543694451', '1969-04-10', '156 Armistice Street'),
    ('Denys Dawe', '0000000000010', '9768474425', '1998-07-24', '6 Russell Road');
	
INSERT INTO Comprador
VALUES
	('Sem Comprador', '', '', NULL, ''),
	('Alena McRae', '0000000000011','7729302700', '1971-01-29', '559 Paget Terrace'),
    ('Dermot Sawfoot', '0000000000012', '6934981149', '1973-03-26', '9 Northwestern Park'),
    ('Arielle Orrom', '0000000000013', '3684155838', '1974-03-31', '1 Barnett Center'),
    ('Jamison Lindermann', '0000000000014', '3317627656', '1986-05-22', '689 Pond Junction'),
    ('Deborah Dufton', '0000000000015', '9351327738', '1960-07-25', '7718 Wayridge Drive'),
    ('Kitti Caccavella', '0000000000016', '4247496855', '1975-05-14', '92 Petterle Alley'),
    ('Lenore Leadston', '0000000000017', '2693528182', '1980-07-04', '31 Clarendon Road'),
    ('Lincoln Wheatley', '0000000000018', '9731535942', '1966-10-11', '07408 Troy Lane'),
    ('Nicolina Matasov', '0000000000019', '2092915850', '1991-06-30', '53 Vermont Court'),
    ('Vitia Steely', '0000000000020', '3593644895', '1980-08-29', '76 Aberg Street');
	
INSERT INTO Veterinario
VALUES
	('0', 'Sem Veterinario', ''),
	('916442845-1', 'Robinson Wragge', 'Geral'),
	('882047628-2', 'Lib Waldron', 'Nutrologia'),
	('283384632-0', 'Shanie Yo', 'Pediatria');
	
INSERT INTO Cachorro
VALUES
	('Externo', '', null, '', '', 0, 0, 0, 0, 0, 0),
    ('Grissel', 'Médio', '2009-03-10', 'Golden Retriever', 'Macho', 61, 0, 0, 1, 1, 1),
    ('Michelina', 'Grande', '2010-06-05', 'Golden Retriever', 'Fêmea', 21, 0, 0, 1, 0, 2),
    ('Mayor', 'Grande', '2011-01-20', 'Golden Retriever', 'Macho', 2, 2, 1, 1, 4, 4),
    ('Veronica', 'Grande', '2012-05-21', 'Golden Retriever', 'Fêmea', 27, 2, 1, 1, 6, 6),
	('Olga', 'Médio', '2014-01-28', 'Golden Retriever', 'Fêmea', 63, 4, 3, 0, 8, 0),
	('Arny', 'Grande', '2015-06-03', 'Golden Retriever', 'Macho', 7, 4, 1, 1, 9, 9),
	('Bird', 'Médio', '2016-02-16', 'Golden Retriever', 'Macho', 51, 4, 6, 0, 4, 0),
	('Aurelie', 'Médio', '2016-09-30', 'Golden Retriever', 'Fêmea', 30, 4, 6, 0, 5, 0),
	('Avrit', 'Médio', '2019-12-04', 'Golden Retriever', 'Macho', 51, 8, 7, 1, 0, 3),
	('Noreen', 'Pequeno', '2020-01-17', 'Golden Retriever', 'Fêmea', 89, 8, 7, 0, 0, 0);

INSERT INTO Venda
VALUES
	(1, 1, '2010-09-10', '2010-07-10', 'Finalizado', 865.36, '1'),
	(2, 2, '2011-03-05', '2011-01-10', 'Finalizado', 842.36, '2'),
	(3, 4, '2012-11-20', '2012-09-20', 'Finalizado', 812.45, '3'),
	(4, 6, '2013-04-21', '2013-02-21', 'Finalizado', 940.38, '4'),
	(6, 9, '2016-08-03', '2016-06-03', 'Finalizado', 972.20, '5'),
	(9, 3, null, '2021-08-04', 'Reservado', 300.00, '');
	
INSERT INTO CarteiraVacinacao
VALUES
	(1, '2009-03-10'),
    (2, '2010-06-05'),
    (3, '2011-01-20'),
    (4, '2012-05-21'),
    (5, '2014-01-28'),
    (6, '2015-06-03'),
    (7, '2016-02-16'),
    (8, '2016-09-30'),
    (9, '2019-12-04'),
    (10, '2020-01-17');
	
INSERT INTO CarteiraMedicacao
VALUES
	(1, '2009-03-10'),
    (2, '2010-06-05'),
    (3, '2011-01-20'),
    (4, '2012-05-21'),
    (5, '2014-01-28'),
    (6, '2015-06-03'),
    (7, '2016-02-16'),
    (8, '2016-09-30'),
    (9, '2019-12-04'),
    (10, '2020-01-17');
	
INSERT INTO CarteiraAlimentacao
VALUES
	(1, '2009-03-10'),
    (2, '2010-06-05'),
    (3, '2011-01-20'),
    (4, '2012-05-21'),
    (5, '2014-01-28'),
    (6, '2015-06-03'),
    (7, '2016-02-16'),
    (8, '2016-09-30'),
    (9, '2019-12-04'),
    (10, '2020-01-17');
	
INSERT INTO CarteiraExame
VALUES
	(1, '2009-03-10'),
    (2, '2010-06-05'),
    (3, '2011-01-20'),
    (4, '2012-05-21'),
    (5, '2014-01-28'),
    (6, '2015-06-03'),
    (7, '2016-02-16'),
    (8, '2016-09-30'),
    (9, '2019-12-04'),
    (10, '2020-01-17');
	
INSERT INTO Vacina
VALUES
	('Anual', 'Antirrábica', 'PDoggizer'),
	('Anual', 'Polivalente', 'DogVac');
	
INSERT INTO Medicamento
VALUES
	('Comprimido', 'Vermífugo', 'BioVet', 'Pamoato de Pirante, Praziquantel, Excipiente'),
	('Cápsula', 'Antipulgas', 'Bravecto', 'Fluralaner');

INSERT INTO Alimento
VALUES
	('Filhote', 'Ração Special Dog Prime Júnior para Cães Filhotes', 'Special Dog', 'Farinha de vísceras de frango, ovo em pó, arroz'),
	('Adulto', 'Ração Royal Canin Maxi Adult para Cães Adultos', 'Royal Canin', 'Farinha de vísceras de aves e arroz, milho moído'),
	('Idoso', 'Ração Pedigree Sachê Carne Molho para Cães Sênior', 'Pedigree', 'Miúdo de bovinos e de suínos , carcaça de frango');
	
INSERT INTO Exame
VALUES
	('Anual', 'Sangue'),
	('Periódico', 'Urina e Fezes'),
	('Especial', 'Radiografia (Displasia)');
	
INSERT INTO Vacinacao
VALUES
	(1, 2, '2009-04-05', 3, 20, '25 dias após o nascimento'),
	(1, 1, '2009-04-15', 3, 20, '45 dias após o nascimento'),
	(2, 2, '2010-06-30', 3, 20, '25 dias após o nascimento'),
	(2, 1, '2010-07-20', 3, 20, '45 dias após o nascimento'),
	(3, 2, '2011-02-15', 3, 20, '25 dias após o nascimento'),
	(3, 1, '2011-03-05', 3, 20, '45 dias após o nascimento'),
	(4, 2, '2012-06-16', 3, 20, '25 dias após o nascimento'),
	(4, 1, '2012-07-06', 3, 20, '45 dias após o nascimento'),
	(5, 2, '2014-02-23', 3, 20, '25 dias após o nascimento'),
	(5, 1, '2014-03-13', 3, 20, '45 dias após o nascimento'),
	(6, 2, '2015-06-28', 3, 20, '25 dias após o nascimento'),
	(6, 1, '2015-07-18', 3, 20, '45 dias após o nascimento'),
	(7, 2, '2016-03-11', 3, 20, '25 dias após o nascimento'),
	(7, 1, '2016-04-01', 3, 20, '45 dias após o nascimento'),
	(8, 2, '2016-10-25', 3, 20, '25 dias após o nascimento'),
	(8, 1, '2016-11-15', 3, 20, '45 dias após o nascimento'),
	(9, 2, '2019-12-29', 3, 20, '25 dias após o nascimento'),
	(9, 1, '2020-01-19', 3, 20, '45 dias após o nascimento'),
	(10, 2, '2020-02-07', 3, 20, '25 dias após o nascimento'),
	(10, 1, '2020-03-08', 3, 20, '45 dias após o nascimento');

INSERT INTO Medicacao
VALUES
	(1, 1, '2009-04-10', '2009-04-17', 0, 1, '30 dias após o nascimento'),
	(2, 1, '2010-07-05', '2010-07-12', 0, 1, '30 dias após o nascimento'),
	(3, 1, '2011-02-20', '2011-02-27', 0, 1, '30 dias após o nascimento'),
	(4, 1, '2012-06-21', '2012-06-28', 0, 1, '30 dias após o nascimento'),
	(5, 1, '2014-02-28', '2014-03-05', 0, 1, '30 dias após o nascimento'),
	(6, 1, '2015-06-08', '2015-06-13', 0, 1, '30 dias após o nascimento'),
	(7, 1, '2016-03-16', '2016-03-23', 0, 1, '30 dias após o nascimento'),
	(8, 1, '2016-10-30', '2016-11-07', 0, 1, '30 dias após o nascimento'),
	(9, 1, '2020-01-03', '2020-01-10', 0, 1, '30 dias após o nascimento'),
	(10, 1, '2020-03-13', '2020-03-20', 0, 1, '30 dias após o nascimento');

INSERT INTO Alimentacao
VALUES
	(1, 1, '2009-04-10', '2010-08-17', 2, 3, 60),
	(2, 1, '2010-07-05', '2011-09-12', 2, 3, 60),
	(3, 1, '2011-02-20', '2012-06-27', 2, 3, 60),
	(4, 1, '2012-06-21', '2013-10-28', 2, 3, 60),
	(5, 1, '2014-02-28', '2015-07-05', 2, 3, 60),
	(6, 1, '2015-06-08', '2016-10-13', 2, 3, 60),
	(7, 1, '2016-03-16', '2017-07-23', 2, 3, 60),
	(8, 1, '2016-10-30', '2018-03-07', 2, 3, 60),
	(9, 1, '2020-01-03', '2021-05-10', 2, 3, 60),
	(10, 1, '2020-02-12', '2021-06-19', 2, 3, 60),
	(1, 2, '2010-08-17', '2017-08-17', 2, 1, 250),
	(2, 2, '2011-09-12', '2018-09-12', 2, 1, 250),
	(3, 2, '2012-06-27', '2019-06-27', 2, 1, 250),
	(4, 2, '2013-10-28', '2020-10-28', 2, 1, 250),
	(5, 2, '2015-07-05', '2022-07-05', 2, 1, 250),
	(6, 2, '2016-10-13', '2023-10-13', 2, 1, 250),
	(7, 2, '2017-07-23', '2024-07-23', 2, 1, 250),
	(8, 2, '2018-03-07', '2025-03-07', 2, 1, 250),
	(9, 2, '2021-05-10', '2028-05-10', 2, 1, 250),
	(10, 2, '2021-06-19', '2028-06-19', 2, 1, 250),
	(1, 3, '2017-08-17', '2024-08-17', 2, 2, 80),
	(2, 3, '2018-09-12', '2025-09-12', 2, 2, 80),
	(3, 3, '2019-06-27', '2026-06-27', 2, 2, 80),
	(4, 3, '2020-10-28', '2027-10-28', 2, 2, 80);

INSERT INTO Consulta
VALUES
	(1, 1, '2009-04-05', 1, 'Normal', ''),
	(1, 2, '2009-04-15', 1, 'Normal', ''),
	(1, 3, '2009-04-15', 1, 'Normal', ''),
	(2, 1, '2010-06-30', 1, 'Normal', ''),
	(2, 2, '2010-07-20', 1, 'Normal', ''),
	(2, 3, '2010-07-20', 1, 'Normal', ''),
	(3, 1, '2011-02-15', 1, 'Normal', ''),
	(3, 2, '2011-03-05', 1, 'Normal', ''),
	(3, 3, '2011-02-15', 1, 'Normal', ''),
	(4, 1, '2012-06-16', 1, 'Normal', ''),
	(4, 2, '2012-07-06', 1, 'Normal', ''),
	(4, 3, '2012-07-06', 1, 'Normal', ''),
	(5, 1, '2014-02-23', 1, 'Normal', ''),
	(5, 2, '2014-03-13', 1, 'Normal', ''),
	(6, 1, '2015-06-28', 1, 'Normal', ''),
	(6, 2, '2015-07-18', 1, 'Normal', ''),
	(7, 1, '2016-03-11', 1, 'Normal', ''),
	(7, 2, '2016-04-01', 1, 'Normal', ''),
	(8, 1, '2016-10-25', 1, 'Normal', ''),
	(8, 2, '2016-11-15', 1, 'Normal', ''),
	(9, 1, '2019-12-29', 1, 'Normal', ''),
	(9, 2, '2020-01-19', 1, 'Normal', ''),
	(10, 1, '2020-02-07', 1, 'Normal', ''),
	(10, 2, '2020-03-08', 1, 'Normal', '');