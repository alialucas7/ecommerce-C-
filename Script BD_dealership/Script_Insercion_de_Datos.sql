-----------------------------------------------------------------------------------------
------------------------------- TALLER DE PROGRAMACIÓN II ------------------------------- 
--------------------------- SISTEMA DE VENTAS "LIMITED EDITION" -------------------------
--- ALUMNOS: Alía, Lucas L.U: 53.181				Ortiz, Julio Sebastián: L.U: 52.072
-----------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------
------------------------------- INSERCIÓN DE DATOS -------------------------------------
-- Nombre de la Base de Datos: BD_dealership
-- Tablas: Marca, Modelo, País, Provincia, Localidad, Sucursal, Automovil
-- Rol, Permiso, Cliente, Usuario, Tipo_Factura 
-- Factura, Detalle_Factura	
-----------------------------------------------------------------------------------------

use BD_dealership


insert into Rol(descripcion) values ('Gerente General')
insert into Rol(descripcion) values ('Administrador')
insert into Rol(descripcion) values ('Empleado')


insert into Tipo_Factura(descripcion) values('A')
insert into Tipo_Factura(descripcion) values('B')
insert into Tipo_Factura(descripcion) values('C')


insert into Pais(descripcionPais) values('Argentina')
insert into Pais(descripcionPais) values('Uruguay')
insert into Pais(descripcionPais) values('Brasil')


insert into Provincia(id_provincia,id_pais,descripcionProv) values(2,1,'Corrientes')
insert into Provincia(id_provincia,id_pais,descripcionProv) values(3,1,'Chaco')
insert into Provincia(id_provincia,id_pais,descripcionProv) values(1,1,'Buenos Aires')
insert into Provincia(id_provincia,id_pais,descripcionProv) values(1,2,'Maldonado')
insert into Provincia(id_provincia,id_pais,descripcionProv) values(1,3,'Rio de Janeiro')


insert into Localidad(id_provincia,id_pais,descripcionLocality) values(2,1,'Empedrado')
insert into Localidad(id_provincia,id_pais,descripcionLocality) values(2,1,'Bella Vista')
insert into Localidad(id_provincia,id_pais,descripcionLocality) values(1,2,'Punta del Este')
insert into Localidad(id_provincia,id_pais,descripcionLocality) values(1,3,'Rio de Janeiro')


insert into Sucursal(id_localidad,id_provincia,id_pais,descripcionSucur)values(1,2,1,'Sucursal Central')
insert into Sucursal(id_localidad,id_provincia,id_pais,descripcionSucur)values(2,2,1,'Avenida los Citricultores 527')
insert into Sucursal(id_localidad,id_provincia,id_pais,descripcionSucur)values(3,1,2,'Bulevar General Artigas 2500')
insert into Sucursal(id_localidad,id_provincia,id_pais,descripcionSucur)values(4,1,3,'Calle Do Brigao')
insert into Sucursal(id_localidad,id_provincia,id_pais,descripcionSucur)values(4,1,3,'Joga Bonito')



Select * from Marca
insert into Marca(descripcionMarca) values ('Audi')
insert into Marca(descripcionMarca) values ('Nissan')
insert into Marca(descripcionMarca) values ('Tesla')
insert into Marca(descripcionMarca) values ('Porsche')
insert into Marca(descripcionMarca) values ('Lamborghini')
insert into Marca(descripcionMarca) values ('Kia')


insert into Modelo(id_marca,id_modelo,descripcionModelo) values (1,1,'E-tron')
insert into Modelo(id_marca,id_modelo,descripcionModelo) values (2,1,'LEAF')
insert into Modelo(id_marca,id_modelo,descripcionModelo) values (3,1,'Model 3')
insert into Modelo(id_marca,id_modelo,descripcionModelo) values (4,1,'Taycan 4S')
insert into Modelo(id_marca,id_modelo,descripcionModelo) values (4,2,'Taycan Turbo')
insert into Modelo(id_marca,id_modelo,descripcionModelo) values (5,1,'Terzo Millenio')
insert into Modelo(id_marca,id_modelo,descripcionModelo) values (6,1,' EV 6')



insert into Cliente(dni,nombre,apellido,email,telefono,estado) values ('38529090','Leonardo','Ríos','leonardo@gmail.com',3794256478,1);
insert into Cliente(dni,nombre,apellido,email,telefono,estado) values ('44761277','Gabriel','Goyeneche','EL_Bandido@hotmail.com',3794675411,1);
insert into Cliente(dni,nombre,apellido,email,telefono,estado) values ('17909012','Roxana','Fuelle','larossi@gmail.com',3782901630,1);
insert into Cliente(dni,nombre,apellido,email,telefono,estado) values ('21308810','Juan','Roman','mandiyu_passion@gmail.com',3794256478,1);
insert into Cliente(dni,nombre,apellido,email,telefono,estado) values ('28394533','Esteban','Quito','medicen_keki@yahoo.com',3782565604,1);
insert into Cliente(dni,nombre,apellido,email,telefono,estado) values ('29018913','Gilda','Romero','gildaForever<3@hotmail.com',3777410804,1);


insert into Usuario(id_rol,id_sucursal,dni,nombre,apellido,email,telefono,estado,pasword)values(1,1,36889588,'Jorge','Balmaceda','jorgitoPeto@gmail.com','3777876539',1,'789')
insert into Usuario(id_rol,id_sucursal,dni,nombre,apellido,email,telefono,estado,pasword)values(2,2,38590120,'Abelino','Florez','el-Guarani@gmail.com','3794557821',1,'789')
insert into Usuario(id_rol,id_sucursal,dni,nombre,apellido,email,telefono,estado,pasword)values(2,2,40983088,'Carlos','Monzon','caliteBX@yahoo.com','3777809042',1,'122')


select * from Automovil
insert into Automovil(id_marca,id_modelo,patente,precio,estado,n_puertas,color,año_fabricacion,descripcion)values
(4,2,'EE4LHG',1005000,1,4,'Blanco',2021,'Auto confortable de alta gama, estipo deportivo ideal para tirar facha:)')

insert into Automovil(id_marca,id_modelo,patente,precio,estado,n_puertas,color,año_fabricacion,descripcion)values
(5,1,'EQP38T',2000000,1,4,'Negro',2022,'Automobili Lamborghini mira al futuro con un enfoque visionario, llevando al extremo los valores que están en su ADN, y fija las exigencias del tercer milenio ')

insert into Automovil(id_marca,id_modelo,patente,precio,estado,n_puertas,color,año_fabricacion,descripcion)values
(6,1,'KK47HG',1000000,1,2,'Azul Electrico',2020,'Kia EV6 es un crossover 100 % eléctrico que pasa de 0 a 100 km/h en 5,2 segundos, con una impresionante velocidad máxima de 188 km/h. Espacioso e inspirador. ')

insert into Automovil(id_marca,id_modelo,patente,precio,estado,n_puertas,color,año_fabricacion,descripcion)values
(1,1,'HTTP98',1000000,1,4,'Blanco Perla',2021,'El Audi e-tron Sportback es una combinación de deportividad, funcionalidad e idoneidad para el uso diario. El interior ofrece mucho espacio y posibilidades, todo esto lo convierte en un vehiculo de alta gama. Permiso no, correte ')

insert into Automovil(id_marca,id_modelo,patente,precio,estado,n_puertas,color,año_fabricacion,descripcion)values
(2,1,'HAN847',500000,1,4,'Negro Mate',2021,'El Nissan LEAF está equipado con la mejor tecnología japonesa para conseguir la conducción eléctrica avanzada más segura, es una de las mejores opciones de gama media en el mercado ')

insert into Producto_Sucursal(id_sucursal,id_automovil,stock)values(2,1,20)
insert into Producto_Sucursal(id_sucursal,id_automovil,stock)values(2,2,20)
insert into Producto_Sucursal(id_sucursal,id_automovil,stock)values(2,5,15)

delete from Producto_Sucursal