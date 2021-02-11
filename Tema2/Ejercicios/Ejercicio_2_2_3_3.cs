using System;

class Ejercicio_2_2_3_3
{
// (2.2.3.3) Crea un programa que muestre los números del 100 al 200 (ambos incluidos) que sean divisibles entre 7 y a la vez entre 3	

	static void Main() {
		for (int i = 100; i <= 200; i++)
		{
			if (i % 7 == 0 && i % 3 == 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}
