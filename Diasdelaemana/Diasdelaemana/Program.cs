using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diasdelaemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string lineas;
            Console.WriteLine();
            Console.WriteLine("DIAS DE LA SEMANA");
            Console.WriteLine();
            Console.WriteLine("INGRESE UN NUMERO DE 1 AL 7 :");
            lineas = Console.ReadLine();

            switch (num)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso Corresponde al dia Domingo");
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso Corresponde al dia Lunes");
                    break;


                case 3: 
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso Corresponde al dia Martes");
                    break;


                case 4:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso Corresponde al dia Miercoles");
                    break;


                case 5:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso Corresponde al dia Jueves");
                    break;


                case 6:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso Corresponde al dia Viernes");
                    break;

                case 7:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso Corresponde al dia Sabado");
                    break;

            }

            Console.ReadKey();
        }
    }
}
