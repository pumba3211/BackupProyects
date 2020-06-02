using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Problema5
    {
        int num;
        public int getNum()
        {
            return num;
        }

        public void setNum(int num)
        {
            this.num = num;
        }
        public String Numero()
        {

            String nombre = "";
            switch (num)
            {
                default:
                    nombre = "Fuera de rango";
                    break;
                case 1:
                    nombre = "uno";
                    break;
                case 2:
                    nombre = "dos";
                    break;
                case 3:
                    nombre = "tres";
                    break;
                case 4:
                    nombre = "cuatro";
                    break;
                case 5:
                    nombre = "cinco";
                    break;
                case 6:
                    nombre = "seis";
                    break;
                case 7:
                    nombre = "siete";
                    break;
                case 8:
                    nombre = "ocho";
                    break;
                case 9:
                    nombre = "nueve";
                    break;
                case 10:
                    nombre = "dies";
                    break;

                    
            }
            return nombre;
        }

    }
}
