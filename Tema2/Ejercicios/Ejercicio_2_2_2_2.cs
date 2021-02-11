using System;

class Ejercicio_2_2_2_2
{
// (2.2.2.2) Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".

	static void Main() {
		int num1 = 0;
		
		do {
			num1 += 1;
			Console.WriteLine(num1);
		} while (num1 < 10);
	}
}
