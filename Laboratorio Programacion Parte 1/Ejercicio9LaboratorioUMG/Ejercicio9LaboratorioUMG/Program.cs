using System;

namespace Ejercicio9LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula el promedio de un Estudiante");

			double sumaNotas;
			double promedioTotal;

			Console.WriteLine("Ingrese la Primera Nota");
			double nota1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ingrese la Segunda Nota");
			double nota2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ingrese la Tercer Nota");
			double nota3 = Convert.ToDouble(Console.ReadLine());

			sumaNotas = nota1 + nota2 + nota3;
			promedioTotal = sumaNotas / 3;

			Console.WriteLine("El promedio del estudiante es: {0}",promedioTotal);

			Console.ReadKey();
		}
	}
}
