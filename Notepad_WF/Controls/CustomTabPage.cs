﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad_WF
{
    class CustomTabPage : TabPage
    {
        TextBox textBox;
        //SaveFileDialog saveFileDialog;

        public CustomTabPage(string title, string textboxText = "")
        {
            this.Name = title;
            this.BackColor = Color.Tomato;
            this.Text = title;
            this.Font = new Font("Gadugi", 9F, FontStyle.Bold);

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
            //saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.Rename);
        }

        public CustomTabPage() : this("NewTab", "")
        {

        }

    }
}
