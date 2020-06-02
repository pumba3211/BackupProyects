using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceProyectoUniversidad.Logica.Metodos
{
    public class EstudianteCL
    {
        public SQL.IEstudianteSQL ObtenerInstancia()
        {
            SQL.IEstudianteSQL Estudianteql = new Logica.Postgress.EstudiantePostgress();
            return Estudianteql;
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
        public void InsertarEstudiante(DateTime fecha_nacimiento, int id_carrera, int cedula, string direccion)
        {
            SQL.IEstudianteSQL EstudianteSQL = this.ObtenerInstancia();
            EstudianteSQL.InsertarEstudiante(fecha_nacimiento, id_carrera, cedula, direccion);
            if (EstudianteSQL.IsError)
            {
                this.IsError = EstudianteSQL.IsError;
                this.ErrorDescripcion = EstudianteSQL.ErrorDescripcion;
            }
        }
        public void ModificarEstudiante(int id_estudiante, DateTime fecha_nacimiento, int id_carrera, int cedula, string direccion)
        {
            SQL.IEstudianteSQL EstudianteSQL = this.ObtenerInstancia();
            EstudianteSQL.ModificarEstudiante(id_estudiante, fecha_nacimiento, id_carrera, cedula, direccion);
            if (EstudianteSQL.IsError)
            {
                this.IsError = EstudianteSQL.IsError;
                this.ErrorDescripcion = EstudianteSQL.ErrorDescripcion;
            }
        }
        public void EliminarEstudiante(int id_estudiante)
        {
            SQL.IEstudianteSQL EstudianteSQL = this.ObtenerInstancia();
            EstudianteSQL.EliminarEstudiante(id_estudiante);
            if (EstudianteSQL.IsError)
            {
                this.IsError = EstudianteSQL.IsError;
                this.ErrorDescripcion = EstudianteSQL.ErrorDescripcion;
            }
        }
        public System.Data.DataSet CargarEstudiantes(string filtro)
        {
            SQL.IEstudianteSQL EstudianteSQL = this.ObtenerInstancia();
            System.Data.DataSet datos = EstudianteSQL.CargarEstudiantes(filtro);
            if (EstudianteSQL.IsError)
            {
                this.IsError = EstudianteSQL.IsError;
                this.ErrorDescripcion = EstudianteSQL.ErrorDescripcion;
            }
            return datos;
        }
        public System.Data.DataSet ObtenerEstudiante(int id_estudiante)
        {
            SQL.IEstudianteSQL EstudianteSQL = this.ObtenerInstancia();
            System.Data.DataSet datos = EstudianteSQL.ObtenerEstudiante(id_estudiante);
            if (EstudianteSQL.IsError)
            {
                this.IsError = EstudianteSQL.IsError;
                this.ErrorDescripcion = EstudianteSQL.ErrorDescripcion;
            }
            return datos;
        }
        public bool EstudianteRepetido(int id_estudiante)
        {
            SQL.IEstudianteSQL EstudianteSQL = this.ObtenerInstancia();
            bool esta = EstudianteSQL.EstudianteRepetido(id_estudiante);
            if (EstudianteSQL.IsError)
            {
                this.IsError = EstudianteSQL.IsError;
                this.ErrorDescripcion = EstudianteSQL.ErrorDescripcion;
            }
            return esta;
        }
    }
}