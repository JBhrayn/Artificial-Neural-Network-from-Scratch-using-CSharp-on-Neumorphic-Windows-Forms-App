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

    }
}
