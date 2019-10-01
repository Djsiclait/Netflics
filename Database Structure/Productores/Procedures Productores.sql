Create Proc USP_INS_PRO
	@fld_cod_pro varchar(5), -- codigo de productor
	@fld_desc_pro varchar(100), -- descripcion de Productores
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Productores where fld_cod_pro = @fld_cod_pro)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Productores where fld_desc_pro = @fld_desc_pro)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				Insert Into Tbl_Productores
				(
					fld_cod_pro,
					fld_desc_pro
				)
				values
				(
					@fld_cod_pro,
					@fld_desc_pro
				)
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
	End

Create Proc USP_MOD_PRO
	@fld_cod_pro varchar(5), -- codigo de productor
	@nuevo_pro varchar(100), -- nueva descripcion de Productores
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Productores where fld_cod_pro = @fld_cod_pro and not(fld_desc_pro = @nuevo_pro))
			Begin
				Update Tbl_Productores
					set
						fld_desc_pro = @nuevo_pro
					where
						fld_cod_pro = @fld_cod_pro
			
				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Productores where fld_cod_pro = @fld_cod_pro and fld_desc_pro = @nuevo_pro)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End



