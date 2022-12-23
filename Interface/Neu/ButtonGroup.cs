using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_PROGLAN.Interface.Neu
{
    public class ButtonGroup
    {
        private List<NeuButton> buttons = new List<NeuButton>();
        public void Add(NeuButton button)
        {
            button.OnMouseDown(new MouseEventHandler(this.OnMouseClick));
            buttons.Add(button);
        }

        private void OnMouseClick(Object sender, MouseEventArgs e)
        {
            Control c = (Control)sender;
            NeuButton button = (NeuButton)c.Parent;

            foreach (NeuButton btn in buttons)
                if (btn != button)
                    btn.Deselect();

            button.Lock(isLocked: true);



        }

        public NeuButton GetToggled()
        {
            foreach (NeuButton btn in buttons)
                if (btn.Toggled == true)
                    return btn;

            return null;
        }
       
    }
}
