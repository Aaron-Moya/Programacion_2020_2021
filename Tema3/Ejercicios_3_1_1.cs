using System;

class Ejercicios_3_1_1
{
	static void Main()
	{
		string op = "1";
		do
		{
			Console.WriteLine("\n\n1- Ejercicio 1\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_3_1_1_1();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_1_1_1()
	{
		/*(3.1.1.1) Calcula el producto de 1.000.000 por 1.000.000, usando una variable
		llamada "producto", de tipo "long". Prueba también a calcularlo usando una variable de tipo "int"*/
		
		long a = 1000000;
		long b = 1000000;
		
		long producto = a * b;
		Console.WriteLine(producto);
		
		int c = 1000000;
		int d = 1000000;
		
		int producto2 = c * d;
		Console.WriteLine(producto2);
		
	}
}
