using System;

class Ejercicio_2_2_1_1_2
{
/* (2.2.1.1.2) Crea un "calculador de cuadrados": pedirá al usuario un número y
mostrará su cuadrado. Se repetirá mientras el número introducido no sea cero (usa "while" para conseguirlo). */

	static void Main() {
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32( Console.ReadLine());
		
		double resultado = Math.Pow(num1, 2);
		Console.WriteLine("El cuadrado del numero {0}, es: {1}", num1, resultado);
		
		while (num1 != 0) {	
			Console.Write("Dime otro numero: ");
			num1 = Convert.ToInt32( Console.ReadLine());
			
			resultado = Math.Pow(num1, 2);
			Console.WriteLine("El cuadrado del numero {0}, es: {1}", num1, resultado);
		}
	}
}
