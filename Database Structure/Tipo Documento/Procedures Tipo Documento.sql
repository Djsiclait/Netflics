Create Proc USP_INS_TIP_DOC
	@fld_cod_tip varchar(3),
	@fld_desc_tip varchar(50),
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Tipo_Documento where fld_cod_tip = @fld_cod_tip)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Tipo_Documento where fld_desc_tip = @fld_desc_tip)
			Begin
				set @message = 'Descripcion Invalido'
			End
		else
			Begin
				Insert Into Tbl_Tipo_Documento
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

Create Proc USP_MOD_TIP_DOC
	@fld_cod_tip varchar(3),
	@nuevo_desc varchar(50),
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Tipo_Documento where fld_cod_tip = @fld_cod_tip and not(fld_desc_tip = @nuevo_desc))
			Begin
				Update Tbl_Tipo_Documento
				set
					fld_desc_tip = @nuevo_desc
				where
					fld_cod_tip = @fld_cod_tip

				set @message = 'Los datos han sido actualizado correctamente'
			End 
		else if exists(select 1 from Tbl_Tipo_Documento where fld_cod_tip = @fld_cod_tip and fld_desc_tip = @nuevo_desc)
			Begin
				set @message = 'Descripcion Invalido' 
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End 
 




