Create Proc USP_INS_EST_SES
	@fld_cod_est bit, -- codigo de estago de
	@fld_desc_est varchar(50), -- descripcion del estado de la session 
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Estado_Sesion where fld_cod_est = @fld_cod_est)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Estado_Sesion where fld_desc_est = @fld_desc_est)
			Begin
				set @message = 'Descripcionn Invalida'
			End
		else
			Begin
				Insert Into Tbl_Estado_Sesion
				(
					fld_cod_est,
					fld_desc_est
				)
				values
				(
					@fld_cod_est,
					@fld_desc_est
				)
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
	End

Create Proc USP_MOD_EST_SES
	@fld_cod_est bit, -- codigo de estago de
	@nuevo_est varchar(50), -- nueva descripcion del estado de la session 
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Estado_Sesion where fld_cod_est = @fld_cod_est and not(fld_desc_est = @nuevo_est))
			Begin
				Update Tbl_Estado_Sesion
					set
						fld_desc_est = @nuevo_est
					where
						fld_cod_est = @fld_cod_est
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Estado_Sesion where fld_cod_est = @fld_cod_est and fld_desc_est = @nuevo_est)
			Begin
				set @message = 'Descripcionn Invalida'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End


