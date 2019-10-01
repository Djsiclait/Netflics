Create Table Tbl_Ratings
(
	fld_cod_rat varchar(2) Not Null, -- codigo del rating
	fld_desc_rat varchar(50) Default '', -- descripcion del rating 
	Primary Key (fld_cod_rat)
)