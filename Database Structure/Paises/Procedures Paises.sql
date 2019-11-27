Create Proc USP_INS_PAI
	@fld_cod_pai varchar(3), -- codigo del pais
	@fld_desc_pai varchar(100), -- descripcion del pais 
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Paises where fld_cod_pai = @fld_cod_pai)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Paises where fld_desc_pai = @fld_desc_pai)
			Begin
				set @message = 'Descripcion Invalidad'
			End
		else
			Begin
				Insert Into Tbl_Paises
				(
					fld_cod_pai,
					fld_desc_pai
				)
				values
				(
					@fld_cod_pai,
					@fld_desc_pai
				)
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
	End

Create Proc INS_MOD_PAI
	@fld_cod_pai varchar(3), -- codigo del pais
	@nuevo_pai varchar(100), -- nueva descripcion del pais 
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Paises where fld_cod_pai = @fld_cod_pai and not(fld_desc_pai = @nuevo_pai))
			Begin
				Update Tbl_Paises
					set
						fld_desc_pai = @nuevo_pai
					where
						fld_cod_pai = @fld_cod_pai
			
				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Paises where fld_cod_pai = @fld_cod_pai and fld_desc_pai = @nuevo_pai)
			Begin
				set @message = 'Descripcion Invalidad'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End

