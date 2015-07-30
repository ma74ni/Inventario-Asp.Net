using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.Common;
using System.Data;

using ProyectoArquitecturaWeb.Comun;

namespace ProyectoArquitecturaWeb.Datos
{
    public class DatoArea
    {
        public DatoArea() { }


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
            int Id = 0;
            try
            {
                //ejecuta un bloque de manera segura
                using (DbConnection con = dpf.CreateConnection())
                {
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
                        Id = cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return Id;
        }

        public int InsertarArea(string NombreArea)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param = dpf.CreateParameter();
            param.Value = NombreArea;
            param.ParameterName = "NombreArea";
            parametros.Add(param);
            return ejecuteNonQuery("InsertarArea", parametros);
        }

        public int ActualizarArea(int IDArea, string NombreArea)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param = dpf.CreateParameter();
            param.Value = IDArea;
            param.ParameterName = "IDArea";
            parametros.Add(param);

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = NombreArea;
            param1.ParameterName = "NombreArea";
            parametros.Add(param1);



            return ejecuteNonQuery("ActualizarArea", parametros);

        }

        public int EliminarArea(int IDArea)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param = dpf.CreateParameter();
            param.Value = IDArea;
            param.ParameterName = "IDArea";
            parametros.Add(param);

            return ejecuteNonQuery("BorrarArea", parametros);
        }

        public List<Area> select_All_Area()
        {
            List<Area> ListaAreas = new List<Area>();

            string StoreProcedure = "ObtenerArea";
            using (DbConnection con = dpf.CreateConnection())
            {
                con.ConnectionString = constr;
                using (DbCommand cmd = dpf.CreateCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = StoreProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    //pasamos los datos leidos a la lista para llenarla
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ListaAreas.Add(
                                new Area((int)dr["IDArea"], (string)dr["NombreArea"])
                            );
                            Console.WriteLine("" + (string)dr["NombreArea"]);
                        }

                    }
                }

            }

            return ListaAreas;

        }


        public Area select_AutosbyId(int IDArea)
        {
            // Autos ObjAuto = new Autos();
            Area ObjArea = new Area();
            string StoredProcedure = "ObtenerAreaByID";

            using (DbConnection con = dpf.CreateConnection())
            {

                con.ConnectionString = constr;
                using (DbCommand cmd = dpf.CreateCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandText = StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    DbParameter param = cmd.CreateParameter();
                    param.DbType = DbType.Int32;
                    param.ParameterName = "IDArea";
                    param.Value = IDArea;
                    cmd.Parameters.Add(param);
                    con.Open();
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ObjArea = new Area(IDArea, (string)dr["NombreArea"]);

                        }

                    }
                }
            }
            return ObjArea;
        }
    }
}