Create Table Tbl_Peliculas
(
	fld_cod_pel varchar(50) Not Null, -- codigo de la pelicula
	fld_nom_pel varchar(100) Default '', -- nombre de la pelicula
	--fld_img_pel varbinary Default '', -- imagen de la pelicula
	fld_gen_pel varchar(3) Default 'ACC', -- genero de la pelicula
	fld_dur_pel int Default 60, -- duracion de la pelicula en minutos 
	fld_fec_pub datetime Default '', -- fecha de publicacion de la pelicula
	fld_pro_pel varchar(5) Default 'FNHUS', -- productor de la pelicula
	fld_dir_pel varchar(100) Default '', -- director de la pelicula
	fld_act_pel varchar(200) Default '', -- actores principales de la pelicula,
	fld_rat_pel varchar(2) Default 'G', -- rating de la pelicula: general, adolecentes, adultos, etc.
	fld_idi_pel varchar(4) Default 'ENG1', -- idioma de la pelicula
	fld_pai_pel varchar(3) Default 'USA', -- pais de la pelicula
	fld_for_pel varchar(2) Default 'HD', -- formato de la pelicula
	Primary Key (fld_cod_pel)
)