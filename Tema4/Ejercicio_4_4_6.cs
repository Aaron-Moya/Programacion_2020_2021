using System;

class Ejercicios_4_4_6
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
					Ejercicio_4_4_6_1();
					break;
				case "2":
					Ejercicio_4_4_6_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_4_6_1()
	{
		/*(4.4.6.1) Una  variante  del  ejercicio  4.4.5.1  (buscar  textos  en  un  array  de frases), 
		 * que no distinga entre mayúsculas  y minúsculas a la hora de buscar.*/
		 
		 string[] frases = new string[10];
		 string texto;
		 
		 for (int i = 0; i < 10; i++)
		 {
			 Console.Write("Dime una frase: ");
			 frases[i] = Console.ReadLine();
		 }
		 
		 do {
			 Console.Write("Dime un texto: ");
			 texto = Console.ReadLine();
			 
			 for (int i = 0; i < 10; i++)
			 {
				 if (frases[i].ToLower().Contains(texto.ToLower()))
				 {
					 Console.WriteLine("El texto aparece en alguno de los elementos");
					 break;
				 }
				 else if (i == 9 && !frases[i].ToLower().Contains(texto.ToLower()))
				 {
					 Console.WriteLine("El texto no aparece");
				 }
			 }
		 } while (texto != "fin");
	}
	
	static void Ejercicio_4_4_6_2()
	{
		/*(4.4.6.2) Un  programa  que  pida  al  usuario  una  frase  y  elimine  todos  los  espacios redundantes  
		 * que  contenga  (debe  quedar  sólo  un  espacio  entre  cada  palabra  y  la siguiente).*/
		 
		 Console.Write("Dime una frase: ");
		 string frase = Console.ReadLine();
		 char delimitador = ' ';
		 
		 string[] cadena = frase.Split(delimitador);
		 
		 for (int i = 0; i < cadena.Length; i++)
		 {
			 Console.Write(cadena[i]);

		 }
	}
}
