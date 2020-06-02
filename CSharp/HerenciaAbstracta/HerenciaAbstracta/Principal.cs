using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAbstracta
{
    class Principal
    {
        static void Main(string[] args)
        {
            Persona oPersona = new Profesor();
            Profesor oProfesor = null;
            oPersona.SetId(1);
            oPersona.SetNombre("Ronald");
            oPersona.SetApellido1("Acuña");
            oPersona.SetApellido2("Arias");
            Console.WriteLine(oPersona.ToString());

            oProfesor = (Profesor)oPersona;
            oProfesor.Carrera = "ISW";
            oProfesor.Cursos = "ISW 311";
            Console.WriteLine(oPersona.ToString() + " es profesor,es parte de la carrera de " + oProfesor.Carrera
            + " y imparte el curso " + oProfesor.Cursos);
            Console.ReadLine();
        }
    }
}
