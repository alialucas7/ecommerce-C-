-----------------------------------------------------------------------------------------
------------------------------- TALLER DE PROGRAMACIÓN II ------------------------------- 
--------------------------- SISTEMA DE VENTAS "LIMITED EDITION" -------------------------
--- ALUMNOS: Alía, Lucas L.U: 53.181				Ortiz, Julio Sebastián: L.U: 52.072
-----------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------
------------------------------- INSERCIÓN DE DATOS -------------------------------------
-- Nombre de la Base de Datos: BD_dealership
-- Tablas: Marca, Modelo, País, Provincia, Localidad, Sucursal, Automovil
-- Rol, Permiso, Cliente, Usuario, Tipo_Factura (Preguntar hay dos tablas de tipo factura),
-- Factura, Detalle_Factura	
-----------------------------------------------------------------------------------------

use BD_dealership
select * from Cliente
insert into Cliente(id_sucursal,dni,nombre,apellido,email,telefono,estado) values (1,'38529090','Leonardo','Ríos','leonardo@gmail.com',3794256478,1);

select * from Usuario
insert into Usuario(id_rol,id_sucursal,dni,nombre,apellido,email,telefono,estado,pasword)values(1,1,36889588,'Jorge','Balmaceda','jorgitoPeto@gmail.com','3777876539',1,'789')

select * From Rol
insert into Rol(descripcion) values ('Gerente General')
insert into Rol(descripcion) values ('Administrador')
insert into Rol(descripcion) values ('Empleado')


select * from Tipo_Factura
insert into Tipo_Factura(descripcion) values('A')
insert into Tipo_Factura(descripcion) values('B')
insert into Tipo_Factura(descripcion) values('C')

select * from Pais
insert into Pais(descripcionPais) values('Argentina')
insert into Pais(descripcionPais) values('Uruguay')
insert into Pais(descripcionPais) values('Brasil')

select * from Provincia
insert into Provincia(id_provincia,id_pais,descripcionProv) values(2,1,'Corrientes')
insert into Provincia(id_provincia,id_pais,descripcionProv) values(3,1,'Chaco')
insert into Provincia(id_provincia,id_pais,descripcionProv) values(1,1,'Buenos Aires')
insert into Provincia(id_provincia,id_pais,descripcionProv) values(1,2,'Maldonado')
insert into Provincia(id_provincia,id_pais,descripcionProv) values(1,3,'Rio de Janeiro')

select * from Localidad
insert into Localidad(id_provincia,id_pais,descripcionLocality) values(2,1,'Empedrado')
insert into Localidad(id_provincia,id_pais,descripcionLocality) values(2,1,'Bella Vista')
insert into Localidad(id_provincia,id_pais,descripcionLocality) values(1,2,'Punta del Este')
insert into Localidad(id_provincia,id_pais,descripcionLocality) values(1,3,'Rio de Janeiro')

select * from Sucursal
insert into Sucursal(id_localidad,id_provincia,id_pais,descripcionSucur)values(1,2,1,'Sucursal Central')
insert into Sucursal(id_localidad,id_provincia,id_pais,descripcionSucur)values(2,2,1,'Avenida los Citricultores 527')
insert into Sucursal(id_localidad,id_provincia,id_pais,descripcionSucur)values(3,1,2,'Bulevar General Artigas 2500')
insert into Sucursal(id_localidad,id_provincia,id_pais,descripcionSucur)values(4,1,3,'Calle Do Brigao')


select s.id_sucursal,s.descripcionSucur,l.id_localidad, l.descripcionLocality ,p1.id_provincia, p1.descripcionProv,p2.id_pais, p2.descripcionPais from Sucursal s 
inner join Localidad l on s.id_localidad = l.id_localidad

inner join Provincia p1 on l.id_provincia = p1.id_provincia 
and						   l.id_pais=p1.id_pais
inner join Pais p2 on      l.id_pais= p2.id_pais





select * from Marca
insert into Marca(descripcionMarca) values ('Audi')
insert into Marca(descripcionMarca) values ('Nissan')
insert into Marca(descripcionMarca) values ('Tesla')
insert into Marca(descripcionMarca) values ('Porsche')

select * from Modelo
insert into Modelo(id_marca,id_modelo,descripcionModelo) values (1,1,'E-tron')
insert into Modelo(id_marca,id_modelo,descripcionModelo) values (2,1,'LEAF')
insert into Modelo(id_marca,id_modelo,descripcionModelo) values (3,1,'Model 3')
insert into Modelo(id_marca,id_modelo,descripcionModelo) values (4,1,'Taycan 4S')
insert into Modelo(id_marca,id_modelo,descripcionModelo) values (4,2,'Taycan Turbo')



Select m.id_marca, m.descripcionMarca, m1.id_modelo, m1.descripcionModelo from  Marca m
inner join Modelo m1 on m.id_marca = m1.id_marca





select * from Automovil
insert into Automovil(id_marca,id_modelo,patente,precio,estado,n_puertas,color,año_fabricacion,descripcion)values
(4,2,'EE4LHG',1005000,1,4,'Blanco',2021,'Auto confortable de alta gama, estipo deportivo ideal para tirar facha:)')



select a.id_automovil ,m2.id_marca,m2.descripcionMarca,m1.id_modelo,m1.descripcionModelo,a.patente,a.precio,a.estado,a.n_puertas,a.color,a.año_fabricacion,a.descripcion, a.fecha_registro from Automovil a
inner join Modelo m1 on m1.id_modelo = a.id_modelo
and				  m1.id_marca = a.id_marca
inner join Marca  m2 on m2.id_marca = a.id_marca

use BD_dealership
select * from Factura
select * from Detalle_Factura
select count(*) +1 from Factura



select f.id_factura,u.id_usuario,u.nombre, u.apellido,tp.id_tipo,tp.descripcion, f.dni_cliente,f.nombre_cliente, 
f.montopago,f.montocambio,f.monto_Total,f.codigoFactura,
convert (char(10),f.fecha_creacion,103)[fecha_creacion]
from Factura f
inner join Usuario u on u.id_usuario = f.id_usuario
inner join Tipo_Factura tp on tp.id_tipo = f.id_tipo
where f.codigoFactura = 32640001

select * from Factura
select * from Detalle_Factura


select m2.descripcionMarca,m1.descripcionModelo,df.precioVenta,df.subTotal,df.cantidad from Detalle_Factura df 
inner join Automovil a on a.id_automovil= df.id_automovil
inner join Modelo m1 on m1.id_modelo = a.id_modelo
and				  m1.id_marca = a.id_marca
inner join Marca  m2 on m2.id_marca = a.id_marca
where df.id_factura = 1

select m2.descripcion,m1.descripcionModelo,df.precioVenta,df.cantidad,df.subTotal from Detalle_Factura df
                    inner join Automovil a on a.id_automovil= df.id_automovil
                   inner join Modelo m1 on m1.id_modelo = a.id_modelo
               and				  m1.id_marca = a.id_marca
              inner join Marca  m2 on m2.id_marca = a.id_marca
                   where df.id_factura =1


select * from usuario
select * from Sucursal
select * from Automovil


select ps.id_automovil,s.id_sucursal, a.id_marca,m2.descripcionMarca,
a.id_modelo,m1.descripcionModelo,a.patente,ps.stock,a.precio, a.estado,
a.n_puertas,a.color,a.año_fabricacion,a.descripcion
from Producto_Sucursal ps
inner join Automovil a on ps.id_automovil = a.id_automovil
inner join Sucursal s on ps.id_sucursal = s.id_sucursal
inner join Modelo m1 on m1.id_modelo = a.id_modelo
               and				  m1.id_marca = a.id_marca
inner join Marca  m2 on m2.id_marca = a.id_marca
where s.id_sucursal = 4

insert into Producto_Sucursal(id_sucursal,id_automovil,stock)values(2,1,20)
insert into Producto_Sucursal(id_sucursal,id_automovil,stock)values(4,1,20)