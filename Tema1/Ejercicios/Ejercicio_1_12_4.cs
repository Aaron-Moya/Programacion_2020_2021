using System;

class Ejercicio1124
{
		static void Main(){
			/* (1.12.4) Crea un programa que convierta de grados Celsius (centígrados) a
				Kelvin y a Fahrenheit: pedirá al usuario la cantidad de grados centígrados y
				usará las siguiente tablas de conversión: kelvin = celsius + 273 ; fahrenheit
				= celsius x 18 / 10 + 32. Emplea "Write" en vez de "{0}" cuando debas
				mostrar varios datos en la misma línea. 
			 */
			 
			 Console.Write("Dime los grados centígrados: ");
			 int gradosCent = Convert.ToInt32( Console.ReadLine());
			 
			 int gradosKelvin = gradosCent + 273;
			 int gradosFahr = gradosCent * 18 / 10 + 32;
			 
			 Console.Write("Grados Kelvin = " + gradosKelvin);
			 Console.Write("  Grados Fahrenheit = " + gradosFahr);

		}
		
	
	
}
