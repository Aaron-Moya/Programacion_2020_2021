using System;

class Ejercicio_5_3_2
{
/*(5.3.2) Crea una función "DibujarRectangulo" que dibuje en pantalla un rectángulo del ancho y alto que se indiquen como parámetros, 
 * en ese orden. Incluyeun Main para probarla.*/
 
	static void Main()
	{
		DibujarRectangulo(10,3);
	}
	
	static void DibujarRectangulo(int ancho, int alto)
	{
		for (int i = 0; i < alto; i++)
		{
			for (int j = 0; j < ancho; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
