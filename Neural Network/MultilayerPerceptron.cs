using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NN_PROGLAN.Utils;
using static NN_PROGLAN.Collections.Dataset;
using static NN_PROGLAN.Utils.MLOperations;

namespace NN_PROGLAN.Neural_Network
{
    public class MultilayerPerceptron
    {
        public double LearningRate { get; set; }
        public int Epochs { get; set; }
        public int Iterations { get; set; }
        public int[] Structure { get; set; }
        public Layer[] Layers { get; set; }
        public Layer OutputLayer { get { return Layers[^1]; } }

        public MultilayerPerceptron() { }

        public MultilayerPerceptron(int[] structure)
        {
            Structure = new int[structure.Length];
            Array.Copy(structure, Structure, structure.Length);

            Layers = new Layer[structure.Length-1];

            for (int i = 0; i < Layers.Length; i++)
                Layers[i] = new Layer(structure[i], structure[i+1]);
        }

        public void Build()
        {
            Layers = new Layer[Structure.Length - 1];

            for (int i = 0; i < Layers.Length; i++)
                Layers[i] = new Layer(Structure[i], Structure[i + 1]);
        }

        // 𝘍𝘰𝘳𝘸𝘢𝘳𝘥 𝘗𝘳𝘰𝘱𝘢𝘨𝘢𝘵𝘪𝘰𝘯
        public double[] ForwardPropagate(double[] inputs)
        {
            
            Layers[0].ForwardPropagate(inputs);

            for (int i = 1; i < Layers.Length; i++)
                Layers[i].ForwardPropagate(Layers[i - 1].Outputs);

            // 𝘓𝘢𝘺𝘦𝘳𝘴[^1] 𝘪𝘴 𝘴𝘩𝘰𝘳𝘵𝘩𝘢𝘯𝘥 𝘧𝘰𝘳 𝘓𝘢𝘺𝘦𝘳𝘴[𝘓𝘢𝘺𝘦𝘳𝘴.𝘓𝘦𝘯𝘨𝘵𝘩-1]
            return Layers[^1].Outputs;
        }

        // 𝘉𝘢𝘤𝘬𝘱𝘳𝘰𝘱𝘢𝘨𝘢𝘵𝘪𝘰𝘯
        public void BackPropagate(double[] expected)
        {
            Layers[^1].BackPropOutput(expected);

            for (int i = Layers.Length-2; i >= 0; i--)
                Layers[i].BackPropHiddenLayer(Layers[i+1].Gradient, Layers[i+1].Neurons);
        }

        // 𝘜𝘱𝘥𝘢𝘵𝘦𝘴 𝘵𝘩𝘦 𝘞𝘦𝘪𝘨𝘩𝘵𝘴 𝘢𝘯𝘥 𝘉𝘪𝘢𝘴𝘦𝘴 𝘰𝘧 𝘢𝘭𝘭 𝘓𝘢𝘺𝘦𝘳𝘴
        public void UpdateWeightsAndBiases()
        {
            for (int i = Layers.Length - 1; i > 0; i--)
                Layers[i].UpdateWeightsAndBiases(LearningRate);
        }
            
        public int Predict(double[] x)
        {
            ForwardPropagate(x);
            return Convert.ToInt32(ArgMax(OutputLayer.Outputs));
        }
    }
}
