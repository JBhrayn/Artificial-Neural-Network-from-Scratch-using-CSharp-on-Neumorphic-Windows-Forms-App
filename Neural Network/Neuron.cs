using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NN_PROGLAN.Neural_Network
{
    public class Neuron
    {
        public double[] Weights { get; set; }
        public double[] WeightsDelta { get; set; }
        public double Bias { get; set; }
        public double Output { get; set; }

        public Neuron()
        {
            
        }

        public Neuron(double[] weights, double bias)
        {
            Array.Copy(weights, this.Weights, weights.Length);
            //this.Bias = bias;
        }

    }
}
