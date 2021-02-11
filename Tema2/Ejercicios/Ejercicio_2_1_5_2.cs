class Ejercicio_2_1_5_2
{
//(2.1.5.2) Crea un programa que pida al usuario un número entero y responda si es múltiplo de 2 y de 3 simultáneamente.
	
	static void Main() {
		System.Console.Write("Dime un número entero: ");
		int num1 = System.Convert.ToInt32( System.Console.ReadLine());
		
		if (num1 % 2 == 0 && num1 % 3 == 0){
			System.Console.WriteLine("El numero es múltiplo de 2 y de 3");
		} else {
			System.Console.WriteLine("El numero no es múltiplo de 2 y de 3");
		}
	}
}
