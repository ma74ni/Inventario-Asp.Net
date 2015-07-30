using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoArquitecturaWeb.Comun;
using ProyectoArquitecturaWeb.Datos;

namespace ProyectoArquitecturaWeb.Negocio
{
    public class NegocioArea
    {
        public NegocioArea(){}


        //Insertar
        public int InsertarArea(string NombreArea)
        {
            DatoArea datArea = new DatoArea();
            return datArea.InsertarArea(NombreArea);
        }

        //Update
        public int ActualizarArea(int IDArea, string NombreArea)
        {
            DatoArea datArea = new DatoArea();
            return datArea.ActualizarArea(IDArea, NombreArea);
        }

        //desplegr todos
        public List<Area> ObtenerArea()
        {
            DatoArea datArea = new DatoArea();
            return datArea.select_All_Area();
        }

        //desplegar por id
        public Area ObtenerAreaById(int IDArea)
        {
            DatoArea datArea = new DatoArea();
            //dos formas de hacerlo
            //LINQ
            Area aut = new Area();
            aut = (from l in datArea.select_All_Area()
                   where l.IDArea == IDArea
                   select l).FirstOrDefault();

            return aut;
            //por medio del procedimiento almacenado
            //return datAuto.select_AutosbyId(IDAuto);
        }

        //Eliminar
        public int BorrarArea(int IDArea)
        {
            DatoArea datAuto = new DatoArea();
            return datAuto.EliminarArea(IDArea);
        }

    }
}