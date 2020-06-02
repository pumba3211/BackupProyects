using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "EstudianteService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EstudianteService.svc o EstudianteService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EstudianteService : IEstudianteService
    {
        Logica.Metodos.CarreraCl oCarreraCl = new Logica.Metodos.CarreraCl();
        Logica.Metodos.EstudianteCL oEstudianteCl = new Logica.Metodos.EstudianteCL();
        Logica.Metodos.AdministrativoCL oAdministradorCl = new Logica.Metodos.AdministrativoCL();
        Logica.Metodos.PersonaCl oPersonalCl = new Logica.Metodos.PersonaCl();
        public string InsertarEstudiante(Estructuras.Persona persona, Estructuras.Estudiante estudiante, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            if (oAdministradorCl.ValidarSession(administrador.Username, administrador.password))
            {
                if (oCarreraCl.CarreraRepetida(estudiante.ID_Carrera))
                {
                    var data = oCarreraCl.ObtenerCarrera(estudiante.ID_Carrera);
                    Estructuras.Carrera oCarrera = new Estructuras.Carrera();
                    oCarrera.Estado = Convert.ToInt32(data.Tables[0].Rows[0]["estado"]);
                    if (oCarrera.Estado == 0)
                    {
                        if (oPersonalCl.CedulaRepetida(persona.Cedula))
                        {
                            mensaje = "La cedula ya esta reservada para algun administrador,estudiante o profesor";
                        }
                        else
                        {
                            if (oEstudianteCl.EstudianteRepetido(estudiante.ID_Estudiante))
                            {
                                mensaje = "El id de estudiante ya existe";
                            }
                            else
                            {
                                oPersonalCl.InsertarPersona(persona.Cedula, persona.Nombre, persona.Apellidos);
                                if (oPersonalCl.IsError)
                                {
                                    mensaje = oPersonalCl.ErrorDescripcion;
                                }
                                oEstudianteCl.InsertarEstudiante(estudiante.Fecha_nacimiento, estudiante.ID_Carrera, persona.Cedula, estudiante.Direccion);
                                if (oEstudianteCl.IsError)
                                {
                                    mensaje = mensaje + oEstudianteCl.ErrorDescripcion;
                                }
                                mensaje = "Estudiante agredado correctamente";
                            }
                        }
                    }
                    else
                    {
                        mensaje = "La carrera no esta disponible";
                    }
                }
                else
                {
                    mensaje = mensaje = "El codigo de carrera no es valido";
                }
            }
            else
            {
                mensaje = "Fallo al inicio de session";
            }
            return mensaje;
        }

        public string ModificarEstudiante(Estructuras.Persona persona, Estructuras.Estudiante estudiante, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            if (oAdministradorCl.ValidarSession(administrador.Username, administrador.password))
            {
                if (oCarreraCl.CarreraRepetida(estudiante.ID_Carrera))
                {
                    var data = oCarreraCl.ObtenerCarrera(estudiante.ID_Carrera);
                    Estructuras.Carrera oCarrera = new Estructuras.Carrera();
                    oCarrera.Estado = Convert.ToInt32(data.Tables[0].Rows[0]["estado"]);
                    if (oCarrera.Estado == 0)
                    {
                        if (oPersonalCl.CedulaRepetida(persona.Cedula))
                        {
                            if (oEstudianteCl.EstudianteRepetido(estudiante.ID_Estudiante))
                            {
                                oPersonalCl.ModificarPersona(persona.Cedula, persona.Nombre, persona.Apellidos);
                                if (oPersonalCl.IsError)
                                {
                                    mensaje = oPersonalCl.ErrorDescripcion;
                                }
                                oEstudianteCl.ModificarEstudiante(estudiante.ID_Estudiante, estudiante.Fecha_nacimiento, estudiante.ID_Carrera, persona.Cedula, estudiante.Direccion);
                                if (oEstudianteCl.IsError)
                                {
                                    mensaje = mensaje + oEstudianteCl.ErrorDescripcion;
                                }
                                mensaje = "Estudiante modificado correctamente";
                            }
                            else
                            {
                                mensaje = "El id de estudiante no existe";
                            }
                        }
                        else
                        {
                            mensaje = "No se encontro la cedula del estudiante por favor digita una correcta";
                        }
                    }
                    else
                    {
                        mensaje = "La carrera no esta disponible";
                    }
                }
                else
                {
                    mensaje = mensaje = "El codigo de carrera no es valido";
                }
            }
            else
            {
                mensaje = "Fallo al inicio de session";
            }
            return mensaje;
        }


        public string ElminarEstudiante(int ID_Estudiante, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            if (oAdministradorCl.ValidarSession(administrador.Username, administrador.password))
            {
                if (oEstudianteCl.EstudianteRepetido(ID_Estudiante))
                {
                    Estructuras.EstudiantePerson oEstudiantePersona = new Estructuras.EstudiantePerson();
                    var data =  oEstudianteCl.ObtenerEstudiante(ID_Estudiante);
                    oEstudiantePersona.Cedula = Convert.ToInt32(data.Tables[0].Rows[0]["cedula"]);
                    oEstudianteCl.EliminarEstudiante(ID_Estudiante);
                    if (oEstudianteCl.IsError)
                    {
                        mensaje =  oEstudianteCl.ErrorDescripcion;
                    }
                    oPersonalCl.EliminarPersona(oEstudiantePersona.Cedula);
                    if (oPersonalCl.IsError)
                    {
                        mensaje = mensaje + oPersonalCl.ErrorDescripcion;
                    }
                    mensaje = mensaje + "Estudiante elimiado correctamente";
                }
                else
                {
                    mensaje = "Ese id de estudiante no existe";
                }
            }
            else
            {
                mensaje = "Fallo al inicio de sesion";
            }
            return mensaje;
        }

        public IEnumerable<Estructuras.EstudiantePerson> TraerEstudiantes(string filtro)
        {
            List<Estructuras.EstudiantePerson> Estudiantes = new List<Estructuras.EstudiantePerson>();
            var data = oEstudianteCl.CargarEstudiantes(filtro);
            if (oEstudianteCl.IsError)
            {
                return null;
            }
            foreach (DataRow item in data.Tables[0].Rows)
            {
                Estudiantes.Add(new Estructuras.EstudiantePerson()
                {
                    Cedula = Convert.ToInt32(item["cedula"]),
                    Nombre = item["nombre"].ToString(),
                    Apellidos = item["apellidos"].ToString(),
                    ID_Estudiante = Convert.ToInt32(item["id_estudiante"]),
                    Fecha_nacimiento=Convert.ToDateTime(item["fecha_nacimiento"]),
                    ID_Carrera = Convert.ToInt32(item["id_carrera"]),
                    Direccion = item["direccion"].ToString(),
                });
            }
            return Estudiantes;
        }

        public Estructuras.EstudiantePerson ObtenerEstudiante(int ID_Estudiante)
        {
            Estructuras.EstudiantePerson oEstudiantePersona = new Estructuras.EstudiantePerson();
            if (oEstudianteCl.EstudianteRepetido(ID_Estudiante))
            {
                var data = oEstudianteCl.ObtenerEstudiante(ID_Estudiante);
                oEstudiantePersona.Cedula = Convert.ToInt32(data.Tables[0].Rows[0]["cedula"]);
                oEstudiantePersona.Nombre = data.Tables[0].Rows[0]["nombre"].ToString();
                oEstudiantePersona.Apellidos = data.Tables[0].Rows[0]["apellidos"].ToString();
                oEstudiantePersona.ID_Estudiante = Convert.ToInt32(data.Tables[0].Rows[0]["id_estudiante"]);
                oEstudiantePersona.Fecha_nacimiento=Convert.ToDateTime(data.Tables[0].Rows[0]["fecha_nacimiento"]);
                oEstudiantePersona.ID_Carrera = Convert.ToInt32(data.Tables[0].Rows[0]["id_carrera"]);
                oEstudiantePersona.Direccion = data.Tables[0].Rows[0]["direccion"].ToString();
            }
            else
            {

            }
            return oEstudiantePersona;
        }
    }
}
