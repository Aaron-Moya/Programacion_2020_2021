using System;

class Ejercicios_3_3_2_1
{
/*(3.3.2.1) Crea  un  programa  que  pida  al  usuario  que  teclee  cuatro  letras  y  las muestre  en  pantalla  juntas,  
 * pero  en  orden  inverso,  y  entre  comillas  dobles.  Por ejemplo si las letras que se teclean son a, l, o, h, escribiría "hola".*/
 
	static void Main()
	{
		Console.Write("Dime una letra: ");
		char letra1 = Convert.ToChar(Console.ReadLine());
		Console.Write("Dime otra letra: ");
		char letra2 = Convert.ToChar(Console.ReadLine());
		Console.Write("Dime otra letra: ");
		char letra3 = Convert.ToChar(Console.ReadLine());
		Console.Write("Dime otra letra: ");
		char letra4 = Convert.ToChar(Console.ReadLine());
		
		Console.Write("\"");
		Console.Write(letra4);
		Console.Write(letra3);
		Console.Write(letra2);
		Console.Write(letra1);
		Console.Write("\"");
	}
}
