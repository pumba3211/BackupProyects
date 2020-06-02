using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UTNProyecto.AccesoDatos;
using WebServiceProyectoUniversidad.Logica.SQL;

namespace WebServiceProyectoUniversidad.Logica.Metodos
{
    public class PersonaCl
    {
        public Boolean IsError { set; get; }
        public String ErrorDescripcion { set; get; }

        public IPersonasSQL ObtenerInstancia()
        {
                IPersonasSQL Personalsql = new Logica.Postgress.PersonaPostgress();;
                return Personalsql;           
        }
        public void InsertarPersona(int cedula,string Nombre,string apellidos)
        {
            Logica.SQL.IPersonasSQL PersonaSql = this.ObtenerInstancia();
            PersonaSql.InsertarPersona(cedula, Nombre, apellidos);
            if (PersonaSql.IsError)
            {
                this.IsError = PersonaSql.IsError;
                this.ErrorDescripcion = PersonaSql.ErrorDescripcion;
            }
        }
        public void ModificarPersona(int cedula, string Nombre, string apellidos)
        {
            Logica.SQL.IPersonasSQL PersonaSql = this.ObtenerInstancia();
            PersonaSql.ModificarPersona(cedula, Nombre, apellidos);
            if (PersonaSql.IsError)
            {
                this.IsError = PersonaSql.IsError;
                this.ErrorDescripcion = PersonaSql.ErrorDescripcion;
            }
        }
        public void EliminarPersona(int Cedula)
        {
            Logica.SQL.IPersonasSQL PersonaSql = this.ObtenerInstancia();
            PersonaSql.EliminarPersona(Cedula);
            if (PersonaSql.IsError)
            {
                this.IsError = PersonaSql.IsError;
                this.ErrorDescripcion = PersonaSql.ErrorDescripcion;
            }
        }
        public System.Data.DataSet CargarPersonas(string filtro)
        {
            Logica.SQL.IPersonasSQL PersonaSql = this.ObtenerInstancia();
            System.Data.DataSet datos = PersonaSql.CargarPersonas(filtro);
            if (PersonaSql.IsError)
            {
                this.IsError = PersonaSql.IsError;
                this.ErrorDescripcion = PersonaSql.ErrorDescripcion;
            }
            return datos;
        }
        public bool CedulaRepetida(int cedula)
        {
            Logica.SQL.IPersonasSQL PersonaSql = this.ObtenerInstancia();
            bool esta = PersonaSql.CedulaRepetida(cedula);
            if (PersonaSql.IsError)
            {
                this.IsError = PersonaSql.IsError;
                this.ErrorDescripcion = PersonaSql.ErrorDescripcion;
            }
            return esta;
        }
    }
}