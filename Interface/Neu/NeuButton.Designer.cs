namespace NN_PROGLAN.Interface.Neu
{
    partial class NeuButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLabel
            // 
            this.buttonLabel.BackColor = System.Drawing.Color.Transparent;
            this.buttonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.buttonLabel.Location = new System.Drawing.Point(0, 0);
            this.buttonLabel.Name = "buttonLabel";
            this.buttonLabel.Size = new System.Drawing.Size(546, 224);
            this.buttonLabel.TabIndex = 0;
            this.buttonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.buttonLabel.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonLabel.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.buttonLabel.MouseHover += new System.EventHandler(this.Button_MouseHover);
            this.buttonLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonLabel_MouseMove);
            this.buttonLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // NeuButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NN_PROGLAN.Properties.Resources.RectButtonDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonLabel);
            this.DoubleBuffered = true;
            this.Name = "NeuButton";
            this.Size = new System.Drawing.Size(546, 224);
            this.ResumeLayout(false);

        }

        #endregion

        private Label buttonLabel;
    }
}
