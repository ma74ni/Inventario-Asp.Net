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
    public partial class Computadoras : System.Web.UI.Page
    {

        string fecha_actual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadGrid();

            }
            TextBox7.Text = fecha_actual;
        }
        private void loadGrid()
        {
            NegocioComputadora negEquipo = new NegocioComputadora();
            grvequipos.DataSource = negEquipo.ObtenerEquipos();
            grvequipos.DataBind();
        }
        private void clean()
        {
            TxtCodigo.Text = null;
            TxtTipo.Text = null;
            TxtSerial.Text = null;
            TxtModelo.Text = null;
            drlDisponible.Text = null;
            TxtMarca.Text = null;
        }

        protected void ImgBtnRegistro_Click(object sender, ImageClickEventArgs e)
        {
            NegocioComputadora negoEquipo = new NegocioComputadora();
            if (negoEquipo.RegistroEquipo(TxtTipo.Text, TxtMarca.Text, TxtModelo.Text, TxtCodigo.Text, TxtSerial.Text, drlDisponible.Text, DateTime.Parse(TextBox7.Text), DateTime.Parse(TextBox7.Text)) > 0)
            {
                loadGrid();
                clean();
                string script = @"<script type='text/javascript'>
                alert ('Equipo registrado');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ProyectoArquitecturaWeb", script, false);
                
            }
        }

        protected void grvequipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("ActualizarEquipo.aspx?idproducto="+grvequipos.Rows[grvequipos.SelectedIndex].Cells[0].Text);
        }
    }
}