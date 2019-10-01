Create Table Tbl_Privilegios_Usuarios -- los privilegios de los empleados dentro del sistema
(
	fld_cod_usu varchar(50) Not Null, -- nombre de usuario del empleado
	fld_cod_pri varchar(1) Not Null, -- codigo del privilegio del empleado
	fld_usu_per varchar(50) Not Null, -- nombre del usuario que dio el privilegio
	fld_fec_pri datetime Default '', -- la fecha en la cual se dio los privilegios
	fld_rev_pri bit Default 0 -- revocacion de privilegio; 1 = Permitido y 0 = Revocar Privilegio
)