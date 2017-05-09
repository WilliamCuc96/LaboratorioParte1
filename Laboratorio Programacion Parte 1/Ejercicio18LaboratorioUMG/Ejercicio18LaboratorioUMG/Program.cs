using System;

namespace Ejercicio18LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que verifica la aprobacion de un estudiante en un curso");

			int notaFinal;
			string nombre;
			string nombreCurso;

			Console.WriteLine("Ingrese el Nombre del Estudiante:");
			nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el Nombre del Curso:");
			nombreCurso = Console.ReadLine();
			Console.WriteLine("Ingrese la nota del primer parcial");
			int nota1 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingrese la nota del segundo parcial");
			int nota2 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingrese la zona");
			int nota3 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingrese la nota del examen final");
			int nota4 = Convert.ToInt16(Console.ReadLine());

			notaFinal = nota1 + nota2 + nota3 + nota4;

			if (notaFinal >= 60)
			{
				Console.WriteLine("{0}",nombre);
				Console.WriteLine("{0}",nombreCurso);
				Console.WriteLine("Nota Final: {0}", notaFinal);
				Console.WriteLine("Aprobado");
			}
			else {
				Console.WriteLine("{0}",nombre);
				Console.WriteLine("{0}",nombreCurso);
				Console.WriteLine("Nota Final: {0}", notaFinal);
				Console.WriteLine("Reprobado");
			}

		}
	}
}
