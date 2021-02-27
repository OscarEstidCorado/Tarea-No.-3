using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FibonacciNumbers
{
	class Program
	{
		static void Main()
		{
			int cantidad = int.Parse(Console.ReadLine());
			long a = 0;
			long b = 1;
			long aux = 0;


			for (int i = 0; i < cantidad; i++)
			{
				if (i == 0)
				{
					Console.Write("{0}", a);
				}
				else
				{
					aux = a;
					a = b;
					b = aux + a;
					Console.Write(", {0}", a);
				}
			}
			Console.WriteLine();
		}
		
	}
}