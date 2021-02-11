using System;

class elevado
{
	public static void Main()
	{
		Console.WriteLine(Elevar(8, 3));
	}
	
	public static int Elevar(int b, int e)
	{
		if (e == 1)
			return b;
		
		return b * Elevar(b, e - 1);
	}
}
