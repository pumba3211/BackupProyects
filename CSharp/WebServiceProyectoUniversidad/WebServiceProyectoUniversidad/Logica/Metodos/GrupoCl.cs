using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebServiceProyectoUniversidad.Logica.Metodos
{
    public class GrupoCl
    {
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
        public SQL.IGrupoSQL ObtenerInstancia()
        {
            SQL.IGrupoSQL GrupoSQL = new Logica.Postgress.GrupoPostgress();
            return GrupoSQL;
        }
        public void InsertarGrupo(int id_carrera,int id_profesor, int id_aula)
        {
            SQL.IGrupoSQL GrupoSQL = this.ObtenerInstancia();
            GrupoSQL.InsertarGrupo(id_carrera, id_profesor, id_aula);
            if (GrupoSQL.IsError)
            {
                this.ErrorDescripcion = GrupoSQL.ErrorDescripcion;
                this.IsError = GrupoSQL.IsError;
            }
        }
        public void ModoficarGrupo(int id_grupo,int id_carrera, int id_profesor, int id_aula)
        {
            SQL.IGrupoSQL GrupoSQL = this.ObtenerInstancia();
            GrupoSQL.ModificarGrupo(id_grupo, id_carrera, id_profesor, id_aula);
            if (GrupoSQL.IsError)
            {
                this.ErrorDescripcion = GrupoSQL.ErrorDescripcion;
                this.IsError = GrupoSQL.IsError;
            }
        }
        public void EliminarGrupo(int id_grupo)
        {
            SQL.IGrupoSQL GrupoSQL = this.ObtenerInstancia();
            GrupoSQL.EliminarGrupo(id_grupo);
            if (GrupoSQL.IsError)
            {
                this.ErrorDescripcion = GrupoSQL.ErrorDescripcion;
                this.IsError = GrupoSQL.IsError;
            }
        }
        public DataSet CargarGrupos(string filtro)
        {
            SQL.IGrupoSQL GrupoSQL = this.ObtenerInstancia();
            DataSet datos = GrupoSQL.CargarGrupos(filtro);
            if (GrupoSQL.IsError)
            {
                this.ErrorDescripcion = GrupoSQL.ErrorDescripcion;
                this.IsError = GrupoSQL.IsError;
            }
            return datos;
        }
        public DataSet ObtenerGrupo(int id_grupo)
        {
            SQL.IGrupoSQL GrupoSQL = this.ObtenerInstancia();
            DataSet datos = GrupoSQL.ObtenerGrupo(id_grupo);
            if (GrupoSQL.IsError)
            {
                this.ErrorDescripcion = GrupoSQL.ErrorDescripcion;
                this.IsError = GrupoSQL.IsError;
            }
            return datos;
        }
        public bool GrupoRepetido(int id_grupo)
        {
            SQL.IGrupoSQL GrupoSQL = this.ObtenerInstancia();
            bool esta = GrupoSQL.GrupoRepetido(id_grupo);
            if (GrupoSQL.IsError)
            {
                this.ErrorDescripcion = GrupoSQL.ErrorDescripcion;
                this.IsError = GrupoSQL.IsError;
            }
            return esta;
        }
    }
}