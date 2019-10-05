Create Proc USP_INS_TEL_USU
	@usuario varchar(50),
	@numero_telefono varchar(30),
	@desc_tipo_telefono varchar(30),
	@message varchar(200) output
	as
	Begin
		Insert Into Tbl_Telefono
		(
			fld_cod_cli,
			fld_tel_cli,
			fld_tip_tel
		)
		values
		(
			@usuario,
			@numero_telefono,
			(select TIP.fld_cod_tip from Tbl_Tipo_Telefono as TIP where TIP.fld_desc_tip = @desc_tipo_telefono)
		)

		if exists(select 1 from Tbl_Telefono where fld_cod_cli = @usuario and fld_tel_cli = @numero_telefono)
			Begin
				set @message = 'EXITO'
			End
		else
			Begin
				set @message = 'ERROR'
			End
	End