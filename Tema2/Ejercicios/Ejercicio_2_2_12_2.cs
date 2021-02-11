using System;

class Ejercicio_2_2_12_1
{
/*2.2.12.2) Crea un programa que escriba los números pares del 20 al 10,
descendiendo, excepto el 14, primero con "for" y luego con "while"*/	

	static void Main()
	{
		for (int i = 20; i >= 10; i--)
		{
			if (i % 2 == 0)
			{
				if (i == 14)
				{
					continue;
				}
			Console.Write(i + " ");
			}
		}
		
		Console.WriteLine();
		
		int contador = 20;
		
		while (contador >= 10)
		{
			if (contador % 2 == 0)
			{
				if (contador == 14)
				{
					continue;
				}
			Console.Write(contador + " ");
			contador -= 2;
			}
			
		}
	}
}
