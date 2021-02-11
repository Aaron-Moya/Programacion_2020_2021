using System;

class Ejercicio_2_2_2_4
{
/*(2.2.2.4) Crea un programa que pida al usuario su identificador y su contraseña
(ambos numéricos), y no le permita seguir hasta que introduzca como
identificador "1234" y como contraseña "1111"*/	

	static void Main() {
		int id;
		int passwd;
		
		do {
			Console.Write("Dime tu identificador: ");
			id = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Dime tu contraseña: ");
			passwd = Convert.ToInt32(Console.ReadLine());
			
			if (id == 1234 && passwd == 1111) {
				Console.WriteLine("Correcto!");
			} else {
				Console.WriteLine("Error: Vuelve a introducir los datos");
			}
		} while (id != 1234 && passwd != 1111);
	}
}
