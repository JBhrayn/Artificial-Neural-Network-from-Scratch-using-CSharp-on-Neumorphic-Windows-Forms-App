
using System.Diagnostics;
using NN_PROGLAN.Utils;
using System.IO;
using System.Drawing;
using NN_PROGLAN.ImageProcessing;
using System.Runtime.InteropServices;
using NN_PROGLAN.Interface.Neu;
using System.Drawing.Imaging;
using NN_PROGLAN.Neural_Network;
using NN_PROGLAN.Collections;
using static NN_PROGLAN.Collections.Dataset;
using System.ComponentModel;
using static NN_PROGLAN.Utils.FileOperations;
using static NN_PROGLAN.Utils.MLOperations;
using static System.Environment;
using static System.Drawing.Region;
using NN_PROGLAN.Interface;
using System.Text;

namespace NN_PROGLAN
{
    public partial class MainForm : Form
    {
        //
        // WINDOW DRAG
        //
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
        //
        // WINDOW ROUND EDGES
        //
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,  
            int nTopRect,     
            int nRightRect,   
            int nBottomRect, 
            int nWidthEllipse,
            int nHeightEllipse 
        );
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      
                return handleParam;
            }

        }
        
        //
        // INPUT CLASS
        //
        public double InputClass
        {
            get
            {
                return Convert.ToDouble(inputClassTextBox.Text);
            }
        }
        //
        // HYPERPARAMETERS
        //
        public int Epochs
        {
            get
            {
                return Int32.Parse(epochsTextBox.Text);
            }
        }
        public int Iterations
        {
            get
            {
                return Int32.Parse(iterationsTextBox.Text);
            }
        }
        public double LearningRate
        {
            get
            {
                return Double.Parse(learningRateTextBox.Text);
            }
        }
        //
        // NETWORK LAYERS
        //
        public int InputLayerNodes 
        { 
            get 
            { 
                return Int32.Parse(inputLayerTextBox.Text); 
            } 
        }
        public int OutputLayerNodes 
        { 
            get 
            { 
                return Int32.Parse(outputLayerTextBox.Text); 
            } 
        }
        public int[] HiddenLayersNodes
        {
            get
            {
                return Array.ConvertAll(hiddenLayerTextBox.Text.Split(','), s => int.Parse(s));
            }
        }
        //
        // DATASET FOLDER PATH
        //
        public string TestingDatasetPath
        {
            get
            {
                return testingDatasetFullPathLabel.Text;
            }
        }
        public string TrainingDatasetPath
        {
            get
            {
                return trainingDatasetFullPathLabel.Text;
            }
        }

        private int classCount;
        private Dataset dataset;
        private Action asyncAction;
        private ButtonGroup radioButtons;
        private Action asyncActionCompleted;
        private Size pictureSize = new(28, 28);
        private MultilayerPerceptron neuralNetwork;

        private List<string> files;
        private List<double[]> predictions;
        private readonly string desktopPath = GetFolderPath(SpecialFolder.Desktop);

#pragma warning disable CS8618
        public MainForm()
#pragma warning restore CS8618
        {
            InitializeComponent();
            InitializeCustomControls();
            SetStyle(ControlStyles.DoubleBuffer, true);
            Region = FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

            dataset = new Dataset();

            MouseDown += (s, e) => {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
        }

        private void InitializeCustomControls()
        {
            //
            // DATASET MENU PANEL
            //
            datasetMenuPanel.PanelLabel = datasetMenuPanelLabel;
            datasetMenuPanel.SetHandlers();
            
            testingDataRadioButton.Type = ButtonType.Radio;
            trainingDataRadioButton.Type = ButtonType.Radio;
            testingDataRadioButton.ExternalLabel = testingDatasetLabel;
            trainingDataRadioButton.ExternalLabel = trainingDatasetLabel;
            trainingDataRadioButton.Toggled = true;

            radioButtons = new ButtonGroup();
            radioButtons.Add(testingDataRadioButton);
            radioButtons.Add(trainingDataRadioButton);

            importDatasetButton.Text = "IMPORT";
            importDatasetButton.Type = ButtonType.Rectangle;
            importDatasetButton.OnMouseClick((s,e) => ImportDataset());

            addDatasetButton.Text = "+";
            addDatasetButton.Type = ButtonType.Square;
            addDatasetButton.Font = new Font("Bahnschrift", 15F);
            addDatasetButton.OnMouseClick((s, e) => ShowDialogBox("New"));
            //
            // NETWORK MENU PANEL
            //
            networkMenuPanel.PanelLabel = networkMenuPanelLabel;
            networkMenuPanel.SetHandlers();

            inputLayerTextBox.ExternalLabel = inputLayerLabel;
            hiddenLayerTextBox.ExternalLabel = hiddenLayerLabel;
            outputLayerTextBox.ExternalLabel = outputLayerLabel;
            //
            // HYPERPARAMETERS MENU PANEL
            //
            hParametersMenuPanel.PanelLabel = hParametersMenuPanelLabel;
            hParametersMenuPanel.SetHandlers();

            learningRateTextBox.ExternalLabel = learningRateLabel;
            iterationsTextBox.ExternalLabel = iterationsLabel;
            epochsTextBox.ExternalLabel = epochsLabel;
            //
            // CREATE NETWORK BUTTON
            //
            createNetworkBtn.Text = "BUILD";
            createNetworkBtn.Type = ButtonType.Rectangle;
            createNetworkBtn.Font = new Font("Bahnschrift", 12F);
            createNetworkBtn.OnMouseClick((s, e) => BuildNeuralNet());
            //
            // TRAIN NETWORK BUTTON
            //
            trainButton.Text = "TRAIN";
            trainButton.Type = ButtonType.Rectangle;
            trainButton.OnMouseClick((s, e) => TrainNeuralNet());
            //
            // TEST NETWORK BUTTON
            //
            testButton.Text = "TEST";
            testButton.Type = ButtonType.Rectangle;
            testButton.Enabled = false;
            testButton.OnMouseClick((s,e) => TestNeuralNet());
            //
            // LOAD MODEL BUTTON
            //
            loadModelButton.Type = ButtonType.Square;
            loadModelButton.SetIcons(
                defaultIcon: Properties.Resources.ImportIconDefault,
                hoveredIcon: Properties.Resources.ImportIconHovered,
                clickedIcon: Properties.Resources.ImportIconClicked);
            loadModelButton.OnMouseClick(
                (s, e) => OpenDialogBox("Load Model", messageTray));
            //
            // SAVE MODEL BUTTON
            //
            saveModelButton.Type = ButtonType.Square;
            saveModelButton.SetIcons(
                defaultIcon: Properties.Resources.SaveIconDefault,
                hoveredIcon: Properties.Resources.SaveIconHovered,
                clickedIcon: Properties.Resources.SaveIconClicked);
            saveModelButton.OnMouseClick(
                (s, e) => OpenDialogBox("Save Model", messageTray));
            //
            // PEN WIDTH TRACKBAR
            //
            penWidthTrackbar.ValueChanged += 
                (s, e) => inputCanvas.Pen.Width = penWidthTrackbar.Value;
            //
            // MATRIX BUTTON
            //
            matrixButton.Type = ButtonType.Picture;
            matrixButton.SetIcons(
                defaultIcon: Properties.Resources.matrixIconDefault,
                hoveredIcon: Properties.Resources.matrixIconHovered,
                clickedIcon: Properties.Resources.matrixIconClicked);
            matrixButton.OnMouseClick(
                (s, e) => Process.Start("notepad.exe", $@"{desktopPath}\binaryMatrix.txt"));
            //
            // INPUT CLASS LABEL
            //
            inputClassTextBox.ExternalLabel = inputClassLbl;
            //
            // ADD CANVAS INPUT BUTTON
            //
            addInputButton.Text = "ADD";
            addInputButton.Type = ButtonType.Rectangle;
            addInputButton.OnMouseClick((s, e) => SaveInputAsImage(inputClassLbl.Text));
            //
            // PREDICT CANVAS INPUT BUTTON
            //
            predictInputButton.Text = "PREDICT";
            predictInputButton.Type = ButtonType.Rectangle;
            predictInputButton.Enabled = false;
            predictInputButton.OnMouseClick((s, e) => PredictCanvasInput());
            //
            // OUTPUT CLASS LABEL
            //
            outputClassLabel.Text = "";
            //
            // BACKGROUND WORKER X PROGRESS BAR
            //
            progressBarBackgroundWorker.DoWork += 
                (s, e) => asyncAction();
            progressBarBackgroundWorker.ProgressChanged += 
                (s, e) => circularBar.Value = e.ProgressPercentage;
            progressBarBackgroundWorker.RunWorkerCompleted += 
                (s, e) => asyncActionCompleted();
            //
            // CLOSE BUTTON
            //
            closeButton.Type = ButtonType.Circle;
            closeButton.SetIcons(
                defaultIcon: Properties.Resources.CloseIconDefault,
                hoveredIcon: Properties.Resources.CloseIconHovered,
                clickedIcon: Properties.Resources.CloseIconHovered);
            closeButton.OnMouseClick((s, e) => Application.Exit());
        }
        //
        // DIALOG BOX
        //
        private void OpenDialogBox(string header, Label? shortPath = null)
        {
            NeuDialogBox dialog = new(header, selectedFilePath);
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ShowDialog(this);

            if (selectedFilePath.Text.Trim().Equals("")) return;

            messageTray.Text = selectedFilePath.Text.Trim();

            string[] paths = messageTray.Text.Split('\\');
            if (paths.Length > 1 && !paths[1].Equals(""))
                (shortPath ?? new Label()).Text = $@"{paths[0]}\...\{paths[^1]}";
            else
                (shortPath ?? new Label()).Text = $@"{paths[0]}\";
        }
        private void ShowDialogBox(string message)
        {
            if (trainingDataRadioButton.Toggled)
                OpenDialogBox($"{message} Training Dataset Folder", trainingDatasetLabel);
            else
                OpenDialogBox($"{message} Testing Dataset Folder", testingDatasetLabel);
        }
        //
        // ANCILLARY FUNCTION
        //
        private void UpdateSomeLabels()
        {
            trainingDataCountLabel.Text = dataset.TrainingDataset.Count.ToString();
            testingDataCountLabel.Text = dataset.TestingDataset.Count.ToString();

            outputLayerTextBox.Text = classCount + "";
            circularBar.Value = 0;
            classCount = GetFoldersCount(selectedFilePath.Text);
            iterationsTextBox.Text = trainingDataCountLabel.Text;
        }
        private DatasetType GetSelectedDatasetType()
        {
            if (trainingDataRadioButton.Toggled)
                return DatasetType.Training;
            else
                return DatasetType.Testing;
        }
        //
        // EXPORT SAMPLE FUNCTIONS
        //
        private void ValidateFolder(NeuButton rButton)
        {
            if (rButton.ExternalLabel.Text.Equals("Select Folder..."))
            {
                MessageBox.Show("You must specify a folder first.", "No Folder Selected");
                ShowDialogBox("Select");
            }
        }
        private void SaveInputAsImage(string classLabel)
        {
            string newDir;
            if (trainingDataRadioButton.Toggled)
            {
                ValidateFolder(trainingDataRadioButton);
                newDir = $@"{TrainingDatasetPath}\{classLabel}";
            }
            else
            {
                ValidateFolder(testingDataRadioButton);
                newDir = $@"{TestingDatasetPath}\{classLabel}";
            }

            Directory.CreateDirectory(newDir);

            double[,] bmpMatrix =
                new Bitmap(inputCanvas.Bitmap, pictureSize)
                .CreateMatrix(0.5f);

            dataset.Add(
                GetSelectedDatasetType(),
                bmpMatrix.Flatten(),
                InputClass,
                CreateFile(newDir));

            WriteToNotepad(
                $@"{desktopPath}\binaryMatrix.txt",
                bmpMatrix.MatrixToString());

        }
        //
        // IMPORT SAMPLES FUNCTIONS
        //
        private void AddAllDataset()
        {
            int counter = 0;
            files.ForEach(file => {
                dataset.Add(
                    GetSelectedDatasetType(),
                    GetVector(file),
                    GetLabel(file),
                    file);
                progressBarBackgroundWorker.ReportProgress(counter++);
            });
        }
        private void ImportDataset()
        {
            ShowDialogBox("Select");
            if (selectedFilePath.Text.Equals("")) return;

            files = GetFiles(
                selectedFilePath.Text,
                new string[] { "png", "jpg" },
                true);

            pictureSize = new Bitmap(files[0]).Size;
            inputLayerTextBox.Text = (pictureSize.Width * pictureSize.Height) + "";
            asyncAction = AddAllDataset;
            asyncActionCompleted = UpdateSomeLabels;

            RunCircularBar(files.Count); // BEGIN ASYNC
        }
        //
        // NEURAL NETWORK FUNCTIONS
        //
        private void PrintNeuralNetInfo(List<int> structure) // OPTIONAL
        {
            trainingTextBox.AppendText(
                    $"Layers = {string.Join(", ", structure.ToArray())}\r\n");
            trainingTextBox.AppendText(
                $"Learning Rate: {LearningRate}\r\n" +
                $"Epochs: {Epochs}\r\n");
        }
        private void BuildNeuralNet()
        {
            List<int> structure = new();
            structure.Add(pictureSize.Width * pictureSize.Height);  // INPUT LAYER
            structure.AddRange(HiddenLayersNodes);                  // HIDDEN LAYER
            structure.Add(classCount);                              // OUTPUT LAYER

            neuralNetwork = new MultilayerPerceptron() 
            {
                Epochs = Epochs,
                Iterations = Iterations,
                LearningRate = LearningRate,
                Structure = structure.ToArray()
            };

            neuralNetwork.Build();

            //PrintNeuralNetInfo(structure);
            messageTray.Text = "network built";
        }
        //
        // ASYNC PROGRESS BAR
        //
        private void RunCircularBar(long maximum)
        {
            circularBar.Value = 0;
            circularBar.Maximum = maximum;
            progressBarBackgroundWorker.RunWorkerAsync(circularBar);
        }
        //
        // Enables the testing controls after training
        //
        private void EnableTesting()
        {
            circularBar.Value = 0;
            accuracyLabel.Text = "";
            outputClassLabel.Text = "";
            epochsCountLabel.Text = "";
            testButton.Enabled = true;
            predictInputButton.Enabled = true;
            inputCanvas.Image = inputCanvas.Bitmap;
            messageTray.Text = "Training Finished.";
        }
        //
        // TRAINING MODE
        //
        private string ToFomattedString(int epoch, double loss, double accuracy)
        {
            string text = $"Epoch\t\t: {epoch} \r\n" +
                          $"Loss\t\t: {loss}\r\n" +
                          $"Accuracy\t\t: {accuracy:N2}%" + 
                          LineSeparator();
            return text;
        }
        private void TrainAsync()
        {
            int currentEpoch = 0;
            predictions = new();

            dataset.TrainingDataset.Shuffle();
            double loss;
            circularBar.Maximum = dataset.TrainingDataset.Count;
            while (currentEpoch < neuralNetwork.Epochs)
            {
                loss = 0;
                int counter = 0;
                dataset.TrainingDataset.Shuffle();
                foreach (Data d in dataset.TrainingDataset.ToList())
                {
                    neuralNetwork.ForwardPropagate(d.X);
                    neuralNetwork.BackPropagate(OneHotEncode(d.Y, classCount));
                    neuralNetwork.UpdateWeights();
                    double[] predY = (double[])neuralNetwork.OutputLayer.Outputs.Clone();

                    if (ArgMax(predY) == d.Y)
                        ThreadHelperClass.SetForeColor(this, outputClassLabel, Color.FromArgb(0, 255, 0));
                    else
                        ThreadHelperClass.SetForeColor(this, outputClassLabel, Color.FromArgb(255, 0, 0));

                    ThreadHelperClass.SetImage(this, inputCanvas, new Bitmap(new Bitmap(d.File), new Size(150, 150)));
                    ThreadHelperClass.SetText(this, outputClassLabel, Convert.ToInt32(ArgMax(predY)).ToString());

                    predictions.Add(predY);

                    loss += neuralNetwork.OutputLayer.RoundedError;
                    progressBarBackgroundWorker.ReportProgress(++counter);
                }
                currentEpoch++;

                double epochLoss = loss / dataset.TrainingDataset.Count;
                double accuracy = CalculateAccuracy(
                    predictions.Select(r => ArgMax(r)).ToArray(),
                    dataset.TrainingDataset.Select(d => d.Y).ToArray());

                string currentEpochResult = ToFomattedString(currentEpoch, epochLoss, accuracy);

                ThreadHelperClass.SetText(this, epochsCountLabel, currentEpoch.ToString());
                ThreadHelperClass.AppendText(this, trainingTextBox, currentEpochResult);

                

                ThreadHelperClass.SetText(this, accuracyLabel, $"{accuracy:N2}%");
                predictions.Clear();
            }
        }
        private void TrainNeuralNet()
        {

            messageTray.Text = "Training...";
            if (neuralNetwork == null)
                MessageBox.Show("You must build the model first.", "Model not built");
            accuracyHeaderLabel.Text = "Training Accuracy";
            asyncAction = TrainAsync;
            asyncActionCompleted = EnableTesting;

            progressBarBackgroundWorker.RunWorkerAsync(circularBar);

        }
        private void PredictCanvasInput()
        {
            outputClassLabel.Text =
                neuralNetwork.Predict(
                    new Bitmap(inputCanvas.Bitmap, pictureSize)
                    .CreateMatrix(0.5f)
                    .Flatten())
                .ToString();
        }
        //
        // TESTING MODE
        //
        private void TestAccuracy()
        {
            double accuracy = CalculateAccuracy(
                predictions.Select(r => ArgMax(r)).ToArray(),
                dataset.TestingDataset.Select(d => d.Y).ToArray());
            accuracyHeaderLabel.Text = "Testing Accuracy";
            accuracyLabel.Text = $"{accuracy:N2}%";

            double[] accuracyPerClass = CalculateAccuracyPerClass(
                predictions.Select(r => ArgMax(r)).ToArray(),
                dataset.TestingDataset.Select(d => d.Y).ToArray(), classCount);

            StringBuilder sb = new StringBuilder("ACCURACY PER CLASS:");
            for (int i = 0; i < accuracyPerClass.Length; i++)
                sb.AppendFormat($"\r\nClass {i} = {accuracyPerClass[i]:N2} %");

            sb.AppendFormat($"{LineSeparator()}Overall Accuracy = {accuracy:N2}%");

            ThreadHelperClass.AppendText(this, testingTextBox, sb.ToString());

            // reset these controls
            accuracyLabel.Text = "";
            outputClassLabel.Text = "";
            epochsCountLabel.Text = "";
            circularBar.Value = 0;
            inputCanvas.Image = inputCanvas.Bitmap;
            messageTray.Text = "Testing Finished.";
        }
        private void TestAsync()
        {
            int counter = 0;
            foreach (Data d in dataset.TestingDataset)
            {
                neuralNetwork.ForwardPropagate(d.X);
                ThreadHelperClass.SetImage(this, inputCanvas, new Bitmap(new Bitmap(d.File), new Size(150, 150)));
                double[] predY = (double[])neuralNetwork.OutputLayer.Outputs.Clone();

                if (ArgMax(predY) == d.Y)
                    ThreadHelperClass.SetForeColor(this, outputClassLabel, Color.FromArgb(0, 255, 0));
                else
                    ThreadHelperClass.SetForeColor(this, outputClassLabel, Color.FromArgb(255, 0, 0));

                ThreadHelperClass.SetText(this, outputClassLabel, Convert.ToInt32(ArgMax(predY)).ToString());
                predictions.Add(predY);
                progressBarBackgroundWorker.ReportProgress(++counter);
            }
        }
        private void TestNeuralNet()
        {
            messageTray.Text = "Testing...";
            epochsCountLabel.Text = "0";
            asyncAction = TestAsync;
            asyncActionCompleted = TestAccuracy;

            RunCircularBar(dataset.TestingDataset.Count);
            inputCanvas.Image = inputCanvas.Bitmap;
        }

        private string LineSeparator()
        {
            return "\r\n================================================\r\n";
        }   
    }
}