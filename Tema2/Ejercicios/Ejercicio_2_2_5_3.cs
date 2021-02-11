using System;

class Ejercicio_2_2_5_3
{
/*(2.2.5.3) Crea un programa que, para los números entre el 10 y el 20 (ambos
incluidos) diga si son divisibles entre 5, si son divisibles entre 6 y si son divisibles entre 7, usando dos bucles anidados.*/	

	static void Main()
	{
		for (int i = 10; i <= 20; i++)
		{
			for (int iDos = 5; iDos <= 7; iDos++)
			{
				if (i % iDos == 0)
				{
					Console.WriteLine("{0} es divisible entre {1}", i, iDos);
				}
			}
		}
	}
}
