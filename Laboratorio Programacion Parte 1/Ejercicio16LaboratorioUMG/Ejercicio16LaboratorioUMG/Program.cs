using System;

namespace Ejercicio16LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula el sueldo de un trabajador");

			double sueldoTotal;
			string nombre;
			double precioHoraExtra = 1.5;
			double horasExtrasTotal;
			double horasExtrasTotal2;
			double horaJornadaNormal;
			double horaNormal = 8;

			Console.WriteLine("Ingrese el Nombre del Trabajador");
						nombre = Console.ReadLine();
						Console.WriteLine("Ingrese el Pago por Hora");
						double pagoHora = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ingrese la cantidad de horas extras");
						double horasExtras = Convert.ToDouble(Console.ReadLine());

			horasExtrasTotal = precioHoraExtra* pagoHora;
			horasExtrasTotal2 = horasExtrasTotal* horasExtras;
			horaJornadaNormal = pagoHora* horaNormal;
			sueldoTotal = horaNormal + horasExtrasTotal2;

			Console.WriteLine("El sueldo total diario del trabajador {0} es: {1}",nombre,sueldoTotal);

			Console.ReadKey();
		}
	}
}
