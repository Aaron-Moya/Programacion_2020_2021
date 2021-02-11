using System;

class Ejercicio_2_2_9_2
{
/* (2.2.9.2) Crea un programa que pida al usuario dos números y escriba sus
divisores comunes. Debes usar llaves en todas las estructuras de control, aunque sólo incluyan una sentencia. */

	static void Main()
	{
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Dime otro numero: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 1; i <= num1; i++)
		{
			if (num1 % i == 0 && num2 % i == 0)
			{
				Console.WriteLine("El numero {0} es divisor de {1} y {2}", i, num1, num2);
			}
		}
	}
}
