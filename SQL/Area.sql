create table Area(
IDArea int primary key not null identity(1,1),
NombreArea varchar (50)
)


create procedure InsertarArea (
	@NombreArea varchar (50)
)
as
	Insert into Area (NombreArea ) values (@NombreArea  ) 
	
	
create procedure BorrarArea(
	@IDArea int 
)
as
	delete Area where IDArea = @IDArea	
	
	
create procedure ObtenerArea
as
select IDArea, NombreArea  from Area


create procedure  ObtenerAreaByID(
	@IDArea int
)
as
	select IDArea, NombreArea  from Area where IDArea = @IDArea


create procedure ActualizarArea(
	@IDArea int,
	@NombreArea varchar (50)
	
)
as
	update Area set @NombreArea = NombreArea  where IDArea = @IDArea

