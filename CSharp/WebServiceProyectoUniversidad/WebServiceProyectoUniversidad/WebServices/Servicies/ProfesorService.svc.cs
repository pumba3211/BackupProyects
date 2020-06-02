using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ProfesorService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ProfesorService.svc o ProfesorService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ProfesorService : IProfesorService
    {
        Logica.Metodos.AdministrativoCL oAdministradorSql = new Logica.Metodos.AdministrativoCL();
        Logica.Metodos.PersonaCl oPersonaCl = new Logica.Metodos.PersonaCl();
        Logica.Metodos.CarreraCl oCarreraCL = new Logica.Metodos.CarreraCl();
        Logica.Metodos.ProfesorCl oProfesorCl = new Logica.Metodos.ProfesorCl();
        public string InsertarProfesor(Estructuras.Persona persona, Estructuras.Profesor Profesor, Estructuras.Adminstrador administrador)
        {
            string mensaje="";
            if (persona.Nombre == "" || persona.Nombre == " " || persona.Apellidos == "" || persona.Apellidos == " ")
            {

            }
            else
            {
                if (oAdministradorSql.ValidarSession(administrador.Username, administrador.password))
                {
                    if (oCarreraCL.CarreraRepetida(Profesor.ID_Carrera))
                    {
                        var data = oCarreraCL.ObtenerCarrera(Profesor.ID_Carrera);
                        Estructuras.Carrera oCarrera = new Estructuras.Carrera();
                        oCarrera.Estado = Convert.ToInt32(data.Tables[0].Rows[0]["estado"]);
                        if (oCarrera.Estado == 0)
                        {
                            if (oPersonaCl.CedulaRepetida(persona.Cedula))
                            {
                                mensaje = "La cedula ya esta reservada para algun administrador,estudiante o profesor";
                            }
                            else
                            {
                                if (oProfesorCl.ProfesorRepetido(Profesor.ID_Profesro))
                                {
                                    mensaje = "Ese codigo de profesor ya esta reservado";
                                }
                                else
                                {
                                    oPersonaCl.InsertarPersona(persona.Cedula, persona.Nombre, persona.Apellidos);
                                    if (oPersonaCl.IsError)
                                    {
                                        mensaje = oPersonaCl.ErrorDescripcion;
                                    }
                                    oProfesorCl.InsertarProfesor(Profesor.ID_Carrera, persona.Cedula);
                                    if (oProfesorCl.IsError)
                                    {
                                        mensaje = mensaje + oProfesorCl.ErrorDescripcion;
                                    }
                                    mensaje = mensaje + "Profesor agredado correctamente";
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
            }
            return mensaje;

        }

        public string ModificarProfesor(Estructuras.Persona persona, Estructuras.Profesor Profesor, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            if (persona.Nombre == "" || persona.Nombre == " " || persona.Apellidos == "" || persona.Apellidos == " ")
            {

            }
            else
            {
                if (oAdministradorSql.ValidarSession(administrador.Username, administrador.password))
                {
                    if (oCarreraCL.CarreraRepetida(Profesor.ID_Carrera))
                    {
                        var data = oCarreraCL.ObtenerCarrera(Profesor.ID_Carrera);
                        Estructuras.Carrera oCarrera = new Estructuras.Carrera();
                        oCarrera.Estado = Convert.ToInt32(data.Tables[0].Rows[0]["estado"]);
                        if (oCarrera.Estado == 0)
                        {
                            if (oPersonaCl.CedulaRepetida(persona.Cedula))
                            {
                                if (oProfesorCl.ProfesorRepetido(Profesor.ID_Profesro))
                                {
                                    oPersonaCl.ModificarPersona(persona.Cedula, persona.Nombre, persona.Apellidos);
                                    if (oPersonaCl.IsError)
                                    {
                                        mensaje = oPersonaCl.ErrorDescripcion;
                                    }
                                    oProfesorCl.ModificarProfesor(Profesor.ID_Profesro, Profesor.ID_Carrera, persona.Cedula);
                                    if (oProfesorCl.IsError)
                                    {
                                        mensaje = mensaje + oProfesorCl.ErrorDescripcion;
                                    }
                                    mensaje = mensaje + "Profesor modificado correctamente";
                                }
                                else
                                {
                                    mensaje = "No se encontro el codigo del profesor";
                                }
                            }
                            else
                            {
                               mensaje="La cedula no Existe";
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
            }
            return mensaje;
        }

        public string EliminarProfesor(int ID_Profesor, Estructuras.Adminstrador administrador)
        {
            string mensaje="";
            if (oAdministradorSql.ValidarSession(administrador.Username, administrador.password))
            {
                if (oProfesorCl.ProfesorRepetido(ID_Profesor))
                {
                    Estructuras.ProfesorPersona oProfesor_Persona = new Estructuras.ProfesorPersona();
                    var data = oProfesorCl.ObtenerProfesor(ID_Profesor);
                    oProfesor_Persona.Cedula = Convert.ToInt32(data.Tables[0].Rows[0]["cedula"]);
                    oProfesorCl.EliminarProfesor(ID_Profesor);
                    if (oProfesorCl.IsError)
                    {
                        mensaje = oProfesorCl.ErrorDescripcion;
                    }
                    oPersonaCl.EliminarPersona(oProfesor_Persona.Cedula);
                    if (oPersonaCl.IsError)
                    {
                        mensaje = mensaje + oPersonaCl.ErrorDescripcion;
                    }
                    mensaje = mensaje + "Profesor elimiado correctamente";
                }
                else
                {
                    mensaje = "Ese id de profesor no existe";
                }
            }
            else
            {
                mensaje = "Fallo al inicio de sesion";
            }
            return mensaje;
        }

        public IEnumerable<Estructuras.ProfesorPersona> TraerProfesores(string filtro)
        {
            List<Estructuras.ProfesorPersona> Profesores = new List<Estructuras.ProfesorPersona>();
            var data = oProfesorCl.TraerProfesores(filtro);
            if (oProfesorCl.IsError)
            {
                return null;
            }
            foreach (DataRow item in data.Tables[0].Rows)
            {
                Profesores.Add(new Estructuras.ProfesorPersona()
                {
                    Cedula = Convert.ToInt32(item["cedula"]),
                    Nombre = item["nombre"].ToString(),
                    Apellidos = item["apellidos"].ToString(),
                    ID_Profesro = Convert.ToInt32(item["id_profesor"]),
                    ID_Carrera = Convert.ToInt32(item["id_carrera"]),
                });
            }
            return Profesores;
        }

        public Estructuras.ProfesorPersona ObtenerProfesor(int ID_Profesor)
        {
            Estructuras.ProfesorPersona oProfesor_Persona = new Estructuras.ProfesorPersona();
            if (oProfesorCl.ProfesorRepetido(ID_Profesor))
            {
                var data = oProfesorCl.ObtenerProfesor(ID_Profesor);
                oProfesor_Persona.Cedula = Convert.ToInt32(data.Tables[0].Rows[0]["cedula"]);
                oProfesor_Persona.Nombre = data.Tables[0].Rows[0]["nombre"].ToString();
                oProfesor_Persona.Apellidos = data.Tables[0].Rows[0]["apellidos"].ToString();
                oProfesor_Persona.ID_Profesro = Convert.ToInt32(data.Tables[0].Rows[0]["id_profesor"]);
                oProfesor_Persona.ID_Carrera = Convert.ToInt32(data.Tables[0].Rows[0]["id_carrera"]);
            }
            else
            {

            }
            return oProfesor_Persona;
        }
    }
}
