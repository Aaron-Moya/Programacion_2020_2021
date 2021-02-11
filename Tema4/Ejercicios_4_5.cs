using System;

class Ejercicios_4_5
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
					Ejercicio_4_5_1();
					break;
				case "2":
					Ejercicio_4_5_2();
					break;
				case "3":
					Ejercicio_4_5_3();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_5_1()
	{
		/*(4.5.1) Un programa que pida tu nombre y lo muestre con un espacio entre cada par de letras, usando "foreach*/
		
		Console.Write("Dime tu nombre: ");
		string nombre = Console.ReadLine();
		int longitud = -1;
		
		foreach (char letra in nombre)
		{
			if (longitud % 2 == 0)
			{
				Console.Write(letra + " ");
			}
			else
			{
				Console.Write(letra);
			}
			longitud++;
		}
	}
	
	static void Ejercicio_4_5_2()
	{
		/*(4.5.2) Un   programa   que   pida al   usuario   una   frase   y   la   descomponga   en subcadenas  separadas  por  espacios,  usando  "Split".  
		 * Luego  debe  mostrar  cada subcadena en una línea nueva, usando "foreach".*/
		 
		 char delimitador = ' ';
		 Console.Write("Dime una frase: ");
		 string frase = Console.ReadLine();
		 string[] frasePartida = frase.Split(delimitador);
		 
		 foreach (string subcadena in frasePartida)
		 {
			 Console.WriteLine(subcadena);
		 }
	}
	
	static void Ejercicio_4_5_3()
	{
		/*(4.5.3) Un programa que pida al usuario varios números separados por espacios y muestre su suma (como el del ejercicio 4.4.7.2), empleando "foreach"*/
		
		char delimitador = ' ';
		Console.Write("Dime varios numeros: ");
		string numeros = Console.ReadLine();
		string[] numerosCadena = numeros.Split(delimitador);
		int suma = 0;
		
		foreach (string numero in numerosCadena)
		{
			int numeroInt = Convert.ToInt32(numero);
			suma += numeroInt;
		}
		Console.WriteLine("La suma es: " + suma);
	}
}
