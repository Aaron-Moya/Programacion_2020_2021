using System;

class Ejercicio_2_2_6_5
{
/*(2.2.6.5) Dibuja un triángulo de asteriscos descendente. Por ejemplo, si el usuario
escoge "4" como tamaño, la primera fila tendrá 4 asteriscos, la segunda tendrá 3,
la siguiente tendrá 2 y la última tendrá 1.*/	

	static void Main()
	{
		Console.Write("Dime el tamaño del triangulo: ");
		int tamanyo = Convert.ToInt32(Console.ReadLine());
						
		for (int columna = tamanyo; columna >= 1; columna--)
		{
			for(int fila = columna; fila >= 1; fila--)
			{
				Console.Write("*");	
			}
			Console.WriteLine();
		}
	}
}

