-----------------------------------------------------------------------------------------
------------------------------- TALLER DE PROGRAMACIÓN II ------------------------------- 
--------------------------- SISTEMA DE VENTAS "LIMITED EDITION" -------------------------
--- ALUMNOS: Alía, Lucas L.U: 53.181				Ortiz, Julio Sebastián: L.U: 52.072
-----------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------
------------------------------- PROCEDIMIENTOS ALMACENADOS -------------------------------------
-- Nombre de la Base de Datos: BD_dealership
-- Tablas: Marca, Modelo, País, Provincia, Localidad, Sucursal, Automovil
-- Rol, Permiso, Cliente, Usuario, Tipo_Factura (Preguntar hay dos tablas de tipo factura),
-- Factura, Detalle_Factura	
-----------------------------------------------------------------------------------------

use BD_dealership
select * from Usuario
--PROCEDIMIENTOS ALMACENADOS PARA EL USUARIO
--Registrar Usuario
create proc SP_RegistrarUsuario(

@idRol int,
@id_sucursal integer,
@dni varchar(8),
@nombre varchar(30),
@apellido varchar(30),
@email varchar(45),
@telefono varchar(12),
@estado bit,
@pasword varchar(55),
@idUsuarioResultado int output,
@Mensaje varchar(200) output
)
as
begin
	set @idUsuarioResultado = 0
	set @Mensaje =''
	if not exists(select * from Usuario where dni = @dni)
	begin
		insert into Usuario(id_rol,id_sucursal, dni,nombre,apellido,email,telefono,estado,pasword)
		values (@idRol,@id_sucursal,@dni,@nombre,@apellido,@email,@telefono,@estado,@pasword)
		set @idUsuarioResultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje ='No se puede repetir el campo DNI para mas de un usuario'
end
go

--Editar Usuario
create proc SP_EDITAR_Usuarioo(
@idUsuario int,
@idRol int,
@dni varchar(8),
@nombre varchar(30),
@apellido varchar(30),
@email varchar(45),
@telefono varchar(12),
@estado bit,
@pasword varchar(55),
@Respuesta int output,
@Mensaje varchar(200) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje =''

	if not exists(select * from Usuario where dni = @dni and id_usuario != @idUsuario)
	begin
		update Usuario set
		
		id_rol = @idRol,
		dni = @dni,
		nombre = @nombre,
		apellido= @apellido,
		email =@email,
		telefono=@telefono,
		estado=@estado,
		pasword=@pasword
		where id_usuario = @idUsuario

		set @Respuesta = 1
	end
	else
		set @Mensaje ='ya existe usuario con esos atributos'
end
go

--Eliminar Usuario
create proc SP_EliminarUsuario(
@idUsuario int,

@Respuesta int output,
@Mensaje varchar(200) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje =''
	declare @pasoreglas bit =1

	if  exists(select * from Factura f
	inner join Usuario u on u.id_usuario = f.id_usuario
	where u.id_usuario =  @idUsuario)
	begin 
		set @pasoreglas =0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usario esta asociado a una venta'
	end

	if (@pasoreglas = 1)
	begin
		delete from Usuario where id_usuario = @idUsuario
		set @Respuesta = 1
	end

	
end
go

--PROCEDIMIENTOS PARA CLIENTE
CREATE PROC sp_RegistrarCliente(

@dni varchar (50),
@nombre varchar (50),
@apellido varchar (50),
@email varchar (50),
@telefono varchar (50),
@estado bit,
@resultado int output,
@mensaje varchar (500) output
)as 
	begin 
		SET @resultado = 0
		DECLARE @idpersona int
	if not exists (select * from Cliente where dni = @dni)
		begin
			insert into Cliente (dni,nombre,apellido,email,telefono,estado) values (@dni,@nombre,@apellido,@email,@telefono,@estado)

			SET @resultado = SCOPE_IDENTITY()
		end
			else
				SET @mensaje = 'El Numero de Documento ya existe en La Base de Datos'
	end
go


CREATE PROC sp_ModificarCliente(
@id_cliente int,
 
@dni varchar (50),
@nombre varchar (50),
@apellido varchar (50),
@email varchar (50),
@telefono varchar (50),
@estado bit,
@resultado bit output,
@mensaje varchar (500) output
) as
	begin
		SET @resultado = 1
		DECLARE @idpersona int 
	if not exists (select * from Cliente where dni = @dni and id_cliente != @id_cliente)
		begin
			update Cliente set
			
			dni = @dni,
			nombre = @nombre,
			apellido = @apellido,
			email = @email,
			telefono = @telefono,
			estado = @estado
			where id_cliente = @id_cliente
		end
			else
		begin
			SET @resultado = 0 
			SET @mensaje = 'El Numero de Documento ya existe en La Base de Datos'
		end
	end

--PROCEDIMIENTOS PARA PRODUCTOS
create proc SP_RegistrarProductoo(


@id_modelo integer,
@id_marca integer,
@patente varchar(20),
@precio float,

@estado bit,

@n_puertas integer,
@color varchar(40),
@año_fabricacion varchar(5),
@descripcion varchar(600),

@resultado bit output,
@mensaje varchar(300) output
)
as
begin 
	set @resultado = 0
	if not exists (select * from Automovil where patente =@patente)
	begin
		insert into Automovil(id_modelo,id_marca,patente,precio,estado,n_puertas,color,año_fabricacion,descripcion)
		values ( @id_modelo,@id_marca,@patente,@precio,@estado,@n_puertas,@color,@año_fabricacion,@descripcion)
		set @resultado = scope_identity()
	end

	else 
	set @mensaje = 'Ya existe un auto con ese patente'
end
go

create proc SP_EditarProductoo(
@id_automovil integer,

@id_modelo integer,
@id_marca integer,
@patente varchar(20),
@precio float,

@estado bit,

@n_puertas integer,
@color varchar(40),
@año_fabricacion varchar(5),
@descripcion varchar(600),

@resultado bit output,
@mensaje varchar(300) output
)
as
begin
	set @resultado = 1
	if not exists (select * from Automovil where patente = @patente and id_automovil != @id_automovil)
	update Automovil set
	
	
	id_modelo = @id_modelo,
	id_marca = @id_marca,
	patente = @patente,
	precio =@precio,
	
	estado = @estado,
	n_puertas =@n_puertas,
	color = @color,
	año_fabricacion = @año_fabricacion,
	descripcion =@descripcion
	where id_automovil = @id_automovil
	else
	begin 
	set @resultado = 0
	set @mensaje = 'Ya existe automovil con el mismo patente'
	end
end
go	

create proc SP_Eliminar_Producto(
@id_automovil integer,
@Respuesta bit output,
@Mensaje varchar(200) output
)
as
begin
	set @Respuesta =0
	set @Mensaje = ''
	declare @pasoreglas bit = 1


	if  exists (select* from Detalle_Factura d 
	inner join Automovil a on a.id_automovil = d.id_automovil
	where a.id_automovil = @id_automovil)
	begin 
	set @pasoreglas = 0
	set @Respuesta = 0
	set @Mensaje = @Mensaje + 'No se puede eliminar porque esta relacionado con una compra'
	end

	if (@pasoreglas = 1)
	begin
	delete from Automovil where id_automovil = @id_automovil
	set @Respuesta = 1
	end 

	end

/*Procedimientos almacenados para la parte de ventas*/
create type [dbo].[EDetalleVenta] as table(
[id_automovil] int null,
[precioVenta] decimal(18,2) null,
[subTotal] decimal(18,2) null,
[cantidad] int null
)

--PROCEDIMIENTOS PARA VENTAS
create procedure usp_RegistrarVentAAx(
@idUsser int,
@tipoFactura int,
@dni varchar(8),
@nameCliente varchar(250),
@montoPago decimal(18,2),
@montoCambio decimal(18,2),
@monto_Total decimal(18,2),
@detalleVenta [EDetalleVenta] readonly,
@codigoFactura int,
@resultado bit output,
@mensaje varchar(500) output
)
as
begin
	begin try
		declare @idFactura int =0
		set @resultado = 1
		set @mensaje =''

		begin transaction registro

		/*Se inserta primero la entidad Factura*/
		insert into Factura(id_usuario,id_tipo,dni_cliente,nombre_cliente,montopago,montocambio,monto_Total,codigoFactura)
		values(@idUsser,@tipoFactura,@dni,@nameCliente,@montoPago,@montoCambio,@monto_Total,@codigoFactura)

		set @idFactura = SCOPE_IDENTITY()
		select * from Detalle_Factura
		/*Se inserta luego la entidad Detalle de Factura*/
		insert into Detalle_Factura(id_factura,id_automovil,precioVenta,cantidad,subTotal)
		select @idFactura, id_automovil,precioVenta,cantidad,subTotal from @detalleVenta

		commit transaction registro

	end try
	begin catch
		set @resultado =0
		set @mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch	
end




-- Procedimiento almacenado para Administrador_Sucursal --
create procedure usp_BajitaSucursal(
@id_sucursal int,
@id_automovil int,

@resultado bit output,
@mensaje varchar(500) output
)
as
begin 
		begin try
		set @resultado =1
		set @mensaje = ''
		delete from Producto_Sucursal where id_sucursal =@id_sucursal  and id_automovil= @id_automovil
		end try

		begin catch
		set @mensaje = ERROR_MESSAGE()
		set @resultado =0
		end catch
end




create procedure usp_AltaProductoSucursaaal(
@id_sucursal int,
@id_automovil int,
@stock int,
@resultado bit output,
@mensaje varchar(500) output
)
as
begin 
		
		set @resultado =1
		set @mensaje = ''
		if  exists (select ps.id_sucursal, ps.id_automovil from Producto_Sucursal ps
		inner join Sucursal s on s.id_sucursal = ps.id_sucursal
		inner join Automovil a on a.id_automovil = ps.id_automovil
		where ps.id_sucursal = @id_sucursal and ps.id_automovil = @id_automovil
		)
		begin
		set @mensaje = 'Ya esta cargado este producto'
		set @resultado = 0
		end
		else
		begin
		insert into Producto_Sucursal(id_sucursal,id_automovil,stock)values(@id_sucursal,@id_automovil,@stock)
		end 

end
