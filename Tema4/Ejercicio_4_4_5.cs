using System;

class Ejercicios_4_4_5
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
					Ejercicio_4_4_5_1();
					break;
				case "2":
					Ejercicio_4_4_5_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_4_5_1()
	{
		/*(4.4.5.1) Un  programa  que  pida  al  usuario  10  frases,  las  guarde  en  un  array,  y luego le pregunte textos de forma repetitiva, 
		 * e indique si cada uno de esos textos aparece  como  parte  de  alguno  de  los  elementos  del  array.  
		 * Terminará  cuando  el texto introducido sea "fin".*/
		 
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
				 if (frases[i].Contains(texto))
				 {
					 Console.WriteLine("El texto aparece en alguno de los elementos");
					 break;
				 }
				 else if (i == 9 && !frases[i].Contains(texto))
				 {
					 Console.WriteLine("El texto no aparece");
				 }
			 }
		 } while (texto != "fin");
	}
	
	static void Ejercicio_4_4_5_2()
	{
		/*(4.4.5.2) Crea una versión del ejercicio 4.4.5.1 en la que, en caso de que alguno de los  textos  aparezca  como  subcadena,  
		 * se informe además de si  se  encuentra exactamente al principio.*/
		 
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
				 if (frases[i].Contains(texto))
				 {
					 if (frases[i].IndexOf(texto) == 0)
					 {
						 Console.WriteLine("El texto aparece en el principio de la subcandena");
						 break;
					 }
					 
					 Console.WriteLine("El texto aparece en alguno de los elementos");
					 break;
				 }
				 else if (i == 9 && !frases[i].Contains(texto))
				 {
					 Console.WriteLine("El texto no aparece");
				 }
			 }
		 } while (texto != "fin");
	}
}
