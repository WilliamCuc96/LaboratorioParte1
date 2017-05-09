using System;

namespace Ejercicio14LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double operacion;

			Console.WriteLine("Programa de un Supermercado");
			string articulo;
			Console.WriteLine("Ingrese el nombre del articulo a comprar:");
			articulo = Console.ReadLine();
			Console.WriteLine("Ingrese el precio del articulo:");
			double precio = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ingrese la cantidad de dinero para pagar:");
			double cantidadDinero = Convert.ToDouble(Console.ReadLine());

			operacion = precio - cantidadDinero;

			if (operacion < 0)
			{
				Console.WriteLine("Su vuelto es: {0}", operacion * -1);
			}
			else if (operacion > 0)
			{
				Console.WriteLine("Dinero Insuficiente, le hace falta: {0}", operacion);
			}
			else if (operacion == 0) {
				Console.WriteLine("Cantidad de dinero exacto");
			}
		}
	}
}
