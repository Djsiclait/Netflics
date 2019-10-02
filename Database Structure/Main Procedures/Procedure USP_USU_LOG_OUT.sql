Create Proc USP_USU_LOG_OUT
	@usuario varchar(50),
	@sucursal varchar(4),
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Usuarios where fld_cod_usu = @usuario)
			Begin
				-- Actualizar el estado de sesion del usuario a En Sesion
				exec USP_SES_USU @fld_cod_usu=@usuario, @fld_suc_log=@sucursal, @fld_est_log=0

				-- Actualizar registrando el inicio de una nueva sesion del usuario
				exec USP_HIS_SES_USU @fld_cod_usu=@usuario, @fld_suc_log=@sucursal, @fld_est_log=0, @fld_act_log=@usuario
			
				set @message = 'EXITO'
			End
		else
			Begin
				set	@message = 'ERROR'
			End
	End