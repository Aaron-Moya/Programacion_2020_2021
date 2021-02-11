using System;

class Practica_5_1 {
	public static void Main() {
		Console.Write("Dime el tamaño: ");
		int tamanyo = Convert.ToInt32(Console.ReadLine());
		
		int[] primerArray = new int[tamanyo];
		int[] segundoArray = new int[tamanyo];
		int[] tercerArray = new int[tamanyo * 2];
		
		RellenarArrays(tamanyo, primerArray, segundoArray, tercerArray);
	}
	
	public static void RellenarArrays(int tamanyo, int[] primerArray, int[] segundoArray, int[] tercerArray) {
		Random rd = new Random();

		for (int i = 0; i < tamanyo; i++) {
			primerArray[i] = rd.Next(1, 10);
			segundoArray[i] = rd.Next(1, 10);
		}
		
		for (int i = 0; i < tamanyo * 2; i++) {
		}
	}
}

