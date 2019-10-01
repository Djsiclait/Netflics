Create Table Tbl_Cargo_Usuario
(
	fld_cod_car varchar(3) Not Null, -- codigo del cargo del empleado
	fld_desc_car varchar(30) Default '', -- descripcion del cargo del empleado
	Primary Key (fld_cod_car)
)