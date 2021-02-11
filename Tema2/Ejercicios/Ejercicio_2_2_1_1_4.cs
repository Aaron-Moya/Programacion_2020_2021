using System;

class Ejercicio_2_2_1_1_4
{
/*(2.2.1.1.4) Crea una versión mejorada del programa anterior, que, tras introducir
cada par de números, responderá si el primero es múltiplo del segundo, o el
segundo es múltiplo del primero, o ninguno de ellos es múltiplo del otro. */

	static void Main() {
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32( Console.ReadLine());
		
		Console.Write("Dime otro numero: ");
		int num2 = Convert.ToInt32( Console.ReadLine());
		
		if (num1 % num2 == 0) {
			Console.WriteLine("El primer numero es multiplo del segundo");
		} else if (num2 % num1 == 0) {
			Console.WriteLine("El segundo numero es multiplo del primero");
		} else {
			Console.WriteLine("Ninguno de los dos numeros son multiplos");
		}
		
		while (num1 != 0 || num2 != 0) {
			
			Console.Write("Dime un numero: ");
			num1 = Convert.ToInt32( Console.ReadLine());
		
			Console.Write("Dime otro numero: ");
			num2 = Convert.ToInt32( Console.ReadLine());
		
			if (num1 % num2 == 0) {
				Console.WriteLine("El primer numero es multiplo del segundo");
			} else if (num2 % num1 == 0) {
				Console.WriteLine("El segundo numero es multiplo del primero");
			} else {
				Console.WriteLine("Ninguno de los dos numeros son multiplos");
			}
		}
	}
}
