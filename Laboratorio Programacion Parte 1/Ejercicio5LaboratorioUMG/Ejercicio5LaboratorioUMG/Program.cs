using System;

namespace Ejercicio5LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula el perímetro de un Cuadrado");

			int total;
			Console.WriteLine("Ingrese la medida de los lados de un cuadrado");
			int lados = Convert.ToInt16(Console.ReadLine());

			total = lados + lados + lados + lados;

			Console.WriteLine("el Perimetro de un cuadrado de {0} * {1} es: {2}",lados,lados,total);
			Console.ReadKey();

		}
	}
}
