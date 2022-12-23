using NN_PROGLAN.Interface.Neu;
using NN_PROGLAN.Interface.ProgressBar;

namespace NN_PROGLAN
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.subPanel = new System.Windows.Forms.Panel();
            this.testingTextBox = new System.Windows.Forms.TextBox();
            this.matrixButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.circularBar = new NN_PROGLAN.Interface.ProgressBar.CircularProgressBar();
            this.trainingTextBox = new System.Windows.Forms.TextBox();
            this.penWidthLabel = new System.Windows.Forms.Label();
            this.penWidthTrackbar = new NN_PROGLAN.Interface.Neu.NeuTrackBar();
            this.accuracyLabel = new System.Windows.Forms.Label();
            this.epochsCountLabel = new System.Windows.Forms.Label();
            this.recognitionRateLabel = new System.Windows.Forms.Label();
            this.errorRateLabel = new System.Windows.Forms.Label();
            this.inputPicLabel = new System.Windows.Forms.Label();
            this.inputClassLbl = new System.Windows.Forms.Label();
            this.inputClassTextBox = new NN_PROGLAN.Interface.Neu.NeuTextBox();
            this.inputCanvas = new NN_PROGLAN.Interface.Canvas();
            this.inputCanvasFrame = new System.Windows.Forms.PictureBox();
            this.accuracyHeaderLabel = new System.Windows.Forms.Label();
            this.epochsHeaderLabel = new System.Windows.Forms.Label();
            this.predictInputButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.outputPicLabel = new System.Windows.Forms.Label();
            this.addInputButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.outputCanvasFrame = new NN_PROGLAN.Interface.Neu.NeuPanel();
            this.outputClassLabel = new System.Windows.Forms.Label();
            this.createNetworkBtn = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.neuPanel1 = new NN_PROGLAN.Interface.Neu.NeuPanel();
            this.testButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.trainButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.modeMenuPanelLbl = new System.Windows.Forms.Label();
            this.loadModelButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.saveModelButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.closeButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.hParametersMenuPanel = new NN_PROGLAN.Interface.Neu.NeuPanel();
            this.epochsTextBox = new NN_PROGLAN.Interface.Neu.NeuTextBox();
            this.iterationsTextBox = new NN_PROGLAN.Interface.Neu.NeuTextBox();
            this.learningRateTextBox = new NN_PROGLAN.Interface.Neu.NeuTextBox();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.epochsLabel = new System.Windows.Forms.Label();
            this.learningRateLabel = new System.Windows.Forms.Label();
            this.hParametersMenuPanelLabel = new System.Windows.Forms.Label();
            this.networkMenuPanel = new NN_PROGLAN.Interface.Neu.NeuPanel();
            this.outputLayerTextBox = new NN_PROGLAN.Interface.Neu.NeuTextBox();
            this.hiddenLayerTextBox = new NN_PROGLAN.Interface.Neu.NeuTextBox();
            this.inputLayerTextBox = new NN_PROGLAN.Interface.Neu.NeuTextBox();
            this.numOfNodesLabel = new System.Windows.Forms.Label();
            this.networkMenuPanelLabel = new System.Windows.Forms.Label();
            this.outputLayerLabel = new System.Windows.Forms.Label();
            this.inputLayerLabel = new System.Windows.Forms.Label();
            this.hiddenLayerLabel = new System.Windows.Forms.Label();
            this.layerLabel = new System.Windows.Forms.Label();
            this.datasetMenuPanel = new NN_PROGLAN.Interface.Neu.NeuPanel();
            this.testingDataRadioButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.testingDataCountLabel = new System.Windows.Forms.Label();
            this.testingDatasetLabel = new System.Windows.Forms.Label();
            this.trainingDataRadioButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.trainingDataCountLabel = new System.Windows.Forms.Label();
            this.trainingDatasetLabel = new System.Windows.Forms.Label();
            this.addDatasetButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.orLabel = new System.Windows.Forms.Label();
            this.testingLabelLine = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trainingLabel = new System.Windows.Forms.Label();
            this.importDatasetButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.trainingLabelLine = new System.Windows.Forms.Label();
            this.datasetMenuPanelLabel = new System.Windows.Forms.Label();
            this.selectedFilePath = new System.Windows.Forms.Label();
            this.testingDatasetFullPathLabel = new System.Windows.Forms.Label();
            this.trainingDatasetFullPathLabel = new System.Windows.Forms.Label();
            this.messageTray = new System.Windows.Forms.Label();
            this.progressBarBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.subPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penWidthTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCanvasFrame)).BeginInit();
            this.outputCanvasFrame.SuspendLayout();
            this.neuPanel1.SuspendLayout();
            this.hParametersMenuPanel.SuspendLayout();
            this.networkMenuPanel.SuspendLayout();
            this.datasetMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(38, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(160, 39);
            this.title.TabIndex = 0;
            this.title.Text = "ANN-MLP";
            // 
            // subPanel
            // 
            this.subPanel.BackgroundImage = global::NN_PROGLAN.Properties.Resources.Subpanel;
            this.subPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subPanel.Controls.Add(this.testingTextBox);
            this.subPanel.Controls.Add(this.matrixButton);
            this.subPanel.Controls.Add(this.circularBar);
            this.subPanel.Controls.Add(this.trainingTextBox);
            this.subPanel.Controls.Add(this.penWidthLabel);
            this.subPanel.Controls.Add(this.penWidthTrackbar);
            this.subPanel.Controls.Add(this.accuracyLabel);
            this.subPanel.Controls.Add(this.epochsCountLabel);
            this.subPanel.Controls.Add(this.recognitionRateLabel);
            this.subPanel.Controls.Add(this.errorRateLabel);
            this.subPanel.Controls.Add(this.inputPicLabel);
            this.subPanel.Controls.Add(this.inputClassLbl);
            this.subPanel.Controls.Add(this.inputClassTextBox);
            this.subPanel.Controls.Add(this.inputCanvas);
            this.subPanel.Controls.Add(this.inputCanvasFrame);
            this.subPanel.Controls.Add(this.accuracyHeaderLabel);
            this.subPanel.Controls.Add(this.epochsHeaderLabel);
            this.subPanel.Controls.Add(this.predictInputButton);
            this.subPanel.Controls.Add(this.outputPicLabel);
            this.subPanel.Controls.Add(this.addInputButton);
            this.subPanel.Controls.Add(this.outputCanvasFrame);
            this.subPanel.Location = new System.Drawing.Point(221, 80);
            this.subPanel.Name = "subPanel";
            this.subPanel.Size = new System.Drawing.Size(859, 857);
            this.subPanel.TabIndex = 1;
            // 
            // testingTextBox
            // 
            this.testingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.testingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testingTextBox.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testingTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.testingTextBox.Location = new System.Drawing.Point(461, 551);
            this.testingTextBox.Multiline = true;
            this.testingTextBox.Name = "testingTextBox";
            this.testingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.testingTextBox.Size = new System.Drawing.Size(363, 260);
            this.testingTextBox.TabIndex = 62;
            this.testingTextBox.WordWrap = false;
            // 
            // matrixButton
            // 
            this.matrixButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.None;
            this.matrixButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.matrixButton.ExternalLabel = null;
            this.matrixButton.Location = new System.Drawing.Point(355, 150);
            this.matrixButton.Name = "matrixButton";
            this.matrixButton.Size = new System.Drawing.Size(31, 31);
            this.matrixButton.TabIndex = 61;
            this.matrixButton.Toggled = false;
            // 
            // circularBar
            // 
            this.circularBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.circularBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.circularBar.BarColor1 = System.Drawing.Color.White;
            this.circularBar.BarColor2 = System.Drawing.Color.White;
            this.circularBar.BarWidth = 15F;
            this.circularBar.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circularBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.circularBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.circularBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.circularBar.LineWidth = 15;
            this.circularBar.Location = new System.Drawing.Point(349, 350);
            this.circularBar.Maximum = ((long)(100));
            this.circularBar.MinimumSize = new System.Drawing.Size(100, 100);
            this.circularBar.Name = "circularBar";
            this.circularBar.ProgressShape = NN_PROGLAN.Interface.ProgressBar.CircularProgressBar._ProgressShape.Round;
            this.circularBar.Size = new System.Drawing.Size(162, 162);
            this.circularBar.TabIndex = 60;
            this.circularBar.Text = "0%";
            this.circularBar.TextMode = NN_PROGLAN.Interface.ProgressBar.CircularProgressBar._TextMode.Percentage;
            this.circularBar.Value = ((long)(0));
            // 
            // trainingTextBox
            // 
            this.trainingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.trainingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trainingTextBox.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainingTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.trainingTextBox.Location = new System.Drawing.Point(35, 551);
            this.trainingTextBox.Multiline = true;
            this.trainingTextBox.Name = "trainingTextBox";
            this.trainingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.trainingTextBox.Size = new System.Drawing.Size(363, 260);
            this.trainingTextBox.TabIndex = 59;
            this.trainingTextBox.WordWrap = false;
            // 
            // penWidthLabel
            // 
            this.penWidthLabel.AutoSize = true;
            this.penWidthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.penWidthLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.penWidthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.penWidthLabel.Location = new System.Drawing.Point(35, 234);
            this.penWidthLabel.Name = "penWidthLabel";
            this.penWidthLabel.Size = new System.Drawing.Size(63, 16);
            this.penWidthLabel.TabIndex = 56;
            this.penWidthLabel.Text = "Pen Width";
            // 
            // penWidthTrackbar
            // 
            this.penWidthTrackbar.Location = new System.Drawing.Point(37, 83);
            this.penWidthTrackbar.Maximum = 15;
            this.penWidthTrackbar.Minimum = 10;
            this.penWidthTrackbar.Name = "penWidthTrackbar";
            this.penWidthTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.penWidthTrackbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.penWidthTrackbar.RightToLeftLayout = true;
            this.penWidthTrackbar.Size = new System.Drawing.Size(45, 150);
            this.penWidthTrackbar.TabIndex = 55;
            this.penWidthTrackbar.Value = 10;
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.accuracyLabel.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accuracyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.accuracyLabel.Location = new System.Drawing.Point(543, 405);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(283, 50);
            this.accuracyLabel.TabIndex = 54;
            this.accuracyLabel.Text = "0%";
            this.accuracyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epochsCountLabel
            // 
            this.epochsCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.epochsCountLabel.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.epochsCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.epochsCountLabel.Location = new System.Drawing.Point(29, 405);
            this.epochsCountLabel.Name = "epochsCountLabel";
            this.epochsCountLabel.Size = new System.Drawing.Size(293, 50);
            this.epochsCountLabel.TabIndex = 53;
            this.epochsCountLabel.Text = "0";
            this.epochsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recognitionRateLabel
            // 
            this.recognitionRateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.recognitionRateLabel.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recognitionRateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.recognitionRateLabel.Location = new System.Drawing.Point(479, 515);
            this.recognitionRateLabel.Name = "recognitionRateLabel";
            this.recognitionRateLabel.Size = new System.Drawing.Size(329, 22);
            this.recognitionRateLabel.TabIndex = 51;
            this.recognitionRateLabel.Text = "Testing Result";
            this.recognitionRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorRateLabel
            // 
            this.errorRateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.errorRateLabel.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorRateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.errorRateLabel.Location = new System.Drawing.Point(53, 515);
            this.errorRateLabel.Name = "errorRateLabel";
            this.errorRateLabel.Size = new System.Drawing.Size(321, 22);
            this.errorRateLabel.TabIndex = 50;
            this.errorRateLabel.Text = "Training Results";
            this.errorRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputPicLabel
            // 
            this.inputPicLabel.AutoSize = true;
            this.inputPicLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.inputPicLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputPicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.inputPicLabel.Location = new System.Drawing.Point(191, 29);
            this.inputPicLabel.Name = "inputPicLabel";
            this.inputPicLabel.Size = new System.Drawing.Size(53, 23);
            this.inputPicLabel.TabIndex = 18;
            this.inputPicLabel.Text = "Input";
            // 
            // inputClassLbl
            // 
            this.inputClassLbl.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputClassLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.inputClassLbl.Location = new System.Drawing.Point(147, 283);
            this.inputClassLbl.Name = "inputClassLbl";
            this.inputClassLbl.Size = new System.Drawing.Size(48, 33);
            this.inputClassLbl.TabIndex = 49;
            this.inputClassLbl.Text = "Class";
            this.inputClassLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputClassTextBox
            // 
            this.inputClassTextBox.BackColor = System.Drawing.Color.Transparent;
            this.inputClassTextBox.BackgroundImage = global::NN_PROGLAN.Properties.Resources.TextBoxDefault;
            this.inputClassTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputClassTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputClassTextBox.ExternalLabel = null;
            this.inputClassTextBox.isFocused = false;
            this.inputClassTextBox.isHovered = false;
            this.inputClassTextBox.Location = new System.Drawing.Point(197, 281);
            this.inputClassTextBox.Name = "inputClassTextBox";
            this.inputClassTextBox.ParentPanel = null;
            this.inputClassTextBox.Size = new System.Drawing.Size(90, 40);
            this.inputClassTextBox.TabIndex = 49;
            this.inputClassTextBox.TabStop = false;
            // 
            // inputCanvas
            // 
            this.inputCanvas.BackColor = System.Drawing.Color.Black;
            this.inputCanvas.Location = new System.Drawing.Point(142, 92);
            this.inputCanvas.Name = "inputCanvas";
            this.inputCanvas.Size = new System.Drawing.Size(150, 150);
            this.inputCanvas.TabIndex = 36;
            // 
            // inputCanvasFrame
            // 
            this.inputCanvasFrame.BackgroundImage = global::NN_PROGLAN.Properties.Resources.ImageFrame;
            this.inputCanvasFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputCanvasFrame.Location = new System.Drawing.Point(101, 50);
            this.inputCanvasFrame.Name = "inputCanvasFrame";
            this.inputCanvasFrame.Size = new System.Drawing.Size(230, 230);
            this.inputCanvasFrame.TabIndex = 45;
            this.inputCanvasFrame.TabStop = false;
            // 
            // accuracyHeaderLabel
            // 
            this.accuracyHeaderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.accuracyHeaderLabel.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accuracyHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.accuracyHeaderLabel.Location = new System.Drawing.Point(552, 382);
            this.accuracyHeaderLabel.Name = "accuracyHeaderLabel";
            this.accuracyHeaderLabel.Size = new System.Drawing.Size(256, 22);
            this.accuracyHeaderLabel.TabIndex = 44;
            this.accuracyHeaderLabel.Text = "Accuracy";
            this.accuracyHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epochsHeaderLabel
            // 
            this.epochsHeaderLabel.AutoSize = true;
            this.epochsHeaderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.epochsHeaderLabel.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.epochsHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.epochsHeaderLabel.Location = new System.Drawing.Point(142, 382);
            this.epochsHeaderLabel.Name = "epochsHeaderLabel";
            this.epochsHeaderLabel.Size = new System.Drawing.Size(69, 22);
            this.epochsHeaderLabel.TabIndex = 42;
            this.epochsHeaderLabel.Text = "Epochs";
            // 
            // predictInputButton
            // 
            this.predictInputButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.RectButtonDefault;
            this.predictInputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.predictInputButton.ExternalLabel = null;
            this.predictInputButton.Location = new System.Drawing.Point(302, 294);
            this.predictInputButton.Name = "predictInputButton";
            this.predictInputButton.Size = new System.Drawing.Size(90, 55);
            this.predictInputButton.TabIndex = 41;
            this.predictInputButton.TabStop = false;
            this.predictInputButton.Toggled = false;
            // 
            // outputPicLabel
            // 
            this.outputPicLabel.AutoSize = true;
            this.outputPicLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.outputPicLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputPicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.outputPicLabel.Location = new System.Drawing.Point(610, 28);
            this.outputPicLabel.Name = "outputPicLabel";
            this.outputPicLabel.Size = new System.Drawing.Size(66, 23);
            this.outputPicLabel.TabIndex = 36;
            this.outputPicLabel.Text = "Output";
            // 
            // addInputButton
            // 
            this.addInputButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.RectButtonDefault;
            this.addInputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addInputButton.ExternalLabel = null;
            this.addInputButton.Location = new System.Drawing.Point(41, 294);
            this.addInputButton.Name = "addInputButton";
            this.addInputButton.Size = new System.Drawing.Size(90, 55);
            this.addInputButton.TabIndex = 40;
            this.addInputButton.TabStop = false;
            this.addInputButton.Toggled = false;
            // 
            // outputCanvasFrame
            // 
            this.outputCanvasFrame.BackgroundImage = global::NN_PROGLAN.Properties.Resources.ImageFrame;
            this.outputCanvasFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outputCanvasFrame.Controls.Add(this.outputClassLabel);
            this.outputCanvasFrame.Location = new System.Drawing.Point(527, 50);
            this.outputCanvasFrame.Name = "outputCanvasFrame";
            this.outputCanvasFrame.PanelHovered = false;
            this.outputCanvasFrame.PanelLabel = null;
            this.outputCanvasFrame.PanelLocked = false;
            this.outputCanvasFrame.Size = new System.Drawing.Size(230, 230);
            this.outputCanvasFrame.TabIndex = 38;
            // 
            // outputClassLabel
            // 
            this.outputClassLabel.BackColor = System.Drawing.Color.Black;
            this.outputClassLabel.Font = new System.Drawing.Font("Bahnschrift", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputClassLabel.ForeColor = System.Drawing.Color.White;
            this.outputClassLabel.Location = new System.Drawing.Point(41, 42);
            this.outputClassLabel.Name = "outputClassLabel";
            this.outputClassLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.outputClassLabel.Size = new System.Drawing.Size(150, 150);
            this.outputClassLabel.TabIndex = 45;
            this.outputClassLabel.Text = "0";
            this.outputClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createNetworkBtn
            // 
            this.createNetworkBtn.BackgroundImage = global::NN_PROGLAN.Properties.Resources.RectButtonDefault;
            this.createNetworkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createNetworkBtn.ExternalLabel = null;
            this.createNetworkBtn.Location = new System.Drawing.Point(47, 742);
            this.createNetworkBtn.Name = "createNetworkBtn";
            this.createNetworkBtn.Size = new System.Drawing.Size(126, 69);
            this.createNetworkBtn.TabIndex = 34;
            this.createNetworkBtn.TabStop = false;
            this.createNetworkBtn.Toggled = false;
            // 
            // neuPanel1
            // 
            this.neuPanel1.BackgroundImage = global::NN_PROGLAN.Properties.Resources.ModePanelDefault;
            this.neuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.neuPanel1.Controls.Add(this.testButton);
            this.neuPanel1.Controls.Add(this.trainButton);
            this.neuPanel1.Controls.Add(this.modeMenuPanelLbl);
            this.neuPanel1.Location = new System.Drawing.Point(0, 815);
            this.neuPanel1.Name = "neuPanel1";
            this.neuPanel1.PanelHovered = false;
            this.neuPanel1.PanelLabel = null;
            this.neuPanel1.PanelLocked = false;
            this.neuPanel1.Size = new System.Drawing.Size(220, 135);
            this.neuPanel1.TabIndex = 35;
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.Transparent;
            this.testButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.RectButtonDefault;
            this.testButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.testButton.ExternalLabel = null;
            this.testButton.Location = new System.Drawing.Point(112, 42);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(80, 54);
            this.testButton.TabIndex = 11;
            this.testButton.TabStop = false;
            this.testButton.Toggled = false;
            // 
            // trainButton
            // 
            this.trainButton.BackColor = System.Drawing.Color.Transparent;
            this.trainButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.RectButtonDefault;
            this.trainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trainButton.ExternalLabel = null;
            this.trainButton.Location = new System.Drawing.Point(28, 42);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(80, 54);
            this.trainButton.TabIndex = 10;
            this.trainButton.TabStop = false;
            this.trainButton.Toggled = false;
            // 
            // modeMenuPanelLbl
            // 
            this.modeMenuPanelLbl.AutoSize = true;
            this.modeMenuPanelLbl.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modeMenuPanelLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.modeMenuPanelLbl.Location = new System.Drawing.Point(86, 20);
            this.modeMenuPanelLbl.Name = "modeMenuPanelLbl";
            this.modeMenuPanelLbl.Size = new System.Drawing.Size(48, 19);
            this.modeMenuPanelLbl.TabIndex = 9;
            this.modeMenuPanelLbl.Text = "Mode";
            // 
            // loadModelButton
            // 
            this.loadModelButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.SquareButtonDefault;
            this.loadModelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadModelButton.ExternalLabel = null;
            this.loadModelButton.Location = new System.Drawing.Point(578, 11);
            this.loadModelButton.Name = "loadModelButton";
            this.loadModelButton.Size = new System.Drawing.Size(66, 66);
            this.loadModelButton.TabIndex = 10;
            this.loadModelButton.TabStop = false;
            this.loadModelButton.Toggled = false;
            // 
            // saveModelButton
            // 
            this.saveModelButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.SquareButtonDefault;
            this.saveModelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveModelButton.ExternalLabel = null;
            this.saveModelButton.Location = new System.Drawing.Point(657, 11);
            this.saveModelButton.Name = "saveModelButton";
            this.saveModelButton.Size = new System.Drawing.Size(66, 66);
            this.saveModelButton.TabIndex = 11;
            this.saveModelButton.TabStop = false;
            this.saveModelButton.Toggled = false;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.CircleButtonDefault;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.ExternalLabel = null;
            this.closeButton.Location = new System.Drawing.Point(1030, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 50);
            this.closeButton.TabIndex = 13;
            this.closeButton.TabStop = false;
            this.closeButton.Toggled = false;
            // 
            // hParametersMenuPanel
            // 
            this.hParametersMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.hParametersMenuPanel.BackgroundImage = global::NN_PROGLAN.Properties.Resources.MenuPanelDefault;
            this.hParametersMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hParametersMenuPanel.Controls.Add(this.epochsTextBox);
            this.hParametersMenuPanel.Controls.Add(this.iterationsTextBox);
            this.hParametersMenuPanel.Controls.Add(this.learningRateTextBox);
            this.hParametersMenuPanel.Controls.Add(this.iterationsLabel);
            this.hParametersMenuPanel.Controls.Add(this.epochsLabel);
            this.hParametersMenuPanel.Controls.Add(this.learningRateLabel);
            this.hParametersMenuPanel.Controls.Add(this.hParametersMenuPanelLabel);
            this.hParametersMenuPanel.Location = new System.Drawing.Point(0, 528);
            this.hParametersMenuPanel.Name = "hParametersMenuPanel";
            this.hParametersMenuPanel.PanelHovered = false;
            this.hParametersMenuPanel.PanelLabel = null;
            this.hParametersMenuPanel.PanelLocked = false;
            this.hParametersMenuPanel.Size = new System.Drawing.Size(220, 210);
            this.hParametersMenuPanel.TabIndex = 32;
            this.hParametersMenuPanel.TabStop = true;
            // 
            // epochsTextBox
            // 
            this.epochsTextBox.BackColor = System.Drawing.Color.Transparent;
            this.epochsTextBox.BackgroundImage = global::NN_PROGLAN.Properties.Resources.TextBoxDefault;
            this.epochsTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.epochsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epochsTextBox.ExternalLabel = null;
            this.epochsTextBox.isFocused = false;
            this.epochsTextBox.isHovered = false;
            this.epochsTextBox.Location = new System.Drawing.Point(100, 95);
            this.epochsTextBox.Name = "epochsTextBox";
            this.epochsTextBox.ParentPanel = null;
            this.epochsTextBox.Size = new System.Drawing.Size(90, 40);
            this.epochsTextBox.TabIndex = 50;
            this.epochsTextBox.TabStop = false;
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.BackColor = System.Drawing.Color.Transparent;
            this.iterationsTextBox.BackgroundImage = global::NN_PROGLAN.Properties.Resources.TextBoxDefault;
            this.iterationsTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iterationsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iterationsTextBox.Enabled = false;
            this.iterationsTextBox.ExternalLabel = null;
            this.iterationsTextBox.isFocused = false;
            this.iterationsTextBox.isHovered = false;
            this.iterationsTextBox.Location = new System.Drawing.Point(100, 136);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.ParentPanel = null;
            this.iterationsTextBox.Size = new System.Drawing.Size(90, 40);
            this.iterationsTextBox.TabIndex = 49;
            this.iterationsTextBox.TabStop = false;
            // 
            // learningRateTextBox
            // 
            this.learningRateTextBox.BackColor = System.Drawing.Color.Transparent;
            this.learningRateTextBox.BackgroundImage = global::NN_PROGLAN.Properties.Resources.TextBoxDefault;
            this.learningRateTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.learningRateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.learningRateTextBox.ExternalLabel = null;
            this.learningRateTextBox.isFocused = false;
            this.learningRateTextBox.isHovered = false;
            this.learningRateTextBox.Location = new System.Drawing.Point(100, 54);
            this.learningRateTextBox.Name = "learningRateTextBox";
            this.learningRateTextBox.ParentPanel = null;
            this.learningRateTextBox.Size = new System.Drawing.Size(90, 40);
            this.learningRateTextBox.TabIndex = 48;
            this.learningRateTextBox.TabStop = false;
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iterationsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.iterationsLabel.Location = new System.Drawing.Point(34, 136);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(63, 40);
            this.iterationsLabel.TabIndex = 27;
            this.iterationsLabel.Text = "Iterations";
            this.iterationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // epochsLabel
            // 
            this.epochsLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.epochsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.epochsLabel.Location = new System.Drawing.Point(34, 95);
            this.epochsLabel.Name = "epochsLabel";
            this.epochsLabel.Size = new System.Drawing.Size(63, 40);
            this.epochsLabel.TabIndex = 26;
            this.epochsLabel.Text = "Epochs";
            this.epochsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // learningRateLabel
            // 
            this.learningRateLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.learningRateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.learningRateLabel.Location = new System.Drawing.Point(34, 54);
            this.learningRateLabel.Name = "learningRateLabel";
            this.learningRateLabel.Size = new System.Drawing.Size(63, 40);
            this.learningRateLabel.TabIndex = 25;
            this.learningRateLabel.Text = "LearningRate";
            this.learningRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hParametersMenuPanelLabel
            // 
            this.hParametersMenuPanelLabel.AutoSize = true;
            this.hParametersMenuPanelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.hParametersMenuPanelLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hParametersMenuPanelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.hParametersMenuPanelLabel.Location = new System.Drawing.Point(42, 19);
            this.hParametersMenuPanelLabel.Name = "hParametersMenuPanelLabel";
            this.hParametersMenuPanelLabel.Size = new System.Drawing.Size(139, 19);
            this.hParametersMenuPanelLabel.TabIndex = 7;
            this.hParametersMenuPanelLabel.Text = "Hyperparameters";
            // 
            // networkMenuPanel
            // 
            this.networkMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.networkMenuPanel.BackgroundImage = global::NN_PROGLAN.Properties.Resources.MenuPanelDefault;
            this.networkMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.networkMenuPanel.Controls.Add(this.outputLayerTextBox);
            this.networkMenuPanel.Controls.Add(this.hiddenLayerTextBox);
            this.networkMenuPanel.Controls.Add(this.inputLayerTextBox);
            this.networkMenuPanel.Controls.Add(this.numOfNodesLabel);
            this.networkMenuPanel.Controls.Add(this.networkMenuPanelLabel);
            this.networkMenuPanel.Controls.Add(this.outputLayerLabel);
            this.networkMenuPanel.Controls.Add(this.inputLayerLabel);
            this.networkMenuPanel.Controls.Add(this.hiddenLayerLabel);
            this.networkMenuPanel.Controls.Add(this.layerLabel);
            this.networkMenuPanel.Location = new System.Drawing.Point(0, 305);
            this.networkMenuPanel.Name = "networkMenuPanel";
            this.networkMenuPanel.PanelHovered = false;
            this.networkMenuPanel.PanelLabel = null;
            this.networkMenuPanel.PanelLocked = false;
            this.networkMenuPanel.Size = new System.Drawing.Size(220, 223);
            this.networkMenuPanel.TabIndex = 31;
            this.networkMenuPanel.TabStop = true;
            // 
            // outputLayerTextBox
            // 
            this.outputLayerTextBox.BackColor = System.Drawing.Color.Transparent;
            this.outputLayerTextBox.BackgroundImage = global::NN_PROGLAN.Properties.Resources.TextBoxDefault;
            this.outputLayerTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outputLayerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outputLayerTextBox.ExternalLabel = null;
            this.outputLayerTextBox.isFocused = false;
            this.outputLayerTextBox.isHovered = false;
            this.outputLayerTextBox.Location = new System.Drawing.Point(101, 149);
            this.outputLayerTextBox.Name = "outputLayerTextBox";
            this.outputLayerTextBox.ParentPanel = null;
            this.outputLayerTextBox.Size = new System.Drawing.Size(90, 40);
            this.outputLayerTextBox.TabIndex = 47;
            this.outputLayerTextBox.TabStop = false;
            // 
            // hiddenLayerTextBox
            // 
            this.hiddenLayerTextBox.BackColor = System.Drawing.Color.Transparent;
            this.hiddenLayerTextBox.BackgroundImage = global::NN_PROGLAN.Properties.Resources.TextBoxDefault;
            this.hiddenLayerTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hiddenLayerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hiddenLayerTextBox.ExternalLabel = null;
            this.hiddenLayerTextBox.isFocused = false;
            this.hiddenLayerTextBox.isHovered = false;
            this.hiddenLayerTextBox.Location = new System.Drawing.Point(101, 109);
            this.hiddenLayerTextBox.Name = "hiddenLayerTextBox";
            this.hiddenLayerTextBox.ParentPanel = null;
            this.hiddenLayerTextBox.Size = new System.Drawing.Size(90, 40);
            this.hiddenLayerTextBox.TabIndex = 48;
            this.hiddenLayerTextBox.TabStop = false;
            // 
            // inputLayerTextBox
            // 
            this.inputLayerTextBox.BackColor = System.Drawing.Color.Transparent;
            this.inputLayerTextBox.BackgroundImage = global::NN_PROGLAN.Properties.Resources.TextBoxDefault;
            this.inputLayerTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputLayerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputLayerTextBox.ExternalLabel = null;
            this.inputLayerTextBox.isFocused = false;
            this.inputLayerTextBox.isHovered = false;
            this.inputLayerTextBox.Location = new System.Drawing.Point(101, 71);
            this.inputLayerTextBox.Name = "inputLayerTextBox";
            this.inputLayerTextBox.ParentPanel = null;
            this.inputLayerTextBox.Size = new System.Drawing.Size(90, 40);
            this.inputLayerTextBox.TabIndex = 45;
            this.inputLayerTextBox.TabStop = false;
            // 
            // numOfNodesLabel
            // 
            this.numOfNodesLabel.AutoSize = true;
            this.numOfNodesLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numOfNodesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.numOfNodesLabel.Location = new System.Drawing.Point(104, 49);
            this.numOfNodesLabel.Name = "numOfNodesLabel";
            this.numOfNodesLabel.Size = new System.Drawing.Size(76, 16);
            this.numOfNodesLabel.TabIndex = 42;
            this.numOfNodesLabel.Text = "no. of nodes";
            // 
            // networkMenuPanelLabel
            // 
            this.networkMenuPanelLabel.AutoSize = true;
            this.networkMenuPanelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.networkMenuPanelLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.networkMenuPanelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.networkMenuPanelLabel.Location = new System.Drawing.Point(74, 20);
            this.networkMenuPanelLabel.Name = "networkMenuPanelLabel";
            this.networkMenuPanelLabel.Size = new System.Drawing.Size(70, 19);
            this.networkMenuPanelLabel.TabIndex = 36;
            this.networkMenuPanelLabel.Text = "Network";
            // 
            // outputLayerLabel
            // 
            this.outputLayerLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputLayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.outputLayerLabel.Location = new System.Drawing.Point(34, 149);
            this.outputLayerLabel.Name = "outputLayerLabel";
            this.outputLayerLabel.Size = new System.Drawing.Size(63, 40);
            this.outputLayerLabel.TabIndex = 41;
            this.outputLayerLabel.Text = "Output";
            this.outputLayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputLayerLabel
            // 
            this.inputLayerLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputLayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.inputLayerLabel.Location = new System.Drawing.Point(34, 71);
            this.inputLayerLabel.Name = "inputLayerLabel";
            this.inputLayerLabel.Size = new System.Drawing.Size(63, 40);
            this.inputLayerLabel.TabIndex = 39;
            this.inputLayerLabel.Text = "Input";
            this.inputLayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hiddenLayerLabel
            // 
            this.hiddenLayerLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hiddenLayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.hiddenLayerLabel.Location = new System.Drawing.Point(34, 109);
            this.hiddenLayerLabel.Name = "hiddenLayerLabel";
            this.hiddenLayerLabel.Size = new System.Drawing.Size(63, 40);
            this.hiddenLayerLabel.TabIndex = 40;
            this.hiddenLayerLabel.Text = "Hidden";
            this.hiddenLayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layerLabel
            // 
            this.layerLabel.AutoSize = true;
            this.layerLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.layerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.layerLabel.Location = new System.Drawing.Point(34, 49);
            this.layerLabel.Name = "layerLabel";
            this.layerLabel.Size = new System.Drawing.Size(40, 16);
            this.layerLabel.TabIndex = 38;
            this.layerLabel.Text = "Layer";
            // 
            // datasetMenuPanel
            // 
            this.datasetMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.datasetMenuPanel.BackgroundImage = global::NN_PROGLAN.Properties.Resources.MenuPanelDefault;
            this.datasetMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.datasetMenuPanel.Controls.Add(this.testingDataRadioButton);
            this.datasetMenuPanel.Controls.Add(this.testingDataCountLabel);
            this.datasetMenuPanel.Controls.Add(this.testingDatasetLabel);
            this.datasetMenuPanel.Controls.Add(this.trainingDataRadioButton);
            this.datasetMenuPanel.Controls.Add(this.trainingDataCountLabel);
            this.datasetMenuPanel.Controls.Add(this.trainingDatasetLabel);
            this.datasetMenuPanel.Controls.Add(this.addDatasetButton);
            this.datasetMenuPanel.Controls.Add(this.orLabel);
            this.datasetMenuPanel.Controls.Add(this.testingLabelLine);
            this.datasetMenuPanel.Controls.Add(this.label10);
            this.datasetMenuPanel.Controls.Add(this.trainingLabel);
            this.datasetMenuPanel.Controls.Add(this.importDatasetButton);
            this.datasetMenuPanel.Controls.Add(this.trainingLabelLine);
            this.datasetMenuPanel.Controls.Add(this.datasetMenuPanelLabel);
            this.datasetMenuPanel.Location = new System.Drawing.Point(0, 80);
            this.datasetMenuPanel.Name = "datasetMenuPanel";
            this.datasetMenuPanel.PanelHovered = false;
            this.datasetMenuPanel.PanelLabel = null;
            this.datasetMenuPanel.PanelLocked = false;
            this.datasetMenuPanel.Size = new System.Drawing.Size(220, 225);
            this.datasetMenuPanel.TabIndex = 33;
            this.datasetMenuPanel.TabStop = true;
            // 
            // testingDataRadioButton
            // 
            this.testingDataRadioButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.RadioButtonDefault;
            this.testingDataRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.testingDataRadioButton.ExternalLabel = null;
            this.testingDataRadioButton.Location = new System.Drawing.Point(34, 118);
            this.testingDataRadioButton.Name = "testingDataRadioButton";
            this.testingDataRadioButton.Size = new System.Drawing.Size(31, 31);
            this.testingDataRadioButton.TabIndex = 37;
            this.testingDataRadioButton.TabStop = false;
            this.testingDataRadioButton.Toggled = false;
            // 
            // testingDataCountLabel
            // 
            this.testingDataCountLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testingDataCountLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.testingDataCountLabel.Location = new System.Drawing.Point(146, 120);
            this.testingDataCountLabel.Name = "testingDataCountLabel";
            this.testingDataCountLabel.Size = new System.Drawing.Size(46, 27);
            this.testingDataCountLabel.TabIndex = 20;
            this.testingDataCountLabel.Text = "0";
            this.testingDataCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // testingDatasetLabel
            // 
            this.testingDatasetLabel.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testingDatasetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.testingDatasetLabel.Location = new System.Drawing.Point(67, 120);
            this.testingDatasetLabel.Name = "testingDatasetLabel";
            this.testingDatasetLabel.Size = new System.Drawing.Size(78, 27);
            this.testingDatasetLabel.TabIndex = 18;
            this.testingDatasetLabel.Text = "Select Folder...";
            this.testingDatasetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trainingDataRadioButton
            // 
            this.trainingDataRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.trainingDataRadioButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.RadioButtonClicked;
            this.trainingDataRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trainingDataRadioButton.ExternalLabel = null;
            this.trainingDataRadioButton.Location = new System.Drawing.Point(34, 66);
            this.trainingDataRadioButton.Name = "trainingDataRadioButton";
            this.trainingDataRadioButton.Size = new System.Drawing.Size(31, 31);
            this.trainingDataRadioButton.TabIndex = 36;
            this.trainingDataRadioButton.TabStop = false;
            this.trainingDataRadioButton.Toggled = false;
            // 
            // trainingDataCountLabel
            // 
            this.trainingDataCountLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainingDataCountLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.trainingDataCountLabel.Location = new System.Drawing.Point(146, 68);
            this.trainingDataCountLabel.Name = "trainingDataCountLabel";
            this.trainingDataCountLabel.Size = new System.Drawing.Size(46, 27);
            this.trainingDataCountLabel.TabIndex = 19;
            this.trainingDataCountLabel.Text = "0";
            this.trainingDataCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trainingDatasetLabel
            // 
            this.trainingDatasetLabel.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainingDatasetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.trainingDatasetLabel.Location = new System.Drawing.Point(67, 68);
            this.trainingDatasetLabel.Name = "trainingDatasetLabel";
            this.trainingDatasetLabel.Size = new System.Drawing.Size(78, 27);
            this.trainingDatasetLabel.TabIndex = 17;
            this.trainingDatasetLabel.Text = "Select Folder...";
            this.trainingDatasetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addDatasetButton
            // 
            this.addDatasetButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.SquareButtonDefault;
            this.addDatasetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addDatasetButton.ExternalLabel = null;
            this.addDatasetButton.Location = new System.Drawing.Point(145, 149);
            this.addDatasetButton.Name = "addDatasetButton";
            this.addDatasetButton.Size = new System.Drawing.Size(50, 50);
            this.addDatasetButton.TabIndex = 34;
            this.addDatasetButton.TabStop = false;
            this.addDatasetButton.Toggled = false;
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.orLabel.Location = new System.Drawing.Point(114, 166);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(22, 18);
            this.orLabel.TabIndex = 42;
            this.orLabel.Text = "or";
            this.orLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // testingLabelLine
            // 
            this.testingLabelLine.AutoSize = true;
            this.testingLabelLine.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testingLabelLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.testingLabelLine.Location = new System.Drawing.Point(33, 97);
            this.testingLabelLine.Name = "testingLabelLine";
            this.testingLabelLine.Size = new System.Drawing.Size(60, 19);
            this.testingLabelLine.TabIndex = 41;
            this.testingLabelLine.Text = "Testing";
            this.testingLabelLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label10.Location = new System.Drawing.Point(98, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 1);
            this.label10.TabIndex = 40;
            // 
            // trainingLabel
            // 
            this.trainingLabel.AutoSize = true;
            this.trainingLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.trainingLabel.Location = new System.Drawing.Point(33, 45);
            this.trainingLabel.Name = "trainingLabel";
            this.trainingLabel.Size = new System.Drawing.Size(67, 19);
            this.trainingLabel.TabIndex = 39;
            this.trainingLabel.Text = "Training";
            this.trainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // importDatasetButton
            // 
            this.importDatasetButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.RectButtonDefault;
            this.importDatasetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.importDatasetButton.ExternalLabel = null;
            this.importDatasetButton.Location = new System.Drawing.Point(28, 151);
            this.importDatasetButton.Name = "importDatasetButton";
            this.importDatasetButton.Size = new System.Drawing.Size(80, 45);
            this.importDatasetButton.TabIndex = 36;
            this.importDatasetButton.TabStop = false;
            this.importDatasetButton.Toggled = false;
            // 
            // trainingLabelLine
            // 
            this.trainingLabelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.trainingLabelLine.Location = new System.Drawing.Point(106, 57);
            this.trainingLabelLine.Name = "trainingLabelLine";
            this.trainingLabelLine.Size = new System.Drawing.Size(80, 1);
            this.trainingLabelLine.TabIndex = 21;
            // 
            // datasetMenuPanelLabel
            // 
            this.datasetMenuPanelLabel.AutoSize = true;
            this.datasetMenuPanelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.datasetMenuPanelLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datasetMenuPanelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.datasetMenuPanelLabel.Location = new System.Drawing.Point(80, 20);
            this.datasetMenuPanelLabel.Name = "datasetMenuPanelLabel";
            this.datasetMenuPanelLabel.Size = new System.Drawing.Size(65, 19);
            this.datasetMenuPanelLabel.TabIndex = 5;
            this.datasetMenuPanelLabel.Text = "Dataset";
            // 
            // selectedFilePath
            // 
            this.selectedFilePath.AutoSize = true;
            this.selectedFilePath.ForeColor = System.Drawing.Color.White;
            this.selectedFilePath.Location = new System.Drawing.Point(227, 62);
            this.selectedFilePath.Name = "selectedFilePath";
            this.selectedFilePath.Size = new System.Drawing.Size(0, 15);
            this.selectedFilePath.TabIndex = 36;
            // 
            // testingDatasetFullPathLabel
            // 
            this.testingDatasetFullPathLabel.AutoSize = true;
            this.testingDatasetFullPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.testingDatasetFullPathLabel.Location = new System.Drawing.Point(221, 44);
            this.testingDatasetFullPathLabel.Name = "testingDatasetFullPathLabel";
            this.testingDatasetFullPathLabel.Size = new System.Drawing.Size(0, 15);
            this.testingDatasetFullPathLabel.TabIndex = 37;
            // 
            // trainingDatasetFullPathLabel
            // 
            this.trainingDatasetFullPathLabel.AutoSize = true;
            this.trainingDatasetFullPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.trainingDatasetFullPathLabel.Location = new System.Drawing.Point(221, 24);
            this.trainingDatasetFullPathLabel.Name = "trainingDatasetFullPathLabel";
            this.trainingDatasetFullPathLabel.Size = new System.Drawing.Size(0, 15);
            this.trainingDatasetFullPathLabel.TabIndex = 38;
            // 
            // messageTray
            // 
            this.messageTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.messageTray.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageTray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.messageTray.Location = new System.Drawing.Point(500, 940);
            this.messageTray.Name = "messageTray";
            this.messageTray.Size = new System.Drawing.Size(580, 22);
            this.messageTray.TabIndex = 60;
            this.messageTray.Text = "status...";
            this.messageTray.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBarBackgroundWorker
            // 
            this.progressBarBackgroundWorker.WorkerReportsProgress = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 965);
            this.Controls.Add(this.messageTray);
            this.Controls.Add(this.trainingDatasetFullPathLabel);
            this.Controls.Add(this.testingDatasetFullPathLabel);
            this.Controls.Add(this.selectedFilePath);
            this.Controls.Add(this.neuPanel1);
            this.Controls.Add(this.createNetworkBtn);
            this.Controls.Add(this.hParametersMenuPanel);
            this.Controls.Add(this.networkMenuPanel);
            this.Controls.Add(this.datasetMenuPanel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveModelButton);
            this.Controls.Add(this.loadModelButton);
            this.Controls.Add(this.subPanel);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.subPanel.ResumeLayout(false);
            this.subPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penWidthTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCanvasFrame)).EndInit();
            this.outputCanvasFrame.ResumeLayout(false);
            this.neuPanel1.ResumeLayout(false);
            this.neuPanel1.PerformLayout();
            this.hParametersMenuPanel.ResumeLayout(false);
            this.hParametersMenuPanel.PerformLayout();
            this.networkMenuPanel.ResumeLayout(false);
            this.networkMenuPanel.PerformLayout();
            this.datasetMenuPanel.ResumeLayout(false);
            this.datasetMenuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

            //this.datasetPanel.PanelLabel = menuLabel1;
            //this.networkPanel.PanelLabel = menuLabel2;
            //this.hyperparametersPanel.PanelLabel = menuLabel3;        
        #endregion

        private Label title;
        private Interface.Neu.NeuButton loadModelButton;
        private Interface.Neu.NeuButton saveModelButton;
        private Interface.Neu.NeuButton closeButton;


        private System.Windows.Forms.Panel dummyPanel = new System.Windows.Forms.Panel();
        private Label inputPicLabel;
        private Label modeMenuPanelLbl;
        private Interface.Neu.NeuButton createNetworkBtn;
        private Interface.Neu.NeuPanel hParametersMenuPanel;
        private Interface.Neu.NeuTextBox epochsTextBox;
        private Interface.Neu.NeuTextBox iterationsTextBox;
        private Interface.Neu.NeuTextBox learningRateTextBox;
        private Label iterationsLabel;
        private Label epochsLabel;
        private Label learningRateLabel;
        private Label hParametersMenuPanelLabel;
        private Interface.Neu.NeuPanel networkMenuPanel;
        private Interface.Neu.NeuTextBox outputLayerTextBox;
        private Interface.Neu.NeuTextBox hiddenLayerTextBox;
        private Interface.Neu.NeuTextBox inputLayerTextBox;
        private Label numOfNodesLabel;
        private Label networkMenuPanelLabel;
        private Label outputLayerLabel;
        private Label inputLayerLabel;
        private Label hiddenLayerLabel;
        private Label layerLabel;
        private Interface.Neu.NeuPanel datasetMenuPanel;
        private Label trainingLabelLine;
        private Label testingDataCountLabel;
        private Label trainingDataCountLabel;
        private Label testingDatasetLabel;
        private Label trainingDatasetLabel;
        private Label datasetMenuPanelLabel;
        private Interface.Neu.NeuPanel neuPanel1;
        private Interface.Neu.NeuButton trainButton;
        private Interface.Neu.NeuButton testButton;
        private Interface.Neu.NeuButton trainingDataRadioButton;
        private Interface.Neu.NeuButton testingDataRadioButton;
        private Interface.Neu.NeuButton importDatasetButton;
        private Label outputPicLabel;
        private Interface.Neu.NeuPanel outputCanvasFrame;
        private Interface.Neu.NeuButton addInputButton;
        private Interface.Neu.NeuButton predictInputButton;
        private Label epochsHeaderLabel;
        private Label accuracyHeaderLabel;
        private Label outputClassLabel;
        private PictureBox inputCanvasFrame;
        private Interface.Canvas inputCanvas;
        private Interface.Neu.NeuTextBox inputClassTextBox;
        private Label inputClassLbl;
        private Label recognitionRateLabel;
        private Label errorRateLabel;
        private Label accuracyLabel;
        private Label epochsCountLabel;
        private Label testingLabelLine;
        private Label label10;
        private Label trainingLabel;
        private NeuButton addDatasetButton;
        private Label orLabel;
        private Interface.Neu.NeuTrackBar penWidthTrackbar;
        private Label penWidthLabel;
        private Label selectedFilePath;
        private Label testingDatasetFullPathLabel;
        private Label trainingDatasetFullPathLabel;
        private TextBox trainingTextBox;
        private Label messageTray;
        private System.ComponentModel.BackgroundWorker progressBarBackgroundWorker;
        private Interface.ProgressBar.CircularProgressBar circularBar;
        private NeuButton matrixButton;
        private FastReport.DataVisualization.Charting.ChartArea chartArea2;
        private Panel subPanel;
        private TextBox testingTextBox;
    }
}