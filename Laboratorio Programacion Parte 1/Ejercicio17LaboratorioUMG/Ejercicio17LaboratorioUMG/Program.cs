using System;

namespace Ejercicio17LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que notifica el resultado de un partido de futbol");

			string equipo1;
			string equipo2;

			Console.WriteLine("Ingrese el Nombre del Primer Equipo:");
			equipo1 = Console.ReadLine();
			Console.WriteLine("Ingrese los goles marcados por el equipo {0}",equipo1);
			int marcador1 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingrese el Nombre del Segundo Equipo:");
			equipo2 = Console.ReadLine();
			Console.WriteLine("Ingrese los goles marcados por el equipo {0}",equipo2);
			int marcador2 = Convert.ToInt16(Console.ReadLine());

			if (marcador1 < marcador2)
			{
				Console.WriteLine("El equipo ganador es el: {0}", equipo2);
			}
			else if (marcador1 > marcador2)
			{
				Console.WriteLine("El equipo ganador es el: {0}", equipo1);
			}
			else if (marcador1 == marcador2) { 
				Console.WriteLine("Empate");
			}
		}
	}
}
