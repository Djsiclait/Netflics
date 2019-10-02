Create Proc USP_FETCH_USU -- Store Procedure para extraer los datos necesarios para iniciar una sesion
	@usuario varchar(50) -- nombre de usuario que quiere conectarse 
	as
	Begin
		select * from Tbl_Usuarios where fld_cod_usu = @usuario
	End

