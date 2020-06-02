using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVotaciones
{
    public class Votante
    {
        public String Cedula { set; get; }//IDentificador de l votante
        public string Contraseña { set; get; }
        public string Tipo { set; get; }
        public string Nombre { set; get; }
        public string Apellido1 { set; get; }
        public string Apellido2 { set; get; }
        public string ComprobarVoto { set; get; }//Se comprueba si el votante ya voto para saber si puede votar de nuevo
    }
}
