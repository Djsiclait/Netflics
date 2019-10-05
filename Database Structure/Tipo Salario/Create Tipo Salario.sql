Create Table Tbl_Tipo_Salario
(
	fld_cod_tip varchar(3) Not Null, -- codigo de tipo de salario
	fld_desc_tip varchar(30) Default '', -- descripcion de tipo de salario
	Primary Key (fld_cod_tip)
)