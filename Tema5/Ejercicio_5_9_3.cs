/*(5.9.3) Crea un programa que emplee recursividad para calcular un número de la serie Fibonacci
 * (en la que los dos primeros elementos valen 1, y para los restantes, cada elemento es la suma de los dos anteriores)*/
 
using System;

class Ejercicio_5_9_3
{
	static void Main()
	{
		Console.WriteLine("El resultado es: " + Fib(7));
	}
	
	static int Fib(int n)
	{
		int resultado = 0;
		
		if (n == 1)
			return 0;
		else if (n == 2)
			return 1;
		else
			resultado = Fib(n - 1) + Fib(n - 2);
		
		return resultado;
	}
}
