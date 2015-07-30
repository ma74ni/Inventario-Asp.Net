using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoArquitecturaWeb.Comun
{
    public class Asignacion
    {
        public Asignacion() { }

        private int _IDAsignacion;

        public int IDAsignacion
        {
            get { return _IDAsignacion; }
            set { _IDAsignacion = value; }
        }
        private int _IDPersonal;

        public int IDPersonal
        {
            get { return _IDPersonal; }
            set { _IDPersonal = value; }
        }
        private int _IDEquipo;

        public int IDEquipo
        {
            get { return _IDEquipo; }
            set { _IDEquipo = value; }
        }

        public Asignacion(int IDAsignacion, int IDPersonal,int IDEquipo ) 
        {
            this.IDAsignacion = IDAsignacion;
            this.IDPersonal = IDPersonal;
            this.IDEquipo = IDEquipo;
        }
    }
}