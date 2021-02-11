using System;

class Ejercicios_3_1_6
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
					Ejercicio_3_1_6_1();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_1_6_1()
	{
		/*(3.1.6.1) Crea un programa que pida al número del 0 al 255 y muestre el resultado de 
		 * hacer   un XOR con un cierto   dato   prefijado (y   también   en   ese   rango). 
		 * Comprueba que la operación es reversible (por ejemplo, 131 xor 5 = 134, y 134 xor 5 = 131)*/
		 
		 Console.Write("Dime un numero del 0 al 255: ");
		 int numero = Convert.ToInt32(Console.ReadLine());
		 int numero2 = 5;
		 int resultado = numero ^ numero2;
		 
			Console.WriteLine("{0} xor {1} = {2}, y {2} xor {1} = {0}", numero, numero2, resultado);
	}
}
