using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.Common;
using System.Data;
using ProyectoArquitecturaWeb.Comun;
using System.Data.SqlClient;

namespace ProyectoArquitecturaWeb.Datos
{
    public class DatoUsuario
    {
        public DatoUsuario()
        {

        }
        public static string constr
        {
            get { return ConfigurationManager.ConnectionStrings["Conn"].ConnectionString; }
        }

        public static string Provider
        {
            get { return ConfigurationManager.ConnectionStrings["Conn"].ProviderName; }
        }

        public static DbProviderFactory dpf
        {
            get
            {
                return DbProviderFactories.GetFactory(Provider);
            }
        }

        //Para la ejecucion de los procedimientos almacenados 
        private static int ejecuteNonQuery(string StoredProcedure, List<DbParameter> parametros)
        {
            List<Usuario> usuario = new List<Usuario>();
            int Id = 0;
            try
            {
                //ejecuta un bloque de manera segura
                using (DbConnection con = dpf.CreateConnection())
                {
                    List<Usuario> listUsuario = new List<Usuario>();
                    con.ConnectionString = constr;
                    using (DbCommand cmd = dpf.CreateCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = StoredProcedure;
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        //va a agregar los elementos a la lista
                        foreach (DbParameter param in parametros)
                        {
                            cmd.Parameters.Add(param);
                        }
                        con.Open();
                        //Id = cmd.ExecuteNonQuery();
                        using (DbDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                               Id = 1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return Id;
        }

        public int Login(string usuario, string contrasena)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param = dpf.CreateParameter();
            param.ParameterName = "@user";
            param.Value = usuario;
            parametros.Add(param);

            DbParameter param1 = dpf.CreateParameter();
            param1.ParameterName = "@pass";
            param1.Value = contrasena;
            parametros.Add(param1);

            return ejecuteNonQuery("sp_login", parametros);
        }
    }
}