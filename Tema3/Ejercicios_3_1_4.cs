using System;

class Ejercicios_3_1_4
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
					Ejercicio_3_1_4_1();
					break;
				case "2":
					Ejercicio_3_1_4_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_1_4_1()
	{
		/*(3.1.4.1) Crea un programa que use tres variables x,y,z. Sus valores iniciales serán
		15, -10, 214. Deberás incrementar el valor de estas variables en 12, usando el
		formato abreviado. ¿Qué valores esperas que se obtengan? Contrástalo con el resultado obtenido por el programa*/
		
		int x = 15;
		int y = -10;
		int z = 214;
		
		Console.WriteLine((x += 15));
		Console.WriteLine((y += 15));
		Console.WriteLine((z += 15));
	}
	
	static void Ejercicio_3_1_4_2()
	{
		/*(3.1.4.2) ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3;
		c=-3; c*=2; ++c; a*=b; Crea un programa que te lo muestre.*/
		
		int a = 5;
		Console.WriteLine(a);
		int b = a + 2;
		Console.WriteLine(b);
		b -= 3;
		Console.WriteLine(b);
		int c =-3;
		Console.WriteLine(c);
		c *= 2;
		Console.WriteLine(c);
		++c;
		Console.WriteLine(c);
		a *= b;
		Console.WriteLine(a);
	}
}
