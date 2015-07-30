create table Asignacion(
IDAsignacion int not null identity(1,1),
IDPersonal int,
IDEquipo int,
foreign key (IDPersonal) references Personal (IDPersonal),
Foreign Key (IDEquipo) references Equipos (IDEquipo),
fechaAsignacion date default getdate()
)

create procedure InsertarAsignacion (
@IDPersonal int,
@IDEquipo int
	
)
as
	Insert into Asignacion (IDPersonal, IDEquipo   ) values (@IDPersonal, @IDEquipo ) 
	
	
create procedure BorrarAsignacion(
	@IDAsignacion int 
)
as
	delete Asignacion where IDAsignacion = @IDAsignacion	
	
	
create procedure ObtenerAsignacion
as
select IDAsignacion,IDPersonal, IDEquipo  from Asignacion


create procedure  ObtenerAsigByID(
	@IDAsignacion int 
)
as
	select IDAsignacion,IDPersonal, IDEquipo   from Asignacion where IDAsignacion = @IDAsignacion


create procedure ActualizarAsig(
	@IDAsignacion int,
	@IDPersonal int,
	@IDEquipo int
)
as
	update Asignacion set IDPersonal = @IDPersonal, IDEquipo =@IDEquipo  where IDAsignacion = @IDAsignacion

