using System;

class Ejercicio_2_6_1
{
/*(2.6.1) Crea un programa que pregunte al usuario su edad y su año de nacimiento.
Si la edad que introduce no es un número válido, mostrará un mensaje de aviso y
se detendrá. Lo mismo ocurrirá si el año de nacimiento no es un número válido*/	

	static void Main()
	{
		int edad, anyo;
		
		try
		{
			Console.Write("Dime tu edad: ");
			edad = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Dime tu año de nacimiento: ");
			anyo = Convert.ToInt32(Console.ReadLine());
			
		}
		catch (FormatException)
		{
			Console.WriteLine("El dato introducido no es válido");
		}
	}
}
