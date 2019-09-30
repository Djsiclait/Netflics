Create Proc USP_INS_SEX
 @fld_cod_sex varchar(1),
 @fld_desc_sex varchar(30),
 @message varchar(200) output
 as
 Begin
	if exists(select 1 from Tbl_Sexo where fld_cod_sex = @fld_cod_sex)
		Begin
			set @message = 'Codigo Invalido'
		End
	else if exists(select 1 from Tbl_Sexo where fld_desc_sex = @fld_desc_sex)
		Begin
			set @message = 'Descripcion Invalido'
		End
	else
		Begin
			Insert Into Tbl_Sexo
			(
				fld_cod_sex,
				fld_desc_sex
			)
			values
			(
				@fld_cod_sex,
				@fld_desc_sex
			)
			set @message = 'Los datos han sido actualizado correctamente.'
		End
 End

Create Proc USP_MOD_SEX
 @fld_cod_sex varchar(1),
 @nuevo_sex varchar(30),
 @message varchar(200) output
 as 
 Begin
	if exists(select 1 from Tbl_Sexo where fld_cod_sex = @fld_cod_sex and not(fld_desc_sex = @nuevo_sex))
		Begin
			Update Tbl_Sexo
				set
					fld_desc_sex = @nuevo_sex
				where
					fld_cod_sex = @fld_cod_sex

			set @message = 'Los datos han sido actualizado correctamente.'
		End
	else if exists(select 1 from Tbl_Sexo where fld_cod_sex = @fld_cod_sex and fld_desc_sex = @nuevo_sex)
		Begin
			set @message = 'Descripcion Invalido'
		End
	else
		Begin
			set @message = 'Codigo Invalido'
		End
 End

