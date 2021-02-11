using System;

class Ejercicios_5_3_4_6 {
	public static void Main() {
		Console.Write("Dime un caracter: ");
		char caracter = Convert.ToChar(Console.ReadLine());
		
		Console.Write("Dime el ancho: ");
		int ancho = Convert.ToInt32(Console.ReadLine());
		Console.Write("Dime el alto: ");
		int alto = Convert.ToInt32(Console.ReadLine());
		
		DibujarRectanguloHueco(alto, caracter, ancho);
	}
	
	static void DibujarRectanguloHueco(int alto, char caracter, int ancho) {
		for (int i = 0; i < alto; i++) {
				if (i == 0 || i == alto - 1) {
					EscribirRepetido(caracter, ancho);
				} else {
					EscribirRepetido(caracter, 1);
					EscribirRepetido(' ', ancho - 2);
					EscribirRepetido(caracter, 1);
				}
				Console.WriteLine();
		 }
	}
	
	static void EscribirRepetido(char caracter, int ancho) {
		for (int i = 0; i < ancho; i++) {
			Console.Write(caracter);
		}
	}
}
