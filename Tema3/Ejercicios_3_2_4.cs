using System;

class Ejercicios_3_2_4
{
	static void Main()
	{
		string op = "1";
		do
		{
			Console.WriteLine("\n\n1- Ejercicio 1\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_3_2_4_1();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_2_4_1()
	{
		/*(3.2.4.1) Crea un   programa   que   calcule   la   raíz   cuadrada   del   número   que introduzca el usuario. 
		 * La raíz se deberá calcular como "double", pero el resultado se mostrará como "float". 
		 * (Recuerda: como viste al hacer el ejercicio 3.2.3.3, la raíz cuadrada de un número x se calcula con Math.Sqrt(x)).*/
		 
		 Console.Write("Dime un numero: ");
		 double num = Convert.ToInt32(Console.ReadLine());
		 
		 Console.WriteLine("La raiz cuadrada el nunero {0} es: " + (Math.Sqrt((float)num)), num);
		 
		 
	}
}
