class Ejercicio_2_1_4_2
{
//(2.1.4.2) Mejora la solución al ejercicio 2.1.3.2, usando "else".

	static void Main(){
		System.Console.Write("Dime un numero: ");
			int num1 = System.Convert.ToInt32( System.Console.ReadLine());
			
			System.Console.Write("Dime otro numero: ");
			int num2 = System.Convert.ToInt32( System.Console.ReadLine());
			
			if (num2 != 0){
					int resultado = num1 / num2;
					System.Console.WriteLine("El resultado de la división da: " + resultado);
			} else {
				System.Console.WriteLine("Error: No se puede dividir entre cero");
			}
	}
}
