using System;

class Ejercicios_4_4_1
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
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_4_4_1_1();
					break;
				case "2":
					Ejercicio_4_4_1_2();
					break;
				case "3":
					Ejercicio_4_4_1_3();
					break;
				case "4":
					Ejercicio_4_4_1_4();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_4_1_1()
	{
		/*(4.4.1.1) Crea un programa que te pida tu nombre y lo escriba 5 veces.*/
		
		Console.Write("Dime tu nombre: ");
		string nombre = Console.ReadLine();
		
		for (int i = 0; i < 5; i++)
		{
			Console.Write(nombre + " ");
		}
	}
	
	static void Ejercicio_4_4_1_2()
	{
		/*(4.4.1.2) Crea  un  programa  que  pida  al  usuario  su  nombre.  Si  se  llama  como  tú (por   ejemplo,   "Nacho"),   
		 * responderá   "Bienvenido,   jefe".   En caso   contrario,   le saludará por su nombre.*/
		 
		 Console.Write("Dime tu nombre: ");
		 string nombre = Console.ReadLine();
		 
		 if (nombre == "Aarón")
		 {
			 Console.WriteLine("Bienvenido, jefe " + nombre);
		 }
		 else
		 {
			 Console.Write("Bienvenido " + nombre);
		 }
	}
	
	static void Ejercicio_4_4_1_3()
	{
		/*(4.4.1.3) Un  programa  que  pida  tu  nombre,  tu  día  de  nacimiento  y  tu  mes  de nacimiento  y  lo  junte  todo  en  una  cadena,  
		 * separando  el  nombre  de  la  fecha  por una coma,y el día y el mes por una barra inclinada, así: "Juan, nacido el 31/12"*/
		 
		 Console.Write("Dime tu nombre: ");
		 string nombre = Console.ReadLine();
		 Console.Write("Dime tu dia de nacimiento: ");
		 int dia = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime tu mes de nacimiento: ");
		 int mes = Convert.ToInt32(Console.ReadLine());
		 
		 Console.WriteLine(nombre + ", nacido el " + dia + "/" + mes );
	}
	
	static void Ejercicio_4_4_1_4()
	{
		/*(4.4.1.4) Crea  un  programa  que  pida  al  usuario  dos  números  enteros  y  después una  operación  que  realizar  con  ellos.  
		 * La  operación  podrá  ser  "suma",  "resta", multiplicación"  y  "división",  que  también  se  podrán  escribir  de  forma  abreviado 
		 * con  los  operadores  matemáticos  "+",  "-",  "*"  y  "/".  Para  multiplicar  también  se podrá  usar  una  "x",  minúscula  o  mayúscula.  
		 * A  continuación  se  mostrará  el resultado de esa operación (por ejemplo, si los números son 3 y 6 y la operación es "suma",  
		 * el  resultado  sería  9).  La  operación  debes  tomarla  como  una  cadena  de texto y analizarla con un "switch"*/
		 
		 Console.Write("Dime un numero: ");
		 int num1 = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime otro numero: ");
		 int num2 = Convert.ToInt32(Console.ReadLine());
		 
		 Console.WriteLine("Que operacion quieres hacer:");
		 Console.WriteLine("1 - Sumar");
		 Console.WriteLine("2 - Restar");
		 Console.WriteLine("3 - Multiplicar");
		 Console.WriteLine("4 - Dividir");
		 string op = Console.ReadLine();
		 
		 switch (op)
		 {
			 case "1": Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
				  break;
			 case "2": Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
				  break;			 
			 case "3": Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
				  break;			 
			 case "4": Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
				  break;			 
			 default: break;
		 }
	}
}
