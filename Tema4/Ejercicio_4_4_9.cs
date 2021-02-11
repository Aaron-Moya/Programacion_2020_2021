using System;
using System.Text;

class Ejercicios_4_4_9
{
	static void Main()
	{
		string op = "1";
		do
		{
			Console.WriteLine("\n\n1- Ejercicio 1\n" +
							  "2- Ejercicio 2\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_4_4_9_1();
					break;
				case "2":
					Ejercicio_4_4_9_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_4_9_1()
	{
		/*(4.4.9.1) Prepara un programa que pida una cadena al usuario y la  modifique, de modo que todas las vocales se conviertan en "o".*/
		
		Console.Write("Dime una cadena: ");
		StringBuilder cadena = new StringBuilder(Console.ReadLine());
		
		for (int i = 0; i < cadena.Length; i++)
		{
			switch (cadena[i])
			{
				case 'a': cadena[i] = 'o'; break;
				case 'e': cadena[i] = 'o'; break;
				case 'i': cadena[i] = 'o'; break;
				case 'u': cadena[i] = 'o'; break;
			}
		}
		
		for (int i = 0; i < cadena.Length; i++)
		{
			Console.Write(cadena[i]);
		}
	}
	
	static void Ejercicio_4_4_9_2()
	{
		
	}
}
