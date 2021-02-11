using System;

class Ejercicio_5_5_5
{
/*(5.5.6) Crea  una  función "DibujarTriángulo" que  reciba  una  letra  y  un  número,  y escriba  un  "triángulo"  formado  por  esa  letra,  
 * que  tenga  como  anchura  inicial  la que se ha indicado. */
 
	static void Main()
	{
		DibujarTriangulo('x', 4);
	}
	
	static void DibujarTriangulo(char letra, int tamanyo)
	{
		for (int i = 0; i < tamanyo; i++)
		{
			for (int j = i; j < tamanyo; j++)
			{
				Console.Write(letra);
			}
			Console.WriteLine();
		}
	}
}
