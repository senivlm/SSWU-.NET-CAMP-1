using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    enum Way { Right, Down };

    class Matrix
    {
        #region Fields

        private int[,] matrix;
        private int Countrow;
        private int Countcol;

        #endregion

        #region Properties

        public int CountRow
        {
            get { return Countrow; }
            set
            {
                if (value < 0) Countrow = 0;
                else Countrow = value;
            }
        }
        public int CountCol
        {
            get { return Countcol; }
            set
            {
                if (value < 0) Countcol = 0;
                else Countcol = value;
            }
        }

        #endregion

        #region Constructors

        public Matrix() { }

        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }

        #endregion

        #region Methods

        public void Input()
        {
            for (int i = 0; i < Countrow; i++)
            {
                for (int j = 0; j < Countcol; j++)
                {
                    Console.Write("Введіть елемент матриці [{0}][{1}]: ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void RandomInitialization()
        {
            Random random = new Random();
            for (int i = 0; i < CountRow; i++)
            {
                for (int j = 0; j < CountCol; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }
        }

        public void InputSizeOfMatrix()
        {
            Console.Write("Введіть кількість рядків: ");
            CountRow = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість стовпців: ");
            CountCol = int.Parse(Console.ReadLine());
            this.matrix = new int[Countrow, Countcol];
        }

        
        public void OutputMatrix()
        {
            for (int i = 0; i < Countrow; i++)
            {
                for (int j = 0; j < Countcol; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //diagonal avtoriz
        public void DiagonalSnakeAutorization(int n, Way way)
        {
            CountRow = n;
            CountCol = n;
            matrix = new int[n, n];
            int number = 0;
            if (way == Way.Right)
            {
                for (int line = 0; line < n; line++)
                {
                    if (line % 2 == 0)
                    {
                        int i1 = line;
                        int j1 = 0;
                        for (int i = 0; i < line + 1; i++)
                        {
                            matrix[i1, j1] = ++number;
                            i1--;
                            j1++;
                        }
                    }
                    else
                    {
                        int i1 = 0;
                        int j1 = line;
                        for (int i = 0; i < line + 1; i++)
                        {
                            matrix[i1, j1] = ++number;
                            i1++;
                            j1--;
                        }
                    }
                }

                bool isEven = false;
                if (n % 2 == 0) { isEven = true; }

                for (int line = 1; line < n; line++)
                {
                    if (isEven)
                    {
                        if (line % 2 == 0)
                        {
                            int i1 = line;
                            int j1 = n - 1;
                            for (int i = 0; i < n - line; i++)
                            {
                                matrix[i1, j1] = ++number;
                                i1++;
                                j1--;
                            }
                        }
                        else
                        {
                            int i1 = n - 1;
                            int j1 = line;
                            for (int i = 0; i < n - line; i++)
                            {
                                matrix[i1, j1] = ++number;
                                i1--;
                                j1++;
                            }
                        }
                    }
                    else
                    {
                        if (line % 2 == 0)
                        {
                            int i1 = n - 1;
                            int j1 = line;
                            for (int i = 0; i < n - line; i++)
                            {
                                matrix[i1, j1] = ++number;
                                i1--;
                                j1++;
                            }
                        }
                        else
                        {
                            int i1 = line;
                            int j1 = n - 1;
                            for (int i = 0; i < n - line; i++)
                            {
                                matrix[i1, j1] = ++number;
                                i1++;
                                j1--;
                            }
                        }
                    }
                }
            }
            else
            {
                for (int line = 0; line < n; line++)
                {
                    if (line % 2 == 0)
                    {
                        int i1 = 0;
                        int j1 = line;
                        for (int i = 0; i < line + 1; i++)
                        {
                            matrix[i1, j1] = ++number;
                            i1++;
                            j1--;
                        }
                    }
                    else
                    {

                        int i1 = line;
                        int j1 = 0;
                        for (int i = 0; i < line + 1; i++)
                        {
                            matrix[i1, j1] = ++number;
                            i1--;
                            j1++;
                        }
                    }
                }

                bool isEven = false;
                if (n % 2 == 0) { isEven = true; }

                for (int line = 1; line < n; line++)
                {
                    if (isEven)
                    {
                        if (line % 2 == 0)
                        {

                            int i1 = n - 1;
                            int j1 = line;
                            for (int i = 0; i < n - line; i++)
                            {
                                matrix[i1, j1] = ++number;
                                i1--;
                                j1++;
                            }
                        }
                        else
                        {
                            int i1 = line;
                            int j1 = n - 1;
                            for (int i = 0; i < n - line; i++)
                            {
                                matrix[i1, j1] = ++number;
                                i1++;
                                j1--;
                            }
                        }
                    }
                    else
                    {
                        if (line % 2 == 0)
                        {

                            int i1 = line;
                            int j1 = n - 1;
                            for (int i = 0; i < n - line; i++)
                            {
                                matrix[i1, j1] = ++number;
                                i1++;
                                j1--;
                            }
                        }
                        else
                        {
                            int i1 = n - 1;
                            int j1 = line;
                            for (int i = 0; i < n - line; i++)
                            {
                                matrix[i1, j1] = ++number;
                                i1--;
                                j1++;
                            }
                        }
                    }
                }
            }
        }
        //vertical avtoriz
        public void VerticalSnakeInitialization()
        {
            int d = 1;
            for (int j = 0; j < Countcol; j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < Countrow; i++)
                    {
                        matrix[i, j] = d;
                        d++;
                    }
                }
                else
                {
                    for (int i = Countrow - 1; i >= 0; i--)
                    {
                        matrix[i, j] = d;
                        d++;
                    }
                }
            }
        }
        public override string ToString()
        {
            string resultString = "";
            for (int i = 0; i < CountRow; i++)
            {
                for (int j = 0; j < CountCol; j++)
                {
                    resultString += matrix[i, j] + "\t";
                }
                resultString += "\n";
            }
            return resultString;
        }

        #endregion
    }
}
