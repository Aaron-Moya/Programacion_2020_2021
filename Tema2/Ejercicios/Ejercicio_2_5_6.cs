using System;

class Ejercicio_2_5_6
{
// (2.5.6) Crea un programa que calcule un número elevado a otro, usando multiplicaciones sucesivas.	

	static void Main()
	{
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Dime otro numero: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		int resultado = num1;
		
		for (int i = 1; i < num2; i++)
		{
			resultado = resultado * num1;
		}
		Console.WriteLine("El numero {0} elevado a {1} es: {2}", num1, num2, resultado);
	}
}
