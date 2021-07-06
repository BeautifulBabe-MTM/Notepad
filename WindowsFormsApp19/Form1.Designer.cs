using System.Globalization;
using System.Windows.Forms;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace WindowsFormsApp19
{
    partial class Form1
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
        private System.ComponentModel.ComponentResourceManager resources;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.zhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.clearToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.toolStripMenuItem2});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripMenuItem3,
            this.closeAppToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            resources.ApplyResources(this.colorToolStripMenuItem, "colorToolStripMenuItem");
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            resources.ApplyResources(this.fontToolStripMenuItem, "fontToolStripMenuItem");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deDEToolStripMenuItem,
            this.ruToolStripMenuItem,
            this.toolStripMenuItem4,
            this.zhToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // deDEToolStripMenuItem
            // 
            this.deDEToolStripMenuItem.Name = "deDEToolStripMenuItem";
            resources.ApplyResources(this.deDEToolStripMenuItem, "deDEToolStripMenuItem");
            this.deDEToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ruToolStripMenuItem
            // 
            this.ruToolStripMenuItem.Name = "ruToolStripMenuItem";
            resources.ApplyResources(this.ruToolStripMenuItem, "ruToolStripMenuItem");
            this.ruToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // zhToolStripMenuItem
            // 
            this.zhToolStripMenuItem.Name = "zhToolStripMenuItem";
            resources.ApplyResources(this.zhToolStripMenuItem, "zhToolStripMenuItem");
            this.zhToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            resources.ApplyResources(this.saveFileToolStripMenuItem, "saveFileToolStripMenuItem");
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            resources.ApplyResources(this.openFileToolStripMenuItem, "openFileToolStripMenuItem");
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // closeAppToolStripMenuItem
            // 
            this.closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            resources.ApplyResources(this.closeAppToolStripMenuItem, "closeAppToolStripMenuItem");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog dialog = new FontDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    this.textBox1.Font = dialog.Font;
            }
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    this.textBox1.BackColor = dialog.Color;
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "text|*.txt";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                    using (StreamWriter streamWriter = new StreamWriter(saveDialog.FileName))
                        streamWriter.WriteLine(this.textBox1.Text);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo((sender as ToolStripMenuItem).Text);
            foreach (Control c in this.Controls)
                resources.ApplyResources(c, c.Name, ci);

            foreach (ToolStripItem c in menuStrip1.Items)
            {
                foreach (ToolStripItem item in toolStripMenuItem1.DropDownItems)
                    resources.ApplyResources(item, item.Name, ci);
                resources.ApplyResources(c, c.Name, ci);
            }
        }
       
        private string LastTab = string.Empty;
        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem deDEToolStripMenuItem;
        private ToolStripMenuItem ruToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem zhToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem closeAppToolStripMenuItem;
    }
}

