using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AulaService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AulaService.svc o AulaService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AulaService : IAulaService
    {
        Logica.Metodos.AdministrativoCL oAdministradorSql = new Logica.Metodos.AdministrativoCL();
        Logica.Metodos.AulaCl oAulaCl = new Logica.Metodos.AulaCl();
        public string InsertarAula(string nombre, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            if (oAdministradorSql.ValidarSession(administrador.Username, administrador.password))
            {
                oAulaCl.InsertarAula(nombre);
                if (oAulaCl.IsError)
                {
                    mensaje = oAulaCl.ErrorDescripcion;
                }
                else
                {
                    mensaje = "Aula agregada correctamente";
                }
            }
            else
            {
                mensaje = "Fallo al inicio de sesion";
            }
            return mensaje;
        }
        public string ModificarAula(Estructuras.Aula aula, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            if (oAdministradorSql.ValidarSession(administrador.Username, administrador.password))
            {

                if (oAulaCl.AulaRepetida(aula.ID_Aula))
                {
                    oAulaCl.ModificarAula(aula.ID_Aula, aula.Nombre_Aula);
                    if (oAulaCl.IsError)
                    {
                        mensaje = oAulaCl.ErrorDescripcion;
                    }
                    else
                    {
                        mensaje = "Aula modificada correctamente";
                    }
                }
                else
                {
                    mensaje = "El numero de aula no existe";
                }
            }
            else
            {
                mensaje = "Fallo al inicio de sesion";
            }

            return mensaje;
        }
        public string EliminarAula(int ID_Aula, Estructuras.Adminstrador administrador)
        {
            string mensaje = "";
            if (oAdministradorSql.ValidarSession(administrador.Username, administrador.password))
            {

                if (oAulaCl.AulaRepetida(ID_Aula))
                {
                    oAulaCl.EliminarAula(ID_Aula);
                    if (oAulaCl.IsError)
                    {
                        mensaje = oAulaCl.ErrorDescripcion;
                    }
                    else
                    {
                        mensaje = "Aula eliminada correctamente";
                    }
                }
                else
                {
                    mensaje = "El numero de aula no existe";
                }
            }
            else
            {
                mensaje = "Fallo al inicio de sesion";
            }
            return mensaje;
        }
        public IEnumerable<Estructuras.Aula> TraerAulas(string filtro)
        {
            List<Estructuras.Aula> Aulas = new List<Estructuras.Aula>();
            var data = oAulaCl.ObtenerAulas(filtro);
            if (oAdministradorSql.IsError)
            {
                return null;
            }
            foreach (DataRow item in data.Tables[0].Rows)
            {
                Aulas.Add(new Estructuras.Aula()
                {
                    ID_Aula = Convert.ToInt32(item["id_aula"]),
                    Nombre_Aula = item["nombre_aula"].ToString(),
                });
            }
            return Aulas;
        }

        public Estructuras.Aula ObtenerAula(int ID_Aula)
        {
            Estructuras.Aula oAula = new Estructuras.Aula();
            if (oAulaCl.AulaRepetida(ID_Aula))
            {
                var data = oAulaCl.ObtenerAula(ID_Aula);
                oAula.ID_Aula = Convert.ToInt32(data.Tables[0].Rows[0]["id_aula"]);
                oAula.Nombre_Aula = data.Tables[0].Rows[0]["nombre_aula"].ToString();
            }
            else
            {

            }
            return oAula;
        }
    }
}
