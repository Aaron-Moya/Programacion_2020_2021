using System;

class Ejercicio_2_2_14
{
/*(2.2.14.1) Crea un programa que escriba los números del 1 al 10, separados por un
espacio, sin avanzar de línea. No puedes usar "for", ni "while", ni "do..while", sólo "if" y "goto"*/

	static void Main()
	{
		Console.Write("Dime un numero del 1 al 10: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		if (num1 >= 1 && num1 <= 10)
		{
			goto numeros;
		}
		
		
		
		numeros: 
			Console.Write(1 + " " + 2 + " " + 3 + " " + 4 + " " + 5 + " " + 6 +
			 " " + 7 + " " + 8 + " " + 9 + " " + 10);
	}
}
