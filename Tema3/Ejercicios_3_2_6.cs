using System;

class Ejercicios_3_2_6
{
	static void Main()
	{
		string op = "1";
		do
		{
			Console.WriteLine("\n\n1- Ejercicio 1\n" +
							  "2- Ejercicio 2\n" +
							  "3- Ejercicio 3\n" +
							  "4- Ejercicio 4\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_3_2_6_1();
					break;
				case "2":
					Ejercicio_3_2_6_2();
					break;
				case "3":
					Ejercicio_3_2_6_3();
					break;
				case "4":
					Ejercicio_3_2_6_4();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_2_6_1()
	{
		/*(3.2.6.1) Crea un programa que pida números (en base 10) al usuario y muestre su equivalente  en  sistema  binario  y  
		 * en  hexadecimal.  Debe  repetirse  hasta  que  el usuario introduzca el número 0.*/
		 
		 int num = 1;
		 
		 do {
			 Console.Write("Dime un numero(0 para salir): ");
			 num = Convert.ToInt32(Console.ReadLine());
			 
			 Console.WriteLine("El numero {0}, en binario es: " + Convert.ToString(num, 2), num);
			 Console.WriteLine("El numero {0}, en hexadecimal es: " + Convert.ToString(num, 16), num);
		} while (num != 0);
	}
	
	static void Ejercicio_3_2_6_2()
	{
		/*(3.2.6.2) Crea  un  programa  que  pida  al  usuario  la  cantidad  de  rojo (por  ejemplo, 255),  
		 * verde  (por  ejemplo,  160)  y  azul  (por  ejemplo,  0)  que  tiene  un  color,  y  
		 * que muestre ese color RGB en notación hexadecimal (por ejemplo, FFA000)*/
		 
		Console.Write("Dime la cantidad de rojo: ");
		int rojo = Convert.ToInt32(Console.ReadLine());
		Console.Write("Dime la cantidad de verde: ");
		int verde = Convert.ToInt32(Console.ReadLine());
		Console.Write("Dime la cantidad de azul: ");
		int azul = Convert.ToInt32(Console.ReadLine());
		
		int rgb = rojo + verde + azul;
		Console.WriteLine("El color RGB en hexadecimal es: " + Convert.ToString(rgb, 16));
	}
	
	static void Ejercicio_3_2_6_3()
	{
		/*(3.2.6.3) Crea un programa para mostrar los números del 0 a 255 en hexadecimal, en 16 filas de 16 columnas cada una 
		 * (la primera fila contendrá los números del 0 al 15 –decimal-, la segunda del 16 al 31 –decimal-y así sucesivamente)*/
		 
		 int numeros = 0;
		 for (int i = 1; i <= 16; i++)
		 {
			for (int j = 1; j <= 16; j++)
			{
				if (numeros <= 255)
				{
					Console.WriteLine("El numero {0} en hexadecimal es: " + Convert.ToString(numeros, 16), numeros);
					numeros += 1;
				}
			}
			Console.WriteLine();
		 }
	}
	
	static void Ejercicio_3_2_6_4()
	{
		/*(3.2.6.4) Crea  un  programa  que  pida  números  binarios  al  usuario  y  muestre  su equivalente  en  sistema  hexadecimal  y  en  decimal.  
		 * Debe  repetirse  hasta  que  el usuario introduzca la palabra "fin".*/
		 
		 int num;
		 
		 do {
			 Console.Write("Dime un numero binario(0 para salir): ");
			 num = Convert.ToInt32(Console.ReadLine());
			 
			 Console.WriteLine("El numero {0} en hexadecimal es: " + Convert.ToString(num, 16), num);
			 Console.WriteLine("El numero {0} en decimal es: " + Convert.ToString(num, 10), num);
			 
		 } while (num != 0);
	}
}
