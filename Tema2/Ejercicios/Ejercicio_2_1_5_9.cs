class Ejercicio_2_1_5_9
{
// (2.1.5.9) Crea un programa que pida al usuario tres números y muestre cuál es el mayor de los tres	

	static void Main() {
		System.Console.Write("Dime un numero: ");
		int num1 = System.Convert.ToInt32( System.Console.ReadLine());
		
		System.Console.Write("Dime otro numero: ");
		int num2 = System.Convert.ToInt32( System.Console.ReadLine());
		
		System.Console.Write("Dime otro numero: ");
		int num3 = System.Convert.ToInt32( System.Console.ReadLine());
		
		if (num1 > num2 && num1 > num3) {
			System.Console.WriteLine("El primer numero es el mas grande");
		} else if (num2 > num1 && num2 > num3) {
			System.Console.WriteLine("El segundo numero es el mas grande");
		} else {
			System.Console.WriteLine("El tercer numero es el mas grande");
		}
	}
}
