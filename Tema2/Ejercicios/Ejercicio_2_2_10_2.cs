using System;

class Ejercicio_2_2_10_1
{
/*(2.2.10.2) Crea un programa que pida al usuario dos números y escriba su mínimo
común múltiplo (pista: una solución lenta pero sencilla es probar con un "for"
todos los números a partir del mayor de ambos, de forma creciente; cuando
encuentres un número que sea múltiplo de ambos, interrumpes la búsqueda con "break").*/	

	static void Main()
	{
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Dime otro numero: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		if (num1 > num2) 
		{
			for (int i = num1; i >= num1; i++)
			{
				if (num1 % i == 0 && i % num2 == 0)
				{ 
					Console.WriteLine("El M.C.D es: " + i);
					break;
				} else if (i % num1 == 0 && i % num2 == 0)
				{ 
					Console.WriteLine("El M.C.D es: " + i);
					break;
				}
			}
		} else {
			for (int i = num2; i >= num2; i++)
			{
				if (i % num1 == 0 && num2 % i == 0)
				{ 
					Console.WriteLine("El M.C.D es: " + i);
					break;
				} else if (i % num1 == 0 && i % num2 == 0)
				{ 
					Console.WriteLine("El M.C.D es: " + i);
					break;
				}
			}
		}
	}
}
