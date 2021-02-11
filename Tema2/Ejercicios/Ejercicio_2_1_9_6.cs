using System;

class Ejercicio_2_1_9_6 
{
// (2.1.9.6) Repite el ejercicio 2.1.9.3, empleando "if" en lugar de "switch".

	static void Main() {
		Console.Write("Dime una vocal, consonante o un numero del 0 al 9: ");
		char caracter = Convert.ToChar(Console.ReadLine());
		
		if ((caracter >= '0' && (caracter <='9'))) {
			Console.Write("El dato introducido es un numero del 0 al 9");
		}
		
		if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u') {
			Console.Write("El dato introducido es una vocal");
		}
		
		if (caracter == 'b' || caracter == 'c' || caracter == 'd' || caracter == 'f' || caracter == 'g'
			|| caracter == 'h' || caracter == 'j' || caracter == 'k' || caracter == 'l' || caracter == 'm'
			|| caracter == 'n' || caracter == 'ñ' || caracter == 'p' || caracter == 'q' || caracter == 'r'
			|| caracter == 's' || caracter == 't' || caracter == 'v' || caracter == 'w' || caracter == 'x'
			|| caracter == 'y' || caracter == 'z') {
			Console.Write("El dato introducido es una consonante");
		}
	}
}
