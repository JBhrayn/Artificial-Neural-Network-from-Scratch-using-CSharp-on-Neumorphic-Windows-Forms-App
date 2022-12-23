using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NN_PROGLAN.Interface;
using NN_PROGLAN.Interface.ProgressBar;

namespace NN_PROGLAN.Utils
{
    public static class ThreadHelperClass
    {
        delegate void SetTextCallback(Form f, Control ctrl, string text);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetText(Form form, Control ctrl, string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new (SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }

        delegate void SetImageCallback(Form f, Canvas canvas, Bitmap img);
        public static void SetImage(Form form, Canvas canvas, Bitmap img)
        {
            if (canvas.InvokeRequired)
            {
                SetImageCallback d = new(SetImage);
                form.Invoke(d, new object[] { form, canvas, img });
            }
            else
            {
                canvas.Image = img;
            }
        }
    }
}
