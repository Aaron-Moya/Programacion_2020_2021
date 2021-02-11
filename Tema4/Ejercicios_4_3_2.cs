using System;

class Ejercicios_4_3_2
{
	static void Main()
	{
		string op = "1";
		do
		{
			Console.WriteLine("\n\n1- Ejercicio 1\n" +
							  "2- Ejercicio 2\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_4_3_2_1();
					break;
				case "2":
					Ejercicio_4_3_2_2();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	struct tipoCancion
	{
		 public string artista;
		 public string titulo;
		 public double duracion;
		 public double tamanyo;
	}
	
	static void Ejercicio_4_3_2_1()
	{
		/*(4.3.2.1) Amplia  el  programa del  ejercicio 4.3.1.1,  para  que  almacene  datos  de hasta  100  canciones.  
		 * Deberá  tener  un  menú  que  permita al  usuario  realizar las opciones:  añadir  una  nueva  canción, 
		 * mostrar  el  título  de  todas  las  canciones, buscar  la  canción  que  contenga  un  cierto  texto  (en  el  artista  o  en  el  título).
		 * Recuerda  que el  array  estará  sobredimensionado,  así  que  deberás  llevar  un contador de la cantidad de datos que hay almacenados hasta el momento*/
		 
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
				 Console.Write("Dime la duracion: ");
				 canciones[cantidad].duracion = Convert.ToDouble(Console.ReadLine());
				 Console.Write("Dime el tamaño: ");
				 canciones[cantidad].tamanyo = Convert.ToDouble(Console.ReadLine());
				 
				 cantidad++;
			 }
			 else if (op == 2)
			 {
				 Console.WriteLine("Los títulos de las canciones son:");
				 for (int i = 0; i < cantidad; i++)
				 {
					 Console.WriteLine(canciones[i].titulo);
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
	
	struct tipoImagen
	{
		public string nombre;
		public int ancho;
		public int alto;
		public double tamanyo;
	}
	
	static void Ejercicio_4_3_2_2()
	{
		/*(4.3.2.2) Crea un programa que permita guardar datos de "imágenes" 
		 * (ficheros de ordenador que contengan fotografías o cualquier otro tipo de información gráfica). 
		 * De  cada  imagen  se  debe  guardar:  nombre  (texto),  ancho  en  píxeles  (por  ejemplo 2000),  alto  en  píxeles  (por  ejemplo,  3000),  
		 * tamaño  en  Kb  (por  ejemplo  145,6).  El programa debe ser capaz de almacenar hasta 700 imágenes (deberá avisar cuando su  capacidad  esté  llena).  
		 * Debe  permitir  las  opciones:  añadir  una  ficha  nueva,  ver todas las fichas (número y nombre de cada imagen), 
		 * buscar la ficha que tenga un cierto nombre(mostrando entonces todos sus datos).*/
		 
		 tipoImagen[] imagenes = new tipoImagen[700];
		 int cantidad = 0;
		 int op;
		 string buscar;
		 
		 do { 
			Console.WriteLine("Elige una opcion:");
			Console.WriteLine("1 - Añadir imagen");
			Console.WriteLine("2 - Mostrar nombres");
			Console.WriteLine("3 - Buscar imagen");
			Console.WriteLine("0 - Salir");
			op = Convert.ToInt32(Console.ReadLine());
			 
			 if (op == 1)
			 {
				 if (cantidad < 700)
				 {
					 Console.Write("Dime el nombre: ");
					 imagenes[cantidad].nombre = Console.ReadLine();
					 Console.Write("Dime el ancho: ");
					 imagenes[cantidad].ancho = Convert.ToInt32(Console.ReadLine());
					 Console.Write("Dime el alto: ");
					 imagenes[cantidad].alto = Convert.ToInt32(Console.ReadLine());
					 Console.Write("Dime el tamaño: ");
					 imagenes[cantidad].tamanyo = Convert.ToDouble(Console.ReadLine());
					 
					 cantidad++;
				}
				else
				{
					Console.WriteLine("No se pueden agregar mas imagenes, la lista esta llena");
				}
			 }
			 else if (op == 2)
			 {
				 int contador = 0;
				 Console.WriteLine("Las imagenes almacenadas son:");
				 
				 for (int i = 0; i < cantidad; i++)
				 {
					 Console.WriteLine("La imagen {0}, tiene el nombre {1}", contador, imagenes[i].nombre);
					 contador++;
				 }
			 }
			 else if (op == 3)
			 {
				 Console.Write("Dime el nombre de la imagen a buscar: ");
				 buscar = Console.ReadLine();
				 
				 for (int i = 0; i < cantidad; i++)
				 {
					 if (imagenes[i].nombre == buscar)
					 {
						 Console.WriteLine("La información de la imagen es la siguiente: ");
						 Console.WriteLine("Nombre: {0}", imagenes[i].nombre);
						 Console.WriteLine("Ancho: {0}", imagenes[i].ancho);
						 Console.WriteLine("Alto: {0}", imagenes[i].alto);
						 Console.WriteLine("Tamaño: {0}", imagenes[i].tamanyo);
					 }
				 }
			 }
		 } while (op != 0);
	}
}
