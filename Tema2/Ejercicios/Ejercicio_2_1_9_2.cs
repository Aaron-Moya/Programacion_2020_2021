using System;

class Ejercicio_2_1_9_2
{
/* (2.1.9.2) Crea un programa que lea una letra tecleada por el usuario y diga si se
trata de un signo de puntuación (. , ; :), una cifra numérica (del 0 al 9) o algún otro
carácter, usando "switch" (pista: necesitarás que usar un dato de tipo "char"). */

	static void Main() {
		
		Console.Write("Dime un caracter, signo o numero del 0 al 9: ");
		char caracter = Convert.ToChar(Console.ReadLine());
		
		switch (caracter) {
			case '.': 
			case ',':
			case ';':
			case ':': Console.WriteLine("El dato introducido es un signo de puntuación");
					  break;
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9': Console.WriteLine("El dato introducido es un numero del 0 al 9");
					  break;
			default: Console.WriteLine("El dato introducido no es válido");
			break;
		}
	}
}
