using System;

class Ejercicio_4_3_1_1
{
	/*(4.3.1.1) Crea  un  "struct"  que  almacene  datos  de  una  canción  en  formato  MP3: Artista,  Título,  Duración  (en  segundos),  
	 * Tamaño  del  fichero  (en  KB).  Un  programa debe  pedir  los  datos  de  una  canción  al  usuario,  
	 * almacenarlos  en  dicho  "struct"  y después mostrarlos en pantalla.*/
	 
	 struct tipoCancion
	 {
		 public string artista;
		 public string titulo;
		 public double duracion;
		 public double tamanyo;
	 }
	 
	 static void Main()
	 {
		 tipoCancion cancion;
		 
		 Console.Write("Dime el artista: ");
		 cancion.artista = Console.ReadLine();
		 Console.Write("Dime el titulo: ");
		 cancion.titulo = Console.ReadLine();
		 Console.Write("Dime la duracion: ");
		 cancion.duracion = Convert.ToDouble(Console.ReadLine());
		 Console.Write("Dime el tamaño: ");
		 cancion.tamanyo = Convert.ToDouble(Console.ReadLine());
		 
		 Console.WriteLine("El artista introducido es: {0}", cancion.artista);
		 Console.WriteLine("El titulo introducido es: {0}", cancion.titulo);
		 Console.WriteLine("La artista introducido es: {0}", cancion.duracion);
		 Console.WriteLine("El tamanyo introducido es: {0}", cancion.tamanyo);
	 }
}
