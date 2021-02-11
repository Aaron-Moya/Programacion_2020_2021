using System;

class Ejercicio_2_4_1
{
// (2.4.1) Crea un programa que cuente cuantas veces aparece la letra 'a' en una frase que teclee el usuario, utilizando "foreach".	

	static void Main()
	{
		Console.Write("Dime una frase: ");
		string frase = Console.ReadLine();
		
		int contador = 0;
		
		foreach (char letra in frase)
		{
			if (letra == 'a')
			{
				contador += 1;
			}
		}
		Console.WriteLine("La frase tiene {0} letras a", contador);
	}
}
