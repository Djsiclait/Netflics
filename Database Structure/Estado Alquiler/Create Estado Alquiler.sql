Create Table Tbl_Estado_Alquiler
(
	fld_cod_est varchar(1) Not Null, -- codigo del estado de alquiler
	fld_desc_est varchar(50) Default '', -- descripcion del estado de alquiler 
	Primary Key (fld_cod_est)
)