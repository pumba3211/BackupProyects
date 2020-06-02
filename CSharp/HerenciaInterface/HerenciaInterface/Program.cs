using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersona oPersona = new Estudiante();
            Estudiante oEstudiante;
            oPersona.setID(12);
            oPersona.setNombre("Ronald");
            oPersona.setApellidos("Acuña Arias");
            Console.WriteLine(oPersona.ToString());

            oEstudiante = (Estudiante)oPersona;
            oEstudiante.Calificaciones=79;
            oEstudiante.Notas="Este estudianete habla mucho";
         
            Console.WriteLine(oPersona.ToString() + "es estudiante, la calificacions es la siguiente "+oEstudiante.Calificaciones+
                " y la nota personal es: "+oEstudiante.Notas);

            Console.ReadLine();
        }
       }
 }

