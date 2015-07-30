using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoArquitecturaWeb.Comun
{
    public class Area
    {
        public Area() { }

        private int _IDArea;

        public int IDArea
        {
            get { return _IDArea; }
            set { _IDArea = value; }
        }
        private string _NombreArea;

        public string NombreArea
        {
            get { return _NombreArea; }
            set { _NombreArea = value; }
        }

        public Area(int IDArea, string NombreArea) {
            this.IDArea = IDArea;
            this.NombreArea = NombreArea;        
        
        }

    }

    
}