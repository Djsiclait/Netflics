Create Proc USP_CHANGE_PASS_USU
	@usuario varchar(50), -- el usuario que desa cambiar su contrasena 
	@nueva_contrasena varchar(50), -- la nueva contrasena
	@message varchar(200) output
	as 
	Begin
		if exists(Select 1 from Tbl_Usuarios where fld_cod_usu = @usuario and not(fld_con_usu = @nueva_contrasena))
			Begin
				Update Tbl_Usuarios
					set
						fld_con_usu = @nueva_contrasena,
						fld_rei_usu = 0
					where
						fld_cod_usu = @usuario
				
				set @message = 'EXITO'
			End
		else if exists(Select 1 from Tbl_Usuarios where fld_cod_usu = @usuario and fld_con_usu = @nueva_contrasena)
			Begin
				set @message = 'Contrasena Invalidada'
			End
		else
			Begin
				set @message = 'Usuario Invalido'
			End
	End