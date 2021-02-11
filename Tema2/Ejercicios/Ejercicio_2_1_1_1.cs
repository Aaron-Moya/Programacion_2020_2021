class Ejercicio_2_1_1_1
{
	
/* (2.1.1.1) Crea un programa que pida al usuario un número entero y diga si es par
(pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero: if (x % 2 == 0) …).
*/

	static void Main()
	{
		System.Console.Write("Dime un numero entero: ");
		int num1 = System.Convert.ToInt32( System.Console.ReadLine());
		
		if (num1 % 2 == 0)
		{
			System.Console.WriteLine("El numero {0} es par", num1);
		} 
		else
		{
			System.Console.WriteLine("El numero {0} no es par", num1);
		}
	
	
	}
}
