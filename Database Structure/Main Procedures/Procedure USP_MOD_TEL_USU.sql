Create Proc USP_MOD_TEL_USU
	@usuario varchar(50),
	@viejoNumero varchar(30),
	@nuevoNumero varchar(30),
	@tipo varchar(3),
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Telefono where fld_cod_cli = @usuario and fld_tel_cli = @viejoNumero)
			Begin
				if(@viejoNumero = @nuevoNumero)
					Begin
						update Tbl_Telefono
						set
							fld_tip_tel = @tipo
						where
							fld_cod_cli = @usuario and fld_tel_cli = @viejoNumero
					End
				else
					Begin
						update Tbl_Telefono
						set
							fld_tel_cli = @nuevoNumero,
							fld_tip_tel = @tipo
						where
							fld_cod_cli = @usuario and fld_tel_cli = @viejoNumero
					End
			End
		else
			Begin
				set @message = 'ERROR'
			End
	End