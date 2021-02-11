using System;

class Ejercicio_5_4_2
{
/*(5.4.2) Crea  una  función "Menor" que  calcule  el  menor  de  dos  números  enteros que recibirá como parámetros. El resultado será otro número entero*/

	static void Main()
	{
		Console.WriteLine("El numero mas pequeño es: " + Menor(3,4));
	}
	
	static int Menor(int num1, int num2)
	{
		if (num1 < num2)
		{
			return num1;
		}
		else
		{
			return num2;
		}
	}
}
