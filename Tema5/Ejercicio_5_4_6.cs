using System;

class Ejercicio_5_4_6
{
/*(5.4.6) Crea  una  función "MostrarPerimSuperfCuadrado" que  reciba  un  número entero y calcule 
 * y muestre en pantalla el valor del perímetro y de la superficie de */
 
	static void Main()
	{
		MostrarPerimSuperfCuadrado(4);
	}
	
	static void MostrarPerimSuperfCuadrado(int numero)
	{
		int perimetro = numero * 4;
		int superficie = numero * numero;
		
		Console.WriteLine(perimetro);
		Console.WriteLine(superficie);
	}
}
