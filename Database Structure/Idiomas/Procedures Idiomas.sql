Create Proc USP_INS_IDI
	@fld_cod_idi varchar(4), -- codigo del idioma
	@fld_desc_idi varchar(50), -- descripcion del idioma
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Idiomas where fld_cod_idi = @fld_cod_idi)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Idiomas where fld_desc_idi = @fld_desc_idi)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else 
			Begin
				Insert Into Tbl_Idiomas
				(
					fld_cod_idi,
					fld_desc_idi
				)
				values
				(
					@fld_cod_idi,
					@fld_desc_idi
				)

				set @message = 'Los datos han sido actualizado correctamente'
			End
	End

Create Proc USP_MOD_IDI
	@fld_cod_idi varchar(4), -- codigo del idioma
	@nuevo_idi varchar(50), -- nueva descripcion del idioma
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Idiomas where fld_cod_idi = @fld_cod_idi and not(fld_desc_idi = @nuevo_idi))
			Begin
				Update Tbl_Idiomas
					set
						fld_desc_idi = @nuevo_idi
					where
						fld_cod_idi = @fld_cod_idi
			
				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Idiomas where fld_cod_idi = @fld_cod_idi and fld_desc_idi = @nuevo_idi)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End















