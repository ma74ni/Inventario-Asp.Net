using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoArquitecturaWeb.Comun;
using ProyectoArquitecturaWeb.Datos;


namespace ProyectoArquitecturaWeb.Negocio
{
    public class NegocioPersonal
    {

        public NegocioPersonal()
        { 
        
        }

        //Insertar
        public int InsertarPersonal(string CIPersonal, string Nombre, string Apellido, string Telefono, string Email, int IDArea)
        {
            DatoPersonal datPersonal = new DatoPersonal();
            return datPersonal.InsertarPersonal(CIPersonal, Nombre, Apellido, Telefono, Email, IDArea);
        }

        //Update
        public int ActualizarPersonal(int IDPersonal, string CIPersonal, string Nombre, string Apellido, string Telefono, string Email, int IDArea)
        {
            DatoPersonal datPersonal = new DatoPersonal();
            return datPersonal.ActualizarPersonal(IDPersonal, CIPersonal, Nombre, Apellido, Telefono, Email, IDArea);
        }

        //desplegr todos
        public List<Personal> ObtenerPersonal() {
            DatoPersonal datPersonal = new DatoPersonal();
            return datPersonal.select_All_Personal();
        }

        //desplegar por id
        public Personal ObtenerPersonalById(int IDPersonal)
        {
            DatoPersonal datPersonal = new DatoPersonal();
            //dos formas de hacerlo
            //LINQ
            Personal aut = new Personal();
            aut = (from l in datPersonal.select_All_Personal()
                   where l.IDPersonal == IDPersonal
                   select l).FirstOrDefault();

            return aut;
            //por medio del procedimiento almacenado
            //return datAuto.select_AutosbyId(IDAuto);
        }

        //Eliminar
        public int BorrarPersonal(int IDPersonal)
        {
            DatoPersonal datpersonal = new DatoPersonal();
            return datpersonal.EliminarPersonal(IDPersonal);
        }

        
    }


}