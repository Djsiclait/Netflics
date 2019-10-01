Create Proc USP_INS_SUC
	@fld_cod_suc varchar(4), -- codigo de la sucursal
	@fld_nom_suc varchar(100), -- nombre del sucursal
	@fld_sup_suc varchar(50), -- nombre de usuario del supervisor de la sucursal
	@fld_dir_suc varchar(200), -- direccion de la sucursal
	@fld_sec_suc varchar(50), -- Sector de la sucursal
	@fld_ciu_suc varchar(50), -- ciudad de la sucursal 
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Sucursales where fld_cod_suc = @fld_cod_suc)
			Begin
				set @message = 'Codigo Invalido'
			End
		else if exists(select 1 from Tbl_Sucursales where fld_nom_suc = @fld_nom_suc)
			Begin
				set @message = 'Nombre Invalido'
			End
		else
			Begin
				Insert Into Tbl_Sucursales
				(
					fld_cod_suc,
					fld_nom_suc,
					fld_sup_suc,
					fld_dir_suc,
					fld_sec_suc,
					fld_ciu_suc
				)
				values
				(
					@fld_cod_suc,
					@fld_nom_suc,
					@fld_sup_suc,
					@fld_dir_suc,
					@fld_sec_suc,
					@fld_ciu_suc
				)
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
	End

Create Proc USP_MOD_NOM_SUC
	@fld_cod_suc varchar(4), -- codigo de la sucursal
	@nuevo_nom_suc varchar(100), -- nuevo nombre del sucursal
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Sucursales where fld_cod_suc = @fld_cod_suc and not(fld_nom_suc = @nuevo_nom_suc))
			Begin
				Update Tbl_Sucursales
					set
						fld_nom_suc = @nuevo_nom_suc
					where
						fld_cod_suc = @fld_cod_suc
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Sucursales where fld_cod_suc = @fld_cod_suc and fld_nom_suc = @nuevo_nom_suc)
			Begin
				set @message = 'Nombre Invalido'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End

Create Proc USP_MOD_SUP_SUC
	@fld_cod_suc varchar(4), -- codigo de la sucursal
	@nuevo_sup_suc varchar(50), -- nuevo nombre de usuario del supervisor de la sucursal
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Sucursales where fld_cod_suc = @fld_cod_suc and not(fld_sup_suc = @nuevo_sup_suc))
			Begin
				Update Tbl_Sucursales
					set
						fld_sup_suc = @nuevo_sup_suc
					where
						fld_cod_suc = @fld_cod_suc
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
		else if exists(select 1 from Tbl_Sucursales where fld_cod_suc = @fld_cod_suc and fld_sup_suc = @nuevo_sup_suc)
			Begin
				set @message = 'Nombre Invalido'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End

Create Proc USP_MOD_DIR_SUC
	@fld_cod_suc varchar(4), -- codigo de la sucursal
	@nuevo_dir_suc varchar(200), -- direccion de la sucursal
	@nuevo_sec_suc varchar(50), -- Sector de la sucursal
	@nuevo_ciu_suc varchar(50), -- ciudad de la sucursal 
	@message varchar(200) output
	as
	Begin
		if exists(select 1 from Tbl_Sucursales where fld_cod_suc = @fld_cod_suc)
			Begin
				Update Tbl_Sucursales
					set
						fld_dir_suc = @nuevo_dir_suc,
						fld_sec_suc = @nuevo_sec_suc,
						fld_ciu_suc = @nuevo_ciu_suc
					where
						fld_cod_suc = @fld_cod_suc
				
				set @message = 'Los datos han sido actualizado correctamente'
			End
		else
			Begin
				set @message = 'Codigo Invalido'
			End
	End
