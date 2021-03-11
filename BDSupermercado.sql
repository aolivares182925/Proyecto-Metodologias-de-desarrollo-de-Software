--------------------------------------------------------------------------
---- CREACION DE LA BASE DE DATOS
--------------------------------------------------------------------------
use master
go
if exists (select * from sysdatabases where name = 'DBSupermercado')
drop database DBSupermercado
go
create database DBSupermercado
go

/* ********************************************************************
      CREACION DE TIPOS
 ******************************************************************** */
USE DBSupermercado 
--EXEC sp_addtype TCod_Usuario,   'varchar(8)', 'not null'
EXEC sp_addtype TCod_Producto,  'varchar(8)', 'not null'
EXEC sp_addtype TCod_Proveedor, 'varchar(8)', 'not null'
EXEC sp_addtype TCod_Venta, 'varchar(8)', 'not null'
GO
-- ====================================================
/* Activar Base de datos: DBSupermercado */
use DBSupermercado
go
/* Crear los tipos */

/* Crear las tablas*/
------------------------
----------------------------------------------------------------------
create table Usuarios
( --lista de atributos  
  NroUsuarios int identity(12000,1)  primary key NOT NULL,
  IdUsuarios as ('US' + RIGHT('23000' + CONVERT(VARCHAR,NroUsuarios),(5))),
  loginName		nvarchar(100) unique NOT NULL,
  Password		nvarchar(100) not null,
  APaterno		varchar(50) not null,
  AMaterno		varchar(50) not null,
  Nombres		varchar(50) not null,
  TipoUsuario	varchar(50) not null
)
go
----------------------------------------------------------------------------------------------------------------------------------------------
create table Venta
(	-- lista de atributos
	Nro_Venta			int identity(10000,1)  primary key NOT NULL,
	IdVenta			as ('VE' + RIGHT('23000' + CONVERT(VARCHAR,Nro_Venta),(5))),
	Fecha				varchar(10) not null,
	DNI_Cliente			varchar(8)  null,
	Nombre_Cliente      varchar(40)  null,
	NroUsuarios			int,
	-- definición de claves
	foreign key (NroUsuarios) references Usuarios(NroUsuarios)
)
go
create table Proveedor
(	-- lista de atributos
	Cod_Proveedor		TCod_Proveedor,
	RUC					varchar(11) not null,
	Razon_Social		varchar(40)  not null,
	-- definición de claves
	primary key (Cod_Proveedor)
)
go

create table Producto
(	-- lista de atributos
    NroProducto int identity(13000,1) PRIMARY KEY NOT NULL,
    Cod_Producto as ('PRO' + RIGHT('13000' + CONVERT(VARCHAR,NroProducto),(5))),
	--Cod_Producto		TCod_Producto,
	Nombre_Producto		varchar(40) not null,
	Precio				float default 1.0 check (Precio > 0),
	Cod_Proveedor		TCod_Proveedor not null,
	Clasificacion		varchar(40)  not null,
			
	-- definición de claves
	--primary key (Cod_Producto),
	foreign key (Cod_Proveedor) references Proveedor(Cod_Proveedor)
)
go


create table DetalleVenta
(	-- lista de atributos
	Nro_Venta		int,

	NroProducto		int,
	Cantidad			integer  default 1 check (Cantidad > 0),
	-- definición de claves
	primary key (Nro_Venta,NroProducto),
	foreign key (Nro_Venta) references Venta(Nro_Venta),
	foreign key (NroProducto) references Producto(NroProducto)
)
go

/* ******************************************************************** */
/*        INSERTAR DATOS       */
/* ******************************************************************** */
USE DBSupermercado 
go

-- inserción de datos en la tabla Usuarios --
-------------------------------------------------------------------
insert into Usuarios values('tron2049','506899','QUISPE','GUERRA','LUIS JOYANES','Cajero')
insert into Usuarios values('ben123','123456','HUAMAN','GAMARRA','SILVERSCHATZ','Cajero')
insert into Usuarios values('ro321','5068pere','CONDORI','LOPEZ','ROGER PRESSMAN','Cajero')
insert into Usuarios values('juger123','teletubie5','PEREZ','OVIEDO','LUIS JOYANES','Cajero')
insert into Usuarios values('legal24','5068','HUAMAN','RUPA','SILVERSCHATZ','Cajero')
insert into Usuarios values('cap123','5068','MAMANI','NOA','ROGER PRESSMAN','Cajero')
insert into Usuarios values('loc123','2049loc','ALBELARDO','OVIEDO','LUIS','Cajero')
insert into Usuarios values('lac987','goInca','GONZALES','PACHA','JHONI','Cajero')
insert into Usuarios values('JE051','wal123','QUISPE','GUERRA','LUIS JOYANES','Admin')
insert into Usuarios values('User0003','Dramelomas69','Mendoza','Álvarez','Iván','Cajero')
insert into Usuarios values('User0004','Estrations48','Lomas','Fuentes','Kiara','Cajero')
insert into Usuarios values('User0014','Prestupran12','Fuentes','Gálvez','Juan','Almacenero')
insert into Usuarios values('User0018','C2017JHRU18','Huamán','Rivero','José','Cajero')
insert into Usuarios values('User0019','C2016MGLU19','Mario','García','Lopez','Cajero')
insert into Usuarios values('User0012','A2015ASDU12','Puma','Fuentes','Carlos','Almacenero')

SELECT * FROM Usuarios
go
--declare @user nvarchar(100)='tron2049'
--declare @pass nvarchar(100)='506899'

--SELECT IdUsuarios, APaterno, AMaterno, Nombres, TipoUsuario FROM Usuarios
--go

SELECT NroUsuarios, IdUsuarios, APaterno, AMaterno, Nombres, TipoUsuario FROM Usuarios
go
/****************************************************************/
/*----------------Proveedor-------------------------------*/
insert into Proveedor values('PR01','10256489651','P&G')
insert into Proveedor values('PR02','10632598482','ALICORP')
insert into Proveedor values('PR03','10329856183','BACKUS')
insert into Proveedor values('PR04','10758496854','CAMPOSOL')
insert into Proveedor values('PR05','10256389565','GLORIA')

set dateformat dmy
go
--agregando productos
insert into Producto values('Detergente Ariel 1kg',15,'PR01','Limpieza')
insert into Producto values('Pasta dental Oral B 200g',7,'PR01','Cuidado personal')	
insert into Producto values('Pañales Pampers 20 uni',25,'PR01','Producto bebe')
insert into Producto values('Gillette Mach 3 ',10,'PR01','Cuidado personal')
insert into Producto values('Pilas Duracel AA 10 uni',11,'PR01','Accesorios')
insert into Producto values('Vick Vaporub 50g',5,'PR01','Cuidado personal') 
insert into Producto values('Tallarines Vitornno 50g',10,'PR02','Comida')
insert into Producto values('Mayonesa Alacena 1kg',20,'PR02','Comida')
insert into Producto values('Harina Blanca Flor 1kg',7,'PR02','Comida')
insert into Producto values('Galleta Tentacion Vainilla',4,'PR02','Comida')
insert into Producto values('Ageite primor 500g',12,'PR02','Comida')
insert into Producto values('Salsa de tomate Pomarola 500g',15,'PR02','Comida')
insert into Producto values('Cerveza Pilsen 12Pack',41.90,'PR03','Bebidas')
insert into Producto values('Cerveza Cusqueña 6Pack Botella',19.90,'PR03','Bebidas')
insert into Producto values('Cerveza Cristal 6Pack Botella',16.50,'PR03','Bebidas')
insert into Producto values('Gaseosa Guaraná Botella 3L',5.20,'PR03','Bebidas')
insert into Producto values('Agua San Mateo Bidón 7L',7.90,'PR03','Bebidas')
insert into Producto values('Cerveza Budweiser 6Pack Botella',21.90,'PR03','Bebidas')
insert into Producto values('Aguacate - Paltas',1.80,'PR04','Comestibles Naturales')
insert into Producto values('Ají Jalapeño COnservas',1.30,'PR04','Comestibles Naturales')
insert into Producto values('Alcachofas Frescas',2.46,'PR04','Comestibles Naturales')
insert into Producto values('Fresas',1.20,'PR04','Comestibles Naturales')
insert into Producto values('Quinua',4.40,'PR04','Comestibles Naturales')
insert into Producto values('Mango Pulpa',1.56,'PR04','Comestibles Naturales')
insert into Producto values('Mermelada de Fresa GLORIA frasco 1kg',11.90,'PR05','comestible')
insert into Producto values('Six pack Leche evaporada GLORA en Lata',18.90,'PR05','lacteo')
insert into Producto values('Yogurt GLORIA sabor a manzana 1Lt',5.50,'PR05','lacteo')
insert into Producto values('Filete de atun GLORIA x 170 gr',5.00,'PR05','conserva')
insert into Producto values('Mantequilla GLORIA con sal Pote 400g',14.90,'PR05','desayuno')
insert into Producto values('Queso Fresco GLORIA',5.80,'PR05','lacteo')

SELECT Cod_Producto, Nombre_Producto, Precio, Cod_Proveedor, Clasificacion FROM Producto
go
--SELECT * FROM Producto
insert into Venta values('01-06-2020',null,null,12000)
insert into Venta values('15-07-2020','73010670','Aler Olivares',12001)
insert into Venta values('04-06-2019','58574123','Erika Merino',12002)
insert into Venta values('05-08-2020','73010670','Aler Olivares',12003)
insert into Venta values('15-09-2020',null,null,12006)
insert into Venta values('21-02-2020','23884409','Betty Aguilar',12004)
insert into Venta values('30-09-2020','98585731','Rick Sanches',12005)
insert into Venta values('25-11-2020','87576633','Ricardo Minos',12007)
insert into Venta values('15-12-2020',null,null,12009)
insert into Venta values('01-01-2021','23568954','Esteban Canales Casas',12010)
insert into Venta values('01-01-2021','14253659','Karen Calderón Pacheco',12012)
insert into Venta values('05-01-2021','12326598','Rosa Mejía Pilares',12013)
insert into Venta values('02-02-2021','15489523','Brany Machaca de la Vega',12000)
insert into Venta values('23-01-2021','72859645','Shana Falcón COrpuna',12001)
insert into Venta values('15-01-2021','95986532','Habigail Delgado Ticona',12002)
insert into Venta values('14-05-2020','24567534','María Vargas Quispe',12003)
insert into Venta values('09-05-2020','45689731','Franklin Zuloaga Meza',12004)
insert into Venta values('21-02-2020','46532178','Roger Silva Choque',12005)
insert into Venta values('10-02-2020','26675643','Sara Cárdenas Tuero',12006)
insert into Venta values('03-08-2020',null,null,12007)
insert into Venta values('30-08-2020',null,null,12009)

select IdVenta, fecha, DNI_Cliente, Nombre_Cliente, NroUsuarios from Venta
GO
-------------detalle de venta-------------
insert into DetalleVenta values(10001,13000,5)
insert into DetalleVenta values(10001,13001,2)
insert into DetalleVenta values(10002,13002,3)
insert into DetalleVenta values(10002,13003,2)
insert into DetalleVenta values(10003,13004,4)
insert into DetalleVenta values(10003,13005,2)
insert into DetalleVenta values(10004,13006,2)
insert into DetalleVenta values (10004,13007,3)
insert into DetalleVenta values (10005,13009,2)
insert into DetalleVenta values (10005,13002,4)
insert into DetalleVenta values (10006,13004,2)
insert into DetalleVenta values (10006,13007,3)
insert into DetalleVenta values (10007,13008,2)
insert into DetalleVenta values (10007,13009,1)
insert into DetalleVenta values(10014,13026,3)
insert into DetalleVenta values(10014,13024,6)
insert into DetalleVenta values(10015,13002,3)
insert into DetalleVenta values(10015,13006,2)
insert into DetalleVenta values(10015,13008,5)
insert into DetalleVenta values(10016,13001,7)
insert into DetalleVenta values(10016,13002,8)
insert into DetalleVenta values(10017,13023,1)
insert into DetalleVenta values(10017,13014,4)
insert into DetalleVenta values(10017,13011,3)
insert into DetalleVenta values(10018,13017,5)
insert into DetalleVenta values(10019,13018,6)
insert into DetalleVenta values(10019,13009,7)
insert into DetalleVenta values(10020,13023,9)
insert into DetalleVenta values(10020,13029,3)
insert into DetalleVenta values(10020,13015,7)
insert into DetalleVenta values(10020,13016,4)
insert into DetalleVenta values(10020,13006,3)
insert into DetalleVenta values(10007,13000,2)
insert into DetalleVenta values(10007,13001,3)
insert into DetalleVenta values(10008,13015,1)
insert into DetalleVenta values(10008,13016,4)
insert into DetalleVenta values(10009,13029,1)
insert into DetalleVenta values(10009,13026,3)
insert into DetalleVenta values(10010,13027,5)
insert into DetalleVenta values(10010,13006,2)
insert into DetalleVenta values(10010,13007,1)
insert into DetalleVenta values(10011,13013,3)
insert into DetalleVenta values(10011,13012,3)
insert into DetalleVenta values(10012,13018,1)
insert into DetalleVenta values(10012,13020,1)
insert into DetalleVenta values(10013,13023,2)
insert into DetalleVenta values(10013,13024,1)
insert into DetalleVenta values(10013,13028,3)

select *  from DetalleVenta 
go



--SELECT Nro_Venta, Cod_Producto, Cantidad, Precio, Nombre_Producto, Clasificacion into #T1
--	FROM DetalleVenta D INNER JOIN Producto P
--	ON D.NroProducto = P.NroProducto

--SELECT IdVenta, Fecha, Nombre_Cliente, DNI_Cliente, Cantidad, NroUsuarios 
--	FROM Venta V INNER JOIN #T1 D 
--	ON V.Nro_Venta = D.Nro_Venta 

--SELECT IdVenta, Fecha, round(SUM(Cantidad*Precio),2) as Monto INTO ArqueoVenta
--	FROM Venta V INNER JOIN #T1 D 
--	ON V.Nro_Venta = D.Nro_Venta 
--	GROUP BY IdVenta, Fecha

--SELECT *
--	FROM ArqueoVenta
--	go


--DROP TABLE #T1
--go

SELECT IdVenta, Fecha, Nombre_Cliente, Nombre_Producto, DNI_Cliente, Cantidad, NroUsuarios INTO ReportVenta
	FROM Venta V INNER JOIN (SELECT Nro_Venta, Cod_Producto, Cantidad, Precio, Nombre_Producto, Clasificacion 
								FROM DetalleVenta D INNER JOIN Producto P
								ON D.NroProducto = P.NroProducto) D 
	ON V.Nro_Venta = D.Nro_Venta 


SELECT * FROM ReportVenta
go

drop table ReportVenta
go

drop table ArqueoVenta
go

SELECT IdVenta, Fecha, Nombre_Cliente, DNI_Cliente, Cantidad, NroUsuarios 
	FROM Venta V INNER JOIN (SELECT Nro_Venta, Cod_Producto, Cantidad, Precio, Nombre_Producto, Clasificacion 
								FROM DetalleVenta D INNER JOIN Producto P
								ON D.NroProducto = P.NroProducto) D 
	ON V.Nro_Venta = D.Nro_Venta 

SELECT IdVenta, Fecha, round(SUM(Cantidad*Precio),2) as Monto INTO ArqueoVenta
	FROM Venta V INNER JOIN (SELECT Nro_Venta, Cod_Producto, Cantidad, Precio, Nombre_Producto, Clasificacion 
								FROM DetalleVenta D INNER JOIN Producto P
								ON D.NroProducto = P.NroProducto) D 
	ON V.Nro_Venta = D.Nro_Venta 
	GROUP BY IdVenta, Fecha

SELECT *
	FROM ArqueoVenta
	go