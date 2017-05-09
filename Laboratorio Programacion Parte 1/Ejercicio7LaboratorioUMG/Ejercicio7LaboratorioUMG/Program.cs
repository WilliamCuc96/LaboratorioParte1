using System;

namespace Ejercicio7LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula la Raiz Cuadrada de un valor");

			double total;

			Console.WriteLine("Ingrese el valor a operar");
			double valor = Convert.ToDouble(Console.ReadLine());

			total = Math.Sqrt(valor);

			Console.WriteLine("La Raiz Cuadrada de {0} es: {1}",valor,total);

			Console.ReadKey();
		}
	}
}
