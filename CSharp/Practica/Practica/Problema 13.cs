using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Problema_13
    {
        public String Cedula(String Cedula)
        {
            char[] cedula = new char[9];
            if (Cedula.Length == 9)
            {
                for (int i = 0; i < Cedula.Length; i++)
                {
                    cedula[i] = Cedula[i];
                }
                Cedula = "";
                for (int i = 0; i < cedula.Length; i++)
                {
                    if (i == 1 || i == 5)
                    {
                        Cedula = Cedula + "-" + cedula[i];
                    }
                    else
                    {
                        Cedula = Cedula + cedula[i];
                    }
                }
            }
            else
            {
                Console.WriteLine("Digite una cedula de 9 caracteres");
            }
            return (Cedula);
        }
    }
}
