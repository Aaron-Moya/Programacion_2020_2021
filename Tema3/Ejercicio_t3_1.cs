using System;

class Ejercicio_t3_1
{
		/*El programa dibuja una X utilizando asteriscos y espacios. Hay que pedir un número entero impar mayor que 2 que es el tamaño de la X
		 *El programa controlará que sea impar y mayor que 2, en caso contrario lo debe volver a pedir.
		  El programa,  también debe tener control de errores (try-catch). Al leer el número, 
		  en el caso de que no sea un número entero, debe avisarnos y volver a pedirlo.*/
	static void Main()
	{
		try 
		{
			Console.Write("Dime un numero impar mayor que 2: ");
			int num = Convert.ToInt32(Console.ReadLine());
			
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					if (i == (num/2) || j == (num/2))
					{
						if (i != j)
						{
							Console.Write(" ");
						}
						else
						{
							Console.Write("*");
						}
					}
					else
					{
						Console.Write("*");
					}
				}
				Console.WriteLine();
			}
		}
		catch (Exception errorEncontrado)
		{
			Console.WriteLine("{0}: El número no es entero", errorEncontrado.Message);
		}
	}
}
