using System;

class Ejercicio_5_4_3
{
/*(5.4.3) Crea una función llamada "Signo", que reciba un número real, y devuelva un número  entero  con  el  valor: -1  
 * si  el  número es  negativo,  1  si  es  positivo o  0  si  es cero.*/
 
	static void Main()
	{
		Console.WriteLine(Signo(-3));
	}
	
	static float Signo(float numero)
	{
		if (numero < 0)
		{
			return -1;
		}
		if (numero > 0)
		{
			return 1;
		}
		else
		{
			return 0;
		}
	}
}
