using System;

class Ejercicio_2_2_3_2
{
/*(2.2.3.2) Crea un programa que escriba en pantalla los números del 1 al 50 que
sean múltiplos de 3 (pista: habrá que recorrer todos esos números y ver si el resto de la división entre 3 resulta 0).*/	

	static void Main()
	{
		for (int i = 1; i <= 50; i++)
		{
			if (i % 3 == 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}
