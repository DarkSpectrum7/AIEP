create database AIEP_TPROGRMACION

go

use AIEP_TPROGRMACION

go
--=====================================================================================
--LOGINS
--=====================================================================================
create table usuario (	id_cuenta varchar(30) primary key not null,
						clave varchar(30) not null,
						nombre varchar(100) not null)

go

select * from usuario

insert usuario  select 'admin','admin','Administrador'
insert usuario  select 'usr1','usr1','Analista'
insert usuario  select 'usr2','usr2','Programador'
insert usuario  select 'usr3','usr3','Soporte'

go
--=====================================================================================
--TIPO REQUERIMIENTO
--=====================================================================================
create table tipo_requerimiento (	id_tipo int identity (1,1) primary key not null, 
									tipo_req varchar(50) not null)

go

insert tipo_requerimiento  select 'Base de Datos'
insert tipo_requerimiento  select 'Sistemas'
insert tipo_requerimiento  select 'Instalación Software'

go
--=====================================================================================
--PRIORIDAD
--=====================================================================================
create table tipo_prioridad (	id_prioridad int identity (1,1) primary key not null, 
								prioridad varchar(50) not null, 
								plazo int not null)

insert tipo_prioridad  select 'Alta',3
insert tipo_prioridad  select 'Media',4
insert tipo_prioridad  select 'Baja',5

go
--=====================================================================================
--REQUERIMIENTO
--=====================================================================================
create table requerimiento (id_req int identity (1,1) primary key not null, 
							descripcion varchar(300) not null,
							estado char(1) not null,
							fecha_ingreso date not null,
							id_tipo int not null,
							id_prioridad int not null,
							id_cuenta varchar(30) not null,
							foreign key (id_tipo) references tipo_requerimiento(id_tipo),
							foreign key (id_prioridad) references tipo_prioridad(id_prioridad),
							foreign key (id_cuenta) references usuario(id_cuenta))

go

insert requerimiento select 'instalar office','P',3,2,'20201212','gmoya'
insert requerimiento select 'instalar antivirus','P',3,1,'20201212','gmoya'

go

--=====================================================================================
--SI ALCANZAMOS HACEMOS LOS ACCESOS CON PERFILES Y NIVEL DE PRIVILEGIO
--=====================================================================================
--=====================================================================================
--PERFIL
--=====================================================================================
--create table perfil (id_per varchar(20) primary key, 
--					nombre varchar(100))

--go

--insert perfil select 'administrador','Administrador del sistema'
--insert perfil select 'analista','Analista de Requerimientos'

--go
--=====================================================================================
--PRIVILEGIO
--=====================================================================================
--create table privilegio (	id_rol varchar(20), 
--							id_menu varchar(10))

--go

--insert privilegio select 'administrador','SR01'
--insert privilegio select 'administrador','SR02'
--insert privilegio select 'analista','SR02'

--go
--=====================================================================================
--MENU
--=====================================================================================
--create table menu (	id_menu varchar(10) primary key, 
--					glosa varchar(100))

--insert menu select 'SR01','Ingresar Requerimiento'
--insert menu select 'SR02','Consultar Requerimiento'

--go
--=====================================================================================
--USUARIO
--=====================================================================================
--create table usuario (	id_usuario varchar(30) primary key, 
--						nombre varchar(100), 
--						clave varchar(30))
--						--id_rol varchar(20))

--go

--insert usuario  select 'blisboa','bernardo lisboa','123456','administrador'
--insert usuario  select 'gmoya','gonzalo moya','123456','administrador'
--insert usuario  select 'mferrada','mauricio ferrada','123456','analista'
--insert usuario  select 'spizarro','sebastian pizarro','123456','analista'

--go