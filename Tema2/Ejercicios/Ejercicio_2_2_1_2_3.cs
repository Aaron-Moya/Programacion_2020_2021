using System;

class Ejercicio_2_2_1_2_3
{
/*(2.2.1.2.3) Crea un programa que calcule cuantas cifras tiene un número entero
positivo (pista: se puede hacer dividiendo varias veces entre 10).*/

	static void Main() {
		
		int num1 = 1;
		int contador = 1;
		
		while (num1 > 0) {
			Console.Write("Dime un numero: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			
			if (num1 >= 1 && num1 < 10) {
				Console.WriteLine("El numero tiene 1 cifra");
			} else {
				while (num1 / 10 > 0) {
					num1 = num1 / 10;
					contador += 1;
					
				}
			Console.WriteLine("El numero tiene {0} cifras", contador);
			}
		}
	}
}
