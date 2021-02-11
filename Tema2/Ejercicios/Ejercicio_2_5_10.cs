using System;

class Ejercicio_2_5_10
{
/*(2.5.10) Crea un programa que "dibuje" un cuadrado formado por cifras sucesivas,
con el tamaño que indique el usuario, hasta un máximo de 9. Por ejemplo, si desea
tamaño 5, el cuadrado sería así:
11111
22222
33333
44444
55555*/	

	static void Main()
	{
		Console.Write("Dime un número: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 1; i <= num1; i++)
		{
			for (int j = 1; j <= num1; j++)
			{
				Console.Write(i);
			}
			Console.WriteLine();
		}
	}
}
