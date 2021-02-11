class Ejercicio1101
{
	static void Main()
	{
		/* (1.10.1) Crea un programa que calcule el producto de dos números introducidos por el usuario */
			
		System.Console.Write("Dime un número: ");
		int num1 = System.Convert.ToInt32( System.Console.ReadLine() );
		
		System.Console.Write("Dime otro número: ");
		int num2 = System.Convert.ToInt32( System.Console.ReadLine() );
		
		System.Console.WriteLine("El resultado es: " + (num1 * num2));
	}
}

