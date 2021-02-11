class Ejercicio_2_1_5_8
{
/* (2.1.5.8) Crea un programa que pida al usuario dos números enteros y diga "Uno de los números es positivo", 
 "Los dos números son positivos" o bien "Ninguno de los números es positivo", según corresponda. */	
	
	static void Main() {
		System.Console.Write("Dime un numero: ");
		int num1 = System.Convert.ToInt32 (System.Console.ReadLine());
		
		System.Console.Write("Dime otro numero: ");
		int num2 = System.Convert.ToInt32 (System.Console.ReadLine());
		
		if (num1 > 0 && num2 < 0 || num1 < 0 && num2 > 0) {
			System.Console.WriteLine("Uno de los numeros es positivo");
		} else if (num1 > 0 && num2 > 0) {
			System.Console.WriteLine("Los dos numeros son positivos");
		} else {
			System.Console.WriteLine("Ninguno de los numeros es positivo");
		}

	}
}
