using System;

class Ejercicios_4_4_3
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
					Ejercicio_4_4_3_1();
					break;
				case "2":
					Ejercicio_4_4_3_2();
					break;
				case "3":
					Ejercicio_4_4_3_3();
					break;
				case "4":
					Ejercicio_4_4_3_4();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_4_3_1()
	{
		/*(4.4.3.1) Un programa que te pida tu nombre y lo muestre en pantalla separando cada  letra  de  la  siguiente  con  un  espacio.  
		 * Por  ejemplo,  si  tu  nombre  es  "Juan", debería aparecer en pantalla "J u a n".*/
		 
		 Console.Write("Dime tu nombre: ");
		 string nombre = Console.ReadLine();
		 int longitud = nombre.Length;
		 
		 for (int i = 0; i < longitud; i++)
		 {
			 Console.Write(nombre[i] + " ");
		 }
	}
	
	static void Ejercicio_4_4_3_2()
	{
		/*(4.4.3.2) Un programa que pida una frase al usuario y la muestre
		 * en orden inverso (de la última letra a la primera)*/ 
		
		Console.Write("Dime una frase: ");
		string frase = Console.ReadLine();
		int longitud = frase.Length;
		longitud--;
		
		for (int i = longitud; i >= 0; i--)
		{
			Console.Write(frase[i]);
		}
	}
	
	static void Ejercicio_4_4_3_3()
	{
		/*(4.4.3.3) Un   programa   que   pida al   usuario una   frase,   después   una   letra   y 
		 * finalmente diga si aparece esa letra como parte de esa frase o no*/
		 
		 Console.Write("Dime una frase: ");
		 string frase = Console.ReadLine();
		 int longitud = frase.Length;
		 Console.Write("Dime una letra: ");
		 char letra = Convert.ToChar(Console.ReadLine());
		 
		 for (int i = 0; i < longitud; i++)
		 {
			 if (frase[i] == letra)
			 {
				 Console.Write("La letra aparece");
				 break;
			 }
			 else if (i == longitud - 1 && frase[i] != letra)
			 {
				 Console.Write("La letra no aparece");
			 }
		 }
	}
	
	static void Ejercicio_4_4_3_4()
	{
		/*(4.4.3.4) Un  programa  capaz  de  sumar  dos  números  enteros  muy  grandes  (por ejemplo, de 50 cifras), 
		 * que se deberán pedir como cadena de texto y analizar letra a letra(pista: tendrás que pensar cómo sumas dos números a mano: 
		 * qué ocurre si al  suma  cifra  a  cifra  obtienes  un  número  mayor  que  10  y  cómo  tratar  el  caso  de que los dos números no tengan la misma longitud).*/
		 
		 string num1 = "7595674576576878567567575674532342346556768435367567656";
		 string num2 = "9999674576576878567567575674532342346556768435367567656";
		 int longitud1 = num1.Length;
		 longitud1--;
		 int longitud2 = num2.Length;
		 longitud2--;
		 
		 string sumaNum1 = "";
		 string sumaNum2 = "";
		 
		 for (int i = 0; i < longitud1; i++)
		 {
			 sumaNum1 += (int)num1[i];
		 }
		 
		 for (int i = 0; i < longitud2; i++)
		 {
			 sumaNum2 += (int)num2[i];
		 }
		 
		 Console.WriteLine("La suma de los dos números es: " + (sumaNum1 + sumaNum2));
	}
}
