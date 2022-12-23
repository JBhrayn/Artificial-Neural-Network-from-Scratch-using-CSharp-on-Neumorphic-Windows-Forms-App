using System.ComponentModel;
using System.Drawing.Drawing2D;
// https://stackoverflow.com/users/2000656/jhollman
namespace NN_PROGLAN.Interface.ProgressBar
{
    public class CircularProgressBar : Control
    {
        #region Enums

        public enum _ProgressShape
        {
            Round,
            Flat
        }

        public enum _TextMode
        {
            None,
            Value,
            Percentage,
            Custom
        }

        #endregion

        #region Private Variables

        private long _Value;
        private long _Maximum = 100;
        private int _LineWitdh = 1;
        private float _BarWidth = 14f;

        private Color _ProgressColor1 = Color.Orange;
        private Color _ProgressColor2 = Color.Orange;
        private Color _LineColor = Color.Silver;
        private LinearGradientMode _GradientMode = LinearGradientMode.ForwardDiagonal;
        private _ProgressShape ProgressShapeVal;
        private _TextMode ProgressTextMode;

        #endregion

        #region Contructor

        public CircularProgressBar()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            BackColor = SystemColors.Control;
            ForeColor = Color.DimGray;

            Size = new Size(130, 130);
            Font = new Font("Segoe UI", 15);
            MinimumSize = new Size(100, 100);
            DoubleBuffered = true;

            LineWidth = 1;
            LineColor = Color.DimGray;

            Value = 57;
            ProgressShape = _ProgressShape.Flat;
            TextMode = _TextMode.Percentage;
        }

        #endregion

        #region Public Custom Properties

        [Description("Integer value that determines the position of the Progress Bar."), Category("Behavior")]
        public long Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if (value > _Maximum)
                    value = _Maximum;
                _Value = value;
                Invalidate();
            }
        }

        [Description("Gets or Sets the Maximum Value of the Progress bar"), Category("Behavior")]
        public long Maximum
        {
            get
            {
                return _Maximum;
            }
            set
            {
                if (value < 1)
                    value = 1;
                _Maximum = value;
                Invalidate();
            }
        }

        [Description("Initial Color of Progress Bar"), Category("Appearance")]
        public Color BarColor1
        {
            get
            {
                return _ProgressColor1;
            }
            set
            {
                _ProgressColor1 = value;
                Invalidate();
            }
        }

        [Description("Final Color of Progress Bar"), Category("Appearance")]
        public Color BarColor2
        {
            get
            {
                return _ProgressColor2;
            }
            set
            {
                _ProgressColor2 = value;
                Invalidate();
            }
        }

        [Description("Progress Bar Width"), Category("Appearance")]
        public float BarWidth
        {
            get
            {
                return _BarWidth;
            }
            set
            {
                _BarWidth = value;
                Invalidate();
            }
        }

        [Description("Color Gradient Mode"), Category("Appearance")]
        public LinearGradientMode GradientMode
        {
            get
            {
                return _GradientMode;
            }
            set
            {
                _GradientMode = value;
                Invalidate();
            }
        }

        [Description("Intermediate Line Color"), Category("Appearance")]
        public Color LineColor
        {
            get
            {
                return _LineColor;
            }
            set
            {
                _LineColor = value;
                Invalidate();
            }
        }

        [Description("Intermediate Line Width"), Category("Appearance")]
        public int LineWidth
        {
            get
            {
                return _LineWitdh;
            }
            set
            {
                _LineWitdh = value;
                Invalidate();
            }
        }

        [Description("Gets or Sets the Shape of the progress bar terminals."), Category("Appearance")]
        public _ProgressShape ProgressShape
        {
            get
            {
                return ProgressShapeVal;
            }
            set
            {
                ProgressShapeVal = value;
                Invalidate();
            }
        }

        [Description("Gets or Sets the Mode how the Text is displayed within the Progress bar."), Category("Behavior")]
        public _TextMode TextMode
        {
            get
            {
                return ProgressTextMode;
            }
            set
            {
                ProgressTextMode = value;
                Invalidate();
            }
        }

        [Description("Gets the Text that is displayed inside the Control"), Category("Behavior")]
        public override string Text
        {
            get; set;
        }

        #endregion

        #region EventArgs

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetStandardSize();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            SetStandardSize();
        }

        protected override void OnPaintBackground(PaintEventArgs p)
        {
            base.OnPaintBackground(p);
        }

        #endregion

        #region Methods

        private void SetStandardSize()
        {
            int _Size = Math.Max(Width, Height);
            Size = new Size(_Size, _Size);
        }

        public void Increment(int Val)
        {
            _Value += Val;
            Invalidate();
        }

        public void Decrement(int Val)
        {
            _Value -= Val;
            Invalidate();
        }
        #endregion

        #region Events

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using Bitmap bitmap = new Bitmap(Width, Height);
            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


            PaintTransparentBackground(this, e);

            // Inner Circle:
            using (Brush mBackColor = new SolidBrush(BackColor))
            {
                graphics.FillEllipse(mBackColor,
                        18, 18,
                        (Width - 0x30) + 12,
                        (Height - 0x30) + 12);
            }
            // Border Line:
            using (Pen pen2 = new Pen(LineColor, LineWidth))
            {
                graphics.DrawEllipse(pen2,
                    18, 18,
                  (Width - 0x30) + 12,
                  (Height - 0x30) + 12);
            }

            // Progress Bar
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
                _ProgressColor1, _ProgressColor2, GradientMode))
            {
                using (Pen pen = new Pen(brush, BarWidth))
                {
                    switch (ProgressShapeVal)
                    {
                        case _ProgressShape.Round:
                            pen.StartCap = LineCap.Round;
                            pen.EndCap = LineCap.Round;
                            break;

                        case _ProgressShape.Flat:
                            pen.StartCap = LineCap.Flat;
                            pen.EndCap = LineCap.Flat;
                            break;
                    }

                    // Draw Progress Bar
                    graphics.DrawArc(pen,
                        0x12, 0x12,
                        (Width - 0x23) - 2,
                        (Height - 0x23) - 2,
                        -90,
                        (int)Math.Round((double)((360.0 / ((double)_Maximum)) * _Value)));
                }
            }

            #region Draw Progress Text

            switch (TextMode)
            {
                case _TextMode.None:
                    Text = string.Empty;
                    break;

                case _TextMode.Value:
                    Text = _Value.ToString();
                    break;

                case _TextMode.Percentage:
                    Text = Convert.ToString(Convert.ToInt32((_Value / (double)_Maximum * 100))) + "%";
                    break;

                default:
                    break;
            }

            if (Text != string.Empty)
            {
                using Brush FontColor = new SolidBrush(ForeColor);
                SizeF MS = graphics.MeasureString(Text, Font);
                SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, ForeColor));

                // Control Text:
                graphics.DrawString(Text, Font, FontColor,
                    Convert.ToInt32(Width / 2 - MS.Width / 2),
                    Convert.ToInt32(Height / 2 - MS.Height / 2));
            }

            #endregion

            // Draw Control:
            e.Graphics.DrawImage(bitmap, 0, 0);
            graphics.Dispose();
            bitmap.Dispose();
        }

        private static void PaintTransparentBackground(Control c, PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;

            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }

        /// <summary>Draw a Color Filled Circle with Perfect Edges.</summary>
        /// <param name="g">'Canvas' of the Object where it is going to be drawn</param>
        /// <param name="brush">Fill color and style</param>
        /// <param name="centerX">Center of the Circle, on the X axis</param>
        /// <param name="centerY">Center of the Circle, on the Y axis</param>
        /// <param name="radius">Circle Radius</param>
        private void FillCircle(Graphics g, Brush brush, float centerX, float centerY, float radius)
        {
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath())
            {
                g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
            }
        }

        #endregion
    }
}
