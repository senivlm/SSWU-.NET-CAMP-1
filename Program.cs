using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Program
    {
        public static void WorkWithVectorClass()
        {

            int[] arr = new int[] { 4, 4, 4, 4, 4, 8, 8, 2, 2, 2, 2, 2 };
            Vector vector = new Vector(arr);
            Console.WriteLine(vector.IsPalindrome());

            Pair pair = vector.LongestSubseqSameNum();
            Console.WriteLine(pair);
        }

        public static void WorkWithMatrixClass()
        {
            var matr = new Matrix();
            matr.DiagonalSnakeAutorization(3, Way.Right);
            Console.WriteLine(matr);
            Console.WriteLine();

            var matr1 = new Matrix();
            matr1.DiagonalSnakeAutorization(4, Way.Down);
            Console.WriteLine(matr1);
        }

        static void Main(string[] args)
        {
            WorkWithMatrixClass();
        }
    }
}
