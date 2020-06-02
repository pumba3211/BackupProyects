using MecanicaVarela.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaVarela
{
    public class RepuestosCL
    {
        public bool Is_Error
        {
            set;
            get;
        }

        public string ErrorDescripcion
        {
            set;
            get;
        }
        public void AgregarRepuesto(string nombre, string modelo, string marca, int cantidad, double precio, int impuesto, bool gravado)
        {
            IAccesoDatos1 accesoDatos = new RepuestosAD();
            accesoDatos.Escribir(Guid.NewGuid().ToString().Substring(0, 10) + " " + nombre + " " + modelo + " " + marca + " " + cantidad + " " +
                precio//.ToString("n2") Agarrar solo 2 decilmares si el numero es float o double        
            + " " + impuesto + " " + gravado);
            if (accesoDatos.Is_Error)
            {
                this.Is_Error = false;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }

        }

        public void EditarRepuesto(string id, string nombre, string modelo, string marca, int cantidad, int precio, int impuesto, bool grabado)
        {
            IAccesoDatos1 accesoDatos = new RepuestosAD();
            accesoDatos.Editar(id,id+" "+nombre+" "+modelo+" "+marca+" "+cantidad+" "+precio.ToString("n2")+" "+impuesto+" "+grabado);

            if (accesoDatos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        public void EliminarRepuesto(string id)
        {
            IAccesoDatos1 accesoDatos = new RepuestosAD();
            accesoDatos.Eliminar(id);
            if (accesoDatos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
    }
}
