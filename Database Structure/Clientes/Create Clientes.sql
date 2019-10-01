Create Table Tbl_Clientes
(
	fld_cod_cli varchar(50) Not Null, -- codigo de su membresia del cliente usado por el sistema 
	fld_tip_cod varchar(1) Default 'B', -- tipo de membresia del cliente
	fld_doc_cli varchar(100) Default '', -- algun documento de identificacion del cliente como cedula o pasaporte
	fld_tip_doc varchar(3) Default 'CED', -- el tipo de documento de identificacion del cliente
	fld_nom_cli varchar(100) Default '', -- nombre del cliente
	fld_ape_cli varchar(100) Default '', -- apellido del cliente
	fld_cor_cli varchar(200) Default '', -- correo electronico del cliente
	fld_sex_cli varchar(1) Default 'H', -- sexo del cliente
	fld_fec_nac datetime Default '', -- fecha de nacimiento del cliente
	fld_edad_cli int Default 14, -- edad del cliente; es minimo 14 ya que permite a padres realizar una membresia para sus adolescentes
	fld_nac_cli varchar(3) Default 'DOM', -- nacionalidad del cliente
	fld_est_cli varchar(1) Default 'A', -- estado del cliente dependiendo si ha pagado su membresia o no
	fld_fec_reg datetime Default '',  -- fecha de registro del cliente
	Primary Key (fld_cod_cli)
)