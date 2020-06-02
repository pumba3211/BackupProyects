using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaSimple
{
    class Calculadora
    {
        public int a { set; get; }
        public int b { set; get; }
        public int ResultadoSumatoria()
        {
            return a + b;
        }
        public int ResultadoResta()
        {
            return a - b;
        }
    }
}
