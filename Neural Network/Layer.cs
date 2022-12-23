using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_PROGLAN.Neural_Network
{
    public class Layer
    {
        private int numOfInputs;
        private int numOfOutputs;

        public double[] Inputs { get; set; }
        public double[] Outputs { get; set; }

        public Neuron[] Neurons { get; set; }

        public double[] Gradient { get; set; }
        public double[] Error { get; set; }
        public double RoundedError { get; set; }

        public static Random random = new Random();

        public Layer(int numOfInputs, int numOfOutputs)
        {
            this.numOfInputs = numOfInputs;
            this.numOfOutputs = numOfOutputs;

            Inputs = new double[numOfInputs];
            Outputs = new double[numOfOutputs];
            Neurons = new Neuron[numOfOutputs];

            Gradient = new double[numOfOutputs];
            Error = new double[numOfOutputs];

            InitializeWeights();
        }

        private void InitializeWeights()
        {
            for (int i = 0; i < numOfOutputs; i++)
            {
                Neurons[i] = new Neuron() {
                    Weights = new double[numOfInputs],
                    WeightsDelta = new double[numOfInputs],
                    Bias = (double)random.NextDouble() - 0.5
                };
                for (int j = 0; j < numOfInputs; j++)
                {
                    Neurons[i].Weights[j] = (double)random.NextDouble() - 0.5; 
                }
            }
        }

        public double[] ForwardPropagate(double[] inputs)
        {
            Inputs = (double[])inputs.Clone();

            for (int i = 0; i < numOfOutputs; i++)
            {
                for (int j = 0; j < numOfInputs; j++)
                {
                    Outputs[i] += inputs[j] * Neurons[i].Weights[j];
                }
                //Outputs[i] += Neurons[i].Bias;
                Outputs[i] = Activation.Sigmoid(Outputs[i]);
            }
            return Outputs;
        }

        public void BackPropOutput(double[] expected)
        {
            for (int i = 0; i < numOfOutputs; i++)
            {
                Error[i] = Outputs[i] - expected[i];
                if(Error[i] != 0)
                    RoundedError = Error[i];
            }


            for (int i = 0; i < numOfOutputs; i++)
                Gradient[i] = Error[i] * Activation.SigmoidPrime(Outputs[i]);

            for (int i = 0; i < numOfOutputs; i++)
            {
                for (int j = 0; j < numOfInputs; j++)
                {
                    Neurons[i].WeightsDelta[j] = Gradient[i] * Inputs[j];
                }
            }
        }

        public void BackPropHiddenLayer(double[] gammaForward, Neuron[] neurons)
        {
            for (int i = 0; i < numOfOutputs; i++)
            {
                for (int j = 0; j < gammaForward.Length; j++)
                {
                    Gradient[i] += gammaForward[j] * neurons[j].Weights[i];
                }

                Gradient[i] *= Activation.SigmoidPrime(Outputs[i]);
            }

            for (int i = 0; i < numOfOutputs; i++)
            {
                for (int j = 0; j < numOfInputs; j++)
                {
                    Neurons[i].WeightsDelta[j] = Gradient[i] * Inputs[j];
                }
            }

        }

        public void UpdateWeights(double learningRate)
        {
            for (int i = 0; i < numOfOutputs; i++)
            {
                for (int j = 0; j < numOfInputs; j++)
                {
                    Neurons[i].Weights[j] -= Neurons[i].WeightsDelta[j] * learningRate; 
                }
            }
        }

    }

}
