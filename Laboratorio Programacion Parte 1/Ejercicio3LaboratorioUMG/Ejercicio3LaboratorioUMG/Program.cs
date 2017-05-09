using System;

namespace Ejercicio3LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula una Regla de 3");

			int total1;
			int total2;

			Console.WriteLine("Ingrese una cantidad(Precio)");
			int precio = Convert.ToInt32(Console.ReadLine());

			total1 = precio/100;
			total2 = total1 * 10;

			Console.WriteLine("El total es: {0}",total2);

			Console.ReadKey();


		}
	}
}
