using System;

class Ejercicios_3_1_2
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
					Ejercicio_3_1_2_1();
					break;
				case "2":
					Ejercicio_3_1_2_2();
					break;
				case "3":
					Ejercicio_3_1_2_3();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_1_2_1()
	{
		/*(3.1.2.1) Pregunta al usuario su edad, que se guardará en un "byte". A
		continuación, le deberás decir que no aparenta tantos años (por ejemplo, "No aparentas 20 años").*/
		
		Console.Write("Dime tu edad: ");
		byte edad = Convert.ToByte(Console.ReadLine());
		
		Console.WriteLine("No aparentas {0} años", edad);
	}
	
	static void Ejercicio_3_1_2_2()
	{
		/*(3.1.2.2) Pide al usuario dos números de dos cifras ("byte"), calcula su
		multiplicación, que se deberá guardar en un "int", y muestra el resultado en pantalla.*/
		
		Console.Write("Dime un numero de dos cifras: ");
		byte num1 = Convert.ToByte(Console.ReadLine());
		
		Console.Write("Dime otro numero: ");
		byte num2 = Convert.ToByte(Console.ReadLine());
		
		int resultado = num1 * num2;
		Console.WriteLine("El resultado es {0}", resultado);
		
	}
	
	static void Ejercicio_3_1_2_3()
	{
		/*(3.1.2.3) Pide al usuario dos números enteros largos ("long") y muestra su suma, su resta y su producto.*/
		
		Console.Write("Dime un numero entero largo: ");
		long num1 = Convert.ToInt64(Console.ReadLine());
		
		Console.Write("Dime otro numero: ");
		long num2 = Convert.ToInt64(Console.ReadLine());
		
		long suma = num1 + num2;
		long resta = num1 - num2;
		long producto = num1 * num2;
		
		Console.WriteLine("El resultado de la suma es {0}", suma);
		Console.WriteLine("El resultado de la resta es {0}", resta);
		Console.WriteLine("El resultado de la multiplicacion es {0}", producto);

	}
}
