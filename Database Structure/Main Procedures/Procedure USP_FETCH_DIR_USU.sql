Create Proc USP_FETCH_DIR_USU
	@usuario varchar(50)
	as
	Begin
		Select
			DIR.fld_cod_cli,
			TIP.fld_desc_tip,
			DIR.fld_dir_cli,
			DIR.fld_sec_dir,
			DIR.fld_ciu_dir
		from 
			Tbl_Direccion as DIR
		Inner Join Tbl_Tipo_Direccion as TIP on TIP.fld_cod_tip = DIR.fld_tip_dir
		where
			DIR.fld_cod_cli = @usuario
	End