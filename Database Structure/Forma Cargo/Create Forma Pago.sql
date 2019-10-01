Create Table Tbl_Forma_Pago
(
	fld_cod_for varchar(3) Not Null, -- codigo de forma de pago de salario
	fld_desc_for varchar(30) Default '', -- descripcion de forma de pago de salario
	Primary Key (fld_cod_for)
)