using System;

class Ejercicio_5_4_4
{
/*(5.4.4) Crea una función "Inicial", que devuelva la primera letra de una cadena de texto. Prueba esta función para calcular la primera letra de la frase "Hola".*/

	static void Main()
	{
		Console.WriteLine(Inicial("Hola que tal"));
	}
	
	static char Inicial(string cadena)
	{
		return cadena[0];
	}
}
