class Ejercicio_2_1_3_1
{
/*(2.1.3.1) Crea un programa que multiplique dos números enteros de la siguiente
forma: pedirá al usuario un primer número entero. Si el número que se que teclee
es 0, escribirá en pantalla "El producto de 0 por cualquier número es 0". Si se ha
tecleado un número distinto de cero, se pedirá al usuario un segundo número y se mostrará el producto de ambos. */

	static void Main(){
		System.Console.Write("Dime un numero entero: ");
		int num1 = System.Convert.ToInt32(System.Console.ReadLine());
		
		if (num1 == 0){
			System.Console.WriteLine("El producto de 0 por cualquier numero es 0");
		}
		
		if (num1 != 0){
			System.Console.Write("Dime otro numero: ");
			int num2 = System.Convert.ToInt32( System.Console.ReadLine());
			int resultado = num1 * num2;
			
			System.Console.WriteLine("El producto de los dos numeros es: " + resultado);
		}
		
	}	
	
	
	
	
	
	
	
}
