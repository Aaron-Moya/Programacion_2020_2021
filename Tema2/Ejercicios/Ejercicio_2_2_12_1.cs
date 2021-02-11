using System;

class Ejercicio_2_2_11_2
{
/* (2.2.12.1) Crea un programa que escriba los números del 100 al 200, separados
por un espacio, sin avanzar de línea, usando "for". En la siguiente línea, vuelve a escribirlos usando "while".	*/

	static void Main()
	{
		for (int i = 100; i <= 200; i++)
		{
			Console.Write(i + " ");
		}
		
		Console.WriteLine();
		
		int contador = 100;
		
		while (contador <= 200)
		{
			Console.Write(contador + " ");
			contador += 1;
		}
	}
}
