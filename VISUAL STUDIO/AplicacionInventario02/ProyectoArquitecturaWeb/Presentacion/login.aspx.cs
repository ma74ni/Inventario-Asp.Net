using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ProyectoArquitecturaWeb.Negocio;
using ProyectoArquitecturaWeb.Comun;

namespace ProyectoArquitecturaWeb.Presentacion
{
    public partial class login : System.Web.UI.Page
    {
        static List<Usuario> listUsuario = new List<Usuario>(); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            String user = TxtUsuario.Text;
            String pass = TxtContrasena.Text;
            Acceso1 log = new Acceso1();
            if (log.estaLogeado(user, pass) == 1)
            {
                Session.Add("usuario", listUsuario);
                Server.Transfer("Computadoras.aspx");
            }
            else {
                lblErrorLogin.Text="El Usuario y Contraseña que ingresó no coinciden, favor ingresarlos nuevamente";
            }
            
        }
    }
}