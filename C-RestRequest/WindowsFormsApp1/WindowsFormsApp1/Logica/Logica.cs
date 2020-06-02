using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Structures;

namespace WindowsFormsApp1.Logica
{
    public class Logica
    {
        public Juego ObtenerJuego(HttpWebResponse response)
        {
            Juego juego = new Juego();
            try
            {
                if (ValidarResponse(response))
                {
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return juego;
        }

        public Boolean ValidarResponse(HttpWebResponse response)
        {
            bool respuesta = false;
            if (response != null)
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
