using System;

class Ejercicios_4_1_3
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
							  "7- Ejercicio 7\n" +
							  "8- Ejercicio 8\n" +
							  "9- Ejercicio 9\n" +
							  "10- Ejercicio 10\n" +
							  "11- Ejercicio 11\n" +
							  "0- Salir");
			op = Console.ReadLine();
			
			switch (op)
			{
				case "1":
					Ejercicio_4_1_3_1();
					break;
				case "2":
					Ejercicio_4_1_3_2();
					break;
				case "3":
					Ejercicio_4_1_3_3();
					break;
				case "4":
					Ejercicio_4_1_3_4();
					break;
				case "5":
					Ejercicio_4_1_3_5();
					break;
				case "6":
					Ejercicio_4_1_3_6();
					break;
				case "7":
					Ejercicio_4_1_3_7();
					break;
				case "8":
					Ejercicio_4_1_3_8();
					break;
				case "9":
					Ejercicio_4_1_3_9();
					break;
				case "10":
					Ejercicio_4_1_3_10();
					break;
				case "11":
					Ejercicio_4_1_3_11();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("MAL");
					break;
			}
		} while(op != "0");
	}
	
	static void Ejercicio_4_1_3_1()
	{
		/*(4.1.3.1) Crea un programa que pida al usuario 6 números enteros cortos y 
		 * luego los  muestre  en  orden  inverso(pista:  usa  un  array  para  almacenarlos y  "for"  para mostrarlos).*/
		 
		 int[] numeros = new int[6];
		 
		 Console.Write("Dime el primer numero: ");
		 numeros[0] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el segundo numero: ");
		 numeros[1] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el tercer numero: ");
		 numeros[2] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el cuarto numero: ");
		 numeros[3] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el quinto numero: ");
		 numeros[4] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el sexto numero: ");
		 numeros[5] = Convert.ToInt32(Console.ReadLine());
		 
		 for (int i = 5; i >= 0; i--)
		 {
			 Console.Write(numeros[i]);
		 } 
	}
	
	static void Ejercicio_4_1_3_2()
	{
		/*(4.1.3.2) Crea un programa que pregunte al usuario cuántos números enteros va a introducir(por ejemplo, 10), 
		 * le pida todos esos números, los guarde en un array y finalmente calcule y muestre la media de esos números*/
		 
		 Console.Write("Cuantos números vas a introducir? ");
		 int cantidadNumeros = Convert.ToInt32(Console.ReadLine());
		 int [] numeros = new int[cantidadNumeros];
		 
		 int contador = 0;
		 int suma = 0;
		 int numero = 0;
		 
		 do {
			 Console.WriteLine("Dime un numero: ");
			 numero = Convert.ToInt32(Console.ReadLine());
			 numeros[contador] = numero;
			 suma += numeros[contador];
			 contador += 1;

		} while (contador < cantidadNumeros);
		 
		 Console.WriteLine("La media de los numeros es: " + (suma / cantidadNumeros)); 
	}
	
	static void Ejercicio_4_1_3_3()
	{
		/*(4.1.3.3) Un programa que pida al usuario 10 reales de doble precisión, calcule su media y luego muestre los que están por encima de la media.*/
		
		double [] numeros = new double[10];
		double suma = 0;
		 
		 Console.Write("Dime el primer numero: ");
		 numeros[0] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el segundo numero: ");
		 numeros[1] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el tercer numero: ");
		 numeros[2] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el cuarto numero: ");
		 numeros[3] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el quinto numero: ");
		 numeros[4] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el sexto numero: ");
		 numeros[5] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el séptimo numero: ");
		 numeros[6] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el octavo numero: ");
		 numeros[7] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el noveno numero: ");
		 numeros[8] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el décimo numero: ");
		 numeros[9] = Convert.ToInt32(Console.ReadLine());
		 
		 for(int i = 0; i < 10; i++)
		 {
			 suma += numeros[i];
		 }
		 
		 double media = suma / 10;
		 Console.WriteLine("La media de los numeros es: {0} ", media);
		 
		 for(int i = 0; i < 10; i++)
		 {
			 if (numeros[i] > media)
			 {
				Console.WriteLine("El numero {0} está por encima de la media({1})", numeros[i], media);
			 }
		 }
	}
	
	static void Ejercicio_4_1_3_4()
	{
		/*(4.1.3.4) Un  programa  que  almacene  en  una  tabla  el  número  de  días  que  tiene cada mes (de un año no bisiesto), 
		 * pida al usuario que le indique un mes (ej. 2 para febrero)  y  un  día  (ej.  el  día  15)  y  
		 * diga  qué  número  de  día  es  dentro  del  año  (por ejemplo,  el  15  de  febrero  sería  el  día  número  46,  
		 * el  31  de  diciembre  sería  el  día 365).*/
		 int[] meses = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		 
		 Console.Write("Dime el numero de un mes: ");
		 int mes = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el día de un mes: ");
		 int dia = Convert.ToInt32(Console.ReadLine());
		 
		 int suma = 0;
		 
		 for (int i = 1; i < mes; i++)
		 {
			suma += meses[i];
		 }
		 
		 suma += dia;
		 Console.WriteLine("El dia {0} del mes {1} sería el día número {2} del año", dia, mes, suma);
	}
	
	static void Ejercicio_4_1_3_5()
	{
		/*(4.1.3.5) A partir del ejercicio anterior, crea otro que pida al usuario que le indique la  fecha, formada  pordía  (1  al  31)  y  
		 * el  mes  (1=enero,  12=diciembre), y como respuesta muestre en pantalla el número de días que quedan hasta final de año.*/
		 
		 int[] meses = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		 
		 Console.Write("Dime el numero de un mes: ");
		 int mes = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el día de un mes: ");
		 int dia = Convert.ToInt32(Console.ReadLine());
		 
		 int suma = 0;
		 
		 for (int i = mes + 1; i <= 12; i++)
		 {
			suma += meses[i];
		 }
		 
		 dia = meses[mes] - dia;
		 suma += dia;
		 Console.WriteLine("Quedan {0} días del año", suma);
	}
	
	static void Ejercicio_4_1_3_6()
	{
		/*(4.1.3.6) Un  programa  que  pida  10  nombres  y  los  memorice  (pista:  esta  vez  se trata  de  un  array  de  "string").  
		 * Después  deberá  pedir  que  se  teclee  un  nombre  y dirá si se encuentra o no entre los 10 que se han tecleado antes. 
		 * Volverá  a pedir otro nombre y a decir si se encuentra entre ellos, y así sucesivamente hasta que se teclee  "fin".
		 * En  el  siguiente  apartado  verás  detalles  de  cómo  hacer  ese  tipo  de búsquedas.*/
		 
		 string[] nombres = new string[10];
		 Console.Write("Dime el primer nombre: ");
		 nombres[0] = (Console.ReadLine());
		 Console.Write("Dime el segundo nombre: ");
		 nombres[1] = (Console.ReadLine());
		 Console.Write("Dime el tercer nombre: ");
		 nombres[2] = (Console.ReadLine());
		 Console.Write("Dime el cuarto nombre: ");
		 nombres[3] = (Console.ReadLine());
		 Console.Write("Dime el quinto nombre: ");
		 nombres[4] = (Console.ReadLine());
		 Console.Write("Dime el sexto nombre: ");
		 nombres[5] = (Console.ReadLine());
		 Console.Write("Dime el séptimo nombre: ");
		 nombres[6] = (Console.ReadLine());
		 Console.Write("Dime el octavo nombre: ");
		 nombres[7] = (Console.ReadLine());
		 Console.Write("Dime el noveno nombre: ");
		 nombres[8] = (Console.ReadLine());
		 Console.Write("Dime el décimo nombre: ");
		 nombres[9] = (Console.ReadLine());
		 
		 string nombre;
		 do {
			 Console.Write("Dime un nombre(fin para salir): ");
			 nombre = Console.ReadLine();
			 
			 for (int i = 0; i < 10; i++)
			 {
				 if (nombres[i] == nombre)
				 {
					Console.WriteLine("El nombre está en la lista!"); 
				 }
			 }
		 } while(nombre != "fin");
	}
	
	static void Ejercicio_4_1_3_7()
	{
		/*(4.1.3.7) Un  programaque  prepare  espacio  para guardar un  máximo  de  100 nombres.  
		 * El  usuario  deberá  ir  introduciendo  un  nombre  cada  vez,  hasta  que  se pulse Intro sin teclear nada, 
		 * momento en el que dejarán de pedirse más nombres y se mostrará en pantalla la lista de los nombresque se han introducido.*/
		 
		 string[] nombres = new string[100];
		 int contador = 0;
		 string nombre;
		 
		 do {
			contador += 1;
			Console.Write("Dime un nombre: ");
			nombre = Console.ReadLine();
			
			nombres[contador] = nombre;
			
		} while(String.IsNullOrEmpty(nombre) == false);
		
		if (String.IsNullOrEmpty(nombre) == true)
		{
			Console.WriteLine("Los nombres introducidos son: ");
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine(nombres[i]);
			}
		}
	}
	
	static void Ejercicio_4_1_3_8()
	{
		/*(4.1.3.8) Un programa que reserve espacio para un vector de 3 componentes, pida al  usuario  valores  para  dichas  
		 * componentes  (por  ejemplo  [2, -5,  7])  y  muestre  su módulo  (la raíz  cuadrada  de  la  suma  de  sus  componentes  al  cuadrado;  
		 * por ejemplo, para [2, -5, 7] el resultado sería la raíz cuadradade 78, aproximadamente 8,83).*/
		 
		 double[] componentes = new double[3];
		 double suma = 0;
		 double resultado = 0;
		 
		 Console.Write("Dime el primer numero: ");
		 componentes[0] = Convert.ToDouble(Console.ReadLine());
		 Console.Write("Dime el segundo numero: ");
		 componentes[1] = Convert.ToDouble(Console.ReadLine());
		 Console.Write("Dime el tercer numero: ");		 
		 componentes[2] = Convert.ToDouble(Console.ReadLine());
		
		 for (int i = 0; i < 3; i++)
		 {
			suma += componentes[i]; 
		 }
		  
		 resultado = Math.Sqrt(suma * suma);
		 Console.WriteLine("El resultado es: {0}", resultado);
	}
	
	static void Ejercicio_4_1_3_9()
	{
		/*(4.1.3.9) Un  programa  que  reserve  espacio  para  dos  vectores  de  3  componentes, pida  al  usuario  sus  valores  y  
		 * calcule  la  suma  de  ambos  vectores  (su  primera componente será x1+y1, la segunda será x2+y2 y así sucesivamente).*/
		 
		 double[] vector1 = new double[3];
		 double[] vector2 = new double[3];
		 double suma1 = 0;
		 double suma2 = 0;
		 
		 Console.WriteLine("VECTOR1");
		 Console.Write("Dime el primer numero: ");
		 vector1[0] = Convert.ToDouble(Console.ReadLine());
		 Console.Write("Dime el segundo numero: ");
		 vector1[1] = Convert.ToDouble(Console.ReadLine());
		 Console.Write("Dime el tercer numero: ");		 
		 vector1[2] = Convert.ToDouble(Console.ReadLine());
		 
		 Console.WriteLine("VECTOR2");
		 Console.Write("Dime el primer numero: ");
		 vector2[0] = Convert.ToDouble(Console.ReadLine());
		 Console.Write("Dime el segundo numero: ");
		 vector2[1] = Convert.ToDouble(Console.ReadLine());
		 Console.Write("Dime el tercer numero: ");		 
		 vector2[2] = Convert.ToDouble(Console.ReadLine());
		 
		 for (int i = 0; i < 3; i++)
		 {
			suma1 += vector1[i]; 
		 }
		 
		 for (int i = 0; i < 3; i++)
		 {
			suma2 += vector2[i]; 
		 }
		 
		 Console.WriteLine("La suma de los 2 vectores es: " + (suma1 + suma2));
	}
	
	static void Ejercicio_4_1_3_10()
	{
		/*(4.1.3.10) Un programa que reserve espacio para dos vectores de 3 componentes, pida al usuario sus valores y 
		 * calcule su producto escalar (x1·y1+ x2·y2+z1·z2).*/
		 
		 double[] vector1 = new double[3];
		 double[] vector2 = new double[3];
		 double operacion1 = 1;
		 double operacion2 = 1;
		 
		 Console.WriteLine("VECTOR1");
		 Console.Write("Dime el primer numero: ");
		 vector1[0] = Convert.ToDouble(Console.ReadLine());
		 Console.Write("Dime el segundo numero: ");
		 vector1[1] = Convert.ToDouble(Console.ReadLine());
		 Console.Write("Dime el tercer numero: ");		 
		 vector1[2] = Convert.ToDouble(Console.ReadLine());
		 
		 Console.WriteLine("VECTOR2");
		 Console.Write("Dime el primer numero: ");
		 vector2[0] = Convert.ToDouble(Console.ReadLine());
		 Console.Write("Dime el segundo numero: ");
		 vector2[1] = Convert.ToDouble(Console.ReadLine());
		 Console.Write("Dime el tercer numero: ");		 
		 vector2[2] = Convert.ToDouble(Console.ReadLine());
		 
		 for (int i = 0; i < 3; i++)
		 {
			operacion1 *= vector1[i]; 
		 }
		 
		 for (int i = 0; i < 3; i++)
		 {
			operacion2 *= vector2[i]; 
		 }
		 
		 Console.WriteLine("La suma de los 2 vectores es: " + (operacion1 + operacion2));
	}
	
	static void Ejercicio_4_1_3_11()
	{
		/*(4.1.3.11) Un  programa  que  pida  al  usuario  4  números  enteros  y  calcule  (y muestre) cuál es el mayor de ellos. 
		 * Nota: para calcular el mayor valor de un array, hay que comparar cada uno de los valores que tiene almacenados el array con el que 
		 * hasta ese momento es el máximo provisional. El valor inicial de este máximo provisional no  debería  ser  cero  
		 * (porque el  resultado  sería  incorrectosi  todos  los números son negativos), * sino el primer elemento del array.*/
		 
		 int[] numeros = new int[4];
		 int maximo = 1;
		 
		 Console.Write("Dime el primer numero: ");
		 numeros[0] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el segundo numero: ");
		 numeros[1] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el tercer numero: ");		 
		 numeros[2] = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el cuarto numero: ");		 
		 numeros[3] = Convert.ToInt32(Console.ReadLine());
		 
		 for (int i = 0; i < 4; i++)
		 {
			if (numeros[i] > maximo)
			{
				maximo = numeros[i];
			}
		 }
		 
		 Console.WriteLine("El número mas grande es: {0}", maximo);
	}
}

