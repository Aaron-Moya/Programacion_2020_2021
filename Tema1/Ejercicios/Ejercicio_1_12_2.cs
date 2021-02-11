using System;

class Ejercicio1122
{
		static void Main(){
			/* (1.12.2) Pide al usuario un número y muestra su tabla de multiplicar,
				usando {0},{1} y {2}. Por ejemplo, si el número es el 3, debería escribirse algo como: 
				3 x 0 = 0
				3 x 1 = 3
				3 x 2 = 6 */
				
			Console.Write("Dime un número: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			
			for (int num2 = 0; num2 <= 10; num2++)
			{
				int resultado = num1 * num2;
				
				Console.WriteLine("{0} x {1} = {2}", num1, num2, resultado);
			}
		}
	
}
