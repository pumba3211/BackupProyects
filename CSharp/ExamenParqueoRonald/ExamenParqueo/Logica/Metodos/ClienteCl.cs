using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ExamenParqueo.Logica.Metodos
{
    public class ClienteCl
    {
        public SQL.IClienteSQL ObtenerInstancia()
        {
            SQL.IClienteSQL Clientesql = new Logica.Postgress.ClientePostgress();
            return Clientesql;
        }
        public bool IsError
        {
            set;
            get;
        }

        public string ErrorDescripcion
        {
            set;
            get;
        }
        public void InsertatCliente(int Cedula, string NombreCompleto, DateTime Fecha_Nacimiento, DateTime Fecha_Ingreso)
        {
            SQL.IClienteSQL ClienteSql = this.ObtenerInstancia();
            ClienteSql.InsertatCliente(Cedula, NombreCompleto, Fecha_Nacimiento, Fecha_Ingreso);
            if (ClienteSql.IsError)
            {
                this.IsError = ClienteSql.IsError;
                this.ErrorDescripcion = ClienteSql.ErrorDescripcion;
            }
        }
        public void ModificarCliente(int Cedula, string NombreCompleto, DateTime Fecha_Nacimiento, DateTime Fecha_Ingreso)
        {
            SQL.IClienteSQL ClienteSql = this.ObtenerInstancia();
            ClienteSql.ModificarCliente(Cedula, NombreCompleto, Fecha_Nacimiento, Fecha_Ingreso);
            if (ClienteSql.IsError)
            {
                this.IsError = ClienteSql.IsError;
                this.ErrorDescripcion = ClienteSql.ErrorDescripcion;
            }
        }
        public void EliminarCliente(int Cedula)
        {
            SQL.IClienteSQL ClienteSql = this.ObtenerInstancia();
            ClienteSql.EliminarCliente(Cedula);
            if (ClienteSql.IsError)
            {
                this.IsError = ClienteSql.IsError;
                this.ErrorDescripcion = ClienteSql.ErrorDescripcion;
            }
        }
        public System.Data.DataSet CargarClientes(string filtro)
        {
            SQL.IClienteSQL ClienteSql = this.ObtenerInstancia();
            DataSet datos = ClienteSql.CargarClientes(filtro);
            if (ClienteSql.IsError)
            {
                this.IsError = ClienteSql.IsError;
                this.ErrorDescripcion = ClienteSql.ErrorDescripcion;
            }
            return datos;
        }
        public System.Data.DataSet ObtenerCliente(int Cedula)
        {
            SQL.IClienteSQL ClienteSql = this.ObtenerInstancia();
            DataSet datos = ClienteSql.ObtenerCliente(Cedula);
            if (ClienteSql.IsError)
            {
                this.IsError = ClienteSql.IsError;
                this.ErrorDescripcion = ClienteSql.ErrorDescripcion;
            }
            return datos;
        }
        public bool ClienteRepetido(int Cedula)
        {
            SQL.IClienteSQL ClienteSql = this.ObtenerInstancia();
            bool esta = ClienteSql.ClienteRepetido(Cedula);
            if (ClienteSql.IsError)
            {
                this.IsError = ClienteSql.IsError;
                this.ErrorDescripcion = ClienteSql.ErrorDescripcion;
            }
            return esta;
        }
    }
}