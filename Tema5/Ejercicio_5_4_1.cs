using System;

class Ejercicio_5_4_1
{
/*(5.4.1) Crea una función "Cubo" que calcule el cubo de un número real (float) que se indique como parámetro. 
 * El resultado deberá ser otro número real. Prueba esta función para calcular el cubo de 3.2 y el de 5*/
 
	static void Main()
	{
		Console.WriteLine(Cubo(5f));
	}
	
	static float Cubo(float numero)
	{
		return numero * numero * numero;
	}
}
