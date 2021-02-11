using System;

class Ejercicio_2_1_8_2
{
// (2.1.8.2) Usa el operador condicional para calcular el menor de dos números.

	static void Main() {
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Dime otro numero: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		int resultado = num1 < num2 ? num1 : num2;
		
		Console.WriteLine("El número mas pequeño es: " + resultado);
	}
}
