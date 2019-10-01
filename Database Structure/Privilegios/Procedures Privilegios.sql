Create Proc USP_INS_PRI
	@fld_cod_pri varchar(1), -- codigo del privilegio
	@fld_desc_pri varchar(30), -- descripcion del privilegio
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Privilegios where fld_cod_pri = @fld_cod_pri)
			Begin
				set @message = 'Codigo Valido'
			End
		else if exists(select 1 from Tbl_Privilegios where fld_desc_pri = @fld_desc_pri)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				Insert Into Tbl_Privilegios
				(
					fld_cod_pri,
					fld_desc_pri
				)
				values
				(
					@fld_cod_pri,
					@fld_desc_pri
				)
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
	End

Create Proc USP_MOD_PRI
	@fld_cod_pri varchar(1), -- codigo del privilegio
	@nuevo_pri varchar(30), -- descripcion del privilegio
	@message varchar(200) output
	as 
	Begin
		if exists(select 1 from Tbl_Privilegios where fld_cod_pri = @fld_cod_pri and not(fld_desc_pri = @nuevo_pri))
			Begin
				Update Tbl_Privilegios
					set
						fld_desc_pri = @nuevo_pri
					where
						fld_cod_pri = @fld_cod_pri
			
				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Privilegios where fld_cod_pri = @fld_cod_pri and fld_desc_pri = @nuevo_pri)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				set @message = 'Codigo Valido'
			End
	End



