using System;

class Ejercicio_2_2_7_2
{
/*(2.2.7.2) Crea un programa que muestre 5 veces las letras de la L (mayúscula) a la N (mayúscula), 
 * en la misma línea, empleando dos "for" anidados.*/	
 
	static void Main()
	{
		for (int i = 1; i <= 5; i++)
		{
			for (char letra = 'L'; letra <= 'N'; letra++) 
			{
				Console.Write(letra);
			}
		}
	}
}
