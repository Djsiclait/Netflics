Create Table Tbl_Contenido_Factura
(
	fld_cod_fac varchar(50) Not Null, -- codigo de la factura
	fld_cod_peli varchar(50) Not Null, -- codigo de la pelicula alquilada
	fld_cod_alq varchar(50) Not Null, -- codigo del alquiler
	fld_pre_alq Decimal(19,2) Default 0, -- precio con la cual se alquilo la pelicula
)