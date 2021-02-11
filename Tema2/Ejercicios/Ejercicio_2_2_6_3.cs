using System;

class Ejercicio_2_2_6_3
{
/*(2.2.6.3) Haz un programa que dibuje un cuadrado de asteriscos, cuyo ancho (y
alto, que tendrá el mismo valor) será introducido por el usuario.*/	

	static void Main()
	{
		Console.Write("Dime un número: ");
		int anchoAlto = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 1; i <= anchoAlto; i++)
		{
			for (int iDos = 1; iDos <= anchoAlto; iDos++)
			{
				Console.Write("**");
			}
			Console.WriteLine();
		}
	}
}
