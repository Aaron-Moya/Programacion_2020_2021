class Ejercicio_2_1_4_1
{
// (2.1.4.1) Mejora la solución al ejercicio 2.1.3.1, usando "else".

		static void Main(){
		System.Console.Write("Dime un numero entero: ");
		int num1 = System.Convert.ToInt32(System.Console.ReadLine());
		
		if (num1 == 0){
			System.Console.WriteLine("El producto de 0 por cualquier numero es 0");
		} else {
		
			System.Console.Write("Dime otro numero: ");
			int num2 = System.Convert.ToInt32( System.Console.ReadLine());
			int resultado = num1 * num2;
			
			System.Console.WriteLine("El producto de los dos numeros es: " + resultado);
		}
	}
}
