using System;

class TextoMayusculas
{
	public static void Main()
	{
		string texto = "hola  mundo maravilloso";
		Console.WriteLine(TextoMayuscula(texto));
	}
	
	static string TextoMayuscula(string texto)
	{
		string nuevoTexto = "";
		char letra = 'n';
		
		for (int i = 0; i < texto.Length; i++)
		{
			if (i == 0)
			{
				nuevoTexto += texto[i].ToString().ToUpper();
			} 
			else if (letra.ToString().ToLower() != texto[i].ToString())
			{
				nuevoTexto += texto[i].ToString();
			}
			
			if (texto[i] == ' ')
			{
				nuevoTexto += texto[i + 1].ToString().ToUpper();
				letra = texto[i + 1];
			}
		}
		return nuevoTexto;
	}
}
