using System;

class Ejercicio_5_2_1
{
/*(5.2.1) Crea una función llamada "BorrarPantalla", que borre la pantalla dibujando 25 líneas en blanco. Crea también un "Main" que permita probarla.*/

	static void Main()
	{
		BorrarPantalla();
	}
	
	static void BorrarPantalla()
	{
		for (int i = 0; i < 25; i++)
		{
			Console.WriteLine();
		}
	}
}
