Create Table Tbl_Historial_Sesion_Usuario -- Historial de actividad de sesion de los usuarios 
(
	fld_cod_usu varchar(50) Not Null, -- nombre de usuario del empleado
	fld_fec_log datetime Default '', -- ultima fecha de actividad del usuario
	fld_suc_log varchar(4) Not Null, -- la ultima surcursal de actividad del usuario
	fld_est_log bit Default 0, -- estado de cuenta 0 = Fuera de Sesion y 1 = En Sesion
	fld_act_log varchar(50) Default '', -- usuario o evento responsable por el cambio de estado de sesion 
)