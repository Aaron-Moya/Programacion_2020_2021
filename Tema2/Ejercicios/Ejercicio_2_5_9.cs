using System;

class Ejercicio_2_5_9
{
/*(2.5.9) Crea un programa que devuelva el cambio de una compra, utilizando
monedas (o billetes) del mayor valor posible. Supondremos que tenemos una
cantidad ilimitada de monedas (o billetes) de 100, 50, 20, 10, 5, 2 y 1, y que no hay
decimales. La ejecución podría ser algo como:
Precio? 44
Pagado? 100

Su cambio es de 56: 50 5 1
*
Precio? 1
Pagado? 100

Su cambio es de 99: 50 20 20 5 2 2*/

	static void Main()
	{
		Console.Write("Precio? ");
		int precio = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Pagado? ");
		int pagado = Convert.ToInt32(Console.ReadLine());
		
		int cambio = pagado - precio;
		
		Console.Write("Su cambio es de {0}: ", cambio);
		
		if (pagado < precio)
		{
			Console.WriteLine("Falta dinero");
		}
		else
		{
			while (50 <= cambio)
			{
				Console.Write("50 ");
				cambio = cambio - 50;
			}
			while (20 <= cambio)
			{
				Console.Write("20 ");
				cambio = cambio - 20;
			}
			while (10 <= cambio)
			{
				Console.Write("10 ");
				cambio = cambio - 10;
			}
			while (5 <= cambio)
			{
				Console.Write("5 ");
				cambio = cambio - 5;
			}
			while (2 <= cambio)
			{
				Console.Write("2 ");
				cambio = cambio - 2;
			}
			while (1 <= cambio)
			{
				Console.Write("1 ");
				cambio = cambio - 1;
			}
		}
	}
}
