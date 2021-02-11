using System;

class Ejercicio_2_1_9_4
{
// (2.1.9.4) Repite el ejercicio 2.1.9.1, empleando "if" en lugar de "switch".

	static void Main() {
		Console.Write("Dime un número del 1 al 10: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		if (num1 == 1) {
			Console.Write("uno");
		}
		if (num1 == 2) {
			Console.Write("dos");
		}
		if (num1 == 3) {
			Console.Write("tres");
		}
		if (num1 == 4) {
			Console.Write("cuatro");
		}
		if (num1 == 5) {
			Console.Write("cinco");
		}
		if (num1 == 6) {
			Console.Write("seis");
		}
		if (num1 == 7) {
			Console.Write("siete");
		}
		if (num1 == 8) {
			Console.Write("ocho");
		}
		if (num1 == 9) {
			Console.Write("nueve");
		}
		if (num1 == 10) {
			Console.Write("diez");
		}
		
	}

}
