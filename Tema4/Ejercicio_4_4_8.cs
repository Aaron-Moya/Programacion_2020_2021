using System;

class Ejercicios_4_4_8
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
					Ejercicio_4_4_8_1();
					break;
				case "2":
					Ejercicio_4_4_8_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_4_8_1()
	{
		/*(4.4.8.1) Un  programa que  pida  al  usuario dosfrasesy diga cuálseríala  "mayor" de ellas (la que aparecería en último lugar en un diccionario).*/
		
		Console.Write("Dime una frase: ");
		string frase1 = Console.ReadLine();
		Console.Write("Dime otra frase: ");
		string frase2 = Console.ReadLine();
		
		if (frase1.CompareTo(frase2) > 0)
		{
			Console.Write("La primera frase es mayor que la segunda");
		}
		else
		{
			Console.Write("La segunda frase es mayor que la primera");
		}
	}
	
	static void Ejercicio_4_4_8_2()
	{
		/*(4.4.8.2) Un  programa  que  pida  al  usuario  cinco  frases,  las  guarde  en  un  array  y muestre la "mayor" de ellas*/
		
		string[] frases = new string [5];
		for (int i = 0; i < 5; i++)
		{
			Console.Write("Dime una frase: ");
			frases[i] = Console.ReadLine();
		}
		
		string mayor = "";
		for (int i = 0; i < 5; i++)
		{
			if (frases[i].CompareTo(mayor) > 0)
			{
				mayor = frases[i];
			}
		}
		
		Console.Write("La frase mayor es {0}", mayor);
	}
}
