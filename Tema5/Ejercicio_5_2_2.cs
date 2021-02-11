using System;

class Ejercicio_5_2_2
{
/*(5.2.2) Crea  una  función  llamada  "DibujarCuadrado3x3",  que  dibuje  un  cuadrado formato por 3 filas con 3 asteriscos cada una.  Incluyeun "Main" paraprobarla.*/

	static void Main()
	{
		DibujarCuadrado3x3();
	}
	
	static void DibujarCuadrado3x3()
	{
		for (int i = 0; i < 3; i++)
		{
			Console.Write("***");
			Console.WriteLine();
		}
	}
}
