using System.Drawing;
using System.Windows.Forms;

namespace Notepad_WF.Controls
{
    class Menustrip : MenuStrip
    {   
        public ToolStripMenuItem File;
        public ToolStripMenuItem New;
        public ToolStripMenuItem Open;
        public ToolStripMenuItem Save;
        public ToolStripMenuItem SaveAll;
        public ToolStripMenuItem Close;
        public ToolStripMenuItem CloseAll;
        public ToolStripMenuItem Exit;

        public ToolStripMenuItem View;
        public ToolStripMenuItem FontSize;
        public ToolStripMenuItem FontSize50;
        public ToolStripMenuItem FontSize100;
        public ToolStripMenuItem FontSize150;
        public ToolStripMenuItem FontSize200;
        public ToolStripMenuItem IconsMenu;
        public ToolStripMenuItem Enable;
        public ToolStripMenuItem Disable;

        public ToolStripMenuItem Undo;
        public ToolStripMenuItem Redo;


        public Menustrip(NotepadForm form)
        {
            this.Font = form.Font;
            this.BackColor = Color.DodgerBlue;

            Items.AddRange(new ToolStripItem[] { File = new ToolStripMenuItem("File") });

            File.DropDownItems.AddRange(new ToolStripItem[]
            {
                New = new ToolStripMenuItem("New Tab"),
                Open = new ToolStripMenuItem("Open"),
                Save = new ToolStripMenuItem("Save"),
                SaveAll = new ToolStripMenuItem("Save as"),
                Close = new ToolStripMenuItem("Close"),
                CloseAll = new ToolStripMenuItem("Close all"),
                Exit = new ToolStripMenuItem("Exit")
            });

            Items.AddRange(new ToolStripItem[] 
            { 
                View = new ToolStripMenuItem("View"),

            });

            View.DropDownItems.AddRange(new ToolStripItem[]
            {
                FontSize = new ToolStripMenuItem("Font Size"),
                IconsMenu = new ToolStripMenuItem("Icons Bar")
            });

            FontSize.DropDownItems.AddRange(new ToolStripItem[] 
            {
                FontSize50 = new ToolStripMenuItem("50%"),
                FontSize100 = new ToolStripMenuItem("100%"),
                FontSize150 = new ToolStripMenuItem("150%"),
                FontSize200 = new ToolStripMenuItem("200%"),
            });

            IconsMenu.DropDownItems.AddRange(new ToolStripItem[]
            {
                Enable = new ToolStripMenuItem("Enable"),
                Disable = new ToolStripMenuItem("Disable")
            });

            SubMenuColor();
            form.Controls.Add(this);
        }

        private void SubMenuColor()
        {
            New.BackColor = Color.Silver;
            Open.BackColor = Color.Silver;
            Save.BackColor = Color.Silver;
            SaveAll.BackColor = Color.Silver;
            Close.BackColor = Color.Silver;
            CloseAll.BackColor = Color.Silver;
            Exit.BackColor = Color.IndianRed;

            FontSize.BackColor = Color.Silver;
            FontSize50.BackColor = Color.Silver;
            FontSize100.BackColor = Color.Silver;
            FontSize150.BackColor = Color.Silver;
            FontSize200.BackColor = Color.Silver;

            IconsMenu.BackColor = Color.Silver;
            Enable.BackColor = Color.Silver;
            Disable.BackColor = Color.Silver;
        }
    }
}
