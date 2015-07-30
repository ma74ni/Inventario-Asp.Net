using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ProyectoArquitecturaWeb.Comun;
namespace ProyectoArquitecturaWeb.Presentacion
{
    public partial class master : System.Web.UI.MasterPage
    {
        static List<Usuario> listUsuario = new List<Usuario>(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            listUsuario = (List<Usuario>)(Session["usuario"]);
            if (listUsuario != null)
            {

            }
            else {
                Response.Redirect("login.aspx");
            }
        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Response.Redirect("login.aspx");
        }
    }
}