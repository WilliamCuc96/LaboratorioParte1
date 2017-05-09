using System;

namespace Ejercicio24LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			int[] numeros = new int[5];

			int cantidadNumeros = 5;
			for (int i = 0; i < cantidadNumeros; i++) {
				Console.WriteLine("Ingrese el Numero {0}",i+1);
				numeros[i] = Convert.ToInt16(Console.ReadLine());
			}
			//ya esta lleno el arreglo de entradas
			int moda = 0;
			Boolean existeModa = false;
			foreach(int numeroActual in numeros){
			int cantidadDeApariciones = 0;
				foreach (int numeroSecundario in numeros) {
					if (numeroActual == numeroSecundario) {
						cantidadDeApariciones++;
					}
					if (cantidadDeApariciones == 3) {
						moda = numeroActual;
						existeModa = true;
						break;
					}
				}
				if (existeModa) {
					Console.WriteLine("La moda es {0}", moda);
					break;
				}
			}
			if (!existeModa) {
				Console.WriteLine("La moda no existe");
			}
		}
	}
}
