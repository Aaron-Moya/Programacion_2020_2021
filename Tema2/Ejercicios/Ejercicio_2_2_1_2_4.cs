using System;

class Ejercicio_2_2_1_2_4
{
/*(2.2.1.2.4) Haz un programa que muestre tantos asteriscos (en la misma línea) como indique el usuario */

	static void Main() {
		Console.Write("Cuantos astericos quieres mostrar?: ");
		int asteriscos = Convert.ToInt32(Console.ReadLine());
		int contador = 0;
		
		while (contador != asteriscos) {
			contador += 1;
			Console.Write("*");
		}
		
		
	}
}
