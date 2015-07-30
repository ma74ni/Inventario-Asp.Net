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


create table Equipos(
IDEquipo int primary key not null identity(1,1),
Tipo varchar (20),
Marca varchar (20),
Modelo varchar (20),
Activo varchar (50),
Serial varchar (50),
Prestar char (1) check (Prestar in( 's','n')),
fecha_registro datetime default getdate(),
fecha_actualizacion datetime default getdate()
)

create procedure sp_InsertarEquipo (

@Tipo varchar (20),
@Marca varchar (20),
@Modelo varchar (20),
@Activo varchar (50),
@Serial varchar (50),
@Prestar char (1),
@fecha_registro datetime,
@fecha_actualizacion datetime

)
as
begin
Insert into Equipos values ( @Tipo,@Marca,@Modelo, @Activo, @Serial, @Prestar, @fecha_registro, @fecha_actualizacion);
end

execute InsertarEquipo computadoras, samsung,a, asdd, sasds1, s, '2015-07-29 20:50:35', '2015-07-29 20:50:35'
select * from Equipos;

create procedure sp_BorrarEquipo(
	@IDEquipo int 
)
as
	delete Equipos where IDEquipo = @IDEquipo
	
	
create procedure sp_ObtenerEquipo
as
select * from Equipos


create procedure  sp_ObtenerEquipoByID(
	@IDEquipo int 
)
as
	select * from Equipos where  IDEquipo = @IDEquipo


create procedure sp_ActualizarEquipo(
@IDEquipo int,
@Tipo varchar (20),
@Marca varchar (20),
@Modelo varchar (20),
@Activo varchar (50),
@Serial varchar (50),
@Prestar char (1) ,
@fecha_registro datetime,
@fecha_actualizacion datetime
)
as
	update Equipos set  Tipo=@Tipo,Marca=@Marca,Modelo=@Modelo,Activo=@Activo,Serial=@Serial,Prestar=@Prestar, fecha_registro=@fecha_registro, fecha_actualizacion=@fecha_actualizacion 			
	  where IDEquipo=@IDEquipo

