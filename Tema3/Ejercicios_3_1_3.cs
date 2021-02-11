using System;

class Ejercicios_3_1_3
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
					Ejercicio_3_1_3_1();
					break;
				case "2":
					Ejercicio_3_1_3_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_1_3_1()
	{
		/*(3.1.3.1) Crea un programa que use tres variables enteras x,y,z. Sus valores
		iniciales serán 15, -10, 2.147.483.647. Se deberá incrementar el valor de estas
		variables. ¿Qué valores esperas que se obtengan? Contrástalo con el resultado obtenido por el programa.*/
		
		int num1 = 15;
		int num2 = -10;
		int num3 = 2147483647;
		
		Console.WriteLine(++num1);
		Console.WriteLine(++num2);
		Console.WriteLine(++num3);
	}
	
	static void Ejercicio_3_1_3_2()
	{
		/*(3.1.3.2) ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++;
		b=b*5; a=a*2; Calcúlalo a mano y luego crea un programa que lo resuelva, para ver si habías hallado la solución correcta.*/
		
		int a = 5;
		int b = ++a;
		int c = a++;
		b = b * 5;
		a = a * 2;
		
		Console.WriteLine("El resultado es: " + a);
	}
}
