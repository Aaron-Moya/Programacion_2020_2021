using System;

class Ejercicio_2_2_7_1
{
/*(2.2.7.1) Crea un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).*/	

	static void Main()
	{
		for (char letra = 'Z'; letra >= 'A'; letra--)
		{
			Console.WriteLine(letra);
		}
	}
}
