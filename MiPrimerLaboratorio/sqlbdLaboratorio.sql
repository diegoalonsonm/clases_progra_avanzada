create database progra_presencial

use progra_presencial

create table inventario(
	id int identity(1,1) not null,
	codigo_repuesto varchar(4) not null,
	nombre_repuesto varchar(20) not null,
	marca_repuesto varchar(20) not null,
	vehiculo varchar(20) not null,
	modelo varchar(20) not null,
	anio int not null,
	cantidad int not null,
	fecha_registro datetime not null,
	fecha_modificacion datetime,
	estado bit not null
);

select * from inventario