using System;

class Ejercicio_5_2_3
{
/*(5.2.3) Descompón en funciones la base de datos de ficheros (ejemplo 04_06a), de modo que el "Main" sea breve y más legible 
 * (Pista: las variables que se compartan entre   varias   funciones   deberán  estar  fuera   de   todas   ellas,   y   deberán   estar precedidas por la palabra "static")*/
 
	static tipoFicha[] fichas = new tipoFicha[1000];
	static int numeroFichas = 0;
	static int opcion;
	static string textoBuscar;
	static long tamanyoBuscar;
	
	struct tipoFicha 
	{
		public string nombreFich;
		public long tamanyo;
	}
	
	static void Main()
	{
		ElegirOpcion();
	}
		
	static void ElegirOpcion()
	{
		
		do {
			Console.WriteLine();
			Console.WriteLine("Escoja una opción:");
			Console.WriteLine("1.-Añadir datos de un nuevo fichero");
			Console.WriteLine("2.-Mostrar los nombres de todos los ficheros");
			Console.WriteLine("3.-Mostrar ficheros por encima de un cierto tamaño");
			Console.WriteLine("4.-Ver datos de un fichero");
			Console.WriteLine("0.-Salir");
			opcion =Convert.ToInt32(Console.ReadLine());
			
			switch (opcion)
			{
				case 1:
					if (numeroFichas < 100)
					{
						Console.WriteLine("Introduce el nombre del fichero: ");
						fichas[numeroFichas].nombreFich = Console.ReadLine();
						Console.WriteLine("Introduce el tamaño en KB: ");
						fichas[numeroFichas].tamanyo = Convert.ToInt32(Console.ReadLine());
						numeroFichas++;
					}
					else
					{
						Console.WriteLine("Máximo de fichas alcanzado (100)!");
					} break;
				
				case 2:
					for(int i=0;i < numeroFichas; i++)
						Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
						  fichas[i].nombreFich,fichas[i].tamanyo);
					break;
				
				case 3:
					Console.WriteLine("¿A partir de que tamaño quieres ver?");
					tamanyoBuscar =Convert.ToInt64(Console.ReadLine());
					
					for(int i=0;i < numeroFichas;i++)
					{
						if(fichas[i].tamanyo >=tamanyoBuscar)
						{
							Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
							  fichas[i].nombreFich,fichas[i].tamanyo);
						}
					} break;
					
				case 4:
					Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
					textoBuscar = Console.ReadLine();
					
					for(int i=0;i < numeroFichas;i++)
					{
						if(fichas[i].nombreFich ==textoBuscar )
						{
							Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
							  fichas[i].nombreFich,fichas[i].tamanyo);
						}
					} break;
					
				case 0:
					Console.WriteLine("Fin del programa");
					break;
					
				default:
					Console.WriteLine("Opcion desconocida!");
					break;
			}
		} while (opcion != 0);
	}
}
