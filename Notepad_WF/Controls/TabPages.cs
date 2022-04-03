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
            this.Name = title;
            
            this.Text = title;;
            Controls.Add(new TextBox() 
            { 
                Size = ClientSize,
                Multiline = true,
                Text = textboxText,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            });
        }

        public TabPages() : this($"NewTab", "")
        {

        }
    }
}
