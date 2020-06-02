using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class problema11
    {
        public String Palindromo(String Frase)
        {
            String resultado = "";
            string palabra=Frase.ToLower();
            String comparcion = "";
            int contfinal = Frase.Length-1;
            while (contfinal >= 0)
            {
                
                comparcion = comparcion + palabra[contfinal];
                contfinal--;
            }
            if (palabra == comparcion)
            {
                resultado = "Si es palindromo";
            }
            else
            {
                resultado = "Sea bestia escriba un palindramo";
            }
            return resultado;
        }
    }
}
