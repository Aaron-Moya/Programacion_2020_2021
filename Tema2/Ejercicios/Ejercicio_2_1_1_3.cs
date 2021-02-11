class Ejercicio_2_1_1_3
{
/*(2.1.1.3) Crea un programa que pida al usuario dos números enteros y diga si el
primero es múltiplo del segundo (pista: igual que en el ejercicio 2.1.1.1, habrá que
ver si el resto de la división es cero: a % b == 0). */

	static void Main()
	{
		System.Console.Write("Dime el primer numero: ");
		int num1 = System.Convert.ToInt32( System.Console.ReadLine());
		
		System.Console.Write("Dime el segundo numero: ");
		int num2 = System.Convert.ToInt32( System.Console.ReadLine());
		
		if (num1 % num2 == 0)
		{
			System.Console.WriteLine("El numero {0} es múltiplo de {1}", num1, num2);
		}
		else
		{
			System.Console.WriteLine("El numero {0} no es múltiplo de {1}", num1 ,num2);
		}
	}	
}
