using System;

class Ejercicio_2_1_9_7
{
/* (2.1.9.7) Pide al usuario el número de un día de la semana y escribe su nombre
(por ejemplo, si escribe 2, la respuesta debería ser "Martes"). Hazlo primero con "if" y después con "switch".	*/

	static void Main() {
		Console.Write("Dime un número de un día de la semana: ");
		int num1 = Convert.ToInt32( Console.ReadLine());
		
		// CON IF
		if (num1 == 1) {
			Console.WriteLine("Lunes");
		}
		if (num1 == 2) {
			Console.WriteLine("Martes");
		}
		if (num1 == 3) {
			Console.WriteLine("Miercoles");
		}
		if (num1 == 4) {
			Console.WriteLine("Jueves");
		}
		if (num1 == 5) {
			Console.WriteLine("Viernes");
		}
		if (num1 == 6) {
			Console.WriteLine("Sábado");
		}
		if (num1 == 7) {
			Console.WriteLine("Domingo");
		}
		
		// CON SWITCH
		switch (num1) {
			case 1: Console.WriteLine("Lunes"); break;
			case 2: Console.WriteLine("Martes"); break;
			case 3: Console.WriteLine("Miercoles"); break;
			case 4: Console.WriteLine("Jueves"); break;
			case 5: Console.WriteLine("Viernes"); break;
			case 6: Console.WriteLine("Sabado"); break;
			case 7: Console.WriteLine("Domingo"); break;
		}
	}
}
