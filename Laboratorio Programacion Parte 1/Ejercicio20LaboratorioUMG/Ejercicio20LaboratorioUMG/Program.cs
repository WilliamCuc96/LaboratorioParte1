using System;

namespace Ejercicio20LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa para Restaurante");

			string orden;
			int precio1 = 35;
			int precio2 = 40;
			int total = 0;
			Console.WriteLine("Ingrese el Numero del Platillo que Desea Ordenar");
			Console.WriteLine("1.Pollo Dorado Q.35.00");
			Console.WriteLine("2.Carne a la Plancha Q.40.00");
			int numero = Convert.ToInt16(Console.ReadLine());
			if (numero == 1)
			{
				orden = "Polle Dorado";
			}
			else {
				orden = "Carne a la Plancha";
			}
			Console.WriteLine("Ingrese la Cantidad de ordenes de {0} que desea consumir",orden);
			int ordenCantidad = Convert.ToInt16(Console.ReadLine());

			if (numero == 1)
			{
				total = ordenCantidad * precio1;
			}
			else if (numero == 2) {
				total = ordenCantidad * precio2;
			}
			Console.WriteLine("Factura");
			Console.WriteLine("{0} ordenes de {1}",ordenCantidad,orden);
			Console.WriteLine("El total a pagar es: Q{0}.00",total);
		}
	}
}
