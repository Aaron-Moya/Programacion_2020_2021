using System;

class Ejercicio_5_5_4
{
/*(5.5.4) Crea  una  función "ContarLetra", que  reciba  una  cadena  y  una  letra,  y devuelva la cantidad de veces que dicha letra 
 * aparece en la cadena. Por ejemplo, si la cadena es "Barcelona" y la letra es 'a', debería devolver 2 (porque la "a" aparece 2 veces).*/
 
	static void Main()
	{
		Console.WriteLine("La letra aparece " + ContarLetra("aaron",'a') + " veces");
	}
	
	static int ContarLetra(string cadena, char letra)
	{
		int contador = 0;
		
		for (int i = 0; i < cadena.Length; i++)
		{
			if (letra == cadena[i])
			{
				contador++;
			}
		}
		
		return contador;
	}
}
