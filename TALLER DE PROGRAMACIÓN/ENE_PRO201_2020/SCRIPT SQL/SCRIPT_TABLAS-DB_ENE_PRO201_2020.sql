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

alter proc sp_logins(@usuario varchar(30), @clave varchar(30))
as begin

 if not exists ( select *  from logins where usuario = @usuario)
	 begin
		select 1 as CodigoRet,
			   'Usuario incorrecto' as MensajeRet
			   return
	 end

 if not exists ( select *  from logins where usuario = @usuario and clave = @clave)
	 begin
		select 2 as CodigoRet,
			   'Clave incorrecta' as MensajeRet
			   return
	 end

end

/*
VALIDAR LOGINS
select * from logins
exec sp_logins 'admin','admin'

*/

go