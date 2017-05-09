using System;

namespace Ejercicio6LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que suma 2 numeros y los eleva al cuadrado");

			int suma;
			double total;

			Console.WriteLine("Ingrese el Primer Valor");
			int valor1 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingrese el Segundo Valor");
			int valor2 = Convert.ToInt16(Console.ReadLine());

			suma = valor1 + valor2;
			total = Math.Pow(suma, 2);

			Console.WriteLine("El total es: {0}",total);


		}
	}
}
