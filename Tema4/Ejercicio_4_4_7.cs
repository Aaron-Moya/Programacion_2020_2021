using System;

class Ejercicios_4_4_7
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
					Ejercicio_4_4_7_1();
					break;
				case "2":
					Ejercicio_4_4_7_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_4_7_1()
	{
		/*(4.4.7.1) Un  programa  que  pida  al  usuario  una  frase  y  muestre  sus  palabras  en orden inverso.*/
		
		Console.Write("Dime una frase: ");
		string frase = Console.ReadLine();
		string[] elementos = frase.Split();
		
		for (int i = elementos.Length - 1; i >= 0; i--)
		{
			Console.Write(elementos[i] + " ");
		}
	}
	
	static void Ejercicio_4_4_7_2()
	{
		/*(4.4.7.2) Un programa que pida al usuario varios números separados por espacios y muestre su suma.*/
		
		Console.Write("Dime varios numeros separados por espacios: ");
		string numeros = Console.ReadLine();
		string[] datos = numeros.Split();
		
		int suma = 0;
		
		for (int i = 0; i < datos.Length; i++)
		{
			int num = Convert.ToInt32(datos[i]);
			suma += num;
		}
		
		Console.WriteLine("La suma de los datos es: {0}", suma);
	}
}
