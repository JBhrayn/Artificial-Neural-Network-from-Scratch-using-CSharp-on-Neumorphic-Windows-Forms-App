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
    public enum ButtonType
    {
        Icon,
        Radio,
        Square,
        Circle,
        Picture,
        Rectangle
    }
    public partial class NeuButton : UserControl
    {
        private ButtonType type;
        private Color defaultColor;
        private Image defaultImage;
        private Image mouseClickedImage;
        private Color mouseHoveredColor;
        private Color mouseClickedColor;
        private Padding defaultPadding;
        private Padding clickedPadding;

        private Image defaultIcon;
        private Image mouseHoveredIcon;
        private Image mouseClickedIcon;

        private Label externalLabel = new Label();

        public bool Toggled { get; set; }

        public Label ExternalLabel { get; set; }

        public override String Text
        {
            set { this.buttonLabel.Text = value; }
        }

        new public Font Font
        {
            set { buttonLabel.Font = value; }
        }

        public NeuButton()
        {
            InitializeComponent();
            buttonLabel.Text = "";
            Toggled = false;
            defaultPadding = new Padding(0, 0, 0, 0);
            defaultColor = Color.FromArgb(150, 150, 150);
            mouseHoveredColor = Color.White;
            mouseClickedColor = Color.FromArgb(51, 204, 255);
        }
 

        public ButtonType Type
        {
            set
            {
                type = value;

                switch (type)
                {
                    case ButtonType.Radio:
                        {
                            setGraphics(
                                defaultPad: new Padding(0, 0, 0, 0),
                                clickedPad: new Padding(0, 0, 0, 0),
                                defaultImg: Properties.Resources.RadioButtonDefault,
                                clickedImg: Properties.Resources.RadioButtonClicked);
                            break;
                        }
                    case ButtonType.Circle:
                        {
                            setGraphics(
                                defaultPad: new Padding(0, 0, 0, 0),
                                clickedPad: new Padding(0, 0, 0, 0),
                                defaultImg: Properties.Resources.CircleButtonDefault,
                                clickedImg: Properties.Resources.CircleButtonClicked);
                            break;
                        }
                    case ButtonType.Square:
                        {
                            setGraphics(
                                defaultPad: new Padding(0, 0, 0, 0),
                                clickedPad: new Padding(0, 2, 0, 0),
                                defaultImg: Properties.Resources.SquareButtonDefault,
                                clickedImg: Properties.Resources.SquareButtonClicked);
                            break;
                        }
                    case ButtonType.Rectangle:
                        {
                            setGraphics(
                                defaultPad: new Padding(0, 0, 0, 0),
                                clickedPad: new Padding(0, 2, 0, 0),
                                defaultImg: Properties.Resources.RectButtonDefault,
                                clickedImg: Properties.Resources.RectButtonClicked);
                            break;
                        }
                    case ButtonType.Picture:
                        {
                            setGraphics(
                                defaultPad: new Padding(0, 0, 0, 0),
                                clickedPad: new Padding(0, 0, 0, 0),
                                defaultImg: Properties.Resources.None,
                                clickedImg: Properties.Resources.None);
                            break;
                        }
                }

                buttonLabel.Padding = defaultPadding;
            }
        }
        public void setGraphics(Padding defaultPad, Padding clickedPad, Bitmap defaultImg, Bitmap clickedImg)
        {
            defaultPadding = defaultPad;
            clickedPadding = clickedPad;
            defaultImage = defaultImg;
            mouseClickedImage = clickedImg;
        }

        public void SetIcons(Bitmap defaultIcon, Bitmap hoveredIcon, Bitmap clickedIcon)
        {
            this.defaultIcon = defaultIcon;
            mouseHoveredIcon = hoveredIcon;
            mouseClickedIcon = clickedIcon;
            buttonLabel.Image = defaultIcon;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (Toggled) return;

            BackgroundImage = defaultImage;
            buttonLabel.Image = defaultIcon;
            Cursor.Current = Cursors.Default;
            buttonLabel.Padding = defaultPadding;
            buttonLabel.ForeColor = defaultColor;
            externalLabel.ForeColor = defaultColor;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (Toggled) return;

            buttonLabel.Image = mouseHoveredIcon;
            buttonLabel.Padding = defaultPadding;
            buttonLabel.ForeColor = mouseHoveredColor;
            externalLabel.ForeColor = mouseHoveredColor;
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Lock(false);
            Focus();
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (Toggled) return;

            buttonLabel.Padding = defaultPadding;
            buttonLabel.ForeColor = mouseHoveredColor;
            externalLabel.ForeColor = mouseHoveredColor;
            BackgroundImage = defaultImage;
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void buttonLabel_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        public void Lock(bool isLocked)
        {
            Toggled = isLocked;
            BackgroundImage = mouseClickedImage;
            buttonLabel.Image = mouseClickedIcon;
            buttonLabel.Padding = clickedPadding;
            buttonLabel.ForeColor = mouseClickedColor;
            externalLabel.ForeColor = mouseClickedColor;
            externalLabel.Text = Toggled + "";
            Cursor.Current = Cursors.Hand;
        }

        public void Deselect()
        {
            Toggled = false;
            BackgroundImage = defaultImage;
            buttonLabel.Padding = defaultPadding;
            buttonLabel.ForeColor = defaultColor;
            externalLabel.ForeColor = defaultColor;
            Cursor.Current = Cursors.Default;
        }

        public void OnMouseDown(MouseEventHandler handler)
        {
            buttonLabel.MouseDown += handler;
        }
        public void OnMouseClick(MouseEventHandler handler)
        {
            buttonLabel.MouseUp += handler;
        }


    }
}
