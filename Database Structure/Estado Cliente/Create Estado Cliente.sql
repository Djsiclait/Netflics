Create Table Tbl_Estado_Cliente
(
	fld_cod_est varchar(1) Not Null, -- codigo del estado del cliente
	fld_desc_est varchar(30) Default '', -- descripcion del estado del cliente
	Primary Key (fld_cod_est)
)