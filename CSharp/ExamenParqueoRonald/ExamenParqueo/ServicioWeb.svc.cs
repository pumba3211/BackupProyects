using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UTNProyecto.AccesoDatos;

namespace ExamenParqueo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IServicioWeb
    {
        AccesoDatos accesodatos = AccesoDatos.Instance;
        Logica.Metodos.FacturaCl oFacturaCl = new Logica.Metodos.FacturaCl();
        Logica.Metodos.ClienteCl oClienteCl = new Logica.Metodos.ClienteCl();
        Logica.Metodos.VehiculoCl oVehiculoCl = new Logica.Metodos.VehiculoCl();
        public string Conexion()
        {
            return accesodatos.accesodatos.Estado();
        }
        public string InsertarCliente(Estructuras.Cliente Cliente)
        {
            string mensaje = "";
            if (oClienteCl.ClienteRepetido(Cliente.Cedula))
            {
                mensaje = "Ese cliente ya existe";
            }
            else
            {
                oClienteCl.InsertatCliente(Cliente.Cedula, Cliente.nombre_completo, Cliente.Fecha_Nacimiento, Cliente.Fecha_Ingreso);
                if (oClienteCl.IsError)
                {
                    mensaje = oClienteCl.ErrorDescripcion;
                }
                else
                {
                    mensaje = "Cliente agregado correctamente";
                }
            }
            return mensaje;
        }

        public string ModificarCliente(Estructuras.Cliente Cliente)
        {
            string mensaje = "";
            if (oClienteCl.ClienteRepetido(Cliente.Cedula))
            {
                oClienteCl.ModificarCliente(Cliente.Cedula, Cliente.nombre_completo, Cliente.Fecha_Nacimiento, Cliente.Fecha_Ingreso);
                if (oClienteCl.IsError)
                {
                    mensaje = oClienteCl.ErrorDescripcion;
                }
                else
                {
                    mensaje = "Cliente modificado correctamente";
                }
            }
            else
            {
                mensaje = "Ese cliente no  existe";
            }
            return mensaje;
        }

        public string EliminarCliente(int Cedula)
        {
            string mensaje = "";
            if (oClienteCl.ClienteRepetido(Cedula))
            {
                oClienteCl.EliminarCliente(Cedula);
                if (oClienteCl.IsError)
                {
                    mensaje = oClienteCl.ErrorDescripcion;
                }
                else
                {
                    mensaje = "Cliente eliminado correctamente";
                }
            }
            else
            {
                mensaje = "Ese cliente no  existe";
            }
            return mensaje;
        }

        public IEnumerable<Estructuras.Cliente> CargarClientes(string filtro)
        {
            List<Estructuras.Cliente> Clientes = new List<Estructuras.Cliente>();
            var data = oClienteCl.CargarClientes(filtro);
            if (oClienteCl.IsError)
            {
                return null;
            }
            foreach (DataRow item in data.Tables[0].Rows)
            {
                Clientes.Add(new Estructuras.Cliente()
                 {
                     Cedula = Convert.ToInt32(item["cedula"]),
                     nombre_completo = item["nombre_completo"].ToString(),
                     Fecha_Nacimiento = Convert.ToDateTime(item["fecha_nacimiento"]),
                     Fecha_Ingreso = Convert.ToDateTime(item["fecha_ingreso"]),
                 });
            }
            return Clientes;
        }

        public Estructuras.Cliente ObtenerCliente(int Cedula)
        {
            Estructuras.Cliente Cliente = new Estructuras.Cliente();
            if (oClienteCl.ClienteRepetido(Cedula))
            {
                var data = oClienteCl.ObtenerCliente(Cedula);
                Cliente.Cedula = Convert.ToInt32(data.Tables[0].Rows[0]["cedula"]);
                Cliente.nombre_completo = data.Tables[0].Rows[0]["nombre_completo"].ToString();
                Cliente.Fecha_Nacimiento = Convert.ToDateTime(data.Tables[0].Rows[0]["fecha_nacimiento"]);
                Cliente.Fecha_Ingreso = Convert.ToDateTime(data.Tables[0].Rows[0]["fecha_ingreso"]);
            }
            else
            {

            }
            return Cliente;
        }

        public string InsertarVehiculo(Estructuras.Vehiculo Vehiculo)
        {
            string mensaje = "";
            if (oVehiculoCl.VehiculoRepetido(Vehiculo.Matricula))
            {
                mensaje = "Ese vehiculo ya esta reservado";
            }
            else
            {
                if (oClienteCl.ClienteRepetido(Vehiculo.Cedula))
                {
                    oVehiculoCl.InsertatVehiculo(Vehiculo.Matricula, Vehiculo.Cedula, Vehiculo.Color, Vehiculo.Marca);
                    if (oVehiculoCl.IsError)
                    {
                        mensaje = oVehiculoCl.ErrorDescripcion;
                    }
                    else
                    {
                        mensaje = "Vehiculo agregado correctamente";
                    }
                }
                else
                {
                    mensaje = "El cliente no existe";

                }
            }
            return mensaje;
        }

        public string ModificarVehiculo(Estructuras.Vehiculo Vehiculo)
        {
            string mensaje = "";
            if (oVehiculoCl.VehiculoRepetido(Vehiculo.Matricula))
            {
                if (oClienteCl.ClienteRepetido(Vehiculo.Cedula))
                {
                    oVehiculoCl.ModificarVehiculo(Vehiculo.Matricula, Vehiculo.Cedula, Vehiculo.Color, Vehiculo.Marca);
                    if (oVehiculoCl.IsError)
                    {
                        mensaje = oVehiculoCl.ErrorDescripcion;
                    }
                    else
                    {
                        mensaje = "Vehiculo modificado correctamente";
                    }
                }
                else
                {
                    mensaje = "El cliente no existe";
                }
            }
            else
            {
                mensaje = "Ese vehiculo no existe";
            }
            return mensaje;
        }

        public string ElimianrVehiculo(string matricula)
        {
            string mensaje = "";
            if (oVehiculoCl.VehiculoRepetido(matricula))
            {
                oVehiculoCl.EliminarVehiculo(matricula);
                if (oVehiculoCl.IsError)
                {
                    mensaje = oVehiculoCl.ErrorDescripcion;
                }
                else
                {
                    mensaje = "Vehiculo eliminado correctamente";
                }
            }
            else
            {
                mensaje = "La matricula no existe";
            }
            return mensaje;
        }

        public IEnumerable<Estructuras.Vehiculo> Cargarvehiculos(string filtro)
        {
            List<Estructuras.Vehiculo> Vehiculos = new List<Estructuras.Vehiculo>();
            var data = oVehiculoCl.CargarVehiculos(filtro);
            if (oVehiculoCl.IsError)
            {
                return null;
            }
            foreach (DataRow item in data.Tables[0].Rows)
            {
                Vehiculos.Add(new Estructuras.Vehiculo()
                {
                    Cedula = Convert.ToInt32(item["cedula"]),
                    Matricula = item["matricula"].ToString(),
                    Color = item["color"].ToString(),
                    Marca = item["marca"].ToString(),
                });
            }
            return Vehiculos;
        }

        public Estructuras.Vehiculo ObtenerVehiculo(string matricula)
        {
            Estructuras.Vehiculo Vehculo = new Estructuras.Vehiculo();
            if (oVehiculoCl.VehiculoRepetido(matricula))
            {
                var data = oVehiculoCl.ObtenerVehicul(matricula);
                Vehculo.Cedula = Convert.ToInt32(data.Tables[0].Rows[0]["cedula"]);
                Vehculo.Matricula = data.Tables[0].Rows[0]["matricula"].ToString();
                Vehculo.Color = data.Tables[0].Rows[0]["color"].ToString();
                Vehculo.Marca = data.Tables[0].Rows[0]["marca"].ToString();
            }
            else
            {

            }
            return Vehculo;
        }

        public string InsertarFactura(Estructuras.Factura Factura)
        {
            string mensaje = "";
            if (oVehiculoCl.VehiculoRepetido(Factura.Matricula))
            {
                oFacturaCl.InsertarFactura(Factura.Matricula, Factura.Fecha_ingreso, Factura.Fecha_salida, Factura.Costo_Hora);
                if (oFacturaCl.IsError)
                {
                    mensaje = oFacturaCl.ErrorDescripcion;
                }
                else
                {
                    mensaje = "Factura Agregada";
                }
            }
            else
            {
                mensaje = "No se encuentra el vehiculo";
            }
            return mensaje;
        }

        public string ModificarFactura(Estructuras.Factura Factura)
        {
            string mensaje = "";
            if (oFacturaCl.FacturaExiste(Factura.N_factura))
            {
                if (oVehiculoCl.VehiculoRepetido(Factura.Matricula))
                {
                    oFacturaCl.ModificarFactura(Factura.Matricula, Factura.Fecha_ingreso, Factura.Fecha_salida, Factura.Costo_Hora, Factura.N_factura);
                    if (oFacturaCl.IsError)
                    {
                        mensaje = oFacturaCl.ErrorDescripcion;
                    }
                    else
                    {
                        mensaje = "Factura Modificada";
                    }
                }
                else
                {
                    mensaje = "No se encuentra el vehiculo";
                }
            }
            else
            {
                mensaje = "No se encuntra el numero de factura";
            }
            return mensaje;
        }

        public string EliminarFactura(int Numero_Factura)
        {
            string mensaje = "";
            if (oFacturaCl.FacturaExiste(Numero_Factura))
            {
                oFacturaCl.EliminarFactura(Numero_Factura);
                if (oFacturaCl.IsError)
                {
                    mensaje = oFacturaCl.ErrorDescripcion;
                }
                else
                {
                    mensaje = "Factura Eliminada";
                }
            }
            else
            {
                mensaje = "La factura no existe";
            }
            return mensaje;
        }

        public IEnumerable<Estructuras.Factura> CargarFacturas(string filtro)
        {
            List<Estructuras.Factura> Facturas = new List<Estructuras.Factura>();
            var data = oFacturaCl.CargarFacturas(filtro);
            if (oVehiculoCl.IsError)
            {
                return null;
            }
            foreach (DataRow item in data.Tables[0].Rows)
            {
                Facturas.Add(new Estructuras.Factura()
                {
                    N_factura = Convert.ToInt32(item["n_factura"]),
                    Matricula = item["matricula"].ToString(),
                    Fecha_ingreso = Convert.ToDateTime(item["fecha_ingreso"]),
                    Fecha_salida = Convert.ToDateTime(item["fecha_salida"]),
                    Costo_Hora = Convert.ToDouble(item["costo_hora"]),

                });
            }
            return Facturas;
        }

        public Estructuras.Factura ObtenerFactura(int Numero_Factura)
        {
            Estructuras.Factura Factura = new Estructuras.Factura();
            if (oFacturaCl.FacturaExiste(Numero_Factura))
            {
                var data = oFacturaCl.ObtenerFactura(Numero_Factura);
                Factura.N_factura = Convert.ToInt32(data.Tables[0].Rows[0]["n_factura"]);
                Factura.Matricula = data.Tables[0].Rows[0]["matricula"].ToString();
                Factura.Fecha_ingreso = Convert.ToDateTime(data.Tables[0].Rows[0]["fecha_ingreso"]);
                Factura.Fecha_salida = Convert.ToDateTime(data.Tables[0].Rows[0]["fecha_salida"]);
                Factura.Costo_Hora = Convert.ToDouble(data.Tables[0].Rows[0]["costo_hora"]);
            }
            else
            {

            }
            return Factura;
        }

        public string CalcularCostoFactura(int Numero_Factura)
        {
            string mensaje = "";
            if (oFacturaCl.FacturaExiste(Numero_Factura))
            {
                mensaje = "El total a pagar es " + oFacturaCl.CalculaCosto(Numero_Factura) + "colones";
            }
            else
            {
                mensaje = "La factura no existe";
            }
            return mensaje;
        }
    }
}
