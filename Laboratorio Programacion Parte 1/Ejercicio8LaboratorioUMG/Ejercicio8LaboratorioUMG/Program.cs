using System;

namespace Ejercicio8LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula la media aritmetica de las ventas de Tigo");

			double promedio;
			double total=0;
			double ventas = 5;
			string[] marca = new string[5];
			double[] precio = new double[5];
			for (int i = 0; i < 5; i++) {
				
				Console.WriteLine("Ingrese la Marca del Telefono");
				marca[i] = Console.ReadLine();
				Console.WriteLine("Ingrese el precio del telefono");
				precio[i] = Convert.ToDouble(Console.ReadLine());
			}

			for (int i = 0; i< 5; i++) {
				Console.WriteLine("{0}     -  {1}",marca[i],precio[i]);
				total += precio[i];
			}

			promedio = total / ventas;

			Console.WriteLine("Promedio =   {0}",promedio);

			Console.ReadKey();

		}
	}
}
