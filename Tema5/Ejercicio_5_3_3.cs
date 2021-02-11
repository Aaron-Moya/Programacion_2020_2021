using System;

class Ejercicio_5_3_3
{
/*(5.3.3) Crea  una  función "DibujarRectanguloHueco" que  dibuje  en  pantalla  un rectángulo hueco del ancho y alto que se indiquen como parámetros,
 * formado por una letra que también se indique como parámetro. Completa el programa con un Main que pida esos datos al usuario y dibuje el rectángulo*/
 
	static void Main()
	{
		DibujarRectanguloHueco(30,5,'x');
	}
	
	static void DibujarRectanguloHueco(int ancho, int alto, char letra)
	{
		for (int i = 0; i < alto; i++)
		{
			for (int j = 0; j < ancho; j++)
			{
				if (j == 0 || i == 0 || j == ancho - 1 || i == alto - 1)
				{
					Console.Write(letra);
				}
				else
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
	}
}
