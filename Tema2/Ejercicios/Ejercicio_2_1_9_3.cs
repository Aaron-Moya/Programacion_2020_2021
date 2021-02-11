using System;

class Ejercicio_2_1_9_3
{
/* (2.1.9.3) Crea un programa que lea una letra tecleada por el usuario y diga si se
trata de una vocal, una cifra numérica o una consonante, usando "switch" */	

	static void Main() {
		Console.Write("Dime una vocal, consonante o un numero del 0 al 9: ");
		char caracter = Convert.ToChar(Console.ReadLine());
		
		switch (caracter) {
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u': Console.WriteLine("El dato introducido es una vocal");
					  break;
			case 'b':
			case 'd':
			case 'f':
			case 'g':
			case 'h':
			case 'j':
			case 'k':
			case 'l':
			case 'm':
			case 'n':
			case 'ñ':
			case 'p':
			case 'r':
			case 's':
			case 't':
			case 'v':
			case 'x':
			case 'y':
			case 'z': Console.WriteLine("El dato introducido es una consonante");
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
		}
	}
}
