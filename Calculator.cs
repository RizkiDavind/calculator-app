class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan : {0} + {1} = {2}", a, b, Penambahan(a, b));
		Console.WriteLine("hasil Pengurangan : {0} + {1} = {2}", a, b, Pengurangan(a, b));
		
		Console.WriteLine("\nTekan Sembarang Key untuk keluar");
		Console.ReadKey();
	}
}

static int Penambahan(int a, int b)
{
	return a + b;
}

static int Pengurangan(int a, int b)
{
	return a - b;
}