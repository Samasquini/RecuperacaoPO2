drop database RecuperacaoPO2;
create database RecuperacaoPO2;
use RecuperacaoPO2;

create table Carros(
id_car int primary key auto_increment,
marca_car varchar(100),
modelo_car varchar(100),
ano_fabricacao_car year,
ano_modelo_car year,
cor_car varchar(100),
num_portas_car int,
tipo_carroceria_car varchar(100)
);

create table Informacoes(
id_inf int primary key auto_increment,
num_chassi_inf varchar(20),
num_motor_inf varchar(11),
tipo_combustivel_inf varchar(100),
capacidade_motor_inf int,
potencia_motor_inf varchar(4),
transmissao_inf varchar(20),
tipo_tracao_inf varchar(20)
);

create table Documentacoes(
id_doc int primary key auto_increment,
renavam_doc varchar(12),
num_placa_doc varchar(20),
data_licenciamento_doc date,
data_inspecao_doc date
);

INSERT INTO Carros VALUES (null, 'Dodge', 'Charger R/T', 1970, 1970, 'Preto', 2, 'Cupê');
INSERT INTO Informacoes VALUES (null, 'JKL34M87H654321098', 'H65432109', 'Gasolina', 15,'3.2', 'Manual', 'Traseira');
INSERT INTO Documentacoes VALUES (null, 'ABC123456789', 'XYZ987', '1970-01-01', '2023-10-26');

INSERT INTO Carros VALUES (null, 'Dodge', 'Charger R/T', 1970, 1970, 'Preto', 2, 'Cupê');
INSERT INTO Informacoes VALUES (null, 'JKL34M87H654321098', 'H65432109', 'Gasolina', 15,'3.2', 'Manual', 'Traseira');
INSERT INTO Documentacoes VALUES (null, 'ABC123456789', 'XYZ987', '1970-01-01', '2023-10-26');

INSERT INTO Carros VALUES (null, 'Chevrolet', 'Camaro', 2016, 2017, 'Preto', 2, 'Cupê');
INSERT INTO Informacoes VALUES (null, '1G1FA1RS2G0123456', 'V8LS376025', 'Gasolina', 20, '2.0', 'Manual', 'Traseira');
INSERT INTO Documentacoes VALUES (null, '12345678901', 'ABC1234', '2016-12-15', '2022-12-25');

INSERT INTO Carros VALUES (null, 'Ford', 'GT', 2004, 2005, 'Vermelho', 2, 'Cupê');
INSERT INTO Informacoes VALUES (null, '12345678901234567', 'ABC123456', 'Gasolina', 10,'1.0', 'Manual', 'Traseira');
INSERT INTO Documentacoes VALUES (null, '12345678901', 'ABC1234', '2023-01-01', '2023-02-01');

select * from Carros;
select * from Informacoes;
select * from Documentacoes;

SET @id_car_to_select = 3;
SELECT * FROM Carros WHERE id_car = 3;
SELECT * FROM Informacoes WHERE id_inf = 3;
SELECT * FROM Documentacoes WHERE id_doc = 3;