using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_PROGLAN.Neural_Network
{
    public class Activation
    {
        public static double ReLu(double x)
        {
            return Math.Max(x, 0);
        }

        public static double ReLuPrime(double x)
        {
            return (x > 0) ? 1 : 0;
        }

        public static double Sigmoid(double x)
        {
            return (double)(1 / (1 + Math.Pow(Math.E, -x)));
        }

        public static double SigmoidPrime(double x)
        {
            return Sigmoid(x) * (1 - Sigmoid(x));
        }

        public static double[] SoftMax(double[] predictions)
        {
            double[] softMaxed = new double[predictions.Length];

            for (int i = 0; i < predictions.Length; i++)
                softMaxed[i] = Math.Pow(Math.E, predictions[i]);

            double sum = softMaxed.Sum();

            for (int i = 0; i < softMaxed.Length; i++)
                softMaxed[i] = softMaxed[i] / sum;

            return softMaxed;
        }
    }
}
