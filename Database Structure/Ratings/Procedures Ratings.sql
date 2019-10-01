Create Proc USP_INS_RAT
	@fld_cod_rat varchar(2), -- codigo del rating
	@fld_desc_rat varchar(50), -- descripcion del rating 
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Ratings where fld_cod_rat = @fld_cod_rat)
			Begin
				set @message = 'Codigo Invalido'
			End 
		else if exists(select 1 from Tbl_Ratings where fld_desc_rat = @fld_desc_rat)
			Begin
				set @message = 'Descipcion Invalida'
			End
		else 
			Begin
				Insert Into Tbl_Ratings
				(
					fld_cod_rat,
					fld_desc_rat
				)
				values
				(
					@fld_cod_rat,
					@fld_desc_rat
				)
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
	End

Create Proc USP_MOD_RAT
	@fld_cod_rat varchar(2), -- codigo del rating
	@nuevo_rat varchar(50), -- nueva descripcion del rating 
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Ratings where fld_cod_rat = @fld_cod_rat and not(fld_desc_rat = @nuevo_rat))
			Begin
				Update Tbl_Ratings
					set
						fld_desc_rat = @nuevo_rat
					where
						fld_cod_rat = @fld_cod_rat
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Ratings where fld_cod_rat = @fld_cod_rat and fld_desc_rat = @nuevo_rat)
			Begin
				set @message = 'Descipcion Invalida'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End

