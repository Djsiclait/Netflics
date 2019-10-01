Create Table Tbl_Telefono
(
	fld_cod_cli varchar(50) Not Null, -- codigo de membresia del cliente
	fld_tel_cli varchar(30) Default '', -- telefono del cliente
	fld_tip_tel varchar(3) Default 'CEL', -- tipo de telefono del cliente
	fld_est_tel varchar(1) Default 'A' -- estado del telefono del cliente
)