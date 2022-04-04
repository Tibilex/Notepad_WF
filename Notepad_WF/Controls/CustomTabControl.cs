using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notepad_WF
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

            DrawItem += CustomTabControl_DrawItem;
            MouseClick += CustomTabControl_MouseClick;
        }

        private void CustomTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = TabPages[e.Index];
            Rectangle rect = GetTabRect(e.Index);
            rect.Inflate(-2, -2);

            var closeImage = Properties.Resources.Del;
            SolidBrush pen = new SolidBrush(Color.Black);

            e.Graphics.DrawImage(closeImage,(rect.Right - closeImage.Width), rect.Top + (rect.Height - closeImage.Height) / 2);
            e.Graphics.DrawString(tabPage.Text, this.Font, pen, new PointF(rect.X, rect.Y));
            
        }
        private void CustomTabControl_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
