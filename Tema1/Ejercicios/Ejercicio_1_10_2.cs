class Ejercicio1102
{
	static void Main()
	{
		/* (1.10.2) Crea un programa que calcule la división de dos números introducidos por
			el usuario, así como el resto de esa división. */
			
		System.Console.Write("Dime un número: ");
		int num1 = System.Convert.ToInt32( System.Console.ReadLine() );
		
		System.Console.Write("Dime otro número: ");
		int num2 = System.Convert.ToInt32( System.Console.ReadLine() );
		
		System.Console.WriteLine("El resultado de la división es: " + num1 / num2);
		System.Console.WriteLine("El resto de la división es: " + num1 % num2);

	}
}

