Create Table Tbl_Tipo_Telefono
(
	fld_cod_tip varchar(3) Not Null, -- codigo del tipo de telefono
	fld_desc_tip varchar(30) Default '', -- descripcion del tipo de telefono
	Primary Key (fld_cod_tip) 	
)