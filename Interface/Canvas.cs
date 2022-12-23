using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace NN_PROGLAN.Interface
{
    public partial class Canvas : UserControl
    {
        private Pen pen;
        private Point px;
        private Point py;
        private Graphics g;
        private Bitmap bitmap;
        private bool penDown = false;

        public Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }

        public Bitmap Image
        {
            set { frame.Image = value; }
        }
        public Bitmap Bitmap { get { return bitmap; }}

        public Canvas()
        {
            InitializeComponent();

            bitmap = new Bitmap(Width, Height);
            
            pen = new Pen(Color.White, 5);
            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
            g = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.Clear(Color.Black);

            frame.Image = bitmap;
        }

        private void OnMouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                g.Clear(Color.Black);
                Refresh();
                return;
            }

            penDown = true;
            py = e.Location;
        }

        private void OnMouseMove(object? sender, MouseEventArgs e)
        {
            if (!penDown) return;

            px = e.Location;
            g.DrawLine(pen, px, py);
            py = px;
            Refresh();
        }


        private void OnMouseUp(object? sender, MouseEventArgs e)
        {
            penDown = false;
        }

        private void frame_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            g.Clear(Color.White);
        }
    }
}
