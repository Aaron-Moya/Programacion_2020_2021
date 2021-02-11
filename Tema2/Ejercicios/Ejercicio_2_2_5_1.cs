using System;

class Ejercicio_2_2_5_1
{
/*(2.2.5.1) Crea un programa escriba 4 veces los números del 1 al 5, en una misma línea, usando "for": 12345123451234512345.*/	

	static void Main()
	{
		for (int i = 1; i <= 4; i++)
		{
			for (int iDos = 1; iDos <= 5; iDos++)
			{
				Console.Write(iDos);
			}
		}
	}
}
