using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indique el numero: ");
            double num1 = double.Parse(Console.ReadLine());

           
            Console.Write("El resultado es un numero ");
            if (num1 % 2 == 0)
                Console.Write("Par");
            else
                Console.Write("Impar");

            Console.ReadKey();
        }
    }
}
