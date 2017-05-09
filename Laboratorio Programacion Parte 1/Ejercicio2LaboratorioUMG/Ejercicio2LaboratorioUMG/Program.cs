using System;

namespace Ejercicio2LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que convierte una cantidad de Millas a Kilometros, Metros, Centimetros y Milimetros");

			double kilometros = 1.60934;
			double metros = 1609.34;
			double centimetros = 160934;
			double milimetro = 10;
			double totalMetros;
			double totalKilometros;
			double totalCentimetros;
			double totalMilimetros;

			Console.WriteLine("Ingrese una cantidad de Millas");
			double millas = Convert.ToDouble(Console.ReadLine());

			totalKilometros = millas * kilometros;
			totalMetros = millas * metros;
			totalCentimetros = millas * centimetros;
			totalMilimetros = totalCentimetros * milimetro;

			Console.WriteLine("El total en Kilometros es: {0}",totalKilometros);
			Console.WriteLine("El total en Metros es: {0}",totalMetros);
			Console.WriteLine("El total en Centimetros es: {0}",totalCentimetros);
			Console.WriteLine("El total en Milimetros es: {0}",totalMilimetros);

			Console.ReadKey();


		}
	}
}
