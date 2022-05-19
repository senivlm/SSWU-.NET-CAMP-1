using Matrixclass;

class Program
{
	static void Main(string[] args)
	{
		Matr matr = new(10, 10);
		matr.Matrixread();
		Console.WriteLine();
		matr.DSnake();	
		matr.Matrixread();
		Console.WriteLine();
		matr.Circle_Snake();

		matr.Matrixread();
	}
}