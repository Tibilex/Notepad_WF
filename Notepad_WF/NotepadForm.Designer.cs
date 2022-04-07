using System.Drawing;
using System.Windows.Forms;

namespace Notepad_WF
{
    partial class NotepadForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.customTabControl1 = new Notepad_WF.Controls.CustomTabControl();
            this.SuspendLayout();
            // 
            // customTabControl1
            // 
            this.customTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.customTabControl1.Font = new System.Drawing.Font("Gadugi", 10F);
            this.customTabControl1.ItemSize = new System.Drawing.Size(80, 20);
            this.customTabControl1.Location = new System.Drawing.Point(0, 0);
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.Padding = new System.Drawing.Point(17, 2);
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(1008, 729);
            this.customTabControl1.TabIndex = 1;
            // 
            // NotepadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.customTabControl1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "NotepadForm";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.NotepadForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Notepad_WF.Controls.CustomTabControl customTabControl1;
    }
}

