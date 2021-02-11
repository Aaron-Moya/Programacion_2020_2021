/*(5.9.2) Como  alternativa,  crea  una  función  que  calcule  el  valor  de  elevar  un número  entero  
 * a otro  número  entero  de forma  NO recursiva (lo  que llamaremos "de forma iterativa"), usando la orden "for".*/
 
using System;

class Ejercicio_5_9_2
{
	public static void Main()
	{
		Console.Write("Que numero quieres elevar? ");
		int b = Convert.ToInt32(Console.ReadLine());
		Console.Write("A que numero lo quieres elevar? ");
		int e = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("El resultado es: " + Elevar(b, e));
	}
	
	static int Elevar(int b, int e)
	{
		int resultado = b;
		
		for (int i = 0; i < e - 1; i++)
		{
			resultado = resultado * b;
		}
		
		return resultado;
	}
}
