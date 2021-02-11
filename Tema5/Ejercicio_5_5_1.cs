using System;

class Ejercicio_5_5_1
{
/*(5.5.1) Crea  una  función  "PedirEntero",  que  reciba  como  parámetros  el  texto  que se  debe  mostrar  en  pantalla,  
 * el  valor  mínimo  aceptable  y  el  valor  máximo aceptable. Esta  función deberá  pedir  al  usuario  que  introduzca  el  valor,
 * tantas veces  como  sea  necesario, deberá volvérselo  a  pedir  en  caso  de  error,  y deberá devolver un valor correcto. 
 * Pruébalocon un programa que pida al usuario un año entre 1800 y 2100*/
 
	static void Main()
	{
		Console.Write("Dime un valor: ");
		int valor = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine(PedirEntero(valor, 2100, 1800));
	}
	
	static int PedirEntero(int valor, int maximo, int minimo)
	{
		while (valor >= maximo || valor <= minimo)
		{
			Console.Write("Dime un valor: ");
			valor = Convert.ToInt32(Console.ReadLine());
		} 
		
		return valor;
	}
}
