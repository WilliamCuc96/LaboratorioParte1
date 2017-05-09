using System;

namespace Ejercicio19LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que compara 2 numeros y notifica cual es mayor, cual es menor o si son iguales");

			Console.WriteLine("Ingrese el Primer Numero");
			int numero1 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingrese el Segundo Numero");
			int numero2 = Convert.ToInt16(Console.ReadLine());

			if (numero1 < numero2)
			{
				Console.WriteLine("El numero {0} es mayor que el numero {1}", numero2, numero1);
			}
			else if (numero1 > numero2)
			{
				Console.WriteLine("El numero {0} es mayor que el numero {1}", numero1, numero2);
			}
			else if (numero1 == numero2) {
				Console.WriteLine("El numero {0} es igual al numero {1}",numero1,numero2);
			} 
		}
	}
}
