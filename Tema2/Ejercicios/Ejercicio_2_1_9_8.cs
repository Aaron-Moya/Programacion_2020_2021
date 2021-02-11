using System;

class Ejercicio_2_1_9_8
{
/* (2.1.9.8) Pide al usuario el un número de mes y escribe su nombre (por ejemplo, si escribe 3,
 la respuesta debería ser "Marzo"), usando "switch" */
 
	static void Main() {
		Console.Write("Dime un numero de un mes: ");
		int num1 = Convert.ToInt32( Console.ReadLine());
		
		switch (num1) {
			case 1: Console.Write("Enero"); break;
			case 2: Console.Write("Febrero"); break;
			case 3: Console.Write("Marzo"); break;
			case 4: Console.Write("Abril"); break;
			case 5: Console.Write("Mayo"); break;
			case 6: Console.Write("Junio"); break;
			case 7: Console.Write("Julio"); break;
			case 8: Console.Write("Agosto"); break;
			case 9: Console.Write("Septiembre"); break;
			case 10: Console.Write("Octubre"); break;
			case 11: Console.Write("Noviembre"); break;
			case 12: Console.Write("Diciembre"); break;
		}
	}
}
