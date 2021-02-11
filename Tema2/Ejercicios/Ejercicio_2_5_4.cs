using System;

class Ejercicio_2_5_4
{
/*(2.5.4) Crea un programa que pida un número al usuario y diga si es primo (divisible sólo entre 1 y él mismo).*/	

	static void Main()
	{
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		int contador = 0;
		
		for (int i = 1; i <= num1; i++)
		{
			if (num1 % i == 0)
			{
				contador++;
			} 
		}
				
		if (contador == 2)
		{
			Console.WriteLine("El numero es primo!");
		} else {
			Console.WriteLine("El numero no es primo...");
		}
	}
}
