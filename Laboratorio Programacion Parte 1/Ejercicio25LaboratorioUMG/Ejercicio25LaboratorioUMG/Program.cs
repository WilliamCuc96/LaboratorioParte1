using System;

namespace Ejercicio25LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que Muestra el tipo de Triangulo segun sus lados");

			Console.WriteLine("Ingrese la medida del primer lado del triangulo");
			double medida1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ingrese la medida del segundo lado del triangulo");
			double medida2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ingrese la medida del tercer lado del triangulo");
			double medida3 = Convert.ToDouble(Console.ReadLine());

			if (medida1 == medida2 && medida2 == medida3)
			{
				Console.WriteLine("Triangulo Equilatero");
			}
			else if (medida1 != medida2 && medida2 != medida3 && medida3 != medida1)
			{
				Console.WriteLine("Triangulo Escaleno");
			}
			else {
				Console.WriteLine("Triangulo Isósceles");
			}
		}
	}
}
