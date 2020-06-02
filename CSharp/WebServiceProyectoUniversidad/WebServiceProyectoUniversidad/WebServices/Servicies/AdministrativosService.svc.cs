using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UTNProyecto.AccesoDatos;
using WebServiceProyectoUniversidad.Estructuras;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AdministrativosService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AdministrativosService.svc o AdministrativosService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AdministrativosService : IAdministrativosService
    {
        AccesoDatos accesoDatos = AccesoDatos.Instance;
        
        public string DoWork()
        {
            return accesoDatos.accesodatos.Estado();
        }


        public string InsertarAdministrador(Estructuras.Persona persona, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            if (persona.Nombre == "" || persona.Nombre == " " || persona.Apellidos == "" || persona.Apellidos == " " ||
                administrador.Username == " " || administrador.Username == "" || administrador.password == "" || administrador.password == " ")
            {
                mensaje = "Todos los espacios en los datos a la hora de ingresar deben ir completos";
            }
            else
            {
                Logica.Metodos.AdministrativoCL oAdministradorSql = new Logica.Metodos.AdministrativoCL();
                Logica.Metodos.PersonaCl oPersonaCl = new Logica.Metodos.PersonaCl();
                if (oPersonaCl.CedulaRepetida(persona.Cedula))
                {
                    mensaje = "La cedula ya esta registrada para una administrados,profesor o estudiante";
                }
                else
                {
                    if (oAdministradorSql.UsernameRepetido(administrador.Username))
                    {
                        mensaje = "Ese nombre de usuario no esta disponible";
                    }
                    else
                    {
                        oPersonaCl.InsertarPersona(persona.Cedula, persona.Nombre, persona.Apellidos);
                        if (oPersonaCl.IsError)
                        {
                            mensaje = "Error " + oPersonaCl.ErrorDescripcion;
                        }
                        else { mensaje = "Persona agregada correctamene"; }
                        oAdministradorSql.InsertarAdministrador(administrador.Username, administrador.password, persona.Cedula);
                        if (oAdministradorSql.IsError)
                        {
                            mensaje = "Error " + oAdministradorSql.ErrorDescripcion;
                        }
                        else { mensaje = mensaje + " y username agregada correctamene"; }
                    }
                }                
            }
            return mensaje;
        }

        public string CambiarClave(string Username, string ContraseñaActual, string NuevaContraseña, string RepetirContraseña)
        {
            string mensaje = "";
            if (Username == "" || Username == " " || ContraseñaActual == "" || ContraseñaActual == " " || NuevaContraseña == "" || NuevaContraseña == " "
                || RepetirContraseña == "" || RepetirContraseña == " ")
            {
                mensaje = "Todos los datos deben estar llenados verifica que esten completos";
            }
            else
            {
                Logica.Metodos.AdministrativoCL oAdministradorSql = new Logica.Metodos.AdministrativoCL();
                if (oAdministradorSql.UsernameRepetido(Username))
                {
                    if (oAdministradorSql.ValidarSession(Username, ContraseñaActual))
                    {
                        if (NuevaContraseña.Equals(RepetirContraseña))
                        {
                            oAdministradorSql.CambiarClave(Username, NuevaContraseña);
                            mensaje = "Contraseña modificada correctamente";
                        }
                        else
                        {
                            mensaje = "Las contraseñas no coinciden en los espacios de nueva contraseña y repetir contraseña";
                        }
                    }
                    else
                    {
                        mensaje = "La contraseña actual no corresponde a la contraseña de inicio";
                    }
                }
                else
                {
                    mensaje = "Ese nombre de usuario no existe";
                }               
            }
            return mensaje;
        }

        public string CambiarPropietario(string username, int cedula)
        {
            throw new NotImplementedException();
        }

        public string EliminarAdministrador(string username)
        {
            string mensaje = "";
            Logica.Metodos.AdministrativoCL oAdministradorSql = new Logica.Metodos.AdministrativoCL();
            Administrador_Persona oAdministrador_Persona = new Administrador_Persona();
            Logica.Metodos.PersonaCl oPersonaCl = new Logica.Metodos.PersonaCl();

            if (oAdministradorSql.UsernameRepetido(username))
            {
                var data = oAdministradorSql.ObtenerAdministrador(username);
                oAdministrador_Persona.Cedula = Convert.ToInt32(data.Tables[0].Rows[0]["cedula"]);               
                oAdministradorSql.EliminarAdministrador(username);
                if (oAdministradorSql.IsError)
                {
                    mensaje = oAdministradorSql.ErrorDescripcion;
                }
                oPersonaCl.EliminarPersona(oAdministrador_Persona.Cedula);
                if (oPersonaCl.IsError)
                {
                    mensaje = mensaje + oPersonaCl.ErrorDescripcion;
                }               
                
            }
            else
            {
                mensaje = "El usuario dijitado o marcado no existe";
            }


            return mensaje;
        }

        public IEnumerable<Estructuras.Administrador_Persona> TraerAdministradores(string filtro)
        {
            List<Estructuras.Administrador_Persona> Administradores = new List<Estructuras.Administrador_Persona>();
            Logica.Metodos.AdministrativoCL oAdministradorSql = new Logica.Metodos.AdministrativoCL();
            var data = oAdministradorSql.CargarAdministrativos(filtro);
            if (oAdministradorSql.IsError)
            {
                return null;
            }
            foreach (DataRow item in data.Tables[0].Rows)
            {
                Administradores.Add(new Administrador_Persona()
                {
                    Cedula = Convert.ToInt32(item["cedula"]),                   
                    Nombre = item["nombre"].ToString(),
                    Apellidos = item["apellidos"].ToString(),
                    Username=item["username"].ToString(),
                });
            }
            return Administradores;
        }

        public Estructuras.Administrador_Persona ObtenerAdministrador(string username)
        {
            Logica.Metodos.AdministrativoCL oAdministradorSql = new Logica.Metodos.AdministrativoCL();
            Administrador_Persona oAdministrador_Persona = new Administrador_Persona();
            if (oAdministradorSql.UsernameRepetido(username))
            {
                var data = oAdministradorSql.ObtenerAdministrador(username);              
                oAdministrador_Persona.Cedula = Convert.ToInt32(data.Tables[0].Rows[0]["cedula"]);
                oAdministrador_Persona.Nombre = data.Tables[0].Rows[0]["nombre"].ToString();
                oAdministrador_Persona.Apellidos = data.Tables[0].Rows[0]["apellidos"].ToString();
                oAdministrador_Persona.Username = data.Tables[0].Rows[0]["username"].ToString();              
            }
            else
            {
                
            }
            return oAdministrador_Persona;
        }


        public bool ValidarSesion(string username, string password)
        {
             Logica.Metodos.AdministrativoCL oAdministradorSql = new Logica.Metodos.AdministrativoCL();
             bool conexion = oAdministradorSql.ValidarSession(username, password);
             return conexion;
            
        }
    }
}
