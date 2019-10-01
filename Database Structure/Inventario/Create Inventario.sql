Create Table Tbl_Inventario
(
	fld_cod_pel varchar(50) Not Null, -- codigo de la pelicula
	fld_pre_pel Decimal(19,2) Default 0, -- precio unitario de la pelicula
	fld_suc_pel varchar(4) Not Null, -- surcursal del inventario en la cual se encuentra la pelicula
	fld_sto_pel int Default 0, -- cantidad de pelicula en stock
	fld_dis_pel int Default 0, -- cantidad de pelicula en la estanteria
	fld_out_pel int Default 0, -- cantidad de pelicula en alquiler
	fld_per_pel int Default 0, -- cantidad de peliculas perdidad/roto/etc. 
	fld_fec_act datetime Default '', -- fecha de ultima actualizacion
	fld_usu_act varchar(50) Not Null -- fecha del ultimo usuario que actualizo el inventario
)