Create Table Tbl_Formato_Pelicula
(
	fld_cod_for varchar(2) Not Null, -- codigo del formato de la pelicula,
	fld_desc_for varchar(50) Default '', -- descripcion del formato de la pelicula 
	Primary Key (fld_cod_for)
)