using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace WebServiceProyectoUniversidad.Logica.Metodos
{
    public class AdministrativoCL
    {
        public Boolean IsError { set; get; }
        public String ErrorDescripcion { set; get; }

        public SQL.IAdministrativoSQL ObtenerInstancia()
        {
            SQL.IAdministrativoSQL AdministradoSql = new Logica.Postgress.AdministrativoPostgress();
            return AdministradoSql;
        }
        public void InsertarAdministrador(string username,string password,int cedula)
        {
            Logica.SQL.IAdministrativoSQL oAdministradorSql = this.ObtenerInstancia();
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = provider.ComputeHash(data);
            string md5 = string.Empty;
            for (int i = 0; i < data.Length; i++)
            {
                md5 += data[i].ToString("x2").ToLower();
            }

            oAdministradorSql.InsertarAdministrativo(username, md5, cedula);
            if (oAdministradorSql.IsError)
            {
                this.IsError = oAdministradorSql.IsError;
                this.ErrorDescripcion = oAdministradorSql.ErrorDescripcion;
            }
        }
        public void CambiarClave(string username, string password)
        {
            Logica.SQL.IAdministrativoSQL oAdministradorSql = this.ObtenerInstancia();
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = provider.ComputeHash(data);
            string md5 = string.Empty;
            for (int i = 0; i < data.Length; i++)
            {
                md5 += data[i].ToString("x2").ToLower();
            }

            oAdministradorSql.CambiarClave(username, md5);
            if (oAdministradorSql.IsError)
            {
                this.IsError = oAdministradorSql.IsError;
                this.ErrorDescripcion = oAdministradorSql.ErrorDescripcion;
            }
        }
        public void CambiarPropietario(string username, int cedula)
        {
            Logica.SQL.IAdministrativoSQL oAdministradorSql = this.ObtenerInstancia();
            oAdministradorSql.CambiarPropietario(username, cedula);
            if (oAdministradorSql.IsError)
            {
                this.IsError = oAdministradorSql.IsError;
                this.ErrorDescripcion = oAdministradorSql.ErrorDescripcion;
            }
        }
        public void EliminarAdministrador(string username)
        {
            Logica.SQL.IAdministrativoSQL oAdministradorSql = this.ObtenerInstancia();
            oAdministradorSql.EliminarAdministrador(username);
            if (oAdministradorSql.IsError)
            {
                this.IsError = oAdministradorSql.IsError;
                this.ErrorDescripcion = oAdministradorSql.ErrorDescripcion;
            }
        }
        public DataSet CargarAdministrativos(string filtro)
        {
            Logica.SQL.IAdministrativoSQL oAdministradorSql = this.ObtenerInstancia();
            DataSet datos = oAdministradorSql.CargarAdministrativos(filtro);
            if (oAdministradorSql.IsError)
            {
                this.IsError = oAdministradorSql.IsError;
                this.ErrorDescripcion = oAdministradorSql.ErrorDescripcion;
            }
            return datos;
        }
        public System.Data.DataSet ObtenerAdministrador(string username)
        {
            Logica.SQL.IAdministrativoSQL oAdministradorSql = this.ObtenerInstancia();
            DataSet datos = oAdministradorSql.ObtenerAdministrador(username);
            if (oAdministradorSql.IsError)
            {
                this.IsError = oAdministradorSql.IsError;
                this.ErrorDescripcion = oAdministradorSql.ErrorDescripcion;
            }
            return datos;
        }
        public bool ValidarSession(string username, string password)
        {
            Logica.SQL.IAdministrativoSQL oAdministradorSql = this.ObtenerInstancia();

            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            byte[] dataResultado = System.Text.Encoding.ASCII.GetBytes(password);
            dataResultado = provider.ComputeHash(dataResultado);
            string md5 = string.Empty;
            for (int i = 0; i < dataResultado.Length; i++)
            {
                md5 += dataResultado[i].ToString("x2").ToLower();
            }

            DataSet data = oAdministradorSql.ValidarSession(username, md5);
            if (data.Tables[0].Rows.Count > 0)
            {
                return true;
            }

            if (oAdministradorSql.IsError)
            {
                this.IsError = oAdministradorSql.IsError;
                this.ErrorDescripcion = oAdministradorSql.ErrorDescripcion;
            }
            return false;
        }
        public bool UsernameRepetido(string username)
        {
            Logica.SQL.IAdministrativoSQL oAdministradorSql = this.ObtenerInstancia();
            bool esta = oAdministradorSql.UsernameRepetido(username);
            if (oAdministradorSql.IsError)
            {
                this.IsError = oAdministradorSql.IsError;
                this.ErrorDescripcion = oAdministradorSql.ErrorDescripcion;
            }
            return esta;
        }
    }
}