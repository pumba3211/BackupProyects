using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WsRecursosHumanos.IndicadoresEconomicos;
using WsRecursosHumanos.AccesoDatos;
using WsRecursosHumanos.Logica;
using System.Data;
using WsRecursosHumanos.Estructuras;
namespace WsRecursosHumanos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    
    public class EmpleadoServicio:IEmpleadoServicio
    {
        
        AccesoDatos.AccesoDatos accesoDatos = AccesoDatos.AccesoDatos.Instance;
        
        public string AgregarEmpleado(Estructuras.Empleado empleado)
        {
            EmpleadoCl oEmpleadoCl = new EmpleadoCl();
            
            oEmpleadoCl.InsertarEmpleado(empleado.Cedula, empleado.Nombre, empleado.Edad, empleado.Puesto);
            if (oEmpleadoCl.IsError)
            {
                return "Error " + oEmpleadoCl.ErrorDescripcion;
            }
            return "Empleado Agregado " ;
        }

        public string ModificarEmpleado(Estructuras.Empleado empleado)
        {

            EmpleadoCl oEmpleadoCl = new EmpleadoCl();           
            if (oEmpleadoCl.IsError)
            {
                return "Error " + oEmpleadoCl.ErrorDescripcion;
            }
            return "Empleado Agregado ";
        }

        public string EliminarEmpleado(int id)
        {
            EmpleadoCl oEmpleadoCl = new EmpleadoCl();
            if (oEmpleadoCl.IsError)
            {
                return "Error " + oEmpleadoCl.ErrorDescripcion;
            }
            else
            {
                oEmpleadoCl.EliminarEmpleado(id);
                return "Empleado Eliminado";
            }
        }

        public IEnumerable<Empleado> TraearEmpleados(string filtro)
        {
            List<Estructuras.Empleado> empleados = new List<Estructuras.Empleado>();
            EmpleadoCl oEmpleadoCl=new EmpleadoCl();
            var data=oEmpleadoCl.TraerEmpleados(filtro);
            if(oEmpleadoCl.IsError)
            {
                return null;
            }
            foreach(DataRow item in data.Tables[0].Rows)
            {
                empleados.Add(new Empleado()
                {
                    Cedula=Convert.ToInt32(item["cedula"]),
                    Edad=Convert.ToInt32(item["edad"]),
                    Nombre=item["nombre"].ToString(),
                    Puesto=item["puesto"].ToString()
                });
            }
            return empleados;
        }
        public double ObtenerTipoCambio()
        {
            wsIndicadoresEconomicosSoapClient oClient = new wsIndicadoresEconomicosSoapClient();
            var data = oClient.ObtenerIndicadoresEconomicos("317", "20/03/2014", "20/03/2014", "Pedro Perez", "N");
            return Convert.ToDouble(data.Tables[0].Rows[0][2]);
        }
    }
}
