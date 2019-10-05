Create Proc USP_INS_NEW_USU
	@usuario varchar(50),
	@documento varchar(100),
	@desc_tipo_documento varchar(50), -- descripcion del tipo de documento
	@nombre varchar(100),
	@apellido varchar(100),
	@correo varchar(200),
	@desc_sexo varchar(30), -- descripcion del sexo
	@fecha_nacimiento datetime,
	@desc_nacionalidad varchar(50), -- descripcion de la nacionalidad
	@desc_cargo varchar(30), -- descripcion del cargo
	@salario Decimal(19,2),
	@desc_forma_pago varchar(30), -- descripcion de la forma de pago
	@desc_rol varchar(30), -- descripcion del rol
	@nombre_sucursal varchar(100), -- nombre del sucursal
	@usuario_registrador varchar(50), -- nombre de usuario del empleado que creo la cuenta para el usuario
	@message varchar(200) output
	as 
	Begin
		Insert Into Tbl_Usuarios
		(
			fld_cod_usu,
			fld_doc_usu,
			fld_tip_doc,
			fld_nom_usu,
			fld_ape_usu,
			fld_cor_usu,
			fld_sex_usu,
			fld_fec_nac,
			fld_edad_usu,
			fld_nac_usu,
			fld_car_usu,
			fld_sal_usu,
			fld_for_pag,
			fld_rol_usu,
			fld_suc_usu,
			fld_fec_reg,
			fld_usu_reg
		)
		values
		(
			@usuario,
			@documento,
			(select DOC.fld_cod_tip from Tbl_Tipo_Documento as DOC where DOC.fld_desc_tip = @desc_tipo_documento),
			@nombre,
			@apellido,
			@correo,
			(select SEX.fld_cod_sex from Tbl_Sexo as SEX where SEX.fld_desc_sex = @desc_sexo),
			@fecha_nacimiento,
			DATEDIFF(Year, @fecha_nacimiento, GETDATE()),
			(select NAC.fld_cod_nac from Tbl_Nacionalidad as NAC where NAC.fld_desc_nac = @desc_nacionalidad),
			(select CAR.fld_cod_car from Tbl_Cargo_Usuario as CAR where CAR.fld_desc_car = @desc_cargo),
			@salario,
			(select SAL.fld_cod_tip from Tbl_Tipo_Salario as SAL where SAL.fld_desc_tip = @desc_forma_pago),
			(select ROL.fld_cod_rol from Tbl_Roles as ROL where ROL.fld_desc_rol = @desc_rol),
			(select SUC.fld_cod_suc from Tbl_Sucursales as SUC where SUC.fld_nom_suc = @nombre_sucursal),
			GETDATE(),
			@usuario_registrador
		)

		if exists(Select 1 from Tbl_Usuarios where fld_cod_usu = @usuario)
			Begin
				set @message = 'EXITO'
			End
		else
			Begin
				set @message = 'ERROR'
			End
	End

	 

