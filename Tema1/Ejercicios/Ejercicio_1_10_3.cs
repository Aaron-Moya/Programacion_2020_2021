class Ejercicio1103 
{
		static void Main()
		{
			// (1.10.3) Suma tres números tecleados por usuario.
			
			System.Console.Write("Dime el primer número: ");
			int num1 = System.Convert.ToInt32( System.Console.ReadLine() );
			
			System.Console.Write("Dime el segundo número: ");
			int num2 = System.Convert.ToInt32( System.Console.ReadLine() );
			
			System.Console.Write("Dime el tercer número: ");
			int num3 = System.Convert.ToInt32( System.Console.ReadLine () );
			
			System.Console.WriteLine("La suma de los tres números es: " + (num1 + num2 + num3));
		}
	
	
}
