Create Proc USP_USU_LOG_IN
	@usuario varchar(50),
	@contrasena varchar(50),
	@sucursal varchar(4),
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Usuarios where fld_cod_usu = @usuario and fld_rei_usu = 1) -- El usuario se connecta por primera vez
			Begin
				set @message = 'CAMBIO' -- Solicitando un cambio de contrasena
			End
		else if exists(select 1 from Tbl_Usuarios where fld_cod_usu = @usuario and fld_con_usu = @contrasena and fld_est_usu = 'S')
			Begin
				set @message = 'SUSPENDIDO'
			End
		else if exists(select 1 from Tbl_Usuarios where fld_cod_usu = @usuario and fld_con_usu = @contrasena and fld_est_usu = 'V')
			Begin
				set @message = 'VACACION'
			End
		else if exists(select 1 from Tbl_Usuarios where fld_cod_usu = @usuario and fld_con_usu = @contrasena) -- El usuario se connecta exitosamente
			Begin
				-- En caso que el usuario ha sido inactivo por un periodo y reinicia sus actividades
				if exists(select 1 from Tbl_Usuarios where fld_cod_usu = @usuario and fld_est_usu = 'I')
					Begin
						Update Tbl_Usuarios
							set
								fld_est_usu = 'A'
							where
								fld_cod_usu = @usuario
					End
				
				set @message = 'CORRECTO'
				-- Actualizar el estado de sesion del usuario a En Sesion
				exec USP_SES_USU @fld_cod_usu=@usuario, @fld_suc_log=@sucursal, @fld_est_log=1

				-- Actualizar registrando el inicio de una nueva sesion del usuario
				exec USP_HIS_SES_USU @fld_cod_usu=@usuario, @fld_suc_log=@sucursal, @fld_est_log=1, @fld_act_log=@usuario
			End
		else if exists(select 1 from Tbl_Usuarios where fld_cod_usu = @usuario and not(fld_con_usu = @contrasena)) -- El usuario se equivoco de contrasena
			Begin
				set @message = 'INCORRECTO'
			End
		else
			Begin
				set @message = 'INVALIDO' -- el nombre de usuario no existe
			End
	End
	