namespace NN_PROGLAN.Interface.Neu
{
    partial class NeuDialogBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuDialogBox));
            this.title = new System.Windows.Forms.Label();
            this.closeDialogButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.label2 = new System.Windows.Forms.Label();
            this.continueButton = new NN_PROGLAN.Interface.Neu.NeuButton();
            this.frame = new System.Windows.Forms.PictureBox();
            this.folderPathLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(21, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(150, 19);
            this.title.TabIndex = 0;
            this.title.Text = "New {Type} Dataset";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeDialogButton
            // 
            this.closeDialogButton.BackgroundImage = global::NN_PROGLAN.Properties.Resources.CircleButtonDefault;
            this.closeDialogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeDialogButton.ExternalLabel = null;
            this.closeDialogButton.Location = new System.Drawing.Point(258, 12);
            this.closeDialogButton.Name = "closeDialogButton";
            this.closeDialogButton.Size = new System.Drawing.Size(50, 50);
            this.closeDialogButton.TabIndex = 1;
            this.closeDialogButton.Toggled = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save input images to folder:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // continueButton
            // 
            this.continueButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("continueButton.BackgroundImage")));
            this.continueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.continueButton.ExternalLabel = null;
            this.continueButton.Location = new System.Drawing.Point(92, 185);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(140, 69);
            this.continueButton.TabIndex = 3;
            this.continueButton.Toggled = false;
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.Transparent;
            this.frame.BackgroundImage = global::NN_PROGLAN.Properties.Resources.FileChooserButtonDefault;
            this.frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frame.Location = new System.Drawing.Point(11, 107);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(301, 69);
            this.frame.TabIndex = 4;
            this.frame.TabStop = false;
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.folderPathLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.folderPathLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.folderPathLabel.ForeColor = System.Drawing.Color.White;
            this.folderPathLabel.Location = new System.Drawing.Point(52, 135);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(221, 16);
            this.folderPathLabel.TabIndex = 5;
            this.folderPathLabel.Text = "C:\\";
            // 
            // NeuDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(325, 261);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.frame);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeDialogButton);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NeuDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeuDialogBox";
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private NeuButton closeDialogButton;
        private Label label2;
        private NeuButton continueButton;
        private PictureBox frame;
        private TextBox folderPathLabel;
    }
}