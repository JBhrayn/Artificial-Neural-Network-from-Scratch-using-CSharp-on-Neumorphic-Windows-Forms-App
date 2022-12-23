using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NN_PROGLAN.Interface.Neu
{
    public partial class NeuTextBox : UserControl
    {
        private NeuPanel parentPanel;
        private Image defaultImg;
        private Image mouseHoveredImg;
        private Image mouseClickedImg;
        private Label label = new Label();
        private Color inactiveColor = Color.FromArgb(150,150,150);
        private Color hoveredColor = Color.White;
        private Color activeColor = Color.FromArgb(51, 204, 255);

        public bool isHovered { get; set; }
        public bool isFocused { get; set; }


        public Label ExternalLabel
        {
            get { return this.label; }
            set { this.label = value; }
        }

        public NeuPanel ParentPanel
        {
            get { return this.parentPanel; }
            set { this.parentPanel = value; }
        }

        public override String Text
        {
            get { return this.text.Text; }
            set { this.text.Text = value; }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        public NeuTextBox()
        {
            InitializeComponent();
            defaultImg = Properties.Resources.TextBoxDefault;
            mouseClickedImg = Properties.Resources.TextBoxClicked;
        }

        private void SetGraphics(Image img, Color foreColor)
        {
            BackgroundImage = img;
            text.ForeColor = foreColor;
            label.ForeColor = foreColor;
        }

        public void Activate()
        {
            text.ForeColor = hoveredColor;
            label.ForeColor = hoveredColor;

            isFocused = false;
            isHovered = true;
            Cursor.Current = Cursors.IBeam;
        }
        public void Deactivate()
        {
            text.ForeColor = inactiveColor;
            label.ForeColor = inactiveColor;
            BackgroundImage = Properties.Resources.TextBoxDefault;

            isFocused = false;
            isHovered = false;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            if (isFocused) return;
            Activate();
        }
        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (isFocused) return;
            Deactivate();
        }
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            text.ForeColor = activeColor;
            label.ForeColor = activeColor;
            BackgroundImage = Properties.Resources.TextBoxClicked;

            isFocused = true;
            isHovered = false;
            
            if(text.Text == "0")
                text.Clear();
            text.Focus();
        }

        private void OnValidated(object sender, EventArgs e)
        {
            if (text.Text.Trim().Equals(""))
                text.Text = "0";
        }

        private void NeuTextBox_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            Deactivate();
        }

        private void NeuTextBox_MouseHover(object sender, EventArgs e)
        {
            text.ForeColor = activeColor;
            label.ForeColor = activeColor;
        }

        private void NeuTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFocused) return;
            Activate();
        }

    }
}
