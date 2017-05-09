using System;

namespace Ejercicio1LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			int minutos = 60;
			int segundos = 60;
			int totalMinutos;
			int totalSegundos;

			Console.WriteLine("Programa que calcula una cantidad de horas a minutos y segundos");

			Console.WriteLine("Ingrese una cantidad de horas");
			int hora = Convert.ToInt16(Console.ReadLine());

			totalMinutos = hora * minutos;
			totalSegundos = totalMinutos * segundos;

			Console.WriteLine("La Cantidad en Minutos es: {0}", totalMinutos);
			Console.WriteLine("La Cantidad en Segundos es: {0}", totalSegundos);

			Console.ReadKey();


		}
	}
}
