Create Proc USP_SEARCH_USU
	@categoria varchar(30), -- categoria por la cual se quiere buscar
	@buscado varchar(200) -- la expresion regular para buscar
	as
	Begin
		if @categoria = 'Cargo' -- busqueda por cargo de usuario
			Begin
				Select
					USU.fld_cod_usu, 
					USU.fld_nom_usu, 
					USU.fld_ape_usu, 
					USU.fld_cor_usu, 
					SEX.fld_desc_sex,
					CAR.fld_desc_car,
					ROL.fld_desc_rol,
					SUC.fld_nom_suc
				from Tbl_Usuarios as USU
					Inner Join Tbl_Sexo as SEX on SEX.fld_cod_sex = USU.fld_sex_usu
					Inner Join Tbl_Cargo_Usuario as CAR on CAR.fld_cod_car = USU.fld_car_usu
					Inner Join Tbl_Roles as ROL on ROL.fld_cod_rol = USU.fld_rol_usu
					Inner Join Tbl_Sucursales as SUC on SUC.fld_cod_suc = USU.fld_suc_usu
				where 
					USU.fld_car_usu like '%' + @buscado + '%' -- en caso que se busca por el codigo del cargo, eje: ADM
				or
					CAR.fld_desc_car like '%' + @buscado + '%' -- en caso que se busca por el nombre del cargo, eje: Administrador
					
			End

		if @categoria = 'Correo' -- busqueda por correo electronico de usuario
			Begin	
				Select 
					USU.fld_cod_usu, 
					USU.fld_nom_usu, 
					USU.fld_ape_usu, 
					USU.fld_cor_usu, 
					SEX.fld_desc_sex,
					CAR.fld_desc_car,
					ROL.fld_desc_rol,
					SUC.fld_nom_suc
				from Tbl_Usuarios as USU
					Inner Join Tbl_Sexo as SEX on SEX.fld_cod_sex = USU.fld_sex_usu
					Inner Join Tbl_Cargo_Usuario as CAR on CAR.fld_cod_car = USU.fld_car_usu
					Inner Join Tbl_Roles as ROL on ROL.fld_cod_rol = USU.fld_rol_usu
					Inner Join Tbl_Sucursales as SUC on SUC.fld_cod_suc = USU.fld_suc_usu
				where 
					USU.fld_cor_usu like '%' + @buscado + '%'
			End

		if @categoria = 'Nombre' -- busqueda poe nombre o apellido
			Begin
				Select
					USU.fld_cod_usu, 
					USU.fld_nom_usu, 
					USU.fld_ape_usu, 
					USU.fld_cor_usu, 
					SEX.fld_desc_sex,
					CAR.fld_desc_car,
					ROL.fld_desc_rol,
					SUC.fld_nom_suc
				from Tbl_Usuarios as USU
					Inner Join Tbl_Sexo as SEX on SEX.fld_cod_sex = USU.fld_sex_usu
					Inner Join Tbl_Cargo_Usuario as CAR on CAR.fld_cod_car = USU.fld_car_usu
					Inner Join Tbl_Roles as ROL on ROL.fld_cod_rol = USU.fld_rol_usu
					Inner Join Tbl_Sucursales as SUC on SUC.fld_cod_suc = USU.fld_suc_usu
				where 
					USU.fld_nom_usu like '%' + @buscado + '%' -- por nombre eje: Ariel
				or
					USU.fld_ape_usu  like '%' + @buscado + '%' -- por apellido eje: Rodriguez
				or 
					(USU.fld_nom_usu + ' ' + USU.fld_ape_usu) like '%' + @buscado + '%' -- por nombre completo eje: Ariel Rodriguez
			End

		if @categoria = 'Nombre de Usuario' -- busqueda por nombre de usuario
			Begin
				if exists(Select 1 from Tbl_Usuarios where fld_cod_usu = @buscado)
					Begin
						Select
							USU.fld_cod_usu, 
							USU.fld_nom_usu, 
							USU.fld_ape_usu, 
							USU.fld_cor_usu, 
							SEX.fld_desc_sex,
							CAR.fld_desc_car,
							ROL.fld_desc_rol,
							SUC.fld_nom_suc
						from Tbl_Usuarios as USU
							Inner Join Tbl_Sexo as SEX on SEX.fld_cod_sex = USU.fld_sex_usu
							Inner Join Tbl_Cargo_Usuario as CAR on CAR.fld_cod_car = USU.fld_car_usu
							Inner Join Tbl_Roles as ROL on ROL.fld_cod_rol = USU.fld_rol_usu
							Inner Join Tbl_Sucursales as SUC on SUC.fld_cod_suc = USU.fld_suc_usu
						where 
							USU.fld_cod_usu = @buscado -- si el usuario existe devolver solo sus datos
					End
				else
					Begin
						Select
							USU.fld_cod_usu, 
							USU.fld_nom_usu, 
							USU.fld_ape_usu, 
							USU.fld_cor_usu, 
							SEX.fld_desc_sex,
							CAR.fld_desc_car,
							ROL.fld_desc_rol,
							SUC.fld_nom_suc
						from Tbl_Usuarios as USU
							Inner Join Tbl_Sexo as SEX on SEX.fld_cod_sex = USU.fld_sex_usu
							Inner Join Tbl_Cargo_Usuario as CAR on CAR.fld_cod_car = USU.fld_car_usu
							Inner Join Tbl_Roles as ROL on ROL.fld_cod_rol = USU.fld_rol_usu
							Inner Join Tbl_Sucursales as SUC on SUC.fld_cod_suc = USU.fld_suc_usu
						where 
							USU.fld_cod_usu like '%' + @buscado + '%' -- si no existe devolver los datos de nombres de usuario que son similar
					End
			End

		if @categoria = 'Rol' -- busqueda por rol de usuario
			Begin
				Select
					USU.fld_cod_usu, 
					USU.fld_nom_usu, 
					USU.fld_ape_usu, 
					USU.fld_cor_usu, 
					SEX.fld_desc_sex,
					CAR.fld_desc_car,
					ROL.fld_desc_rol,
					SUC.fld_nom_suc
				From Tbl_Usuarios as USU
					Inner Join Tbl_Sexo as SEX on SEX.fld_cod_sex = USU.fld_sex_usu
					Inner Join Tbl_Cargo_Usuario as CAR on CAR.fld_cod_car = USU.fld_car_usu
					Inner Join Tbl_Roles as ROL on ROL.fld_cod_rol = USU.fld_rol_usu
					Inner Join Tbl_Sucursales as SUC on SUC.fld_cod_suc = USU.fld_suc_usu
				where
					USU.fld_rol_usu like '%' + @buscado + '%' -- en caso que se busca por el codigo del rol, eje: S
				or
					ROL.fld_desc_rol like '%' + @buscado + '%' -- en caso que se busca por el nombre del rol, eje: Super Admin
			End

		if @categoria = 'Sucursal'
			Begin
				Select
					USU.fld_cod_usu, 
					USU.fld_nom_usu, 
					USU.fld_ape_usu, 
					USU.fld_cor_usu, 
					SEX.fld_desc_sex,
					CAR.fld_desc_car,
					ROL.fld_desc_rol,
					SUC.fld_nom_suc
				From Tbl_Usuarios as USU
					Inner Join Tbl_Sexo as SEX on SEX.fld_cod_sex = USU.fld_sex_usu
					Inner Join Tbl_Cargo_Usuario as CAR on CAR.fld_cod_car = USU.fld_car_usu
					Inner Join Tbl_Roles as ROL on ROL.fld_cod_rol = USU.fld_rol_usu
					Inner Join Tbl_Sucursales as SUC on SUC.fld_cod_suc = USU.fld_suc_usu
				where
					USU.fld_suc_usu like '%' + @buscado + '%' -- en caso que se busca por el codigo de la sucursal, eje: MAIN
				or
					SUC.fld_nom_suc like '%' + @buscado + '%' -- en caso que se busca por el nombre de la sucursal, eje: Oficina Principal
			End

		if @categoria = 'Todos' -- buscar el registro entero sin filtrar
			Begin
				Select
					USU.fld_cod_usu, 
					USU.fld_nom_usu, 
					USU.fld_ape_usu, 
					USU.fld_cor_usu, 
					SEX.fld_desc_sex,
					CAR.fld_desc_car,
					ROL.fld_desc_rol,
					SUC.fld_nom_suc
				From Tbl_Usuarios as USU
					Inner Join Tbl_Sexo as SEX on SEX.fld_cod_sex = USU.fld_sex_usu
					Inner Join Tbl_Cargo_Usuario as CAR on CAR.fld_cod_car = USU.fld_car_usu
					Inner Join Tbl_Roles as ROL on ROL.fld_cod_rol = USU.fld_rol_usu
					Inner Join Tbl_Sucursales as SUC on SUC.fld_cod_suc = USU.fld_suc_usu
			End
	End

