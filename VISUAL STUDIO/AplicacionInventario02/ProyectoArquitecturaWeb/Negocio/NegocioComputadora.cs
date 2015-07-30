using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ProyectoArquitecturaWeb.Comun;
using ProyectoArquitecturaWeb.Datos;
namespace ProyectoArquitecturaWeb.Negocio
{
    public class NegocioComputadora
    {
       
        public NegocioComputadora() { 
        }
        //insertar
        public int RegistroEquipo(string Tipo, string Marca, string Modelo, string Activo, string Serial, string Prestar, DateTime fecha_registro, DateTime fecha_actualizacion)
        {
            DatoComputadoras datEquipo = new DatoComputadoras();
            return datEquipo.InsertarEquipo(Tipo, Marca, Modelo, Activo, Serial, Prestar, fecha_registro, fecha_actualizacion);
        }
        //Actualizar
        public int ActulaizarEquipo(int IDEquipo, string Tipo, string Marca, string Modelo, string Activo, string Serial, string Prestar, DateTime fecha_registro, DateTime fecha_actualizacion) 
        {
            DatoComputadoras datEquipo = new DatoComputadoras();
            return datEquipo.ActualizaEquipo(IDEquipo, Tipo, Marca, Modelo, Activo, Serial, Prestar, fecha_registro, fecha_actualizacion);
        }
        //Mostrar Todos
        public List<Computadoras> ObtenerEquipos() {
            DatoComputadoras datEquipo = new DatoComputadoras();
            return datEquipo.select_All_Equipos();
        }
        //Eliminar
        public int EliminarEquipo(int IDEquipo) {
            DatoComputadoras datEquipo = new DatoComputadoras();
            return datEquipo.EliminarEquipo(IDEquipo);
        }
        // Mostrar por Id
        public Computadoras MostrarPorId(int IDEquipo) {
            DatoComputadoras datEquipo = new DatoComputadoras();
            return datEquipo.select_EquiposbyId(IDEquipo);
        }
    }
}