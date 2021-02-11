using System;

class Ejercicio_2_2_1_2_2
{
/*(2.2.1.2.2) Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando "while" */	

	static void Main() {
		int num1 = 28;
		
		while (num1 % 2 == 0 && num1 >= 12) {
			num1 = num1 - 2;
			Console.WriteLine(num1);
		}
	}
}
