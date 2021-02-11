using System;

class Ejercicio_2_2_1_2_1
{
/*(2.2.1.2.1) Crea un programa que escriba en pantalla los números del 1 al 10, usando "while".*/	

	static void Main() {
		int num1 = 0;
		
		while (num1 <= 9) {
			num1 += 1;
			Console.WriteLine(num1);
		}
	}
}
