using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoArquitecturaWeb.Comun
{
    public class Computadoras
    {
        int IDEquipo;

        public int IDEquipo1
        {
            get { return IDEquipo; }
            set { IDEquipo = value; }
        }
        string Tipo;

        public string Tipo1
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        string Marca;

        public string Marca1
        {
            get { return Marca; }
            set { Marca = value; }
        }
        string Modelo;

        public string Modelo1
        {
            get { return Modelo; }
            set { Modelo = value; }
        }
        string Activo;

        public string Activo1
        {
            get { return Activo; }
            set { Activo = value; }
        }
        string Serial;

        public string Serial1
        {
            get { return Serial; }
            set { Serial = value; }
        }
        string Prestar;

        public string Prestar1
        {
            get { return Prestar; }
            set { Prestar = value; }
        }
        DateTime fecha_registro;

        public DateTime Fecha_registro
        {
            get { return fecha_registro; }
            set { fecha_registro = value; }
        }
        DateTime fecha_actualizacion;

        public DateTime Fecha_actualizacion
        {
            get { return fecha_actualizacion; }
            set { fecha_actualizacion = value; }
        }
        public Computadoras() { }

        public Computadoras(int IDEquipo, string Tipo, string Marca, string Modelo, string Activo, string Serial, string Prestar, DateTime fecha_registro, DateTime fecha_actualizacion) 
        {
            this.IDEquipo = IDEquipo;
            this.Tipo = Tipo;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Activo = Activo;
            this.Serial = Serial;
            this.Prestar = Prestar;
            this.fecha_registro = fecha_registro;
            this.fecha_actualizacion = fecha_actualizacion;
        }

    }
}