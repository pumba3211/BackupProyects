using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebServiceProyectoUniversidad.Logica.Metodos
{
    public class AulaCl
    {
        public SQL.IAulaSQL ObtenerInstancia()
        {
            SQL.IAulaSQL Aulasql = new Logica.Postgress.AulaPostgress();
            return Aulasql;
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
        public void InsertarAula(string nombre)
        {
            SQL.IAulaSQL Aulasql= this.ObtenerInstancia();
            Aulasql.InsertarAula(nombre);
            if (Aulasql.IsError)
            {
                this.IsError = Aulasql.IsError;
                this.ErrorDescripcion = Aulasql.ErrorDescripcion;
            }
        }
        public void ModificarAula(int ID_Aula, string nombre)
        {
            SQL.IAulaSQL Aulasql = this.ObtenerInstancia();
            Aulasql.ModificarAula(ID_Aula, nombre);
            if (Aulasql.IsError)
            {
                this.IsError = Aulasql.IsError;
                this.ErrorDescripcion = Aulasql.ErrorDescripcion;
            }
        }
        public void EliminarAula(int ID_Aula)
        {
            SQL.IAulaSQL Aulasql = this.ObtenerInstancia();
            Aulasql.EliminarAula(ID_Aula);
            if (Aulasql.IsError)
            {
                this.IsError = Aulasql.IsError;
                this.ErrorDescripcion = Aulasql.ErrorDescripcion;
            }
        }
        public DataSet ObtenerAulas(string filtro)
        {
            SQL.IAulaSQL Aulasql = this.ObtenerInstancia();
            DataSet datos = Aulasql.CargarAula(filtro);
            if (Aulasql.IsError)
            {
                this.IsError = Aulasql.IsError;
                this.ErrorDescripcion = Aulasql.ErrorDescripcion;
            }
            return datos;
        }
        public DataSet ObtenerAula(int ID_Aula)
        {
            SQL.IAulaSQL Aulasql = this.ObtenerInstancia();
            DataSet datos = Aulasql.ObtenerAula(ID_Aula);
            if (Aulasql.IsError)
            {
                this.IsError = Aulasql.IsError;
                this.ErrorDescripcion = Aulasql.ErrorDescripcion;
            }
            return datos;
        }
        public bool AulaRepetida(int ID_Aula)
        {
            SQL.IAulaSQL Aulasql = this.ObtenerInstancia();
            bool esta = Aulasql.AulaRepetida(ID_Aula);
            if (Aulasql.IsError)
            {
                this.IsError = Aulasql.IsError;
                this.ErrorDescripcion = Aulasql.ErrorDescripcion;
            }
            return esta;
        }
    }
}