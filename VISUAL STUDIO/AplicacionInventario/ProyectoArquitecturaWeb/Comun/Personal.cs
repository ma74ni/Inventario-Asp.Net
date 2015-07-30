using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoArquitecturaWeb.Comun
{
    public class Personal
    {
        public Personal() { }

        private int _IDPersonal;

        public int IDPersonal
        {
            get { return _IDPersonal; }
            set { _IDPersonal = value; }
        }
        private string _CIPersonal;

        public string CIPersonal
        {
            get { return _CIPersonal; }
            set { _CIPersonal = value; }
        }
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private string _Apellido;

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        private string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private int _IDArea;

        public int IDArea
        {
            get { return _IDArea; }
            set { _IDArea = value; }
        }

        public Personal(int IDPersonal, string CIPersonal , string Nombre,string Apellido,string Telefono,string Email, int IDArea) 
        {
            this.IDPersonal = IDPersonal;
            this.CIPersonal = CIPersonal;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Email = Email;
            this.IDPersonal = IDPersonal;

        }
    }
}