Create Table Tbl_Paises
(
	fld_cod_pai varchar(3) Not Null, -- codigo del pais
	fld_desc_pai varchar(100) Default '', -- descripcion del pais 
	Primary Key (fld_cod_pai)
)