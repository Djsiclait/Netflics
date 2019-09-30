Create Table Tbl_Tipo_Membresia -- desde Basico hasta Diamante
(
	fld_cod_tip varchar(1) Not Null, -- codigo del tipo de membresia
	fld_desc_tip varchar(30) Default '', -- descripcion del tipo de membresia
	Primary Key (fld_cod_tip)
)
