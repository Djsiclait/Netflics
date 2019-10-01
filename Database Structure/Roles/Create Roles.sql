Create Table Tbl_Roles
(
	fld_cod_rol varchar(1) Not Null, -- codigo del rol usuario
	fld_desc_rol varchar(30) Default '', -- descripcion del rol de usuario
	Primary Key (fld_cod_rol)
)