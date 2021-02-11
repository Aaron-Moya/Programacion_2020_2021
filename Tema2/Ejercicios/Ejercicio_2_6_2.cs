using System;

class Ejercicio_2_6_1
{
/*(2.6.2) Crea un programa que pregunte al usuario su edad y su año de nacimiento.
Si la edad que introduce no es un número válido, mostrará un mensaje de aviso,
pero aun así le preguntará su año de nacimiento.*/	

	static void Main()
	{
		int edad, anyo;
		
		try
		{
			Console.Write("Dime tu edad: ");
			edad = Convert.ToInt32(Console.ReadLine());
		}
		catch (FormatException)
		{
			Console.WriteLine("La edad introducida no es un número válido");
		}
		
		try
		{
			Console.Write("Dime tu año de nacimiento: ");
			anyo = Convert.ToInt32(Console.ReadLine());
		}
		catch (FormatException)
		{
			Console.WriteLine("El año introducido no es un número válido");
		}
	}
}
