Create Proc USP_INS_TEL_USU
	@usuario varchar(50),
	@numbero_telefono varchar(30),
	@desc_tipo_telefono varchar(30),
	@messge varchar(200) output
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
			@numbero_telefono,
			(select TIP.fld_cod_tip from Tbl_Tipo_Telefono as TIP where TIP.fld_desc_tip = @desc_tipo_telefono)
		)

		if exists(select 1 from Tbl_Telefono where fld_cod_cli = @usuario and fld_tel_cli = @numbero_telefono)
			Begin
				set @messge = 'EXITO'
			End
		else
			Begin
				set @messge = 'ERROR'
			End
	End