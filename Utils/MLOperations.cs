using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_PROGLAN.Utils
{
    public static class MLOperations
    {
        public static double[] OneHotEncode(double label, int classCount)
        {
            double[] output = new double[classCount];
            for (int i = 0; i < classCount; i++)
                if (Convert.ToDouble(i) == label)
                {
                    output[i] = 1d;
                    break;
                }
            return output;
        }

        public static double CalculateAccuracy(double[] predictions, double[] expected)
        {
            double sum = 0;
            for (int i = 0; i < predictions.Length; i++)
                if (predictions[i] == expected[i]) sum++;

            return sum / (double)expected.Length * 100;
        }

        public static double ArgMax(double[] Y)
        {
            return Y.ToList().IndexOf(Y.Max());
        }
    }
}
