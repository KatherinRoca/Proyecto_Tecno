CREATE DATABASE GA1;
GO
USE GA1;
GO 

CREATE TABLE Ingresar(
Nombre Varchar(50) Primary key,
Contraseña Varchar(50),
Rol Varchar(50),
);

Insert Into Ingresar Values('Katherin','123','Administrador');
Insert Into Ingresar Values('Dereck','1234','Cliente');
Insert Into Ingresar Values('Josue','12345','Secretario');
Insert Into Ingresar Values('Critopher','1020','Usuario');

CREATE TABLE Datos(
Id int Primary key,
Nombre Varchar(50),
Correo Varchar(50),
Pais varchar(50), 
);
select * from Datos
select * from Ingresar
Insert Into Datos Values(1,'Angel','Angel@gmail.com','Guatemala');