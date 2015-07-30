using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ProyectoArquitecturaWeb.Comun;
using ProyectoArquitecturaWeb.Negocio;
namespace ProyectoArquitecturaWeb.Presentacion
{
    public partial class ActualizarEquipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["idproducto"] != null)
            {
                int idproducto = Convert.ToInt32(Request.QueryString["idproducto"]);
                NegocioComputadora negEquipo = new NegocioComputadora();
                TxtIDEquipo.Text = ""+negEquipo.MostrarPorId(idproducto).IDEquipo1;
                TxtTipo.Text = negEquipo.MostrarPorId(idproducto).Tipo1;
                TxtMarca.Text = negEquipo.MostrarPorId(idproducto).Marca1;
                TxtModelo.Text = negEquipo.MostrarPorId(idproducto).Modelo1;
                TxtCodigo.Text = negEquipo.MostrarPorId(idproducto).Activo1;
                TxtSerial.Text = negEquipo.MostrarPorId(idproducto).Serial1;
                TxtDisponible.Text = negEquipo.MostrarPorId(idproducto).Prestar1;
                TxtFechaRegistro.Text = ""+negEquipo.MostrarPorId(idproducto).Fecha_registro;
                TxtFechaActual.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            }
            else {
                Response.Redirect("primera.aspx");
            }
        }

        protected void ImgBtnRegistro_Click(object sender, ImageClickEventArgs e)
        {
            NegocioComputadora negEquipo = new NegocioComputadora();
            if (negEquipo.ActulaizarEquipo(int.Parse(TxtIDEquipo.Text), TxtTipo.Text, TxtMarca.Text, TxtModelo.Text, TxtCodigo.Text, TxtSerial.Text, TxtDisponible.Text, DateTime.Parse(TxtFechaRegistro.Text), DateTime.Parse(TxtFechaActual.Text)) > 0)
            {
                string script = @"<script type='text/javascript'>
                alert ('Equipo Modificado');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "AgenciaAutos1", script, false);
            }
        }
        private void clean() 
        {
            TxtIDEquipo.Text = null;
            TxtTipo.Text = null;
            TxtMarca.Text = null;
            TxtModelo.Text = null;
            TxtCodigo.Text = null;
            TxtSerial.Text = null;
            TxtDisponible.Text = null;
            TxtFechaRegistro.Text = null;
            TxtFechaActual.Text = null;

        }
    }
}