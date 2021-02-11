using System;

class Ejercicio_2_2_8_2
{
/*(2.2.8.2) Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto
(por ejemplo, 3) y escriba un rectángulo formado por esa cantidad de asteriscos,
como en el ejercicio 2.2.6.2. Deberás usar las variables "ancho" y "alto" para los
datos que pidas al usuario, y las variables "filaActual" y "columnaActual"
(declaradas en el "for") para el bloque repetitivo.*/	

	static void Main()
	{
		Console.Write("Dime el ancho: ");
		int ancho = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Dime el alto: ");
		int alto = Convert.ToInt32(Console.ReadLine());
				
		for (int columnaActual = 1; columnaActual <= alto; columnaActual++)
		{
			for (int filaActual = 1; filaActual <= ancho; filaActual++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
