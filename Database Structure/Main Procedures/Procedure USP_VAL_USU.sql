Create Proc USP_VAL_USU -- procedure para validar un nuevo nombre de usuario 
	@usuario varchar(50),
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Usuarios where fld_cod_usu = @usuario)
			Begin
				set @message = 'No Disponible'
			End
		else
			Begin
				set @message = 'Disponible'
			End
	End