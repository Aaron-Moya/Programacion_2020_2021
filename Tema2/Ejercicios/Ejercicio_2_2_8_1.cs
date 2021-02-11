using System;

class Ejercicio_2_2_8_1
{
/*(2.2.8.1) Crea un programa que escriba 6 líneas de texto, cada una de las cuales
estará formada por los números del 1 al 7. Debes usar dos variables llamadas
"linea" y "numero", y ambas deben estar declaradas en el "for".*/	

	static void Main()
	{
		for (int lineas = 1; lineas <= 6; lineas++)
		{
			for (int numero = 1; numero <= 7; numero++)
			{
				Console.Write(numero);
			}
			Console.WriteLine();
		}
	}
}
