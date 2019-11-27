Create Proc USP_MOD_USU
	@usuario varchar(50),
	@documento varchar(100),
	@desc_tipo_domumento varchar(50),
	@nombre varchar(100),
	@apellido varchar(100),
	@correo varchar(200),
	@desc_sexo varchar(30),
	@fehca_nacimiento datetime,
	@desc_nacionalidad varchar(50),
	@desc_cargo varchar(30),
	@salario Decimal(19,2),
	@desc_forma_pago varchar(30),
	@desc_rol varchar(30),
	@nombre_sucursal varchar(100),
	@usuario_actualizador varchar(50),
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Usuarios where fld_cod_usu = @usuario)
			Begin
				Update Tbl_Usuarios
					set
						fld_doc_usu = @documento,
						fld_tip_doc = (select DOC.fld_cod_tip from Tbl_Tipo_Documento as DOC where DOC.fld_desc_tip = @desc_tipo_domumento),
						fld_nom_usu = @nombre,
						fld_ape_usu = @apellido,
						fld_cor_cli = @correo,
						fld_sex_usu = (select SEX.fld_cod_sex from Tbl_Sexo as SEX where SEX.fld_desc_sex = @desc_sexo),
						fld_fec_nac = @fehca_nacimiento,
						fld_edad_usu = DATEDIFF(Year, @fehca_nacimiento, GETDATE()),
						fld_nac_usu = (select NAC.fld_cod_nac from Tbl_Nacionalidad as NAC where NAC.fld_desc_nac = @desc_nacionalidad),
						fld_car_usu = (select CAR.fld_cod_car from Tbl_Cargo_Usuario as CAR where CAR.fld_desc_car = @desc_cargo),
						fld_sal_usu = @salario,
						fld_for_pag = (select SAL.fld_cod_tip from Tbl_Tipo_Salario as SAL where SAL.fld_desc_tip = @desc_forma_pago),
						fld_rol_usu = (select ROL.fld_cod_rol from Tbl_Roles as ROL where ROL.fld_desc_rol = @desc_rol),
						fld_suc_usu = (select SUC.fld_cod_suc from Tbl_Sucursales as SUC where SUC.fld_nom_suc = @nombre_sucursal),
						fld_usu_act = @usuario_actualizador,
						fld_fec_act = GETDATE()
					where
						fld_cod_usu = @usuario

				set @message = 'Los datos han sido actualizado correctamente'
			End
		else
			Begin
				set @message = 'ERROR'
			End
	End






