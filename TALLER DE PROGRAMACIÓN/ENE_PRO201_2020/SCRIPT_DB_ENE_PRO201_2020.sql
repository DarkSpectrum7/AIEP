--create database ENE_PRO201_2020

use ENE_PRO201_2020

go
--=====================================================================================
--REQUERIMIENTO
--=====================================================================================
create table tipo_requerimiento (	id_tipo int primary key,
									glosa varchar (50))

go

insert tipo_requerimiento select 1, 'Base de Datos'
insert tipo_requerimiento select 2, 'Sistemas'
insert tipo_requerimiento select 3, 'Instalacion Software'

go

--=====================================================================================
--PRIORIDAD
--=====================================================================================
create table prioridad (id varchar (10) primary key,
						glosa varchar (50),
						plazo varchar (30))

go

insert prioridad select 1, 'Alta','3 días de plazo.'
insert prioridad select 2, 'Media','4 días de plazo.'
insert prioridad select 3, 'Baja','5 días de plazo.'

go
--=====================================================================================
--USUARIO
--=====================================================================================
create table usuario (	id_usuario int primary key,
						nombre varchar (100),
						clave varchar (30),
						)

go

insert usuario select '', '',''
insert usuario select '', '',''
insert usuario select '', '',''

go
--=====================================================================================
--MENU
--=====================================================================================
create table menu (id_menu int primary key,
					)


go
--=====================================================================================
--ROL
--=====================================================================================
create table rol (id_rol varchar (100) primary key,
					nombre varchar (100))

go

insert rol select 'Administrador','Administrados del sistema'
insert rol select 'Analista','Analista de requeimiento'

go
--=====================================================================================
--
--=====================================================================================
