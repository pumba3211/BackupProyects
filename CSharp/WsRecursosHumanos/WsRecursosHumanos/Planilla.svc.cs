using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WsRecursosHumanos.Logica;

namespace WsRecursosHumanos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Planilla" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Planilla.svc o Planilla.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Planilla : IPlanilla
    {

        public string AgregarPlanilla(Estructuras.Planilla planilla)
        {
            PlanillaCl oPlanillaCl = new PlanillaCl();
            oPlanillaCl.InsertarPlanilla(planilla.Nombre, planilla.Fecha);
            if (oPlanillaCl.IsError)
            {
                return "Error " + oPlanillaCl.ErrorDescripcion;
            }
            else
            {
                return "Planilla agregada correctamente";
            }
        }

        public string EditarPlanilla(Estructuras.Planilla planilla, int id)
        {
            PlanillaCl oPlanillaCl = new PlanillaCl();
            oPlanillaCl.ModificarPlanilla(id, planilla.Nombre, planilla.Fecha);
            if (oPlanillaCl.IsError)
            {
                return "Error " + oPlanillaCl.ErrorDescripcion;
            }
            else
            {
                return "Planilla editada correctamente";
            }
        }

        public IEnumerable<Estructuras.Planilla> TraerPlanillas(string filtro)
        {
            List<Estructuras.Planilla> planillas = new List<Estructuras.Planilla>();
            PlanillaCl oPlanillaCl = new PlanillaCl();
            var data = oPlanillaCl.TraerPlanillas(filtro);
            if (oPlanillaCl.IsError)
            {
                return null;
            }
            foreach (DataRow item in data.Tables[0].Rows)
            {
                planillas.Add(new Estructuras.Planilla()
                {
                    ID=Convert.ToInt32(item["id"]),
                    Nombre=item["nombre"].ToString(),
                    Fecha=Convert.ToDateTime(item["fecha"])
                });
            }
            return planillas;
        }

        public  Estructuras.Planilla ObtenerPlanilla(int id)
        {
            PlanillaCl oPlanillaCl = new PlanillaCl();
            var data = oPlanillaCl.ObtenerPlanilla(id);
            Estructuras.Planilla oPlanilla = new Estructuras.Planilla();
            oPlanilla.ID = Convert.ToInt32(data.Tables[0].Rows[0]["id"]);
            oPlanilla.Nombre = data.Tables[0].Rows[0]["nombre"].ToString();
            oPlanilla.Fecha=Convert.ToDateTime(data.Tables[0].Rows[0]["fecha"]);

            return oPlanilla;
        }
        public string InsertarPlanillaEmpleado(IEnumerable<Estructuras.PlanillaEmpleado> planillaempleado)
        {
            PlanillaCl oPlanillaCl = new PlanillaCl();
            oPlanillaCl.InsertarPlanillaEmpleado(planillaempleado);
            if (oPlanillaCl.IsError)
            {
                return "Error " + oPlanillaCl.ErrorDescripcion;
            }
            else
            {
                return "Planilla editada correctamente";
            }
        }
    }
}
