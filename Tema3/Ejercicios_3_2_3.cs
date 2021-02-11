using System;

class Ejercicios_3_2_3
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
							  "5- Ejercicio 5\n" +
							  "6- Ejercicio 6\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_3_2_3_1();
					break;
				case "2":
					Ejercicio_3_2_3_2();
					break;
				case "3":
					Ejercicio_3_2_3_3();
					break;
				case "4":
					Ejercicio_3_2_3_4();
					break;
				case "5":
					Ejercicio_3_2_3_5();
					break;
				case "6":
					Ejercicio_3_2_3_6();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_3_2_3_1()
	{
		/*(3.2.3.1) Calcula el volumen de una esfera, dado su radio, que será 
		 * un número de doble precisión (volumen = pi * radio al cubo * 4/3)*/
		 
		 double radio = 5;
		 double pi = 3.14159;
		 double resultado = pi * radio * radio * radio * 4/3;
		 
		 Console.WriteLine("El volumen es: {0}", resultado);
	}
	
	static void Ejercicio_3_2_3_2()
	{
		/*(3.2.3.2) Crea  un  programa  que  pida  al  usuario  a  una  distancia  (en  metros)  y  
		 * el tiempo necesario para recorrerla (como tres números: horas, minutos, segundos), y 
		 * muestre la velocidad, en metros por segundo, en kilómetros por hora y en millas por hora (pista: 1 milla = 1.609 metros).*/
		 
		 Console.Write("Dime una distancia: ");
		 double metros = Convert.ToDouble(Console.ReadLine());
		 double kilometros = metros / 1000;
		 double millas = metros / 1609;
		 
		 Console.Write("Dime el tiempo que necesita(segundos) para recorrerlo: ");
		 double distanciaSegundos = Convert.ToDouble(Console.ReadLine());
		 
		 Console.WriteLine("La velocidad es de: "+ (metros / distanciaSegundos) + " m/s");

		 Console.Write("Dime el tiempo que necesita(horas) para recorrerlo: ");
		 double distanciaHoras = Convert.ToDouble(Console.ReadLine());
		 
		 Console.WriteLine("La velocidad es de: "+ (kilometros / distanciaHoras) + " k/h");		 
		 Console.WriteLine("La velocidad es de: "+ (millas / distanciaHoras) + " millas/h");		 
	}
	
	static void Ejercicio_3_2_3_3()
	{
		/*(3.2.3.3) Halla las soluciones de una ecuación de segundo grado del tipo y = Ax2+ Bx + C. 
		 * Pista: la raíz cuadrada de un número x se calcula con Math.Sqrt(x)*/
		 
		 double a = 1;
		 double b = 2;
		 double c = 2;
		 
		 double resultado = (-b+(Math.Sqrt(Math.Pow(b,2)-4*a*c)))/(2*a);
		 Console.WriteLine("El resultado es {0}", resultado);
	}
	
	static void Ejercicio_3_2_3_4()
	{
		/*(3.2.3.4) Si se ingresan E euros en el banco a un cierto interés I durante N años, el dinero  obtenido  
		 * viene  dado  por  la  fórmula  del  interés  compuesto:  Resultado  =  e (1+  i)n 
		 * Aplícalo  para  calcular  en  cuanto  se  convierten  1.000  euros  al  cabo  de  10 años al 3% de interés anual. */
		 
		 Console.Write("Dime la cantidad de dinero: ");
		 double dinero = Convert.ToDouble(Console.ReadLine());
		 
		 Console.Write("Dime el interes: ");
		 double interes = Convert.ToDouble(Console.ReadLine());
		 
		 Console.Write("Dime los años: ");
		 double anyos = Convert.ToDouble(Console.ReadLine());
		 
		 double resultado = dinero * Math.Pow((1 + interes), anyos);
		 Console.WriteLine("El resultado es {0} ", resultado);
	}
	
	static void Ejercicio_3_2_3_5()
	{
		/*(3.2.3.5) Crea un programa que muestre los primeros 20 valores de la función y = x2-1*/
		
		double resultado;
		
		for (double x = 0; x <= 20; x++)
		{
			resultado = Math.Pow(x, 2) - 1;
			Console.WriteLine("y = {0}", resultado);
		}
	}
	
	static void Ejercicio_3_2_3_6()
	{
		/*(3.2.3.6) Crea  un  programa  que  "dibuje"  la  gráfica  de  y  =  (x-5)2 para  valores  de  x entre  1  y  10.  
		 * Deberá  hacerlo  dibujando  varios  espacios  en  pantalla  y  luego  un asterisco. 
		 * La cantidad de espacios dependerá del valor obtenido para "y".Te será fácil si dibujas la gráfica "girada", 
		 * de forma que los valores de "y" crezcan hacia la derecha*/
		 			 	 
		 for (double x = 1; x <= 10; x++)
		 {
			for (double y = Math.Pow((x-5),2); y >= 0; y--)
				Console.Write(" ");
				Console.Write("*");
				
				Console.WriteLine();
				
			Console.WriteLine();
		 }
	}
}
