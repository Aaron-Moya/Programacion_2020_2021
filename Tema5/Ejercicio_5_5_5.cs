using System;

class Ejercicio_5_5_5
{
/*(5.5.5) Crea  una  función "SumarCifras" que  reciba  un  numero  cualquiera  y  que devuelva  como  resultado  la  suma  de  sus  dígitos.  
 * Por  ejemplo,  si el  número  fuera 123,la suma sería 6*/
 
	static void Main()
	{
		Console.WriteLine(SumarCifras("123"));
	}
	
	static int SumarCifras(string numeros)
	{
		int suma = 0;
		
		for (int i = 0; i < numeros.Length; i++)
		{
			int numero = Convert.ToInt32(numeros.Substring(i,1));
			suma += numero;
		}
		
		return suma;
	}
}
