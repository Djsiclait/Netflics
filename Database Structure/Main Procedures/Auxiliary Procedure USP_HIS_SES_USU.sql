Create Proc USP_HIS_SES_USU
	@fld_cod_usu varchar(50), -- el usuario que se conecta o desconecta
	@fld_suc_log varchar(4), -- sucursal origin de la actividad
	@fld_est_log bit, -- estado de la sesion dado la actividad
	@fld_act_log varchar(50) -- usuario o evento responsable por el cambio de estado de sesion
	as
	Begin
		Insert Into Tbl_Historial_Sesion_Usuario
		(
			fld_cod_usu,
			fld_fec_log,
			fld_suc_log,
			fld_est_log,
			fld_act_log
		)
		values
		(
			@fld_cod_usu,
			GETDATE(),
			@fld_suc_log,
			@fld_est_log,
			@fld_act_log
		)
	End



