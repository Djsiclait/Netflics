Create Proc USP_INS_EST_TEL
	@fld_cod_est varchar(1), -- codigo del estado de telefono
	@fld_desc_est varchar(30), -- descripcion del estado de telefono
	@message varchar(200) output
	as
	Begin
		if exists(Select 1 from Tbl_Estado_Telefono where fld_cod_est = @fld_cod_est)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Estado_Telefono where fld_desc_est = @fld_desc_est)
			Begin
				set @message = 'Descipcion Invalida'
			End
		else
			Begin
				Insert Into Tbl_Estado_Telefono
				(
					fld_cod_est,
					fld_desc_est
				)
				values
				(
					@fld_cod_est,
					@fld_desc_est
				)

				set @message = 'Los daots han sido actualizado correctamente.'
			End
	End

Create Proc USP_MOD_EST_TEL
	@fld_cod_est varchar(1), -- codigo del estado de telefono
	@nuevo_est varchar(30), -- nueva descripcion del estado de telefono
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Estado_Telefono where fld_cod_est = @fld_cod_est and not(fld_desc_est = @nuevo_est))
			Begin
				Update Tbl_Estado_Telefono
					set
						fld_desc_est = @nuevo_est
					where
						fld_cod_est = @fld_cod_est
				
				set @message = 'Los daots han sido actualizado correctamente.'
			End
		else if exists(select 1 from Tbl_Estado_Telefono where fld_cod_est = @fld_cod_est and fld_desc_est = @nuevo_est)
			Begin
				set @message = 'Descipcion Invalida'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End









