Create Table Tbl_Direccion -- Se especifica el tipo de direccion en caso de oficinas o escuelas que desean alquilar peliculas
(
	fld_cod_cli varchar(50) Not Null, -- codigo de membresia del cliente y usuarios
	fld_dir_cli varchar(300) Default '', -- direccion del cliente y usuarios
	fld_tip_dir varchar(1) Default 'C', -- tipo de direccion del cliente y usuario; solo Casas para los empleados
	fld_sec_dir varchar(50) Default '', -- sector de la direccion del cliente y usuarios
	fld_ciu_dir varchar(50) Default '' -- ciudad de la direccion del cliente y usuarios
)