using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NN_PROGLAN.ImageProcessing;
using NN_PROGLAN.Utils;

namespace NN_PROGLAN.Collections
{
    public enum DatasetType { Training, Testing };
    public class Dataset
    {
        public class Data
        {
            public double[] X { get; set; }
            public double Y { get; set; }
            public string File { get; set; }

        }

        private List<Data> trainingDataset;
        private List<Data> testingDataset;

        public Dataset()
        {
            trainingDataset = new List<Data>();
            testingDataset = new List<Data>();
        }
        public List<Data> TrainingDataset
        {
            get
            {
                return trainingDataset;
            }
        }

        public List<Data> TestingDataset
        {
            get
            {
                return testingDataset;
            }
        }

        private void AddTrainingData(double[] vector, double label, string file)
        {
            trainingDataset.Add(new Data() {
                X = vector,
                Y = label,
                File = file
            });
        }

        private void AddTestingData(double[] vector, double label, string file)
        {
            testingDataset.Add(new Data() {
                X = vector,
                Y = label,
                File = file
            });
        }

        public void Add(DatasetType type, double[] x, double y, string file)
        {
            if (type == DatasetType.Training)
                AddTrainingData(x, y, file);
            else
                AddTestingData(x, y, file);

        }
    }
}
