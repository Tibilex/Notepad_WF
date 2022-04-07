using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notepad_WF.Controls
{
    class CustomTabControl : TabControl
    {
        public CustomTabControl()
        {
            this.Dock = DockStyle.Fill;
            this.Location = new Point(0, 24);
            this.SizeMode = TabSizeMode.Normal;
            this.ItemSize = new Size(80, 20);
            this.Size = ClientSize;
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.Font = new Font("Gadugi", 10F, FontStyle.Regular);
            this.SelectedIndex = 0;
            this.Name = "TabControl";
            this.Padding = new Point(17, 2);

            DrawItem += CustomTabControl_DrawItem;
            MouseClick += CustomTabControl_MouseClick;

            this.Controls.Add(new CustomTabPage($"NewTab{this.TabIndex}"));
        }


        private void CustomTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image img = Properties.Resources.Del;
            if (e.Index == this.TabPages.Count - 1)
            {
                img = Properties.Resources.Add;
            }
            else { img = Properties.Resources.Del; }

            Rectangle rect = GetTabRect(e.Index);
            rect.Inflate(-3, 2);

            SolidBrush pen = new SolidBrush(Color.Black);
            string text = this.TabPages[e.Index].Text;

            e.Graphics.DrawImage(img, rect.Right - img.Width, rect.Y + 5);
            e.Graphics.DrawString(text, this.Font, pen, new PointF(rect.X + 3, rect.Y + 3));
        }
        private void CustomTabControl_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            Point point = e.Location;
            int rectWidth = 0;

            rectWidth = this.GetTabRect(this.SelectedIndex).Width - 15;
            Rectangle rect = this.GetTabRect(this.SelectedIndex);
            rect.Offset(rectWidth - 4, 2);
            rect.Width = 15;
            rect.Height = 15;

            if (this.SelectedIndex == this.TabPages.Count - 1)
            {
                this.TabPages.Add(new CustomTabPage($"NewTab{this.SelectedIndex + 1}"));
            }
            else
            {
                if (rect.Contains(point))
                {
                    TabPage tabPage = this.TabPages[(int)this.SelectedIndex];
                    this.TabPages.Remove(tabPage);
                }
            }
        }
    }
}
