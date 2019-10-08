Create Proc USP_FETCH_USU -- Store Procedure para extraer los datos necesarios para iniciar una sesion
	@usuario varchar(50) -- nombre de usuario que quiere conectarse 
	as
	Begin
		select
			USU.fld_cod_usu,
			USU.fld_doc_usu,
			DOC.fld_desc_tip,
			USU.fld_nom_usu,
			USU.fld_ape_usu,
			USU.fld_cor_usu,
			SEX.fld_desc_sex,
			USU.fld_fec_nac,
			NAC.fld_desc_nac,
			CAR.fld_desc_car,
			USU.fld_sal_usu,
			SAL.fld_desc_tip,
			ROL.fld_desc_rol,
			SUC.fld_nom_suc
		from 
			Tbl_Usuarios as USU
		Inner Join Tbl_Tipo_Documento as DOC on DOC.fld_cod_tip = USU.fld_tip_doc
		Inner Join Tbl_Sexo as SEX on SEX.fld_cod_sex = USU.fld_sex_usu
		Inner Join Tbl_Nacionalidad as NAC on NAC.fld_cod_nac = USU.fld_nac_usu
		Inner Join Tbl_Cargo_Usuario as CAR on CAR.fld_cod_car = USU.fld_car_usu
		Inner Join Tbl_Tipo_Salario as SAL on SAL.fld_cod_tip = USU.fld_for_pag
		Inner Join Tbl_Roles as ROL on ROL.fld_cod_rol = USU.fld_rol_usu
		Inner Join Tbl_Sucursales as SUC on SUC.fld_cod_suc = USU.fld_suc_usu
		where 
			fld_cod_usu = @usuario
	End

