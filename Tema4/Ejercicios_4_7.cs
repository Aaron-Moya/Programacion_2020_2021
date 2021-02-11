using System;

class Ejercicios_4_7
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
					Ejercicio_4_7_1();
					break;
				case "2":
					Ejercicio_4_7_2();
					break;
				case "3":
					Ejercicio_4_7_3();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_7_1()
	{
		/*(4.7.1) Un programa que pida al usuario 6 números en coma flotante y los muestre ordenados de menor a mayor.Escoge el método de ordenación que prefieras.*/
		
		float[] numeros = new float[6];
		for (int i = 0; i < 6; i++)
		{
			Console.Write("Dime un numero: ");
			numeros[i] = Convert.ToSingle(Console.ReadLine());
		}
		
		for (int i = 0; i < numeros.Length - 1; i++)
		{
			for (int j = i + 1; j < numeros.Length; j++)
			{
				if (numeros[i] > numeros[j])
				{
					float aux = numeros[i];
					numeros[i] = numeros[j];
					numeros[j] = aux;
				}
			}
		}
		
		foreach (float numero in numeros)
		{
			Console.WriteLine(numero);
		}
	}
	
	static void Ejercicio_4_7_2()
	{
		/*(4.7.2) Un  programa  que  pida  al  usuario  5  nombres  y  los  muestre  ordenados alfabéticamente
		 * (recuerda que para comparar cadenas no podrás usar el símbolo ">", sino "CompareTo").*/
		 
		string[] nombres = new string[5];
		for (int i = 0; i < 5; i++)
		{
			Console.Write("Dime un nombre: ");
			nombres[i] = Console.ReadLine();
		}
		
		for (int i = 0; i < nombres.Length - 1; i++)
		{
			for (int j = i + 1; j < nombres.Length; j++)
			{
				if (nombres[i].CompareTo(nombres[j]) > 0)
				{
					string aux = nombres[i];
					nombres[i] = nombres[j];
					nombres[j] = aux;
				}
			}
		}
		
		foreach (string nombre in nombres)
		{
			Console.WriteLine(nombre);
		}
	}
	
	static void Ejercicio_4_7_3()
	{
		/*(4.7.3) Un programa que pida al usuario varios números, los vaya añadiendo a un array,  mantenga  el  array  ordenado  continuamente  y 
		 *  muestre  el contenido  tras añadir   cada   nuevo   dato(todos   los   datos   se   
		 * mostrarán   en   la   misma   línea, separados por espacios en blanco).
		 *  Terminará cuando el usuario teclee "fin"en vez de un numero*/
		 
		 int[] numeros = new int[7];
		 for (int i = 0; i < numeros.Length; i++)
		 {
			 Console.WriteLine("Introduce un numero: ");
			 numeros[i] = Convert.ToInt32(Console.ReadLine());
			 
			 for (int k = 0; k < numeros.Length - 1; k++)
			 {
				 for (int j = k + 1; j < numeros.Length; j++)
				 {
					 if (numeros[k] > numeros[j])
					 {
						 int aux = numeros[k];
						 numeros[k] = numeros[j];
						 numeros[j] = aux;
					 }
				 }
				 foreach (int numero in numeros)
				 {
					Console.Write(numero + " ");
				 }
			 }
		 }
		 
		 
	}
}
