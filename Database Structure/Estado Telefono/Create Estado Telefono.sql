Create Table Tbl_Estado_Telefono
(
	fld_cod_est varchar(1) Not Null, -- codigo del estado de telefono
	fld_desc_est varchar(30) Default '', -- descripcion del estado de telefono
	Primary Key (fld_cod_est)
)