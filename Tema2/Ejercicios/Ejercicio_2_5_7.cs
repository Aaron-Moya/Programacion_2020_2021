using System;

class Ejercicio_2_5_7
{
/*(2.5.7) Crea un programa que "dibuje" un rectángulo hueco, cuyo borde sea una
fila (o columna) de asteriscos y cuyo interior esté formado por espacios en blanco,
con el ancho y el alto que indique el usuario. Por ejemplo, si desea anchura 4 y
altura 3, el rectángulo sería así:
****
*  *
****/	

	static void Main()
	{
		Console.Write("Dime un el alto: ");
		int filas = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Dime un el ancho: ");
		int columnas = Convert.ToInt32(Console.ReadLine());
		
		for (int fila = 1; fila <= filas; fila++)
		{
			for (int columna = 1; columna <= columnas; columna++)
			{
				if ((fila == 1) || (fila == filas) || (columna == 1) || (columna == columnas))
				{
					Console.Write("*");
				}
				else
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
		
		
	}
}
