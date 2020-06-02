using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Problema12
    {
        String[] arregloCentenas = new String[] { "  ", "cien", "doscientos", "trecientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };
        String[] arrreglodecenas = new String[] { " " + "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
        String[] arreglonumeros = new String[] { " " + "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
        String[] arreglonumeros2 = new String[] { "once", "doce", "trece", "catorce", "quince" };

        public String NumeroEnLetras(String Cantidad)
        {
            String resultado = "";
            if (Cantidad.Length == 3)
            {
                String cent = "" + Cantidad[0];
                String des = "" + Cantidad[1];
                String num = "" + Cantidad[2];
                int desenas = Convert.ToInt32(des);
                int numeros = Convert.ToInt32(num);
                int centenas = Convert.ToInt32(cent);
                resultado = resultado + arregloCentenas[centenas];
                if (desenas == 0 && numeros == 0)
                {
                    return resultado;
                }
                else
                {

                    if (desenas == 1)
                    {
                        if (numeros == 0)
                        {
                            resultado = resultado + "  " + arrreglodecenas[1];
                        }

                        else if (numeros == 1)
                        {
                            resultado = resultado + " " + arreglonumeros2[0];
                        }
                        else if (numeros == 2)
                        {
                            resultado = resultado + " " + arreglonumeros2[1];
                        }
                        else if (numeros == 3)
                        {
                            resultado = resultado + " " + arreglonumeros2[2];
                        }
                        else if (numeros == 4)
                        {
                            resultado = resultado + " " + arreglonumeros2[3];
                        }
                        else if (numeros == 5)
                        {
                            resultado = resultado + " " + arreglonumeros2[4];
                        }
                        else
                        {
                            resultado = resultado + "  " + arrreglodecenas[1] + " y " + arreglonumeros[numeros - 1];
                        }

                    }
                    else
                    {
                        if (numeros == 0)
                        {
                            resultado = resultado + "  " + arrreglodecenas[desenas - 1];
                        }
                        else
                        {
                            resultado = resultado + "  " + arrreglodecenas[desenas - 1] + " y " + arreglonumeros[numeros - 1];
                        }
                    }
                }
            }
            else
            {
                resultado = "A digitado una cantidad de mas de tres cifras";
            }
                return (resultado);

        }
    }
}
