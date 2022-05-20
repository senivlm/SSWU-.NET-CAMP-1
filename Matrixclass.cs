
namespace Matrixclass
{
    class Matr
    {
        private readonly int ml, mc;
        private int[,] matrix;

        public Matr(int n, int m)
        {
            this.ml = n;
            this.mc = m;
            matrix = new int[n, m];
        }


        public void VertSnake() // вертикальна змійка
        {
            int rate = 1;
            for (int i = 0; i < mc; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < ml; j++)
                        matrix[j, i] = rate++;
                }
                else
                {
                    for (int j = ml - 1; j >= 0; j--)
                        matrix[j, i] = rate++;
                }
            }
        }

        public void DSnake() // діагональна матриця
        {

            int a = 1;
            for (int lev = 0; lev < mc; lev++)
            {
                if (lev % 2 == 0)
                {
                    for (int i = 0; i <= lev; i++)
                        matrix[i, lev - i] = a++;
                }
                else
                {
                    for (int j = lev; j >= 0; j--)
                        matrix[j, lev - j] = a++;
                }
            }

            for (int lev = ml; lev <= (ml - 1) * 2; lev++)
            {
                if (lev % 2 == 0)
                {
                    for (int i = lev - ml + 1; i <= mc - 1; i++)
                        matrix[i, lev - i] = a++;
                }
                else
                {
                    for (int i = ml - 1; i >= lev - ml + 1; i--)
                        matrix[i, lev - i] = a++;
                }
            }

        }

        public void Matrixread() // виведення матриць
        {
            for (int i = 0; i < ml; i++)
            {
                for (int j = 0; j < mc; j++)
                {
                    Console.Write(matrix[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }

        public void Circle_Snake() //спіральна матриця.
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            if (n % 2 != 0)
            {
                matrix[n / 2, n / 2] = n * n;
            }
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < (n - i); j++)
                {
                    matrix[i, j] = m;
                    m++;
                }
                for (int j = 1; j < (n - i - i); j++)
                {
                    matrix[j + i, n - i - 1] = m;
                    m++;
                }
                for (int j = (n - 2) - i; j >= i; j--)
                {
                    matrix[n - i - 1, j] = m;
                    m++;
                }
                for (int j = (n - i - 2); j > i; j--)
                {
                    matrix[j, i] = m;
                    m++;
                }
            }
        }
    }
}
