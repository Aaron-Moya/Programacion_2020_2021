using System;

class Ejercicio_5_4_5
{
/*(5.4.5) Crea una función "UltimaLetra", que devuelva la última letra de una cadena de texto. Prueba esta función para calcular la última letra de la frase "Hola".*/

	static void Main()
	{
		Console.WriteLine(Inicial("Hola que tal"));
	}
	
	static char Inicial(string cadena)
	{
		char resultado = ' ';
		
		for (int i = 0; i < cadena.Length; i++)
		{
			if (i == cadena.Length - 1)
			{
				resultado = cadena[i];
			}
		}
		return resultado;
	}
}
