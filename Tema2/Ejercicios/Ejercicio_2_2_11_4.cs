using System;

class Ejercicio_2_2_11_4
{
// (2.2.11.4) Crea una versión alternativa del ejercicio 2.2.11.2, que no emplee "continue" sino el "if" contrario.	

	static void Main()
	{
		for (int i = 2; i <= 106; i++)
		{
			if (i % 10 != 0)
			{
				Console.Write(i + " ");
			}
		} 
	}
}
