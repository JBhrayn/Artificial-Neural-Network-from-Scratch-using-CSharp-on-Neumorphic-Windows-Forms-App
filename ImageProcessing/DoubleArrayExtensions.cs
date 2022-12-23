using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_PROGLAN.ImageProcessing
{
    public static class DoubleArrayExtensions
    {
        public static string MatrixToString(this double[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            matrix.ForEach(element => sb.Append(element), () => sb.AppendLine());
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

        public static double[] Flatten(this double[,] matrix)
        {
            List<double> flattenMatrix = new List<double>();
            matrix.ForEach(element => flattenMatrix.Add(element));
            return flattenMatrix.ToArray();
        }

        public static void ForEach(this double[,] matrix, Action<double> onElementAction, Action onNewRowAction = null)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                for (int x = 0; x < matrix.GetLength(0); x++)
                {
                    onElementAction(matrix[x, y]);
                }
                onNewRowAction?.Invoke();
            }
        }
    }
}
