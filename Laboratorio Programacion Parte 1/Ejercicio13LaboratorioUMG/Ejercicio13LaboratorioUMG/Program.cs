using System;

namespace Ejercicio13LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que verifica el Usuario y Contraseña");

			string usuario;
			Boolean validar = false;

			while (!validar) { 

				Console.WriteLine("Ingrese Usuario");
				usuario = (Console.ReadLine());
				Console.WriteLine("Ingrese Contraseña");
				int contraseña = Convert.ToInt16(Console.ReadLine());

				if (usuario == "UMG" && contraseña == 2016)
				{

						Console.WriteLine("Acceso Correcto");
						validar = true;


				}
				else {
					Console.WriteLine("Acceso Incorrecto");
				}

			}

		}
	}
}
