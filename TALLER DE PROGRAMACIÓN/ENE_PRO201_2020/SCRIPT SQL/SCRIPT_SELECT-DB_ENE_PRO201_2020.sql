use AIEP_TPROGRMACION

go
--=====================================================================================
--LOGINS
--=====================================================================================
select * from usuario

go
--=====================================================================================
--TIPO REQUERIMIENTO
--=====================================================================================
select * from tipo_requerimiento

go
--=====================================================================================
--PRIORIDAD
--=====================================================================================
select * from tipo_prioridad

go
--=====================================================================================
--REQUERIMIENTO
--=====================================================================================
--select * from requerimiento

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
	 





