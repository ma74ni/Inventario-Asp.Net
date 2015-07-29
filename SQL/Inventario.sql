create database Inventario
go

use Inventario
go

create table Usuario(
id_usuario int Primary key not null,
nombre_usuario varchar (100),
contrasenia varchar (35),
fecha_registro date,
ultimo_ingreso datetime default getdate(),
tipo_usuario char(1)
);

insert into Usuario values(1, 'admin', 'Password123', GETDATE(), default, 's');
insert into Usuario values(2, 'tecnologia', 'Password123', GETDATE(), default, 't');

Drop table Usuario;
select * from Usuario;

create procedure sp_login
@user varchar (100),
@pass varchar (35)
as
begin
select nombre_usuario from Usuario where @user = nombre_usuario and @pass = contrasenia;
update Usuario set ultimo_ingreso = getdate() where @user = nombre_usuario and @pass = contrasenia;
end;

execute sp_login admin, Password123;
