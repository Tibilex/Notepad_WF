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
        Menustrip menustrip;

        public NotepadForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Gadugi", 10F, FontStyle.Regular);

            toolStrip.Visible = false;
        }

        #region - Events -
        private void NotepadForm_Load(object sender, EventArgs e)
        {
            AddIconBar();

            menustrip = new Menustrip(this);
            menustrip.New.Click += new EventHandler(NewTab);
            menustrip.Open.Click += new EventHandler(Open);
            //menustrip.Save.Click += new EventHandler(Save);
            menustrip.SaveAll.Click += new EventHandler(SaveAs);
            menustrip.Close.Click += new EventHandler(Close);
            menustrip.CloseAll.Click += new EventHandler(CloseAll);
            menustrip.Exit.Click += new EventHandler(Exit);
            menustrip.FontSize50.Click += new EventHandler(FontSize50);
            menustrip.FontSize100.Click += new EventHandler(FontSize100);
            menustrip.FontSize150.Click += new EventHandler(FontSize150);
            menustrip.FontSize200.Click += new EventHandler(FontSize200);
            menustrip.Enable.Click += new EventHandler(EnableIconMenu);
            menustrip.Disable.Click += new EventHandler(DisableIconMenu);
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
            toolStrip.Items.Add(new ToolStripSeparator());
            Controls.Add(toolStrip);
        }

        #endregion
    }
}
