namespace NN_PROGLAN.Interface.Neu
{
    public class NeuPanel : Panel
    {
        private Label panelLabel;
        private bool panelLocked;
        private bool panelHovered;
        private Color activeColor = Color.White;
        private Color inactiveColor = Color.FromArgb(150, 150, 150);
        private Bitmap activeImg = Properties.Resources.MenuPanelHovered;
        private Bitmap inactiveImg = Properties.Resources.MenuPanelDefault;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }

        }

        public NeuPanel()
        {
            //this.SetStyle(
            //    System.Windows.Forms.ControlStyles.UserPaint |
            //    System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
            //    System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);
        }
        public bool PanelHovered
        {
            get { return this.panelHovered; }
            set { this.panelHovered = value; }
        }

        public bool PanelLocked
        {
            get { return this.panelLocked; }
            set { this.panelLocked = value; }
        }

        public Label PanelLabel
        {
            get { return panelLabel; }
            set { panelLabel = value; }
        }

        public void SetHandlers()
        {
            SetChildControlHandler(this);
            Leave += new EventHandler(this.OnPanelLeave);
            MouseEnter += new EventHandler(this.OnMouseEnter);
            MouseLeave += new EventHandler(this.OnMouseLeave);
        }

        private void SetChildControlHandler(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c.GetType() == typeof(NeuTextBox) || c.GetType() == typeof(TextBox))
                    c.MouseDown += new MouseEventHandler(this.OnMouseDown);
                SetChildControlHandler(c);
            };
        }

        public void Deactivate()
        {
            BackgroundImage = inactiveImg;
            panelLabel.ForeColor = inactiveColor;
        }

        public void Activate()
        {
            BackgroundImage = activeImg;
            panelLabel.ForeColor = activeColor;
        }

        private void OnMouseEnter(Object? sender, EventArgs e)
        {
            if (!panelHovered)
            {
                panelHovered = true;
                Activate();
            }

        }

        private void OnMouseLeave(Object? sender, EventArgs e)
        {
            if (GetChildAtPoint(PointToClient(MousePosition)) == null && !panelLocked)
            {
                panelHovered = false;
                Deactivate();
            }
        }

        private void OnPanelLeave(Object? sender, EventArgs e)
        {
            panelLocked = false;
            Deactivate();
        }

        private void OnMouseDown(Object? sender, MouseEventArgs e)
        {
            Control c = (Control)sender;
            NeuPanel? np = null;

            if (c.GetType() == typeof(TextBox))
                np = (NeuPanel)c.Parent.Parent;
            else if (c.GetType() == typeof(NeuTextBox))
                np = (NeuPanel)c.Parent;

            np.PanelLocked = true;
            np.Activate();
        }
    }
}