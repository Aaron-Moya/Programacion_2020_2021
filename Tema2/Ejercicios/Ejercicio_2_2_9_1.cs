using System;

class Ejercicio_2_2_9_1
{
/*(2.2.9.1) Crea un programa que pida un número al usuario y escriba los múltiplos
de 9 que haya entre 1 y ese número. Debes usar llaves en todas las estructuras de
control, aunque sólo incluyan una sentencia.*/	

	static void Main()
	{
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 1; i <= num1; i++)
		{
			if (i % 9 == 0)
			{
				Console.WriteLine("El numero {0} es multiplo de 9", i);
			}
		}
	}
}
