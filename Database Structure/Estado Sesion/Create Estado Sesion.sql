Create Table Tbl_Estado_Sesion
(
	fld_cod_est bit Not Null, -- codigo de estago de
	fld_desc_est varchar(50) Default '', -- descripcion del estado de la session 
	Primary Key (fld_cod_est)
)