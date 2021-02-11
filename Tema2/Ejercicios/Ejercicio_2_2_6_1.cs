using System;

class Ejercicio_2_2_6_1
{
// (2.2.6.1) Crea un programa que escriba 4 líneas de texto, cada una de las cuales estará formada por los números del 1 al 5.

	static void Main()
	{
		for (int lineas = 1; lineas <= 4; lineas++)
		{
			for (int i = 1; i <= 5; i++)
			{
				Console.Write(i);
			}
			Console.WriteLine();
		}
	}
}
