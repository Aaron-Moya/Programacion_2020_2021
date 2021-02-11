using System;

class Ejercicio_2_5_2
{
/*(2.5.2) Crea un programa en el que el usuario deba adivinar un número del 1 al
100 (prefijado en el programa). En cada pasada deberá avisar de si se ha pasado o se ha quedado corto.*/	

	static void Main()
	{
		int numeroAdivinar = 64;
		
		Console.Write("Dime un numero del 1 al 100: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		while (num1 != numeroAdivinar)
		{
			if (num1 <= 40)
			{
				Console.WriteLine("Te has pasado");
			} else if (num1 >= 80) 
			{
				Console.WriteLine("Te has pasado");
			} else 
			{
				Console.WriteLine("Te has quedado corto!");
			}
			
			Console.Write("Dime un numero del 1 al 100: ");
			num1 = Convert.ToInt32(Console.ReadLine());
		}
		
		if (num1 == numeroAdivinar)
			{
				Console.WriteLine("Enhorabuena has adivinado el numero!");
			}	
	}
}
