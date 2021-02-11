using System;

class Ejercicio1121
{
		static void Main()
		{
			/*(1.12.1) El usuario tecleará dos números (a y b), y el programa mostrará el
			resultado de la operación (a+b)*(a-b) y el resultado de la operación a2-b2.
			Ambos resultados se deben mostrar en la misma línea.
			 */
			 			 
			 Console.Write("Dime el primer número: ");
			 double num1 = Convert.ToInt32(Console.ReadLine());
			 
			 Console.Write("Dime el segundo número: ");
			 double num2 = Convert.ToInt32(Console.ReadLine());
			 
			 Console.Write("El resultado de la primera operación es: " + ((num1+num2)*(num1-num2)));
			 Console.Write("  El resultado de la segunda operación es: " + ((Math.Pow(num1, 2))-(Math.Pow(num2, 2))));

		}
	
}

