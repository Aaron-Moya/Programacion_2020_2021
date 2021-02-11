using System;

class Ejercicios_4_1_4
{
	static void Main()
	{
		string op = "1";
		do
		{
			Console.WriteLine("\n\n1- Ejercicio 1\n" +
							  "2- Ejercicio 2\n" +
							  "3- Ejercicio 3\n" +
							  "4- Ejercicio 4\n" +
							  "5- Ejercicio 5\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_4_1_4_1();
					break;
				case "2":
					Ejercicio_4_1_4_2();
					break;
				case "3":
					Ejercicio_4_1_4_3();
					break;
				case "4":
					Ejercicio_4_1_4_4();
					break;
				case "5":
					Ejercicio_4_1_4_5();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_1_4_1()
	{
		/*(4.1.4.1) Crea  una  variante  del  ejemplo 04_01_04a que pida  al  usuario  el  dato  a buscar, avise si ese dato no aparece,
		 *  y que diga cuántas veces se ha encontrado en caso contrario*/
		 
		 int[] datos = {1, 3, 7, 13, 15, 20, 15};
		 int datosCapacidad = 7;
		 int apariciones = 0;
		 
		 
		 Console.Write("Dime un dato para buscar: ");
		 int dato = Convert.ToInt32(Console.ReadLine());
		 
		 for (int i = 0; i < datosCapacidad; i++)
		 {
			 if (dato == datos[i])
			 {
				 apariciones++;
			 }
		 }
		 
		 if (apariciones > 0)
			Console.WriteLine("El dato {0} aparece {1} veces", dato, apariciones);
		 else 
			Console.WriteLine("El dato no aparece");
	}
	
	static void Ejercicio_4_1_4_2()
	{
		/*(4.1.4.2) Crea una variante del ejemplo 04_01_04aque añada un dato introducido por el usuario al final de los datos existentes.*/
		
		int[] datos = {3, 5, 7, 10, 0};
		int datosCantidad = 4;
		int datosCapacidad = 5;
		
		Console.Write("Dime un numero: ");
		int numero = Convert.ToInt32(Console.ReadLine());
		
		if (datosCantidad < datosCapacidad)
		{
			datos[datosCantidad] = numero;
			datosCantidad++;
		}
		
		Console.WriteLine("Ahora datos tiene guardado el numero: " + datos[4]);
	}
	
	static void Ejercicio_4_1_4_3()
	{
		/*(4.1.4.3) Crea una variante del ejemplo 04_01_04aque inserte un dato introducido por  el  usuario  en  la  posición  que  elija  el  usuario.  
		 * Debe  avisar  si  la  posición escogida es incorrecta (porque esté más allá del final de los datos)*/
		 
		 int[] datos = {2, 4, 6, 8, 10, 0};
		 int cantidad = 5;
		 
		 Console.Write("Dime un numero: ");
		 int dato = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime una posición(1 al 5): ");
		 int posicionInsertar = Convert.ToInt32(Console.ReadLine());
		 posicionInsertar--;
		 
		 try {
			 for (int i = cantidad; i > posicionInsertar; i--)
			 {
				datos[i] = datos[i - 1];
			 }
			 datos[posicionInsertar] = dato;
			 cantidad++;
			 
			 for (int i = 0; i < cantidad; i++)
			 {
				 Console.WriteLine(datos[i]);
			 }
		}
		catch(Exception)
		{
			Console.WriteLine("Has introducido una posicion incorrecta");
		}
	}
	
	static void Ejercicio_4_1_4_4()
	{
		/*(4.1.4.4) Crea  una  variante  del  ejemplo 04_01_04a que borre  el  dato  que  se encuentre   
		 * en   la   posición   que   escoja   el   usuario.   Debe   avisar   si   la   posición seleccionadano es válida.*/
		 
		 int[] datos = {2, 4, 6, 8, 10};
		 int cantidad = 5;
		 
		 Console.Write("Dime una posición(1 al 5): ");
		 int posicionBorrar = Convert.ToInt32(Console.ReadLine());
		 posicionBorrar--;
		 
		 try {
			 
			 for (int i = posicionBorrar; i < cantidad - 1; i++)
			 {
				 datos[i] = datos[i + 1];
			 }
			 cantidad--;
			 
			 for (int i = 0; i < cantidad; i++)
			 {
				 Console.WriteLine(datos[i]);
			 }
		 }
		 catch (Exception)
		 {
			 Console.WriteLine("Has introducido una posicion incorrecta");
		 }
	}
	
	static void Ejercicio_4_1_4_5()
	{
		/*(4.1.4.5) Crea un programa que prepare espacio para un máximo de 10 nombres. 
		 * Deberá   mostrar   al   usuario   un   menú   que   le   permita   realizar   las   siguientes operaciones:*/
		 
		 /* - Añadir un dato al final de los ya existentes.
		  - Insertar un dato en una cierta posición (como ya se ha comentado, los que queden detrás deberán desplazarse "hacia el final" 
		    para dejarle hueco); por ejemplo,  si  el  array  contiene  "hola",  "adiós"  y  se  pide  insertar  "bien"  en  la segunda posición, 
		    el array pasará a contener "hola", "bien", "adiós".
		  - Borrar  el  dato  que  hay  en  una  cierta  posición  (como  se  ha  visto,  lo  que estaban  detrás  deberán  desplazarse  "hacia  el  principio" 
		    para  que  no  haya huecos);  por  ejemplo,  si  el  array  contiene  "hola",  "bien",  "adiós"  y  
		    se  pide borrar  el  dato  dela  segunda  posición,  el  array  pasará  a  contener  "hola", "adiós"
		  - Mostrar los datos que contiene el array.
		  - Salir del programa*/
		    
		 string[] nombres = new string[10];
		 nombres[0] = "Aarón";
		 nombres[1] = "Manolo";
		 
		 int cantidad = 2;
		 int capacidad = 10;
		 string nombre;
		 bool acabar = false;
		 
		 do {
			 Console.WriteLine("\n\nQue operacion quieres hacer? \n" +
							   "1 - Añadir un dato\n" +
							   "2 - Insertar un dato\n" +
							   "3 - Borrar un dato\n" +
							   "4 - Mostrar datos\n" +
							   "0 - Salir\n");
						   
		 int op = Convert.ToInt32(Console.ReadLine());

			 if (op == 1)
			 {
				 if (cantidad < capacidad)
				 {
					 Console.WriteLine("Dime un nombre para añadir: ");
					 nombre = Console.ReadLine();
					 
					 nombres[cantidad] = nombre;
					 cantidad++;
					 
					 Console.WriteLine("Nombre añadido correctamente");
				 }
				 else
				 {
					 Console.WriteLine("La capacidad del array ya está al máximo!");
				 }
			 }
			 else if (op == 2)
			 {
				 Console.WriteLine("Dime un nombre para añadir: ");
				 nombre = Console.ReadLine();
				 Console.WriteLine("Dime la posición a insertar: ");
				 int insertar = Convert.ToInt32(Console.ReadLine());
				 insertar--;
				 
				 for (int i = cantidad; i > insertar; i--)
				 {
					 nombres[i] = nombres[i - 1];
				 }
				 nombres[insertar] = nombre;
				 cantidad++;
				 
				 Console.WriteLine("Nombre añadido correctamente");
			 }
			 else if (op == 3)
			 {
				 Console.WriteLine("Dime la posición del nombre a borrar: ");
				 int borrar = Convert.ToInt32(Console.ReadLine());
				 borrar--;
				 
				 for (int i = borrar; i < cantidad - 1; i++)
				 {
					 nombres[i] = nombres[i + 1];
				 }
				 cantidad--;
				 
				 Console.WriteLine("Nombre eliminado correctamente");
			 }
			 else if (op == 4)
			 {
				 Console.WriteLine("Los nombres almacenados son: ");
				 
				 for (int i = 0; i < cantidad; i++)
				 {
					 Console.WriteLine(nombres[i]);
				 }
			 }
			 else if (op == 0)
			 {
				 break;
			 } 
		 } while (acabar != true); 
	}
}
