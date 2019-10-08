Create Proc USP_FETCH_TEL_USU
	@usuario varchar(50)
	as 
	Begin
		Select 
			TEL.fld_cod_cli,
			TEl.fld_tel_cli,
			TIP.fld_desc_tip,
			EST.fld_desc_est
		from
			Tbl_Telefono as TEL
		Inner Join Tbl_Tipo_Telefono as TIP on TIP.fld_cod_tip = TEL.fld_tip_tel
		Inner Join Tbl_Estado_Telefono as EST on EST.fld_cod_est = TEL.fld_est_tel
		where
			TEL.fld_cod_cli = @usuario
	End