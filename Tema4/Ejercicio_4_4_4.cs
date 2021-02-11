using System;

class Ejercicios_4_4_4
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
					Ejercicio_4_4_4_1();
					break;
				case "2":
					Ejercicio_4_4_4_2();
					break;
				case "3":
					Ejercicio_4_4_4_3();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_4_4_1()
	{
		/*(4.4.4.1) Un programa que te pida tu nombre y lo muestre en pantalla separando cada  letra  de  la  siguiente  con  un  espacio,  similar  al  4.4.3.1,  
		 * pero  esta  vez  usando "Substring". Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla "J u a n".*/
		 
		 Console.Write("Dime tu nombre: ");
		 string nombre = Console.ReadLine();
		 int longitud = nombre.Length;
		 
		 for (int i = 0; i < longitud; i++)
		 {
			 Console.Write(nombre.Substring(i, 1) + " ");
		 }
	}
	
	static void Ejercicio_4_4_4_2()
	{
		/*(4.4.4.2) Un  programa  que  te  pida  tu  nombre  y  lo  muestre  en  pantalla  como  un triángulo  creciente.*/
		
		 Console.Write("Dime tu nombre: ");
		 string nombre = Console.ReadLine();
		 int longitud = nombre.Length;
		 
		 for (int filas = 0; filas <= longitud; filas++)
		 {
			 Console.WriteLine(nombre.Substring(0, filas));
		 }
	}
	
	static void Ejercicio_4_4_4_3()
	{
		/*(4.4.4.3) Un  programa  que  te  pida  tu  nombre  y  lo  muestre  en  pantalla  como  un triángulo creciente desde la derecha*/
		
		 Console.Write("Dime tu nombre: ");
		 string nombre = Console.ReadLine();
		 int longitud = nombre.Length;
		 		 
		 for (int filas = 0; filas <= longitud; filas++)
         {
            Console.WriteLine(nombre.Substring(filas, 0));
         }
	}
}
