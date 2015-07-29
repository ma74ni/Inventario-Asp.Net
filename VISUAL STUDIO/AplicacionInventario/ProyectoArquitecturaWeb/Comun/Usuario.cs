using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoArquitecturaWeb.Comun
{
    public class Usuario
    {
        public Usuario() { }

        private String _User;

        public String User
        {
            get { return _User; }
            set { _User = value; }
        }
        private String _Pass;

        public String Pass
        {
            get { return _Pass; }
            set { _Pass = value; }
        }

        public Usuario(string User) {
            this._User = User;
            //this._Pass = Pass;
        }
    }
}