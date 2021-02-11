using System;

class Ejercicio_2_2_10_4
{
/*(2.2.10.4) Crea una versión alternativa del ejercicio 2.2.10.2 (mínimo común
múltiplo) usando "while", en vez de "for" y "break"*/	

	static void Main()
	{
		Console.Write("Dime un numero: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Dime otro numero: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		int contador;
		int finalPrograma = 0;
		
		if (num1 > num2) 
		{
			contador = num1;
			
			while (contador >= num1 && finalPrograma != 1)
			{
				contador += 1;
				
				if (num1 % contador == 0 && contador % num2 == 0)
				{ 
					Console.WriteLine("El M.C.D es: " + contador);
					finalPrograma = 1;
				} else if (contador % num1 == 0 && contador % num2 == 0)
				{ 
					Console.WriteLine("El M.C.D es: " + contador);
					finalPrograma = 1;
				}
			}
		} else {
			contador = num2;
			
			while (contador >= num2 && finalPrograma != 1)
			{
				contador += 1;
				
				if (contador % num1 == 0 && num2 % contador == 0)
				{ 
					Console.WriteLine("El M.C.D es: " + contador);
					finalPrograma = 1;
				} else if (contador % num1 == 0 && contador % num2 == 0)
				{ 
					Console.WriteLine("El M.C.D es: " + contador);
					finalPrograma = 1;
				}
			}
		}
	}
}
