using System;

class Ejercicios_3_2_7
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
					Ejercicio_3_2_7_1();
					break;
				case "2":
					Ejercicio_3_2_7_2();
					break;
				case "3":
					Ejercicio_3_2_7_3();
					break;
				case "4":
					Ejercicio_3_2_7_4();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_2_7_1()
	{
		/*(3.2.7.1) Crea un programa que halle (y muestre) laraízcuadradadelnúmeroque introduzca el usuario. Se repetirá hasta que introduzca 0.*/
		
		double numero = 1;
		
		do {
			Console.Write("Dime un numero(0 para salir): ");
			numero = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("La raíz cuadrada es: " + (Math.Sqrt(numero)));
		} while (numero != 0);
	}
	
	static void Ejercicio_3_2_7_2()
	{
		/*(3.2.7.2) Diseña un programa que calcule cualquier raíz (de cualquier orden) de un número. 
		 * El usuario deberá indicar el número (por ejemplo, 2) y el índice de la raíz (por ejemplo, 3 para la raíz cúbica). 
		 * Pista: hallar la raíz cúbica de 2 es lo mismo que elevar 2 a 1/3*/
		 
		double numero;
		double raiz;
		
		Console.Write("Dime un numero: ");
		numero = Convert.ToDouble(Console.ReadLine());
		Console.Write("Dime la raiz: ");
		raiz = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("El numero {0} elevado a {1} es: " +  Math.Pow(numero, raiz), numero, raiz);
	}
	
	static void Ejercicio_3_2_7_3()
	{
		/*(3.2.7.3) Crea unprograma que calcule la distancia entre dos puntos (x1,y1) y (x2,y2), usando la expresión d = raíz [ (x1-x2)2+ (y1-y2)2]*/
		
		Console.Write("Dime la primera x: ");
		double xUno = Convert.ToDouble(Console.ReadLine());
		Console.Write("Dime la segunda x: ");
		double xDos = Convert.ToDouble(Console.ReadLine());
		Console.Write("Dime la primera y: ");
		double yUno = Convert.ToDouble(Console.ReadLine());
		Console.Write("Dime la segunda y: ");
		double yDos = Convert.ToDouble(Console.ReadLine());
		
		double resultado = Math.Sqrt(Math.Pow(xUno - xDos, 2) + (Math.Pow(yUno - yDos, 2)));
		
		Console.WriteLine("La distancia entre los dos puntos es {0}", resultado);
	}
	
	static void Ejercicio_3_2_7_4()
	{
		/*(3.2.7.4) Crea un programa que pida al usuario un ángulo (en grados) y muestre su seno, coseno y tangente. 
		 * Recuerda que las funciones trigonométricas esperan que el ángulo se indique en radianes, no en grados. 
		 * La equivalencia es que 180 grados =PI radianes.*/
		 
		Console.Write("Dime el angulo: ");
		double angulo = Convert.ToDouble(Console.ReadLine());
		
		double seno = Math.Sin(angulo);
		double coseno = Math.Cos(angulo);
		double tangente = Math.Tan(angulo);
		
		Console.WriteLine("El seno es: " + seno);
		Console.WriteLine("El coseno es: " + coseno);
		Console.WriteLine("La tangente es: " + tangente);
	}
}
