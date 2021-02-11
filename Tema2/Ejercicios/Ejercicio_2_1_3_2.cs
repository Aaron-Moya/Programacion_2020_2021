class Ejercicio_2_1_3_2
{
/*(2.1.3.2) Crea un programa que pida al usuario dos números enteros. Si el
segundo no es cero, mostrará el resultado de dividir el primero entre el segundo.
Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre cero". */

		static void Main(){
			System.Console.Write("Dime un numero: ");
			int num1 = System.Convert.ToInt32( System.Console.ReadLine());
			
			System.Console.Write("Dime otro numero: ");
			int num2 = System.Convert.ToInt32( System.Console.ReadLine());
			
			if (num2 != 0){
					int resultado = num1 / num2;
					System.Console.WriteLine("El resultado de la división da: " + resultado);
			}
			
			if (num2 == 0){
					System.Console.WriteLine("Error: No se puede dividir entre cero");
			}
			
			
		}	
}
