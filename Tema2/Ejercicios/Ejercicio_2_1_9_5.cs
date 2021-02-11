using System;

class Ejercicio_2_1_9_5
{
/* (2.1.9.5) Repite el ejercicio 2.1.9.2, empleando "if" en lugar de "switch" (pista: como
las cifras numéricas del 0 al 9 están ordenadas, no hace falta comprobar los 10
valores, sino que se puede hacer con "if ((simbolo >= '0') && (simbolo <='9'))"). */

	static void Main() {
		Console.Write("Dime un caracter, signo o numero del 0 al 9: ");
		char caracter = Convert.ToChar(Console.ReadLine());
		
		if ((caracter >= '0' && (caracter <='9'))) {
			Console.Write("El dato introducido es un numero del 0 al 9");
		}	
		if (caracter == '.' || caracter == ',' || caracter == ';' || caracter == ':') {
			Console.Write("El dato introducido es un signo de puntuación");
		}
		
	}

}
