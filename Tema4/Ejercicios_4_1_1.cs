using System;

class Ejercicios_4_1_1
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
					Ejercicio_4_1_1_1();
					break;
				case "2":
					Ejercicio_4_1_1_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_1_1_1()
	{
		/*(4.1.1.1) Un programa que pida al usuario 4 números, los memorice (utilizando un array),  calcule  
		 * su  media  aritmética  y  después  muestre  en  pantalla  la  media  y  los datos tecleados*/
		 
		 int[] numeros = new int[4];
		 int suma = 0;
		 
		 Console.Write("Dime el primer numero: ");
		 numeros[0] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el segundo numero: ");
		 numeros[1] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el tercer numero: ");
		 numeros[2] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el cuarto numero: ");
		 numeros[3] = Convert.ToInt32(Console.ReadLine());
		 
		 
		 Console.Write("La media de los numeros: ");
		 for (int i = 0; i < 4; i++)
		 {
			suma += numeros[i];
			Console.Write(numeros[i] + " ");
		 }
		 Console.Write("es: " + (suma / 4));
		 
	}
	
	static void Ejercicio_4_1_1_2()
	{
		/*(4.1.1.2) Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") y 
		 * luego los muestre en el orden contrario al que se introdujeron.*/
		 
		 float[] numeros = new float[5];
		 
		 Console.Write("Dime el primer numero: ");
		 numeros[0] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el segundo numero: ");
		 numeros[1] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el tercer numero: ");
		 numeros[2] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el cuarto numero: ");
		 numeros[3] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el quinto numero: ");
		 numeros[4] = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Los numeros introducidos al contrario son: ");
		 for (int i = 4; i >= 0; i--)
		 {
			 Console.Write(numeros[i] + " ");
		 }
	}
}
