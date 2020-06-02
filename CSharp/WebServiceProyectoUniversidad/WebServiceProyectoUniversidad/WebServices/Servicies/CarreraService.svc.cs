using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CarreraService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CarreraService.svc o CarreraService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CarreraService : ICarreraService
    {

        public string InsertarCarrera(Estructuras.Carrera carrera, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            Logica.Metodos.CarreraCl oCarreraCl = new Logica.Metodos.CarreraCl();
            Logica.Metodos.AdministrativoCL oAdministrativoCl = new Logica.Metodos.AdministrativoCL();
            if (oAdministrativoCl.ValidarSession(administrador.Username, administrador.password))
            {
                if (oCarreraCl.CarreraRepetida(carrera.ID_Carrera))
                {
                    mensaje = "El codigo digitado ya esta reservado para una carrera";
                }
                else
                {
                    oCarreraCl.InsertarCarrera(carrera.ID_Carrera, carrera.Nombre_Carrera, carrera.Estado);
                    if (oCarreraCl.IsError)
                    {
                        mensaje = oCarreraCl.ErrorDescripcion;
                    }
                    mensaje = mensaje+" Carrera agregada correctamente";
                }
            }
            else
            {
                mensaje = "Fallo al inicio del usuario";
            }
            return mensaje;
        }

        public string ModificarCarrera(Estructuras.Carrera carrera, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            Logica.Metodos.CarreraCl oCarreraCl = new Logica.Metodos.CarreraCl();
            Logica.Metodos.AdministrativoCL oAdministrativoCl = new Logica.Metodos.AdministrativoCL();
            if (oAdministrativoCl.ValidarSession(administrador.Username, administrador.password))
            {
                if (oCarreraCl.CarreraRepetida(carrera.ID_Carrera))
                {
                    oCarreraCl.ModificarCarrera(carrera.ID_Carrera, carrera.Nombre_Carrera, carrera.Estado);
                    if (oCarreraCl.IsError)
                    {
                        mensaje = oCarreraCl.ErrorDescripcion;
                    }
                    else
                    {
                        mensaje = "Carrera Modificada correctamente";
                    }
                }
                else
                {
                    mensaje = "No se encontro el codigo de carrera digitado";
                }
            }
            else
            {
                mensaje = "Fallo al inicio del usuario";
            }
            return mensaje;
        }

        public string EliminarCarrera(int id_carrera, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            Logica.Metodos.CarreraCl oCarreraCl = new Logica.Metodos.CarreraCl();
            Logica.Metodos.AdministrativoCL oAdministrativoCl = new Logica.Metodos.AdministrativoCL();
            if (oAdministrativoCl.ValidarSession(administrador.Username, administrador.password))
            {
                if (oCarreraCl.CarreraRepetida(id_carrera))
                {
                    oCarreraCl.EliminarCarrera(id_carrera);
                    mensaje = "Carrera Modificada correctamente";
                }
                else
                {
                    mensaje = "No se encontro el codigo de carrera digitado";
                }
            }
            else
            {
                 mensaje = "Fallo al inicio del usuario";
            }
            return mensaje;
        }

        public IEnumerable<Estructuras.Carrera> TraerCarreras(string filtro)
        {
            List<Estructuras.Carrera> Carreras = new List<Estructuras.Carrera>();
            Logica.Metodos.CarreraCl oCarreraCl = new Logica.Metodos.CarreraCl();
            var data = oCarreraCl.ObtenerCarreras(filtro);
            if (oCarreraCl.IsError)
            {
                return null;
            }
            foreach (DataRow item in data.Tables[0].Rows)
            {
                Carreras.Add(new Estructuras.Carrera()
                {
                    ID_Carrera= Convert.ToInt32(item["id_carrera"]),
                    Nombre_Carrera = item["nombre_carrera"].ToString(),
                    Estado=Convert.ToInt32(item["estado"]),
               });
            }
            return Carreras;
        }

        public Estructuras.Carrera ObtenerCarrera(int id_carrera)
        {
            Logica.Metodos.CarreraCl oCarreraCl = new Logica.Metodos.CarreraCl();
            Estructuras.Carrera oCarrera = new Estructuras.Carrera();
            if (oCarreraCl.CarreraRepetida(id_carrera))
            {
                var data = oCarreraCl.ObtenerCarrera(id_carrera);
                oCarrera.ID_Carrera = Convert.ToInt32(data.Tables[0].Rows[0]["id_carrera"]);
                oCarrera.Nombre_Carrera = data.Tables[0].Rows[0]["nombre_carrera"].ToString();
                oCarrera.Estado =Convert.ToInt32( data.Tables[0].Rows[0]["estado"].ToString());
               
            }
            else
            {

            }
            return oCarrera;
        }
    }
}
