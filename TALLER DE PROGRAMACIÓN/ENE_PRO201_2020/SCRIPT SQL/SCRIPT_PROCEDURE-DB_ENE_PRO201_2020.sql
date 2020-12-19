use AIEP_TPROGRMACION

go
--===============================================================================================
--PROCEDURE VALIDACION USUARIO ACCESO A SISTEMA
--===============================================================================================
create proc SP_ValidaUsuario(@usuario varchar(30), @clave varchar(30))
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

go
--===============================================================================================
--MARCAR COMO RESUELTO
--===============================================================================================
create  proc SP_Mresuelto(@id_req int)
as begin

  if exists ( select *  from requerimiento where id_req = @id_req)
	begin 
	  update requerimiento
	  set estado = 'R'
	  where id_req = @id_req

	  select 0 as CodigoRet,'Requerimiento Resuelto.' as MensajeRet 
	end
   else
	  select 1 as CodigoRet,'Numero de requerimiento no existe.' as MensajeRet 
end

--exec sp_Mresuelto 8
go
--===============================================================================================
--ELIMINAR REQURIMIENTO
--===============================================================================================
create proc SP_ERequerimiento(@id_req int)
as begin
  delete from requerimiento where id_req = @id_req
  select 0 as CodigoRet,'Requerimiento ' + convert(varchar(10),@id_req ) +' fue eliminado ' as MensajeRet
end

go
--===============================================================================================
--CARGAR DATA GRID
--===============================================================================================
create  proc SP_CargaDT 
as
begin
	select	r.id_req as 'Código',
	       tr.tipo_req as 'Tipo Requerimiento',
			r.descripcion as 'Descripción',
			r.estado as 'Estado',
			p.prioridad as 'Prioridad',
			p.plazo as 'Plazo',
			u.nombre as 'Asignado'
	from requerimiento r

	inner join tipo_prioridad p
	on r.id_prioridad = p.id_prioridad

	inner join tipo_requerimiento tr
	on tr.id_tipo = r.id_tipo 

		inner join usuario u
		on u.id_cuenta = r.id_cuenta 
end

--exec SP_CargaDT
go
--===============================================================================================
--GUARDAR REQUERIMIENTO
--===============================================================================================
create  proc SP_InsertarReq(@tipoReq int, 
							@usuario varchar(30),
							@desc varchar(300),
							@prioridad int)
as begin
 declare  @plazo int,
          @idReq int

 select @idReq  = isnull(max(id_req),0) + 1 from requerimiento
 select @plazo  = plazo  from tipo_prioridad where id_prioridad = @prioridad
 insert requerimiento select @desc ,'P',getdate(), @tipoReq,@prioridad, @usuario
   select 0 as CodigoRet,'Requerimiento ' + convert(varchar(10),@idReq ) +' fue guardado exitozamente, el plazo para resolverlo es ' + convert(varchar(10),@plazo) + ' días'  as MensajeRet

end


--exec SP_InsertarReq 1,'usr1','Descripcion...',1

