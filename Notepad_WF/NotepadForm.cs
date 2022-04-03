using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad_WF
{   
    public partial class NotepadForm : Form
    {
        public NotepadForm()
        {
            InitializeComponent(); 

        }

        private void NotepadForm_Load(object sender, EventArgs e)
        {
            this.tabControl.Size = ClientSize;
            menuStrip1.Font = new Font("Gadugi", 10F, FontStyle.Regular);
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPages newPage = new TabPages();
            this.tabControl.Controls.Add(newPage);
            newPage.BackColor = Color.Tomato;
        }
    }
}
