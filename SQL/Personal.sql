create table Personal(
IDPersonal int primary key not null identity(1,1),
CIPersonal varchar (10),
Nombre varchar (20),
Apellido varchar (20),
Telefono varchar (20),
Email varchar (50),
foreign key (IDArea) references Area (IDArea)
)

create procedure InsertarPersonal(
@CIPersonal varchar (10),
@Nombre varchar (20),
@Apellido varchar (20),
@Telefono varchar (20),
@Email varchar (50),
@IDArea int 
)
as
	Insert into Personal(CIPersonal , Nombre,Apellido,Telefono,Email, IDArea) values (@CIPersonal , @Nombre,@Apellido,@Telefono,@Email, @IDArea)  
	
	
create procedure BorrarPersonal(
	@IDPersonal  int 
)
as
	delete Personal where IDPersonal  = @IDPersonal	
	
	
create procedure ObtenerPersonal
as
select IDPersonal, CIPersonal , Nombre,Apellido,Telefono,Email, IDArea from Personal


create procedure  ObtenerPersonalByID(
	@IDPersonal int 
)
as
	select IDPersonal, CIPersonal , Nombre,Apellido,Telefono,Email, IDArea from personal where IDPersonal = @IDPersonal

	
create procedure ActualizarPersonal(
@IDPersonal int, 
@CIPersonal varchar (10),
@Nombre varchar (20),
@Apellido varchar (20),
@Telefono varchar (20),
@Email varchar (50),
@IDArea int 

)
as
	update personal set CIPersonal = @CIPersonal, Nombre  = @Nombre ,
	Apellido = @Apellido, Telefono =@Telefono, Email  = @Email,IDArea=@IDArea  
	
	 where IDPersonal = @IDPersonal