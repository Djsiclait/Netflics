Create Table Tbl_Sexo
(
	fld_cod_sex varchar(1) Not Null, -- Codigo del sexo
	fld_desc_sex varchar(30) Default '', -- descripcion del sexo
	Primary Key (fld_cod_sex)
)