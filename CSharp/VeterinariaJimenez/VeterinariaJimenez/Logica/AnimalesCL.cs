using System;
using System.Data;
using VeterinariaJimenez.AccesoDatos;
using VeterinariaJimenez.Logica.Postgrest;
using VeterinariaJimenez.Logica.SQL;
using VeterinariaJimenez.Logica.SQLServer;

namespace VeterinariaJimenez.Logica
{
    public class AnimalesCL
    {
        public Boolean IsError { set; get; }
        public String ErrorDescripcion { set; get; }

        public IAnimalesSql ObtenerInstancia()
        {
            IAnimalesSql animalesSql = null;
            switch (AccesoDatos.AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.SqlServer:
                    animalesSql = new AnimalesSQLServer();
                    break;
                case ContextDataBase.PostgreSql:
                   animalesSql = new AnimalesPostgres();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return animalesSql;
        }


        public void InsertarAnimal(string nombre, int especie, int tipo, string dueno)
        {
            IAnimalesSql animalesSql = this.ObtenerInstancia();
            animalesSql.InsertarAnimal(nombre, especie, tipo, dueno);
            if (animalesSql.IsError)
            {
                this.IsError = animalesSql.IsError;
                this.ErrorDescripcion = animalesSql.ErrorDescripcion;
            }
        }

        public DataSet TraerAnimales(string filtro)
        {
            IAnimalesSql animalesSql = this.ObtenerInstancia();
            DataSet datos = animalesSql.TraerAnimales(filtro);
            if (animalesSql.IsError)
            {
                this.IsError = animalesSql.IsError;
                this.ErrorDescripcion = animalesSql.ErrorDescripcion;
            }
            return datos;
        }

        public void EditarAnimal(int id, string nombre, int especie, int tipo, string dueno)
        {
            IAnimalesSql animalesSql = this.ObtenerInstancia();
            animalesSql.EditarAnimal(id, nombre, especie, tipo, dueno);
            if (animalesSql.IsError)
            {
                this.IsError = animalesSql.IsError;
                this.ErrorDescripcion = animalesSql.ErrorDescripcion;
            }
        }


        public void EliminarAnimal(int id)
        {
            IAnimalesSql animalesSql = this.ObtenerInstancia();
            animalesSql.EliminarAnimal(id);
            if (animalesSql.IsError)
            {
                this.IsError = animalesSql.IsError;
                this.ErrorDescripcion = animalesSql.ErrorDescripcion;
            }
        }

    }
}
