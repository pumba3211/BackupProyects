using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        enum opciones
        {
            Default,
            Problema1,
            Problema2,
            Problema3,
            Problema4,
            Problema5,
            Problema6,
            Problema7,
            Problema8,
            problema9,
            problema10,
            problema11,
            problema12,
            probelma13,
            problema14
        }
        static void Main(string[] args)
        {   
            
            bool validar = true;
            opciones opcionElegida = opciones.Default;
            Problema1 Problema1 = new Problema1();
            Problema2 Problema2 = new Problema2();
            Problema3 Problema3 = new Problema3();
            Problema5 Problema5 = new Problema5();
            Problema6 Problema6 = new Problema6();
            Problema_7 Problema7 = new Problema_7();
            Problema_8 Problema8 = new Problema_8();
            Problema9 Problema9 = new Problema9();
            Problema10 Problema10=new Problema10();
            problema11 Problema11 = new problema11();
            Problema12 Problema12 = new Problema12();
            Problema_13 Problema13 = new Problema_13();
            Problema14 Problema14=new Problema14();
            while (validar)
            {
                Console.WriteLine("Digite su opcion");
                Console.WriteLine("1  Sumatoria de numeros de 1 al 10");
                Console.WriteLine("2 Suma de Multiplicacion");
                Console.WriteLine("3 Digite 10 numero para verificar cuantos son positivos ");
                Console.WriteLine("4 Mayor y numeros iguales ");
                Console.WriteLine("5 Numeros del 1 al 10 ");
                Console.WriteLine("6 Converion de letras mayusculas y minusculas");
                Console.WriteLine("7 Ingrese su calificacion");
                Console.WriteLine("8 Digite el numero de la multiplicacion que desea calcular");
                Console.WriteLine("9 Digite el numero de la multiplicacion que desea calcular");
                Console.WriteLine("10 Digite el numero de la multiplicacion que desea calcular");
                Console.WriteLine("11 Digite el numero de la multiplicacion que desea calcular");
                Console.WriteLine("12 Digite un numero de 3 cifras para dar su nombre");
                Console.WriteLine("13 Cambiar formato a cedula");
                Console.WriteLine("14 De letras a numero y de numeros a letras");

                int opcion = Convert.ToInt32(Console.ReadLine());
                opcionElegida = (opciones)opcion;

                switch (opcionElegida)
                {
                    case opciones.Default:
                        Console.WriteLine("Ha ocurrido un error");
                        break;
                    case opciones.Problema1:                       
                        Console.WriteLine("El resultado de sumar de 1 hasta 10 es :"+Problema1.Suma());
                       
                        break;
                    case opciones.Problema2:
                        Console.WriteLine("El resultado de la multipliacion es :" + Problema2.Multiplicacion());
                        break;
                    case opciones.Problema3:
                        int[] arreglo = new int[10];
                        for (int i = 0; i < arreglo.Length; i++)
                        {
                            Console.WriteLine("Digite el numero " + (i+1));
                            int num = Convert.ToInt32(Console.ReadLine());
                            arreglo[i] = num;

                        }
                        Problema3.setArreglo(arreglo);
                        Console.WriteLine("De los numeros que digito hay : " + Problema3.resultado()+" positivos "+"\n");
                        break;

                    case opciones.Problema4:
                         int[] arreproblema4 = new int[3];
                        for (int i = 0; i < arreproblema4.Length; i++)
                        {
                            Console.WriteLine("Digite el numero " + (i+1));
                            int num = Convert.ToInt32(Console.ReadLine());
                            arreproblema4[i] = num;
                        }

                        break;
                    case opciones.Problema5:
                        Console.WriteLine("Digete un numero del 1 a l0");
                        Problema5.setNum(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine(Problema5.Numero());
                        break;
                    case opciones.Problema6:
                        Console.WriteLine("Digete su letra");
                        Problema6.setLetra(Console.ReadLine());
                        Console.WriteLine(""+Problema6.conversion());
                        break;
                    case opciones.Problema7:
                        Console.WriteLine("Digite su Calificacion en letras");
                        Problema7.setLetra(Convert.ToChar(Console.ReadLine()));
                        Console.WriteLine(""+ Problema7.Calificacion());
                        break;
                    case opciones.Problema8:
                        Console.WriteLine("Digite su numero");
                        Problema8.setbnum(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("" + Problema8.Multiplicacion());
                        break;
                    case opciones.problema9:
                        Console.WriteLine("Digite su palabra");
                        Console.WriteLine(Problema9.Conversion(Console.ReadLine()));
                        break;

                    case opciones.problema10:
                        Console.WriteLine("Digite su palabra");
                        Console.WriteLine("La palabra es: " + Problema10.Conversion(Console.ReadLine()));
                        Console.WriteLine("Digite los caracteres previos");
                        Console.WriteLine("La palabra es: " + Problema10.Conversionletras(Console.ReadLine()));
                        break;
                    case opciones.problema11:
                        Console.WriteLine("Digite una palabra");
                        Console.WriteLine(Problema11.Palindromo(Console.ReadLine()));
                        break;
                    case opciones.problema12:
                        Console.WriteLine("Digite su numero");
                        Console.WriteLine(Problema12.NumeroEnLetras(Console.ReadLine()));
                        break;
                    case opciones.probelma13:
                        Console.WriteLine("Digite su cedula");
                        Console.WriteLine(Problema13.Cedula(Console.ReadLine()));
                        break;
                    case opciones.problema14:
                        Console.WriteLine("1 Para pasar de frases a numeros");
                        Console.WriteLine("2 Para pasar de numeros a frases");
                        int opcionProblema14= Convert.ToInt32(Console.ReadLine());
                        switch(opcionProblema14)
                        {
                            case 1:
                                Console.WriteLine("Digite su frase");
                                Console.WriteLine(Problema14.PalabraAnumero(Console.ReadLine()));
                                break;
                            case 2:
                                Console.WriteLine("Digite su numero");
                                Console.WriteLine(Problema14.NumeroAletras(Console.ReadLine()));
                                break;
                            default:
                                Console.WriteLine("Opcion erronea");
                                break;
                        }
                        break;

                    default:
                        break;
                }
                
    
            }
        }
    }
}
