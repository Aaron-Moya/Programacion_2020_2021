using System;

class Ejercicio_2_2_1_1_1
{
/* (2.2.1.1.1) Crea un programa que pida al usuario su contraseña (numérica).
Deberá terminar cuando introduzca como contraseña el número 1111, pero volvérsela a pedir tantas veces como sea necesario. */

	static void Main() {
		Console.Write("Dime una contraseña(numerica): ");
		int password = Convert.ToInt32( Console.ReadLine());
		
		while (password != 1111) {
			Console.Write("Dime una contraseña(numerica): ");
			password = Convert.ToInt32( Console.ReadLine());
		}
	}
}
