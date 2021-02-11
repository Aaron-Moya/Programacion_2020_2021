using System;

class Ejercicio_4_4_2_1
{
/*(4.4.2.1) Crea un programa que pregunte al usuario su nombre y le responda cuál es su inicial.*/	

	static void Main()
	{
		Console.Write("Dime tu nombre: ");
		string nombre = Console.ReadLine();
		
		Console.WriteLine("La inicial de tu nombre es {0}", nombre[0]);
	}
}
