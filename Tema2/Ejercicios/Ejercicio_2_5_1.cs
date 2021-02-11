using System;

class Ejercicio_2_5_1
{
/*(2.5.1) Crea un programa que muestre una cuenta atrás (3 2 1 0) desde el número
que introduzca el usuario hasta cero. Ese número debe estar entre 1 y 10 (y el
programa debe comprobar que realmente lo está, y volverlo a pedir tantas veces
como sea necesario, en caso de que no sea así).*/	

	static void Main()
	{
		int num1;
			
		do 
		{
			Console.Write("Dime un numero: ");
			num1 = Convert.ToInt32(Console.ReadLine());
		}
		while (num1 > 10);
		
		for (int i = num1; i > -1; i--)
		{
			Console.Write(i + " ");
		}
		
	}
}
