namespace NN_PROGLAN.Interface.Neu
{
    partial class NeuTextBox
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
            this.text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.text.Location = new System.Drawing.Point(14, 12);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(61, 17);
            this.text.TabIndex = 0;
            this.text.Text = "1000";
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.text.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.text.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            this.text.MouseHover += new System.EventHandler(this.OnMouseEnter);
            this.text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseEnter);
            this.text.Validated += new System.EventHandler(this.OnValidated);
            // 
            // NeuTextBox
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::NN_PROGLAN.Properties.Resources.TextBoxDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.text);
            this.DoubleBuffered = true;
            this.Name = "NeuTextBox";
            this.Size = new System.Drawing.Size(91, 45);
            this.Leave += new System.EventHandler(this.NeuTextBox_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            this.MouseHover += new System.EventHandler(this.OnMouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NeuTextBox_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text;
    }
}
