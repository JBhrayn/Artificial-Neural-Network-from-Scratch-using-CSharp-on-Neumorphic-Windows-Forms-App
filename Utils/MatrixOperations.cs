using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_PROGLAN.Utils
{
    public static class MatrixOperations
    {
        private static Random rng = new Random();

        public static double[,] Transpose(double[,] A)
        {
            double[,] B = new double[A.GetLength(1), A.GetLength(0)];
            for (int i = 0; i < A.GetLength(1); i++)
                for (int j = 0; j < A.GetLength(0); j++)
                    B[i, j] = A[j, i];

            return B;
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

    }
}
