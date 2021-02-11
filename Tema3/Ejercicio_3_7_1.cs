using System;

class Ejercicio_3_7_1
{
	static void Main()
	{
		/*(3.7.1) Crea  unprograma  que  pida  al  usuario  una  cantidad  de  kilómetros  y muestre  su  equivalencia  en  millas.  
		 * El  valor  de  conversión  debe  estar  en  una variable definida con "var".*/
		 
		 var conversion = 1.609;
		 Console.Write("Dime una cantidad de kilometros: ");
		 int km = Convert.ToInt32(Console.ReadLine());
		 
		 Console.WriteLine("En millas sería: " + (km / conversion));
		 
	}
}
