using System;
using System.Data;
using WsRecursosHumanos.AccesoDatos;
using WsRecursosHumanos.Logica.Postgres;
using WsRecursosHumanos.Logica.SQL;

namespace WsRecursosHumanos.Logica
{
    public class EmpleadoCl
    {
        public Boolean IsError { set; get; }
        public String ErrorDescripcion { set; get; }

        public IEmpleadoSql ObtenerInstancia()
        {
            IEmpleadoSql empleadoSql = null;
            
            switch (AccesoDatos.AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.SqlServer:
                    break;
                case ContextDataBase.PostgreSql:
                    empleadoSql = new EmpleadoPostgres();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return empleadoSql;
        }


        public void InsertarEmpleado(int cedula, string nombre, int edad, string puesto)
        {
            IEmpleadoSql empleadoSql = this.ObtenerInstancia();
            empleadoSql.InsertarEmpleado(cedula, nombre, edad, puesto);
            if (empleadoSql.IsError)
            {
                this.IsError = empleadoSql.IsError;
                this.ErrorDescripcion = empleadoSql.ErrorDescripcion;
            }
        }

        

        public void EditarEmpleado(int id, int cedula, string nombre, int edad, string puesto)
        {
            IEmpleadoSql empleadoSql = this.ObtenerInstancia();
            empleadoSql.EditarEmpleado(id, cedula, nombre, edad, puesto);
            if (empleadoSql.IsError)
            {
                this.IsError = empleadoSql.IsError;
                this.ErrorDescripcion = empleadoSql.ErrorDescripcion;
            }
        }


        public void EliminarEmpleado(int id)
        {
            IEmpleadoSql empleadoSql = this.ObtenerInstancia();
            empleadoSql.EliminarEmpleado(id);
            if (empleadoSql.IsError)
            {
                this.IsError = empleadoSql.IsError;
                this.ErrorDescripcion = empleadoSql.ErrorDescripcion;
            }
        }

        public DataSet TraerEmpleados(string filtro)
        {
            IEmpleadoSql empleadoSql = this.ObtenerInstancia();
            DataSet datos = empleadoSql.TraerEmpleados(filtro);
            if (empleadoSql.IsError)
            {
                this.IsError = empleadoSql.IsError;
                this.ErrorDescripcion = empleadoSql.ErrorDescripcion;
            }
            return datos;
        }

    }
}
