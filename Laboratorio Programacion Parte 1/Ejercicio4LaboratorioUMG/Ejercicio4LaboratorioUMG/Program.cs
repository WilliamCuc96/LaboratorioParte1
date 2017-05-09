using System;

namespace Ejercicio4LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula una cantidad en Toneladas a Quintales, Arrobas y Libras");

			double quintales = 10;
			double libras = 2204.62;
			double arrobas = 25;
			double totalQuintales;
			double totalArrobas;
			double totalLibras;

			Console.WriteLine("Ingrese una cantidad en Toneladas");
			double toneladas = Convert.ToDouble(Console.ReadLine());

			totalQuintales = toneladas * quintales;
			totalLibras = toneladas * libras;
			totalArrobas = totalLibras * arrobas;

			Console.WriteLine("La cantidad en Quintales es: {0}",totalQuintales);
			Console.WriteLine("La cantidad en Libras es: {0}",totalLibras);
			Console.WriteLine("La cantidad en Arrobas es: {0}",totalArrobas);

			Console.ReadKey();

		}
	}
}
