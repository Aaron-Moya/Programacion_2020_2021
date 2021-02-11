using System;

class Ejercicios_3_3_1
{
	static void Main()
	{
		string op = "1";
		do
		{
			Console.WriteLine("\n\n1- Ejercicio 1\n" +
							  "2- Ejercicio 2\n" +
							  "3- Ejercicio 3\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_3_3_1_1();
					break;
				case "2":
					Ejercicio_3_3_1_2();
					break;
				case "3":
					Ejercicio_3_3_1_3();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_3_1_1()
	{
		/*(3.3.1.1) Crea un programa que pida una letra al usuario y diga si se trata de una vocal.*/
		
		Console.Write("Dime una letra: ");
		char letra = Convert.ToChar(Console.ReadLine());
		
		switch (letra)
		{
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u': 
				Console.WriteLine("La letra es una vocal"); break;
			default: 
				Console.WriteLine("La letra es una consonante");
				break;
		}
	}
	
	static void Ejercicio_3_3_1_2()
	{
		/*(3.3.1.2) Crea  un  programa  que muestre letras  alternas (una  sí  y  una  no) entre  la que  teclee  el  usuario  y  la  "z".  
		 * Por  ejemplo,  si  el  usuario  introduce  una  "a",  se escribirá "aceg...".*/
		 
		Console.Write("Dime una letra: ");
		char letra = Convert.ToChar(Console.ReadLine());
		 
		 for (char i = letra; i <= 'z'; i++)
		 {
			 Console.Write(i);
			 i++;
		 }
	}
	
	static void Ejercicio_3_3_1_3()
	{
		/*(3.3.1.3) Crea  un programa  quepida al  usuario  el  ancho  (por ejemplo,  4)  y  el  alto (por  ejemplo,  3)  y  una letra  (por  ejemplo,  X)  
		 * y escriba  un  rectángulo formado  por esa cantidad de letras:
		 * XXXX
		 * XXXX
		 * XXXX*/
		 
		Console.Write("Dime el ancho: ");
		int ancho = Convert.ToInt32(Console.ReadLine());
		Console.Write("Dime el alto: ");
		int alto = Convert.ToInt32(Console.ReadLine());
		Console.Write("Dime una letra: ");
		char letra = Convert.ToChar(Console.ReadLine());
		
		for (int i = 1; i <= alto; i++)
		{
			for (int j = 1; j <= ancho; j++)
			{
				Console.Write(letra);
			}
			Console.WriteLine();
		}
	}
}
