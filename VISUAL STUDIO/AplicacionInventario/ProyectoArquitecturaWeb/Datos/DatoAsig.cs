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
    public class DatoAsig
    {

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

        public int InsertarAsig( int IDPersonal, int IDEquipo)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param = dpf.CreateParameter();
            param.Value = IDPersonal;
            param.ParameterName = "IDPersonal";
            parametros.Add(param);

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = IDEquipo;
            param1.ParameterName = "IDEquipo";
            parametros.Add(param1);



            return ejecuteNonQuery("InsertarAsignacion", parametros);
        }

        public int ActualizarAsig(int IDAsignacion, int IDPersonal, int IDEquipo)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param = dpf.CreateParameter();
            param.Value = IDAsignacion;
            param.ParameterName = "IDAsignacion";
            parametros.Add(param);

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = IDPersonal;
            param1.ParameterName = "IDPersonal";
            parametros.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = IDEquipo;
            param2.ParameterName = "IDEquipo";
            parametros.Add(param2);



            return ejecuteNonQuery("ActualizarAsig", parametros);

        }

        public int EliminarAsig(int IDAsignacion)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param = dpf.CreateParameter();
            param.Value = IDAsignacion;
            param.ParameterName = "IDAsignacion";
            parametros.Add(param);

            return ejecuteNonQuery("BorrarAsignacion", parametros);
        }

        public List<Asignacion> select_All_Asig()
        {
            List<Asignacion> ListaAsig = new List<Asignacion>();

            string StoreProcedure = "ObtenerAsignacion";
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
                            ListaAsig.Add(
                                new Asignacion((int)dr["IDAsignacion"], (int)dr["IDPersonal"], (int)dr["IDEquipo"])
                            );
                            Console.WriteLine("" + (int)dr["IDPersonal"]);
                        }

                    }
                }

            }

            return ListaAsig;

        }


        public Asignacion select_AsigbyId(int IDAsignacion)
        {
            // Autos ObjAuto = new Autos();
            Asignacion ObjAsig = new Asignacion();
            string StoredProcedure = "ObtenerAsigByID";

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
                    param.ParameterName = "IDAsignacion";
                    param.Value = IDAsignacion;
                    cmd.Parameters.Add(param);
                    con.Open();
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ObjAsig = new Asignacion(IDAsignacion, (int)dr["IDPersonal"], (int)dr["IDEquipo"]);

                        }

                    }
                }
            }
            return ObjAsig;
        }

    }
}