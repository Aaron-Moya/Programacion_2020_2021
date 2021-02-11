using System;

class Ejercicio_5_3_4
{
/*(5.3.4) Crea una función "EscribirRepetido", que reciba un carácter y un número, y escriba  ese  carácter  tantas  veces  como  indique  ese  número  
 * (todas  ellas  en  la misma línea).*/
 
	static void Main()
	{
		EscribirRepetido('a', 6);
	}
	
	static void EscribirRepetido(char caracter, int repetir)
	{
		for (int i = 0; i < repetir; i++)
		{
			Console.Write(caracter);
		}
	}
}
