-----------------------------------------------------------------------------------------
------------------------------- TALLER DE PROGRAMACIÓN II ------------------------------- 
--------------------------- SISTEMA DE VENTAS "LIMITED EDITION" -------------------------
--- ALUMNOS: Alía, Lucas L.U: 53.181				Ortiz, Julio Sebastián: L.U: 52.072
-----------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------
------------------------------- Tablas de Entidades -------------------------------------
-- Nombre de la Base de Datos: BD_dealership
-- Tablas: Marca, Modelo, País, Provincia, Localidad, Sucursal, Automovil
-- Rol, Permiso, Cliente, Usuario, Tipo_Factura (Preguntar hay dos tablas de tipo factura),
-- Factura, Detalle_Factura	
-----------------------------------------------------------------------------------------

Create database BD_dealership
use BD_dealership

create table Marca(
id_marca integer IDENTITY(1,1) primary key,
descripcionMarca  varchar(20) not null)


create table Modelo(
id_marca integer,
id_modelo integer,
descripcionModelo  varchar(20) not null,
primary key(id_marca,id_modelo),
foreign key (id_marca) references Marca(id_marca)
)

create table Pais(
id_pais integer IDENTITY(1,1) primary key,
descripcionPais varchar(20) not null)

create table Provincia(
id_provincia integer,
id_pais integer,
descripcionProv varchar(20) not null,
foreign key (id_pais) references Pais(id_pais),
primary key (id_provincia,id_pais)
)

create table Localidad(
id_localidad integer not null identity(1,1),
id_provincia integer not null,
id_pais		 integer not null,
descripcionLocality varchar(35) not null,
foreign key (id_provincia,id_pais) references Provincia(id_provincia,id_pais),
primary key (id_localidad,id_provincia,id_pais)
)

create table Sucursal(
id_sucursal integer IDENTITY(1,1) primary key,
id_localidad integer,
id_provincia integer,
id_pais		 integer,
descripcionSucur varchar(35) not null,
foreign key (id_localidad,id_provincia,id_pais) references Localidad(id_localidad,id_provincia,id_pais)
)

create table Automovil(
id_automovil integer identity(1,1) primary key,
id_sucursal integer,
id_marca integer,
id_modelo integer,
patente varchar(20) unique not null,
precio float not null,
stock integer default 0,
estado bit not null,
fecha_registro datetime default getdate(),
n_puertas integer,
color varchar(20),
año_fabricacion datetime,
descripcion varchar(30),
foreign key (id_marca,id_modelo) references Modelo(id_marca,id_modelo),
foreign key (id_sucursal) references Sucursal(id_sucursal)
)

create table Tipo_Factura(
id_tipo int primary key,
descripcion varchar(20) 
)

create table Rol(
id_rol integer primary key identity(1,1),
descripcion varchar(30),
fecha_creacion datetime default getdate()
)

create table Usuario(
id_usuario integer primary key identity(1,1),
id_rol  integer references Rol(id_rol),
dni varchar(8) not null unique,
nombre varchar(30),
apellido varchar(20),
email varchar(45),
telefono varchar(12),
estado bit,
fecha_creacion datetime default getdate(),
pasword varchar(55)
)

create table Factura(
id_factura integer identity(1,1) primary key,
id_usuario integer references Usuario(id_usuario),
id_tipo int references Tipo_Factura(id_tipo),
dni_cliente varchar(8),
nombre_cliente varchar(40) null,
montopago decimal(10,2) null,
montocambio decimal(10,2) null,
monto_Total decimal(10,2),
fecha_creacion datetime default getdate(),
codigoFactura int null
)

create table Detalle_Factura(
id_detalle integer identity(1,1) primary key,
id_factura integer references Factura(id_factura),
id_automovil integer references Automovil(id_automovil),
precioVenta decimal(10,2) null,
subTotal decimal(10,2) null,
cantidad int,
fecha_registro datetime default getdate()
)

create table Cliente(
id_cliente integer primary key identity(1,1),
id_sucursal integer not null,
dni varchar(8) not null unique,
nombre varchar(30),
apellido varchar(20),
email varchar(45),
telefono varchar(12),
estado bit,
fecha_creacion datetime default getdate(),
foreign key (id_sucursal) references Sucursal (id_sucursal)
)
