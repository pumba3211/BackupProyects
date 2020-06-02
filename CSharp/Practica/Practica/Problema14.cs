using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Problema14
    {
        String[] arregloNumeros = new String[]{"00","01","02","03","04","05","06","07","08","09","10","11","12","13","14","15",
            "16","17","18","19","20","21","22","23","24","25","26","27"};
        String letras = " ABCDEFGHIJLKMNÑOPQRSTUVWXYZ";
        public string PalabraAnumero(String palabra)
        {
            String resultado = "";
            String palabra2 = palabra.ToUpper();
            for (int i = 0; i < palabra2.Length; i++)
            {
                for (int j = 0; j < letras.Length; j++)
                {
                    if (palabra2[i] == letras[j])
                    {
                        resultado = resultado + arregloNumeros[j];
                    }              
                }
            }
            return resultado;
        }
        public String NumeroAletras(String numero)
        {
            String resultado = "";
            if (numero.Length % 2 == 0)
            {        
                int cont = 0;
                while (cont < numero.Length-1)
                {
                    String ValorAcomparar = "" + numero[cont] + numero[cont + 1];

                    int cont2 = 0;
                    while (cont2 < arregloNumeros.Length)
                    {
                        
                        if (ValorAcomparar == arregloNumeros[cont2])
                        {
                            resultado = resultado + letras[cont2];
                        }
                        
                        cont2++;
                    }
                    cont = cont + 2;
                }
                return resultado;
            }
            else
            {
               resultado = "El numero que digitaste debe ser un numero par"; 
            }
            return resultado;
        }
      
    }
}
