class Ejercicio_2_1_5_3
{
// (2.1.5.3) Crea un programa que pida al usuario un número entero y responda si es múltiplo de 2 pero no de 3.

	static void Main() {
		System.Console.Write("Dime un numero: ");
		int num1 = System.Convert.ToInt32 ( System.Console.ReadLine());
		
		if (num1 % 2 == 0 && num1 % 3 != 0){
			System.Console.WriteLine("El numero es múltiplo de 2 pero no de 3");
		}
	}
}
