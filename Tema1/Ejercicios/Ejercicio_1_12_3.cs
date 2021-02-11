using System;

class Ejercicio1122
{
		static void Main(){
			/* (1.12.3) Crea una variante del programa anterior, que pide al usuario un
				número y muestra su tabla de multiplicar. Esta vez no deberás utilizar {0},
				{1}, {2}, sino "Write" */
				
			Console.Write("Dime un número: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			
			for (int num2 = 0; num2 <= 10; num2++)
			{
				int resultado = num1 * num2;
				
				Console.WriteLine(num1 + " x " + num2 + " = " + resultado);
			}
		}
	
}

