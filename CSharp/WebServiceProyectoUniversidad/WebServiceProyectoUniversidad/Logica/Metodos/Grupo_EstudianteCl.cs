using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebServiceProyectoUniversidad.Logica.Metodos
{
    public class Grupo_EstudianteCl
    {
        public SQL.IGrupo_Estudiante ObtenerInstancia()
        {
            SQL.IGrupo_Estudiante Grupo_Estudiantesql = new Logica.Postgress.Grupo_EstudiantePostgress();
            return Grupo_Estudiantesql ;
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
        public void InsertarEstudianteGrupo(int id_grupo, int id_estudiante)
        {
            SQL.IGrupo_Estudiante Grupo_EstudianteSQL = this.ObtenerInstancia();
            Grupo_EstudianteSQL.InsertarEstudianteGrupo(id_grupo, id_estudiante);
            if (Grupo_EstudianteSQL.IsError)
            {
                this.IsError = Grupo_EstudianteSQL.IsError;
                this.ErrorDescripcion = Grupo_EstudianteSQL.ErrorDescripcion;
            }
        }
        public void ModificarEstudianteGrupo(int n_registro, int id_grupo, int id_estudiante)
        {
            SQL.IGrupo_Estudiante Grupo_EstudianteSQL = this.ObtenerInstancia();
            Grupo_EstudianteSQL.ModificarEstudianteGrupo(n_registro,id_grupo, id_estudiante);
            if (Grupo_EstudianteSQL.IsError)
            {
                this.IsError = Grupo_EstudianteSQL.IsError;
                this.ErrorDescripcion = Grupo_EstudianteSQL.ErrorDescripcion;
            }
        }
        public void EliminarRegistro(int n_registro)
        {
            SQL.IGrupo_Estudiante Grupo_EstudianteSQL = this.ObtenerInstancia();
            Grupo_EstudianteSQL.EliminarRegistro(n_registro);
            if (Grupo_EstudianteSQL.IsError)
            {
                this.IsError = Grupo_EstudianteSQL.IsError;
                this.ErrorDescripcion = Grupo_EstudianteSQL.ErrorDescripcion;
            }
        }
        public System.Data.DataSet CargarEstudiantesengrupo(int id_grupo)
        {
            SQL.IGrupo_Estudiante Grupo_EstudianteSQL = this.ObtenerInstancia();
            DataSet datos = Grupo_EstudianteSQL.CargarEstudiantesengrupo(id_grupo);
            if (Grupo_EstudianteSQL.IsError)
            {
                this.IsError = Grupo_EstudianteSQL.IsError;
                this.ErrorDescripcion = Grupo_EstudianteSQL.ErrorDescripcion;
            }
            return datos;
        }
        public DataSet CargarRegistros(string filtro)
        {

            SQL.IGrupo_Estudiante Grupo_EstudianteSQL = this.ObtenerInstancia();
            DataSet datos = Grupo_EstudianteSQL.CargarRegistros(filtro);
            if (Grupo_EstudianteSQL.IsError)
            {
                this.IsError = Grupo_EstudianteSQL.IsError;
                this.ErrorDescripcion = Grupo_EstudianteSQL.ErrorDescripcion;
            }
            return datos;
        }
        public bool ExisteRegistro(int n_registro)
        {
            SQL.IGrupo_Estudiante Grupo_EstudianteSQL = this.ObtenerInstancia();
            bool esta = Grupo_EstudianteSQL.ExisteRegistro(n_registro);
            if (Grupo_EstudianteSQL.IsError)
            {
                this.IsError = Grupo_EstudianteSQL.IsError;
                this.ErrorDescripcion = Grupo_EstudianteSQL.ErrorDescripcion;
            }
            return esta;
        }
        public bool EstudianteEnGrupo(int id_grupo, int id_estudiante)
        {
            SQL.IGrupo_Estudiante Grupo_EstudianteSQL = this.ObtenerInstancia();
            bool esta = Grupo_EstudianteSQL.EstudianteEnGrupo(id_grupo, id_estudiante);
            if (Grupo_EstudianteSQL.IsError)
            {
                this.IsError = Grupo_EstudianteSQL.IsError;
                this.ErrorDescripcion = Grupo_EstudianteSQL.ErrorDescripcion;
            }
            return esta;
        }
    }
}