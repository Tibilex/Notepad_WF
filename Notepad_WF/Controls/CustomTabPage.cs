using System.Drawing;
using System.Windows.Forms;

namespace Notepad_WF.Controls
{
    class CustomTabPage : TabPage
    {
        TextBox textBox;

        public TextBox TextBox
        {
            get { return textBox; }
            set { textBox = value; }
        }
        //SaveFileDialog saveFileDialog;

        public CustomTabPage(string title, string textboxText = "")
        {
            this.Name = title;
            this.BackColor = Color.Tomato;
            this.Text = title;
            this.Font = new Font("Gadugi", 9F, FontStyle.Regular);
            

            textBox = new TextBox()
            { 
                Size = ClientSize,
                Dock = DockStyle.Fill,
                Multiline = true,
                Text = textboxText,
                Name = "textBox",
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Gadugi", 10F, FontStyle.Regular),
            };
            Controls.Add(textBox);
        }

        public CustomTabPage() : this("NewTab", "")
        {

        }

    }
}
