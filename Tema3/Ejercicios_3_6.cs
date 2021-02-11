using System;

class Ejercicios_3_6
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
					Ejercicio_3_6_1();
					break;
				case "2":
					Ejercicio_3_6_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_6_1()
	{
		/*(3.6.1) Crea  un programa  que  permita  convertir  de  millas  a  metros.  El  valor necesario para la conversión debe estar almacenado en una constante*/
		
		Console.Write("Dime las millas: ");
		double millas = Convert.ToDouble(Console.ReadLine());
		
		const int valConversion = 1609;
		
		Console.WriteLine("En metros sería: " + millas * valConversion);
	}
	
	enum diasSemana {ENERO = 1, FEBRERO, MARZO, ABRIL, MAYO, JUNIO = 6, JULIO, AGOSTO, SEPTIEMBRE, OCTUBRE, NOVIEMBRE, DICIEMBRE = 12};
	
	static void Ejercicio_3_6_2()
	{
		/*(3.6.2) Crea una enumeración para los meses del año, desde ENERO (con valor 1) hasta  DICIEMBRE  (con  valor  12).
		 * Muestra  el  valor  numérico  correspondiente  a OCTUBRE.*/
		 
		 
		 Console.WriteLine("El valor numerico de octubre es: {0}", (int) diasSemana.OCTUBRE);
	}
}
