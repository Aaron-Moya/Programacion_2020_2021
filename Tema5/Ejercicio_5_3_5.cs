using System;

class Ejercicio_5_3_5
{
/*(5.3.5) Crea una nueva versión de la función "DibujarRectangulo", que se apoye en la "EscribirRepetido" que acabas de crear*/

	static void Main()
	{
		EscribirRepetido(3);
	}
	
	static void EscribirRepetido(int repetir)
	{
		for (int i = 0; i < repetir; i++)
		{
			DibujarRectangulo(10,3,'a');
			Console.Write("\n\n");
		}
	}
	
	static void DibujarRectangulo(int ancho, int alto, char caracter)
	{
		for (int i = 0; i < alto; i++)
		{
			for (int j = 0; j < ancho; j++)
			{
				Console.Write(caracter);
			}
			Console.WriteLine();
		}
	}
	
	
}
