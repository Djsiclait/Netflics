Create Proc USP_INS_ROL
	@fld_cod_rol varchar(1), -- codigo del rol usuario
	@fld_desc_rol varchar(30), -- descripcion del rol de usuario
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Roles where fld_cod_rol = @fld_cod_rol)
			Begin
				set @message = 'Codigo Invalido'	
			End
		else if exists(select 1 from Tbl_Roles where fld_desc_rol = @fld_desc_rol)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				Insert Into Tbl_Roles
				(
					fld_cod_rol,
					fld_desc_rol
				)
				values
				(
					@fld_cod_rol,
					@fld_desc_rol
				)

				set @message = 'Los datos han sido actualizado correctamente'
			End
	End


Create Proc USP_MOD_ROL
	@fld_cod_rol varchar(1), -- codigo del rol usuario
	@nuevo_rol varchar(30), -- nueva descripcion del rol de usuario
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Roles where fld_cod_rol = @fld_cod_rol and not(fld_desc_rol = @nuevo_rol))
			Begin
				Update Tbl_Roles
					set
						fld_desc_rol = @nuevo_rol
					where
						fld_cod_rol = @fld_cod_rol
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Roles where fld_cod_rol = @fld_cod_rol and fld_desc_rol = @nuevo_rol)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End
