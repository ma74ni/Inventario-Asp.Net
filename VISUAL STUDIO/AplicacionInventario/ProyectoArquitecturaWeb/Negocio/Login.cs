using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ProyectoArquitecturaWeb.Comun;
using ProyectoArquitecturaWeb.Datos;
namespace ProyectoArquitecturaWeb.Negocio
{
    public class Login
    {
        public int estaLogeado(String usuario, String contrasena) {
            DatoUsuario datUsuario = new DatoUsuario();
            return datUsuario.Login(usuario, contrasena);
        }
    }

}