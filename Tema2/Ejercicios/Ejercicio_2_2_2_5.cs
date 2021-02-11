using System;

class Ejercicio_2_2_2_5
{
/*(2.2.2.5) Crea un programa que pida al usuario su identificador y su contraseña, y
no le permita seguir hasta que introduzca como nombre "Pedro" y como contraseña "Peter".*/	

	static void Main() {
		string id;
		string passwd;
		
		do {
			Console.Write("Dime tu identificador: ");
			id = Console.ReadLine();
			
			Console.Write("Dime tu contraseña: ");
			passwd = Console.ReadLine();
			
			if (id == "Pedro" && passwd == "Peter") {
				Console.Write("Bienvenido "+id);
			} else {
				Console.WriteLine("Error: Vuelve a introducir tus datos");
			}
		} while (id != "Pedro" && passwd != "Peter");
	}
}
