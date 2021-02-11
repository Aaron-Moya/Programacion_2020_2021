using System;

class Ejercicio_2_2_1_1_2
{
/* (2.2.1.1.3) Crea un programa que pida de forma repetitiva pares de números al
usuario. Tras introducir cada par de números, responderá si el primero es múltiplo
del segundo. Se repetirá mientras los dos números sean distintos de cero (terminará cuando uno de ellos sea cero). */

	static void Main() {
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32( Console.ReadLine());
		
		Console.Write("Dime otro numero: ");
		int num2 = Convert.ToInt32( Console.ReadLine());
		
		if (num1 % num2 == 0) {
			Console.WriteLine("El primer numero es multiplo del segundo");
		} else {
			Console.WriteLine("El primer numero no es multiplo del segundo");
		}
		
		while (num1 != 0 || num2 != 0) {
			
			Console.Write("Dime un numero: ");
			num1 = Convert.ToInt32( Console.ReadLine());
		
			Console.Write("Dime otro numero: ");
			num2 = Convert.ToInt32( Console.ReadLine());
		
			if (num1 % num2 == 0) {
				Console.WriteLine("El primer numero es multiplo del segundo");
			} else {
			Console.WriteLine("El primer numero no es multiplo del segundo");
			}
		}
	}
}
