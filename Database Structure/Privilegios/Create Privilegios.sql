Create Table Tbl_Privilegios
(
	fld_cod_pri varchar(1) Not Null, -- codigo del privilegio
	fld_desc_pri varchar(30) Default '', -- descripcion del privilegio
	Primary Key (fld_cod_pri) 
)