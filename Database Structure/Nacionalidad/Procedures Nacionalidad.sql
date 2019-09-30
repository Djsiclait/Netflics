Create Proc USP_INS_NAC
	@fld_cod_nac varchar(3),
	@fld_desc_nac varchar(50), -- descripcion de la nacionalidad
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Nacionalidad where fld_cod_nac = @fld_cod_nac)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Nacionalidad where fld_desc_nac = @fld_desc_nac)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				Insert Into Tbl_Nacionalidad
				(
					fld_cod_nac,
					fld_desc_nac
				)
				values
				(
					@fld_cod_nac,
					@fld_desc_nac
				)

				set @message = 'Los datos han sido actualizado correctamente'
			End
	End

Create Proc USP_MOD_NAC
	@fld_cod_nac varchar(3),
	@nuevo_nac varchar(50), -- nueva descripcion de la nacionalidad
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Nacionalidad where fld_cod_nac = @fld_cod_nac and not(fld_desc_nac = @nuevo_nac))
			Begin
				Update Tbl_Nacionalidad
					set
						fld_desc_nac = @nuevo_nac
					where
						fld_cod_nac = @fld_cod_nac

				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Nacionalidad where fld_cod_nac = @fld_cod_nac and fld_desc_nac = @nuevo_nac)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End
