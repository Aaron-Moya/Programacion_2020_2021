using System;

class Ejercicio_2_5_8
{
/*(2.5.8) Crea un programa que "dibuje" un triángulo creciente, alineado a la
derecha, con la altura que indique el usuario. Por ejemplo, si el usuario dice que
desea 4 caracteres de alto, el triángulo sería así:
   *
  **
 ***
****
*/

	static void Main()
	{
		Console.Write("Dime el alto: ");
		int alto = Convert.ToInt32(Console.ReadLine());
		
		int espacios = alto - 1;
		int asteriscos = 1;
		
		for (int i = 1; i <= alto; i++)
		{	
			for (int j = 1; j <= espacios; j++)
			{
				Console.Write(" ");
			}
			
			for (int j = 1; j <= asteriscos; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
			
			espacios--;
			asteriscos++;
		}
	}
}
