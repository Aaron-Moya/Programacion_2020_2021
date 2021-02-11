class Ejercicio_2_1_5_10
{
// (2.1.5.10) Crea un programa que pida al usuario dos números enteros y diga si son iguales o, en caso contrario, cuál es el mayor de ellos.	

	static void Main() {
		System.Console.Write("Dime un numero: ");
		int num1 = System.Convert.ToInt32( System.Console.ReadLine());
		
		System.Console.Write("Dime otro numero: ");
		int num2 = System.Convert.ToInt32( System.Console.ReadLine());
		
		if (num1 == num2) {
			System.Console.WriteLine("Los dos numeros son iguales");
		} else if (num1 > num2) {
			System.Console.WriteLine("El primer numero es el mas grande");
		} else {
			System.Console.WriteLine("El segundo numero es el mas grande");
		}
		
	}
}
