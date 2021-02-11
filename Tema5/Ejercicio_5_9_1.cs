/*(5.9.1) Crea  una  función  que  calcule  el  valor  de  elevar  un número  entero  a  otro número  entero  
 * (por  ejemplo,  5  elevado  a  3  =  53=  5  ·5  ·5  =  125).  Esta  función  se debe  crear  de  forma  recursiva.
 * Piensa  cuál  será  el  caso  base  (qué  potencia  se puede  calcular  de  forma  trivial)  y  cómo  pasar  del  caso  "n-1"  al  caso  "n"  
 * (por ejemplo, si sabes el valor de 54, cómo hallarías el de 55a partir de él).*/
 
using System;
 
class Ejercicio_5_9_1
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
		if (e == 1)
			return b;
		return b * Elevar(b, e - 1);
	}
}
