using System;

class Ejercicio_4_1_2_1
{
/*(4.1.2.1) Un  programa  que  almacene  en  una  tabla  el  número  de  días  que  tiene cada mes (supondremos que es un año no bisiesto), 
 * pida al usuario que le indique un  mes  (1=enero,  12=diciembre)y  muestre  en  pantalla  el  número  de  días  que tiene ese mes.*/
 
	static void Main()
	{
		int[] meses = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		
		Console.Write("Dime el número de un mes: ");
		int numero = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("El mes {0} tiene {1} días", numero, meses[numero]);
	}
}
