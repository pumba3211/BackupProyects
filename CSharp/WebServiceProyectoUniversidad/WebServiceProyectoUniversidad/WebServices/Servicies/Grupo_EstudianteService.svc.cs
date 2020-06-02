using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Grupo_EstudianteService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Grupo_EstudianteService.svc o Grupo_EstudianteService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Grupo_EstudianteService : IGrupo_EstudianteService
    {
        Logica.Metodos.Grupo_EstudianteCl oGrupo_EstudianteCl = new Logica.Metodos.Grupo_EstudianteCl();
        Logica.Metodos.AdministrativoCL oAdministrativoCl = new Logica.Metodos.AdministrativoCL();
        Logica.Metodos.GrupoCl oGrupoCl = new Logica.Metodos.GrupoCl();
        Logica.Metodos.EstudianteCL oEstudcianteCl = new Logica.Metodos.EstudianteCL();
        public string InsertarRegistro(Estructuras.Grupo_Estudiante grupo_estudiante,Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            if (oAdministrativoCl.ValidarSession(administrador.Username, administrador.password))
            {
                if (oGrupoCl.GrupoRepetido(grupo_estudiante.ID_Grupo))
                {
                    if (oEstudcianteCl.EstudianteRepetido(grupo_estudiante.ID_Estudiante))
                    {
                        if (oGrupo_EstudianteCl.EstudianteEnGrupo(grupo_estudiante.ID_Grupo, grupo_estudiante.ID_Estudiante))
                        {
                            mensaje = "Ese estudiante ya esta en ese grupo ";
                        }
                        else
                        {                           
                            oGrupo_EstudianteCl.InsertarEstudianteGrupo(grupo_estudiante.ID_Grupo, grupo_estudiante.ID_Estudiante);
                            if (oGrupo_EstudianteCl.IsError)
                            {
                                mensaje = oGrupo_EstudianteCl.ErrorDescripcion;
                            }
                            else
                            {
                                mensaje = "El registro se ha insertado correctamente";
                            }
                        }
                    }
                    else
                    {
                        mensaje = "El codigo de estudiante no existe";
                    }
                }
                else
                {
                    mensaje = "El codigo de grupo no existe";
                }
            }
            else 
            {
                mensaje = "Fallo al inicio de sesion";
            }
            return mensaje;
        }

        public string ModificarRegistro(Estructuras.Grupo_Estudiante grupo_estudiante, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            if (oAdministrativoCl.ValidarSession(administrador.Username, administrador.password))
            {
                if (oGrupo_EstudianteCl.ExisteRegistro(grupo_estudiante.N_Registro))
                {
                    if (oGrupoCl.GrupoRepetido(grupo_estudiante.ID_Grupo))
                    {
                        if (oEstudcianteCl.EstudianteRepetido(grupo_estudiante.ID_Estudiante))
                        {

                            oGrupo_EstudianteCl.ModificarEstudianteGrupo(grupo_estudiante.N_Registro, grupo_estudiante.ID_Grupo, grupo_estudiante.ID_Estudiante);
                            if (oGrupo_EstudianteCl.IsError)
                            {
                                mensaje = oGrupo_EstudianteCl.ErrorDescripcion;
                            }
                            else
                            {
                                mensaje = "El registro se ha modificado correctamente";
                            }
                        }
                        else
                        {
                            mensaje = "El codigo de estudiante no existe";
                        }
                    }
                    else
                    {
                        mensaje = "El codigo de grupo no existe";
                    }
                }
                else
                {
                    mensaje = "El registro no se encontro";
                }
            }
            else
            {
                mensaje = "Fallo al inicio de sesion";
            }
            return mensaje;
        }

        public string EliminarRegistro(int n_registro, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            if (oAdministrativoCl.ValidarSession(administrador.Username, administrador.password))
            {
                if (oGrupo_EstudianteCl.ExisteRegistro(n_registro))
                {
                    oGrupo_EstudianteCl.EliminarRegistro(n_registro);
                    if (oGrupo_EstudianteCl.IsError)
                    {
                        mensaje = oGrupo_EstudianteCl.ErrorDescripcion;
                    }
                    else
                    {
                        mensaje = "Registro eliminado correctamente";
                    }
                }
                else
                {
                    mensaje = "El registro no existe";
                }
            }
            else
            {
                mensaje = "Fallo al inicio de sesion";
            }
            return mensaje;
        }

        public IEnumerable<Estructuras.Grupo_Estudiantes> EstudiantesGrupo(int id_grupo)
        {
            List<Estructuras.Grupo_Estudiantes> EstudiantesEnGrupo = new List<Estructuras.Grupo_Estudiantes>();
            var data = oGrupo_EstudianteCl.CargarEstudiantesengrupo(id_grupo);
            if (oGrupo_EstudianteCl.IsError)
            {
                return null;
            }
            foreach (DataRow item in data.Tables[0].Rows)
            {
                EstudiantesEnGrupo.Add(new Estructuras.Grupo_Estudiantes()
                {
                    ID_Grupo = Convert.ToInt32(item["id_grupo"]),
                    ID_Estudiante= Convert.ToInt32(item["id_estudiante"]),
                    Cedula = Convert.ToInt32(item["cedula"]),
                    Nombre = item["nombre"].ToString(),
                    Apellidos = item["apellidos"].ToString(),
                });
            }
            return EstudiantesEnGrupo;
        }
    }
}
