class Ejercicio_2_1_5_1 
{
//(2.1.5.1) Crea un programa que pida al usuario un número entero y responda si es múltiplo de 2 o de 3.

	static void Main() {
		System.Console.Write("Dime un número entero: ");
		int num1 = System.Convert.ToInt32( System.Console.ReadLine());
		
		if (num1 % 2 == 0 || num1 % 3 == 0){
			System.Console.WriteLine("El número es múltiplo de 2 o de 3");
		} else {
			System.Console.WriteLine("El numero no es múltiplo de 2 o de 3");
		}
	
	
	}
}
