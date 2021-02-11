class Ejercicio_2_1_2_1
{
/*(2.1.2.1) Crea un programa que pida al usuario un número entero. Si es múltiplo
de 10, informará al usuario y pedirá un segundo número, para decir a
continuación si este segundo número también es múltiplo de 10.*/

	static void Main(){
		
		System.Console.WriteLine("Dime un numero entero: ");
		int num1 = System.Convert.ToInt32( System.Console.ReadLine());
		
		if (num1 % 10 == 0){
			System.Console.WriteLine("El numero es multiplo de 10");
			System.Console.WriteLine("Dime otro numero entero: ");
			int num2 = System.Convert.ToInt32(System.Console.ReadLine());
				
				if (num2 % 10 == 0){
					System.Console.WriteLine("El segundo numero tambien es multiplo de 10");
				}
		} else {
			System.Console.WriteLine("El numero no es multiplo de 10");
		}
	
	
	
	}
}
