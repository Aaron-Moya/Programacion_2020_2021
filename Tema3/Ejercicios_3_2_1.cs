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
					Ejercicio_3_2_1_1();
					break;
				case "2":
					Ejercicio_3_2_1_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_2_1_1()
	{
		/*(3.2.1.1) Crea un programa que muestre el resultado de dividir 3 entre 4, primero 
		 * usando números enteros y luego usando números de coma flotante.*/
		 int num1 = 3;
		 int num2 = 4;
		 
		 Console.WriteLine(num1/num2);
		 Console.WriteLine((float)num1/num2);
	}
	
	static void Ejercicio_3_2_1_2()
	{
		/*(3.2.1.2) ¿Cuál  sería  el  resultado  de  las siguientes  operaciones,  
		 * usando  números reales?  a=5; a/=2; a+=1; a*=3; --a;*/
		 
		 float a = 5f;
		 Console.WriteLine(a);
		 a /= 2;
		 Console.WriteLine(a);
		 a += 1;
		 Console.WriteLine(a);
		 a *= 3;
		 Console.WriteLine(a);
		 --a;
		 Console.WriteLine(a);

	}
}
