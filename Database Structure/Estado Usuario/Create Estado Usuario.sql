Create Table Tbl_Estado_Usuario
(
	fld_cod_est varchar(1) Not Null, -- codigo del estado del usuario
	fld_desc_est varchar(30) Default '', -- descripcion del estado de usuario
	Primary Key (fld_cod_est)
)