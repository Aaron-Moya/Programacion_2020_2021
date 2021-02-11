class Ejercicio_2_1_5_6
{
//(2.1.5.6) Crea un programa que pida al usuario dos números enteros y diga si (al menos) uno es par.

	static void Main() {
		System.Console.Write("Dime un numero: ");
		int num1 = System.Convert.ToInt32( System.Console.ReadLine());
		
		System.Console.Write("Dime otro numero: ");
		int num2 = System.Convert.ToInt32( System.Console.ReadLine());
		
		if (num1 % 2 == 0 || num2 % 2 == 0){
			System.Console.WriteLine("Hay un numero par");
		}
		
	}
}
