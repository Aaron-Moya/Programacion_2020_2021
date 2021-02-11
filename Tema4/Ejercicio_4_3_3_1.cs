using System;

class Ejercicio_4_3_3_1
{
/*(4.3.3.1) Amplia  el  programa  4.3.2.1,  para  que  el  campo  "duración"  se  almacene como  minutos  y  segundos,  
 * usando  un  "struct"  anidado  que  contenga  a  su  vez estos dos campos*/
	
	struct duracionCancion
	{
		public int minutos;
		public int segundos;
	}
	
	struct tipoCancion
	{
		 public string artista;
		 public string titulo;
		 public duracionCancion duracion;
		 public double tamanyo;
	}
	
	static void Main()
	{
		 tipoCancion[] canciones = new tipoCancion[100];
		 int cantidad = 0;
		 int op;
		 string buscar;
		 
		 do {
			 
			Console.WriteLine("Elige una opcion:");
			Console.WriteLine("1 - Añadir canción");
			Console.WriteLine("2 - Mostrar titulos");
			Console.WriteLine("3 - Buscar canción");
			Console.WriteLine("0 - Salir");
			op = Convert.ToInt32(Console.ReadLine());
			 
			 if (op == 1)
			 {
				 Console.Write("Dime el artista: ");
				 canciones[cantidad].artista = Console.ReadLine();
				 Console.Write("Dime el titulo: ");
				 canciones[cantidad].titulo = Console.ReadLine();
				 Console.Write("Dime los minutos que dura: ");
				 canciones[cantidad].duracion.minutos = Convert.ToInt32(Console.ReadLine());
				 Console.Write("Dime los segundos que dura: ");
				 canciones[cantidad].duracion.segundos = Convert.ToInt32(Console.ReadLine());
				 Console.Write("Dime el tamaño: ");
				 canciones[cantidad].tamanyo = Convert.ToDouble(Console.ReadLine());
				 
				 cantidad++;
			 }
			 else if (op == 2)
			 {
				 Console.WriteLine("La información de las canciones son:");
				 for (int i = 0; i < cantidad; i++)
				 {
					 Console.Write(canciones[i].artista + " - " + canciones[i].titulo);
					 Console.Write("   minutos: {0} segundos{1}", canciones[i].duracion.minutos, canciones[i].duracion.segundos);
					 Console.WriteLine();
				 }
			 }
			 else if (op == 3)
			 {
				 Console.Write("Dime el texto a buscar: ");
				 buscar = Console.ReadLine();
				 
				 for (int i = 0; i < cantidad; i++)
				 {
					 if (canciones[i].titulo == buscar)
					 {
						 Console.WriteLine("El titulo existe!");
					 }
					 else if (canciones[i].artista == buscar)
					 {
						 Console.WriteLine("El artista existe!");
					 }
				 }
			 }
		 } while (op != 0);
	}
}
