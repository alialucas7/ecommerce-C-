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

select s.id_sucursal,s.descripcionSucur,l.id_localidad, l.descripcionLocality ,p1.id_provincia, p1.descripcionProv,p2.id_pais, p2.descripcionPais from Sucursal s 
inner join Localidad l on s.id_localidad = l.id_localidad

inner join Provincia p1 on l.id_provincia = p1.id_provincia 
and						   l.id_pais=p1.id_pais
inner join Pais p2 on      l.id_pais= p2.id_pais

----------------------------------------------------------------------------------------

Select m.id_marca, m.descripcionMarca, m1.id_modelo, m1.descripcionModelo from  Marca m
inner join Modelo m1 on m.id_marca = m1.id_marca
--------------------------------------------------------------------------------------------



select a.id_automovil ,m2.id_marca,m2.descripcionMarca,m1.id_modelo,m1.descripcionModelo,a.patente,a.precio,a.estado,a.n_puertas,a.color,a.año_fabricacion,a.descripcion, a.fecha_registro from Automovil a
inner join Modelo m1 on m1.id_modelo = a.id_modelo
and				  m1.id_marca = a.id_marca
inner join Marca  m2 on m2.id_marca = a.id_marca

-----------------------------------------------------------------------------------------


select f.id_factura,u.id_usuario,u.nombre, u.apellido,tp.id_tipo,tp.descripcion, f.dni_cliente,f.nombre_cliente, 
f.montopago,f.montocambio,f.monto_Total,f.codigoFactura,
convert (char(10),f.fecha_creacion,103)[fecha_creacion]
from Factura f
inner join Usuario u on u.id_usuario = f.id_usuario
inner join Tipo_Factura tp on tp.id_tipo = f.id_tipo
where f.codigoFactura = 32640001


---------------------------------------------------------------------------------------------------
select m2.descripcionMarca,m1.descripcionModelo,df.precioVenta,df.subTotal,df.cantidad from Detalle_Factura df 
inner join Automovil a on a.id_automovil= df.id_automovil
inner join Modelo m1 on m1.id_modelo = a.id_modelo
and				  m1.id_marca = a.id_marca
inner join Marca  m2 on m2.id_marca = a.id_marca
where df.id_factura = 1
------------------------------------------------------------------------------------------------------
























select
convert(char(10),f.fecha_creacion,103)[fecha_creacion],f.codigoFactura,f.monto_Total,u.nombre[Nombre_Usuario],u.apellido[Apellido_Usuario],
f.dni_cliente,f.nombre_cliente[nombre_cliente]from Factura f
inner join Usuario u on u.id_usuario = f.id_usuario
--inner join Detalle_Factura df on df.id_factura = f.id_factura
--inner join Automovil a on a.id_automovil = df.id_automovil
--inner join Modelo m on m.id_modelo = a.id_modelo
--and m.id_marca = a.id_marca
--inner join Marca m2 on m2.id_marca = a.id_marca
group by f.fecha_creacion,f.codigoFactura,f.monto_Total,u.nombre,u.apellido,
f.dni_cliente,f.nombre_cliente,m2.descripcionMarca, m.descripcionModelo,df.precioVenta,df.cantidad, df.subTotal


select
f.codigoFactura from Factura f
inner join Usuario u on u.id_usuario = f.id_usuario
inner join Detalle_Factura df on df.id_factura = f.id_factura
inner join Automovil a on a.id_automovil = df.id_automovil
inner join Modelo m on m.id_modelo = a.id_modelo
and m.id_marca = a.id_marca
inner join Marca m2 on m2.id_marca = a.id_marca
group by f.codigoFactura



select  m2.descripcionMarca [cantidad mas vendida], count(m2.descripcionMarca) from Detalle_Factura df
inner join Automovil a on a.id_automovil = df.id_automovil
inner join Modelo m on m.id_modelo = a.id_modelo
and m.id_marca = a.id_marca
inner join Marca m2 on m2.id_marca = a.id_marca
group by m2.descripcionMarca

