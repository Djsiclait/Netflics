Create Table Tbl_Sucursales
(
	fld_cod_suc varchar(4) Not Null, -- codigo de la sucursal
	fld_nom_suc varchar(100) Default '', -- nombre del sucursal
	fld_sup_suc varchar(50) Not Null, -- nombre de usuario del supervisor de la sucursal
	fld_dir_suc varchar(200) Default '', -- direccion de la sucursal
	fld_sec_suc varchar(50) Default '', -- Sector de la sucursal
	fld_ciu_suc varchar(50) Default '', -- ciudad de la sucursal 
	Primary Key (fld_cod_suc)
)