using System;

namespace Ejercicio15LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que verifica el dia de la semana segun el numero ingresado");

			Console.WriteLine("Ingrese un numero del 1 al 7");
			int numero = Convert.ToInt16(Console.ReadLine());

			if (numero == 1)
			{
				Console.WriteLine("El numero {0} corresponde al dia Lunes", numero);
			}
			else if (numero == 2)
			{
				Console.WriteLine("El numero {0} corresponde al dia Martes", numero);
			}
			else if (numero == 3)
			{
				Console.WriteLine("El numero {0} corresponde al dia Miercoles", numero);
			}
			else if (numero == 4)
			{
				Console.WriteLine("El numero {0} corresponde al dia Jueves", numero);
			}
			else if (numero == 5)
			{
				Console.WriteLine("El numero {0} corresponde al dia Viernes", numero);
			}
			else if (numero == 6)
			{
				Console.WriteLine("El numero {0} corresponde al dia Sabado", numero);
			}
			else if (numero == 7) { 
				Console.WriteLine("El numero {0} corresponde al dia Domingo",numero);
			}
		}
	}
}
