using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad_WF
{
    class TabPages : TabPage
    {
        public TabPages(string title, string textboxText = "")
        {
            this.Text = title;
            
            Controls.Add(new TextBox() 
            { 
                Size = new Size(this.Size.Width, this.Size.Height - 40),
                Multiline = true,
                Text = textboxText,
            });
        }
        public TabPages() : this($"NewTab{1}", "")
        {

        }
    }
}
