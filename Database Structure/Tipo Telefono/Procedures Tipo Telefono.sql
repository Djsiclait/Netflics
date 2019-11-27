Create Proc USP_INS_TIP_TEL
	@fld_cod_tip varchar(3), -- codigo del tipo de telefono
	@fld_desc_tip varchar(30), -- descripcion del tipo de telefono
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Tipo_Telefono where fld_cod_tip = @fld_cod_tip)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Tipo_Telefono where fld_desc_tip = @fld_desc_tip)
			Begin
				set @message = 'Descripcion Invalidad'
			End
		else 
			Begin
				Insert Into Tbl_Tipo_Telefono
				(
					fld_cod_tip,
					fld_desc_tip
				)
				values
				(
					@fld_cod_tip,
					@fld_desc_tip
				)
				
				set @message = 'Los datos han sido actualizado correctamente.'
			End
	End

Create Proc USP_MOD_TIP_TEL
	@fld_cod_tip varchar(3), -- codigo del tipo de telefono
	@nuevo_tip varchar(30), -- nueva descripcion del tipo de telefono
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Tipo_Telefono where fld_cod_tip = @fld_cod_tip and not(fld_desc_tip = @nuevo_tip))
			Begin
				Update Tbl_Tipo_Telefono
					set
						fld_desc_tip = @nuevo_tip
					where
						fld_cod_tip = @fld_cod_tip
				
				set @message = 'Los datos han sido actualizado correctamente.'
			End
		else if exists(select 1 from Tbl_Tipo_Telefono where fld_cod_tip = @fld_cod_tip and fld_desc_tip = @nuevo_tip)
			Begin
				set @message = 'Descripcion Invalidad'
			End
		else 
			Begin
				set @message = 'Codigo Invalido'
			End
	End


