Create Proc USP_INS_FOR_PEL
	@fld_cod_for varchar(2), -- codigo del formato de la pelicula,
	@fld_desc_for varchar(50), -- descripcion del formato de la pelicula 
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Formato_Pelicula where fld_cod_for = @fld_cod_for)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Formato_Pelicula where fld_desc_for = @fld_desc_for)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else 
			Begin
				Insert Into Tbl_Formato_Pelicula
				(
					fld_cod_for,
					fld_desc_for
				)
				values
				(
					@fld_cod_for,
					@fld_desc_for
				)
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
	End

Create Proc USP_MOD_FOR_PEL
	@fld_cod_for varchar(2), -- codigo del formato de la pelicula,
	@nuevo_for varchar(50), -- nueva descripcion del formato de la pelicula 
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Formato_Pelicula where fld_cod_for = @fld_cod_for and not(fld_desc_for = @nuevo_for))
			Begin
				Update Tbl_Formato_Pelicula
					set
						fld_desc_for = @nuevo_for
					where
						fld_cod_for = @fld_cod_for 

				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Formato_Pelicula where fld_cod_for = @fld_cod_for and fld_desc_for = @nuevo_for)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End

