using System;

class Ejercicio_2_2_2_3
{
// (2.2.2.3) Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando "do..while".

	static void Main() {
		int num1 = 26;
		
		do {
			Console.WriteLine(num1);
			num1 -= 2;
		} while (num1 > 8);
	}
}
