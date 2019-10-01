Create Table Tbl_Tipo_Direccion
(
	fld_cod_tip varchar(1) Not Null, -- codigo del tipo de direccion
	fld_desc_tip varchar(30) Default '', -- descripcion del tipo de direccion
	Primary Key (fld_cod_tip)
)