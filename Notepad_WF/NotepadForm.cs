using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Notepad_WF
{   
    public partial class NotepadForm : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();  

        public NotepadForm()
        {
            InitializeComponent(); 
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void NotepadForm_Load(object sender, EventArgs e)
        {
            this.Font = new Font("Gadugi", 10F, FontStyle.Regular);
            menuStrip1.Font = this.Font;
            menuStrip1.BackColor = Color.Coral;

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customTabControl1.TabPages.Add(new CustomTabPage($"NewTab{customTabControl1.TabCount + 1}"));
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customTabControl1.TabPages.Remove(customTabControl1.SelectedTab);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            string text = File.ReadAllText(openFileDialog1.FileName);
            customTabControl1.Controls.Add(new CustomTabPage(Path.GetFileName(openFileDialog1.FileName), text));

        }

    }
}
