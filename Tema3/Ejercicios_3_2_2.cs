using System;

class Ejercicios_3_2_1
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
					Ejercicio_3_2_2_1();
					break;
				case "2":
					Ejercicio_3_2_2_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_2_2_1()
	{
		/*(3.2.2.1) Crea un programa que muestre el resultado de dividir 13 entre 6 usando números  enteros,  
		 * luego  usando  números  de  coma  flotante  de  simple  precisión  y luego con números de doble precisión.*/
		 
		 int num1 = 13;
		 int num2 = 6;
		 
		 Console.WriteLine(num1 / num2);
		 Console.WriteLine((float)num1 / num2);
		 Console.WriteLine((double)num1 / num2);
	}
	
	static void Ejercicio_3_2_2_2()
	{
		/*(3.2.2.2) Calcula el área  de  un  círculo,  dado  su  radio,  que  será  
		 * un  número  entero(área = pi * radio al cuadrado). Usa datos de doble precisión.*/
		 
		 double radio = 5;
		 double pi = 3.14159;
		 double resultado = pi * radio * 2;
		 Console.WriteLine("El área es: {0}", resultado);
	}
}
