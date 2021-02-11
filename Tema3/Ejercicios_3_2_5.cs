using System;

class Ejercicios_3_2_5
{
	static void Main()
	{
		string op = "1";
		do
		{
			Console.WriteLine("\n\n1- Ejercicio 1\n" +
							  "2- Ejercicio 2\n" +
							  "3- Ejercicio 3\n" +
							  "4- Ejercicio 4\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_3_2_5_1();
					break;
				case "2":
					Ejercicio_3_2_5_2();
					break;
				case "3":
					Ejercicio_3_2_5_3();
					break;
				case "4":
					Ejercicio_3_2_5_4();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_2_5_1()
	{
		/*(3.2.5.1) El  usuario  de  nuestro  programa  podrá  teclear  dos  números  de  hasta  12 cifras significativas.  
		 * El  programa  deberá  mostrar  el  resultado  de  dividir  el  primer número entre el segundo, utilizando tres cifras decimales.*/
		 
		 Console.Write("Dime un numero: ");
		 double num1 = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Dime otro numero: ");
		 double num2 = Convert.ToInt32(Console.ReadLine());
		 
		 double resultado = num1 / num2;
		 
		 Console.WriteLine("El resultado es: " + resultado.ToString("N3"));
	}
	
	static void Ejercicio_3_2_5_2()
	{
		/*(3.2.5.2) Creaun  programa  que  use  tres  variables  x,y,z.  Las  tres  serán  números reales, y 
		 * nos bastará con datos de simple precisión. Se deberá pedir al usuario los valores  para  las  tres  variables  y  
		 * mostrar  en  pantalla  el  valor  de  x2+  y -z  (con exactamente dos cifras decimales)*/
		 
		 Console.Write("Dime un numero: ");
		 float x = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Dime otro numero: ");
		 float y = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Dime otro numero: ");
		 float z = Convert.ToInt32(Console.ReadLine());
		 
		 float resultado = ((x * x) + y - z);
		 
		 Console.WriteLine("El resultado es: " + resultado.ToString("N2"));
	}
	
	static void Ejercicio_3_2_5_3()
	{
		/*(3.2.5.3) Calcula el  perímetro,  área  y  diagonal  de  un  rectángulo,  a  partir  de  su ancho y alto 
		 * (perímetro = suma de los cuatro lados; área = base x altura;diagonal=hipotenusa, usando el teorema de Pitágoras). 
		 * Muestra todos ellos con una cifra decimal*/
		 
		 Console.Write("Dime el ancho: ");
		 float ancho = Convert.ToSingle(Console.ReadLine());
		 
		 Console.Write("Dime el alto: ");
		 float alto = Convert.ToSingle(Console.ReadLine());
		 
		 float perimetro = (ancho * 2) + (alto * 2);
		 float area = perimetro * alto;
		 double diagonal = Math.Sqrt(perimetro);
		 
		 Console.WriteLine("El perímetro es: " + perimetro.ToString("N1"));
		 Console.WriteLine("La area es: " + area.ToString("N1"));
		 Console.WriteLine("La diagonal es: " + diagonal.ToString("N1"));
	}
	
	static void Ejercicio_3_2_5_4()
	{
		/*(3.2.5.4) Calculala  superficie  y  el  volumen  de  una  esfera,  a  partir  de  su  radio 
		 * (superficie  =  4*  pi  *  radio  al  cuadrado;  volumen  =  4/3  *  pi  *  radio  al  cubo). 
		 * Usa datos "doble" y muestralos resultados con 5 cifras decimales*/
		 
		 Console.Write("Dime el radio: ");
		 double radio = Convert.ToDouble(Console.ReadLine());
		 
		 double pi = 3.1415926535897932;
		 
		 double superficie = (4 * pi * radio) * 2;
		 double volumen = 4/3 * pi * (Math.Pow(radio, 3));
		 
		 Console.WriteLine("La superficie es: " + superficie.ToString("N5"));
		 Console.WriteLine("El volumen es: " + volumen.ToString("N5"));
	}
}
