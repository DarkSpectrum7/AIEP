create database AIEP_TPROGRMACION

go

use AIEP_TPROGRMACION

go
--=====================================================================================
--LOGINS
--=====================================================================================
create table usuario (	id_cuenta varchar(30) primary key not null,
						clave varchar(30) not null,
						tipo_usuario varchar(100) not null,
						nombre varchar(100) not null)

go

insert usuario  select 'admin','admin','Administrador','Administrador'
insert usuario  select 'usr1','usr1','Analista','Juan Perez'
insert usuario  select 'usr2','usr2','Programador','Patricio Vasquez'
insert usuario  select 'usr3','usr3','Soporte','Alejandro Martinez'

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

insert requerimiento values ('Solicitud...','P',getdate(),1,1,'usr1')
insert requerimiento values ('Solicitud...','P',getdate(),2,1,'usr1')
insert requerimiento values ('Solicitud...','P',getdate(),3,1,'usr1')
insert requerimiento values ('Solicitud...','P',getdate(),1,2,'usr2')
insert requerimiento values ('Solicitud...','P',getdate(),2,2,'usr2')
insert requerimiento values ('Solicitud...','P',getdate(),3,2,'usr2')
insert requerimiento values ('Solicitud...','P',getdate(),1,3,'usr3')
insert requerimiento values ('Solicitud...','P',getdate(),2,3,'usr3')
insert requerimiento values ('Solicitud...','P',getdate(),3,3,'usr3')
insert requerimiento values ('Solicitud...','R',getdate(),1,1,'usr1')
insert requerimiento values ('Solicitud...','R',getdate(),2,1,'usr1')
insert requerimiento values ('Solicitud...','R',getdate(),3,1,'usr1')
insert requerimiento values ('Solicitud...','R',getdate(),1,2,'usr2')
insert requerimiento values ('Solicitud...','R',getdate(),2,2,'usr2')
insert requerimiento values ('Solicitud...','R',getdate(),3,2,'usr2')
insert requerimiento values ('Solicitud...','R',getdate(),1,3,'usr3')
insert requerimiento values ('Solicitud...','R',getdate(),2,3,'usr3')
insert requerimiento values ('Solicitud...','R',getdate(),3,3,'usr3')
