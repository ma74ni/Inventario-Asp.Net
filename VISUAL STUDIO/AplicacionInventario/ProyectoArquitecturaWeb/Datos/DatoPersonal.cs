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
    public class DatoPersonal
    {
        public DatoPersonal()
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

        public int InsertarPersonal( string CIPersonal, string Nombre, string Apellido, string Telefono, string Email, int IDArea)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param = dpf.CreateParameter();
            param.Value = CIPersonal;
            param.ParameterName = "CIPersonal";
            parametros.Add(param);

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = Nombre;
            param1.ParameterName = "Nombre";
            parametros.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = Apellido;
            param2.ParameterName = "Apellido";
            parametros.Add(param2);

            DbParameter param3 = dpf.CreateParameter();
            param3.Value = Telefono;
            param3.ParameterName = "Telefono";
            parametros.Add(param3);

            DbParameter param4 = dpf.CreateParameter();
            param4.Value = Email;
            param4.ParameterName = "Email";
            parametros.Add(param4);

            DbParameter param5 = dpf.CreateParameter();
            param5.Value = IDArea;
            param5.ParameterName = "IDArea";
            parametros.Add(param5);



            return ejecuteNonQuery("InsertarPersonal", parametros);
        }

        public int ActualizarPersonal(int IDPersonal, string CIPersonal, string Nombre, string Apellido, string Telefono, string Email, int IDArea)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param0 = dpf.CreateParameter();
            param0.Value = IDPersonal;
            param0.ParameterName = "IDPersonal";
            parametros.Add(param0);

            DbParameter param = dpf.CreateParameter();
            param.Value = CIPersonal;
            param.ParameterName = "CIPersonal";
            parametros.Add(param);

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = Nombre;
            param1.ParameterName = "Nombre";
            parametros.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = Apellido;
            param2.ParameterName = "Apellido";
            parametros.Add(param2);

            DbParameter param3 = dpf.CreateParameter();
            param3.Value = Telefono;
            param3.ParameterName = "Telefono";
            parametros.Add(param3);

            DbParameter param4 = dpf.CreateParameter();
            param4.Value = Email;
            param4.ParameterName = "Email";
            parametros.Add(param4);

            DbParameter param5 = dpf.CreateParameter();
            param5.Value = IDArea;
            param5.ParameterName = "IDArea";
            parametros.Add(param5);

            return ejecuteNonQuery("ActualizarPersonal", parametros);

        }

        public int EliminarPersonal(int IDPersonal)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param0 = dpf.CreateParameter();
            param0.Value = IDPersonal;
            param0.ParameterName = "IDPersonal";
            parametros.Add(param0);

            return ejecuteNonQuery("BorrarPersonal", parametros);
        }

        public List<Personal> select_All_Personal()
        {
            List<Personal> ListaPersonal = new List<Personal>();

            string StoreProcedure = "ObtenerPersonal";
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
                            ListaPersonal.Add(
                                new Personal((int)dr["IDPersonal"], (string)dr["CIPersonal"], (string)dr["Nombre"], (string)dr["Apellido"],
                                   (string)dr["Telefono"], (string)dr["Email"], (int)dr["IDArea"])
                            );
                            Console.WriteLine("" + (string)dr["CIPersonal"]);
                        }

                    }
                }

            }

            return ListaPersonal;

        }

        public Personal select_AutosbyId(int IDPersonal)
        {
            // Autos ObjAuto = new Autos();
            Personal ObjAuto = new Personal();
            string StoredProcedure = "ObtenerPersonalByID";

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
                    param.ParameterName = "IDPersonal";
                    param.Value = IDPersonal;
                    cmd.Parameters.Add(param);
                    con.Open();
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ObjAuto = new Personal(IDPersonal, (string)dr["CIPersonal"], (string)dr["Nombre"], (string)dr["Apellido"]
                                , (string)dr["Telefono"], (string)dr["Email"], (int)dr["IDArea"]);

                        }

                    }
                }
            }
            return ObjAuto;
        }


       
    }
}