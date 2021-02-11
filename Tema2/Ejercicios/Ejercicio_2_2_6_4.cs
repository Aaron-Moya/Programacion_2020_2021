using System;

class Ejercicio_2_2_6_4
{
/*(2.2.6.4) Crea un triángulo de asteriscos, que mostrará uno en la primera fila, dos
en la segunda, tres en la tercera y así sucesivamente, hasta llegar al tamaño indicado por el usuario*/

	static void Main()
	{
		Console.Write("De cuanto tamaño quieres el triangulo?: ");
		int tamanyo = Convert.ToInt32(Console.ReadLine());
		
		for (int columna = 1; columna <= tamanyo; columna++)
		{
			for (int fila = 1; fila <= columna; fila++)
			{
				Console.Write("*");	
			}
			Console.WriteLine();
		}
	}	
}
