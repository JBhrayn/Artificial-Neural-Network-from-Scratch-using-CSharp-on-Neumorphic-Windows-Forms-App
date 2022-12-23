using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NN_PROGLAN.Interface.Neu
{
    public partial class NeuDialogBox : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void DialogBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
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
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        private Label label;

        public NeuDialogBox(String header, Label label)
        {
            InitializeComponent();
            this.label = label;
            title.Text = header;
            MouseDown += DialogBox_MouseDown;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            SetStyle(ControlStyles.DoubleBuffer, true);

            EventHandler OnMouseHover = (s, e) => Cursor.Current = Cursors.Hand;
            EventHandler OnMouseEnter = (s, e) => {
                Cursor.Current = Cursors.Hand;
                folderPathLabel.ForeColor = Color.White;
            };
            EventHandler OnMouseLeave = (s, e) => {
                Cursor.Current = Cursors.Default;
                frame.BackgroundImage = Properties.Resources.FileChooserButtonDefault;
                folderPathLabel.ForeColor = Color.FromArgb(150, 150, 150);
            };
            MouseEventHandler OnMouseDown = (s, e) => {
                Cursor.Current = Cursors.Hand;
                frame.BackgroundImage = Properties.Resources.FileChooserButtonClicked;
                folderPathLabel.ForeColor = Color.FromArgb(51, 204, 255);
            };
            MouseEventHandler OnMouseUp = (s, e) => {
                frame.BackgroundImage = Properties.Resources.FileChooserButtonDefault;
                folderPathLabel.ForeColor = Color.FromArgb(150, 150, 150);
            };

            frame.MouseUp += OnMouseUp;
            frame.MouseDown += OnMouseDown;
            frame.MouseEnter += OnMouseEnter;
            frame.MouseLeave += OnMouseLeave;
            frame.MouseHover += OnMouseHover;
            frame.MouseDown += OpenFileDialog_OnMouseClick;

            folderPathLabel.MouseUp += OnMouseUp;
            folderPathLabel.MouseDown += OnMouseDown;
            folderPathLabel.MouseEnter += OnMouseEnter;
            folderPathLabel.MouseLeave += OnMouseLeave;
            folderPathLabel.MouseHover += OnMouseHover;
            folderPathLabel.MouseDown += OpenFileDialog_OnMouseClick;

            continueButton.Text = "Continue";
            continueButton.Type = ButtonType.Rectangle;
            continueButton.OnMouseClick((s, e) => Close());
            closeDialogButton.Type = ButtonType.Circle;
            closeDialogButton.SetIcons(
                defaultIcon: Properties.Resources.CloseIconDefault,
                hoveredIcon: Properties.Resources.CloseIconHovered,
                clickedIcon: Properties.Resources.CloseIconHovered);
            closeDialogButton.OnMouseClick((s, e) => {
                label.Text = "";
                Close();
            });
        }

        private void OpenFileDialog_OnMouseClick(object sender, MouseEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    string[] paths = fbd.SelectedPath.Split('\\');
                    folderPathLabel.Text = fbd.SelectedPath;
                    label.Text = fbd.SelectedPath;
                }
            }
        }




    }
}
