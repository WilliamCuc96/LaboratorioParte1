using System;

namespace Ejercicio22LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que Clasifica a personas segun su edad");

			Console.WriteLine("Ingrese su edad");
			int edad = Convert.ToInt16(Console.ReadLine());

			if (edad < 5)
			{
				Console.WriteLine("Bebe");
			}
			else if (edad >= 6 && edad <= 12)
			{
				Console.WriteLine("Niño");
			}
			else if (edad >= 13 && edad <= 17)
			{
				Console.WriteLine("Adolescente");
			}
			else if (edad >= 18 && edad <= 50)
			{
				Console.WriteLine("Adulto");
			}
			else if (edad >= 51) {
				Console.WriteLine("Anciano");
			}
		}
	}
}
