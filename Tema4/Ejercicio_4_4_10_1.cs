using System;

class Ejercicio_4_4_10_1
{
/*(4.4.10.1) Crea un programa que pida al usuario una frase y la muestre subrayada, usando  
 * para  ello  una  cadena  formada  por  tantos  guiones  como  letras  tuviera  la frase inicial*/
 
	static void Main()
	{
		Console.Write("Dime una frase: ");
		string frase = Console.ReadLine();
		string guiones = "";
		
		for (int i = 0; i < frase.Length; i++)
		{
			guiones += "_";
		}
		
		Console.WriteLine(frase);
		Console.Write(guiones);
	}
}
