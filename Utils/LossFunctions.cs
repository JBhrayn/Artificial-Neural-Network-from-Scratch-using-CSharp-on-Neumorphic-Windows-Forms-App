using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_PROGLAN.Utils
{
    public static class LossFunctions
    {
        public static double CategoricalEntropy(double[] softMaxedPred)
        {
            return -Math.Log(softMaxedPred.Max());
        }
    }
}
