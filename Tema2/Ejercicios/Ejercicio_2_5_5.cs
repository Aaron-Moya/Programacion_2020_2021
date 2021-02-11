using System;

class Ejercicio_2_5_5
{
/*(2.5.5) Crea un programa que descomponga un número (que teclee el usuario)
como producto de su factores primos. Por ejemplo, 60 = 2 · 2 · 3 · 5 (pista: como
primera aproximación, puedes escribir siempre un "punto" después de cada número y luego terminar 
* con la cifra uno, así: 60 = 2 · 2 · 3 · 5 · 1; cuando lo consigas, piensa cómo harías para eliminar ese "• 1" del final).*/

	static void Main()
	{
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write(num1 + " = ");
		
		for (int i = 2; num1 > i; i++)
		{
			while (num1 != 1)
			{
				if (num1 % i == 0)
				{
					Console.Write("{0}", i);
					num1 /= i;	
					
					if (num1 != i)
					{
						Console.Write(" · ");
					} 
					else if (i == num1)
					{
						break;
					}
				}
				else
				{
					i += 1;
				}
				
				
				
			}
		}
	}
}
