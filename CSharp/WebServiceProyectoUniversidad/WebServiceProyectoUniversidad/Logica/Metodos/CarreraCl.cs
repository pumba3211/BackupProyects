using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebServiceProyectoUniversidad.Logica.Metodos
{
    public class CarreraCl
    {
        public SQL.ICarreraSQL ObtenerInstancia()
        {
            SQL.ICarreraSQL Carrerasql = new Logica.Postgress.CarreraPostgress();
            return Carrerasql;
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
        public void InsertarCarrera(int id_carrera, string nombre, int estado)
        {
            SQL.ICarreraSQL oCarrerasql = this.ObtenerInstancia();
            oCarrerasql.InsertarCarrera(id_carrera, nombre, estado);
            if (oCarrerasql.IsError)
            {
                this.IsError = oCarrerasql.IsError;
                this.ErrorDescripcion = oCarrerasql.ErrorDescripcion;
            }
        }
        public void ModificarCarrera(int id_carrera, string nombre, int estado)
        {
            SQL.ICarreraSQL oCarrerasql = this.ObtenerInstancia();
            oCarrerasql.ModificarCarrera(id_carrera, nombre, estado);
            if (oCarrerasql.IsError)
            {
                this.IsError = oCarrerasql.IsError;
                this.ErrorDescripcion = oCarrerasql.ErrorDescripcion;
            }
        }
        public void EliminarCarrera(int id_carrera)
        {
            SQL.ICarreraSQL oCarrerasql = this.ObtenerInstancia();
            oCarrerasql.EliminarCarrera(id_carrera);
            if (oCarrerasql.IsError)
            {
                this.IsError = oCarrerasql.IsError;
                this.ErrorDescripcion = oCarrerasql.ErrorDescripcion;
            }
        }
        public DataSet ObtenerCarreras(string filtro)
        {
            SQL.ICarreraSQL oCarrerasql = this.ObtenerInstancia();
            DataSet datos = oCarrerasql.CargarCarreras(filtro);
            if (oCarrerasql.IsError)
            {
                this.IsError = oCarrerasql.IsError;
                this.ErrorDescripcion = oCarrerasql.ErrorDescripcion;
            }
            return datos;
        }
        public DataSet ObtenerCarrera(int id_carrera)
        {
            SQL.ICarreraSQL oCarrerasql = this.ObtenerInstancia();
            DataSet datos = oCarrerasql.ObtenerCarrera(id_carrera);
            if (oCarrerasql.IsError)
            {
                this.IsError = oCarrerasql.IsError;
                this.ErrorDescripcion = oCarrerasql.ErrorDescripcion;
            }
            return datos;
        }
        public bool CarreraRepetida(int id_carrera)
        {
            SQL.ICarreraSQL oCarrerasql = this.ObtenerInstancia();
            bool esta = oCarrerasql.CarrraRepetida(id_carrera);
            if (oCarrerasql.IsError)
            {
                this.IsError = oCarrerasql.IsError;
                this.ErrorDescripcion = oCarrerasql.ErrorDescripcion;
            }
            return esta;
        }
    }
}