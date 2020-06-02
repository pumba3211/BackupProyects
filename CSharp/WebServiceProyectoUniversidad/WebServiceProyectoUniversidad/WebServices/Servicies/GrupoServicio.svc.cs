using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "GrupoServicio" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione GrupoServicio.svc o GrupoServicio.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class GrupoServicio : IGrupoServicio
    {
        Logica.Metodos.AdministrativoCL oAdmninistrativoCl = new Logica.Metodos.AdministrativoCL();
        Logica.Metodos.ProfesorCl oProfesorCl = new Logica.Metodos.ProfesorCl();
        Logica.Metodos.AulaCl oAulaCl = new Logica.Metodos.AulaCl();
        Logica.Metodos.CarreraCl oCarreraCl = new Logica.Metodos.CarreraCl();
        Logica.Metodos.GrupoCl oGrupoCl = new Logica.Metodos.GrupoCl();
        public string InsertarGrupo(Estructuras.Grupo Grupo, Estructuras.Adminstrador Administrador)
        {
            string mensaje="";
            if(oAdmninistrativoCl.ValidarSession(Administrador.Username,Administrador.password))
            {
                if (oCarreraCl.CarreraRepetida(Grupo.ID_Carrera))
                {
                    Estructuras.Carrera oCarrera = new Estructuras.Carrera();
                    var data = oCarreraCl.ObtenerCarrera(Grupo.ID_Carrera);
                    oCarrera.Estado = Convert.ToInt32(data.Tables[0].Rows[0]["estado"]);
                    if (oCarrera.Estado == 0)
                    {
                        if (oProfesorCl.ProfesorRepetido(Grupo.ID_Profesor))
                        {
                            if (oAulaCl.AulaRepetida(Grupo.ID_Aula))
                            {
                                oGrupoCl.InsertarGrupo(Grupo.ID_Carrera, Grupo.ID_Profesor, Grupo.ID_Aula);
                                if (oGrupoCl.IsError)
                                {
                                    mensaje = oGrupoCl.ErrorDescripcion;
                                }
                                else
                                {
                                    mensaje = "Grupo agregado correctamente";
                                }
                            }
                            else
                            {
                                mensaje = "El aula digitada no existe";
                            }
                        }
                        else
                        {
                            mensaje = "El profesor digitado no existe";
                        }
                    }
                    else
                    {
                        mensaje = "La carrera digitada no esta disponible";
                    }
                }
                else
                {
                    mensaje = "La carrera digitada no existe";
                }
            }
            else
            {
                mensaje="Fallo al inicio de sesion";
            }
            return mensaje;
        }

        public string Modificargrupo(Estructuras.Grupo Grupo, Estructuras.Adminstrador Administrador)
        {
            string mensaje = "";
            if (oAdmninistrativoCl.ValidarSession(Administrador.Username, Administrador.password))
            {
                if (oGrupoCl.GrupoRepetido(Grupo.ID_Grupo))
                {
                    if (oCarreraCl.CarreraRepetida(Grupo.ID_Carrera))
                    {
                        Estructuras.Carrera oCarrera = new Estructuras.Carrera();
                        var data = oCarreraCl.ObtenerCarrera(Grupo.ID_Carrera);
                        oCarrera.Estado = Convert.ToInt32(data.Tables[0].Rows[0]["estado"]);
                        if (oCarrera.Estado == 0)
                        {
                            if (oProfesorCl.ProfesorRepetido(Grupo.ID_Profesor))
                            {
                                if (oAulaCl.AulaRepetida(Grupo.ID_Aula))
                                {
                                    oGrupoCl.ModoficarGrupo(Grupo.ID_Grupo, Grupo.ID_Carrera, Grupo.ID_Profesor, Grupo.ID_Aula);
                                    if (oGrupoCl.IsError)
                                    {
                                        mensaje = oGrupoCl.ErrorDescripcion;
                                    }
                                    else
                                    {
                                        mensaje = "Grupo modificado correctamente";
                                    }
                                }
                                else
                                {
                                    mensaje = "El id de aula no existe";
                                }
                            }
                            else
                            {
                                mensaje = "El id del profesor no existe";
                            }
                        }
                        else
                        {
                            mensaje = "La carrera digitada no esta activa";
                        }
                    }
                    else
                    {
                        mensaje = "El codigo de carrera no existe";
                    }
                }
                else
                {
                    mensaje = "El id de grupo no existe";
                }
            }
            else
            {
                mensaje = "Fallo e inicio de sesion";
            }
            return mensaje;
        }

        public string EliminarGrupo(int id_grupo, Estructuras.Adminstrador Administrador)
        {
            string mensaje = "";
            if (oAdmninistrativoCl.ValidarSession(Administrador.Username, Administrador.password))
            {
                if (oGrupoCl.GrupoRepetido(id_grupo))
                {
                    oGrupoCl.EliminarGrupo(id_grupo);
                    if (oGrupoCl.IsError)
                    {
                        mensaje = oGrupoCl.ErrorDescripcion;
                    }
                    else
                    {
                        mensaje = "Grupo Eliminado correctamente";
                    }
                }
                else
                {
                    mensaje = "El grupo no existe";
                }
            }
            else
            {
                mensaje = "Fallo al inicio de sesion";
            }
            return mensaje;
        }

        public IEnumerable<Estructuras.Grupo_Entero> CargarGrupos(string filtro)
        {
            List<Estructuras.Grupo_Entero> Grupos = new List<Estructuras.Grupo_Entero>();
            var data = oGrupoCl.CargarGrupos(filtro);
            if (oGrupoCl.IsError)
            {
                return null;
            }
            foreach (DataRow item in data.Tables[0].Rows)
            {
                Grupos.Add(new Estructuras.Grupo_Entero()
                {
                   ID_Grupo=Convert.ToInt32(item["id_grupo"]),
                   ID_Carrera=Convert.ToInt32(item["id_carrera"]),
                   Nombre_Carrera=item["nombre_carrera"].ToString(),
                   ID_Profesor=Convert.ToInt32(item["id_profesor"]),
                    Nombre=item["nombre"].ToString(),
                    ID_Aula=Convert.ToInt32(item["id_aula"]),
                    Nombre_Aula=item["nombre_aula"].ToString(),                        
                });
            }
            return Grupos;
        }

        public Estructuras.Grupo_Entero ObtenerGrupo(int id_grupo)
        {
            Estructuras.Grupo_Entero Grupo = new Estructuras.Grupo_Entero();
            if (oGrupoCl.GrupoRepetido(id_grupo))
            {
                var data = oGrupoCl.ObtenerGrupo(id_grupo);
                Grupo.ID_Grupo = Convert.ToInt32(data.Tables[0].Rows[0]["id_grupo"]);
                Grupo.ID_Carrera = Convert.ToInt32(data.Tables[0].Rows[0]["id_carrera"]);
                Grupo.Nombre_Carrera = data.Tables[0].Rows[0]["nombre_carrera"].ToString();
                Grupo.ID_Profesor = Convert.ToInt32(data.Tables[0].Rows[0]["id_profesor"]);
                Grupo.Nombre = data.Tables[0].Rows[0]["nombre"].ToString();
                Grupo.ID_Aula = Convert.ToInt32(data.Tables[0].Rows[0]["id_aula"]);
                Grupo.Nombre_Aula = data.Tables[0].Rows[0]["nombre_aula"].ToString();

            }
            else
            {

            }
            return Grupo;
        }
    }
}
