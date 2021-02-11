using System;

class Ejercicio_2_2_5_2
{
//(2.2.5.2) Crea un programa escriba 4 veces los números del 1 al 5, en una misma línea, usando "while": 12345123451234512345.	

	static void Main()
	{
		int indiceUno = 1;

		
		while (indiceUno <= 4){
			indiceUno += 1;
			int indiceDos = 1;
			
			while (indiceDos <= 5)
			{
				Console.Write(indiceDos);
				indiceDos += 1;
			}
		}
	}
}
