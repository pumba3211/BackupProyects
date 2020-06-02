using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Problema9
    {
        String resultado = "";
        String minusculas = "abcdefghigjklmnñopqrstuvwxyz";
        String MAYUSCULAS="ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        public string Conversion(String palabra)
        {
            if (palabra != palabra.ToLower())
            {
                for (int i = 0; i < palabra.Length; i++)
                {
                    for (int j = 0; j < minusculas.Length; j++)
                    {
                        if (palabra[i].ToString().ToLower() == minusculas[j].ToString())
                        {
                            resultado=resultado+minusculas[j];
                        }                      
                    }
                }
            }
            else if (palabra != palabra.ToUpper())
            {
                for (int i = 0; i < palabra.Length; i++)
                {
                    for (int j = 0; j < MAYUSCULAS.Length; j++)
                    {
                        if (palabra[i].ToString().ToUpper() == MAYUSCULAS[j].ToString())
                        {
                            resultado = resultado + MAYUSCULAS[j];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i].ToString() != palabra[i].ToString().ToLower())
                    {
                        for (int j = 0; j < minusculas.Length; j++)
                        {
                            if (palabra[i].ToString().ToLower() == minusculas[j].ToString())
                            {
                                resultado = resultado + minusculas[j];
                            }
                        }
                    }
                    else
                    {
                        resultado = resultado + palabra[i];
                    }

                }
            }

            return (resultado);
        }
    }
}
