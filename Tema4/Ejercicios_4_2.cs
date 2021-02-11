using System;

class Ejercicios_4_2
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
					Ejercicio_4_2_1();
					break;
				case "2":
					Ejercicio_4_2_2();
					break;
				case "3":
					Ejercicio_4_2_3();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_2_1()
	{
		/*(4.2.1) Un  programa  que  pida  al  usuario  dos  bloques  de  10  números  enteros (usando  un  array  de  dos  dimensiones).  
		 * Después  deberá  mostrar  el  mayor  dato que se ha introducido en cada uno de ellos.*/
		 
		 int[,] datos = new int[2,10];
		 int mayor = 0;
		 int numero;
		 
		 for (int i = 0; i < datos.GetLength(0); i++)
		 {
			 for (int j = 0; j < datos.GetLength(1); j++)
			 {
				 Console.Write("Dime un numero: ");
				 numero = Convert.ToInt32(Console.ReadLine());
				 
				 datos[i,j] = numero;
			 }
		 }
		 
		 for (int i = 0; i < datos.GetLength(0); i++)
		 {
			 for (int j = 0; j < datos.GetLength(1); j++)
			 {
				 if (datos[i,i] > mayor)
				 {
					 mayor = datos[i,j];
				 }
			 }
		 }
		 
		 Console.WriteLine("El numero mas grande es: {0}", mayor);
	}
	
	static void Ejercicio_4_2_2()
	{
		/*(4.2.2) Un  programa  que  pida  al  usuario  dos  bloques  de  6  cadenas  de  texto. 
		 * Después  pedirá  al  usuario  una  nueva  cadena  y  comprobará  si  aparece en  alguno de los dos bloques de información anteriores.*/
		 
		 string[,] cadenas = new string[2,6];
		 string cadena;
		 
		 for (int i = 0; i < cadenas.GetLength(0); i++)
		 {
			 for (int j = 0; j < cadenas.GetLength(1); j++)
			 {
				Console.Write("Dime una cadena de texto: ");
				cadena = Console.ReadLine();
				
				cadenas[i,j] = cadena;
			 }
		 }
		 
		 Console.Write("Dime una cadena de texto para comprobar si aparece: ");
		 cadena = Console.ReadLine();
		 
		 for (int i = 0; i < cadenas.GetLength(0); i++)
		 {
			 for (int j = 0; j < cadenas.GetLength(1); j++)
			 {
				 if (cadenas[i,j] == cadena)
				 {
					 Console.WriteLine("La cadena {0} si aparece", cadena);
				 }
				 else 
				 {
					 Console.WriteLine("La cadena no aparece");
				 }
			 }
		}
	}
	
	static void Ejercicio_4_2_3()
	{
		/*(4.2.3) Un programa que pregunte al usuario el tamaño que tendrán dos bloques de  números  enteros (por ejemplo,  uno  de  10  elementos  y  otro  de  12).
		 *Luego pedirá  los  datos  para  ambos  bloques  de  datos.  Finalmentedeberá  mostrar  el mayor dato que se ha introducido en cada uno de ellos.*/
		 
		 int[][] numeros;
		 numeros = new int[2][];
		 int tamanyoBloque;
		 int numero;
		 
		 Console.Write("Dime el tamaño del primer bloque: ");
		 tamanyoBloque = Convert.ToInt32(Console.ReadLine());
		 numeros[0] = new int[tamanyoBloque];
		 
		 Console.Write("Dime el tamaño del segundo bloque: ");
		 tamanyoBloque = Convert.ToInt32(Console.ReadLine());
		 numeros[1] = new int[tamanyoBloque];
		 
		 for (int i = 0; i < numeros.Length; i++)
		 {
			 for (int j = 0; j < numeros[i].Length; j++)
			 {
				 Console.Write("Dime un numero: ");
				 numero = Convert.ToInt32(Console.ReadLine());
				 
				 numeros[i][j] = numero;
			 }
		 }
		 
		 int mayor1 = 1;
		 int mayor2 = 1;
		 
		 for (int i = 0; i < numeros.Length; i++)
		 {
			 for (int j = 0; j < numeros[i].Length; j++)
			 {
				 if (numeros[0][j] > mayor1)
				 {
					 mayor1 = numeros[0][j];
				 }
				 
				 if (numeros[1][j] > mayor2)
				 {
					 mayor2 = numeros[1][j];
				 }
			 }
		 }
		 
		 Console.WriteLine("El numero mas grande del bloque 1 es: " + mayor1);
		 Console.WriteLine("El numero mas grande del bloque 2 es: " + mayor2);
	}
}
