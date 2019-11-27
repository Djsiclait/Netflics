Create Proc USP_INS_FOR_PAG
	@fld_cod_for varchar(3), -- codigo de forma de pago de salario
	@fld_desc_for varchar(30), -- descripcion de forma de pago de salario
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Forma_Pago where fld_cod_for = @fld_cod_for)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Forma_Pago where fld_desc_for = @fld_desc_for)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				Insert Into Tbl_Forma_Pago
				(
					fld_cod_for,
					fld_desc_for
				)
				values
				(
					@fld_cod_for,
					@fld_desc_for
				)

				set @message = 'Los datos han sido actualizado correctamente.'
			End
	End

Create Proc USP_MOD_FOR_PAG
	@fld_cod_for varchar(3), -- codigo de forma de pago de salario
	@nuevo_for varchar(30), -- nueva descripcion de forma de pago de salario
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Forma_Pago where fld_cod_for = @fld_cod_for and not(fld_desc_for = @nuevo_for))
			Begin
				Update Tbl_Forma_Pago
					set
						fld_desc_for = @nuevo_for
					where
						fld_cod_for = @fld_cod_for
			
				set @message = 'Los datos han sido actualizado correctamente.'
			End
		else if exists(select 1 from Tbl_Forma_Pago where fld_cod_for = @fld_cod_for and fld_desc_for = @nuevo_for)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End

