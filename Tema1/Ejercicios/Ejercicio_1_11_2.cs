using System;

class Ejercicio1112
{
		static void Main()
		{
			/*(1.11.2) Crea una nueva versión del programa que calcula la división de dos
				números introducidos por el usuario, así como el resto de esa división (1.10.2),
				empleando "using System". Deberás incluir un comentario con tu nombre y la
				fecha en que has realizado el programa.
			 */
			 
			 // Aarón Moya Arques - 19/09/2020
			 
			 Console.Write("Dime el primer número: ");
			 int num1 = Convert.ToInt32(Console.ReadLine());
			 
			 Console.Write("Dime el segundo número: ");
			 int num2 = Convert.ToInt32(Console.ReadLine());
			 
			 Console.WriteLine("El resultado de la división es: " + (num1 / num2)); 
			 Console.WriteLine("El resto de la división es: " + (num1 % num2)); 

		}
	
}

