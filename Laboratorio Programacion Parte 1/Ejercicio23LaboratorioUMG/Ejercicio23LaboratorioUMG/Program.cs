using System;

namespace Ejercicio23LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Boolean salir = false;
			while (!salir)
			{
				Console.WriteLine("Escoja la Opcion que Desea Realizar");
				Console.WriteLine("Menu Principal");
				Console.WriteLine("1. Calculo de Hipotenusa");
				Console.WriteLine("2. Entero Positivo");
				Console.WriteLine("3. Salir");
				int numero = Convert.ToInt16(Console.ReadLine());

				double total1;
				double total2;

				if (numero == 1)
				{
					Console.WriteLine("Calculo de Hipotenusa");
					Console.WriteLine("Ingrese el valor a");
					int valorA = Convert.ToInt16(Console.ReadLine());
					Console.WriteLine("Ingrese el valor b");
					int valorB = Convert.ToInt16(Console.ReadLine());

					total1 = Math.Pow(valorA, 2) + Math.Pow(valorB, 2);
					total2 = Math.Sqrt(total1);

					Console.WriteLine("El resultado final es: {0}", total2);
				}
				else if (numero == 2)
				{
					Console.WriteLine("Entero Positivo");
					Console.WriteLine("Ingrese Un Numero");
					int entero = Convert.ToInt16(Console.ReadLine());
					if (entero == 0)
					{
						Console.WriteLine("El numero {0} es Cero", entero);
					}
					else if (entero < 0)
					{
						Console.WriteLine("El numero {0} es Negativo", entero);
					}
					else {
						Console.WriteLine("El numero {0} es Positivo",entero);
					}
				}
				else if (numero == 3) {
					salir = true;
				}
			}

		}
	}
}
