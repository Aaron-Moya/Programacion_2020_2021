using System;

class Ejercicio_5_5_2
{
/*(5.5.2) Crea una función "EscribirTablaMultiplicar", que reciba como parámetro un número entero, y escriba la tabla de multiplicar de ese número 
 * (por ejemplo, para el 3 deberá llegar desde "3x0=0" hasta "3x10=30")*/
 
	static void Main()
	{
		EscribirTablaMultiplicar(3);
	}
	
	static void EscribirTablaMultiplicar(int numero)
	{
		for (int i = 0; i <= 10; i++)
		{
			Console.WriteLine(numero + " x " + i + " = " + (numero * i));
		}
	}
}
