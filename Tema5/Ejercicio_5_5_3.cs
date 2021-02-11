using System;

class Ejercicio_5_5_3
{
/*(5.5.3) Crea  una  función  "EsPrimo",  que  reciba  un  número  y  devuelva  el  valor booleano "true" si es un número primo o "false" en caso contrario*/

	static void Main()
	{
		Console.WriteLine(EsPrimo(97));
	}
	
	static bool EsPrimo(int numero)
	{
		for (int i = 2; i < numero; i++)
		{
			if (numero % i == 0)
			{
				return false;
			}
		}
		
		return true;
	}
}
