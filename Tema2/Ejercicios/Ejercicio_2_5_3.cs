using System;

class Ejercicio_2_5_3
{
/*(2.5.3) Haz un programa que dé al usuario la oportunidad de adivinar un número
del 1 al 100 (prefijado en el programa) en un máximo de 6 intentos. En cada
pasada deberá avisar de si se ha pasado o se ha quedado corto.*/	

	static void Main()
	{
		int numeroAdivinar = 60;
		int intentos = 0;
		
		Console.Write("Dime un numero del 1 al 100: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		while (num1 != numeroAdivinar)
		{
			if (intentos == 6)
			{
				Console.WriteLine("Has acabado todos tus intentos...");
				break;
			} else {
				intentos += 1;
			}
			
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
