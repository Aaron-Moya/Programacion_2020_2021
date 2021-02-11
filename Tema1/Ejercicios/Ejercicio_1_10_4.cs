class Ejercicio1104
{
		static void Main(){
			
		/* (1.10.4) Pide al usuario una cantidad de "millas náuticas" y muestra la equivalencia
			en metros, usando: 1 milla náutica = 1852 metros. */
		
		System.Console.Write("Dime una cantidad de millas náuticas: ");
		int millas = System.Convert.ToInt32( System.Console.ReadLine());
		int totalMetros = millas * 1852;
		
		System.Console.WriteLine("{0} milla náutica = {1} metros", millas, totalMetros);
			
		}
	
	
}
