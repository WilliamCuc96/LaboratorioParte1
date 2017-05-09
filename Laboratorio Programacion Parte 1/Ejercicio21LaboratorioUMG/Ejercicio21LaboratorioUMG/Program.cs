using System;

namespace Ejercicio21LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula las ventas diarias de un Almacen");

			string producto;
			double total = 0;

			Console.WriteLine("Ingrese la Cantidad de Ventas a Ingresar");
			int cantidadVentas = Convert.ToInt16(Console.ReadLine());

			for (int i = 1; i <= cantidadVentas; i++) {
				Console.WriteLine("Ingrese el Nombre del Producto");
				producto = Console.ReadLine();
				Console.WriteLine("Ingrese el Precio del Producto");
				double precioProducto = Convert.ToDouble(Console.ReadLine());
				total += precioProducto;
			}
			Console.WriteLine("El total vendido en el dia es de: Q{0}.00",total);
		}
	}
}
