Create Table Tbl_Usuarios
(
	fld_cod_usu varchar(50) Not Null, -- nombre de usuario del empleado
	fld_con_usu varchar(50) Default '12345', -- contrasena del usuario
	fld_doc_usu varchar(100) Default '', -- documento de identificacion del empleado
	fld_tip_doc varchar(3) Default 'CED', -- tipo de documento del empleado
	fld_nom_usu varchar(100) Default '', -- nombre del empleado
	fld_ape_usu varchar(100) Default '', -- apellido del empleado
	fld_cor_cli varchar(200) Default '', -- correo electronico del empleado
	fld_sex_usu varchar(1) Default 'H', -- sexo del empleado
	fld_fec_nac datetime Default '', -- fecha de nacimiento del empleado
	fld_edad_usu int Default 18, -- edad del empleado siempre el minimo es 18 ya que solo contratan personas mayot de edad
	fld_nac_usu varchar(3) Default 'DOM', -- nacionalidad del empleado
	fld_est_usu varchar(1) Default 'A', -- estado del empleado en caso de despedidos para desactivar sus cuentas o estan de vacacion
	fld_car_usu varchar(3) Default 'CAJ', -- puesto del empleado
	fld_sal_usu Decimal(19,2) Default 0, -- salario del empleado
	fld_for_pag varchar(3) Default 'QUI', -- forma de pagar el salario del empleado; semanal, quincenal o mensual
	fld_rol_usu varchar(1) Default 'A', -- el rol del usuario que define que tipo de vistas tiene acceso 
	fld_suc_usu varchar(4) Default 'PLA1', -- surcusal donde se assigna el empleado 
	fld_fec_reg datetime Default'', -- fecha de registro del empleado
	fld_usu_reg varchar(50) Default '', -- usuario que registo el empleado
	fld_fec_act datetime Default '', -- fecha de ultima actualizacion 
	fld_usu_act varchar(50) Default '', -- usuario que realizo la ultima actualizacion 
	fld_rei_usu bit Default 1, -- es necesario reiniciar la contrasena 0 = false y 1 = true
	Primary Key (fld_cod_usu) 
)
