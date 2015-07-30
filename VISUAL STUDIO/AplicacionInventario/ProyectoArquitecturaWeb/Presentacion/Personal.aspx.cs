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
    public partial class Personal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadGrid();
            loadDropList();
            drlpersonal.AutoPostBack = true;

        }

        private void loadGrid()
        {
            NegocioPersonal negAuto = new NegocioPersonal();
            grvpersonal.DataSource = negAuto.ObtenerPersonal();
            grvpersonal.DataBind();

        }

        private void loadDropList()
        {
            
        }

        private void clean()
        {
            txtcedula.Text = null;
            txtnombre.Text = null;
            txtapellido.Text = null;
            txttelefono.Text = null;
            txtemail.Text = null;
            txtarea.Text = null;

        }

     

        protected void btnalmacenar_Click(object sender, EventArgs e)
        {
            NegocioPersonal negPersonal = new NegocioPersonal();
            //si es mayor a cero registro
            // if (negAuto.AltaAuto(txtmarca.Text, decimal.Parse(txtprecio.Text)) > 0, txtvendido.Text)
            if (negPersonal.InsertarPersonal(txtcedula.Text,txtnombre.Text,txtapellido.Text,txttelefono.Text,txtemail.Text, int.Parse(txtarea.Text)) > 0)
            {
                //agregar referencia a System.Windows.Forms
                loadGrid();
                loadDropList();
                clean();
                string script = @"<script type='text/javascript'>
                alert ('Colaborador registrado');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ProyectoArquitecturaWeb", script, false);
                //MessageBox.Show("Auto Insertado");

            }
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(drlpersonal.SelectedValue);
            NegocioPersonal negauto = new NegocioPersonal();

            if (negauto.BorrarPersonal(id) > 0)
            {
                loadGrid();
                loadDropList();
                clean();
                string script = @"<script type='text/javascript'>
                alert ('Colaborador  Eliminado');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ProyectoArquitecturaWeb", script, false);
                //MessageBox.Show("Auto Eliminado");
            }

        }

        protected void btnmodificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(drlpersonal.SelectedValue);
            //int x = drlautos.SelectedIndex;
            //lblprecio.Text = Convert.ToString(drlautos.SelectedIndex);

            NegocioPersonal negAuto = new NegocioPersonal();



            if (negAuto.ActualizarPersonal(id, txtcedula.Text, txtnombre.Text, txtapellido.Text, txttelefono.Text, txtemail.Text, int.Parse(txtarea.Text)) > 0)
            {
                loadGrid();
                loadDropList();
                clean();
                string script = @"<script type='text/javascript'>
                alert ('Colaborador Modificado');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "AgenciaAutos1", script, false);
                //MessageBox.Show("Auto Modificado");
            }

        }

     

    
               
      

        
    }
}