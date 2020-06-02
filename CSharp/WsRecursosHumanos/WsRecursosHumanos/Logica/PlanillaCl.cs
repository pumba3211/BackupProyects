using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WsRecursosHumanos.AccesoDatos;
using WsRecursosHumanos.Logica.SQL;

namespace WsRecursosHumanos.Logica
{
    public class PlanillaCl
    {
        public Boolean IsError { set; get; }
        public String ErrorDescripcion { set; get; }

        public IPlanillaSQL ObtenerInstancia()
        {
            IPlanillaSQL planillaSql = null;
            switch (AccesoDatos.AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.SqlServer:
                    break;
                case ContextDataBase.PostgreSql:
                    planillaSql = new Postgres.PlanillaPostgress();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return planillaSql;
        }
        public void InsertarPlanilla(string nombre, DateTime fecha)
        {
            IPlanillaSQL planillasql = this.ObtenerInstancia();
            planillasql.InsertarPlanilla(nombre, fecha);
            if (planillasql.IsError)
            {
                this.IsError = planillasql.IsError;
                this.ErrorDescripcion = planillasql.ErrorDescripcion;
            }
        }
        public void ModificarPlanilla(int id, string nombre, DateTime fecha)
        {
            IPlanillaSQL planillasql = this.ObtenerInstancia();
            planillasql.EditarPlanilla(id, nombre, fecha);
            if (planillasql.IsError)
            {
                this.IsError = planillasql.IsError;
                this.ErrorDescripcion = planillasql.ErrorDescripcion;
            }
        }
        public DataSet TraerPlanillas(string filtro)
        {
            IPlanillaSQL planillasql = this.ObtenerInstancia();
            DataSet datos = planillasql.TraerPlanilla(filtro);
            if (planillasql.IsError)
            {
                this.IsError = planillasql.IsError;
                this.ErrorDescripcion = planillasql.ErrorDescripcion;
            }
            return datos;
        }

        public DataSet ObtenerPlanilla(int id)
        {
            IPlanillaSQL planillasql = this.ObtenerInstancia();
            DataSet datos = planillasql.ObtenerPlanilla(id);
            if (planillasql.IsError)
            {
                this.IsError = planillasql.IsError;
                this.ErrorDescripcion = planillasql.ErrorDescripcion;
            }
            return datos;
        }
        public void InsertarPlanillaEmpleado(IEnumerable<Estructuras.PlanillaEmpleado> planillaempleado)
        {
            IPlanillaSQL planillasql = this.ObtenerInstancia();
            AccesoDatos.AccesoDatos.Instance.accesoDatos.IniciarTransaccion();
            foreach (var item in planillaempleado)
            {
                planillasql.InsertarPlanillaEmpleado(item.IDplanilla, item.IDempleado, item.saldo);
                if (planillasql.IsError)
                {
                    AccesoDatos.AccesoDatos.Instance.accesoDatos.RollbackTransaccion();
                    this.IsError = planillasql.IsError;
                    this.ErrorDescripcion = planillasql.ErrorDescripcion;
                    return;
                }
                if (!planillasql.IsError)
                {
                    AccesoDatos.AccesoDatos.Instance.accesoDatos.CommitTransaccion();
                }
            }
        }
    }
}