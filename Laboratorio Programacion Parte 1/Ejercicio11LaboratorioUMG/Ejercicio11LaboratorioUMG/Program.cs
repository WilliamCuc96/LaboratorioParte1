using System;

namespace Ejercicio11LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que verifica la cantidad de billetes en una cantidad determinada");

			int Q100 = 0;
			int Q50 = 0;
			int Q20 = 0;
			int Q10 = 0;
			int Q5 = 0;
			int Q1 = 0;

			Console.WriteLine("Ingrese cantidad de quetzales");
			string strCantidad = Console.ReadLine();
			int cantidad = Convert.ToInt16(strCantidad);
			while (cantidad >= 100) {
				Q100++;
				cantidad -= 100;
			}
			while (cantidad >= 50) {
				Q50++;
				cantidad -= 50;
			}
			while (cantidad >= 20) {
				Q20++;
				cantidad -= 20;
			}
			while (cantidad >= 10) {
				Q10++;
				cantidad -= 10;
			}
			while (cantidad >= 5) {
				Q5++;
				cantidad -= 5;
			}
			while (cantidad >= 1) {
				Q1++;
				cantidad -= 1;
			}
			Console.WriteLine("La cantidad de billetes es:\nQ100:{0}\nQ50:{1}\nQ20:{2}\nQ10:{3}\nQ5:{4}\nQ1:{5}\n",Q100,Q50,Q20,Q10,Q5,Q1);

		}
	}
}
