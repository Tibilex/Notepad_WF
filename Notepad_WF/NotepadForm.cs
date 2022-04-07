using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Notepad_WF.Controls;

namespace Notepad_WF
{
    public partial class NotepadForm : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        ToolStrip toolStrip = new ToolStrip();

        public NotepadForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            toolStrip.Location = new Point(0, 48);
            AddIconBar();
            toolStrip.Visible = false;
        }

        #region - Events -
        private void NotepadForm_Load(object sender, EventArgs e)
        {
            this.Font = new Font("Gadugi", 10F, FontStyle.Regular);
            menuStrip1.Font = this.Font;
            menuStrip1.BackColor = Color.Coral;

        }

        // Open file and add to new tab
        private void Open(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            string text = File.ReadAllText(openFileDialog1.FileName);
            customTabControl1.Controls.Add(new CustomTabPage(Path.GetFileName(openFileDialog1.FileName), text));
        }

        // Close current tab
        private void Close(object sender, EventArgs e)
        {
            customTabControl1.TabPages.Remove(customTabControl1.SelectedTab);
        }

        // Create new tab
        private void NewTab(object sender, EventArgs e)
        {
            customTabControl1.TabPages.Add(new CustomTabPage($"NewTab{customTabControl1.TabCount + 1}"));
        }

        // Close all tabs
        private void CloseAll(object sender, EventArgs e)
        {
            customTabControl1.TabPages.Clear();
        }

        // Save to file
        private void SaveAs(object sender, EventArgs e)
        {
            CustomTabPage tabPage = (CustomTabPage)customTabControl1.SelectedTab;

            if (tabPage.TextBox.Text != "")
            {
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog1.ShowDialog();

                string path = saveFileDialog1.FileName;
                if (path != "")
                {
                    File.WriteAllText(path, tabPage.TextBox.Text);
                    string[] array = path.Split('\\');
                    tabPage.Text = array[array.Length - 1];
                }
                saveFileDialog1.Reset();
            }
        }

        // Exit
        private void Exit(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Do you want Exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // Text font size 50%
        private void FontSize50(object sender, EventArgs e)
        {
            foreach(CustomTabPage it in customTabControl1.TabPages)
            {
                it.TextBox.Font = new Font("Gadugi", 7F, FontStyle.Regular);
            }
        }
        // Text font size 100%
        private void FontSize100(object sender, EventArgs e)
        {
            foreach (CustomTabPage it in customTabControl1.TabPages)
            {
                it.TextBox.Font = new Font("Gadugi", 10F, FontStyle.Regular);
            }
        }
        // Text font size 150%
        private void FontSize150(object sender, EventArgs e)
        {
            foreach (CustomTabPage it in customTabControl1.TabPages)
            {
                it.TextBox.Font = new Font("Gadugi", 15F, FontStyle.Regular);
            }
        }
        // Text font size 200%
        private void FontSize200(object sender, EventArgs e)
        {
            foreach (CustomTabPage it in customTabControl1.TabPages)
            {
                it.TextBox.Font = new Font("Gadugi", 20F, FontStyle.Regular);
            }
        }

        private void EnableIconMenu(object sender, EventArgs e) { toolStrip.Visible = true; }
        private void DisableIconMenu(object sender, EventArgs e) { toolStrip.Visible = false; }

        #endregion

        #region - Methods -

        private void AddIconBar()
        {
            toolStrip.Items.Add("", Properties.Resources.AddBlue, NewTab);
            toolStrip.Items.Add("", Properties.Resources.OpenBlue, Open);
            //toolStrip.Items.Add("", Properties.Resources.Save, Save);
            toolStrip.Items.Add("", Properties.Resources.SaveBlue, SaveAs);
            toolStrip.Items.Add("", Properties.Resources.CloseBlue, Close);
            toolStrip.Items.Add("", Properties.Resources.CloseallBlue, CloseAll);
            //toolStrip.Items.Add("", Properties.Resources.Print, Print);
            toolStrip.Items.Add(new ToolStripSeparator());
            //toolStrip.Items.Add("", Properties.Resources.Cut, Cut);
            //toolStrip.Items.Add("", Properties.Resources.Copy, Copy);
            //toolStrip.Items.Add("", Properties.Resources.Paste, Paste);
            //toolStrip.Items.Add(new ToolStripSeparator());
            //toolStrip.Items.Add("", Properties.Resources.Undo, Undo);
            //toolStrip.Items.Add("", Properties.Resources.Redo, Redo);
            Controls.Add(toolStrip);
        }

        #endregion
    }
}
