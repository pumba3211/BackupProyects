using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Problema_8
    {
        int num;
        public int getnum()
        {
            return num;
        }

        public void setbnum(int num)
        {
            this.num = num;
        }
        public string Multiplicacion()
        {
            String resultado = "";
            for (int i = 1; i <= 15; i++)
            {
                resultado = resultado + num + "x" + i + " = " + (i * num) + "\n"; 
            }
            return resultado;
        }
    }
}
