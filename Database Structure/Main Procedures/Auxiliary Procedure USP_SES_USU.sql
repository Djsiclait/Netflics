Create Proc USP_SES_USU
	@fld_cod_usu varchar(50),
	@fld_suc_log varchar(4),
	@fld_est_log bit
	as
	Begin
		if exists(select 1 from Tbl_Sesion_Usuario where fld_cod_usu = @fld_cod_usu) -- Actualizando el cambio de conexion del usuario
			Begin
				Update Tbl_Sesion_Usuario
					set
						fld_fec_log = GETDATE(),
						fld_suc_log = @fld_suc_log,
						fld_est_log = @fld_est_log
					where
						fld_cod_usu = @fld_cod_usu
			End
		else
			Begin
				Insert Into Tbl_Sesion_Usuario
				(
					fld_cod_usu,
					fld_fec_log,
					fld_suc_log,
					fld_est_log
				)
				values
				(
					@fld_cod_usu,
					GETDATE(),
					@fld_suc_log,
					1
				)
			End
	End