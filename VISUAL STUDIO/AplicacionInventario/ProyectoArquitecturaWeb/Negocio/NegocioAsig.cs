using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ProyectoArquitecturaWeb.Comun;
using ProyectoArquitecturaWeb.Datos;

namespace ProyectoArquitecturaWeb.Negocio
{
    public class NegocioAsig
    {

        //Insertar
        public int InsertarAsig(int IDPersonal, int IDEquipo)
        {
            DatoAsig datAsig = new DatoAsig();
            return datAsig.InsertarAsig(IDPersonal, IDEquipo);
        }

        //Update
        public int ActualizarAsig(int IDAsignacion, int IDPersonal, int IDEquipo)
        {
            DatoAsig datAsig = new DatoAsig();
            return datAsig.ActualizarAsig(IDAsignacion, IDPersonal, IDEquipo);
        }

        //desplegr todos
        public List<Asignacion> ObtenerAsig()
        {
            DatoAsig datAuto = new DatoAsig();
            return datAuto.select_All_Asig();
        }

        //desplegar por id
        public Asignacion select_AsigbyId(int IDAsignacion)
        {
            DatoAsig datAuto = new DatoAsig();
            //dos formas de hacerlo
            //LINQ
            Asignacion aut = new Asignacion();
            aut = (from l in datAuto.select_All_Asig()
                   where l.IDAsignacion == IDAsignacion
                   select l).FirstOrDefault();

            return aut;
            //por medio del procedimiento almacenado
            //return datAuto.select_AutosbyId(IDAuto);
        }

        //Eliminar
        public int EliminarAsig(int IDAsignacion)
        {
            DatoAsig datAuto = new DatoAsig();
            return datAuto.EliminarAsig(IDAsignacion);
        }
    }
}