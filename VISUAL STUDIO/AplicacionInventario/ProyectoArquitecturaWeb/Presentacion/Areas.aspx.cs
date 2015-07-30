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
    public partial class Areas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                loadGrid();
                loadDropList();
                drlarea.AutoPostBack = true;

            }

        }

        private void loadGrid()
        {
            NegocioArea negAuto = new NegocioArea();
            grvarea.DataSource = negAuto.ObtenerArea();
            grvarea.DataBind();

        }

        private void loadDropList()
        {
            NegocioArea negAuto = new NegocioArea();
            drlarea.DataSource = negAuto.ObtenerArea();
            drlarea.DataValueField = "IDArea";
            drlarea.DataTextField = "NombreArea";
            drlarea.DataBind();
        }


        private void clean()
        {
            txtarea.Text = null;
            
        }
        protected void drlarea_TextChanged(object sender, EventArgs e)
        {
            NegocioArea negArea = new NegocioArea ();
            Area area = negArea.ObtenerAreaById(Convert.ToInt16(drlarea.SelectedValue));
            txtarea.Text = Convert.ToString(area.IDArea);
        }

        protected void btnalmacenar_Click(object sender, EventArgs e)
        {
            NegocioArea negArea = new NegocioArea();

            if (negArea.InsertarArea(txtarea.Text) > 0)
            {
                //agregar referencia a System.Windows.Forms
                loadGrid();
                loadDropList();
                clean();
                string script = @"<script type='text/javascript'>
                alert ('Area registrada');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ProyectoArquitecturaWeb", script, false);
                //MessageBox.Show("Auto Insertado");

            }

        }

        protected void btnmodificar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt16(drlarea.SelectedValue);
            //int x = drlautos.SelectedIndex;
            //lblprecio.Text = Convert.ToString(drlautos.SelectedIndex);

            NegocioArea negAuto = new NegocioArea();



            if (negAuto.ActualizarArea(id, txtarea.Text) > 0)
            {
                loadGrid();
                loadDropList();
                clean();
                string script = @"<script type='text/javascript'>
                alert ('Area Modificada');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ProyectoArquitecturaWeb", script, false);
                //MessageBox.Show("Auto Modificado");
            }

        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt16(drlarea.SelectedValue);
            NegocioArea negauto = new NegocioArea();

            if (negauto.BorrarArea(id) > 0)
            {
                loadGrid();
                loadDropList();
                clean();
                string script = @"<script type='text/javascript'>
                alert ('Area Eliminada');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ProyectoArquitecturaWeb", script, false);
                //MessageBox.Show("Auto Eliminado");
            }

        }
    }
}