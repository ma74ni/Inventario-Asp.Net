create table Equipos(
IDEquipo int primary key not null identity(1,1),
Tipo varchar (20),
Marca varchar (20),
Modelo varchar (20),
Activo varchar (50),
Serial varchar (50),
Prestar char (1) check (Prestar in( 's','n')),
fecha_registro date default getdate(),
fecha_actualizacion date default getdate()
)

create procedure InsertarEquipo (

@Tipo varchar (20),
@Marca varchar (20),
@Modelo varchar (20),
@Activo varchar (50),
@Serial varchar (50),
@Prestar char (1) 
)
as
	Insert into Equipos ( Tipo,Marca, Modelo, Activo, Serial, Prestar ) values ( @Tipo,@Marca,@Modelo, @Activo, @Serial, @Prestar  ) 
	
	
create procedure BorrarEquipo(
	@IDEquipo int 
)
as
	delete Equipos where IDEquipo = @IDEquipo
	
	
create procedure ObtenerEquipo
as
select IDEquipo, Tipo,Marca, Modelo, Activo, Serial, Prestar,fecha_registro,fecha_actualizacion  from Equipos


create procedure  ObtenerAutoByID(
	@IDEquipo int 
)
as
	select IDEquipo, Tipo,Marca, Modelo, Activo, Serial, Prestar,fecha_registro,fecha_actualizacion  from Equipos where  IDEquipo = @ IDEquipo


create procedure ActualizarAuto(
@IDEquipo int,
@Tipo varchar (20),
@Marca varchar (20),
@Modelo varchar (20),
@Activo varchar (50),
@Serial varchar (50),
@Prestar char (1) ,

@fecha_actualizacion date
)
as
	update Equipos set  Tipo=@Tipo,Marca=@Marca,Modelo=@Modelo,Activo=@Activo,Serial=@Serial,Prestar=@Prestar
				fecha_actualizacion=@fecha_actualizacion 			
	  where IDEquipo=@IDEquipo

