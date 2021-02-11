using System;

class Ejercicio_5_3_1
{
/*(5.3.1) Crea una función "DibujarCuadrado" que dibuje en pantalla un cuadrado de asteriscos del   ancho   (y   alto)   
 * que   se   indique   como   parámetro.   Completa   el programa con un Main que permita probarla.*/
 
	static void Main()
	{
		DibujarCuadrado(4);
	}
	
	static void DibujarCuadrado(int tamanyo)
	{		
		for (int i = 0; i < tamanyo; i++)
		{
			for (int j = 0; j < tamanyo; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
