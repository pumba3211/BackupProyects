using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Problema10
    {
        
        String valores = "0123456789/!$&()´+-,.-?¡¿*~";
        String letras = "abcdefghijklmnñopqrstuvwxyz";

        public String Conversion(String palabra)
        {
            String Resultado = "";
            String palabra2 = palabra.ToLower();
            for (int i = 0; i < palabra2.Length; i++)
            {
                for (int j = 0; j < letras.Length; j++)
                {
                    if (palabra2[i] == letras[j])
                    {
                        Resultado=Resultado+valores[j];
                    }
                }

            }
            return Resultado;
        }
        public String Conversionletras(String palabra2)
        {
            String Resultado = "";
            
            for (int i = 0; i < palabra2.Length; i++)
            {
                for (int j = 0; j < valores.Length; j++)
                {
                    if (palabra2[i] == valores[j])
                    {
                        Resultado = Resultado + letras[j];
                    }
                }

            }
            return Resultado;
        }

    }
}
