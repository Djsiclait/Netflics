Create Table Tbl_Factura
(
	fld_cod_fac varchar(50) Not Null, -- codigo de factura
	fld_tip_fac varchar(1) Default 'A', -- tipo de factura
	fld_rnc_fac varchar(100) Default '', -- RNC de la factura
	fld_cod_cli varchar(50) Not Null, -- codigo de membresia del cliente
	fld_fec_fac datetime Default '', -- fecha de la factura
	fld_tot_fac Decimal(19,2) Default 0, -- la suma del precio de alquiler de las peliculas sin impuestos
	fld_des_fac Decimal(19,2) Default 0, -- cualquier descuento/promocion que se le ceda al cliente segun entrega, menbresia, etc.
	fld_car_fac Decimal(19,2) Default 0, -- cualquier cargo que se aplica a la entrega de un alquiler
	fld_imp_fac Decimal(19,2) Default 0, -- impuestos sobre el total de la factura
	fld_mon_fac Decimal(19,2) Default 0, -- monto a pagar despues de impuestos y/o cargos y descuentos
	fld_for_fac varchar(1) Default 'E',  -- formato de pago de la factura, no se imprime en el recibo
	fld_cod_usu varchar(50) Not Null, -- nombre de usuario que atendio al cliente, no se imprema en el recibo
	Primary Key (fld_cod_fac)
)