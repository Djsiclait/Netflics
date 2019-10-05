Create Proc USP_INS_DIR_USU
	@usuario varchar(50),
	@direccion varchar(300),
	@desc_tipo_direccion varchar(30),
	@sector varchar(50),
	@ciudad varchar(50),
	@message varchar(200) output
	as 
	Begin
		Insert Into Tbl_Direccion
		(
			fld_cod_cli,
			fld_dir_cli,
			fld_tip_dir,
			fld_sec_dir,
			fld_ciu_dir
		)
		values
		(
			@usuario,
			@direccion,
			(Select fld_cod_tip from Tbl_Tipo_Direccion where fld_desc_tip = @desc_tipo_direccion),
			@sector,
			@ciudad
		)

		if exists(select 1 from Tbl_Direccion where fld_cod_cli = @usuario and fld_dir_cli = @direccion and fld_sec_dir = @sector and fld_ciu_dir = @ciudad)
			Begin
				set @message = 'EXITO'
			End
		else
			Begin
				set @message = 'ERROR'
			End
	End