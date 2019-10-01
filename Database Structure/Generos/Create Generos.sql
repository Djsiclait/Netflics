Create Table Tbl_Generos
(
	fld_cod_gen varchar(3) Not Null, -- codigo del genero
	fld_desc_gen varchar(50) Default '', --descripcion del genero
	Primary Key (fld_cod_gen)
)