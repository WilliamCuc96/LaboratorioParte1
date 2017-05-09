using System;

namespace Ejercicio12LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que verifica si el año ingresado es Bisiesto o no");

			int anio4;
			int anio100;
			int anio400;

			Console.WriteLine("Ingrese un Año");
			int anio = Convert.ToInt16(Console.ReadLine());

			anio4 = anio % 4;
			if (anio4 == 0)
			{
				anio100 = anio % 100;
				if (anio100 == 0)
				{
					anio400 = anio % 400;
					if (anio400 == 0)
					{
						Console.WriteLine("El año {0} es bisiesto",anio);
					}
					else { 
						Console.WriteLine("El año {0} no es bisiesto",anio);
					}
				}
				else { 
					Console.WriteLine("El año {0} es bisiesto",anio);
				}
			}
			else {

				Console.WriteLine("El año {0} no es bisiesto",anio);
			}

		}

	}
}
