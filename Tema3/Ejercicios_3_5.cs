using System;

class Ejercicios_3_5
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
							  "5- Ejercicio 5\n" +
							  "6- Ejercicio 6\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_3_5_1();
					break;
				case "2":
					Ejercicio_3_5_2();
					break;
				case "3":
					Ejercicio_3_5_3();
					break;
				case "4":
					Ejercicio_3_5_4();
					break;
				case "5":
					Ejercicio_3_5_5();
					break;
				case "6":
					Ejercicio_3_5_6();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_5_1()
	{
		/*(3.5.1) Crea un programa que use el operador condicional para dar a una variable llamada "iguales" (booleana) 
		 * el valor "true" si los dos números que ha tecleado el usuario son iguales, o "false" si son distintos.*/
		 
		 Console.Write("Dime un numero: ");
		 int num1 = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime otro numero: ");
		 int num2 = Convert.ToInt32(Console.ReadLine());
		 
		 bool iguales = num1 == num2 ? true : false;
		 
		 if (iguales == true)
		 {
			 iguales = true;
			 Console.WriteLine("Los dos numeros son iguales");
		 }
		 else
		 {
			 iguales = false;
			 Console.WriteLine("Los dos numeros no son iguales");
		 }
	}
	
	static void Ejercicio_3_5_2()
	{
		/*(3.5.2) Crea  una  versión  alternativa  del  ejercicio  3.5.1,  que  use  "if"  en  vez  del operador condicional.*/
		
		bool iguales = true;
		 
		 Console.Write("Dime un numero: ");
		 int num1 = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime otro numero: ");
		 int num2 = Convert.ToInt32(Console.ReadLine());
		 
		 if (num1 == num2 && iguales == true)
		 {
			 iguales = true;
			 Console.WriteLine("Los dos numeros son iguales");
		 }
		 else
		 {
			 iguales = false;
			 Console.WriteLine("Los dos numeros no son iguales");
		 }
	}
	
	static void Ejercicio_3_5_3()
	{
		/*(3.5.3) Crea  una  versión  alternativa  del ejercicio  3.5.1,  que asigne  directamente  el valor al booleano a partir de una comparación.*/
		
		 bool iguales = true;
		 
		 Console.Write("Dime un numero: ");
		 int num1 = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime otro numero: ");
		 int num2 = Convert.ToInt32(Console.ReadLine());
		 
		 if (num1 == num2) iguales = true; else iguales = false;

		 if (iguales == true)
		 {
			 Console.WriteLine("Los dos numeros son iguales");
		 }
		 else 
		 {
			 Console.WriteLine("Los dos numeros no son iguales");
		 }
	}
	
	static void Ejercicio_3_5_4()
	{
		/*(3.5.4) Crea un programa que use el operador condicional para dar a una variable llamada  "ambosPares"  (booleana) el valor  "true" 
		 * si  dos  números  introducidos  por el usuario son pares, o "false" si alguno es impar.*/
		 
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Dime otro numero: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		bool ambosPares = num1 % 2 == 0 && num2 % 2 == 0 ? true : false;
		
		if (ambosPares == true)
		{
			Console.WriteLine("Ambos numeros son pares");
		}
		else
		{
			Console.WriteLine("Algun numero es impar");
		}
		 
	}
	
	static void Ejercicio_3_5_5()
	{
		/*(3.5.5) Crea  una  versiónalternativa  del ejercicio  3.5.4,  que  use  "if"  en  vez  del operador condicional.*/
		
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Dime otro numero: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		bool ambosPares = true;
				
		if (num1 % 2 == 0 && num2 % 2 == 0 && ambosPares == true)
		{
			ambosPares = true;
			Console.WriteLine("Ambos numeros son pares");
		}
		else
		{
			ambosPares = false;
			Console.WriteLine("Algun numero es impar");
		}
		
	}
	
	static void Ejercicio_3_5_6()
	{
		/*(3.5.6) Crea  una  versiónalternativa  del ejercicio  3.5.5,  que asigne  directamente  el valor al booleano a partir de una comparación.*/
		
		bool ambosPares = true;
		 
		 Console.Write("Dime un numero: ");
		 int num1 = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime otro numero: ");
		 int num2 = Convert.ToInt32(Console.ReadLine());
		 
		 if (num1 % 2 == 0 && num2 % 2 == 0) ambosPares = true; else ambosPares = false;

		 if (ambosPares == true)
		 {
			 Console.WriteLine("Los dos numeros son pares");
		 }
		 else 
		 {
			 Console.WriteLine("Algun numero es impar");
		 }
	}
}
