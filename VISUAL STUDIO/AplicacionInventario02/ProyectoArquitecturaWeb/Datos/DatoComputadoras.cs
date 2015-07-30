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
    public class DatoComputadoras
    {
        public DatoComputadoras() { }

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

        public int InsertarEquipo(string Tipo, string Marca, string Modelo, string Activo, string Serial, string Prestar, DateTime fecha_registro, DateTime fecha_actualizacion)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param = dpf.CreateParameter();
            param.Value = Tipo;
            param.ParameterName = "@Tipo";
            parametros.Add(param);

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = Marca;
            param1.ParameterName = "@Marca";
            parametros.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = Modelo;
            param2.ParameterName = "@Modelo";
            parametros.Add(param2);

            DbParameter param3 = dpf.CreateParameter();
            param3.Value = Activo;
            param3.ParameterName = "@Activo";
            parametros.Add(param3);

            DbParameter param4 = dpf.CreateParameter();
            param4.Value = Serial;
            param4.ParameterName = "@Serial";
            parametros.Add(param4);

            DbParameter param5 = dpf.CreateParameter();
            param5.Value = Prestar;
            param5.ParameterName = "@Prestar";
            parametros.Add(param5);

            DbParameter param6 = dpf.CreateParameter();
            param6.Value = fecha_registro;
            param6.ParameterName = "@fecha_registro";
            parametros.Add(param6);

            DbParameter param7 = dpf.CreateParameter();
            param7.Value = fecha_registro;
            param7.ParameterName = "@fecha_actualizacion";
            parametros.Add(param7);



            return ejecuteNonQuery("sp_InsertarEquipo", parametros);
        }

        public int ActualizaEquipo(int IDEquipo, string Tipo, string Marca, string Modelo, string Activo, string Serial, string Prestar, DateTime fecha_registro, DateTime fecha_actualizacion)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param0 = dpf.CreateParameter();
            param0.Value = IDEquipo;
            param0.ParameterName = "@IDEquipo";
            parametros.Add(param0);
            
            DbParameter param = dpf.CreateParameter();
            param.Value = Tipo;
            param.ParameterName = "@Tipo";
            parametros.Add(param);

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = Marca;
            param1.ParameterName = "@Marca";
            parametros.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = Modelo;
            param2.ParameterName = "@Modelo";
            parametros.Add(param2);

            DbParameter param3 = dpf.CreateParameter();
            param3.Value = Activo;
            param3.ParameterName = "@Activo";
            parametros.Add(param3);

            DbParameter param4 = dpf.CreateParameter();
            param4.Value = Serial;
            param4.ParameterName = "@Serial";
            parametros.Add(param4);

            DbParameter param5 = dpf.CreateParameter();
            param5.Value = Prestar;
            param5.ParameterName = "@Prestar";
            parametros.Add(param5);

            DbParameter param6 = dpf.CreateParameter();
            param6.Value = fecha_registro;
            param6.ParameterName = "@fecha_registro";
            parametros.Add(param6);

            DbParameter param7 = dpf.CreateParameter();
            param7.Value = fecha_registro;
            param7.ParameterName = "@fecha_actualizacion";
            parametros.Add(param7);

            return ejecuteNonQuery("sp_ActualizarEquipo", parametros);

        }

        public int EliminarEquipo(int IDEquipo)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param = dpf.CreateParameter();
            param.Value = IDEquipo;
            param.ParameterName = "@IDEquipo";
            parametros.Add(param);

            return ejecuteNonQuery("BorrarAuto", parametros);
        }

        public List<Computadoras> select_All_Equipos()
        {
            List<Computadoras> ListaComputadoras = new List<Computadoras>();

            string StoreProcedure = "sp_ObtenerEquipo";
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
                            ListaComputadoras.Add(
                                new Computadoras((int)dr["IDEquipo"], (string)dr["Tipo"], (string)dr["Marca"], (string)dr["Modelo"], (string)dr["Activo"], (string)dr["Serial"], (string)dr["Prestar"], (DateTime)dr["Fecha_registro"], (DateTime)dr["fecha_actualizacion"])
                            );
                            Console.WriteLine("" + (string)dr["Tipo"]);
                        }

                    }
                }

            }

            return ListaComputadoras;

        }


        public Computadoras select_EquiposbyId(int IDEquipo)
        {
            Computadoras ObjAuto = new Computadoras();
            string StoredProcedure = "sp_ObtenerEquipoByID";

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
                    param.ParameterName = "@IDEquipo";
                    param.Value = IDEquipo;
                    cmd.Parameters.Add(param);
                    con.Open();
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ObjAuto = new Computadoras((int)dr["IDEquipo"], (string)dr["Tipo"], (string)dr["Marca"], (string)dr["Modelo"], (string)dr["Activo"], (string)dr["Serial"], (string)dr["Prestar"], (DateTime)dr["Fecha_registro"], (DateTime)dr["fecha_actualizacion"]);
                        }

                    }
                }
            }
            return ObjAuto;
        }
    }
}