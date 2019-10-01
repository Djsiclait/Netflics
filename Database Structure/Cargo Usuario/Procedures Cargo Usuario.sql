Create Proc USP_INS_CAR_USU
	@fld_cod_car varchar(3), -- codigo del cargo del empleado
	@fld_desc_car varchar(30), -- descripcion del cargo del empleado
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Cargo_Usuario where fld_cod_car = @fld_cod_car)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Cargo_Usuario where fld_desc_car = @fld_desc_car)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				Insert Into Tbl_Cargo_Usuario
				(
					fld_cod_car,
					fld_desc_car
				)
				values
				(
					@fld_cod_car,
					@fld_desc_car
				)
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
	End

Create Proc USP_MOD_CAR_USU
	@fld_cod_car varchar(3), -- codigo del cargo del empleado
	@nuevo_car varchar(30), -- nueva descripcion del cargo del empleado
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Cargo_Usuario where fld_cod_car = @fld_cod_car and not(fld_desc_car = @nuevo_car))
			Begin
				Update Tbl_Cargo_Usuario
					set
						fld_desc_car = @nuevo_car
					where
						fld_cod_car = @fld_cod_car
			
				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Cargo_Usuario where fld_cod_car = @fld_cod_car and fld_desc_car = @nuevo_car)
			Begin
				set @message = 'Descripcion Invalida'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End







