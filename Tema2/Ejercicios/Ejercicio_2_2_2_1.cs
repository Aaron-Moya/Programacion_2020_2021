using System;

class Ejercicio_2_2_2_1
{
/*(2.2.2.1) Crea un programa que pida números positivos al usuario, y vaya
calculando y mostrando la suma de todos ellos (terminará cuando se teclea un número negativo o cero). */

	static void Main() {
		int num1;
		int num2;
		
		do {
			Console.Write("Dime un numero: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Dime otro numero: ");
			num2 = Convert.ToInt32(Console.ReadLine());
			
			if (num1 > 0 && num2 > 0) {
				Console.WriteLine("La suma de esos dos numeros es: "+(num1 + num2));
			}
		} while (num1 > 0 && num2 > 0);
	}
}
