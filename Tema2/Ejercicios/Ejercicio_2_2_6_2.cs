using System;

class Ejercicio_2_2_6_2
{
/*(2.2.6.2) Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto
(por ejemplo, 3) y escriba un rectángulo formado por esa cantidad de asteriscos:
****
****
*****/

	static void Main()
	{
		Console.Write("Dime el ancho: ");
		int ancho = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Dime el alto: ");
		int alto = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 1; i <= alto; i++)
		{
			for (int iDos = 1; iDos <= ancho; iDos++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
