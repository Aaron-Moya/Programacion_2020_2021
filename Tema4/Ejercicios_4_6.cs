using System;

class Ejercicios_4_6
{
	static void Main()
	{
		string op = "1";
		do
		{
			Console.WriteLine("\n\n1- Ejercicio 1\n" +
							  "2- Ejercicio 2\n" +
							  "3- Ejercicio 3\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_4_6_1();
					break;
				case "2":
					Ejercicio_4_6_2();
					break;
				case "3":
					Ejercicio_4_6_3();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	struct tipoPersona {
		public string nombre;
		public string apellido;
		public int edad;
	}
	
	static void Ejercicio_4_6_1()
	{
		/*(4.6.1) Un programa que pida el nombre, el apellido y la edad de una persona, los almacene  en  un  "struct"  y  
		 * luego  muestre  los  tres  datos  en  una  misma  línea, separados por comas*/
		 
		 tipoPersona[] persona = new tipoPersona[1];
		 Console.Write("Dime tu nombre: ");
		 persona[0].nombre = Console.ReadLine();
		 Console.Write("Dime tu apellido: ");
		 persona[0].apellido = Console.ReadLine();
		 Console.Write("Dime tu edad: ");
		 persona[0].edad = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write(persona[0].nombre + " " + persona[0].apellido + " " + persona[0].edad);
	}
	
	struct tipoPersona2 {
		public string nombre;
		public int dia;
		public int mes;
		public int anyo;
	}
	
	static void Ejercicio_4_6_2()
	{
		/*(4.6.2) Un  programa  que  pida  datos  de  8  personas:  nombre, díade  nacimiento, mes de nacimiento, y año de nacimiento (que se deben almacenar en unarrayde structs).  
		 * Después  deberá  repetir  lo  siguiente:  preguntar  un  número  de  mes  y mostrar en  pantalla  los  datos  de  las  personas que  cumplan  los  años durante  ese mes. 
		 * Terminará de repetirse cuando se teclee 0 como número de mes*/
		 
		 tipoPersona2[] persona = new tipoPersona2[8];
		 int mes = 1;
		 
		 for (int i = 0; i < persona.Length; i++)
		 {
			 Console.Write("Dime tu nombre: ");
			 persona[i].nombre = Console.ReadLine();
			 Console.Write("Dime tu dia de nacimiento: ");
			 persona[i].dia = Convert.ToInt32(Console.ReadLine());
			 Console.Write("Dime tu mes de nacimiento: ");
			 persona[i].mes = Convert.ToInt32(Console.ReadLine());
			 Console.Write("Dime tu año de nacimiento: ");
			 persona[i].anyo = Convert.ToInt32(Console.ReadLine());
		 }
		 
		 do {
			 Console.Write("Dime un numero de un mes: ");
			 mes = Convert.ToInt32(Console.ReadLine());
			 
			 for (int i = 0; i < persona.Length; i++)
			 {
				 if (mes == persona[i].mes)
				 {
					 Console.Write(persona[i].nombre + " " + persona[i].dia + " " + persona[i].mes + " " + persona[i].anyo);
					 Console.WriteLine();
				 }
			 }
		 } while (mes != 0);
	}
	
	struct tipoPersona3 {
		public string nombre;
		public string direccion;
		public int telefono;
		public int edad;
	}
	
	static void Ejercicio_4_6_3()
	{
		/*(4.6.3) Un  programa  que  sea  capaz  de  almacenar  los  datos  de  50  personas: nombre,   dirección,   teléfono,   edad   
		 * (usando   una   tabla   de   structs).   Deberá   ir pidiendo  los  datos  uno  por  uno,  hasta  que  un  nombre  se  introduzca  vacío(se pulse Intro sin teclear nada). 
		 * Entonces deberá aparecer un menú que permita:
		 * -Mostrar la lista de todos los nombres.
		 * -Mostrar las personas de una cierta edad.
		 * -Mostrar las personas cuya inicial sea la que el usuario indique.
		 * -Salir del programa*/
		 
		 tipoPersona3[] persona = new tipoPersona3[50];
		 int cantidad = 0;
		 string nombre = "a";
		 int op;
		 
		 while (true)
		 {
			 if (cantidad == 50)
			 {
				 Console.WriteLine("Tamaño maximo de personas alcanzado");
				 break;
			 }
			 Console.Write("Dime tu nombre: ");
			 nombre = Console.ReadLine();
			 
			 if (nombre == "")
			 {
				 break;
			 }
			 persona[cantidad].nombre = nombre;
			 Console.Write("Dime tu direccion: ");
			 persona[cantidad].direccion = Console.ReadLine();
			 Console.Write("Dime tu telefono: ");
			 persona[cantidad].telefono = Convert.ToInt32(Console.ReadLine());
			 Console.Write("Dime tu edad: ");
			 persona[cantidad].edad = Convert.ToInt32(Console.ReadLine());
			 
			 cantidad++;
		 }
		 
		 while (true)
		 {
			 Console.WriteLine("\n\n1 -  Mostrar la lista de todos los nombres");
			 Console.WriteLine("2 - Mostrar las personas de una cierta edad");
			 Console.WriteLine("3 -  Mostrar las personas cuya inicial sea la que el usuario indique");
			 Console.WriteLine("0 - Salir");
			 
			 op = Convert.ToInt32(Console.ReadLine());
			 
			 if (op == 1)
			 {
				 Console.WriteLine("Nombres: ");
				 for (int i = 0; i < cantidad; i++)
				 {
					 Console.WriteLine(persona[i].nombre + " ");
				 }
			 }
			 else if (op == 2)
			 {
				 Console.Write("Dime la edad: ");
				 int edad = Convert.ToInt32(Console.ReadLine());
				 
				 for (int i = 0; i < cantidad; i++)
				 {
					 if (persona[i].edad == edad)
					 {
						Console.WriteLine(persona[i].nombre + " " + persona[i].direccion + " " + persona[i].telefono + " " + persona[i].edad);
					 }
				 }
			 }
			 else if (op == 3)
			 {
				 Console.Write("Dime la letra: ");
				 char letra = Convert.ToChar(Console.ReadLine());
				 
				 for (int i = 0; i < cantidad; i++)
				 {
					 if (persona[i].nombre[0] == letra)
					 {
						Console.WriteLine(persona[i].nombre + " " + persona[i].direccion + " " + persona[i].telefono + " " + persona[i].edad);
					 }
				 }
			 }
			 else
			 {
				 break;
			 }
			 
		 }
	}
}
