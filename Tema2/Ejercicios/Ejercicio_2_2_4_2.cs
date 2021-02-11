using System;

class Ejercicio_2_2_4_2
{
/*(2.2.4.2) Crea un programa que contenga un bucle sin fin que muestre los
números enteros positivos a partir del uno, separados por un espacio en blanco.*/

	static void Main() 
	{
		int numeros = 0;
		
		while (true)
		{
			Console.Write((numeros = numeros + 1)+ " ");
		}
	}
}
