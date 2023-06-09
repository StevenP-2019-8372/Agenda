create database dbagelec
go
use dbagelec
go
create table clientes
(
id varchar(5),
Nombre varchar(50),
Apellido varchar(50),
Direccion varchar(200)
);
go
create proc sp_listar_clientes
as
select * from clientes order by id
go

create proc sp_buscar_clientes
@Nombre varchar(50)
as
select id,Nombre,Apellido,Direccion from clientes where Nombre like @Nombre + '%'
go

create proc sp_mantenimiento_clientes
@id varchar(5),
@Nombre varchar(50),
@Apellido varchar(50),
@Direccion varchar(200),
@accion varchar(50) output
as
if(@accion='1')
begin
	declare @idnuevo varchar(5), @idmax varchar(5)
	set @idmax=(select max (id) from clientes)
	set @idmax= isnull(@idmax,'A0000')
	set @idnuevo='A'+RIGHT(RIGHT(@idmax,4)+10001,4)
	insert into clientes(id,Nombre,Apellido,Direccion)
	values(@idnuevo,@Nombre,@Apellido,@Direccion)
	set @accion='Se genero el id: '+@idnuevo
end
else if(@accion='2')
begin
	update clientes set Nombre=@Nombre,Apellido=@Apellido,Direccion=@Direccion where id=@id
	set @accion='Se modifico el id'+@id
end
else if(@accion='3')
begin
	delete from clientes where id=@id
	set @accion='Se borro el id'+@id
end
go
