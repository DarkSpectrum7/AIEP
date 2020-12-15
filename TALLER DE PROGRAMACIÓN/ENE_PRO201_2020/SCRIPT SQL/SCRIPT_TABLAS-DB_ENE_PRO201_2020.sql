create database AIEP_TPROGRMACION

go

use AIEP_TPROGRMACION

go

create table logins (	usuario varchar(30) primary key,
						clave varchar(30),
						nombre varchar(100))

go

insert logins  select 'admin','admin','Administrador'

go



go