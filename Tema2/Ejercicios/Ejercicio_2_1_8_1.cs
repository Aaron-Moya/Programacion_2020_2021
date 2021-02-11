using System;

class Ejercicio_2_1_8_1
{
/* (2.1.8.1) Crea un programa que use el operador condicional para mostrar el valor
absoluto de un número de la siguiente forma: si el número es positivo, se
mostrará tal cual; si es negativo, se mostrará cambiado de signo. */

	static void Main() {
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32( Console.ReadLine());
		
		int numResultado = num1 > 0 ? num1 : -num1;
		Console.WriteLine("El resultado es: {0}", num1);
	}
	
}
