using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebServiceProyectoUniversidad.Logica.SQL;

namespace WebServiceProyectoUniversidad.Logica.Metodos
{
    public class ProfesorCl
    {
        public Boolean IsError { set; get; }
        public String ErrorDescripcion { set; get; }

        public IProfesorSQL ObtenerInstancia()
        {
            IProfesorSQL Profesorsql = new Logica.Postgress.ProfesorPostgress(); ;
            return Profesorsql;
        }
        public void InsertarProfesor(int ID_Carrera, int Cedula)
        {
            IProfesorSQL Profesorsql = this.ObtenerInstancia();
            Profesorsql.InsertarProfesor(ID_Carrera, Cedula);
            if (Profesorsql.IsError)
            {
                this.IsError = Profesorsql.IsError;
                this.ErrorDescripcion = Profesorsql.ErrorDescripcion;
            }
        }
        public void ModificarProfesor(int ID_Profesor, int ID_Carrera, int Cedula)
        {
            IProfesorSQL Profesorsql = this.ObtenerInstancia();
            Profesorsql.ModificarProfesor(ID_Profesor, ID_Carrera, Cedula);
            if (Profesorsql.IsError)
            {
                this.IsError = Profesorsql.IsError;
                this.ErrorDescripcion = Profesorsql.ErrorDescripcion;
            }
        }
        public void EliminarProfesor(int ID_Profesor)
        {
            IProfesorSQL Profesorsql = this.ObtenerInstancia();
            Profesorsql.EliminarProfesor(ID_Profesor);
            if (Profesorsql.IsError)
            {
                this.IsError = Profesorsql.IsError;
                this.ErrorDescripcion = Profesorsql.ErrorDescripcion;
            }
        }
        public DataSet TraerProfesores(string filtro)
        {
            IProfesorSQL Profesorsql = this.ObtenerInstancia();
            DataSet datos = Profesorsql.CargarProfesor(filtro);
            if (Profesorsql.IsError)
            {
                this.IsError = Profesorsql.IsError;
                this.ErrorDescripcion = Profesorsql.ErrorDescripcion;
            }
            return datos;
        }
        public DataSet ObtenerProfesor(int ID_Profesor)
        {
            IProfesorSQL Profesorsql = this.ObtenerInstancia();
            DataSet datos = Profesorsql.ObtenerProfesor(ID_Profesor);
            if (Profesorsql.IsError)
            {
                this.IsError = Profesorsql.IsError;
                this.ErrorDescripcion = Profesorsql.ErrorDescripcion;
            }
            return datos;
        }
        public bool ProfesorRepetido(int ID_Profesor)
        {
            IProfesorSQL Profesorsql = this.ObtenerInstancia();
            bool esta = Profesorsql.ProfesorRepetido(ID_Profesor);
            if (Profesorsql.IsError)
            {
                this.IsError = Profesorsql.IsError;
                this.ErrorDescripcion = Profesorsql.ErrorDescripcion;
            }
            return esta;
        }
    }
}