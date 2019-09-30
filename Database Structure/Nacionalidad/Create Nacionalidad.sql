Create Table Tbl_Nacionalidad
(
	fld_cod_nac varchar(3) Not Null, -- codigo de la nacionalidad
	fld_desc_nac varchar(50) Default '', -- descripcion de la nacionalidad
	Primary Key (fld_cod_nac)
)