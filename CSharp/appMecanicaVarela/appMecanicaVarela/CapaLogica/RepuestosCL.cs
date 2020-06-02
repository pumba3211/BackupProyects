using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appMecanicaVarela.CapaLogica;
using appMecanicaVarela.Estructura;

namespace appMecanicaVarela.CapaLogica
{
    public class RepuestosCL
    {
        public bool IsError { set; get; }

        public string ErrorDescripcion { set; get; }

        public void AgregarRepuesto(string nombre, string modelo, string marca, int cantidad,
                                    int precio, int impuesto, bool gravado)
        {
            lAccesoDatos accesoDatos = new RepuestosAD();

            accesoDatos.Escribir(Guid.NewGuid().ToString().Substring(0, 10) + " " +
                                nombre + " " + 
                                modelo + " "+ 
                                marca + " " +
                                cantidad + " " +
                                precio.ToString("n2")+ " " +
                                impuesto + " " +
                                gravado);
            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }



        public void Editar(string id, string nombre, string modelo, string marca, int cantidad,
                                    int precio, int impuesto, bool gravado)
        {
            lAccesoDatos accesoDatos = new RepuestosAD();

            accesoDatos.Editar(id, id+ " " +
                                nombre + " " + 
                                modelo + " " +
                                marca + " " +
                                cantidad + " " +
                                precio.ToString("n2") + " " +
                                impuesto + " " +
                                gravado);
            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }

        }


        public void EliminarRepuesto(string id)
        {
            lAccesoDatos accesoDatos = new RepuestosAD();

            accesoDatos.Eliminar(id);

            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }

        }
        public List<Repuesto> ObtenerRepuestos()
        {
            List<Repuesto> repuestos = new List<Repuesto>();
            lAccesoDatos accesoDatos = new RepuestosAD();
            StringBuilder informacion = new StringBuilder(accesoDatos.leer()); //Se obtiene una lista de todos los repuestos 
            string[] lineas = informacion.ToString().Split(new string[]{Environment.NewLine},StringSplitOptions.None);

            if (lineas.Any())
            {
                foreach (var linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] atributos=linea.Split(new string[]{" "},StringSplitOptions.None);
                        repuestos.Add(new Repuesto()
                        {
                            Id=atributos[0],
                            Nombre=atributos[1],
                            Modelo=atributos[2],
                            Marca=atributos[3],
                            Cantidad=Convert.ToInt32(atributos[4]),
                            Precio=Convert.ToDouble(atributos[5]),
                            Impuesto=Convert.ToInt32(atributos[6]),
                            Gravado=Convert.ToBoolean(atributos[7])});                      
                    }
                }
            }
            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
            return repuestos;
        }

    }
}
