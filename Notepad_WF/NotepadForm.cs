using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_WF
{
    public partial class NotepadForm : Form
    {
        public NotepadForm()
        {
            InitializeComponent();
            //menuStrip1.Visible = false;
        }

        private void NotepadForm_Load(object sender, EventArgs e)
        {
            this.tabControl.Controls.Add(new TabPages("srart", "test"));
            this.tabControl.Controls.Add(new TabPages("srart2", "test"));
            this.tabControl.Controls.Add(new TabPages("srart3", "test"));
            this.tabControl.Controls.Add(new TabPages());
            this.tabControl.Controls.Add(new TabPages());
        }
    }
}
