using System;

class Ejercicio1111
{
		static void Main()
		{
			/*(1.11.1) Crea una nueva versión del programa que calcula el producto de dos
				números introducidos por el usuario (1.10.1), empleando "using System". El
				programa deberá contener un comentario al principio, que recuerde cual es su objetivo.
			 */
			 
			 // Calcular el producto de dos números usando "using System"
			 
			 Console.Write("Dime el primer número: ");
			 int num1 = Convert.ToInt32(Console.ReadLine());
			 
			 Console.Write("Dime el segundo número: ");
			 int num2 = Convert.ToInt32(Console.ReadLine());
			 
			 Console.WriteLine("El resultado del producto de los dos números es: " + (num1 * num2)); 
		}
	
}
