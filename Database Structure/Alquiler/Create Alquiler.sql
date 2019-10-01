Create Table Tbl_Alquiler
(
	fld_num_alq varchar(50) Not Null, -- Numero de referencia del alquiler, puede repetirse aunque cada transaccion de alquiler se gestiona de manera unica 
	fld_cod_cli varchar(50) Not Null, -- codigo de membresia del cliente
	fld_cod_pel varchar(50) Not Null, -- codigo de la pelicula
	fld_cant_alq int Default 1, -- cantidad de unidad alquilada,
	fld_pre_alq Decimal(19,2) Default 0, -- precio del alquiler de la pelicula segun descuentos, promociones, etc.
	fld_fec_alq datetime Default '', -- fecha de realizar el alquiler
	fld_fec_ent datetime Default '', -- fecha de entrega del alquiler
	fld_est_alq varchar(1) Default 'A', -- estado del alquiler
	fld_cod_usu varchar(50) Not Null, -- nombre de usuario del empleado que atendio al cliente
)