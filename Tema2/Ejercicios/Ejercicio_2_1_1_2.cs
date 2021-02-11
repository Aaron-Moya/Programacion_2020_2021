class Ejercicio_2_1_1_2
{
//(2.1.1.2) Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos

		static void Main()
		{
			System.Console.Write("Dime un numero: ");
			int num1 = System.Convert.ToInt32( System.Console.ReadLine());
			
			System.Console.Write("Dime otro numero: ");
			int num2 = System.Convert.ToInt32( System.Console.ReadLine());
			
			if (num1 > num2)
			{
				System.Console.WriteLine("El numero {0} es mayor que el numero {1}", num1, num2);
			}
			else
			{
				System.Console.WriteLine("El numero {1} es mayor que el numero {0}", num1, num2);
			}
		}
	
	
	
	
	
	
	
}
