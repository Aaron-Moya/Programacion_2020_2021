using System;

class Ejercicios_3_4
{
	static void Main()
	{
		string op = "1";
		do
		{
			Console.WriteLine("\n\n1- Ejercicio 1\n" +
							  "2- Ejercicio 2\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_3_4_1();
					break;
				case "2":
					Ejercicio_3_4_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_4_1()
	{
		/*(3.4.1) Crea  un  programa  que  pida  al  usuario  su  nombre,  y  le  diga  "Hola"  si  se llama "Juan", 
		 * o bien le diga "No te conozco" si teclea otro nombre.*/
		 
		 Console.Write("Dime tu nombre: ");
		 string nombre = Console.ReadLine();
		 
		 if (nombre == "Juan")
		 {
			 Console.WriteLine("Hola");
		 } 
		 else
		 {
			 Console.WriteLine("No te conozco");
		 }
	}
	
	static void Ejercicio_3_4_2()
	{
		/*(3.4.2) Crea un  programa  que  pida  al  usuario  un  nombre  y  una  contraseña.  La contraseña se debe introducir dos veces. 
		 * Si las dos contraseñas no son iguales, se avisará al usuario y se le volverán a pedir las dos contraseñas, tantas veces como sea necesario hasta 
		 * que coincidan.*/
		 
		 Console.Write("Dime tu nombre: ");
		 string nombre = Console.ReadLine();
		 string contrasenya;
		 string contrasenya2;
		 
		 do {
			Console.Write("Dime tu contraseña: ");
			contrasenya = Console.ReadLine();
			Console.Write("Dime otra vez tu contraseña: ");
			contrasenya2 = Console.ReadLine();
			
			if (contrasenya != contrasenya2)
			{
				Console.WriteLine("Has introducido mal la contraseña vuelve a introducirlas.");
			}
		 } while(contrasenya != contrasenya2);
	}
}
