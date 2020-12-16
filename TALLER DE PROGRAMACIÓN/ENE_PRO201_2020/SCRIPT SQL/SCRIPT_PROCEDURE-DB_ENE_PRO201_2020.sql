use AIEP_TPROGRMACION

go
--===============================================================================================
--PROCEDURE VALIDACION USUARIO ACCESO A SISTEMA
--===============================================================================================
create proc sp_ValidaUsuario(@usuario varchar(30), @clave varchar(30))
as begin

 if not exists ( select *  from usuario where id_cuenta = @usuario)
	 begin
		select 1 as CodigoRet,
			   'Usuario incorrecto' as MensajeRet
			   return
	 end

 if not exists ( select *  from usuario where id_cuenta = @usuario and clave = @clave)
	 begin
		select 2 as CodigoRet,
			   'Clave incorrecta' as MensajeRet
			   return
	 end

end

/*
VALIDAR LOGINS

select * from logins

exec sp_ValidaUsuario 'admin','admin'

*/

--===============================================================================================
--
--===============================================================================================