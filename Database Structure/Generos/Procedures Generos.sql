Create Proc USP_INS_GEN
	@fld_cod_gen varchar(3), -- codigo del genero
	@fld_desc_gen varchar(50), --descripcion del genero
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Generos where fld_cod_gen = @fld_cod_gen)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Generos where fld_desc_gen = @fld_desc_gen)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				Insert Into Tbl_Generos
				(
					fld_cod_gen,
					fld_desc_gen
				)
				values
				(
					@fld_cod_gen,
					@fld_desc_gen
				)

				set @message = 'Los datos han sido actualizado correctamente'
			End
	End 

Create Proc USP_MOD_GEN
	@fld_cod_gen varchar(3), -- codigo del genero
	@nuevo_gen varchar(50), -- nueva descripcion del genero
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Generos where fld_cod_gen = @fld_cod_gen and not(fld_desc_gen = @nuevo_gen))
			Begin
				Update Tbl_Generos
					set
						fld_desc_gen = @nuevo_gen
					where
						fld_cod_gen = @fld_cod_gen
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Generos where fld_cod_gen = @fld_cod_gen and fld_desc_gen = @nuevo_gen)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End


