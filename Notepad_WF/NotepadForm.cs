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

        Image CloseImage;
        Image AddImage;

        //Point _imageLocation = new Point(20, 4);
        Point imageHitArea = new Point(20, 4);

        public NotepadForm()
        {
            InitializeComponent(); 
            this.StartPosition = FormStartPosition.CenterScreen;
            customTabControl1.Controls.Add(new CustomTabPage());
            customTabControl1.Controls.Add(new CustomTabPage());
        }

        private void NotepadForm_Load(object sender, EventArgs e)
        {
            this.Font = new Font("Gadugi", 10F, FontStyle.Regular);
            menuStrip1.Font = this.Font;
            menuStrip1.BackColor = Color.Coral;
            
            //CloseImage = Properties.Resources.Del;
            //AddImage = Properties.Resources.Add;
            //AddTab();
        }

     
    }
}
